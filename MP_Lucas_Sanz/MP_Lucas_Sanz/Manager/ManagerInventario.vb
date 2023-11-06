Imports System.Data.SqlClient
Imports MP_Lucas_Sanz.VariablesGlobales

Public Class ManagerInventario
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaInventario As List(Of Inventario) = New List(Of Inventario)
    Private listaArticulo As List(Of Articulo) = New List(Of Articulo)
    Dim inventarioTemp As Inventario
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Sub New()
        MyBase.New()
    End Sub

    Public Function getInventario() As List(Of Inventario)
        listaInventario = New List(Of Inventario)

        cmd = New SqlCommand("SELECT * FROM INVENTARIOS;", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Do
                inventarioTemp = New Inventario(Convert.ToInt32(dr(0)), Convert.ToInt32(dr(1)), Convert.ToInt32(dr(2)))
                listaInventario.Add(inventarioTemp)
            Loop While dr.Read()
            dr.Close()
        End If
        dr.Close()
        Return listaInventario
    End Function
    Public Function getInventario(codigoInventario As Integer) As Inventario
        cmd = New SqlCommand("SELECT * FROM INVENTARIOS WHERE ID_INVENTARIO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = codigoInventario
        Try
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                Dim inventarioTemp As Inventario = New Inventario(Convert.ToInt32(dr(0)), Convert.ToInt32(dr(1)), Convert.ToInt32(dr(2)))
                dr.Close()
                Return inventarioTemp
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Return Nothing
    End Function
    Public Sub setUnidades(cantidadNueva As Integer, articuloPasado As Integer)
        cmd = New SqlCommand("UPDATE INVENTARIOS SET
                            UNIDADES_INVENTARIO = @Cantidad
                            WHERE ID_ARTICULO = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Cantidad", SqlDbType.Int).Value = cantidadNueva
            .Add("@Codigo", SqlDbType.Int).Value = articuloPasado
        End With
        Try
            cmd.ExecuteNonQuery()
            updateListaInventarios()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub addUnidades(cantidadSumar As Integer, articuloPasado As Integer)
        cmd = New SqlCommand("UPDATE INVENTARIOS SET 
                            UNIDADES_INVENTARIO = UNIDADES_INVENTARIO + @CantidadSumar
                            WHERE ID_ARTICULO = @CodigoArticulo;", connectionDBManager)
        With cmd.Parameters
            .Add("@CantidadSumar", SqlDbType.Int).Value = cantidadSumar
            .Add("@CodigoArticulo", SqlDbType.Int).Value = articuloPasado
        End With
        Try
            cmd.ExecuteNonQuery()
            updateListaInventarios()
        Catch ex As Exception
            MessageBox.Show("Error al añadir unidades: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteUnidades(cantidadRestar As Integer, articuloPasado As Integer)
        cmd = New SqlCommand("SELECT UNIDADES_INVENTARIO FROM INVENTARIOS 
                            WHERE ID_ARTICULO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = articuloPasado
        Dim cantidadObject As Object = cmd.ExecuteScalar
        Dim unidadesDisponibles As Integer = Convert.ToInt32(cantidadObject)

        If unidadesDisponibles - cantidadRestar < 0 Then
            frmConfirmacionUnidadesNegativas.ShowDialog()
            If Not frmConfirmacionUnidadesNegativas.respuesta Then
                Return
            End If
        End If
        cmd = New SqlCommand("UPDATE INVENTARIOS SET 
                            UNIDADES_INVENTARIO = UNIDADES_INVENTARIO - @CantidadRestar
                            WHERE ID_ARTICULO = @CodigoArticulo;", connectionDBManager)
        With cmd.Parameters
            .Add("@CantidadRestar", SqlDbType.Int).Value = cantidadRestar
            .Add("@CodigoArticulo", SqlDbType.Int).Value = articuloPasado
        End With
        Try
            cmd.ExecuteNonQuery()
            updateListaInventarios()
        Catch ex As Exception
            MessageBox.Show("Error al restar unidades: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub addInventario(inventarioPasado As Inventario)
        Dim codigoNuevo As Integer = getIDInventario()
        cmd = New SqlCommand("INSERT INTO INVENTARIOS
                            VALUES (@CodigoInventario, @Articulo, @UnidadesDisponibles);", connectionDBManager)
        With cmd.Parameters
            .Add("@CodigoInventario", SqlDbType.Int).Value = codigoNuevo
            .Add("@Articulo", SqlDbType.Int).Value = inventarioPasado.ArticuloDeInventario.CodigoDeArticulo
            .Add("@UnidadesDisponibles", SqlDbType.Int).Value = inventarioPasado.UnidadesDisponibles
        End With
        Try
            cmd.ExecuteNonQuery()
            updateListaInventarios()
        Catch ex As Exception
            MessageBox.Show("Error al introducir unidades: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteInventario(inventarioPasado As Inventario)
        cmd = New SqlCommand("DELETE FROM INVENTARIOS 
                            WHERE ID_INVENTARIO = @CodigoInventario;", connectionDBManager)
        cmd.Parameters.Add("@CodigoInventario", SqlDbType.Int).Value = inventarioPasado.CodigoDeInventario
        Try
            cmd.ExecuteNonQuery()
            updateListaInventarios()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar unidades: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteInventarioArticulo(codigoArticulo As Integer)
        cmd = New SqlCommand("DELETE FROM INVENTARIOS 
                            WHERE ID_ARTICULO = @CodigoInventario;", connectionDBManager)
        cmd.Parameters.Add("@CodigoInventario", SqlDbType.Int).Value = codigoArticulo
        Try
            cmd.ExecuteNonQuery()
            updateListaInventarios()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar unidades: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Function checkInventario(articuloPasado As Articulo) As Boolean
        cmd = New SqlCommand("SELECT * FROM INVENTARIOS WHERE
                            ID_ARTICULO = @Articulo;", connectionDBManager)
        cmd.Parameters.Add("@Articulo", SqlDbType.Int).Value = articuloPasado.CodigoDeArticulo
        Try
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Close()
                Return True
            Else
                dr.Close()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Return False
    End Function
    Public Function checkStock(codigoArticulo As Integer)
        cmd = New SqlCommand("SELECT UNIDADES_INVENTARIO FROM INVENTARIOS WHERE ID_ARTICULO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = codigoArticulo
        Try
            Dim maxActual As Object = cmd.ExecuteScalar
            If maxActual IsNot DBNull.Value Then
                Dim stockActual As Integer = Convert.ToInt32(maxActual)
                Return stockActual
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Return Nothing
    End Function
    Public Function getIDInventario() As Integer
        cmd = New SqlCommand("SELECT MAX(ID_INVENTARIO) FROM INVENTARIOS;", connectionDBManager)
        Dim maxActual As Object = cmd.ExecuteScalar()
        Dim codigoInventarioNuevo As Integer = Nothing
        If maxActual IsNot DBNull.Value Then
            codigoInventarioNuevo = Convert.ToInt32(maxActual) + 1
        Else
            codigoInventarioNuevo = 0
        End If
        Return codigoInventarioNuevo
    End Function
End Class
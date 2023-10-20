Imports System.Data.SqlClient

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
        listaArticulo = managerArticuloAux.getArticulos()
        Dim articuloFind As Articulo

        cmd = New SqlCommand("SELECT * FROM INVENTARIOS;", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Do
                articuloFind = listaArticulo.Find(Function(art) art.CodigoDeArticulo = Convert.ToInt32(dr(1)))
                inventarioTemp = New Inventario(Convert.ToInt32(dr(0)), articuloFind.NombreDeArticulo, Convert.ToInt32(dr(2)))
                listaInventario.Add(inventarioTemp)
            Loop While dr.Read()
            dr.Close()
        End If
        dr.Close()
        Return listaInventario
    End Function
    Public Sub addUnidades(cantidadSumar As Integer, inventarioPasado As Inventario)
        cmd = New SqlCommand("UPDATE INVENTARIOS SET 
                            UNIDADES_INVENTARIO = UNIDADES_INVENTARIO + @CantidadSumar
                            WHERE ID_INVENTARIO = @CodigoInventario;", connectionDBManager)
        With cmd.Parameters
            .Add("@CantidadSumar", SqlDbType.Int).Value = cantidadSumar
            .Add("@CodigoInventario", SqlDbType.Int).Value = inventarioPasado.CodigoDeInventario
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al añadir unidades: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteUnidades(cantidadRestar As Integer, inventarioPasado As Inventario)
        If inventarioPasado.UnidadesDisponibles - cantidadRestar < 0 Then
            frmConfirmacionUnidadesNegativas.ShowDialog()
            If Not frmConfirmacionUnidadesNegativas.respuesta Then
                Return
            End If
        End If

        Dim listaArticulos As List(Of Articulo) = managerArticuloAux.getArticulos()
        Dim articuloSeleccionado As Articulo = listaArticulos.Find(Function(art) art.NombreDeArticulo = inventarioPasado.CodigoDeInventario)
        cmd = New SqlCommand("UPDATE INVENTARIOS SET 
                            UNIDADES_INVENTARIO = UNIDADES_INVENTARIO - @CantidadRestar
                            WHERE ID_INVENTARIO = @CodigoInventario;", connectionDBManager)
        With cmd.Parameters
            .Add("@CantidadRestar", SqlDbType.Int).Value = cantidadRestar
            .Add("@CodigoInventario", SqlDbType.Int).Value = inventarioPasado.CodigoDeInventario
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al restar unidades: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub addInventario(inventarioPasado As Inventario)
        cmd = New SqlCommand("INSERT INTO INVENTARIOS
                            VALUES (@Nombre, @Articulo, @UnidadesDisponibles);", connectionDBManager)
        Dim listaArticulos As List(Of Articulo) = managerArticuloAux.getArticulos()
        Dim articuloFind As Articulo = listaArticulos.Find(Function(art) art.NombreDeArticulo = inventarioPasado.NombreDeArticulo)
        With cmd.Parameters
            .Add("@CodigoInventario", SqlDbType.Int).Value = getIDInventario()
            .Add("@Articulo", SqlDbType.Int).Value = articuloFind.CodigoDeArticulo
            .Add("@UnidadesDisponibles", SqlDbType.Int).Value = inventarioPasado.UnidadesDisponibles
        End With
        Try
            cmd.ExecuteNonQuery()
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
        Catch ex As Exception
            MessageBox.Show("Error al eliminar unidades: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Function checkInventario(nombrePasado As String) As Boolean
        cmd = New SqlCommand("SELECT * FROM INVENTARIOS WHERE
                            ID_ARTICULO = @Articulo;", connectionDBManager)
        Dim listaArticulos As List(Of Articulo) = managerArticuloAux.getArticulos()
        Dim articuloFind As Articulo = listaArticulos.Find(Function(art) art.NombreDeArticulo = nombrePasado)
        cmd.Parameters.Add("@Articulo", SqlDbType.Int).Value = articuloFind.CodigoDeArticulo
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Close()
            Return True
        Else
            dr.Close()
            Return False
        End If
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
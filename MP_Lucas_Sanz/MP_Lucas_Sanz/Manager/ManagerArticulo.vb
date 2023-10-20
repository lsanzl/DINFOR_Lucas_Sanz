Imports System.Data.SqlClient

Public Class ManagerArticulo
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaArticulos As List(Of Articulo) = New List(Of Articulo)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Function getArticulos() As List(Of Articulo)
        listaArticulos = New List(Of Articulo)
        cmd = New SqlCommand("SELECT * FROM ARTICULOS;", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Dim codigoArticulo As Integer
            Dim familiaArticulo As Integer
            Dim nombreArticulo As String
            Dim descripcionArticulo As String
            Dim pvpCompraArticulo As Double
            Dim porcBeneficioArticulo As Double
            Dim tipoUnidadArticulo As String

            dr.Read()
            Do
                codigoArticulo = Convert.ToInt32(dr(0))
                familiaArticulo = Convert.ToInt32(dr(1))
                nombreArticulo = dr(2).ToString().Trim()
                descripcionArticulo = dr(3).ToString().Trim()
                pvpCompraArticulo = Convert.ToDouble(dr(4))
                porcBeneficioArticulo = Convert.ToDouble(dr(5))
                tipoUnidadArticulo = dr(6).ToString().Trim()

                articuloAux = New Articulo(codigoArticulo, nombreArticulo, descripcionArticulo,
                                            pvpCompraArticulo, porcBeneficioArticulo, tipoUnidadArticulo, familiaArticulo)

                listaArticulos.Add(articuloAux)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaArticulos
    End Function
    Public Sub addArticulo(articuloPasado As Articulo)
        cmd = New SqlCommand("INSERT INTO ARTICULOS VALUES (@Codigo, @Familia, @Nombre, 
                            @Descripcion, @PVPCompra, @PorcentajeBeneficio, @TipoUnidad);", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = getIDArticulo()
            .Add("@Familia", SqlDbType.Int).Value = articuloPasado.FamiliaDeArticulo
            .Add("@Nombre", SqlDbType.Char, 100).Value = articuloPasado.NombreDeArticulo
            .Add("@Descripcion", SqlDbType.Char, 150).Value = articuloPasado.DescripcionDeArticulo
            .Add("@PVPCompra", SqlDbType.Decimal, 10, 2).Value = articuloPasado.PVPCompraDeArticulo
            .Add("@PorcentajeBeneficio", SqlDbType.Decimal, 5, 2).Value = articuloPasado.PorcentajeDeBeneficio
            .Add("@TipoUnidad", SqlDbType.Char, 50).Value = articuloPasado.TipoDeUnidadArticulo
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al introducir nuevo Artículo: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub modifyArticulo(articuloPasado As Articulo)
        cmd = New SqlCommand($"UPDATE ARTICULOS
                            SET ID_FAMILIA = @Familia,
                            NOMBRE_ARTICULO = @Nombre,
                            DESCRIPCION_ARTICULO = @Descripcion,
                            PRECIO_COMPRA_ARTICULO = @PVPCompra,
                            PORC_BENEFICIO_ARTICULO = @PorcentajeBeneficio,
                            TIPO_UNIDAD = @TipoUnidad                          
                            WHERE ID_ARTICULO = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = articuloPasado.CodigoDeArticulo
            .Add("@Familia", SqlDbType.Int).Value = articuloPasado.FamiliaDeArticulo
            .Add("@Nombre", SqlDbType.Char, 100).Value = articuloPasado.NombreDeArticulo
            .Add("@Descripcion", SqlDbType.Char, 150).Value = articuloPasado.DescripcionDeArticulo
            .Add("@PVPCompra", SqlDbType.Decimal, 10, 2).Value = articuloPasado.PVPCompraDeArticulo
            .Add("@PorcentajeBeneficio", SqlDbType.Decimal, 5, 2).Value = articuloPasado.PorcentajeDeBeneficio
            .Add("@TipoUnidad", SqlDbType.Char, 50).Value = articuloPasado.TipoDeUnidadArticulo
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al modificar nuevo Artículo: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteArticulo(articuloPasado As Articulo)
        cmd = New SqlCommand($"DELETE FROM ARTICULOS WHERE ID_ARTICULO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = articuloPasado.CodigoDeArticulo
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el artículo: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Function getCampoArticulo(codigoArticulo As String, campoArticulo As String) As String
        cmd = New SqlCommand($"SELECT {campoArticulo} FROM ARTICULOS WHERE ID_ARTICULO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = codigoArticulo
        Dim campoObtenido As Object = cmd.ExecuteScalar()
        Dim campoTemp As String
        If campoObtenido IsNot DBNull.Value Then
            campoTemp = campoObtenido.ToString()
            Return campoTemp
        End If
        Return Nothing
    End Function
    'Public Function getIDArticulo(nombreArticulo As String) As Integer
    '    cmd = New SqlCommand($"SELECT ID_ARTICULO FROM ARTICULOS WHERE NOMBRE_ARTICULO = @Nombre;", connectionDBManager)
    '    cmd.Parameters.Add("@Nombre", SqlDbType.Char, 100).Value = nombreArticulo
    '    Dim campoObtenido As Object = cmd.ExecuteScalar()
    '    Dim campoTemp As String
    '    If campoObtenido IsNot DBNull.Value Then
    '        campoTemp = Convert.ToInt32(campoObtenido)
    '        Return campoTemp
    '    End If
    '    Return Nothing
    'End Function
    Public Function getIDArticulo() As Integer
        cmd = New SqlCommand("SELECT MAX(ID_ARTICULO) FROM ARTICULOS;", connectionDBManager)
        Dim maxActual As Object = cmd.ExecuteScalar()
        Dim codigoArticuloNuevo As Integer = Nothing
        If maxActual IsNot DBNull.Value Then
            codigoArticuloNuevo = Convert.ToInt32(maxActual) + 1
        Else
            codigoArticuloNuevo = 0
        End If
        Return codigoArticuloNuevo
    End Function
End Class
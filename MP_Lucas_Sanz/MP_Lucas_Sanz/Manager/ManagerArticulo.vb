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
            Dim codigoArticulo As String
            Dim nombreArticulo As String
            Dim descripcionArticulo As String
            Dim pvpCompraArticulo As Double
            Dim porcBeneficioArticulo As Double
            Dim tipoUnidadArticulo As String
            Dim familiaArticulo As String

            dr.Read()
            Do
                codigoArticulo = dr(0).ToString()
                nombreArticulo = dr(1).ToString()
                descripcionArticulo = dr(2).ToString()
                pvpCompraArticulo = Convert.ToDouble(dr(3))
                porcBeneficioArticulo = Convert.ToDouble(dr(4))
                tipoUnidadArticulo = dr(5).ToString()
                familiaArticulo = dr(6).ToString()

                articuloAux = New Articulo(codigoArticulo, nombreArticulo, descripcionArticulo,
                                            pvpCompraArticulo, porcBeneficioArticulo, tipoUnidadArticulo, familiaArticulo)

                listaArticulos.Add(articuloAux)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaArticulos
    End Function

    Public Sub addArticulo(articuloPasado As Articulo)
        Dim pvpCompraConPunto As String = Replace(articuloPasado.PVPCompraDeArticulo.ToString(), ",", ".")
        Dim porcBeneficioConPunto As String = Replace(articuloPasado.PorcentajeDeBeneficio.ToString(), ",", ".")

        cmd = New SqlCommand($"INSERT INTO ARTICULOS
                    VALUES ('{articuloPasado.CodigoDeArticulo}', '{articuloPasado.NombreDeArticulo}', 
                    '{articuloPasado.DescripcionDeArticulo}', {pvpCompraConPunto}, 
                    {porcBeneficioConPunto}, '{articuloPasado.TipoDeUnidadArticulo}',
                    '{articuloPasado.FamiliaDeArticulo}');", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Artículo creado")
        Else
            MessageBox.Show("Artículo no creado")
        End If
    End Sub
    Public Sub modifyArticulo(articuloPasado As Articulo)
        Dim pvpCompraConPunto As String = Replace(articuloPasado.PVPCompraDeArticulo.ToString(), ",", ".")
        Dim porcBeneficioConPunto As String = Replace(articuloPasado.PorcentajeDeBeneficio.ToString(), ",", ".")

        cmd = New SqlCommand($"UPDATE ARTICULOS
                            SET NOMBREARTICULO = '{articuloPasado.NombreDeArticulo}',
                            DESCRIPCIONARTICULO = '{articuloPasado.DescripcionDeArticulo}',
                            PVPCOMPRAARTICULO = {pvpCompraConPunto},
                            PORCBENEFICIOARTICULO = {porcBeneficioConPunto},
                            TIPOUNIDADARTICULO = '{articuloPasado.TipoDeUnidadArticulo}',
                            FAMILIAARTICULO = '{articuloPasado.FamiliaDeArticulo}'
                            WHERE CODIGOARTICULO = '{articuloPasado.CodigoDeArticulo}';", connectionDBManager)
        If cmd.ExecuteNonQuery > 0 Then
            MessageBox.Show("Artículo modificado")
        Else
            MessageBox.Show("Artículo no modificado")
        End If
    End Sub
    Public Sub deleteArticulo(articuloPasado As Articulo)
        cmd = New SqlCommand($"DELETE FROM ARTICULOS WHERE CODIGOARTICULO = '{articuloPasado.CodigoDeArticulo}';", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Artículo eliminado")
        Else
            MessageBox.Show("Artículo no eliminado")
        End If
    End Sub
    Public Function getCampoArticulo(codigoArticulo As String, campoArticulo As String) As String
        cmd = New SqlCommand($"SELECT {campoArticulo} FROM ARTICULOS WHERE CODIGOARTICULO = '{codigoArticulo}';", connectionDBManager)
        dr = cmd.ExecuteReader()
        Dim campoTemp As String
        If dr.HasRows Then
            dr.Read()
            campoTemp = dr(0).ToString()
            dr.Close()
            Return campoTemp
        End If
        Return Nothing
    End Function
    Public Function checkArticulo(codigoPasado As String) As Boolean
        cmd = New SqlCommand($"SELECT * FROM ARTICULOS WHERE CODIGOARTICULO = '{codigoPasado}';", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Close()
            Return True
        Else
            dr.Close()
            Return False
        End If
    End Function
End Class
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
            Dim impuestoArticulo As Double

            dr.Read()
            Do
                codigoArticulo = Convert.ToInt32(dr(0))
                familiaArticulo = Convert.ToInt32(dr(1))
                nombreArticulo = dr(2).ToString().Trim()
                descripcionArticulo = dr(3).ToString().Trim()
                pvpCompraArticulo = Convert.ToDouble(dr(4))
                porcBeneficioArticulo = Convert.ToDouble(dr(5))
                tipoUnidadArticulo = dr(6).ToString().Trim()
                impuestoArticulo = Convert.ToDouble(dr(7))

                articuloAux = New Articulo(codigoArticulo, nombreArticulo, descripcionArticulo,
                                            pvpCompraArticulo, porcBeneficioArticulo, tipoUnidadArticulo, familiaArticulo, impuestoArticulo)

                listaArticulos.Add(articuloAux)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaArticulos
    End Function
    Public Sub addArticulo(articuloPasado As Articulo)
        If Not checkNombreUnique(articuloPasado.NombreDeArticulo) Then
            MessageBox.Show("Ya existe un artículo con ese nombre, no puede repetirse")
            Return
        End If
        Dim codigoNuevo As Integer = getIDArticulo()
        cmd = New SqlCommand("INSERT INTO ARTICULOS VALUES 
                            (@Codigo, 
                            @Familia, 
                            @Nombre, 
                            @Descripcion, 
                            @PVPCompra, 
                            @PorcentajeBeneficio, 
                            @TipoUnidad,
                            @Impuesto);", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = codigoNuevo
            .Add("@Familia", SqlDbType.Int).Value = articuloPasado.FamiliaDeArticulo
            .Add("@Nombre", SqlDbType.Char, 100).Value = articuloPasado.NombreDeArticulo
            .Add("@Descripcion", SqlDbType.Char, 150).Value = articuloPasado.DescripcionDeArticulo
            .Add("@PVPCompra", SqlDbType.Decimal, 10, 2).Value = articuloPasado.PVPCompraDeArticulo
            .Add("@PorcentajeBeneficio", SqlDbType.Decimal, 5, 2).Value = articuloPasado.PorcentajeDeBeneficio
            .Add("@TipoUnidad", SqlDbType.Char, 50).Value = articuloPasado.TipoDeUnidadArticulo
            .Add("@Impuesto", SqlDbType.Decimal, 5, 2).Value = articuloPasado.ImpuestoDeArticulo
        End With
        Try
            cmd.ExecuteNonQuery()
            VariablesGlobales.updateListaArticulos()
        Catch ex As Exception
            MessageBox.Show("Error al introducir nuevo Artículo: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub modifyArticulo(articuloPasado As Articulo)
        cmd = New SqlCommand("UPDATE ARTICULOS
                            SET ID_FAMILIA = @Familia,
                            NOMBRE_ARTICULO = @Nombre,
                            DESCRIPCION_ARTICULO = @Descripcion,
                            PRECIO_COMPRA_ARTICULO = @PVPCompra,
                            PORC_BENEFICIO_ARTICULO = @PorcentajeBeneficio,
                            TIPO_UNIDAD = @TipoUnidad,
                            IMPUESTO_ARTICULO = @Impuesto
                            WHERE ID_ARTICULO = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = articuloPasado.CodigoDeArticulo
            .Add("@Familia", SqlDbType.Int).Value = articuloPasado.FamiliaDeArticulo
            .Add("@Nombre", SqlDbType.Char, 100).Value = articuloPasado.NombreDeArticulo
            .Add("@Descripcion", SqlDbType.Char, 150).Value = articuloPasado.DescripcionDeArticulo
            .Add("@PVPCompra", SqlDbType.Decimal, 10, 2).Value = articuloPasado.PVPCompraDeArticulo
            .Add("@PorcentajeBeneficio", SqlDbType.Decimal, 5, 2).Value = articuloPasado.PorcentajeDeBeneficio
            .Add("@TipoUnidad", SqlDbType.Char, 50).Value = articuloPasado.TipoDeUnidadArticulo
            .Add("@Impuesto", SqlDbType.Decimal, 5, 2).Value = articuloPasado.ImpuestoDeArticulo
        End With
        Try
            cmd.ExecuteNonQuery()
            VariablesGlobales.updateListaArticulos()
        Catch ex As Exception
            MessageBox.Show("Error al modificar nuevo Artículo: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteArticulo(articuloPasado As Articulo)
        Dim dr As DialogResult = MessageBox.Show("Se borrarán datos asociados al registro: compras y ventas, ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (dr = DialogResult.No) Then
            Return
        End If
        managerCompraAux.deleteCompraArticulo(articuloPasado.CodigoDeArticulo)
        managerVentaAux.deleteVentaArticulo(articuloPasado.CodigoDeArticulo)
        managerInventarioAux.deleteInventarioArticulo(articuloPasado.CodigoDeArticulo)

        cmd = New SqlCommand("DELETE FROM ARTICULOS WHERE ID_ARTICULO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = articuloPasado.CodigoDeArticulo
        Try
            cmd.ExecuteNonQuery()
            VariablesGlobales.updateListaArticulos()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el artículo: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteArticuloFamilia(idFamilia As Integer)
        Dim listaArticulosFamilia As List(Of Integer) = New List(Of Integer)
        cmd = New SqlCommand("SELECT ID_ARTICULO FROM ARTICULOS WHERE ID_FAMILIA = @CodigoFamilia", connectionDBManager)
        cmd.Parameters.Add("@CodigoFamilia", SqlDbType.Int).Value = idFamilia
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Do
                listaArticulosFamilia.Add(Convert.ToInt32(dr(0)))
            Loop While dr.Read()
            dr.Close()
        End If
        For Each numeroArticulo As Integer In listaArticulosFamilia
            managerInventarioAux.deleteInventarioArticulo(numeroArticulo)
            managerCompraAux.deleteCompraArticulo(numeroArticulo)
            managerVentaAux.deleteVentaArticulo(numeroArticulo)
        Next
        cmd = New SqlCommand("DELETE FROM ARTICULOS WHERE ID_FAMILIA = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = idFamilia
        Try
            cmd.ExecuteNonQuery()
            VariablesGlobales.updateListaArticulos()
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
    Public Function checkNombreUnique(nombre As String) As Boolean
        cmd = New SqlCommand("SELECT NOMBRE_ARTICULO FROM ARTICULOS WHERE NOMBRE_ARTICULO = @Nombre", connectionDBManager)
        cmd.Parameters.Add("@Nombre", SqlDbType.Char, 100).Value = nombre
        Dim nombreObj As Object = cmd.ExecuteScalar
        If nombreObj Is DBNull.Value Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function getArticuloConcreto(codigo As Integer) As Articulo
        Dim articuloFind As Articulo = VariablesGlobales.listaArticulosAux.Find(Function(a) a.CodigoDeArticulo = codigo)
        Return articuloFind
    End Function
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
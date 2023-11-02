Imports System.Data.SqlClient

Public Class ManagerCompra
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaCompras As List(Of Compra) = New List(Of Compra)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Function getCompras() As List(Of Compra)
        listaCompras = New List(Of Compra)
        cmd = New SqlCommand("SELECT * FROM COMPRAS;", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Dim codigo As Integer
            Dim proveedor As Integer
            Dim articulo As String
            Dim formaPago As Integer
            Dim precio As Double
            Dim cantidad As Integer
            Dim descuento As Double
            Dim fecha As Date
            Dim factura As String
            Dim eliminadoInt As Integer
            Dim eliminado As Boolean

            dr.Read()
            Do
                codigo = Convert.ToInt32(dr(0))
                proveedor = Convert.ToInt32(dr(1))
                articulo = dr(2).ToString().Trim()
                formaPago = Convert.ToInt32(dr(3))
                precio = Convert.ToDouble(dr(4))
                cantidad = Convert.ToInt32(dr(5))
                descuento = Convert.ToDouble(dr(6))
                fecha = Convert.ToDateTime(dr(7))
                eliminado = Convert.ToInt32(dr(8))
                factura = dr(9).ToString().Trim()

                If eliminadoInt = 0 Then
                    eliminado = False
                Else
                    eliminado = True
                End If

                compraAux = New Compra(codigo, proveedor, articulo, formaPago, precio, cantidad, fecha, eliminado, factura, descuento)
                listaCompras.Add(compraAux)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaCompras
    End Function
    Public Sub addCompra(compraTemp As Compra)
        Dim codigoCompra As Integer = getIDCompra()
        Dim eliminadoInt As Integer
        If compraTemp.CompraEliminada Then
            eliminadoInt = 1
        Else
            eliminadoInt = 0
        End If
        cmd = New SqlCommand($"INSERT INTO COMPRAS
                                VALUES 
                                (@Codigo,
                                @Proveedor, 
                                @Articulo,
                                @FormaPago,
                                @PVPCompra,
                                @Cantidad,
                                @Descuento,
                                @Fecha,
                                @Eliminado,
                                @Factura);", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = codigoCompra
            .Add("@Proveedor", SqlDbType.Char, 6).Value = compraTemp.ProveedorDeCompra
            .Add("@Articulo", SqlDbType.Char, 6).Value = compraTemp.ArticuloDeCompra
            .Add("@FormaPago", SqlDbType.Char, 5).Value = compraTemp.FormaDePagoCompra
            .Add("@PVPCompra", SqlDbType.Decimal, 10, 2).Value = compraTemp.PrecioDeArticuloCompra
            .Add("@Cantidad", SqlDbType.Int).Value = compraTemp.CantidadDeCompra
            .Add("@Descuento", SqlDbType.Decimal, 5, 2).Value = compraTemp.DescuentoDeCompra
            .Add("@Fecha", SqlDbType.Date).Value = compraTemp.FechaDeCompra
            .Add("@Eliminado", SqlDbType.Bit).Value = eliminadoInt
            .Add("@Factura", SqlDbType.Char, 10).Value = compraTemp.FacturaDeCompra
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al introducir una compra: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub modifyCompra(c As Compra)
        cmd = New SqlCommand("UPDATE COMPRAS SET
                            ID_FORMA_PAGO = @FormaPago,
                            PRECIO_ARTICULO_COMPRA = @PrecioCompra,
                            CANTIDAD_COMPRA = @Cantidad,
                            DESCUENTO_COMPRA = @Descuento,
                            FECHA_COMPRA = @Fecha
                            WHERE ID_COMPRA = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@FormaPago", SqlDbType.Int).Value = c.FormaDePagoCompra
            .Add("@PrecioCompra", SqlDbType.Decimal, 10, 2).Value = c.PrecioDeArticuloCompra
            .Add("@Cantidad", SqlDbType.Int).Value = c.CantidadDeCompra
            .Add("@Descuento", SqlDbType.Decimal, 5, 2).Value = c.DescuentoDeCompra
            .Add("@Fecha", SqlDbType.Date).Value = c.FechaDeCompra
            .Add("@Codigo", SqlDbType.Int).Value = c.CodigoDeCompra
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub deleteCompra(compra As Compra)
        cmd = New SqlCommand("DELETE FROM COMPRAS WHERE ID_COMPRA = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = compra.CodigoDeCompra
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub deleteCompraArticulo(codigoArticulo As Integer)
        cmd = New SqlCommand("DELETE FROM COMPRAS WHERE ID_ARTICULO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = codigoArticulo
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub deleteCompraProveedor(codigoProveedor As Integer)
        cmd = New SqlCommand("DELETE FROM COMPRAS WHERE ID_PROVEEDOR = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = codigoProveedor
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub deleteCompraFormaPago(codigoFormaPago As Integer)
        cmd = New SqlCommand("DELETE FROM COMPRAS WHERE ID_FORMA_PAGO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = codigoFormaPago
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Function checkNumFactura(factura As String) As Boolean
        cmd = New SqlCommand("SELECT FACTURA_COMPRA FROM COMPRAS WHERE FACTURA_COMPRA = @Factura", connectionDBManager)
        cmd.Parameters.Add("@Factura", SqlDbType.Char, 10).Value = factura
        Try
            Dim facturaObj As Object = cmd.ExecuteScalar
            If facturaObj Is DBNull.Value Then
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Return True
    End Function
    Public Function getIDCompra() As Integer
        cmd = New SqlCommand("SELECT MAX(ID_COMPRA) FROM COMPRAS;", connectionDBManager)
        Dim maxActual As Object = cmd.ExecuteScalar()
        Dim codigoCompraNuevo As Integer = Nothing
        If maxActual IsNot DBNull.Value Then
            codigoCompraNuevo = Convert.ToInt32(maxActual) + 1
        Else
            codigoCompraNuevo = 0
        End If
        Return codigoCompraNuevo
    End Function
End Class
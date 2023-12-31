﻿Imports System.Data.SqlClient

Public Class ManagerVenta
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaVentas As List(Of Venta) = New List(Of Venta)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Function getVentas() As List(Of Venta)
        listaVentas = New List(Of Venta)
        cmd = New SqlCommand("SELECT * FROM VENTAS;", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Dim codigo As Integer
            Dim cliente As Integer
            Dim articulo As String
            Dim formaPago As String
            Dim precio As Double
            Dim cantidad As Integer
            Dim descuento As Double
            Dim fecha As Date
            Dim eliminadoInt As Integer
            Dim eliminado As Boolean
            Dim factura As String

            dr.Read()
            Do
                codigo = Convert.ToInt32(dr(0))
                cliente = Convert.ToInt32(dr(1))
                articulo = dr(2).ToString().Trim()
                formaPago = Convert.ToInt32(dr(3))
                precio = Convert.ToDouble(dr(4))
                cantidad = Convert.ToInt32(dr(5))
                descuento = Convert.ToDouble(dr(6))
                fecha = Convert.ToDateTime(dr(7))
                eliminadoInt = Convert.ToInt32(dr(8))
                factura = dr(9).ToString().Trim()

                If eliminadoInt = 0 Then
                    eliminado = False
                Else
                    eliminado = True
                End If

                ventaAux = New Venta(codigo, cliente, articulo, formaPago, precio, cantidad, fecha, eliminado, factura, descuento)
                listaVentas.Add(ventaAux)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaVentas
    End Function
    Public Sub addVenta(ventaTemp As Venta)
        Dim listaArticulos As List(Of Articulo) = managerArticuloAux.getArticulos()
        Dim articuloFind As Articulo = listaArticulos.Find(Function(a) a.CodigoDeArticulo = ventaTemp.ArticuloDeVenta)
        Dim codigoVenta As Integer = getIDVenta()
        Dim eliminadoInt As Integer
        If ventaTemp.VentaEliminada Then
            eliminadoInt = 1
        Else
            eliminadoInt = 0
        End If
        cmd = New SqlCommand("INSERT INTO VENTAS VALUES 
                                (@Codigo,
                                @Cliente, 
                                @Articulo,
                                @FormaPago,
                                @PVPVenta,
                                @Cantidad,
                                @Descuento,
                                @Fecha,
                                @Eliminado,
                                @Factura);", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = codigoVenta
            .Add("@Cliente", SqlDbType.Int).Value = ventaTemp.ClienteDeVenta
            .Add("@Articulo", SqlDbType.Int).Value = articuloFind.CodigoDeArticulo
            .Add("@FormaPago", SqlDbType.Int).Value = ventaTemp.FormaDePagoVenta
            .Add("@PVPVenta", SqlDbType.Decimal, 10, 2).Value = ventaTemp.PrecioDeArticuloVenta
            .Add("@Cantidad", SqlDbType.Int).Value = ventaTemp.CantidadDeVenta
            .Add("@Descuento", SqlDbType.Decimal, 5, 2).Value = ventaTemp.DescuentoDeVenta
            .Add("@Fecha", SqlDbType.Date).Value = ventaTemp.FechaDeVenta
            .Add("@Eliminado", SqlDbType.Bit).Value = eliminadoInt
            .Add("@Factura", SqlDbType.Char, 10).Value = ventaTemp.FacturaDeVenta
        End With
        Try
            cmd.ExecuteNonQuery()
            VariablesGlobales.updateListaVentas()
        Catch ex As Exception
            MessageBox.Show("Error al introducir una venta: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub modifyVenta(v As Venta)
        cmd = New SqlCommand("UPDATE VENTAS SET
                            ID_FORMA_PAGO = @FormaPago,
                            PRECIO_VENTA_ARTICULO = @PrecioCompra,
                            CANTIDAD_VENTA = @Cantidad,
                            DESCUENTO_VENTA = @Descuento,
                            FECHA_VENTA = @Fecha
                            WHERE ID_VENTA = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@FormaPago", SqlDbType.Int).Value = v.FormaDePagoVenta
            .Add("@PrecioCompra", SqlDbType.Decimal, 10, 2).Value = v.PrecioDeArticuloVenta
            .Add("@Cantidad", SqlDbType.Int).Value = v.CantidadDeVenta
            .Add("@Descuento", SqlDbType.Decimal, 5, 2).Value = v.DescuentoDeVenta
            .Add("@Fecha", SqlDbType.Date).Value = v.FechaDeVenta
            .Add("@Codigo", SqlDbType.Int).Value = v.CodigoDeVenta
        End With
        Try
            cmd.ExecuteNonQuery()
            updateListaVentas()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub cambiarEliminadoVenta(venta As Venta)
        Dim eliminado As Integer
        cmd = New SqlCommand("UPDATE VENTAS SET 
                            ELIMINADO_VENTA = @Eliminado
                            WHERE ID_VENTA = @Codigo;", connectionDBManager)
        If venta.VentaEliminada Then
            eliminado = 0
        Else
            eliminado = 1
        End If
        cmd.Parameters.Add("@Eliminado", SqlDbType.Bit).Value = eliminado
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = venta.CodigoDeVenta
        Try
            cmd.ExecuteNonQuery()
            updateListaVentas()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub deleteVentaArticulo(codigoArticulo As Integer)
        cmd = New SqlCommand("DELETE FROM VENTAS WHERE ID_ARTICULO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = codigoArticulo
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub deleteVentaCliente(codigoCliente As Integer)
        cmd = New SqlCommand("DELETE FROM VENTAS WHERE ID_CLIENTE = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = codigoCliente
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub deleteVentaFormaPago(codigoFormaPago As Integer)
        cmd = New SqlCommand("DELETE FROM VENTAS WHERE ID_FORMA_PAGO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = codigoFormaPago
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Function checkNumFactura(factura As String) As Boolean
        cmd = New SqlCommand("SELECT FACTURA_VENTA FROM VENTAS WHERE FACTURA_VENTA = @Factura", connectionDBManager)
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
    Public Function getIDVenta() As Integer
        cmd = New SqlCommand("SELECT MAX(ID_VENTA) FROM VENTAS;", connectionDBManager)
        Dim maxActual As Object = cmd.ExecuteScalar()
        Dim codigoVentaNuevo As Integer = Nothing
        If maxActual IsNot DBNull.Value Then
            codigoVentaNuevo = Convert.ToInt32(maxActual) + 1
        Else
            codigoVentaNuevo = 0
        End If
        Return codigoVentaNuevo
    End Function
End Class
Imports System.Data.SqlClient

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
            Dim cliente As String
            Dim articulo As String
            Dim formaPago As String
            Dim precio As Double
            Dim cantidad As Integer

            dr.Read()
            Do
                cliente = dr(1).ToString().Trim()
                articulo = dr(2).ToString().Trim()
                formaPago = dr(3).ToString().Trim()
                precio = Convert.ToDouble(dr(4))
                cantidad = Convert.ToInt32(dr(5))

                ventaAux = New Venta(cliente, articulo, formaPago, precio, cantidad)
                listaVentas.Add(ventaAux)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaVentas
    End Function
    Public Sub addVenta(ventaTemp As Venta)
        cmd = New SqlCommand("SELECT MAX(CODIGOVENTA) FROM VENTAS;", connectionDBManager)
        Dim maxActual As Object = cmd.ExecuteScalar()
        Dim codigoVentaNuevo As Integer = Nothing
        If maxActual IsNot DBNull.Value Then
            codigoVentaNuevo = Convert.ToInt32(maxActual) + 1
        Else
            codigoVentaNuevo = 0
        End If
        cmd = New SqlCommand($"INSERT INTO VENTAS
                                VALUES (@Codigo,
                                @Cliente, 
                                @Articulo,
                                @FormaPago,
                                @PVPVenta,
                                @Cantidad);", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = codigoVentaNuevo
            .Add("@Cliente", SqlDbType.Char, 6).Value = ventaTemp.ClienteDeVenta
            .Add("@Articulo", SqlDbType.Char, 6).Value = ventaTemp.ArticuloDeVenta
            .Add("@FormaPago", SqlDbType.Char, 5).Value = ventaTemp.FormaDePagoVenta
            .Add("@PVPVenta", SqlDbType.Decimal, 10, 2).Value = ventaTemp.PrecioDeArticuloVenta
            .Add("@Cantidad", SqlDbType.Int).Value = ventaTemp.CantidadDeVenta
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al introducir una venta: " + vbCrLf + ex.ToString())
        End Try
    End Sub
End Class
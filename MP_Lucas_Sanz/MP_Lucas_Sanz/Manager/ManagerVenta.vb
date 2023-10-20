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
            Dim codigo As Integer
            Dim cliente As Integer
            Dim articulo As String
            Dim formaPago As String
            Dim precio As Double
            Dim cantidad As Integer
            Dim fecha As Date

            dr.Read()
            Do
                codigo = Convert.ToInt32(dr(0))
                cliente = Convert.ToInt32(dr(1))
                articulo = dr(2).ToString().Trim()
                formaPago = Convert.ToInt32(dr(3))
                precio = Convert.ToDouble(dr(4))
                cantidad = Convert.ToInt32(dr(5))
                fecha = Convert.ToDateTime(dr(6))

                ventaAux = New Venta(codigo, cliente, articulo, formaPago, precio, cantidad, fecha)
                listaVentas.Add(ventaAux)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaVentas
    End Function
    Public Sub addVenta(ventaTemp As Venta)
        cmd = New SqlCommand("SELECT MAX(ID_VENTA) FROM VENTAS;", connectionDBManager)
        Dim maxActual As Object = cmd.ExecuteScalar()
        Dim codigoVentaNuevo As Integer = Nothing
        If maxActual IsNot DBNull.Value Then
            codigoVentaNuevo = Convert.ToInt32(maxActual) + 1
        Else
            codigoVentaNuevo = 0
        End If
        Dim listaArticulos As List(Of Articulo) = managerArticuloAux.getArticulos()
        Dim articuloFind As Articulo = listaArticulos.Find(Function(art) art.NombreDeArticulo = ventaTemp.ArticuloDeVenta)
        cmd = New SqlCommand($"INSERT INTO VENTAS
                                VALUES 
                                (@Codigo,
                                @Cliente, 
                                @Articulo,
                                @FormaPago,
                                @PVPVenta,
                                @Cantidad,
                                @Fecha);", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = codigoVentaNuevo
            .Add("@Cliente", SqlDbType.Int).Value = ventaTemp.ClienteDeVenta
            .Add("@Articulo", SqlDbType.Int).Value = articuloFind.CodigoDeArticulo
            .Add("@FormaPago", SqlDbType.Int).Value = ventaTemp.FormaDePagoVenta
            .Add("@PVPVenta", SqlDbType.Decimal, 10, 2).Value = ventaTemp.PrecioDeArticuloVenta
            .Add("@Cantidad", SqlDbType.Int).Value = ventaTemp.CantidadDeVenta
            .Add("@Fecha", SqlDbType.Date).Value = ventaTemp.FechaDeVenta
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al introducir una venta: " + vbCrLf + ex.ToString())
        End Try
    End Sub
End Class
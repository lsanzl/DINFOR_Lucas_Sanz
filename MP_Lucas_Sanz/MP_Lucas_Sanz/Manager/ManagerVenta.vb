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
                cliente = dr(1).ToString()
                articulo = dr(2).ToString()
                formaPago = dr(3).ToString()
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
        Dim pvpVentaConPunto As String = Replace(ventaTemp.PrecioDeArticuloVenta.ToString(), ",", ".")
        cmd = New SqlCommand($"INSERT INTO VENTAS
                                VALUES ({codigoVentaNuevo},
                                '{ventaTemp.ClienteDeVenta}', 
                                '{ventaTemp.ArticuloDeVenta}',
                                '{ventaTemp.FormaDePagoVenta}',
                                {pvpVentaConPunto},
                                {ventaTemp.CantidadDeVenta});", connectionDBManager)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class
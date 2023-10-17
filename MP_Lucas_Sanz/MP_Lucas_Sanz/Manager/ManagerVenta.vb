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
        cmd = New SqlCommand($"INSERT INTO VENTAS
                                VALUES ('{ventaTemp.ClienteDeVenta}', 
                                '{ventaTemp.ArticuloDeVenta}',
                                '{ventaTemp.FormaDePagoVenta}',
                                {ventaTemp.PrecioDeArticuloVenta},
                                {ventaTemp.CantidadDeVenta});", connectionDBManager)
        If cmd.ExecuteNonQuery > 0 Then
            MessageBox.Show("Venta introducida")
        Else
            MessageBox.Show("Venta no introducida")
        End If
    End Sub
End Class
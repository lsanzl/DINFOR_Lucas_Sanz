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
            Dim proveedor As String
            Dim articulo As String
            Dim formaPago As String
            Dim precio As Double
            Dim cantidad As Integer

            dr.Read()
            Do
                proveedor = dr(1).ToString()
                articulo = dr(2).ToString()
                formaPago = dr(3).ToString()
                precio = Convert.ToDouble(dr(4))
                cantidad = Convert.ToInt32(dr(5))

                compraAux = New Compra(proveedor, articulo, formaPago, precio, cantidad)
                listaCompras.Add(compraAux)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaCompras
    End Function
    Public Sub addCompra(compraTemp As Compra)
        cmd = New SqlCommand($"INSERT INTO COMPRAS
                                VALUES ('{compraTemp.ProveedorDeCompra}', 
                                '{compraTemp.ArticuloDeCompra}',
                                '{compraTemp.FormaDePagoCompra}',
                                {compraTemp.PrecioDeArticuloCompra},
                                {compraTemp.CantidadDeCompra});", connectionDBManager)
        If cmd.ExecuteNonQuery > 0 Then
            MessageBox.Show("Compra introducida")
        Else
            MessageBox.Show("Compra no introducida")
        End If
    End Sub
End Class
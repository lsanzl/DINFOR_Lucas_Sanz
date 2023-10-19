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
            Dim proveedor As String
            Dim articulo As String
            Dim formaPago As String
            Dim precio As Double
            Dim cantidad As Integer
            Dim fecha As Date

            dr.Read()
            Do
                codigo = Convert.ToInt32(dr(0))
                proveedor = dr(1).ToString().Trim()
                articulo = dr(2).ToString().Trim()
                formaPago = dr(3).ToString().Trim()
                precio = Convert.ToDouble(dr(4))
                cantidad = Convert.ToInt32(dr(5))
                fecha = Convert.ToDateTime(dr(6))

                compraAux = New Compra(codigo, proveedor, articulo, formaPago, precio, cantidad, fecha)
                listaCompras.Add(compraAux)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaCompras
    End Function
    Public Sub addCompra(compraTemp As Compra)
        cmd = New SqlCommand($"INSERT INTO COMPRAS
                                VALUES 
                                (@Codigo,
                                @Proveedor, 
                                @Articulo,
                                @FormaPago,
                                @PVPCompra,
                                @Cantidad,
                                @Fecha);", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = getIDCompra()
            .Add("@Proveedor", SqlDbType.Char, 6).Value = compraTemp.ProveedorDeCompra
            .Add("@Articulo", SqlDbType.Char, 6).Value = compraTemp.ArticuloDeCompra
            .Add("@FormaPago", SqlDbType.Char, 5).Value = compraTemp.FormaDePagoCompra
            .Add("@PVPCompra", SqlDbType.Decimal, 10, 2).Value = compraTemp.PrecioDeArticuloCompra
            .Add("@Cantidad", SqlDbType.Int).Value = compraTemp.CantidadDeCompra
            .Add("@Fecha", SqlDbType.Date).Value = compraTemp.FechaDeCompra
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al introducir una compra: " + vbCrLf + ex.ToString())
        End Try
    End Sub
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
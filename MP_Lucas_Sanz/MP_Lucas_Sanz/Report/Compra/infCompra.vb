Imports System.ComponentModel

Public Class infCompra
    Dim listaCompra As BindingList(Of Compra) = New BindingList(Of Compra)

    Public Sub New(listaCompraP As BindingList(Of Compra))
        MyBase.New()
        listaCompra = New BindingList(Of Compra)
        listaCompra = listaCompraP

        showReport()
    End Sub
    Private Sub showReport()
        Dim dt As DataTable = New DataTable("dsCompra")
        dt.Columns.Add("Proveedor")
        dt.Columns.Add("Artículo")
        dt.Columns.Add("Forma Pago")
        dt.Columns.Add("Precio Unitario")
        dt.Columns.Add("Cantidad")
        dt.Columns.Add("Precio Total")

        Dim dr As DataRow

        For Each c As Compra In listaCompra
            dr = dt.NewRow()

            dr(0) = c.ProveedorDeCompra
            dr(1) = c.ArticuloDeCompra
            dr(2) = c.FormaDePagoCompra
            dr(3) = c.PrecioDeArticuloCompra
            dr(4) = c.CantidadDeCompra
            dr(5) = c.PrecioDeArticuloCompra * c.CantidadDeCompra

            dt.Rows.Add(dr)
            MessageBox.Show($"Añadido registro {c.ArticuloDeCompra}")
        Next

        Dim informe As New rptCompra()
        informe.SetDataSource(dt)
        informe.Refresh()

        Dim visorRPT As viewerRPTCompra = New viewerRPTCompra()
        visorRPT.crvCompra.ReportSource = informe
        visorRPT.Text = "Informe de Compra"
        visorRPT.WindowState = FormWindowState.Maximized
        visorRPT.ShowDialog()
    End Sub
End Class

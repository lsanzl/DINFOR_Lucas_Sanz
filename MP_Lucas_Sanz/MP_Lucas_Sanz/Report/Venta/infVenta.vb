Imports System.ComponentModel

Public Class infVenta
    Dim listaVenta As BindingList(Of Venta) = New BindingList(Of Venta)
    Dim fechaVenta As Date

    Public Sub New(listaVentaP As BindingList(Of Venta), fechaVentaP As Date)
        MyBase.New()
        listaVenta = New BindingList(Of Venta)
        listaVenta = listaVentaP
        fechaVenta = fechaVentaP

        showReport()
    End Sub
    Private Sub showReport()
        Dim ds As DataSet = New dsVenta

        Dim dr As DataRow

        For Each v As Venta In listaVenta
            dr = ds.Tables("Venta").NewRow()

            dr("Cliente") = v.ClienteDeVenta
            dr("Artículo") = v.ArticuloDeVenta
            dr("Forma Pago") = v.FormaDePagoVenta
            dr("Precio Unitario") = v.PrecioDeArticuloVenta
            dr("Cantidad") = v.CantidadDeVenta
            dr("Precio Total") = v.PrecioDeArticuloVenta * v.CantidadDeVenta

            ds.Tables("Venta").Rows.Add(dr)
        Next

        Dim clienteSeleccionado As Cliente = getClienteSeleccioando(listaVenta(0).ClienteDeVenta)
        dr = ds.Tables("Cliente").NewRow()

        dr("Código") = clienteSeleccionado.CodigoDelCliente
        dr("Nombre") = clienteSeleccionado.NombreDelCliente
        dr("Dirección") = clienteSeleccionado.DireccionDelCliente
        dr("NIF") = clienteSeleccionado.NifDelCliente
        dr("Email") = clienteSeleccionado.EmailDelCliente
        dr("Fecha Venta") = fechaVenta

        ds.Tables("Cliente").Rows.Add(dr)

        Dim informe As New rptVenta()
        informe.SetDataSource(ds)
        informe.Refresh()

        Dim visorRPT As viewerRPTVenta = New viewerRPTVenta()
        visorRPT.crvVenta.ReportSource = informe
        visorRPT.Text = "Informe de Venta"
        visorRPT.WindowState = FormWindowState.Maximized
        visorRPT.ShowDialog()
    End Sub
    Private Function getClienteSeleccioando(codigoCliente As String) As Cliente
        Dim listaClientes As List(Of Cliente) = clienteAux.getClientes()
        Dim clienteFind As Cliente = listaClientes.Find(Function(c) c.CodigoDelCliente = codigoCliente)
        Return clienteFind
    End Function
End Class

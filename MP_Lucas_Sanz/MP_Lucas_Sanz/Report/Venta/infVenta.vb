Imports System.ComponentModel

Public Class infVenta
    Dim listaVenta As List(Of Venta) = New List(Of Venta)
    Dim fechaVenta As Date
    Dim brutoTotal As Double
    Dim baseImponibleTotal As Double
    Dim impuestoTotal As Double
    Dim precioTotal As Double

    Public Sub New(listaVentaP As List(Of Venta), fechaVentaP As Date, brutoTotalP As Double, baseImponibleTotalP As Double, impuestoTotalP As Double, precioTotalP As Double)
        MyBase.New()
        listaVenta = New List(Of Venta)
        listaVenta = listaVentaP
        fechaVenta = fechaVentaP
        brutoTotal = brutoTotalP
        baseImponibleTotal = baseImponibleTotalP
        impuestoTotal = impuestoTotalP
        precioTotal = precioTotalP
    End Sub
    Public Sub showReport()
        Dim articuloTemp As Articulo
        Dim baseImponible As Double
        Dim impuesto As Double
        Dim ds As DataSet = New dsVenta

        Dim dr As DataRow

        For Each v As Venta In listaVenta
            dr = ds.Tables("Venta").NewRow()
            articuloTemp = VariablesGlobales.getArticuloPorCodigo(v.ArticuloDeVenta)
            baseImponible = v.PrecioDeArticuloVenta * (1 - v.DescuentoDeVenta / 100)
            impuesto = baseImponible * (articuloTemp.ImpuestoDeArticulo / 100)

            dr("Cliente") = v.ClienteDeVenta
            dr("Artículo") = articuloTemp.NombreDeArticulo
            dr("Forma Pago") = v.FormaDePagoVenta
            dr("Precio Unitario") = v.PrecioDeArticuloVenta * v.CantidadDeVenta
            dr("Cantidad") = v.CantidadDeVenta
            dr("Descuento") = v.DescuentoDeVenta
            dr("Base Imponible") = baseImponible * v.CantidadDeVenta
            dr("Impuesto") = impuesto * v.CantidadDeVenta
            dr("Precio Total") = (baseImponible + impuesto) * v.CantidadDeVenta

            ds.Tables("Venta").Rows.Add(dr)
        Next

        Dim clienteSeleccionado As Cliente = getClienteSeleccionado(listaVenta(0).ClienteDeVenta)
        dr = ds.Tables("Cliente").NewRow()

        dr("Código") = clienteSeleccionado.CodigoDelCliente
        dr("Nombre") = clienteSeleccionado.NombreDelCliente
        dr("Dirección") = clienteSeleccionado.DireccionDelCliente
        dr("NIF") = clienteSeleccionado.NifDelCliente
        dr("Email") = clienteSeleccionado.EmailDelCliente
        dr("Fecha Venta") = fechaVenta

        ds.Tables("Cliente").Rows.Add(dr)

        dr = ds.Tables("Desglose").NewRow()

        dr("Bruto") = brutoTotal
        dr("Base Imponible") = baseImponibleTotal
        dr("Impuesto") = impuestoTotal
        dr("Precio Total") = precioTotal

        ds.Tables("Desglose").Rows.Add(dr)

        Dim informe As New rptVenta()
        informe.SetDataSource(ds)
        informe.Refresh()

        Dim visorRPT As viewerRPTVenta = New viewerRPTVenta(informe, listaVenta(0))
        visorRPT.crvVenta.ReportSource = informe
        visorRPT.Text = "Informe de Venta"
        visorRPT.WindowState = FormWindowState.Maximized
        visorRPT.ShowDialog()
    End Sub
    Public Function getReport() As rptVenta
        Dim articuloTemp As Articulo
        Dim baseImponible As Double
        Dim impuesto As Double
        Dim ds As DataSet = New dsVenta

        Dim dr As DataRow

        For Each v As Venta In listaVenta
            dr = ds.Tables("Venta").NewRow()
            articuloTemp = VariablesGlobales.getArticuloPorCodigo(v.ArticuloDeVenta)
            baseImponible = v.PrecioDeArticuloVenta * (1 - v.DescuentoDeVenta / 100)
            impuesto = baseImponible * (articuloTemp.ImpuestoDeArticulo / 100)

            dr("Cliente") = v.ClienteDeVenta
            dr("Artículo") = articuloTemp.NombreDeArticulo
            dr("Forma Pago") = v.FormaDePagoVenta
            dr("Precio Unitario") = v.PrecioDeArticuloVenta * v.CantidadDeVenta
            dr("Cantidad") = v.CantidadDeVenta
            dr("Descuento") = v.DescuentoDeVenta
            dr("Base Imponible") = baseImponible * v.CantidadDeVenta
            dr("Impuesto") = impuesto * v.CantidadDeVenta
            dr("Precio Total") = (baseImponible + impuesto) * v.CantidadDeVenta

            ds.Tables("Venta").Rows.Add(dr)
        Next

        Dim clienteSeleccionado As Cliente = getClienteSeleccionado(listaVenta(0).ClienteDeVenta)
        dr = ds.Tables("Cliente").NewRow()

        dr("Código") = clienteSeleccionado.CodigoDelCliente
        dr("Nombre") = clienteSeleccionado.NombreDelCliente
        dr("Dirección") = clienteSeleccionado.DireccionDelCliente
        dr("NIF") = clienteSeleccionado.NifDelCliente
        dr("Email") = clienteSeleccionado.EmailDelCliente
        dr("Fecha Venta") = fechaVenta

        ds.Tables("Cliente").Rows.Add(dr)

        dr = ds.Tables("Desglose").NewRow()

        dr("Bruto") = brutoTotal
        dr("Base Imponible") = baseImponibleTotal
        dr("Impuesto") = impuestoTotal
        dr("Precio Total") = precioTotal

        ds.Tables("Desglose").Rows.Add(dr)

        Dim informe As New rptVenta()
        informe.SetDataSource(ds)
        informe.Refresh()

        Return informe
    End Function
    Private Function getClienteSeleccionado(codigoCliente As String) As Cliente
        Dim listaClientes As List(Of Cliente) = managerClienteAux.getClientes()
        Dim clienteFind As Cliente = listaClientes.Find(Function(c) c.CodigoDelCliente = codigoCliente)
        Return clienteFind
    End Function
End Class

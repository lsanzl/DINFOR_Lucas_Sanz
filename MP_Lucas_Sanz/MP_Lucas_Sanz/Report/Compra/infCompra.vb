Imports System.ComponentModel

Public Class infCompra
    Dim listaCompra As List(Of Compra) = New List(Of Compra)
    Dim fechaCompra As Date
    Dim brutoTotal As Double
    Dim baseImponibleTotal As Double
    Dim impuestoTotal As Double
    Dim precioTotal As Double

    Public Sub New(listaCompraP As List(Of Compra), fechaCompraP As Date, brutoTotalP As Double, baseImponibleTotalP As Double, impuestoTotalP As Double, precioTotalP As Double)
        MyBase.New()
        listaCompra = New List(Of Compra)
        listaCompra = listaCompraP
        fechaCompra = fechaCompraP
        brutoTotal = brutoTotalP
        baseImponibleTotal = baseImponibleTotalP
        impuestoTotal = impuestoTotalP
        precioTotal = precioTotalP

        showReport()
    End Sub
    Private Sub showReport()
        Dim codigoProveedor As String = listaCompra(0).ProveedorDeCompra
        Dim articuloTemp As Articulo
        Dim baseImponible As Double
        Dim impuesto As Double
        Dim ds As DataSet = New dsCompra

        Dim dr As DataRow

        For Each c As Compra In listaCompra
            dr = ds.Tables("Compra").NewRow()

            articuloTemp = VariablesGlobales.getArticuloPorCodigo(c.ArticuloDeCompra)
            baseImponible = c.PrecioDeArticuloCompra * (1 - c.DescuentoDeCompra / 100)
            impuesto = baseImponible * (articuloTemp.ImpuestoDeArticulo / 100)

            dr("Proveedor") = c.ProveedorDeCompra
            dr("Artículo") = articuloTemp.NombreDeArticulo
            dr("Forma Pago") = c.FormaDePagoCompra
            dr("Precio Unitario") = c.PrecioDeArticuloCompra
            dr("Cantidad") = c.CantidadDeCompra
            dr("Descuento") = c.DescuentoDeCompra
            dr("Base Imponible") = baseImponible * c.CantidadDeCompra
            dr("Impuesto") = impuesto * c.CantidadDeCompra
            dr("Precio Total") = (baseImponible + impuesto) * c.CantidadDeCompra

            ds.Tables("Compra").Rows.Add(dr)
        Next

        Dim drP As DataRow
        Dim proveedorSeleccionado As Proveedor = getProveedorSeleccionado(codigoProveedor)

        drP = ds.Tables("Proveedor").NewRow()
        drP("Código") = proveedorSeleccionado.CodigoDeProveedor
        drP("Nombre") = proveedorSeleccionado.NombreDeProveedor
        drP("Dirección") = proveedorSeleccionado.DireccionDeProveedor
        drP("Teléfono") = proveedorSeleccionado.TelefonoDeProveedor
        drP("Fecha Compra") = fechaCompra

        ds.Tables("Proveedor").Rows.Add(drP)

        dr = ds.Tables("Desglose").NewRow()
        dr("Bruto") = brutoTotal
        dr("Base Imponible") = baseImponibleTotal
        dr("Impuesto") = impuestoTotal
        dr("Precio Total") = precioTotal

        ds.Tables("Desglose").Rows.Add(dr)

        Dim informe As New rptCompra()
        informe.SetDataSource(ds)
        informe.Refresh()

        Dim visorRPT As viewerRPTCompra = New viewerRPTCompra(informe, listaCompra(0))
        visorRPT.crvCompra.ReportSource = informe
        visorRPT.Text = "Informe de Compra"
        visorRPT.WindowState = FormWindowState.Maximized
        visorRPT.ShowDialog()
    End Sub
    Private Function getProveedorSeleccionado(codigoProveedor As String) As Proveedor
        Dim listaProveedores As List(Of Proveedor) = proveedorAux.getProveedores()
        Dim proveedorFind As Proveedor = listaProveedores.Find(Function(p) p.CodigoDeProveedor = codigoProveedor)
        Return proveedorFind
    End Function
End Class

Public Class ctrAlbaran
    Dim frmAlbaran As frmMain
    Dim listaAlbaranVenta As List(Of Venta) = New List(Of Venta)
    Dim listaAlbaranCompra As List(Of Compra) = New List(Of Compra)
    Dim listaFacturas As List(Of String) = New List(Of String)
    Dim ventaTemp As Venta
    Dim compraTemp As Compra
    Dim clienteTemp As Cliente
    Dim proveedorTemp As Proveedor
    Dim formaTemp As FormaPago

    Public Sub New(frmAlbaranPasado As frmMain)
        MyBase.New()
        frmAlbaran = frmAlbaranPasado
        frmAlbaran.rdb_ver_ventas.Checked = True

        AddHandler frmAlbaran.rdb_ver_ventas.CheckedChanged, AddressOf checked_changed_gb_ver_albaranes
        AddHandler frmAlbaran.rdb_ver_compras.CheckedChanged, AddressOf checked_changed_gb_ver_albaranes
        AddHandler frmAlbaran.dg_albaranes.CellClick, AddressOf cell_click_dg_albaranes
        AddHandler frmAlbaran.tab_main.SelectedIndexChanged, AddressOf tab_main_SelectedIndexChanged
    End Sub

    Private Sub fillDGAlbaranes()
        If VariablesGlobales.albaranSeleccionado.Equals("Ventas") Then
            fillDGAlbaranesVentas()
        Else
            fillDGAlbaranesCompras()
        End If
    End Sub
    Private Sub fillDGAlbaranesVentas()
        listaFacturas = New List(Of String)
        frmAlbaran.dg_albaranes.Rows.Clear()
        listaAlbaranVenta = managerVentaAux.getVentas()
        For Each v As Venta In listaAlbaranVenta
            If listaFacturas.Contains(v.FacturaDeVenta) Then
                Continue For
            End If
            Dim index As Integer = frmAlbaran.dg_albaranes.Rows.Add()
            clienteTemp = VariablesGlobales.getClientePorCodigo(v.ClienteDeVenta)
            frmAlbaran.dg_albaranes.Rows(index).Cells("idAlbaran").Value = v.CodigoDeVenta
            frmAlbaran.dg_albaranes.Rows(index).Cells("personaAlbaran").Value = clienteTemp.NombreDelCliente
            frmAlbaran.dg_albaranes.Rows(index).Cells("formaPagoAlbaran").Value = v.FormaDePagoVenta
            frmAlbaran.dg_albaranes.Rows(index).Cells("fechaAlbaran").Value = v.FechaDeVenta
            frmAlbaran.dg_albaranes.Rows(index).Cells("tipoAlbaran").Value = "V"
            frmAlbaran.dg_albaranes.Rows(index).Cells("facturaAlbaran").Value = v.FacturaDeVenta
            frmAlbaran.dg_albaranes.Rows(index).Cells("verAlbaran").Value = "VER VENTA"
            listaFacturas.Add(v.FacturaDeVenta)
        Next
    End Sub
    Private Sub fillDGAlbaranesCompras()
        listaFacturas = New List(Of String)
        frmAlbaran.dg_albaranes.Rows.Clear()
        listaAlbaranCompra = managerCompraAux.getCompras()
        For Each c As Compra In listaAlbaranCompra
            If listaFacturas.Contains(c.FacturaDeCompra) Then
                Continue For
            End If
            Dim index As Integer = frmAlbaran.dg_albaranes.Rows.Add()
            proveedorTemp = VariablesGlobales.getProveedorPorCodigo(c.ProveedorDeCompra)
            frmAlbaran.dg_albaranes.Rows(index).Cells("idAlbaran").Value = c.CodigoDeCompra
            frmAlbaran.dg_albaranes.Rows(index).Cells("personaAlbaran").Value = proveedorTemp.NombreDeProveedor
            frmAlbaran.dg_albaranes.Rows(index).Cells("formaPagoAlbaran").Value = c.FormaDePagoCompra
            frmAlbaran.dg_albaranes.Rows(index).Cells("fechaAlbaran").Value = c.FechaDeCompra
            frmAlbaran.dg_albaranes.Rows(index).Cells("tipoAlbaran").Value = "C"
            frmAlbaran.dg_albaranes.Rows(index).Cells("facturaAlbaran").Value = c.FacturaDeCompra
            frmAlbaran.dg_albaranes.Rows(index).Cells("verAlbaran").Value = "VER COMPRA"
            listaFacturas.Add(c.FacturaDeCompra)
        Next
    End Sub
    Private Sub checked_changed_gb_ver_albaranes(sender As Object, e As EventArgs)
        If frmAlbaran.rdb_ver_ventas.Checked Then
            VariablesGlobales.albaranSeleccionado = "Ventas"
        Else
            VariablesGlobales.albaranSeleccionado = "Compras"
        End If
        fillDGAlbaranes()
    End Sub
    Private Sub cell_click_dg_albaranes(sender As Object, e As DataGridViewCellEventArgs)
        If Not e.RowIndex >= 0 Then
            Return
        End If
        Dim currentCelll As DataGridViewCell = frmAlbaran.dg_albaranes.CurrentCell
        Dim codigo As Integer = frmAlbaran.dg_albaranes.Rows(e.RowIndex).Cells("idAlbaran").Value
        If currentCelll.Value.Equals("VER VENTA") Then
            ventaTemp = VariablesGlobales.getVentaPorCodigo(codigo)
            showVenta(ventaTemp)
        Else
            compraTemp = VariablesGlobales.getCompraPorCodigo(codigo)
            showCompra(compraTemp)
        End If
    End Sub
    Private Sub showVenta(ventaTemp As Venta)
        Dim listaVentasFactura As List(Of Venta) = New List(Of Venta)

        clienteTemp = VariablesGlobales.getClientePorCodigo(ventaTemp.ClienteDeVenta)
        formaTemp = VariablesGlobales.getFormaPagoPorCodigo(ventaTemp.FormaDePagoVenta)
        For Each v As Venta In VariablesGlobales.listaVentasAux
            If v.FacturaDeVenta.Equals(ventaTemp.FacturaDeVenta) Then
                listaVentasFactura.Add(v)
            End If
        Next
        Dim frm As frmVenta = New frmVenta()

        Dim articuloTemp As Articulo = VariablesGlobales.getArticuloPorCodigo(ventaTemp.ArticuloDeVenta)
        frm.txt_cliente_seleccionado.Text = clienteTemp.NombreDelCliente
        frm.txt_articulo_seleccionado_venta.Text = articuloTemp.NombreDeArticulo
        frm.cb_forma_pago_seleccionada_venta.SelectedValue = formaTemp.NombreDePago
        frm.dp_fecha_venta.Value = ventaTemp.FechaDeVenta

        frm.fillDGVentas(listaVentasFactura)

        frm.ShowDialog()
        fillDGAlbaranes()
    End Sub
    Private Sub showCompra(compraTemp As Compra)
        Dim listaComprasFactura As List(Of Compra) = New List(Of Compra)

        proveedorTemp = VariablesGlobales.getProveedorPorCodigo(compraTemp.ProveedorDeCompra)
        formaTemp = VariablesGlobales.getFormaPagoPorCodigo(compraTemp.FormaDePagoCompra)
        For Each c As Compra In VariablesGlobales.listaComprasAux
            If c.FacturaDeCompra.Equals(compraTemp.FacturaDeCompra) Then
                listaComprasFactura.Add(c)
            End If
        Next
        Dim frm As frmCompra = New frmCompra()

        Dim articuloTemp As Articulo = VariablesGlobales.getArticuloPorCodigo(compraTemp.ArticuloDeCompra)
        frm.txt_proveedor_seleccionado.Text = proveedorTemp.NombreDeProveedor
        frm.txt_articulo_seleccionado.Text = articuloTemp.NombreDeArticulo
        frm.cb_forma_pago_seleccionada.SelectedValue = formaTemp.NombreDePago
        frm.dp_fecha_compra.Value = compraTemp.FechaDeCompra

        frm.fillDGCompras(listaComprasFactura)

        frm.ShowDialog()
        fillDGAlbaranes()
    End Sub
    Private Sub tab_main_SelectedIndexChanged(sender As Object, e As EventArgs)
        If frmAlbaran.tab_main.SelectedTab.Text.Equals("ALBARANES") Then
            fillDGAlbaranes()
            If VariablesGlobales.albaranSeleccionado = "Ventas" Then
                frmAlbaran.rdb_ver_ventas.Checked = True
            Else
                frmAlbaran.rdb_ver_compras.Checked = True
            End If
        End If
    End Sub
End Class
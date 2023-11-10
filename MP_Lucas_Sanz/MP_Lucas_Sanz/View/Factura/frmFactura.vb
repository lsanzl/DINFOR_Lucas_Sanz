Public Class frmFactura
    Private listaAlbaranes As List(Of String)
    Private clienteSeleccionado As Cliente
    Private proveedorSeleccionado As Proveedor
    Private entidadSeleccionada As String
    Private brutoTotal As Double
    Private brutoParcial As Double
    Private baseImponibleTotal As Double
    Private baseImponibleParcial As Double
    Private impuestoTotal As Double
    Private impuestoParcial As Double
    Private descuentoTotal As Double
    Private descuentoParcial As Double
    Private precioTotal As Double
    Private dg As DataGridView

    Public Sub New(nuevo As Boolean)
        InitializeComponent()
        dg = dg_albaranes_factura
        listaAlbaranes = New List(Of String)
        brutoTotal = 0
        baseImponibleTotal = 0
        impuestoTotal = 0
        descuentoTotal = 0
        precioTotal = 0

        If nuevo Then
            Dim idFactura As Integer = managerFacturaAux.getIDFactura()
            txt_referencia_factura.Text = idFactura
        End If
    End Sub
    Private Sub click_busqueda_cliente(sender As Object, e As EventArgs) Handles btn_busqueda_cliente.Click
        Dim frmClienteProv As frmBusquedaClienteProveedor = New frmBusquedaClienteProveedor()
        frmClienteProv.ShowDialog()
        If frmClienteProv.tipoBusqueda.Equals("Cliente") Then
            clienteSeleccionado = frmClienteProv.clienteSeleccionado
            entidadSeleccionada = "Cliente"
        Else
            proveedorSeleccionado = frmClienteProv.proveedorSeleccionado
            entidadSeleccionada = "Proveedor"
        End If
        If entidadSeleccionada.Equals("Cliente") And clienteSeleccionado IsNot Nothing Then
            fillDatosCliente()
            fillDGAlbaranes()
        ElseIf entidadSeleccionada.Equals("Proveedor") And proveedorSeleccionado IsNot Nothing Then
            fillDatosProveedor()
            fillDGAlbaranes()
        End If
    End Sub
    Private Sub click_btn_cancelar_factura(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub current_cell_dirty_state_changed_dg_albaranes(sender As Object, e As EventArgs) Handles dg_albaranes_factura.CurrentCellDirtyStateChanged
        If TypeOf dg.CurrentCell Is DataGridViewCheckBoxCell Then
            dg.CommitEdit(DataGridViewDataErrorContexts.Commit)
            checkCell(dg.CurrentCell)
        End If
    End Sub
    Private Sub checkCell(dgCurrent As DataGridViewCell)
        If dgCurrent.Value Then
            listaAlbaranes.Add(dg.Rows(dgCurrent.RowIndex).Cells("idAlbaran").Value)
        Else
            listaAlbaranes.Remove(dg.Rows(dgCurrent.RowIndex).Cells("idAlbaran").Value)
        End If
        recalcularTotales()
    End Sub
    Private Sub fillDGAlbaranes()
        If entidadSeleccionada.Equals("Cliente") Then
            fillDGVentas()
        Else
            fillDGCompras()
        End If
    End Sub
    Private Sub fillDGCompras()
        If listaComprasAux.Count = 0 Then
            MessageBox.Show("Sin compras que facturar")
            Return
        End If
        Dim listaComprasFacturas As List(Of Compra) = listaComprasAux

        For Each c As Compra In listaComprasFacturas
            If c.ProveedorDeCompra = proveedorSeleccionado.CodigoDeProveedor Then
                Dim index As Integer = dg.Rows.Add()
                dg.Rows(index).Cells("idAlbaran").Value = c.FacturaDeCompra
                dg.Rows(index).Cells("fechaAlbaran").Value = c.FechaDeCompra
            End If
        Next
    End Sub
    Private Sub fillDGVentas()
        If listaVentasAux.Count = 0 Then
            MessageBox.Show("Sin ventas que facturar")
            Return
        End If
        Dim listaVentasFacturas As List(Of Venta) = listaVentasAux

        For Each v As Venta In listaVentasFacturas
            If v.ClienteDeVenta = clienteSeleccionado.CodigoDelCliente Then
                Dim index As Integer = dg.Rows.Add()
                dg.Rows(index).Cells("idAlbaran").Value = v.FacturaDeVenta
                dg.Rows(index).Cells("fechaAlbaran").Value = v.FechaDeVenta
            End If
        Next
    End Sub
    Private Sub fillDatosCliente()
        lbl_telefono.Visible = False
        txt_telefono_cliente_factura.Visible = False
        lbl_nombre.Text = "Cliente"
        lbl_email.Text = "Email"
        lbl_grupo.Text = "Grupo"

        txt_cliente_factura.Text = clienteSeleccionado.NombreDelCliente
        txt_nif_cliente_factura.Text = clienteSeleccionado.NifDelCliente
        txt_grupo_cliente_factura.Text = getGrupoPorCodigo(clienteSeleccionado.GrupoDelCliente).NombreDeGrupo
        txt_email_cliente_factura.Text = clienteSeleccionado.EmailDelCliente
        txt_direccion_cliente_factura.Text = clienteSeleccionado.DireccionDelCliente
        txt_banco_factura.Text = getBancoPorCodigo(clienteSeleccionado.BancoDelCliente).NombreDeBanco
    End Sub
    Private Sub fillDatosProveedor()
        lbl_email.Text = "Población"
        lbl_grupo.Visible = False
        txt_grupo_cliente_factura.Visible = False
        lbl_telefono.Visible = True
        txt_telefono_cliente_factura.Visible = True

        txt_cliente_factura.Text = proveedorSeleccionado.NombreDeProveedor
        txt_nif_cliente_factura.Text = proveedorSeleccionado.NifDeProveedor
        txt_email_cliente_factura.Text = proveedorSeleccionado.PoblacionDeProveedor
        txt_direccion_cliente_factura.Text = proveedorSeleccionado.DireccionDeProveedor
        txt_telefono_cliente_factura.Text = proveedorSeleccionado.TelefonoDeProveedor
    End Sub
    Private Sub recalcularTotales()
        Dim txtFormaPago As String = ""
        brutoTotal = 0
        baseImponibleTotal = 0
        impuestoTotal = 0
        descuentoTotal = 0
        precioTotal = 0

        If entidadSeleccionada.Equals("Cliente") Then
            For Each s As String In listaAlbaranes
                Dim ventaTemp As Venta = getVentaPorFactura(s)
                If txtFormaPago.Equals("") Then
                    txtFormaPago = getFormaPagoPorCodigo(ventaTemp.FormaDePagoVenta).NombreDePago
                End If
                Dim articuloTemp As Articulo = getArticuloPorCodigo(ventaTemp.ArticuloDeVenta)

                brutoParcial = ventaTemp.PrecioDeArticuloVenta * ventaTemp.CantidadDeVenta
                baseImponibleParcial = brutoParcial * (1 - ventaTemp.DescuentoDeVenta / 100)
                impuestoParcial = brutoParcial * articuloTemp.ImpuestoDeArticulo / 100
                descuentoParcial = brutoParcial * (ventaTemp.DescuentoDeVenta / 100)

                brutoTotal += brutoParcial
                baseImponibleTotal += baseImponibleParcial
                impuestoTotal += impuestoParcial
                descuentoTotal += descuentoParcial
                precioTotal += baseImponibleParcial + impuestoParcial
            Next
        Else
            For Each s As String In listaAlbaranes
                Dim compraTemp As Compra = getCompraPorFactura(s)
                If txtFormaPago.Equals("") Then
                    txtFormaPago = getFormaPagoPorCodigo(compraTemp.FormaDePagoCompra).NombreDePago
                End If
                Dim articuloTemp As Articulo = getArticuloPorCodigo(compraTemp.ArticuloDeCompra)
                brutoParcial = compraTemp.PrecioDeArticuloCompra * compraTemp.CantidadDeCompra
                baseImponibleParcial = brutoParcial * (1 - compraTemp.DescuentoDeCompra / 100)
                impuestoParcial = brutoParcial * articuloTemp.ImpuestoDeArticulo / 100
                descuentoParcial = brutoParcial * (compraTemp.DescuentoDeCompra / 100)

                brutoTotal += brutoParcial
                baseImponibleTotal += baseImponibleParcial
                impuestoTotal += impuestoParcial
                descuentoTotal += descuentoParcial
                precioTotal += baseImponibleParcial + impuestoParcial
            Next
        End If
        txt_forma_pago_factura.Text = txtFormaPago
        txt_bruto_factura.Text = brutoTotal.ToString("N2")
        txt_base_imponible_factura.Text = baseImponibleTotal.ToString("N2")
        txt_descuento_factura.Text = descuentoTotal.ToString("N2")
        txt_impuestos_factura.Text = impuestoTotal.ToString("N2")
        txt_total_factura.Text = precioTotal.ToString("N2")
    End Sub
    Private Sub click_btn_facturar_factura(sender As Object, e As EventArgs) Handles btn_facturar_factura.Click
        Dim codigoNuevo As Integer = Convert.ToInt32(txt_referencia_factura.Text)
        Dim fechaFactura As DateTime = dp_factura.Value
        Dim tipoFactura As String
        If entidadSeleccionada.Equals("Cliente") Then
            tipoFactura = "V"
        Else
            tipoFactura = "C"
        End If
        Dim stringFacturas As String = ""
        For Each s As String In listaAlbaranes
            stringFacturas += $"{s},"
        Next

        Dim facturaNueva As Factura = New Factura(codigoNuevo, stringFacturas, fechaFactura, "Pagada", tipoFactura)
        facturaNueva.addFactura()
        MessageBox.Show("Factura cobrada")
        Me.Close()
    End Sub
End Class
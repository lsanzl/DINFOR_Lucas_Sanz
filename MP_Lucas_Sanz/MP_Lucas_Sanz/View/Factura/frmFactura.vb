Public Class frmFactura
    Private listaAlbaranes As List(Of String)
    Public clienteSeleccionado As Cliente
    Public proveedorSeleccionado As Proveedor
    Public formaPagoSeleccionada As FormaPago
    Public entidadSeleccionada As String
    Private codigoNuevo As Integer
    Private brutoTotal As Double
    Private brutoParcial As Double
    Private baseImponibleTotal As Double
    Private baseImponibleParcial As Double
    Private impuestoTotal As Double
    Private impuestoParcial As Double
    Private descuentoTotal As Double
    Private descuentoParcial As Double
    Private precioTotal As Double
    Private duplicado As Boolean
    Private nuevo As Boolean
    Private dg As DataGridView

    Public Sub New(nuevoP As Boolean)
        InitializeComponent()
        dg = dg_albaranes_factura
        listaAlbaranes = New List(Of String)
        brutoTotal = 0
        baseImponibleTotal = 0
        impuestoTotal = 0
        descuentoTotal = 0
        precioTotal = 0
        duplicado = False
        nuevo = nuevoP
        If nuevo Then
            Dim idFactura As Integer = managerFacturaAux.getIDFactura()
            txt_referencia_factura.Text = idFactura
        Else
            btn_modificar_factura.Visible = True
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
    Private Sub current_cell_dirty_state_changed_dg_albaranes(sender As Object, e As EventArgs) Handles dg_albaranes_factura.CurrentCellDirtyStateChanged
        If TypeOf dg.CurrentCell Is DataGridViewCheckBoxCell Then
            dg.CommitEdit(DataGridViewDataErrorContexts.Commit)
            checkCell(dg.CurrentCell)
        End If
    End Sub
    Private Sub checkCell(dgCurrent As DataGridViewCell)
        If dgCurrent.Value And Not duplicado Then
            listaAlbaranes.Add(dg.Rows(dgCurrent.RowIndex).Cells("idAlbaran").Value)
            duplicado = True
        ElseIf Not dgCurrent.Value Then
            listaAlbaranes.Remove(dg.Rows(dgCurrent.RowIndex).Cells("idAlbaran").Value)
        ElseIf duplicado Then
            duplicado = False
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
        dg.Rows.Clear()
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
    Public Sub fillDGCompras(listaComprasPasada As List(Of String))
        dg.Rows.Clear()
        Dim listaComprasMod As List(Of Compra) = listaComprasAux
        For Each c As Compra In listaComprasMod
            If c.ProveedorDeCompra = proveedorSeleccionado.CodigoDeProveedor Then
                Dim index As Integer = dg.Rows.Add()
                dg.Rows(index).Cells("idAlbaran").Value = c.FacturaDeCompra
                dg.Rows(index).Cells("fechaAlbaran").Value = c.FechaDeCompra
                If listaComprasPasada.Contains(c.FacturaDeCompra) Then
                    dg.Rows(index).Cells("incluidoAlbaran").Value = True
                End If
            End If
        Next
    End Sub
    Private Sub fillDGVentas()
        dg.Rows.Clear()
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
    Public Sub fillDGVentas(listaVentasPasada As List(Of String))
        dg.Rows.Clear()
        Dim listaVentasMod As List(Of Venta) = listaVentasAux
        For Each v As Venta In listaVentasMod
            If v.ClienteDeVenta = clienteSeleccionado.CodigoDelCliente Then
                Dim index As Integer = dg.Rows.Add()
                dg.Rows(index).Cells("idAlbaran").Value = v.FacturaDeVenta
                dg.Rows(index).Cells("fechaAlbaran").Value = v.FechaDeVenta
                If listaVentasPasada.Contains(v.FacturaDeVenta) Then
                    dg.Rows(index).Cells("incluidoAlbaran").Value = True
                End If
            End If
        Next
    End Sub
    Public Sub fillDatosCliente()
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
    Public Sub fillDatosProveedor()
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
                    formaPagoSeleccionada = getFormaPagoPorCodigo(ventaTemp.FormaDePagoVenta)
                    txtFormaPago = formaPagoSeleccionada.NombreDePago
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
                    formaPagoSeleccionada = getFormaPagoPorCodigo(compraTemp.FormaDePagoCompra)
                    txtFormaPago = formaPagoSeleccionada.NombreDePago
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
    Public Sub recalcularTotales(listadoAlbaranes As List(Of String))
        If entidadSeleccionada.Equals("Cliente") Then
            For Each s As String In listadoAlbaranes
                If s.StartsWith(" ") Then
                    Continue For
                End If
                Dim ventaTemp As Venta = getVentaPorFactura(s)
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
            For Each s As String In listadoAlbaranes
                If s.StartsWith(" ") Then
                    Continue For
                End If
                Dim compraTemp As Compra = getCompraPorFactura(s)
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
        txt_bruto_factura.Text = brutoTotal.ToString("N2")
        txt_base_imponible_factura.Text = baseImponibleTotal.ToString("N2")
        txt_descuento_factura.Text = descuentoTotal.ToString("N2")
        txt_impuestos_factura.Text = impuestoTotal.ToString("N2")
        txt_total_factura.Text = precioTotal.ToString("N2")
    End Sub
    Private Sub click_btn_facturar_factura(sender As Object, e As EventArgs) Handles btn_facturar_factura.Click
        facturar(True)
    End Sub
    Private Sub click_btn_modificar(sender As Object, e As EventArgs) Handles btn_modificar_factura.Click
        facturar(True)
    End Sub
    Private Sub click_btn_guardar_factura(sender As Object, e As EventArgs) Handles btn_guardar_factura.Click
        facturar(False)
    End Sub
    Private Sub facturar(cobrado As Boolean)
        codigoNuevo = Convert.ToInt32(txt_referencia_factura.Text)
        Dim fechaFactura As Date = dp_factura.Value
        Dim tipoFactura As String
        If entidadSeleccionada.Equals("Cliente") Then
            tipoFactura = "V"
        Else
            tipoFactura = "C"
        End If

        Dim stringFacturas As String = ""
        For Each s As String In getListaCompra()
            stringFacturas += $"{s},"
        Next

        Dim estado As String
        Dim msg As String
        If cobrado Then
            estado = "C"
            msg = "Factura cobrada"
        Else
            estado = "P"
            msg = "Factura guardada, pendiente de cobro"
        End If

        Dim facturaNueva As Factura = New Factura(codigoNuevo, stringFacturas, fechaFactura, estado, tipoFactura)
        If Not nuevo Then
            facturaNueva.modifyFactura()
            msg = "Factura modificada"
        Else
            facturaNueva.addFactura()
            crearVencimiento()
        End If
        MessageBox.Show(msg)
        Me.Close()
    End Sub
    Private Sub crearVencimiento()
        Dim plazosTotales As Integer = formaPagoSeleccionada.NumeroPlazosPago
        Dim importePorPago As Double = Math.Round(precioTotal / plazosTotales, 2)
        Dim fechaCobro As Date = dp_factura.Value.AddDays(formaPagoSeleccionada.PrimerPlazo)
        Dim venc As Vencimiento

        Dim totalParcial As Double = 0
        For i As Integer = 1 To plazosTotales
            If i = plazosTotales Then
                importePorPago = precioTotal - totalParcial
            End If
            totalParcial += importePorPago
            If entidadSeleccionada.Equals("Cliente") Then
                venc = New Vencimiento(codigoNuevo, clienteSeleccionado, formaPagoSeleccionada, plazosTotales, i, importePorPago, fechaCobro.AddDays((i - 1) * formaPagoSeleccionada.DiasPlazos), 0, 0)
            Else
                venc = New Vencimiento(codigoNuevo, proveedorSeleccionado, formaPagoSeleccionada, plazosTotales, i, importePorPago, fechaCobro.AddDays((i - 1) * formaPagoSeleccionada.DiasPlazos), 0, 0)
            End If
            venc.addVencimiento()
        Next
    End Sub
    Private Function getListaCompra() As List(Of String)
        Dim listaMarcados As List(Of String) = New List(Of String)
        For Each fila As DataGridViewRow In dg.Rows
            If fila.Cells("incluidoAlbaran").Value Then
                listaMarcados.Add(fila.Cells("idAlbaran").Value)
            End If
        Next
        Return listaMarcados
    End Function
    Private Sub click_btn_cancelar_factura(sender As Object, e As EventArgs) Handles btn_cancelar_factura.Click
        Me.Close()
    End Sub

End Class
Public Class ctrFactura
    Private frm As frmMain
    Private dg As DataGridView
    Private listaFacturas As List(Of Factura)
    Private clienteTemp As Cliente
    Private proveedorTemp As Proveedor
    Private facturaSeleccionada As Factura
    Private codigoCliente As Integer
    Private codigoProveedor As Integer
    Private tipoFactura As String = "Compras"

    Public Sub New(frmP As frmMain)
        MyBase.New()
        frm = frmP
        dg = frm.dg_facturas
        frm.rdb_facturas_compra.Checked = True

        AddHandler frm.btn_facturar_albaran.Click, AddressOf click_btn_facturar_albaran
        AddHandler frm.btn_eliminar_factura.Click, AddressOf click_btn_eliminar_factura
        AddHandler frm.rdb_facturas_compra.CheckedChanged, AddressOf checked_changed_gb_facturas
        AddHandler frm.rdb_facturas_venta.CheckedChanged, AddressOf checked_changed_gb_facturas
        AddHandler frm.dg_facturas.CellClick, AddressOf cell_click_dg_facturas
        AddHandler frm.dg_facturas.CellDoubleClick, AddressOf cell_double_click_dg_facturas
        AddHandler frm.btn_cambiar_estado_factura.Click, AddressOf click_btn_cambiar_estado_factura
        AddHandler frm.txt_busqueda_factura.TextChanged, AddressOf text_changed_txt_busqueda_factura
        AddHandler frm.dp_busqueda_inicio_factura.ValueChanged, AddressOf value_changed_dp_busqueda_inicio_factura
        AddHandler frm.dp_busqueda_fin_factura.ValueChanged, AddressOf value_changed_dp_busqueda_fin_factura
        AddHandler frm.btn_busqueda_factura.Click, AddressOf click_btn_busqueda_factura
        AddHandler frm.tab_main.SelectedIndexChanged, AddressOf selected_index_changed_tab_main
    End Sub

    Private Sub checked_changed_gb_facturas(sender As Object, e As EventArgs)
        If frm.rdb_facturas_compra.Checked Then
            tipoFactura = "Compras"
            fillDGFacturas()
        Else
            tipoFactura = "Ventas"
            fillDGFacturas()
        End If
    End Sub

    Private Sub fillDGFacturas()
        dg.Rows.Clear()
        listaFacturas = New List(Of Factura)
        listaFacturas = listaFacturasAux
        If tipoFactura.Equals("Compras") Then
            fillDGFacturasCompras(listaFacturas)
        Else
            fillDGFacturasVentas(listaFacturas)
        End If
        frm.dp_busqueda_inicio_factura.Format = DateTimePickerFormat.Custom
        frm.dp_busqueda_inicio_factura.CustomFormat = "Día inicio"
        frm.dp_busqueda_fin_factura.Format = DateTimePickerFormat.Custom
        frm.dp_busqueda_fin_factura.CustomFormat = "Día fin"
        frm.btn_cambiar_estado_factura.Enabled = False
    End Sub
    Private Sub fillDGFacturasCompras(listaFacturas As List(Of Factura))
        Dim cbAlbaranes As DataGridViewComboBoxCell
        For Each f As Factura In listaFacturas
            If f.TipoDeFactura.Equals("V") Then
                Continue For
            End If
            Dim index As Integer = dg.Rows.Add()
            codigoProveedor = getCompraPorFactura(f.ListaDeAlbaranes(0)).ProveedorDeCompra
            proveedorTemp = getProveedorPorCodigo(codigoProveedor)

            dg.Rows(index).Cells("idFactura").Value = f.CodigoDeFactura
            dg.Rows(index).Cells("entidadFactura").Value = proveedorTemp.NombreDeProveedor
            cbAlbaranes = New DataGridViewComboBoxCell()
            For Each stringFactura As String In f.ListaDeAlbaranes
                If stringFactura.Equals("") Then
                    Continue For
                End If
                cbAlbaranes.Items.Add(stringFactura)
            Next
            dg.Rows(index).Cells("listaAlbaranesFactura") = cbAlbaranes
            dg.Rows(index).Cells("estadoFactura").Value = f.EstadoDeFactura
            dg.Rows(index).Cells("fechaFactura").Value = f.FechaDeCobro
        Next
    End Sub
    Private Sub fillDGFacturasVentas(listaFacturas As List(Of Factura))
        Dim cbAlbaranes As DataGridViewComboBoxCell
        For Each f As Factura In listaFacturas
            If f.TipoDeFactura.Equals("C") Then
                Continue For
            End If
            Dim index As Integer = dg.Rows.Add()
            codigoCliente = getVentaPorFactura(f.ListaDeAlbaranes(0)).ClienteDeVenta
            clienteTemp = getClientePorCodigo(codigoCliente)

            dg.Rows(index).Cells("idFactura").Value = f.CodigoDeFactura
            dg.Rows(index).Cells("entidadFactura").Value = clienteTemp.NombreDelCliente
            cbAlbaranes = New DataGridViewComboBoxCell()
            For Each stringFactura As String In f.ListaDeAlbaranes
                If stringFactura.Equals("") Then
                    Continue For
                End If
                cbAlbaranes.Items.Add(stringFactura)
            Next
            dg.Rows(index).Cells("listaAlbaranesFactura") = cbAlbaranes
            dg.Rows(index).Cells("estadoFactura").Value = f.EstadoDeFactura
            dg.Rows(index).Cells("fechaFactura").Value = f.FechaDeCobro
        Next
    End Sub
    Private Sub click_btn_facturar_albaran(sender As Object, e As EventArgs)
        Dim frmF As frmFactura = New frmFactura(True)
        frmF.btn_busqueda_cliente.Visible = True
        frmF.ShowDialog()
        fillDGFacturas()
    End Sub
    Private Function lookForText(textoOrigen As String, textoBusqueda As String) As Boolean
        Dim resultado As Integer
        resultado = InStr(1, textoOrigen.ToUpper(), textoBusqueda.ToUpper())
        If resultado > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub text_changed_txt_busqueda_factura(sender As Object, e As EventArgs)
        Dim textoBusqueda As String = frm.txt_busqueda_factura.Text
        Dim dg As DataGridView = frm.dg_facturas

        If textoBusqueda = Nothing Then
            For Each fila As DataGridViewRow In dg.Rows
                fila.Visible = True
            Next
            Exit Sub
        End If
        For Each fila As DataGridViewRow In dg.Rows
            If lookForText(fila.Cells("entidadFactura").Value.ToString().Trim, textoBusqueda.Trim) Then
                dg.CurrentCell = Nothing
                fila.Visible = True
            Else
                dg.CurrentCell = Nothing
                fila.Visible = False
            End If
        Next
    End Sub
    Private Sub value_changed_dp_busqueda_inicio_factura(sender As Object, e As EventArgs)
        frm.dp_busqueda_inicio_factura.Format = DateTimePickerFormat.Short
        frm.dp_busqueda_inicio_factura.Value = frm.dp_busqueda_inicio_factura.Value
    End Sub
    Private Sub value_changed_dp_busqueda_fin_factura(sender As Object, e As EventArgs)
        frm.dp_busqueda_fin_factura.Format = DateTimePickerFormat.Short
        frm.dp_busqueda_fin_factura.Value = frm.dp_busqueda_fin_factura.Value
    End Sub
    Private Sub click_btn_busqueda_factura(sender As Object, e As EventArgs)
        Dim textoBusqueda As String = frm.txt_busqueda_factura.Text
        Dim dg As DataGridView = frm.dg_facturas
        Dim fechaInicio As Date = frm.dp_busqueda_inicio_factura.Value
        Dim fechaFin As Date = frm.dp_busqueda_fin_factura.Value
        If fechaInicio > fechaFin Then
            MessageBox.Show("Error de fecha")
            Return
        End If

        If Not textoBusqueda.Equals("") Then
            For Each fila As DataGridViewRow In dg.Rows
                If lookForText(fila.Cells("entidadFactura").Value.ToString().Trim, textoBusqueda.Trim) Then
                    dg.CurrentCell = Nothing
                    fila.Visible = True
                Else
                    dg.CurrentCell = Nothing
                    fila.Visible = False
                End If
            Next
        End If

        Dim fechaCheck As Date
        Dim f As Factura
        For Each fila As DataGridViewRow In dg.Rows
            f = getFacturaPorCodigo(fila.Cells("idFactura").Value)
            fechaCheck = f.FechaDeCobro
            If fechaCheck >= fechaInicio And fechaCheck <= fechaFin Then
                dg.CurrentCell = Nothing
                fila.Visible = True
            Else
                dg.CurrentCell = Nothing
                fila.Visible = False
            End If
        Next
    End Sub
    Private Sub cell_click_dg_facturas(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then
            Return
        End If
        facturaSeleccionada = getFacturaPorCodigo(dg.Rows(e.RowIndex).Cells("idFactura").Value)
        frm.btn_cambiar_estado_factura.Enabled = True
        If facturaSeleccionada.EstadoDeFactura.Equals("P") Then
            frm.btn_cambiar_estado_factura.Text = "MARCAR COMO COBRADO"
        Else
            frm.btn_cambiar_estado_factura.Text = "MARCAR COMO PENDIENTE"
        End If
    End Sub
    Private Sub cell_double_click_dg_facturas(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then
            Return
        End If
        Dim frmF As frmFactura = New frmFactura(False)
        If tipoFactura.Equals("Compras") Then
            Dim compraList As Compra = getCompraPorFactura(facturaSeleccionada.ListaDeAlbaranes(0))
            codigoProveedor = compraList.ProveedorDeCompra
            frmF.proveedorSeleccionado = getProveedorPorCodigo(codigoProveedor)
            frmF.fillDatosProveedor()
            frmF.fillDGCompras(facturaSeleccionada.ListaDeAlbaranes)
            frmF.txt_referencia_factura.Text = facturaSeleccionada.CodigoDeFactura
            frmF.dp_factura.Text = facturaSeleccionada.FechaDeCobro
            frmF.dp_factura.Enabled = False
            frmF.txt_forma_pago_factura.Text = getFormaPagoPorCodigo(compraList.FormaDePagoCompra).NombreDePago
            frmF.entidadSeleccionada = "Proveedor"
            frmF.recalcularTotales(facturaSeleccionada.ListaDeAlbaranes)
        Else
            Dim ventaList As Venta = getVentaPorFactura(facturaSeleccionada.ListaDeAlbaranes(0))
            codigoCliente = ventaList.ClienteDeVenta
            frmF.clienteSeleccionado = getClientePorCodigo(codigoCliente)
            frmF.fillDatosCliente()
            frmF.fillDGVentas(facturaSeleccionada.ListaDeAlbaranes)
            frmF.txt_referencia_factura.Text = facturaSeleccionada.CodigoDeFactura
            frmF.dp_factura.Text = facturaSeleccionada.FechaDeCobro
            frmF.dp_factura.Enabled = False
            frmF.txt_forma_pago_factura.Text = getFormaPagoPorCodigo(ventaList.FormaDePagoVenta).NombreDePago
            frmF.entidadSeleccionada = "Cliente"
            frmF.recalcularTotales(facturaSeleccionada.ListaDeAlbaranes)
        End If
        frmF.ShowDialog()
        fillDGFacturas()
    End Sub
    Private Sub click_btn_cambiar_estado_factura(sender As Object, e As EventArgs)
        managerFacturaAux.cambiarEstadoFactura(facturaSeleccionada)
        fillDGFacturas()
        If frm.btn_cambiar_estado_factura.Text.Equals("MARCAR COMO PAGADO") Then
            frm.btn_cambiar_estado_factura.Text = "MARCAR COMO PENDIENTE"
        Else
            frm.btn_cambiar_estado_factura.Text = "MARCAR COMO COBRADO"
        End If
        frm.btn_cambiar_estado_factura.Enabled = False
    End Sub
    Private Sub click_btn_eliminar_factura(sender As Object, e As EventArgs)
        facturaSeleccionada.deleteFactura()
        fillDGFacturas()
    End Sub
    Private Sub selected_index_changed_tab_main(sender As Object, e As EventArgs)
        If frm.tab_main.SelectedTab.Text.Equals("FACTURAS") Then
            fillDGFacturas()
        End If
    End Sub
End Class
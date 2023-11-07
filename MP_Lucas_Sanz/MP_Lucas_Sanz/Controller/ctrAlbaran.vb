Imports MP_Lucas_Sanz.VariablesGlobales

Public Class ctrAlbaran
    Dim frmAlbaran As frmMain
    Dim listaAlbaranVenta As List(Of Venta) = New List(Of Venta)
    Dim listaAlbaranCompra As List(Of Compra) = New List(Of Compra)
    Dim listaFacturas As List(Of String) = New List(Of String)
    Dim mostrarEliminados As Boolean = False
    Dim ventaTemp As Venta
    Dim compraTemp As Compra
    Dim clienteTemp As Cliente
    Dim proveedorTemp As Proveedor
    Dim formaTemp As FormaPago
    Dim fechaInicio As Date
    Dim fechaFin As Date
    Dim entidadBusqueda As String

    Public Sub New(frmAlbaranPasado As frmMain)
        MyBase.New()
        frmAlbaran = frmAlbaranPasado
        frmAlbaran.rdb_ver_ventas.Checked = True
        frmAlbaran.rdb_albaranes_activos.Checked = True

        AddHandler frmAlbaran.btn_eliminar_compra.Click, AddressOf click_btn_eliminar_compra
        AddHandler frmAlbaran.rdb_ver_ventas.CheckedChanged, AddressOf checked_changed_gb_ver_albaranes
        AddHandler frmAlbaran.rdb_ver_compras.CheckedChanged, AddressOf checked_changed_gb_ver_albaranes
        AddHandler frmAlbaran.rdb_albaranes_activos.CheckedChanged, AddressOf checked_changed_gb_estado_albaranes
        AddHandler frmAlbaran.rdb_albaranes_eliminados.CheckedChanged, AddressOf checked_changed_gb_estado_albaranes
        AddHandler frmAlbaran.dg_albaranes.CellClick, AddressOf cell_click_dg_albaranes
        AddHandler frmAlbaran.dg_albaranes.CellDoubleClick, AddressOf cell_double_click_dg_albaranes
        AddHandler frmAlbaran.txt_busqueda_albaran_factura.TextChanged, AddressOf text_changed_txt_busqueda_albaran_factura
        AddHandler frmAlbaran.dp_busqueda_inicio_albaran.ValueChanged, AddressOf value_changed_dp_busqueda_inicio_albaran
        AddHandler frmAlbaran.dp_busqueda_fin_albaran.ValueChanged, AddressOf value_changed_dp_busqueda_fin_albaran
        AddHandler frmAlbaran.txt_busqueda_albaran_entidad.TextChanged, AddressOf text_changed_txt_busqueda_albaran_entidad
        AddHandler frmAlbaran.tab_main.SelectedIndexChanged, AddressOf tab_main_SelectedIndexChanged
    End Sub
    Private Sub fillDGAlbaranes()
        resetDP()
        If albaranSeleccionado.Equals("Ventas") Then
            fillDGAlbaranesVentas()
        Else
            fillDGAlbaranesCompras()
        End If
    End Sub
    Private Sub fillDGAlbaranesVentas()
        Dim dg As DataGridView = frmAlbaran.dg_albaranes
        listaFacturas = New List(Of String)
        dg.Rows.Clear()
        listaAlbaranVenta = listaVentasAux
        For Each v As Venta In listaAlbaranVenta
            If v.VentaEliminada And Not mostrarEliminados Then
                Continue For
            ElseIf Not v.VentaEliminada And mostrarEliminados Then
                Continue For
            End If
            If listaFacturas.Contains(v.FacturaDeVenta) Then
                Continue For
            End If
            Dim index As Integer = dg.Rows.Add()
            clienteTemp = getClientePorCodigo(v.ClienteDeVenta)
            With dg.Rows(index)
                .Cells("idAlbaran").Value = v.CodigoDeVenta
                .Cells("personaAlbaran").Value = clienteTemp.NombreDelCliente
                .Cells("formaPagoAlbaran").Value = v.FormaDePagoVenta
                .Cells("fechaAlbaran").Value = v.FechaDeVenta
                .Cells("tipoAlbaran").Value = "V"
                .Cells("facturaAlbaran").Value = v.FacturaDeVenta
                .Cells("verAlbaran").Value = "VER VENTA"
            End With
            listaFacturas.Add(v.FacturaDeVenta)
        Next
    End Sub
    Private Sub fillDGAlbaranesCompras()
        Dim dg As DataGridView = frmAlbaran.dg_albaranes
        listaFacturas = New List(Of String)
        dg.Rows.Clear()
        listaAlbaranCompra = listaComprasAux
        For Each c As Compra In listaAlbaranCompra
            If c.CompraEliminada And Not mostrarEliminados Then
                Continue For
            ElseIf Not c.CompraEliminada And mostrarEliminados Then
                Continue For
            End If
            If listaFacturas.Contains(c.FacturaDeCompra) Then
                Continue For
            End If
            Dim index As Integer = dg.Rows.Add()
            proveedorTemp = getProveedorPorCodigo(c.ProveedorDeCompra)
            With dg.Rows(index)
                .Cells("idAlbaran").Value = c.CodigoDeCompra
                .Cells("personaAlbaran").Value = proveedorTemp.NombreDeProveedor
                .Cells("formaPagoAlbaran").Value = c.FormaDePagoCompra
                .Cells("fechaAlbaran").Value = c.FechaDeCompra
                .Cells("tipoAlbaran").Value = "C"
                .Cells("facturaAlbaran").Value = c.FacturaDeCompra
                .Cells("verAlbaran").Value = "VER COMPRA"
            End With
            listaFacturas.Add(c.FacturaDeCompra)
        Next
    End Sub
    Private Sub checked_changed_gb_ver_albaranes(sender As Object, e As EventArgs)
        If frmAlbaran.rdb_ver_ventas.Checked Then
            albaranSeleccionado = "Ventas"
        Else
            albaranSeleccionado = "Compras"
        End If
        fillDGAlbaranes()
    End Sub
    Private Sub checked_changed_gb_estado_albaranes(sender As Object, e As EventArgs)
        If frmAlbaran.rdb_albaranes_activos.Checked Then
            mostrarEliminados = False
            frmAlbaran.btn_eliminar_compra.Text = "Eliminar"
        Else
            mostrarEliminados = True
            frmAlbaran.btn_eliminar_compra.Text = "Recuperar"
        End If
        fillDGAlbaranes()
    End Sub
    Private Sub cell_click_dg_albaranes(sender As Object, e As DataGridViewCellEventArgs)
        If Not e.RowIndex >= 0 Then
            Return
        End If
        ventaTemp = Nothing
        compraTemp = Nothing
        Dim currentCelll As DataGridViewCell = frmAlbaran.dg_albaranes.CurrentCell
        Dim codigo As Integer = frmAlbaran.dg_albaranes.Rows(e.RowIndex).Cells("idAlbaran").Value
        If albaranSeleccionado.Equals("Ventas") Then
            ventaTemp = getVentaPorCodigo(codigo)
        Else
            compraTemp = getCompraPorCodigo(codigo)
        End If
        If currentCelll.Value.Equals("VER VENTA") Then
            showVenta(ventaTemp)
        ElseIf currentCelll.Value.Equals("VER COMPRA") Then
            showCompra(compraTemp)
        End If
    End Sub
    Private Sub cell_double_click_dg_albaranes(sender As Object, e As DataGridViewCellEventArgs)
        If Not e.RowIndex >= 0 Then
            Return
        End If
        If albaranSeleccionado.Equals("Ventas") Then
            showVenta(ventaTemp)
        Else
            showCompra(compraTemp)
        End If
    End Sub
    Private Sub click_btn_eliminar_compra(sender As Object, e As EventArgs)
        If albaranSeleccionado = "Compras" Then
            compraTemp.deleteCompra()
        Else
            ventaTemp.deleteVenta()
        End If
        fillDGAlbaranes()
    End Sub
    Private Sub showVenta(ventaTemp As Venta)
        Dim listaVentasFactura As List(Of Venta) = New List(Of Venta)
        Dim frm As frmVenta = New frmVenta()
        Dim articuloTemp As Articulo = getArticuloPorCodigo(ventaTemp.ArticuloDeVenta)

        clienteTemp = getClientePorCodigo(ventaTemp.ClienteDeVenta)
        formaTemp = getFormaPagoPorCodigo(ventaTemp.FormaDePagoVenta)
        For Each v As Venta In listaVentasAux
            If v.FacturaDeVenta.Equals(ventaTemp.FacturaDeVenta) Then
                listaVentasFactura.Add(v)
            End If
        Next
        With frm
            .txt_cliente_seleccionado.Text = clienteTemp.NombreDelCliente
            .txt_articulo_seleccionado_venta.Text = articuloTemp.NombreDeArticulo
            .cb_forma_pago_seleccionada_venta.SelectedValue = formaTemp.NombreDePago
            .dp_fecha_venta.Value = ventaTemp.FechaDeVenta
            .fillDGVentas(listaVentasFactura)
            .ShowDialog()
        End With
        fillDGAlbaranes()
    End Sub
    Private Sub showCompra(compraTemp As Compra)
        Dim listaComprasFactura As List(Of Compra) = New List(Of Compra)
        Dim frm As frmCompra = New frmCompra()
        Dim articuloTemp As Articulo = getArticuloPorCodigo(compraTemp.ArticuloDeCompra)

        proveedorTemp = getProveedorPorCodigo(compraTemp.ProveedorDeCompra)
        formaTemp = getFormaPagoPorCodigo(compraTemp.FormaDePagoCompra)
        For Each c As Compra In listaComprasAux
            If c.FacturaDeCompra.Equals(compraTemp.FacturaDeCompra) Then
                listaComprasFactura.Add(c)
            End If
        Next
        With frm
            .txt_proveedor_seleccionado.Text = proveedorTemp.NombreDeProveedor
            .txt_articulo_seleccionado.Text = articuloTemp.NombreDeArticulo
            .cb_forma_pago_seleccionada.SelectedValue = formaTemp.NombreDePago
            .dp_fecha_compra.Value = compraTemp.FechaDeCompra
            .fillDGCompras(listaComprasFactura)
            .ShowDialog()
        End With
        fillDGAlbaranes()
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
    Private Sub text_changed_txt_busqueda_albaran_factura(sender As Object, e As EventArgs)
        Dim textoBusqueda As String = frmAlbaran.txt_busqueda_albaran_factura.Text
        Dim dg As DataGridView = frmAlbaran.dg_albaranes

        If textoBusqueda.Equals("") Then
            For Each fila As DataGridViewRow In dg.Rows
                fila.Visible = True
            Next
            Exit Sub
        End If
        For Each fila As DataGridViewRow In dg.Rows
            If lookForText(fila.Cells("facturaAlbaran").Value.ToString().Trim, textoBusqueda.Trim()) Then
                dg.CurrentCell = Nothing
                fila.Visible = True
            Else
                dg.CurrentCell = Nothing
                fila.Visible = False
            End If
        Next
    End Sub
    Private Sub text_changed_txt_busqueda_albaran_entidad(sender As Object, e As EventArgs)
        entidadBusqueda = frmAlbaran.txt_busqueda_albaran_entidad.Text
        busquedaFechaEntidad()
    End Sub
    Private Sub resetDP()
        Dim dpInicio As DateTimePicker = frmAlbaran.dp_busqueda_inicio_albaran
        Dim dpFin As DateTimePicker = frmAlbaran.dp_busqueda_fin_albaran
        fechaInicio = Nothing
        fechaFin = Nothing
        frmAlbaran.txt_busqueda_albaran_entidad.Clear()
        frmAlbaran.txt_busqueda_albaran_factura.Clear()
        dpInicio.CustomFormat = "Inicio"
        dpFin.CustomFormat = "Fin"
        dpInicio.Format = DateTimePickerFormat.Custom
        dpFin.Format = DateTimePickerFormat.Custom
    End Sub
    Private Sub value_changed_dp_busqueda_inicio_albaran(sender As Object, e As EventArgs)
        Dim dpInicio As DateTimePicker = frmAlbaran.dp_busqueda_inicio_albaran
        fechaInicio = dpInicio.Value
        dpInicio.Format = DateTimePickerFormat.Short
        dpInicio.CustomFormat = ""
        busquedaFechaEntidad()
    End Sub
    Private Sub value_changed_dp_busqueda_fin_albaran(sender As Object, e As EventArgs)
        Dim dpFin As DateTimePicker = frmAlbaran.dp_busqueda_fin_albaran
        fechaFin = dpFin.Value
        dpFin.Format = DateTimePickerFormat.Short
        dpFin.CustomFormat = ""
        busquedaFechaEntidad()
    End Sub
    Private Sub busquedaFechaEntidad()
        Dim dg As DataGridView = frmAlbaran.dg_albaranes
        Dim visibilidad As Boolean
        If fechaFin = Nothing And fechaInicio = Nothing And entidadBusqueda = Nothing Then
            For Each fila As DataGridViewRow In dg.Rows
                fila.Visible = True
            Next
            Exit Sub
        End If
        For Each fila As DataGridViewRow In dg.Rows
            visibilidad = True
            If Not entidadBusqueda = Nothing Then
                If Not lookForText(fila.Cells("personaAlbaran").Value, entidadBusqueda) Then
                    visibilidad = False
                End If
            End If
            If Not fechaInicio = Nothing Then
                If CDate(fila.Cells("fechaAlbaran").Value) < fechaInicio Then
                    visibilidad = False
                End If
            End If
            If Not fechaFin = Nothing Then
                If CDate(fila.Cells("fechaAlbaran").Value) > fechaFin Then
                    visibilidad = False
                End If
            End If
            fila.Visible = visibilidad
        Next
    End Sub
    Private Sub tab_main_SelectedIndexChanged(sender As Object, e As EventArgs)
        If frmAlbaran.tab_main.SelectedTab.Text.Equals("ALBARANES") Then
            fillDGAlbaranes()
            If albaranSeleccionado = "Ventas" Then
                frmAlbaran.rdb_ver_ventas.Checked = True
            Else
                frmAlbaran.rdb_ver_compras.Checked = True
            End If
        End If
    End Sub
End Class
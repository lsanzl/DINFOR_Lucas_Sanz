Imports System.ComponentModel
Imports CrystalDecisions.Shared

Public Class frmCompra
    Dim listaFormasPago As List(Of FormaPago) = New List(Of FormaPago)
    Dim listaCompras As List(Of Compra) = New List(Of Compra)
    Dim listaComprasEliminadas As List(Of Compra) = New List(Of Compra)
    Dim compraTemp As Compra = New Compra()
    Dim modificacion As Boolean = False
    Dim verAlbaran As Boolean = True
    Dim dt As New DataTable()
    Dim proveedorSeleccionado As Proveedor
    Dim articuloSeleccionado As Articulo
    Dim facturaGenerada As String
    Dim doubleParse As Double
    Dim brutoTotal As Double
    Dim baseImponibleTotal As Double
    Dim impuestoTotal As Double
    Dim precioTotal As Double

    Private Sub frmCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaComprasEliminadas = New List(Of Compra)
        facturaGenerada = compraAux.getRandomFactura()
        fillFields()
    End Sub

    Private Sub click_btn_busqueda_proveedor(sender As Object, e As EventArgs) Handles btn_busqueda_proveedor.Click
        Dim frmBusquedaNuevo As frmBusqueda = New frmBusqueda(proveedorAux)
        frmBusquedaNuevo.Text = "BÚSQUEDA DE PROVEEDORES"
        frmBusquedaNuevo.ShowDialog()
        proveedorSeleccionado = frmBusquedaNuevo.proveedorSeleccionado
        If proveedorSeleccionado IsNot Nothing Then
            proveedorSeleccionado = frmBusquedaNuevo.proveedorSeleccionado
            txt_proveedor_seleccionado.Text = proveedorSeleccionado.NombreDeProveedor
        End If
    End Sub
    Private Sub click_btn_busqueda_articulo(sender As Object, e As EventArgs) Handles btn_busqueda_articulo.Click
        Dim frmBusquedaNuevo As frmBusqueda = New frmBusqueda(articuloAux)
        frmBusquedaNuevo.Text = "BÚSQUEDA DE ARTÍCULOS"
        frmBusquedaNuevo.ShowDialog()
        articuloSeleccionado = frmBusquedaNuevo.articuloSeleccionado
        txt_articulo_seleccionado.Text = articuloSeleccionado.NombreDeArticulo
    End Sub
    Private Sub clearFields()
        txt_proveedor_seleccionado.Clear()
        txt_cantidad_seleccionada.Clear()
        txt_articulo_seleccionado.Clear()
        lbl_total_compra.Visible = False
        lbl_bruto.Visible = False
        lbl_base_imponible.Visible = False
        lbl_impuesto.Visible = False
        lbl_bruto.Text = Nothing
        lbl_base_imponible.Text = Nothing
        lbl_impuesto.Text = Nothing
        lbl_total_compra.Text = Nothing

        dt.Clear()
        cb_forma_pago_seleccionada.DataSource = Nothing
        cb_forma_pago_seleccionada.Items.Clear()
        cb_forma_pago_seleccionada.SelectedIndex = -1

        btn_modificar_compra.Enabled = False
        btn_eliminar_compra.Enabled = False
        btn_confirmar_compra.Enabled = False
        btn_busqueda_proveedor.Enabled = True

        listaFormasPago = formaPagoAux.getFormasPago()

        If Not dt.Columns.Contains("Nombre") Then
            dt.Columns.Add("Nombre")
            dt.Columns.Add("Codigo")
        End If
        For Each formilla As FormaPago In listaFormasPago
            Dim fila As DataRow = dt.NewRow()
            fila("Nombre") = formilla.NombreDePago
            fila("Codigo") = formilla.CodigoDePago
            dt.Rows.Add(fila)
        Next
        cb_forma_pago_seleccionada.DataSource = dt
        cb_forma_pago_seleccionada.DisplayMember = "Nombre"
        cb_forma_pago_seleccionada.ValueMember = "Codigo"
        cb_forma_pago_seleccionada.SelectedIndex = -1
    End Sub
    Private Sub clearFieldsDatos()
        txt_articulo_seleccionado.Clear()
        txt_cantidad_seleccionada.Clear()
        txt_descuento_compra.Clear()
        cb_forma_pago_seleccionada.SelectedIndex = -1
    End Sub
    Private Sub fillFields()
        listaFormasPago = formaPagoAux.getFormasPago()

        If Not dt.Columns.Contains("Nombre") Then
            dt.Columns.Add("Nombre")
            dt.Columns.Add("Codigo")
        End If
        For Each formilla As FormaPago In listaFormasPago
            Dim fila As DataRow = dt.NewRow()
            fila("Nombre") = formilla.NombreDePago
            fila("Codigo") = formilla.CodigoDePago
            dt.Rows.Add(fila)
        Next
        cb_forma_pago_seleccionada.DataSource = dt
        cb_forma_pago_seleccionada.DisplayMember = "Nombre"
        cb_forma_pago_seleccionada.ValueMember = "Codigo"
        cb_forma_pago_seleccionada.SelectedIndex = -1
    End Sub

    Public Function checkCampos() As Boolean
        If String.IsNullOrEmpty(txt_proveedor_seleccionado.Text) Then
            MessageBox.Show("Seleccione primero proveedor")
            Return False
        End If
        If String.IsNullOrEmpty(txt_articulo_seleccionado.Text) Then
            MessageBox.Show("Seleccione primero artículo")
            Return False
        End If
        If cb_forma_pago_seleccionada.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione primero forma de pago")
            Return False
        End If
        If String.IsNullOrEmpty(txt_cantidad_seleccionada.Text) Or Not IsNumeric(txt_cantidad_seleccionada.Text) Then
            MessageBox.Show("Introduzca cantidad válida")
            Return False
        End If
        If Not String.IsNullOrEmpty(txt_descuento_compra.Text) And Not Double.TryParse(txt_descuento_compra.Text, doubleParse) Then
            MessageBox.Show("Introduzca descuento válido")
            Return False
        End If
        Return True
    End Function

    Private Sub click_btn_añadir_compra(sender As Object, e As EventArgs) Handles btn_añadir_compra.Click
        añadirCompra()
    End Sub
    Private Sub añadirCompra()
        If Not checkCampos() Then
            Return
        End If
        compraTemp = New Compra()
        Dim codigoArticuloSeleccionado As Integer = articuloSeleccionado.CodigoDeArticulo
        Dim formaPagoSeleccionada As Integer = cb_forma_pago_seleccionada.SelectedValue
        Dim cantidadSeleccionada As Integer = Convert.ToInt32(txt_cantidad_seleccionada.Text)
        Dim precioCompra As Double = Convert.ToDouble(managerArticuloAux.getCampoArticulo(codigoArticuloSeleccionado, "PRECIO_COMPRA_ARTICULO"))
        Dim porcBeneficio As Double = Convert.ToDouble(managerArticuloAux.getCampoArticulo(codigoArticuloSeleccionado, "PORC_BENEFICIO_ARTICULO"))
        Dim fechaCompra As Date = dp_fecha_compra.Value
        Dim descuentoCompra As Double = Convert.ToDouble(txt_descuento_compra.Text)

        Dim precioVenta As Double = precioCompra * (1 + porcBeneficio / 100)
        Dim codigoCompra As Integer = managerCompraAux.getIDCompra()

        compraTemp = New Compra(codigoCompra, proveedorSeleccionado.CodigoDeProveedor, codigoArticuloSeleccionado, formaPagoSeleccionada, precioVenta, cantidadSeleccionada, fechaCompra, False, facturaGenerada, descuentoCompra)
        listaCompras.Add(compraTemp)
        fillDGCompras()
        clearFieldsDatos()
        calcularTotal()
        modificacion = True
    End Sub
    Private Sub eliminarCompra()
        Dim cantidadDevuelta As Integer = compraTemp.CantidadDeCompra
        Dim articuloDevuelto As Integer = compraTemp.ArticuloDeCompra
        managerInventarioAux.deleteUnidades(cantidadDevuelta, articuloDevuelto)
        If verAlbaran Then
            listaComprasEliminadas.Add(compraTemp)
        End If
        listaCompras.Remove(compraTemp)
        btn_eliminar_compra.Enabled = False
        btn_modificar_compra.Enabled = False
        fillDGCompras()
        calcularTotal()
        modificacion = True
    End Sub
    Private Sub click_btn_eliminar_compra(sender As Object, e As EventArgs) Handles btn_eliminar_compra.Click
        eliminarCompra()
    End Sub
    Private Sub click_btn_modificar_compra(sender As Object, e As EventArgs) Handles btn_modificar_compra.Click
        If btn_modificar_compra.Text.Equals("MODIFICAR") Then
            Dim articuloTemp As Articulo = VariablesGlobales.getArticuloPorCodigo(compraTemp.ArticuloDeCompra)
            Dim proveedorTemp As Proveedor = VariablesGlobales.getProveedorPorCodigo(compraTemp.ProveedorDeCompra)
            txt_articulo_seleccionado.Text = articuloTemp.NombreDeArticulo
            txt_proveedor_seleccionado.Text = proveedorTemp.NombreDeProveedor
            txt_cantidad_seleccionada.Text = compraTemp.CantidadDeCompra
            txt_descuento_compra.Text = compraTemp.DescuentoDeCompra
            cb_forma_pago_seleccionada.SelectedValue = compraTemp.FormaDePagoCompra
            btn_modificar_compra.Text = "CONFIRMAR"
        Else
            articuloSeleccionado = VariablesGlobales.getArticuloPorNombre(txt_articulo_seleccionado.Text)
            proveedorSeleccionado = VariablesGlobales.getProveedorPorCodigo(compraTemp.ProveedorDeCompra)
            eliminarCompra()
            añadirCompra()
            btn_modificar_compra.Text = "MODIFICAR"
            btn_modificar_compra.Enabled = False
            btn_eliminar_compra.Enabled = False
            modificacion = True
        End If
    End Sub
    Private Sub fillDGCompras()
        dg_compras.Rows.Clear()
        Dim articuloItem As Articulo
        For Each item As Compra In listaCompras
            Dim index As Integer = dg_compras.Rows.Add()
            articuloItem = VariablesGlobales.getArticuloPorCodigo(item.ArticuloDeCompra)
            Dim baseImponible As Double = item.PrecioDeArticuloCompra * (1 - item.DescuentoDeCompra / 100)
            Dim impuesto As Double = baseImponible * (articuloItem.ImpuestoDeArticulo / 100)

            dg_compras.Rows(index).Cells("idCompra").Value = item.CodigoDeCompra
            dg_compras.Rows(index).Cells("proveedorCompra").Value = item.ProveedorDeCompra
            dg_compras.Rows(index).Cells("articuloCompra").Value = articuloItem.NombreDeArticulo
            dg_compras.Rows(index).Cells("formaPagoCompra").Value = item.FormaDePagoCompra
            dg_compras.Rows(index).Cells("precioUnitario").Value = item.PrecioDeArticuloCompra
            dg_compras.Rows(index).Cells("precioBrutoCompra").Value = item.PrecioDeArticuloCompra * item.CantidadDeCompra
            dg_compras.Rows(index).Cells("cantidadCompra").Value = item.CantidadDeCompra
            dg_compras.Rows(index).Cells("descuentoCompra").Value = item.DescuentoDeCompra
            dg_compras.Rows(index).Cells("baseImponibleCompra").Value = baseImponible * item.CantidadDeCompra
            dg_compras.Rows(index).Cells("impuestoCompra").Value = impuesto * item.CantidadDeCompra
            dg_compras.Rows(index).Cells("precioTotalCompra").Value = (baseImponible + impuesto) * item.CantidadDeCompra
        Next
        If dg_compras.RowCount > 0 Then
            btn_confirmar_compra.Enabled = True
            btn_busqueda_proveedor.Enabled = False
            cb_forma_pago_seleccionada.Enabled = False
        Else
            btn_confirmar_compra.Enabled = False
            btn_busqueda_proveedor.Enabled = True
            cb_forma_pago_seleccionada.Enabled = True
        End If
        dg_compras.ClearSelection()
    End Sub
    Public Sub fillDGCompras(listaComprasPasada As List(Of Compra))
        RemoveHandler dg_compras.CellEndEdit, AddressOf cell_end_edit_dg_compras
        'modificacion = True
        verAlbaran = True
        listaCompras = New List(Of Compra)
        listaCompras = listaComprasPasada
        facturaGenerada = listaComprasPasada(0).FacturaDeCompra
        dg_compras.Rows.Clear()
        Dim articuloItem As Articulo
        Dim proveedorTemp As Proveedor = VariablesGlobales.getProveedorPorCodigo(listaCompras(0).ProveedorDeCompra)
        For Each item As Compra In listaCompras
            Dim index As Integer = dg_compras.Rows.Add()
            articuloItem = managerArticuloAux.getArticuloConcreto(item.ArticuloDeCompra)
            Dim baseImponible As Double = item.PrecioDeArticuloCompra * (1 - item.DescuentoDeCompra / 100)
            Dim impuesto As Double = baseImponible * (articuloItem.ImpuestoDeArticulo / 100)

            dg_compras.Rows(index).Cells("idCompra").Value = item.CodigoDeCompra
            dg_compras.Rows(index).Cells("proveedorCompra").Value = proveedorTemp.NombreDeProveedor
            dg_compras.Rows(index).Cells("articuloCompra").Value = articuloItem.NombreDeArticulo
            dg_compras.Rows(index).Cells("formaPagoCompra").Value = item.FormaDePagoCompra
            dg_compras.Rows(index).Cells("precioUnitario").Value = item.PrecioDeArticuloCompra
            dg_compras.Rows(index).Cells("precioBrutoCompra").Value = item.PrecioDeArticuloCompra * item.CantidadDeCompra
            dg_compras.Rows(index).Cells("cantidadCompra").Value = item.CantidadDeCompra
            dg_compras.Rows(index).Cells("descuentoCompra").Value = item.DescuentoDeCompra
            dg_compras.Rows(index).Cells("baseImponibleCompra").Value = baseImponible * item.CantidadDeCompra
            dg_compras.Rows(index).Cells("impuestoCompra").Value = impuesto * item.CantidadDeCompra
            dg_compras.Rows(index).Cells("precioTotalCompra").Value = (baseImponible + impuesto) * item.CantidadDeCompra
        Next
        If dg_compras.RowCount > 0 Then
            btn_confirmar_compra.Enabled = True
            btn_busqueda_proveedor.Enabled = False
            cb_forma_pago_seleccionada.Enabled = False
        Else
            btn_confirmar_compra.Enabled = False
            btn_busqueda_proveedor.Enabled = True
            cb_forma_pago_seleccionada.Enabled = True
        End If
        dg_compras.ClearSelection()
        AddHandler dg_compras.CellEndEdit, AddressOf cell_end_edit_dg_compras
    End Sub
    Private Sub calcularTotal()
        lbl_total_compra.Visible = True
        lbl_bruto.Visible = True
        lbl_base_imponible.Visible = True
        lbl_impuesto.Visible = True

        brutoTotal = 0
        baseImponibleTotal = 0
        impuestoTotal = 0
        precioTotal = 0
        Dim baseImponibleTemp As Double
        Dim impuestoTemp As Double
        Dim articuloTemp As Articulo

        For Each comprilla As Compra In listaCompras
            articuloTemp = VariablesGlobales.getArticuloPorCodigo(comprilla.ArticuloDeCompra)
            baseImponibleTemp = comprilla.PrecioDeArticuloCompra * (1 - comprilla.DescuentoDeCompra / 100)
            impuestoTemp = baseImponibleTemp * (articuloTemp.ImpuestoDeArticulo / 100)
            brutoTotal += comprilla.PrecioDeArticuloCompra * comprilla.CantidadDeCompra
            baseImponibleTotal += baseImponibleTemp * comprilla.CantidadDeCompra
            impuestoTotal += impuestoTemp * comprilla.CantidadDeCompra
            precioTotal += (baseImponibleTemp + impuestoTemp) * comprilla.CantidadDeCompra
        Next
        If brutoTotal = 0 Then
            lbl_total_compra.Visible = False
            lbl_bruto.Visible = False
            lbl_base_imponible.Visible = False
            lbl_impuesto.Visible = False
        End If
        lbl_total_compra.Text = $"Precio total: {precioTotal.ToString("N2")}€"
        lbl_bruto.Text = $"Bruto total: {brutoTotal.ToString("N2")}"
        lbl_base_imponible.Text = $"Base imponible total: {baseImponibleTotal.ToString("N2")}"
        lbl_impuesto.Text = $"Impuesto total: {impuestoTotal.ToString("N2")}"
    End Sub

    Private Sub click_cell_dg_compras(sender As Object, e As DataGridViewCellEventArgs) Handles dg_compras.CellClick
        If e.RowIndex >= 0 Then
            btn_eliminar_compra.Enabled = True
            btn_modificar_compra.Enabled = True
            Dim codigoTemp As Integer = dg_compras.Rows(e.RowIndex).Cells("idCompra").Value
            compraTemp = listaCompras.Find(Function(c) c.CodigoDeCompra = codigoTemp)
        End If
    End Sub
    Private Sub click_btn_guardar_pdf(sender As Object, e As EventArgs) Handles btn_guardar_pdf.Click
        If dg_compras.RowCount = 0 Then
            MessageBox.Show("Introduzca primero alguna compra")
            Return
        End If

        Dim infCompra As infCompra = New infCompra(listaCompras, dp_fecha_compra.Value, brutoTotal, baseImponibleTotal, impuestoTotal, precioTotal)
        Dim report As rptCompra = infCompra.getReport()

        Dim exportPath As String = "C:\Users\Puesto\Desktop\Reportes\Compras\"
        Dim exportedFile As String = exportPath + facturaGenerada + ".pdf"
        If Not System.IO.Directory.Exists(exportPath) Then
            System.IO.Directory.CreateDirectory(exportPath)
        End If
        Try
            Dim cExportOptions As ExportOptions
            Dim cFinalDestination As New DiskFileDestinationOptions
            Dim cFormatOptions As New PdfRtfWordFormatOptions

            cFinalDestination.DiskFileName = exportedFile
            cExportOptions = report.ExportOptions

            With cExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .ExportDestinationOptions = cFinalDestination
                .ExportFormatOptions = cFormatOptions
            End With
            report.Export()
            MessageBox.Show("PDF guardado")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub click_btn_confirmar_compra(sender As Object, e As EventArgs) Handles btn_confirmar_compra.Click
        If dg_compras.RowCount = 0 Then
            MessageBox.Show("Introduzca primero alguna compra")
            Return
        End If
        If Not modificacion And verAlbaran Then
            Me.Close()
            Return
        End If
        Dim fechaCompra As Date = dp_fecha_compra.Value
        Dim movimientoTemp As Movimiento = New Movimiento()
        Dim stockActual As Integer
        If listaComprasEliminadas.Count > 0 Then
            For Each itemDel As Compra In listaComprasEliminadas
                itemDel.deleteCompra()
            Next
        End If

        For Each item As Compra In listaCompras
            If VariablesGlobales.listaComprasAux.Contains(item) Then
                item.modifyCompra()
            Else
                item.addCompra()
            End If
            Dim articuloFind As Articulo = VariablesGlobales.getArticuloPorCodigo(item.ArticuloDeCompra)
            If Not managerInventarioAux.checkInventario(articuloFind) Then
                Dim inventarioTemp As Inventario = New Inventario(articuloFind.CodigoDeArticulo, item.CantidadDeCompra)
                inventarioTemp.addInventario()
            Else
                managerInventarioAux.addUnidades(item.CantidadDeCompra, articuloFind.CodigoDeArticulo)
            End If
            stockActual = managerInventarioAux.checkStock(articuloFind.CodigoDeArticulo)
            movimientoTemp = New Movimiento("C", facturaGenerada, item.ProveedorDeCompra, fechaCompra, articuloFind.CodigoDeArticulo, stockActual, item.CantidadDeCompra)
            movimientoTemp.addMovimiento()
        Next

        Dim result As DialogResult = MessageBox.Show("¿Desea ver la factura de compra?", "Factura generada", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            clearFields()
            Me.Close()
            Exit Sub
        End If
        Dim informe As infCompra = New infCompra(listaCompras, fechaCompra, brutoTotal, baseImponibleTotal, impuestoTotal, precioTotal)
        informe.showReport()
        clearFields()
    End Sub
    Private Sub cell_end_edit_dg_compras(sender As Object, e As DataGridViewCellEventArgs) Handles dg_compras.CellEndEdit
        Dim precioBrutoNuevo As Double
        If dg_compras.Columns(e.ColumnIndex).Name = "precioUnitario" AndAlso e.RowIndex >= 0 Then
            precioBrutoNuevo = dg_compras.Rows(e.RowIndex).Cells("precioUnitario").Value
            listaCompras.Remove(compraTemp)
            compraTemp.PrecioDeArticuloCompra = precioBrutoNuevo
            listaCompras.Add(compraTemp)
            Dim dr As DialogResult = MessageBox.Show("¿Desea cambiar el precio de compra del producto?", "Nuevo precio compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (dr = DialogResult.Yes) Then
                Dim articuloMod As Articulo = VariablesGlobales.getArticuloPorCodigo(compraTemp.ArticuloDeCompra)
                articuloMod.PVPCompraDeArticulo = precioBrutoNuevo
                articuloMod.modifyArticulo()
            End If
            calcularTotal()
        End If
    End Sub
    Private Sub closed_frm_compra(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        clearFields()
        clearFieldsDatos()
        listaCompras = New List(Of Compra)
        fillDGCompras()
    End Sub
End Class
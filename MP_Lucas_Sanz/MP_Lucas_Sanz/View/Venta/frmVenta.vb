Imports System.ComponentModel
Imports CrystalDecisions.Shared

Public Class frmVenta
    Dim listaFormasPago As List(Of FormaPago) = New List(Of FormaPago)
    Dim listaVentas As List(Of Venta) = New List(Of Venta)
    Dim listaVentasEliminadas As List(Of Venta) = New List(Of Venta)
    Dim borrado As Boolean
    Dim modificacion As Boolean = False
    Dim verAlbaran As Boolean = False
    Dim ventaTemp As Venta = New Venta()
    Dim dt As New DataTable()
    Dim clienteSeleccionado As Cliente = Nothing
    Dim articuloSeleccionado As Articulo = Nothing
    Dim facturaGenerada As String
    Dim doubleParse As Double
    Dim brutoTotal As Double
    Dim baseImponibleTotal As Double
    Dim impuestoTotal As Double
    Dim precioTotal As Double

    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not verAlbaran Then
            listaVentas = New List(Of Venta)
        End If
        facturaGenerada = ventaAux.getRandomFactura()
        fillFields()
    End Sub

    Private Sub click_btn_busqueda_cliente(sender As Object, e As EventArgs) Handles btn_busqueda_cliente.Click
        Dim frmBusquedaNuevo As frmBusquedaVenta = New frmBusquedaVenta(clienteAux)
        frmBusquedaNuevo.Text = "BÚSQUEDA DE CLIENTES"
        frmBusquedaNuevo.ShowDialog()
        If frmBusquedaNuevo.clienteSeleccionado IsNot Nothing Then
            clienteSeleccionado = frmBusquedaNuevo.clienteSeleccionado
            txt_cliente_seleccionado.Text = clienteSeleccionado.NombreDelCliente
        End If
    End Sub
    Private Sub click_btn_busqueda_articulo(sender As Object, e As EventArgs) Handles btn_busqueda_articulo_venta.Click
        Dim frmBusquedaNuevo As frmBusqueda = New frmBusqueda(articuloAux)
        frmBusquedaNuevo.Text = "BÚSQUEDA DE ARTÍCULOS"
        frmBusquedaNuevo.ShowDialog()
        If frmBusquedaNuevo.articuloSeleccionado IsNot Nothing Then
            articuloSeleccionado = frmBusquedaNuevo.articuloSeleccionado
            txt_articulo_seleccionado_venta.Text = articuloSeleccionado.NombreDeArticulo
        End If
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
        cb_forma_pago_seleccionada_venta.DataSource = dt
        cb_forma_pago_seleccionada_venta.DisplayMember = "Nombre"
        cb_forma_pago_seleccionada_venta.ValueMember = "Codigo"
        cb_forma_pago_seleccionada_venta.SelectedIndex = -1
    End Sub
    Private Sub clearFields()
        txt_cliente_seleccionado.Clear()
        txt_cantidad_seleccionada_venta.Clear()
        txt_articulo_seleccionado_venta.Clear()
        txt_descuento_venta.Clear()
        lbl_bruto.Text = Nothing
        lbl_base_imponible.Text = Nothing
        lbl_impuesto.Text = Nothing
        lbl_total.Text = Nothing
        lbl_bruto.Visible = False
        lbl_base_imponible.Visible = False
        lbl_impuesto.Visible = False
        lbl_total.Visible = False

        dt.Clear()
        cb_forma_pago_seleccionada_venta.DataSource = Nothing
        cb_forma_pago_seleccionada_venta.Items.Clear()
        cb_forma_pago_seleccionada_venta.SelectedIndex = -1

        btn_modificar_venta.Enabled = False
        btn_eliminar_venta.Enabled = False
        btn_confirmar_venta.Enabled = False

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
        cb_forma_pago_seleccionada_venta.DataSource = dt
        cb_forma_pago_seleccionada_venta.DisplayMember = "Nombre"
        cb_forma_pago_seleccionada_venta.ValueMember = "Codigo"
        cb_forma_pago_seleccionada_venta.SelectedIndex = -1
    End Sub
    Private Sub clearFieldsDatos()
        txt_articulo_seleccionado_venta.Clear()
        txt_cantidad_seleccionada_venta.Clear()
        txt_descuento_venta.Clear()
        cb_forma_pago_seleccionada_venta.SelectedIndex = -1
    End Sub

    Public Function checkCampos() As Boolean
        If String.IsNullOrEmpty(txt_cliente_seleccionado.Text) Then
            MessageBox.Show("Seleccione primero cliente")
            Return False
        End If
        If String.IsNullOrEmpty(txt_articulo_seleccionado_venta.Text) Then
            MessageBox.Show("Seleccione primero artículo")
            Return False
        End If
        If cb_forma_pago_seleccionada_venta.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione primero forma de pago")
            Return False
        End If
        If String.IsNullOrEmpty(txt_cantidad_seleccionada_venta.Text) Or Not IsNumeric(txt_cantidad_seleccionada_venta.Text) Then
            MessageBox.Show("Introduzca cantidad válida")
            Return False
        End If
        If Not String.IsNullOrEmpty(txt_descuento_venta.Text) And Not Double.TryParse(txt_descuento_venta.Text, doubleParse) Then
            MessageBox.Show("Introduzca descuento válido")
            Return False
        End If
        Return True
    End Function

    Private Sub click_btn_añadir_venta(sender As Object, e As EventArgs) Handles btn_añadir_venta.Click
        añadirVenta()
    End Sub
    Private Sub añadirVenta()
        If Not checkCampos() Then
            Return
        End If
        Dim formaPagoSeleccionada As String = cb_forma_pago_seleccionada_venta.SelectedValue
        Dim cantidadSeleccionada As Integer = Convert.ToInt32(txt_cantidad_seleccionada_venta.Text)
        Dim precioVenta As Double = Convert.ToDouble(managerArticuloAux.getCampoArticulo(articuloSeleccionado.CodigoDeArticulo, "PRECIO_COMPRA_ARTICULO"))
        Dim porcBeneficio As Double = Convert.ToDouble(managerArticuloAux.getCampoArticulo(articuloSeleccionado.CodigoDeArticulo, "PORC_BENEFICIO_ARTICULO"))
        Dim fechaVenta As Date = dp_fecha_venta.Value
        Dim descuentoVenta As Double = Convert.ToDouble(txt_descuento_venta.Text)

        Dim cantidadTemporalTotal As Integer = cantidadSeleccionada
        For Each item As Venta In listaVentas
            If item.ArticuloDeVenta.Equals(articuloSeleccionado.NombreDeArticulo) Then
                cantidadTemporalTotal += item.CantidadDeVenta
            End If
        Next
        If Not checkStockage(cantidadTemporalTotal) Then
            Return
        End If
        Dim precioVentaArticulo As Double = precioVenta * (1 + porcBeneficio / 100)
        Dim codigoVenta As Integer = managerVentaAux.getIDVenta()
        ventaTemp = New Venta(codigoVenta, clienteSeleccionado.CodigoDelCliente, articuloSeleccionado.CodigoDeArticulo, formaPagoSeleccionada, precioVentaArticulo, cantidadSeleccionada, fechaVenta, False, facturaGenerada, descuentoVenta)
        listaVentas.Add(ventaTemp)
        fillDGVentas()
        clearFieldsDatos()
        calcularTotal()
        modificacion = True
    End Sub
    Private Sub click_btn_eliminar_venta(sender As Object, e As EventArgs) Handles btn_eliminar_venta.Click
        Dim cantidadDevuelta As Integer = ventaTemp.CantidadDeVenta
        Dim articuloDevuelto As Integer = ventaTemp.ArticuloDeVenta
        managerInventarioAux.addUnidades(cantidadDevuelta, articuloDevuelto)
        listaVentas.Remove(ventaTemp)
        btn_eliminar_venta.Enabled = False
        btn_modificar_venta.Enabled = False
        fillDGVentas()
        calcularTotal()
        modificacion = True
    End Sub
    Private Sub click_btn_modificar_venta(sender As Object, e As EventArgs) Handles btn_modificar_venta.Click
        If btn_modificar_venta.Text.Equals("MODIFICAR") Then
            articuloSeleccionado = VariablesGlobales.getArticuloPorCodigo(ventaTemp.ArticuloDeVenta)
            clienteSeleccionado = VariablesGlobales.getClientePorCodigo(ventaTemp.ClienteDeVenta)
            txt_articulo_seleccionado_venta.Text = articuloSeleccionado.NombreDeArticulo
            txt_cliente_seleccionado.Text = clienteSeleccionado.NombreDelCliente
            txt_cantidad_seleccionada_venta.Text = ventaTemp.CantidadDeVenta
            txt_descuento_venta.Text = ventaTemp.DescuentoDeVenta
            cb_forma_pago_seleccionada_venta.SelectedValue = ventaTemp.FormaDePagoVenta
            btn_modificar_venta.Text = "CONFIRMAR"
        Else
            listaVentas.Remove(ventaTemp)
            añadirVenta()
            btn_modificar_venta.Text = "MODIFICAR"
            btn_modificar_venta.Enabled = False
            btn_eliminar_venta.Enabled = False
            modificacion = True
        End If
    End Sub
    Private Sub fillDGVentas()
        If listaVentas.Count = 0 Then
            Return
        End If
        Dim clienteTemp As Cliente = VariablesGlobales.getClientePorCodigo(clienteSeleccionado.CodigoDelCliente)
        dg_ventas.Rows.Clear()
        Dim articuloItem As Articulo
        For Each item As Venta In listaVentas
            Dim index As Integer = dg_ventas.Rows.Add()
            articuloItem = managerArticuloAux.getArticuloConcreto(item.ArticuloDeVenta)
            Dim baseImponible As Double = item.PrecioDeArticuloVenta * (1 - item.DescuentoDeVenta / 100)
            Dim impuesto As Double = baseImponible * (articuloItem.ImpuestoDeArticulo / 100)

            dg_ventas.Rows(index).Cells("idVenta").Value = item.CodigoDeVenta
            dg_ventas.Rows(index).Cells("clienteVenta").Value = clienteTemp.NombreDelCliente
            dg_ventas.Rows(index).Cells("articuloVenta").Value = articuloItem.NombreDeArticulo
            dg_ventas.Rows(index).Cells("formaPagoVenta").Value = item.FormaDePagoVenta
            dg_ventas.Rows(index).Cells("precioUnitario").Value = item.PrecioDeArticuloVenta
            dg_ventas.Rows(index).Cells("precioBrutoVenta").Value = item.PrecioDeArticuloVenta * item.CantidadDeVenta
            dg_ventas.Rows(index).Cells("cantidadVenta").Value = item.CantidadDeVenta
            dg_ventas.Rows(index).Cells("descuentoVenta").Value = item.DescuentoDeVenta
            dg_ventas.Rows(index).Cells("baseImponible").Value = baseImponible * item.CantidadDeVenta
            dg_ventas.Rows(index).Cells("impuestoVenta").Value = impuesto * item.CantidadDeVenta
            dg_ventas.Rows(index).Cells("precioTotalVenta").Value = (baseImponible + impuesto) * item.CantidadDeVenta
        Next
        If dg_ventas.RowCount > 0 Then
            btn_confirmar_venta.Enabled = True
            btn_busqueda_cliente.Enabled = False
            cb_forma_pago_seleccionada_venta.Enabled = False
        Else
            btn_confirmar_venta.Enabled = False
            btn_busqueda_cliente.Enabled = True
            cb_forma_pago_seleccionada_venta.Enabled = True
        End If
        dg_ventas.ClearSelection()
    End Sub
    Public Sub fillDGVentas(listaFacturas As List(Of Venta))
        verAlbaran = True
        listaVentas.AddRange(listaFacturas)
        dg_ventas.Rows.Clear()
        Dim clienteTemp As Cliente = VariablesGlobales.getClientePorCodigo(listaFacturas(0).ClienteDeVenta)
        Dim articuloItem As Articulo
        For Each item As Venta In listaFacturas
            Dim index As Integer = dg_ventas.Rows.Add()
            articuloItem = VariablesGlobales.getArticuloPorCodigo(item.ArticuloDeVenta)
            Dim baseImponible As Double = item.PrecioDeArticuloVenta * (1 - item.DescuentoDeVenta / 100)
            Dim impuesto As Double = baseImponible * (articuloItem.ImpuestoDeArticulo / 100)

            dg_ventas.Rows(index).Cells("idVenta").Value = item.CodigoDeVenta
            dg_ventas.Rows(index).Cells("clienteVenta").Value = clienteTemp.NombreDelCliente
            dg_ventas.Rows(index).Cells("articuloVenta").Value = articuloItem.NombreDeArticulo
            dg_ventas.Rows(index).Cells("formaPagoVenta").Value = item.FormaDePagoVenta
            dg_ventas.Rows(index).Cells("precioUnitario").Value = item.PrecioDeArticuloVenta
            dg_ventas.Rows(index).Cells("precioBrutoVenta").Value = item.PrecioDeArticuloVenta * item.CantidadDeVenta
            dg_ventas.Rows(index).Cells("cantidadVenta").Value = item.CantidadDeVenta
            dg_ventas.Rows(index).Cells("descuentoVenta").Value = item.DescuentoDeVenta
            dg_ventas.Rows(index).Cells("baseImponible").Value = baseImponible * item.CantidadDeVenta
            dg_ventas.Rows(index).Cells("impuestoVenta").Value = impuesto * item.CantidadDeVenta
            dg_ventas.Rows(index).Cells("precioTotalVenta").Value = (baseImponible + impuesto) * item.CantidadDeVenta
        Next
        If dg_ventas.RowCount > 0 Then
            btn_confirmar_venta.Enabled = True
            btn_busqueda_cliente.Enabled = False
            cb_forma_pago_seleccionada_venta.Enabled = False
        Else
            btn_confirmar_venta.Enabled = False
            btn_busqueda_cliente.Enabled = True
            cb_forma_pago_seleccionada_venta.Enabled = True
        End If
        dg_ventas.ClearSelection()
    End Sub
    Private Sub calcularTotal()
        lbl_total.Visible = True
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

        For Each ventilla As Venta In listaVentas
            articuloTemp = VariablesGlobales.getArticuloPorCodigo(ventilla.ArticuloDeVenta)
            baseImponibleTemp = ventilla.PrecioDeArticuloVenta * (1 - ventilla.DescuentoDeVenta / 100)
            impuestoTemp = baseImponibleTemp * articuloTemp.ImpuestoDeArticulo / 100
            brutoTotal += ventilla.PrecioDeArticuloVenta * ventilla.CantidadDeVenta
            baseImponibleTotal += baseImponibleTemp * ventilla.CantidadDeVenta
            impuestoTotal += impuestoTemp * ventilla.CantidadDeVenta
            precioTotal += (baseImponibleTemp + impuestoTemp) * ventilla.CantidadDeVenta
        Next
        If brutoTotal = 0 Then
            lbl_total.Visible = False
            lbl_bruto.Visible = False
            lbl_base_imponible.Visible = False
            lbl_impuesto.Visible = False
        End If
        lbl_total.Text = $"Importe total: {precioTotal.ToString("N2")}€"
        lbl_bruto.Text = $"Bruto total: {brutoTotal.ToString("N2")}€"
        lbl_base_imponible.Text = $"Base imponible total: {baseImponibleTotal.ToString("N2")}€"
        lbl_impuesto.Text = $"Impuesto total: {impuestoTotal.ToString("N2")}€"
    End Sub
    Private Sub click_cell_dg_ventas(sender As Object, e As DataGridViewCellEventArgs) Handles dg_ventas.CellClick
        If e.RowIndex >= 0 And dg_ventas.Rows(e.RowIndex).Cells("articuloVenta").Value <> Nothing Then
            btn_eliminar_venta.Enabled = True
            btn_modificar_venta.Enabled = True
            Dim codigoTemp As Integer = dg_ventas.Rows(e.RowIndex).Cells("idVenta").Value
            ventaTemp = listaVentas.Find(Function(v) v.CodigoDeVenta = codigoTemp)
        End If
    End Sub
    Private Function checkStockage(cantidadSeleccionada As Integer) As Boolean
        Dim cantidadActual As Integer = managerInventarioAux.checkStock(articuloSeleccionado.CodigoDeArticulo)
        If cantidadActual - cantidadSeleccionada < 0 Then
            Dim dr As DialogResult = MessageBox.Show("Al efectuar esta venta se quedará en negativo las uds del artículo, ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (dr = DialogResult.No) Then
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub click_btn_guardar_pdf_venta(sender As Object, e As EventArgs) Handles btn_guardar_pdf_venta.Click
        If dg_ventas.RowCount = 0 Then
            MessageBox.Show("Introduzca primero alguna venta")
            Return
        End If

        Dim infVenta As infVenta = New infVenta(listaVentas, dp_fecha_venta.Value, brutoTotal, baseImponibleTotal, impuestoTotal, precioTotal)
        Dim report As rptVenta = infVenta.getReport()

        Dim exportPath As String = "C:\Users\Puesto\Desktop\Reportes\Ventas\"
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
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub click_btn_confirmar_venta(sender As Object, e As EventArgs) Handles btn_confirmar_venta.Click
        If dg_ventas.RowCount = 0 Then
            MessageBox.Show("Introduzca primero alguna venta")
            Return
        End If
        If verAlbaran And Not modificacion Then
            Me.Close()
            Return
        End If
        Dim fechaVenta As Date = dp_fecha_venta.Value
        Dim stockActual As Integer
        Dim movimientoTemp As Movimiento = New Movimiento()
        For Each item As Venta In listaVentas
            If VariablesGlobales.listaVentasAux.Contains(item) Then
                item.modifyVenta()
            Else
                item.addVenta()
            End If
            Dim articuloFind As Articulo = VariablesGlobales.getArticuloPorCodigo(item.ArticuloDeVenta)
            managerInventarioAux.deleteUnidades(item.CantidadDeVenta, articuloFind.CodigoDeArticulo)
            stockActual = managerInventarioAux.checkStock(articuloFind.CodigoDeArticulo)
            movimientoTemp = New Movimiento("V", facturaGenerada, item.ClienteDeVenta, fechaVenta, articuloFind.CodigoDeArticulo, stockActual, item.CantidadDeVenta)
            movimientoTemp.addMovimiento()
        Next

        Dim informe As infVenta = New infVenta(listaVentas, fechaVenta, brutoTotal, baseImponibleTotal, impuestoTotal, precioTotal)
        informe.showReport()
        clearFields()
    End Sub

    Private Sub cell_end_edit_dg_ventas(sender As Object, e As DataGridViewCellEventArgs) Handles dg_ventas.CellEndEdit
        Dim precioBrutoNuevo As Double
        Dim porcentajeNuevo As Double
        Dim articuloMod As Articulo = VariablesGlobales.getArticuloPorCodigo(ventaTemp.ArticuloDeVenta)
        If dg_ventas.Columns(e.ColumnIndex).Name = "precioUnitario" AndAlso e.RowIndex >= 0 Then
            precioBrutoNuevo = dg_ventas.Rows(e.RowIndex).Cells("precioUnitario").Value
            porcentajeNuevo = ((100 * precioBrutoNuevo) / articuloMod.PVPCompraDeArticulo) - 100
            listaVentas.Remove(ventaTemp)
            ventaTemp.PrecioDeArticuloVenta = precioBrutoNuevo
            listaVentas.Add(ventaTemp)
            Dim dr As DialogResult = MessageBox.Show("¿Desea cambiar el porcentaje de beneficio del producto?", "Nuevo precio compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (dr = DialogResult.Yes) Then
                articuloMod.PorcentajeDeBeneficio = porcentajeNuevo
                articuloMod.modifyArticulo()
            End If
            calcularTotal()
        End If
    End Sub
    Private Sub closed_frm_venta(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        clearFields()
        clearFieldsDatos()
        listaVentas = New List(Of Venta)
        fillDGVentas()
    End Sub
End Class
Imports System.ComponentModel

Public Class frmVenta
    Dim listaFormasPago As List(Of FormaPago) = New List(Of FormaPago)
    Dim listaVentas As List(Of Venta) = New List(Of Venta)
    Dim ventaTemp As Venta = New Venta()
    Dim dt As New DataTable()
    Dim clienteSeleccionado As Cliente
    Dim articuloSeleccionado As Articulo
    Dim facturaGenerada As String

    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaVentas = New List(Of Venta)
        facturaGenerada = ventaAux.getRandomFactura()
        clearFields()
    End Sub

    Private Sub click_btn_busqueda_cliente(sender As Object, e As EventArgs) Handles btn_busqueda_cliente.Click
        Dim frmBusquedaNuevo As frmBusquedaVenta = New frmBusquedaVenta(clienteAux)
        frmBusquedaNuevo.Text = "BÚSQUEDA DE CLIENTES"
        frmBusquedaNuevo.ShowDialog()
        clienteSeleccionado = Nothing
        clienteSeleccionado = frmBusquedaNuevo.clienteSeleccionado
        If clienteSeleccionado IsNot Nothing Then
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
    Private Sub clearFields()
        txt_cliente_seleccionado.Clear()
        txt_cantidad_seleccionada_venta.Clear()
        txt_articulo_seleccionado_venta.Clear()
        lbl_precio_sumatorio_venta.Visible = False
        lbl_precio_sumatorio_venta.Text = Nothing

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
        ventaTemp = New Venta(codigoVenta, clienteSeleccionado.CodigoDelCliente, articuloSeleccionado.CodigoDeArticulo, formaPagoSeleccionada, precioVentaArticulo, cantidadSeleccionada, fechaVenta, False, facturaGenerada)
        listaVentas.Add(ventaTemp)
        fillDGVentas()
        clearFieldsDatos()
        calcularTotal()
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
    End Sub
    Private Sub click_btn_modificar_venta(sender As Object, e As EventArgs) Handles btn_modificar_venta.Click
        If btn_modificar_venta.Text.Equals("MODIFICAR") Then
            Dim articuloTemp As Articulo = VariablesGlobales.getArticuloPorCodigo(ventaTemp.ArticuloDeVenta)
            Dim clienteTemp As Cliente = VariablesGlobales.getClientePorCodigo(ventaTemp.ClienteDeVenta)
            txt_articulo_seleccionado_venta.Text = articuloTemp.NombreDeArticulo
            txt_cliente_seleccionado.Text = clienteTemp.NombreDelCliente
            txt_cantidad_seleccionada_venta.Text = ventaTemp.CantidadDeVenta
            cb_forma_pago_seleccionada_venta.SelectedValue = ventaTemp.FormaDePagoVenta
            btn_modificar_venta.Text = "CONFIRMAR"
        Else
            listaVentas.Remove(ventaTemp)
            añadirVenta()
            btn_modificar_venta.Text = "MODIFICAR"
            btn_modificar_venta.Enabled = False
            btn_eliminar_venta.Enabled = False
        End If
    End Sub
    Private Sub fillDGVentas()
        dg_ventas.Rows.Clear()
        Dim articuloItem As Articulo
        For Each item As Venta In listaVentas
            Dim index As Integer = dg_ventas.Rows.Add()
            articuloItem = managerArticuloAux.getArticuloConcreto(item.ArticuloDeVenta)
            dg_ventas.Rows(index).Cells("idVenta").Value = item.CodigoDeVenta
            dg_ventas.Rows(index).Cells("clienteVenta").Value = item.ClienteDeVenta
            dg_ventas.Rows(index).Cells("articuloVenta").Value = articuloItem.NombreDeArticulo
            dg_ventas.Rows(index).Cells("formaPagoVenta").Value = item.FormaDePagoVenta
            dg_ventas.Rows(index).Cells("precioArticuloVenta").Value = item.PrecioDeArticuloVenta
            dg_ventas.Rows(index).Cells("cantidadVenta").Value = item.CantidadDeVenta
            dg_ventas.Rows(index).Cells("precioTotalVenta").Value = item.PrecioTotalDeVenta
        Next
        If dg_ventas.RowCount > 0 Then
            btn_confirmar_venta.Enabled = True
            btn_busqueda_cliente.Enabled = False
        Else
            btn_confirmar_venta.Enabled = False
            btn_busqueda_cliente.Enabled = True
        End If
        dg_ventas.ClearSelection()
    End Sub
    Private Sub calcularTotal()
        lbl_precio_sumatorio_venta.Visible = True
        Dim precioTotal As Double = 0
        For Each ventilla As Venta In listaVentas
            precioTotal += ventilla.PrecioTotalDeVenta
        Next
        If precioTotal = 0 Then
            lbl_precio_sumatorio_venta.Visible = False
        End If
        lbl_precio_sumatorio_venta.Text = $"Importe total: {precioTotal}€"
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
    Private Sub click_btn_confirmar_venta(sender As Object, e As EventArgs) Handles btn_confirmar_venta.Click
        If dg_ventas.RowCount = 0 Then
            MessageBox.Show("Introduzca primero alguna venta")
            Return
        End If
        Dim fechaVenta As Date = dp_fecha_venta.Value
        Dim stockActual As Integer
        Dim movimientoTemp As Movimiento = New Movimiento()
        For Each item As Venta In listaVentas
            item.addVenta()
            Dim articuloFind As Articulo = VariablesGlobales.getArticuloPorCodigo(item.ArticuloDeVenta)
            managerInventarioAux.deleteUnidades(item.CantidadDeVenta, articuloFind.CodigoDeArticulo)
            stockActual = managerInventarioAux.checkStock(articuloFind.CodigoDeArticulo)
            movimientoTemp = New Movimiento("V", facturaGenerada, item.ClienteDeVenta, fechaVenta, articuloFind.CodigoDeArticulo, stockActual, item.CantidadDeVenta)
            movimientoTemp.addMovimiento()
        Next

        Dim informe As infVenta = New infVenta(listaVentas, fechaVenta)
        clearFields()
    End Sub
End Class
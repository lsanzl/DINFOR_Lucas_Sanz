Imports System.ComponentModel

Public Class frmVenta
    Dim listaFormasPago As List(Of FormaPago) = New List(Of FormaPago)
    Dim listaVentas As BindingList(Of Venta) = New BindingList(Of Venta)()
    Dim ventaTemp As Venta = New Venta()
    Dim dt As New DataTable()
    Dim clienteSeleccionado As String

    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaVentas = New BindingList(Of Venta)
        clearFields()
        dg_ventas.DataSource = listaVentas
    End Sub

    Private Sub click_btn_busqueda_cliente(sender As Object, e As EventArgs) Handles btn_busqueda_cliente.Click
        Dim frmBusquedaNuevo As frmBusquedaVenta = New frmBusquedaVenta(clienteAux)
        frmBusquedaNuevo.Text = "BÚSQUEDA DE CLIENTES"
        frmBusquedaNuevo.ShowDialog()
        txt_cliente_seleccionado.Text = frmBusquedaNuevo.codigoSeleccionado
        clienteSeleccionado = frmBusquedaNuevo.codigoSeleccionado
    End Sub
    Private Sub click_btn_busqueda_articulo(sender As Object, e As EventArgs) Handles btn_busqueda_articulo_venta.Click
        Dim frmBusquedaNuevo As frmBusqueda = New frmBusqueda(articuloAux)
        frmBusquedaNuevo.Text = "BÚSQUEDA DE ARTÍCULOS"
        frmBusquedaNuevo.ShowDialog()
        txt_articulo_seleccionado_venta.Text = frmBusquedaNuevo.codigoSeleccionado
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
        Dim articuloSeleccionado As String = txt_articulo_seleccionado_venta.Text
        Dim formaPagoSeleccionada As String = cb_forma_pago_seleccionada_venta.SelectedValue
        Dim cantidadSeleccionada As Integer = Convert.ToInt32(txt_cantidad_seleccionada_venta.Text)
        Dim precioVenta As Double = Convert.ToDouble(managerArticuloAux.getCampoArticulo(articuloSeleccionado, "PVPCOMPRAARTICULO"))
        Dim porcBeneficio As Double = Convert.ToDouble(managerArticuloAux.getCampoArticulo(articuloSeleccionado, "PORCBENEFICIOARTICULO"))

        Dim precioVentaArticulo As Double = precioVenta * (1 + porcBeneficio / 100)

        Dim ventaTemp As Venta = New Venta(clienteSeleccionado, articuloSeleccionado, formaPagoSeleccionada, precioVentaArticulo, cantidadSeleccionada)
        'ventaTemp.addVenta()
        listaVentas.Add(ventaTemp)
        fillDGVentas()
        clearFieldsDatos()
        calcularTotal()
    End Sub
    Private Sub click_btn_eliminar_venta(sender As Object, e As EventArgs) Handles btn_eliminar_venta.Click
        listaVentas.Remove(ventaTemp)
        btn_eliminar_venta.Enabled = False
        btn_modificar_venta.Enabled = False
        fillDGVentas()
        calcularTotal()
    End Sub
    Private Sub click_btn_modificar_venta(sender As Object, e As EventArgs) Handles btn_modificar_venta.Click
        If btn_modificar_venta.Text.Equals("MODIFICAR") Then
            txt_articulo_seleccionado_venta.Text = ventaTemp.ArticuloDeVenta
            txt_cliente_seleccionado.Text = ventaTemp.ClienteDeVenta
            txt_cantidad_seleccionada_venta.Text = ventaTemp.CantidadDeVenta
            cb_forma_pago_seleccionada_venta.SelectedValue = ventaTemp.FormaDePagoVenta
            btn_modificar_venta.Text = "CONFIRMAR"
        Else
            listaVentas.Remove(ventaTemp)
            añadirVenta()
            btn_modificar_venta.Text = "MODIFICAR"
        End If
    End Sub
    Private Sub fillDGVentas()
        dg_ventas.DataSource = listaVentas
        dg_ventas.Refresh()
        If dg_ventas.RowCount > 0 Then
            btn_confirmar_venta.Enabled = True
        End If
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
        If e.RowIndex >= 0 Then
            btn_eliminar_venta.Enabled = True
            btn_modificar_venta.Enabled = True
            ventaTemp = dg_ventas.Rows(e.RowIndex).DataBoundItem
        End If
    End Sub

    Private Sub click_btn_confirmar_venta(sender As Object, e As EventArgs) Handles btn_confirmar_venta.Click
        If dg_ventas.RowCount = 0 Then
            MessageBox.Show("Introduzca primero alguna venta")
            Return
        End If
        Dim fechaVenta As Date = dp_fecha_venta.Value
        Dim informe As infVenta = New infVenta(listaVentas, fechaVenta)
    End Sub
End Class
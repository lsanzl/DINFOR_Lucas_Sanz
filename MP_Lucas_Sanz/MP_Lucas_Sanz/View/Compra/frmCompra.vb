Imports System.ComponentModel

Public Class frmCompra
    Dim listaFormasPago As List(Of FormaPago) = New List(Of FormaPago)
    Dim listaCompras As List(Of Compra) = New List(Of Compra)()
    Dim compraTemp As Compra = New Compra()
    Dim dt As New DataTable()
    Dim proveedorSeleccionado As Proveedor
    Dim articuloSeleccionado As Articulo
    Dim facturaGenerada As String

    Private Sub frmCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaCompras = New List(Of Compra)
        facturaGenerada = compraAux.getRandomFactura()
        clearFields()
    End Sub

    Private Sub click_btn_busqueda_proveedor(sender As Object, e As EventArgs) Handles btn_busqueda_proveedor.Click
        Dim frmBusquedaNuevo As frmBusqueda = New frmBusqueda(proveedorAux)
        frmBusquedaNuevo.Text = "BÚSQUEDA DE PROVEEDORES"
        frmBusquedaNuevo.ShowDialog()
        proveedorSeleccionado = frmBusquedaNuevo.proveedorSeleccionado
        txt_proveedor_seleccionado.Text = proveedorSeleccionado.CodigoDeProveedor
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
        lbl_precio_sumatorio.Visible = False
        lbl_precio_sumatorio.Text = Nothing

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
        Return True
    End Function

    Private Sub click_btn_añadir_compra(sender As Object, e As EventArgs) Handles btn_añadir_compra.Click
        añadirCompra()
    End Sub
    Private Sub añadirCompra()
        If Not checkCampos() Then
            Return
        End If
        Dim codigoArticuloSeleccionado As Integer = articuloSeleccionado.CodigoDeArticulo
        Dim formaPagoSeleccionada As Integer = cb_forma_pago_seleccionada.SelectedValue
        Dim cantidadSeleccionada As Integer = Convert.ToInt32(txt_cantidad_seleccionada.Text)
        Dim precioCompra As Double = Convert.ToDouble(managerArticuloAux.getCampoArticulo(codigoArticuloSeleccionado, "PRECIO_COMPRA_ARTICULO"))
        Dim porcBeneficio As Double = Convert.ToDouble(managerArticuloAux.getCampoArticulo(codigoArticuloSeleccionado, "PORC_BENEFICIO_ARTICULO"))
        Dim fechaCompra As Date = dp_fecha_compra.Value

        Dim precioVenta As Double = precioCompra * (1 + porcBeneficio / 100)
        Dim codigoCompra As Integer = managerCompraAux.getIDCompra()

        Dim compraTemp As Compra = New Compra(codigoCompra, proveedorSeleccionado.CodigoDeProveedor, codigoArticuloSeleccionado, formaPagoSeleccionada, precioVenta, cantidadSeleccionada, fechaCompra, facturaGenerada)
        listaCompras.Add(compraTemp)
        fillDGCompras()
        clearFieldsDatos()
        calcularTotal()
    End Sub
    Private Sub click_btn_eliminar_compra(sender As Object, e As EventArgs) Handles btn_eliminar_compra.Click
        listaCompras.Remove(compraTemp)
        btn_eliminar_compra.Enabled = False
        btn_modificar_compra.Enabled = False
        fillDGCompras()
        calcularTotal()
    End Sub
    Private Sub click_btn_modificar_compra(sender As Object, e As EventArgs) Handles btn_modificar_compra.Click
        If btn_modificar_compra.Text.Equals("MODIFICAR") Then
            txt_articulo_seleccionado.Text = managerArticuloAux.getCampoArticulo(compraTemp.ArticuloDeCompra, "NOMBRE_ARTICULO")
            txt_proveedor_seleccionado.Text = compraTemp.ProveedorDeCompra
            txt_cantidad_seleccionada.Text = compraTemp.CantidadDeCompra
            cb_forma_pago_seleccionada.SelectedValue = compraTemp.FormaDePagoCompra
            btn_modificar_compra.Text = "CONFIRMAR"
        Else
            listaCompras.Remove(compraTemp)
            añadirCompra()
            btn_modificar_compra.Text = "MODIFICAR"
        End If
    End Sub
    Private Sub fillDGCompras()
        dg_compras.Rows.Clear()
        Dim articuloItem As Articulo
        For Each item As Compra In listaCompras
            Dim index As Integer = dg_compras.Rows.Add()
            articuloItem = managerArticuloAux.getArticuloConcreto(item.ArticuloDeCompra)
            dg_compras.Rows(index).Cells("idCompra").Value = item.CodigoDeCompra
            dg_compras.Rows(index).Cells("proveedorCompra").Value = item.ProveedorDeCompra
            dg_compras.Rows(index).Cells("articuloCompra").Value = articuloItem.NombreDeArticulo
            dg_compras.Rows(index).Cells("formaPagoCompra").Value = item.FormaDePagoCompra
            dg_compras.Rows(index).Cells("precioArticuloCompra").Value = item.PrecioDeArticuloCompra
            dg_compras.Rows(index).Cells("cantidadCompra").Value = item.CantidadDeCompra
            dg_compras.Rows(index).Cells("precioTotalCompra").Value = item.PrecioTotalDeCompra
        Next
        If dg_compras.RowCount > 0 Then
            btn_confirmar_compra.Enabled = True
            btn_busqueda_proveedor.Enabled = False
        Else
            btn_confirmar_compra.Enabled = False
            btn_busqueda_proveedor.Enabled = True
        End If
    End Sub
    Private Sub calcularTotal()
        lbl_precio_sumatorio.Visible = True
        Dim precioTotal As Double = 0
        For Each comprilla As Compra In listaCompras
            precioTotal += comprilla.PrecioTotalDeCompra
        Next
        If precioTotal = 0 Then
            lbl_precio_sumatorio.Visible = False
        End If
        lbl_precio_sumatorio.Text = $"Precio total: {precioTotal}€"
    End Sub

    Private Sub click_cell_dg_compras(sender As Object, e As DataGridViewCellEventArgs) Handles dg_compras.CellClick
        If e.RowIndex >= 0 Then
            btn_eliminar_compra.Enabled = True
            btn_modificar_compra.Enabled = True
            Dim codigoTemp As Integer = dg_compras.Rows(e.RowIndex).Cells("idCompra").Value
            compraTemp = listaCompras.Find(Function(c) c.CodigoDeCompra = codigoTemp)
        End If
    End Sub

    Private Sub click_btn_confirmar_compra(sender As Object, e As EventArgs) Handles btn_confirmar_compra.Click
        If dg_compras.RowCount = 0 Then
            MessageBox.Show("Introduzca primero alguna compra")
            Return
        End If
        Dim fechaCompra As Date = dp_fecha_compra.Value
        Dim movimientoTemp As Movimiento = New Movimiento()
        Dim stockActual As Integer

        For Each item As Compra In listaCompras
            item.addCompra()
            Dim articuloFind As Articulo = VariablesGlobales.getArticuloPorCodigo(item.ArticuloDeCompra)
            managerInventarioAux.addUnidades(item.CantidadDeCompra, articuloFind.CodigoDeArticulo)
            stockActual = managerInventarioAux.checkStock(articuloFind.CodigoDeArticulo)
            movimientoTemp = New Movimiento("C", facturaGenerada, item.ProveedorDeCompra, fechaCompra, articuloFind.CodigoDeArticulo, stockActual, item.CantidadDeCompra)
            movimientoTemp.addMovimiento()
        Next

        Dim informe As infCompra = New infCompra(listaCompras, fechaCompra)
        clearFields()
    End Sub
End Class
Public Class frmCompra
    Dim listaFormasPago As List(Of FormaPago) = New List(Of FormaPago)
    Dim listaCompras As List(Of Compra) = New List(Of Compra)
    Dim dt As New DataTable()

    Private Sub frmCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearFields()
    End Sub

    Private Sub click_btn_busqueda_proveedor(sender As Object, e As EventArgs) Handles btn_busqueda_proveedor.Click
        Dim frmBusquedaNuevo As frmBusqueda = New frmBusqueda(proveedorAux)
        frmBusquedaNuevo.Text = "BÚSQUEDA DE PROVEEDORES"
        frmBusquedaNuevo.ShowDialog()
        txt_proveedor_seleccionado.Text = frmBusquedaNuevo.codigoSeleccionado
    End Sub
    Private Sub click_btn_busqueda_articulo(sender As Object, e As EventArgs) Handles btn_busqueda_articulo.Click
        Dim frmBusquedaNuevo As frmBusqueda = New frmBusqueda(articuloAux)
        frmBusquedaNuevo.Text = "BÚSQUEDA DE ARTÍCULOS"
        frmBusquedaNuevo.ShowDialog()
        txt_articulo_seleccionado.Text = frmBusquedaNuevo.codigoSeleccionado
    End Sub
    Private Sub clearFields()
        txt_proveedor_seleccionado.Clear()
        txt_cantidad_seleccionada.Clear()
        txt_articulo_seleccionado.Clear()
        dg_compras.Rows.Clear()
        cb_forma_pago_seleccionada.SelectedIndex = -1

        btn_modificar_compra.Enabled = False
        btn_eliminar_compra.Enabled = False
        btn_confirmar_compra.Enabled = False
        btn_añadir_compra.Enabled = False

        listaFormasPago = formaPagoAux.getFormasPago()
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Codigo")
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
        If String.IsNullOrEmpty(txt_articulo_seleccionado.Text) Then
            MessageBox.Show("Seleccione primero artículo")
            Return False
        End If
        If String.IsNullOrEmpty(txt_proveedor_seleccionado.Text) Then
            MessageBox.Show("Seleccione primero proveedor")
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
        If Not checkCampos() Then
            Return
        End If
        Dim articuloSeleccionado As String = txt_articulo_seleccionado.Text
        Dim proveedorSeleccionado As String = txt_proveedor_seleccionado.Text
        Dim formaPagoSeleccionada As String = cb_forma_pago_seleccionada.SelectedValue
        Dim cantidadSeleccionada As Integer = Convert.ToInt32(txt_cantidad_seleccionada.Text)

        Dim precioCompra As String = managerArticuloAux.getCampoArticulo(articuloSeleccionado, "PVPCOMPRAARTICULO")
        Dim porcBeneficio As String = managerArticuloAux.getCampoArticulo(articuloSeleccionado, "PORCBENEFICIOARTICULO")

        Dim precioVenta As Double = Convert.ToDouble(precioCompra) * (1 + Convert.ToDouble(porcBeneficio) / 100)

        Dim compraTemp As Compra = New Compra(proveedorSeleccionado, articuloSeleccionado, formaPagoSeleccionada, precioVenta, cantidadSeleccionada)
        compraTemp.addCompra()
        listaCompras.Add(compraTemp)
    End Sub
    Private Sub fillDGCompras()
        dg_compras.DataSource = Nothing
        dg_compras.Rows.Clear()
        dg_compras.DataSource = listaCompras
    End Sub
End Class
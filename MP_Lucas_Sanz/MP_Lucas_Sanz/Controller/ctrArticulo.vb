Public Class ctrArticulo
    Dim frmArticulo As frmMain
    Dim listaArticulos As List(Of Articulo) = New List(Of Articulo)
    Dim articuloTemp As Articulo
    Dim criterioBusqueda As String = "nombreArticulos"

    Public Sub New(frmPasado As frmMain)
        MyBase.New()
        frmArticulo = frmPasado
        frmArticulo.rdb_nombre_articulo.Checked = True

        AddHandler frmArticulo.btn_añadir_articulo.Click, AddressOf click_btn_añadir_articulo
        AddHandler frmArticulo.btn_modificar_articulo.Click, AddressOf click_btn_modificar_articulo
        AddHandler frmArticulo.btn_eliminar_articulo.Click, AddressOf click_btn_eliminar_articulo
        AddHandler frmArticulo.dg_articulos.CellClick, AddressOf click_cell_dg_articulos
        AddHandler frmArticulo.tab_main.SelectedIndexChanged, AddressOf tab_main_SelectedIndexChanged
        AddHandler frmArticulo.rdb_codigo_articulo.CheckedChanged, AddressOf checked_changed_gb_articulos
        AddHandler frmArticulo.rdb_nombre_articulo.CheckedChanged, AddressOf checked_changed_gb_articulos
        AddHandler frmArticulo.txt_busqueda_articulo.TextChanged, AddressOf text_changed_txt_busqueda_articulo
    End Sub

    Private Sub fillDGArticulos()
        frmArticulo.btn_modificar_articulo.Enabled = False
        frmArticulo.btn_eliminar_articulo.Enabled = False

        frmNuevoArticulo.btn_confirmar_articulo.Text = "Confirmar"
        frmNuevoArticulo.txt_codigo_articulo.Clear()
        frmNuevoArticulo.txt_nombre_articulo.Clear()
        frmNuevoArticulo.txt_descripcion_articulo.Clear()
        frmNuevoArticulo.txt_pvp_compra_articulo.Clear()
        frmNuevoArticulo.txt_porc_beneficio_articulo.Clear()
        frmNuevoArticulo.txt_pvp_venta_articulo.Clear()
        frmNuevoArticulo.txt_familia_articulo.Clear()
        frmNuevoArticulo.cb_tipo_unidad_articulo.SelectedIndex = -1
        frmNuevoArticulo.txt_codigo_articulo.Enabled = True

        frmArticulo.dg_articulos.DataSource = Nothing
        frmArticulo.dg_articulos.Rows.Clear()
        listaArticulos = articuloAux.getArticulos()
        frmArticulo.dg_articulos.DataSource = listaArticulos
        frmArticulo.dg_articulos.ClearSelection()
    End Sub

    Private Sub click_btn_añadir_articulo(sender As Object, e As EventArgs)
        frmNuevoArticulo.Text = "Creación nuevo artículo"
        frmNuevoArticulo.btn_confirmar_articulo.Text = "Confirmar"
        frmNuevoArticulo.ShowDialog()
        fillDGArticulos()
    End Sub
    Private Sub click_btn_modificar_articulo(sender As Object, e As EventArgs)
        frmNuevoArticulo.Text = "Modificación de banco"
        frmNuevoArticulo.txt_codigo_articulo.Text = articuloTemp.CodigoDeArticulo
        frmNuevoArticulo.txt_codigo_articulo.Enabled = False
        frmNuevoArticulo.txt_nombre_articulo.Text = articuloTemp.NombreDeArticulo
        frmNuevoArticulo.txt_descripcion_articulo.Text = articuloTemp.DescripcionDeArticulo
        frmNuevoArticulo.txt_pvp_compra_articulo.Text = articuloTemp.PVPCompraDeArticulo
        frmNuevoArticulo.txt_porc_beneficio_articulo.Text = articuloTemp.PorcentajeDeBeneficio
        frmNuevoArticulo.txt_pvp_venta_articulo.Text = articuloTemp.PVPVentaDeArticulo
        frmNuevoArticulo.txt_familia_articulo.Text = articuloTemp.FamiliaDeArticulo
        frmNuevoArticulo.cb_tipo_unidad_articulo.Text = articuloTemp.TipoDeUnidadArticulo

        frmNuevoArticulo.btn_confirmar_articulo.Text = "Modificar"
        frmNuevoArticulo.ShowDialog()

        fillDGArticulos()
    End Sub
    Private Sub click_btn_eliminar_articulo(sender As Object, e As EventArgs)
        articuloTemp.deleteArticulo()
        fillDGArticulos()
    End Sub
    Private Sub click_cell_dg_articulos(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            frmArticulo.btn_modificar_articulo.Enabled = True
            frmArticulo.btn_eliminar_articulo.Enabled = True
            articuloTemp = frmArticulo.dg_articulos.Rows(e.RowIndex).DataBoundItem
        End If
    End Sub
    Private Sub checked_changed_gb_articulos(sender As Object, e As EventArgs)
        If frmArticulo.rdb_codigo_articulo.Checked Then
            criterioBusqueda = "codigoArticulo"
        Else
            criterioBusqueda = "nombreArticulos"
        End If
    End Sub
    Private Function lookForText(textoOrigen As String, textoBusqueda As String) As Boolean
        Dim resultado As Integer
        resultado = InStr(1, textoOrigen, textoBusqueda)
        If resultado > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub text_changed_txt_busqueda_articulo(sender As Object, e As EventArgs)
        Dim textoBusqueda As String = frmArticulo.txt_busqueda_articulo.Text
        Dim dg As DataGridView = frmArticulo.dg_articulos

        If frmArticulo.txt_busqueda_articulo.Text = Nothing Then
            For Each fila As DataGridViewRow In dg.Rows
                fila.Visible = True
            Next
            Exit Sub
        End If
        For Each fila As DataGridViewRow In dg.Rows
            If lookForText(fila.Cells(criterioBusqueda).Value.ToString().Trim, textoBusqueda.Trim) Then
                dg.CurrentCell = Nothing
                fila.Visible = True
            Else
                dg.CurrentCell = Nothing
                fila.Visible = False
            End If
        Next
    End Sub
    Private Sub tab_main_SelectedIndexChanged(sender As Object, e As EventArgs)
        If frmArticulo.tab_main.SelectedTab.Text.Equals("ARTÍCULOS/PROVEEDORES") Then
            fillDGArticulos()
        End If
    End Sub
End Class
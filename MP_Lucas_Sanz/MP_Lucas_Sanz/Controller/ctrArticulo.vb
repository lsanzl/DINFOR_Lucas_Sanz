Public Class ctrArticulo
    Dim frmArticulo As frmMain
    Dim listaArticulos As List(Of Articulo) = New List(Of Articulo)
    Dim articuloTemp As Articulo

    Public Sub New(frmPasado As frmMain)
        MyBase.New()
        frmArticulo = frmPasado

        AddHandler frmArticulo.btn_añadir_articulo.Click, AddressOf click_btn_añadir_articulo
        AddHandler frmArticulo.btn_modificar_articulo.Click, AddressOf click_btn_modificar_articulo
        AddHandler frmArticulo.btn_eliminar_articulo.Click, AddressOf click_btn_eliminar_articulo
        AddHandler frmArticulo.dg_articulos.CellClick, AddressOf click_cell_dg_articulos
        AddHandler frmArticulo.tab_main.SelectedIndexChanged, AddressOf tab_main_SelectedIndexChanged
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
    Private Sub tab_main_SelectedIndexChanged(sender As Object, e As EventArgs)
        If frmArticulo.tab_main.SelectedTab.Text.Equals("ARTÍCULOS/PROVEEDORES") Then
            fillDGArticulos()
        End If
    End Sub
End Class
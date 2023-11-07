Public Class ctrArticulo
    Dim frmArticulo As frmMain
    Dim listaArticulos As List(Of Articulo) = New List(Of Articulo)
    Dim articuloTemp As Articulo
    Dim familiaTemp As Familia
    Dim criterioBusqueda As String = "nombreArticuloo"

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

        Dim dg As DataGridView = frmArticulo.dg_articulos
        dg.Rows.Clear()
        listaArticulos = listaArticulosAux
        For Each a As Articulo In listaArticulos
            Dim index As Integer = dg.Rows.Add()
            familiaTemp = getFamiliaPorCodigo(a.FamiliaDeArticulo)
            With dg.Rows(index)
                .Cells("idArticulo").Value = a.CodigoDeArticulo
                .Cells("nombreArticuloo").Value = a.NombreDeArticulo
                .Cells("descripcionArticulo").Value = a.DescripcionDeArticulo
                .Cells("pvpCompraArticulo").Value = a.PVPCompraDeArticulo
                .Cells("pvpVentaArticulo").Value = a.PVPVentaDeArticulo
                .Cells("impuestoArticulo").Value = a.ImpuestoDeArticulo
                .Cells("porcBeneficioArticulo").Value = a.PorcentajeDeBeneficio
                .Cells("tipoUnidadArticulo").Value = a.TipoDeUnidadArticulo
                .Cells("familiaArticulo").Value = familiaTemp.NombreDeFamilia
            End With
        Next
        frmArticulo.dg_articulos.ClearSelection()
        frmArticulo.txt_busqueda_articulo.Clear()
    End Sub
    Private Sub clearFieldsNuevo()
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
    End Sub

    Private Sub click_btn_añadir_articulo(sender As Object, e As EventArgs)
        clearFieldsNuevo()
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
            articuloTemp = getArticuloPorCodigo(frmArticulo.dg_articulos.Rows(e.RowIndex).Cells("idArticulo").Value)
        End If
    End Sub
    Private Sub checked_changed_gb_articulos(sender As Object, e As EventArgs)
        If frmArticulo.rdb_codigo_articulo.Checked Then
            criterioBusqueda = "idArticulo"
        Else
            criterioBusqueda = "nombreArticuloo"
        End If
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
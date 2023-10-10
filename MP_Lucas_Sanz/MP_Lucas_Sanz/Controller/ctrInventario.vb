Public Class ctrInventario
    Dim frmInventario As frmMain
    Dim inventarioTemp As Inventario
    Dim listaInventario As List(Of Inventario) = New List(Of Inventario)

    Public Sub New(frmPasado As frmMain)
        MyBase.New()
        frmInventario = frmPasado

        AddHandler frmInventario.btn_añadir_unidades.Click, AddressOf click_btn_añadir_unidades
        AddHandler frmInventario.btn_restar_unidades.Click, AddressOf click_btn_restar_unidades
        AddHandler frmInventario.tab_main.SelectedIndexChanged, AddressOf tab_main_SelectedIndexChanged
        AddHandler frmInventario.dg_inventario.CellClick, AddressOf click_cell_dg_inventario
    End Sub

    Private Sub fillDGInventario()
        frmInventario.btn_añadir_unidades.Enabled = False
        frmInventario.btn_restar_unidades.Enabled = False

        frmUnidadesInventario.btn_confirmar_unidades.Text = "Confirmar"
        frmUnidadesInventario.txt_unidades_inventario.Clear()

        frmInventario.dg_inventario.DataSource = Nothing
        frmInventario.dg_inventario.Rows.Clear()
        listaInventario = inventarioAux.getInventario()
        frmInventario.dg_inventario.DataSource = listaInventario
        frmInventario.dg_inventario.ClearSelection()
    End Sub

    Private Sub click_btn_añadir_unidades(sender As Object, e As EventArgs)
        frmUnidadesInventario.Text = $"Añadir unidades de {inventarioTemp.NombreDeArticulo}"
        frmUnidadesInventario.btn_confirmar_unidades.Text = "Añadir"
        frmUnidadesInventario.ShowDialog()
        If frmUnidadesInventario.confirmado Then
            inventarioTemp.addUnidades(frmUnidadesInventario.cantidadVariar)
        End If
        fillDGInventario()
    End Sub
    Private Sub click_btn_restar_unidades(sender As Object, e As EventArgs)
        frmUnidadesInventario.Text = $"Restar unidades de {inventarioTemp.NombreDeArticulo}"
        frmUnidadesInventario.btn_confirmar_unidades.Text = "Restar"
        frmUnidadesInventario.ShowDialog()
        If frmUnidadesInventario.confirmado Then
            inventarioTemp.deleteUnidades(frmUnidadesInventario.cantidadVariar)
        End If
        fillDGInventario()
    End Sub

    Private Sub click_cell_dg_inventario(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            frmInventario.btn_añadir_unidades.Enabled = True
            frmInventario.btn_restar_unidades.Enabled = True
            inventarioTemp = frmInventario.dg_inventario.Rows(e.RowIndex).DataBoundItem
        End If
    End Sub

    Private Sub tab_main_SelectedIndexChanged(sender As Object, e As EventArgs)
        If frmInventario.tab_main.SelectedTab.Text.Equals("INVENTARIO") Then
            fillDGInventario()
        End If
    End Sub

End Class
Public Class frmFamilias
    Public familiaSeleccionada As String = Nothing
    Dim familiaTemp As Familia = New Familia()
    Dim listaFamilias As List(Of Familia) = New List(Of Familia)

    Private Sub frmFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_modificar_familia.Enabled = False
        btn_eliminar_familia.Enabled = False
        btn_seleccionar_familia.Enabled = False
        dg_familias.ClearSelection()
        fillDGFamilias()
    End Sub

    Private Sub fillDGFamilias()
        dg_familias.DataSource = Nothing
        dg_familias.Rows.Clear()
        listaFamilias = managerFamiliaAux.getFamilias()
        dg_familias.DataSource = listaFamilias
        btn_modificar_familia.Enabled = False
        btn_eliminar_familia.Enabled = False
        btn_seleccionar_familia.Enabled = False
        dg_familias.ClearSelection()
    End Sub

    Private Sub click_cell_dg_familias(sender As Object, e As DataGridViewCellEventArgs) Handles dg_familias.CellClick
        If e.RowIndex >= 0 Then
            btn_modificar_familia.Enabled = True
            btn_eliminar_familia.Enabled = True
            btn_seleccionar_familia.Enabled = True
            familiaTemp = dg_familias.Rows(e.RowIndex).DataBoundItem
        End If
    End Sub

    Private Sub click_btn_seleccionar_familia(sender As Object, e As EventArgs) Handles btn_seleccionar_familia.Click
        familiaSeleccionada = familiaTemp.NombreDeFamilia
        dg_familias.ClearSelection()
        Close()
    End Sub
    Private Sub click_btn_añadir_familia(sender As Object, e As EventArgs) Handles btn_añadir_familia.Click
        frmNuevaFamilia.ShowDialog()
        fillDGFamilias()
    End Sub
    Private Sub click_btn_modificar_familia(sender As Object, e As EventArgs) Handles btn_modificar_familia.Click
        frmNuevaFamilia.Text = "Modificar Familia"
        frmNuevaFamilia.btn_confirmar_familia.Text = "Modificar"
        frmNuevaFamilia.txt_codigo_familia.Text = familiaTemp.CodigoDeFamilia
        frmNuevaFamilia.txt_codigo_familia.Enabled = False
        frmNuevaFamilia.txt_nombre_familia.Text = familiaTemp.NombreDeFamilia
        frmNuevaFamilia.ShowDialog()
        fillDGFamilias()
    End Sub
    Private Sub click_btn_eliminar_familia(sender As Object, e As EventArgs) Handles btn_eliminar_familia.Click
        familiaTemp.deleteFamilia()
        fillDGFamilias()
    End Sub
End Class
Public Class frmAñadirArticuloInventario
    Dim articuloTemp As Articulo = New Articulo()

    Private Sub frmAñadirArticuloInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        articuloTemp = Nothing
    End Sub
    Private Sub click_btn_confirmar_articulo_inventario(sender As Object, e As EventArgs) Handles btn_confirmar_articulo_inventario.Click
        If Not articuloTemp = Nothing Then

        End If

    End Sub

    Private Sub cb_articulos_inventario_selectedvaluechanged(sender As Object, e As EventArgs) Handles cb_articulo_inventario.SelectedValueChanged
        articuloTemp = cb_articulo_inventario.SelectedValue
    End Sub


End Class
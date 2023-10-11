Public Class frmAñadirArticuloInventario
    Dim articuloTemp As String
    Dim listaArticulos As List(Of Articulo) = New List(Of Articulo)

    Private Sub frmAñadirArticuloInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        articuloTemp = Nothing
        fillCBArticulosInventario()
    End Sub
    Private Sub click_btn_confirmar_articulo_inventario(sender As Object, e As EventArgs) Handles btn_confirmar_articulo_inventario.Click
        If String.IsNullOrEmpty(articuloTemp) Or articuloTemp.Equals("") Then
            MessageBox.Show("Seleccione artículo primero")
            Return
        End If
        If String.IsNullOrEmpty(txt_cantidad_inventario.Text) Or Not IsNumeric(txt_cantidad_inventario.Text) Then
            MessageBox.Show("Introduzca una cantidad válida")
            Return
        End If
        Dim inventarioTemp As Inventario = New Inventario(articuloTemp, txt_cantidad_inventario.Text)
        inventarioTemp.addInventario()
        Close()
    End Sub

    Private Sub fillCBArticulosInventario()
        cb_articulo_inventario.Items.Clear()
        listaArticulos.Clear()
        listaArticulos = articuloAux.getArticulos()
        cb_articulo_inventario.Items.Add("")
        For Each articulillo In listaArticulos
            cb_articulo_inventario.Items.Add($"{articulillo.CodigoDeArticulo} - {articulillo.NombreDeArticulo}")
        Next
        cb_articulo_inventario.SelectedIndex = Nothing
        txt_cantidad_inventario.Clear()
    End Sub
    Private Sub cb_articulos_inventario_selectedvaluechanged(sender As Object, e As EventArgs) Handles cb_articulo_inventario.SelectedValueChanged
        articuloTemp = cb_articulo_inventario.SelectedItem
    End Sub
End Class
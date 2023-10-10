Public Class frmUnidadesInventario
    Public confirmado As Boolean = False
    Public cantidadVariar As Integer

    Private Sub frmUnidadesInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        confirmado = False
    End Sub
    Private Sub click_btn_confirmar_unidades(sender As Object, e As EventArgs) Handles btn_confirmar_unidades.Click
        If String.IsNullOrEmpty(txt_unidades_inventario.Text) Then
            MessageBox.Show("Introduzca una cantidad")
            Return
        End If
        If Not IsNumeric(txt_unidades_inventario.Text) Then
            MessageBox.Show("Introduzca una cantidad válida")
            Return
        End If
        cantidadVariar = Convert.ToInt32(txt_unidades_inventario.Text)
        If cantidadVariar < 0 Then
            MessageBox.Show("La cantidad debe ser mayor de 0")
            Return
        End If

        confirmado = True
        Close()
    End Sub
End Class
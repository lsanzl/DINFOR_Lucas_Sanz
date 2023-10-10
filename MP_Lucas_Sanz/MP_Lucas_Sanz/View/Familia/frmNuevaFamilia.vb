Public Class frmNuevaFamilia
    Private Sub click_btn_confirmar_familia(sender As Object, e As EventArgs) Handles btn_confirmar_familia.Click
        Dim codigoFamilia As String = txt_codigo_familia.Text
        Dim nombreFamilia As String = txt_nombre_familia.Text
        Dim familiaTemp As Familia = New Familia(codigoFamilia, nombreFamilia)

        If Not familiaTemp.checkCodigo(codigoFamilia) Then
            MessageBox.Show("Código incorrecto, máx 6 caracteres")
            Return
        End If
        If btn_confirmar_familia.Text = "Modificar" Then
            familiaTemp.modifyFamilia()
        Else
            familiaTemp.addFamilia()
        End If
        clearFields()
        Close()
    End Sub
    Private Sub clearFields()
        btn_confirmar_familia.Text = "Confirmar"
        txt_codigo_familia.Clear()
        txt_nombre_familia.Clear()
        txt_codigo_familia.Enabled = True
    End Sub
End Class
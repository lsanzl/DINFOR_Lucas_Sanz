Public Class frmConfirmacionUnidadesNegativas
    Public respuesta As Boolean = False

    Private Sub click_btn_confirmar_advertencia(sender As Object, e As EventArgs) Handles btn_confirmar_advertencia.Click
        respuesta = True
        Close()
    End Sub

    Private Sub click_btn_cancelar_advertencia(sender As Object, e As EventArgs) Handles btn_cancelar_advertencia.Click
        respuesta = False
        Close()
    End Sub
End Class
Public Class frmNuevaEmpresa
    Dim empresaAux As Empresa = New Empresa()

    Private Sub click_btn_nueva_empresa(sender As Object, e As EventArgs) Handles btn_confirmar_nueva_empresa.Click
        empresaAux.addEmpresa(txt_nueva_empresa.Text)
        Close()
    End Sub
End Class
Public Class frmNuevaEmpresa
    Private Sub click_btn_nueva_empresa(sender As Object, e As EventArgs) Handles btn_confirmar_nueva_empresa.Click
        If Not empresaAux.checkNombre(txt_nueva_empresa.Text) Then
            MessageBox.Show("Introduzca nombre válido (Emp + número)")
            Return
        End If
        If Not empresaAux.checkEmpresaDB(txt_nueva_empresa.Text) Then
            MessageBox.Show("Esa empresa ya existe")
            Return
        End If
        empresaAux.addEmpresa(txt_nueva_empresa.Text)
        Close()
    End Sub
End Class
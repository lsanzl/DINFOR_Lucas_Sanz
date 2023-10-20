Public Class frmNuevoGrupo
    Private Sub frmNuevoGrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub click_btn_confirmar_grupo(sender As Object, e As EventArgs) Handles btn_confirmar_nuevo_grupo.Click
        If String.IsNullOrEmpty(txt_codigo_grupo.Text) Then
            MessageBox.Show("Introduzca un nombre para el banco")
            Return
        End If
        If Not IsNumeric(txt_codigo_grupo.Text) Then
            MessageBox.Show("El código deber ser numérico")
            Return
        End If
        If btn_confirmar_nuevo_grupo.Text = "Confirmar" And managerGrupoAux.checkGrupo(txt_codigo_grupo.Text) Then
            MessageBox.Show("Nombre ya existente")
            Return
        End If
        Dim grupoTemp As Grupo = New Grupo(Convert.ToInt32(txt_codigo_grupo.Text), txt_nombre_grupo.Text)
        If btn_confirmar_nuevo_grupo.Text = "Modificar" Then
            grupoTemp.modifyGrupo()
        Else
            grupoTemp.addGrupo()
        End If
        Me.Close()
    End Sub
End Class
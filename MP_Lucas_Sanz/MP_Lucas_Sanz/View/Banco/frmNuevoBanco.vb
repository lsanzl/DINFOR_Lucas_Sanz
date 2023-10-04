Public Class frmNuevoBanco
    Private Sub frmNuevoBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub click_btn_confirmar_nuevo_banco(sender As Object, e As EventArgs) Handles btn_confirmar_nuevo_banco.Click
        If String.IsNullOrEmpty(txt_nombre_banco.Text) Then
            MessageBox.Show("Introduzca un nombre para el banco")
            Return
        End If
        If Not IsNumeric(txt_codigo_banco.Text) Then
            MessageBox.Show("El código del banco solo puede ser numérico")
            Return
        End If

        If Not bancoAux.checkBancoDB(txt_codigo_banco.Text) And btn_confirmar_nuevo_banco.Text = "Confirmar" Then
            MessageBox.Show("No puede repetirse el código del banco")
            Return
        End If
        Dim bancoTemp As Banco = New Banco(txt_nombre_banco.Text, Integer.Parse(txt_codigo_banco.Text))
        If btn_confirmar_nuevo_banco.Text = "Modificar" Then
            bancoTemp.modifyBanco()
        Else
            bancoTemp.addBanco()
        End If
        Me.Close()
    End Sub
End Class
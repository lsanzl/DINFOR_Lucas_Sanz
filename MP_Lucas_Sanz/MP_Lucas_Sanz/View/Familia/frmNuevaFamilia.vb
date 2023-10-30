Public Class frmNuevaFamilia
    Private Sub frmNuevaFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If btn_confirmar_familia.Text.Equals("Confirmar") Then
            txt_codigo_familia.Clear()
            txt_nombre_familia.Clear()
            txt_codigo_familia.Enabled = True
            lbl_nombre_familia.Text = "Nombre:"
        End If
        If Me.Text.Equals("Nuevo impuesto") Then
            Dim codigoNuevo As Integer = managerImpuestoAux.getIDImpuesto()
            txt_codigo_familia.Text = codigoNuevo
            txt_codigo_familia.Enabled = False
            lbl_nombre_familia.Text = "Cantidad:"
        End If
    End Sub
    Private Sub click_btn_confirmar_familia(sender As Object, e As EventArgs) Handles btn_confirmar_familia.Click
        Dim codigoFamilia As String = txt_codigo_familia.Text
        Dim nombreFamilia As String = txt_nombre_familia.Text

        If Not checkCampos() Then
            Return
        End If

        Dim familiaTemp As Familia = New Familia()
        Dim impuestoTemp As Impuesto = New Impuesto()
        If Me.Text.Equals("Nueva familia") Then
            familiaTemp = New Familia(codigoFamilia, nombreFamilia)
        Else
            impuestoTemp = New Impuesto(codigoFamilia, nombreFamilia)
        End If

        If btn_confirmar_familia.Text = "Modificar" Then
            familiaTemp.modifyFamilia()
        Else
            If Me.Text.Equals("Nueva familia") Then
                familiaTemp.addFamilia()
            Else
                impuestoTemp.addImpuesto()
            End If
        End If
        clearFields()
        Close()
    End Sub
    Private Function checkCampos() As Boolean
        If String.IsNullOrEmpty(txt_codigo_familia.Text) Or String.IsNullOrEmpty(txt_nombre_familia.Text) Then
            Return False
        End If
        If Not IsNumeric(txt_codigo_familia.Text) Then
            MessageBox.Show("El código debe ser numérico")
            Return False
        End If
        Return True
    End Function
    Private Sub clearFields()
        btn_confirmar_familia.Text = "Confirmar"
        txt_codigo_familia.Clear()
        txt_nombre_familia.Clear()
        txt_codigo_familia.Enabled = True
    End Sub
End Class
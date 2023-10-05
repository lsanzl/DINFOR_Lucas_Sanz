Public Class frmNuevaFormaPago
    Private Sub frmNuevaFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearFields()
        fillCBBancos()
    End Sub

    Dim bancoSeleccionado As String = Nothing

    Private Sub fillCBBancos()
        cb_banco_asignado.Items.Clear()
        Dim listaBancosTemp As List(Of Banco) = bancoAux.getBancos()
        Dim nombreBanco As String
        For Each Banco In listaBancosTemp
            nombreBanco = $"{Banco.NombreDeBanco} - {Banco.CodigoDeBanco}"
            cb_banco_asignado.Items.Add(nombreBanco)
        Next
    End Sub

    Public Sub change_cb_banco_asignado(sender As Object, e As EventArgs) Handles cb_banco_asignado.SelectedIndexChanged
        If Not cb_banco_asignado.SelectedIndex = -1 Then
            bancoSeleccionado = cb_banco_asignado.SelectedItem.ToString()
        End If
    End Sub

    Private Sub click_btn_confirmar_forma_pago(sender As Object, e As EventArgs) Handles btn_confirmar_forma_pago.Click
        If Not checkCampos() Then
            Return
        End If

        If Not managerFormaPagoAux.checkFormaPago(txt_codigo_forma_pago.Text) Then
            MessageBox.Show("Código ya existente")
            Return
        End If

        Dim stringBanco() As String
        Dim bancoAsignado As Integer = 0
        If Not bancoSeleccionado = Nothing Then
            stringBanco = bancoSeleccionado.Split(" - ")
            bancoAsignado = Convert.ToInt32(stringBanco(2))
        Else
            stringBanco = Nothing
        End If

        Dim codigoFormaPago As String = txt_codigo_forma_pago.Text
        Dim nombreFormaPago As String = txt_nombre_forma_pago.Text
        Dim estadoFormaPago As Integer
        If checkb_estado_forma_pago.Checked Then
            estadoFormaPago = 1
        Else
            estadoFormaPago = 0
        End If
        Dim numPlazos As Integer = checkNumeroVacio(txt_numero_plazos)
        Dim diasPrimerPlazo As Integer = checkNumeroVacio(txt_dias_primer_plazo)
        Dim diasEntrePlazos As Integer = checkNumeroVacio(txt_dias_entre_plazos)

        Dim formaPagoTemp As FormaPago = New FormaPago(codigoFormaPago, nombreFormaPago, bancoAsignado,
                                                    estadoFormaPago, numPlazos, diasPrimerPlazo, diasEntrePlazos)
        formaPagoTemp.addFormaPago()

        Close()
    End Sub

    Private Function checkCampos() As Boolean
        If txt_codigo_forma_pago.Text.Length > 5 Then
            MessageBox.Show("El código solo puede tener 5 caracteres")
            Return False
        End If
        If Not IsNumeric(txt_numero_plazos.Text) And Not String.IsNullOrEmpty(txt_numero_plazos.Text) Then
            MessageBox.Show("Introduzca un número válido")
            Return False
        End If
        If Not IsNumeric(txt_dias_entre_plazos.Text) And Not String.IsNullOrEmpty(txt_dias_entre_plazos.Text) Then
            MessageBox.Show("Introduzca un número válido")
            Return False
        End If
        If Not IsNumeric(txt_dias_primer_plazo.Text) And Not String.IsNullOrEmpty(txt_dias_primer_plazo.Text) Then
            MessageBox.Show("Introduzca un número válido")
            Return False
        End If
        Return True
    End Function

    Private Function checkNumeroVacio(tb As TextBox) As Integer
        If String.IsNullOrEmpty(tb.Text) Then
            Return Nothing
        Else
            Return Integer.Parse(tb.Text)
        End If
    End Function

    Private Sub clearFields()
        txt_codigo_forma_pago.Clear()
        txt_nombre_forma_pago.Clear()
        txt_numero_plazos.Clear()
        txt_dias_entre_plazos.Clear()
        txt_dias_primer_plazo.Clear()
        checkb_estado_forma_pago.CheckState = False
        cb_banco_asignado.SelectedIndex = -1
    End Sub
End Class
Public Class frmNuevaFormaPago
    Private Sub frmNuevaFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCBBancos()
        If btn_confirmar_forma_pago.Text.Equals("Confirmar") Then
            clearFields()
        End If
    End Sub

    Private bancoSeleccionado As Integer = Nothing
    Private bancoAsignadoMod As Integer
    Private bancoYaSeleccionado As Integer = -1
    Private contador As Integer = 0

    Private Sub fillCBBancos()
        contador = 1
        bancoYaSeleccionado = -1
        cb_banco_asignado.Items.Clear()

        Dim listaBancosTemp As List(Of Banco) = bancoAux.getBancos()
        cb_banco_asignado.Items.Add("")

        For Each Banco In listaBancosTemp
            If Not bancoAsignadoMod = Nothing Then
                If Banco.CodigoDeBanco = bancoAsignadoMod Then
                    bancoYaSeleccionado = contador
                End If
            End If
            cb_banco_asignado.Items.Add(Banco.CodigoDeBanco)
            contador += 1
        Next
        cb_banco_asignado.SelectedIndex = bancoYaSeleccionado
    End Sub
    Private Sub click_btn_confirmar_forma_pago(sender As Object, e As EventArgs) Handles btn_confirmar_forma_pago.Click
        If Not checkCampos() Then
            Return
        End If

        If Not managerFormaPagoAux.checkFormaPago(Convert.ToInt32(txt_codigo_forma_pago.Text)) And btn_confirmar_forma_pago.Text.Equals("Confirmar") Then
            MessageBox.Show("Código ya existente")
            Return
        End If

        Dim bancoAsignado As Integer = 0
        If cb_banco_asignado.SelectedIndex > 0 Then
            bancoAsignado = Convert.ToInt32(cb_banco_asignado.SelectedItem)
        End If

        Dim codigoFormaPago As Integer = Convert.ToInt32(txt_codigo_forma_pago.Text)
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

        If btn_confirmar_forma_pago.Text.Equals("Confirmar") Then
            formaPagoTemp.addFormaPago()
        Else
            formaPagoTemp.modifyFormaPago()
        End If
        Close()
    End Sub
    Private Function checkCampos() As Boolean
        If Not IsNumeric(txt_codigo_forma_pago.Text) Then
            MessageBox.Show("El código debe ser numérico")
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
            Return Convert.ToInt32(tb.Text)
        End If
    End Function
    Public Sub clearFields()
        txt_codigo_forma_pago.Clear()
        txt_nombre_forma_pago.Clear()
        txt_numero_plazos.Clear()
        txt_dias_entre_plazos.Clear()
        txt_dias_primer_plazo.Clear()
        checkb_estado_forma_pago.CheckState = False
        cb_banco_asignado.SelectedIndex = -1
        txt_codigo_forma_pago.Enabled = True
        bancoAsignadoMod = Nothing
    End Sub
    Public Sub setBancoAsignadoMod(numBanco As Integer)
        bancoAsignadoMod = numBanco
    End Sub
End Class
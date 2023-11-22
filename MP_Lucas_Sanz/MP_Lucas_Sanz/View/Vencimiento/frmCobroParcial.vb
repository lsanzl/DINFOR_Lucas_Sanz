Public Class frmCobroParcial
    Private v As Vencimiento

    Public Sub New(v As Vencimiento)
        InitializeComponent()
        Me.v = v
        lbl_importe_pendiente.Text = $"Importe pendiente: {v.ImportePendiente.ToString("N2")}"
    End Sub
    Private Sub click_btn_confirmar_pago_parcial(sender As Object, e As EventArgs) Handles btn_confirmar_pago_parcial.Click
        If String.IsNullOrEmpty(txt_pago_pacial.Text) Then
            MessageBox.Show("Introduzca cantidad válida")
            Return
        End If
        Dim cantidadPago As Double = Math.Round(Convert.ToDouble(txt_pago_pacial.Text), 2)
        If cantidadPago > v.ImportePendiente Then
            MessageBox.Show("El pago excede lo pendiente")
            Return
        End If
        v.ImportePagado += cantidadPago
        v.cobrarVencimiento()
        Me.Close()
    End Sub
    Private Sub click_btn_cancelar_pago_parcial(sender As Object, e As EventArgs) Handles btn_cancelar_pago_parcial.Click
        Me.Close()
    End Sub
End Class
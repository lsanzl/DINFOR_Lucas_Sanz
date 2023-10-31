Public Class ctrAlbaran
    Dim frmAlbaran As frmMain

    Public Sub New(frmAlbaranPasado As frmMain)
        MyBase.New()
        frmAlbaran = frmAlbaranPasado

        AddHandler frmAlbaran.tab_main.SelectedIndexChanged, AddressOf tab_main_SelectedIndexChanged
    End Sub

    Private Sub fillDGAlbaranes()
        If VariablesGlobales.albaranSeleccionado.Equals("Ventas") Then
            fillDGAlbaranesVentas()
        Else
            fillDGAlbaranesCompras()
        End If
    End Sub
    Private Sub fillDGAlbaranesVentas()

    End Sub
    Private Sub fillDGAlbaranesCompras()

    End Sub
    Private Sub tab_main_SelectedIndexChanged(sender As Object, e As EventArgs)
        If frmAlbaran.tab_main.SelectedTab.Text.Equals("ALBARANES") Then
            fillDGAlbaranes()
        End If
    End Sub
End Class
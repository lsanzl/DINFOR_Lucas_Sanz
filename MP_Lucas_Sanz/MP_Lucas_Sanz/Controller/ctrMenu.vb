Public Class ctrMenu
    Dim frmMenu As frmMain

    Public Sub New(frmMenuPasado As frmMain)
        MyBase.New()
        frmMenu = frmMenuPasado

        AddHandler frmMenu.btn_efectuar_compra.Click, AddressOf click_btn_efectuar_compra
    End Sub

    Private Sub click_btn_efectuar_compra(sender As Object, e As EventArgs)
        frmCompra.ShowDialog()
    End Sub

End Class
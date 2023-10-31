Public Class ctrMenu
    Dim frmMenu As frmMain

    Public Sub New(frmMenuPasado As frmMain)
        MyBase.New()
        frmMenu = frmMenuPasado

        AddHandler frmMenu.btn_efectuar_compra.Click, AddressOf click_btn_efectuar_compra
        AddHandler frmMenu.btn_efectuar_venta.Click, AddressOf click_btn_efectuar_venta
        AddHandler frmMenu.btn_menu_inventario.Click, AddressOf click_btn_menu_inventario
        AddHandler frmMenu.btn_menu_configuraciones.Click, AddressOf click_btn_menu_configuraciones
        AddHandler frmMenu.btn_ver_ventas.Click, AddressOf click_btn_ver_ventas
        AddHandler frmMenu.btn_ver_compras.Click, AddressOf click_btn_ver_compras
    End Sub

    Private Sub click_btn_efectuar_compra(sender As Object, e As EventArgs)
        frmCompra.ShowDialog()
    End Sub
    Private Sub click_btn_efectuar_venta(sender As Object, e As EventArgs)
        frmVenta.ShowDialog()
    End Sub
    Private Sub click_btn_menu_inventario(sender As Object, e As EventArgs)
        For Each tab As TabPage In frmMenu.tab_main.TabPages
            If tab.Text.Equals("INVENTARIO") Then
                frmMenu.tab_main.SelectedIndex = tab.TabIndex
            End If
        Next
    End Sub
    Private Sub click_btn_menu_configuraciones(sender As Object, e As EventArgs)
        For Each tab As TabPage In frmMenu.tab_main.TabPages
            If tab.Text.Equals("CONFIGURACIONES") Then
                frmMenu.tab_main.SelectedIndex = tab.TabIndex
            End If
        Next
    End Sub
    Private Sub click_btn_ver_ventas(sender As Object, e As EventArgs)
        VariablesGlobales.albaranSeleccionado = "Ventas"
        For Each tab As TabPage In frmMenu.tab_main.TabPages
            If tab.Text.Equals("ALBARANES") Then
                frmMenu.tab_main.SelectedIndex = tab.TabIndex
            End If
        Next
    End Sub
    Private Sub click_btn_ver_compras(sender As Object, e As EventArgs)
        VariablesGlobales.albaranSeleccionado = "Compras"
        For Each tab As TabPage In frmMenu.tab_main.TabPages
            If tab.Text.Equals("ALBARANES") Then
                frmMenu.tab_main.SelectedIndex = tab.TabIndex
            End If
        Next
    End Sub
End Class
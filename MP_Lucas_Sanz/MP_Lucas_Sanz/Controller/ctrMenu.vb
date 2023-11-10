Public Class ctrMenu
    Dim frmMenu As frmMain

    Public Sub New(frmMenuPasado As frmMain)
        MyBase.New()
        frmMenu = frmMenuPasado

        AddHandler frmMenu.btn_efectuar_compra.Click, AddressOf click_btn_efectuar_compra
        AddHandler frmMenu.btn_efectuar_venta.Click, AddressOf click_btn_efectuar_venta
        AddHandler frmMenu.btn_menu_factura.Click, AddressOf click_btn_menu_factura
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
    Private Sub click_btn_menu_factura(sender As Object, e As EventArgs)
        frmMenu.tab_main.SelectTab("tab_facturas")
    End Sub
    Private Sub click_btn_menu_configuraciones(sender As Object, e As EventArgs)
        frmMenu.tab_main.SelectTab("tab_configuraciones")
    End Sub
    Private Sub click_btn_ver_ventas(sender As Object, e As EventArgs)
        VariablesGlobales.albaranSeleccionado = "Ventas"
        frmMenu.tab_main.SelectTab("tab_albaranes")
    End Sub
    Private Sub click_btn_ver_compras(sender As Object, e As EventArgs)
        VariablesGlobales.albaranSeleccionado = "Compras"
        frmMenu.tab_main.SelectTab("tab_albaranes")
    End Sub
End Class
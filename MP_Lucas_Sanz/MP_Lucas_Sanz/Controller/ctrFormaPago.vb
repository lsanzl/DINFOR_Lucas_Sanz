Public Class ctrFormaPago
    Public frmFormasPago As frmMain
    Dim formaPagoSeleccionado As Boolean = False
    Dim listaFormasPago As List(Of FormaPago) = New List(Of FormaPago)
    Dim formaPagoTemp As FormaPago

    Public Sub New(frmPasado As frmMain)
        MyBase.New()
        frmFormasPago = frmPasado

        AddHandler frmFormasPago.btn_añadir_forma_pago.Click, AddressOf click_btn_añadir_forma_pago
        AddHandler frmFormasPago.btn_modificar_forma_pago.Click, AddressOf click_btn_modificar_forma_pago
        AddHandler frmFormasPago.btn_eliminar_forma_pago.Click, AddressOf click_btn_eliminar_forma_pago
        AddHandler frmFormasPago.dg_formas_pago.CellClick, AddressOf click_cell_formas_pago
        AddHandler frmFormasPago.tab_main.SelectedIndexChanged, AddressOf tab_main_SelectedIndexChanged
    End Sub

    Public Sub fillDGFormasPago()
        formaPagoTemp = Nothing
        formaPagoSeleccionado = False
        frmMain.btn_modificar_forma_pago.Enabled = False
        frmMain.btn_eliminar_forma_pago.Enabled = False
        frmNuevaFormaPago.btn_confirmar_forma_pago.Text = "Confirmar"
        frmFormasPago.dg_formas_pago.DataSource = Nothing
        frmFormasPago.dg_formas_pago.Rows.Clear()
        listaFormasPago = formaPagoAux.getFormasPago()
        frmFormasPago.dg_formas_pago.DataSource = listaFormasPago
        frmFormasPago.dg_formas_pago.ClearSelection()
    End Sub

    Private Sub click_cell_formas_pago(sender As Object, e As DataGridViewCellEventArgs)
        If Not e.RowIndex >= 0 Then
            Return
        End If
        Dim currentCelll As DataGridViewCell = frmFormasPago.dg_formas_pago.CurrentCell
        If currentCelll.OwningColumn.HeaderText.Equals("Activo") Then
            formaPagoTemp = frmFormasPago.dg_formas_pago.Rows(e.RowIndex).DataBoundItem
            formaPagoTemp.changeEstado()
            fillDGFormasPago()
            Return
        End If

        frmFormasPago.btn_modificar_forma_pago.Enabled = True
        frmFormasPago.btn_eliminar_forma_pago.Enabled = True
        formaPagoTemp = frmFormasPago.dg_formas_pago.Rows(e.RowIndex).DataBoundItem
    End Sub

    Private Sub click_btn_añadir_forma_pago(sender As Object, e As EventArgs)
        frmNuevaFormaPago.Text = "Creación nueva forma de pago"
        frmNuevaFormaPago.btn_confirmar_forma_pago.Text = "Confirmar"
        frmNuevaFormaPago.txt_codigo_forma_pago.ReadOnly = False
        frmNuevaFormaPago.ShowDialog()
        fillDGFormasPago()
    End Sub

    Private Sub click_btn_modificar_forma_pago(sender As Object, e As EventArgs)
        frmNuevaFormaPago.Text = "Modificación forma de pago"
        frmNuevaFormaPago.btn_confirmar_forma_pago.Text = "Modificar"

        frmNuevaFormaPago.txt_codigo_forma_pago.Text = formaPagoTemp.CodigoDePago
        frmNuevaFormaPago.txt_codigo_forma_pago.ReadOnly = True
        frmNuevaFormaPago.txt_nombre_forma_pago.Text = formaPagoTemp.NombreDePago
        frmNuevaFormaPago.txt_numero_plazos.Text = formaPagoTemp.NumeroPlazosPago
        frmNuevaFormaPago.txt_dias_primer_plazo.Text = formaPagoTemp.PrimerPlazo
        frmNuevaFormaPago.txt_dias_entre_plazos.Text = formaPagoTemp.DiasPlazos
        frmNuevaFormaPago.checkb_estado_forma_pago.CheckState = formaPagoTemp.Activo

        frmNuevaFormaPago.setBancoAsignadoMod(formaPagoTemp.BancoAsignado)
        frmNuevaFormaPago.ShowDialog()
        frmNuevaFormaPago.clearFields()
        fillDGFormasPago()
    End Sub

    Private Sub click_btn_eliminar_forma_pago(sender As Object, e As EventArgs)
        formaPagoTemp.deleteFormaPago()
        fillDGFormasPago()
    End Sub

    Private Sub tab_main_SelectedIndexChanged(sender As Object, e As EventArgs)
        If frmFormasPago.tab_main.SelectedTab.Text.Equals("BANCOS/PAGOS") Then
            fillDGFormasPago()
        End If
    End Sub
End Class
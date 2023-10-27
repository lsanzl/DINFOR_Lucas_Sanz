Public Class ctrFormaPago
    Public frmFormasPago As frmMain
    Dim formaPagoSeleccionado As Boolean = False
    Dim listaFormasPago As List(Of FormaPago) = New List(Of FormaPago)
    Dim formaPagoTemp As FormaPago
    Dim criterioBusqueda As String = "nombreFormaPago"

    Public Sub New(frmPasado As frmMain)
        MyBase.New()
        frmFormasPago = frmPasado
        frmFormasPago.rdb_nombre_forma_pago.Checked = True

        AddHandler frmFormasPago.btn_añadir_forma_pago.Click, AddressOf click_btn_añadir_forma_pago
        AddHandler frmFormasPago.btn_modificar_forma_pago.Click, AddressOf click_btn_modificar_forma_pago
        AddHandler frmFormasPago.btn_eliminar_forma_pago.Click, AddressOf click_btn_eliminar_forma_pago
        AddHandler frmFormasPago.dg_formas_pago.CellClick, AddressOf click_cell_formas_pago
        AddHandler frmFormasPago.tab_main.SelectedIndexChanged, AddressOf tab_main_SelectedIndexChanged
        AddHandler frmFormasPago.rdb_codigo_forma_pago.CheckedChanged, AddressOf checked_changed_gb_formas_pago
        AddHandler frmFormasPago.rdb_nombre_forma_pago.CheckedChanged, AddressOf checked_changed_gb_formas_pago
        AddHandler frmFormasPago.txt_busqueda_forma_pago.TextChanged, AddressOf text_changed_txt_busqueda_forma_pago
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
    Private Sub checked_changed_gb_formas_pago(sender As Object, e As EventArgs)
        If frmFormasPago.rdb_codigo_forma_pago.Checked Then
            criterioBusqueda = "codigoFormaPago"
        Else
            criterioBusqueda = "nombreFormaPago"
        End If
    End Sub
    Private Function lookForText(textoOrigen As String, textoBusqueda As String) As Boolean
        Dim resultado As Integer
        resultado = InStr(1, textoOrigen, textoBusqueda)
        If resultado > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub text_changed_txt_busqueda_forma_pago(sender As Object, e As EventArgs)
        Dim textoBusqueda As String = frmFormasPago.txt_busqueda_forma_pago.Text
        Dim dg As DataGridView = frmFormasPago.dg_formas_pago

        If frmFormasPago.txt_busqueda_forma_pago.Text = Nothing Then
            For Each fila As DataGridViewRow In dg.Rows
                fila.Visible = True
            Next
            Exit Sub
        End If
        For Each fila As DataGridViewRow In dg.Rows
            If lookForText(fila.Cells(criterioBusqueda).Value.ToString().Trim, textoBusqueda.Trim) Then
                dg.CurrentCell = Nothing
                fila.Visible = True
            Else
                dg.CurrentCell = Nothing
                fila.Visible = False
            End If
        Next
    End Sub
    Private Sub tab_main_SelectedIndexChanged(sender As Object, e As EventArgs)
        If frmFormasPago.tab_main.SelectedTab.Text.Equals("BANCOS/PAGOS") Then
            fillDGFormasPago()
        End If
    End Sub
End Class
Public Class ctrBanco
    Public frmBanco As frmMain
    Dim listaBancos As List(Of Banco) = New List(Of Banco)
    Dim bancoTemp As Banco
    Dim criterioBusqueda As String = "nombreBanco"

    Public Sub New(frmBancoPasado As frmMain)
        MyBase.New()
        frmBanco = frmBancoPasado
        frmBanco.rdb_nombre_banco.Checked = True

        AddHandler frmBanco.btn_añadir_banco.Click, AddressOf click_btn_añadir_banco
        AddHandler frmBanco.btn_modificar_banco.Click, AddressOf click_btn_modificar_banco
        AddHandler frmBanco.btn_eliminar_banco.Click, AddressOf click_btn_eliminar_banco
        AddHandler frmBanco.dg_bancos.CellClick, AddressOf click_cell_dg_bancos
        AddHandler frmBanco.tab_main.SelectedIndexChanged, AddressOf tab_main_SelectedIndexChanged
        AddHandler frmBanco.rdb_codigo_banco.CheckedChanged, AddressOf checked_changed_gb_bancos
        AddHandler frmBanco.rdb_nombre_banco.CheckedChanged, AddressOf checked_changed_gb_bancos
        AddHandler frmBanco.txt_busqueda_banco.TextChanged, AddressOf text_changed_txt_busqueda_banco
    End Sub

    Public Sub fillDGBancos()
        frmBanco.btn_modificar_banco.Enabled = False
        frmBanco.btn_eliminar_banco.Enabled = False

        frmNuevoBanco.btn_confirmar_nuevo_banco.Text = "Confirmar"
        frmNuevoBanco.txt_codigo_banco.Clear()
        frmNuevoBanco.txt_nombre_banco.Clear()

        frmBanco.dg_bancos.DataSource = Nothing
        frmBanco.dg_bancos.Rows.Clear()
        listaBancos = bancoAux.getBancos()
        frmBanco.dg_bancos.DataSource = listaBancos
        frmBanco.dg_bancos.ClearSelection()
    End Sub

    Private Sub click_btn_añadir_banco(sender As Object, e As EventArgs)
        frmNuevoBanco.Text = "Creación nuevo banco"
        frmNuevoBanco.ShowDialog()
        fillDGBancos()
    End Sub

    Private Sub click_btn_modificar_banco(sender As Object, e As EventArgs)
        frmNuevoBanco.Text = "Modificación de banco"
        frmNuevoBanco.txt_codigo_banco.Text = bancoTemp.CodigoDeBanco
        frmNuevoBanco.txt_codigo_banco.Enabled = False
        frmNuevoBanco.txt_nombre_banco.Text = bancoTemp.NombreDeBanco
        frmNuevoBanco.btn_confirmar_nuevo_banco.Text = "Modificar"
        frmNuevoBanco.ShowDialog()

        frmNuevoBanco.txt_codigo_banco.Clear()
        frmNuevoBanco.txt_codigo_banco.Enabled = True
        frmNuevoBanco.txt_nombre_banco.Clear()

        fillDGBancos()
    End Sub

    Private Sub click_btn_eliminar_banco(sender As Object, e As EventArgs)
        bancoTemp.deleteBanco()
        Dim ctrBancoPago As ctrFormaPago = New ctrFormaPago(frmBanco)
        ctrBancoPago.fillDGFormasPago()
        fillDGBancos()
    End Sub

    Private Sub click_cell_dg_bancos(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            frmBanco.btn_modificar_banco.Enabled = True
            frmBanco.btn_eliminar_banco.Enabled = True
            bancoTemp = frmBanco.dg_bancos.Rows(e.RowIndex).DataBoundItem
        End If
    End Sub
    Private Sub checked_changed_gb_bancos(sender As Object, e As EventArgs)
        If frmBanco.rdb_codigo_banco.Checked Then
            criterioBusqueda = "codigoBanco"
        Else
            criterioBusqueda = "nombreBanco"
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
    Private Sub text_changed_txt_busqueda_banco(sender As Object, e As EventArgs)
        Dim textoBusqueda As String = frmBanco.txt_busqueda_banco.Text
        Dim dg As DataGridView = frmBanco.dg_bancos

        If frmBanco.txt_busqueda_banco.Text = Nothing Then
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
        If frmBanco.tab_main.SelectedTab.Text.Equals("BANCOS/PAGOS") Then
            fillDGBancos()
        End If
    End Sub
End Class
Public Class ctrCliente
    Public frmCliente As frmMain
    Dim listaClientes As List(Of Cliente) = New List(Of Cliente)
    Dim clienteTemp As Cliente
    Dim criterioBusqueda As String = "nombreCliente"

    Public Sub New(frmClientePasado As frmMain)
        MyBase.New()
        frmCliente = frmClientePasado
        frmCliente.rdb_nombre_cliente.Checked = True

        AddHandler frmCliente.btn_añadir_cliente.Click, AddressOf click_btn_añadir_cliente
        AddHandler frmCliente.btn_modificar_cliente.Click, AddressOf click_btn_modificar_cliente
        AddHandler frmCliente.btn_eliminar_cliente.Click, AddressOf click_btn_eliminar_cliente
        AddHandler frmCliente.dg_clientes.CellClick, AddressOf click_cell_dg_clientes
        AddHandler frmCliente.tab_main.SelectedIndexChanged, AddressOf tab_main_SelectedIndexChanged
        AddHandler frmCliente.rdb_id_cliente.CheckedChanged, AddressOf checked_changed_gb_clientes
        AddHandler frmCliente.rdb_nombre_cliente.CheckedChanged, AddressOf checked_changed_gb_clientes
        AddHandler frmCliente.rdb_nif_cliente.CheckedChanged, AddressOf checked_changed_gb_clientes
        AddHandler frmCliente.txt_busqueda_cliente.TextChanged, AddressOf text_changed_txt_busqueda_cliente
    End Sub

    Public Sub fillDGClientes()
        listaClientes.Clear()

        frmCliente.btn_modificar_cliente.Enabled = False
        frmCliente.btn_eliminar_cliente.Enabled = False

        frmCliente.dg_clientes.DataSource = Nothing
        frmCliente.dg_clientes.Rows.Clear()
        listaClientes = managerClienteAux.getClientes()
        frmCliente.dg_clientes.DataSource = listaClientes

        frmCliente.dg_clientes.ClearSelection()
    End Sub

    Private Sub click_btn_añadir_cliente(sender As Object, e As EventArgs)
        frmNuevoCliente.Text = "Creación nuevo cliente"
        frmNuevoCliente.btn_confirmar_cliente.Text = "Confirmar"
        frmNuevoCliente.txt_codigo_cliente.Text = managerClienteAux.getIDCliente()
        frmNuevoCliente.txt_codigo_cliente.Enabled = False
        frmNuevoCliente.ShowDialog()

        fillDGClientes()
    End Sub
    Private Sub click_btn_modificar_cliente(sender As Object, e As EventArgs)
        frmNuevoCliente.txt_codigo_cliente.Text = clienteTemp.CodigoDelCliente
        frmNuevoCliente.txt_codigo_cliente.Enabled = False
        frmNuevoCliente.txt_nombre_cliente.Text = clienteTemp.NombreDelCliente
        frmNuevoCliente.txt_nif_cliente.Text = clienteTemp.NifDelCliente
        frmNuevoCliente.txt_direccion_cliente.Text = clienteTemp.DireccionDelCliente
        frmNuevoCliente.txt_direccion_cliente.Text = clienteTemp.DireccionDelCliente
        frmNuevoCliente.dp_fecha_nacimiento_cliente.Value = clienteTemp.FechaDeNacimientoDelCliente
        frmNuevoCliente.setBancoAsignadoMod(clienteTemp.BancoDelCliente)
        frmNuevoCliente.setGrupoAsignadoMod(clienteTemp.GrupoDelCliente)
        frmNuevoCliente.txt_email_cliente.Text = clienteTemp.EmailDelCliente

        frmNuevoCliente.Text = "Modificación del cliente"
        frmNuevoCliente.btn_confirmar_cliente.Text = "Modificar"
        frmNuevoCliente.ShowDialog()
        frmNuevoCliente.clearFields()

        fillDGClientes()
    End Sub
    Private Sub click_btn_eliminar_cliente(sender As Object, e As EventArgs)
        clienteTemp.deleteCliente()
        fillDGClientes()
    End Sub
    Private Sub click_cell_dg_clientes(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            frmCliente.btn_modificar_cliente.Enabled = True
            frmCliente.btn_eliminar_cliente.Enabled = True
            clienteTemp = frmCliente.dg_clientes.Rows(e.RowIndex).DataBoundItem
        End If
    End Sub
    Private Sub checked_changed_gb_clientes(sender As Object, e As EventArgs)
        If frmCliente.rdb_id_cliente.Checked Then
            criterioBusqueda = "codigoCliente"
        ElseIf frmCliente.rdb_nombre_cliente.Checked Then
            criterioBusqueda = "nombreCliente"
        Else
            criterioBusqueda = "nifCliente"
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
    Private Sub text_changed_txt_busqueda_cliente(sender As Object, e As EventArgs)
        Dim textoBusqueda As String = frmCliente.txt_busqueda_cliente.Text
        Dim dg As DataGridView = frmCliente.dg_clientes

        If frmCliente.txt_busqueda_cliente.Text = Nothing Then
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
        If frmCliente.tab_main.SelectedTab.Text.Equals("CLIENTES/GRUPOS") Then
            fillDGClientes()
        End If
    End Sub
End Class

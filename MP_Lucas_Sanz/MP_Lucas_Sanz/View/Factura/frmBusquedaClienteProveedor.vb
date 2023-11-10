Public Class frmBusquedaClienteProveedor
    'Private dg As DataGridView = dg_busqueda_cliente_proveedor
    Public tipoBusqueda As String = "Cliente"
    Public clienteSeleccionado As Cliente
    Public proveedorSeleccionado As Proveedor

    Public Sub New()
        InitializeComponent()
        rdb_busqueda_cliente.Checked = True
        fillDG()
    End Sub

    Private Sub checked_changed_gb_busqueda_entidad(sender As Object, e As EventArgs) Handles rdb_busqueda_cliente.CheckedChanged, rdb_busqueda_proveedor.CheckedChanged
        If rdb_busqueda_cliente.Checked Then
            tipoBusqueda = "Cliente"
            fillDG()
        Else
            tipoBusqueda = "Proveedor"
            fillDG()
        End If
    End Sub
    Private Sub fillDG()
        Dim dg As DataGridView = dg_busqueda_cliente_proveedor
        dg.Rows.Clear()
        If tipoBusqueda.Equals("Cliente") Then
            For Each c As Cliente In listaClientesAux
                Dim index As Integer = dg.Rows.Add()
                dg.Rows(index).Cells("idEntidad").Value = c.CodigoDelCliente
                dg.Rows(index).Cells("nombreEntidad").Value = c.NombreDelCliente
            Next
        Else
            For Each p As Proveedor In listaProveedoresAux
                Dim index As Integer = dg.Rows.Add()
                dg.Rows(index).Cells("idEntidad").Value = p.CodigoDeProveedor
                dg.Rows(index).Cells("nombreEntidad").Value = p.NombreDeProveedor
            Next
        End If
    End Sub
    Private Sub cell_double_click_dg_busqueda_cliente_proveedor(sender As Object, e As DataGridViewCellEventArgs) Handles dg_busqueda_cliente_proveedor.CellDoubleClick
        If e.RowIndex < 0 Then
            Return
        End If
        Dim codigoSeleccionado As Integer = dg_busqueda_cliente_proveedor.Rows(e.RowIndex).Cells("idEntidad").Value
        If tipoBusqueda.Equals("Cliente") Then
            clienteSeleccionado = getClientePorCodigo(codigoSeleccionado)
        Else
            proveedorSeleccionado = getProveedorPorCodigo(codigoSeleccionado)
        End If
        Me.Close()
    End Sub
    Private Function lookForText(textoOrigen As String, textoBusqueda As String) As Boolean
        Dim resultado As Integer
        resultado = InStr(1, textoOrigen.ToUpper(), textoBusqueda.ToUpper())
        If resultado > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub text_changed_txt_busqueda_entidad(sender As Object, e As EventArgs) Handles txt_busqueda_entidad.TextChanged
        Dim textoBusqueda As String = txt_busqueda_entidad.Text
        Dim dg As DataGridView = dg_busqueda_cliente_proveedor
        If textoBusqueda = Nothing Then
            For Each fila As DataGridViewRow In dg.Rows
                fila.Visible = True
            Next
            Exit Sub
        End If
        For Each fila As DataGridViewRow In dg.Rows
            If lookForText(fila.Cells("nombreEntidad").Value.ToString().Trim, textoBusqueda.Trim) Then
                dg.CurrentCell = Nothing
                fila.Visible = True
            Else
                dg.CurrentCell = Nothing
                fila.Visible = False
            End If
        Next
    End Sub
    Private Sub click_btn_cancelar_busqueda_entidad(sender As Object, e As EventArgs) Handles btn_cancelar_busqueda_entidad.Click
        Me.Close()
    End Sub
End Class
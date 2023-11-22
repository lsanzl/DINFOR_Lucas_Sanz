Public Class ctrVencimiento
    Private frmVencimiento As frmMain
    Private dg As DataGridView
    Private vencimientoSeleccionado As Vencimiento
    Private entidadSeleccionada As String

    Public Sub New(frmmain As frmMain)
        frmVencimiento = frmmain
        dg = frmVencimiento.dg_vencimientos
        frmVencimiento.rdb_cliente_vencimiento.Checked = True
        entidadSeleccionada = "C"

        AddHandler frmVencimiento.btn_consultar_vencimiento.Click, AddressOf click_btn_consultar_vencimiento
        AddHandler frmVencimiento.btn_cobrar_vencimiento.Click, AddressOf click_btn_cobrar_vencimiento
        AddHandler frmVencimiento.btn_cobro_parcial_vencimiento.Click, AddressOf click_btn_cobro_parcial_vencimiento
        AddHandler frmVencimiento.btn_eliminar_vencimiento.Click, AddressOf click_btn_eliminar_vencimiento
        AddHandler frmVencimiento.dg_vencimientos.CellClick, AddressOf cell_click_dg_vencimientos
        AddHandler frmVencimiento.rdb_cliente_vencimiento.CheckedChanged, AddressOf checked_changed_gb_busqueda_vencimiento
        AddHandler frmVencimiento.rdb_proveedor_vencimiento.CheckedChanged, AddressOf checked_changed_gb_busqueda_vencimiento
        AddHandler frmVencimiento.txt_busqueda_entidad_vencimiento.TextChanged, AddressOf text_changed_txt_busqueda_vencimientos
        AddHandler frmVencimiento.btn_buscar_vencimiento.Click, AddressOf click_btn_buscar_vencimiento
    End Sub

    Private Sub click_btn_consultar_vencimiento(sender As Object, e As EventArgs)
        fillDGVencimientos()
    End Sub
    Private Sub checked_changed_gb_busqueda_vencimiento(sender As Object, e As EventArgs)
        If frmVencimiento.rdb_cliente_vencimiento.Checked Then
            entidadSeleccionada = "C"
        Else
            entidadSeleccionada = "P"
        End If
        fillDGVencimientos()
    End Sub
    Private Sub cell_click_dg_vencimientos(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then
            Return
        End If
        vencimientoSeleccionado = getVencimientoPorCodigo(dg.Rows(e.RowIndex).Cells("idVencimiento").Value)
        frmVencimiento.btn_cobrar_vencimiento.Enabled = True
        frmVencimiento.btn_cobro_parcial_vencimiento.Enabled = True
        frmVencimiento.btn_eliminar_vencimiento.Enabled = True
    End Sub
    Private Sub click_btn_cobrar_vencimiento(sender As Object, e As EventArgs)
        vencimientoSeleccionado.ImportePagado = vencimientoSeleccionado.ImportePendiente
        vencimientoSeleccionado.ImportePendiente = 0
        vencimientoSeleccionado.cobrarVencimiento()
        fillDGVencimientos()
    End Sub
    Private Sub click_btn_cobro_parcial_vencimiento(sender As Object, e As EventArgs)
        Dim frmCobroP As frmCobroParcial = New frmCobroParcial(vencimientoSeleccionado)
        frmCobroP.ShowDialog()
        fillDGVencimientos()
    End Sub
    Private Sub click_btn_eliminar_vencimiento(sender As Object, e As EventArgs)
        eliminarPago()
    End Sub
    Private Sub fillDGVencimientos()
        Dim listaOrdenada As List(Of Vencimiento) = VariablesGlobales.listaVencimientosAux
        listaOrdenada = listaOrdenada.OrderBy(Function(v) v.FechaDeVencimiento).ToList()

        dg.Rows.Clear()
        For Each v As Vencimiento In listaOrdenada
            If Not v.TipoDeEntidad.Equals(entidadSeleccionada) Then
                Continue For
            End If
            Dim index As Integer = dg.Rows.Add()
            dg.Rows(index).Cells("idVencimiento").Value = v.CodigoDeVencimiento
            dg.Rows(index).Cells("idFacturaVencimiento").Value = v.CodigoDeFactura
            If v.TipoDeEntidad.Equals("C") Then
                dg.Rows(index).Cells("clienteVencimiento").Value = v.ClienteDeVencimiento.NombreDelCliente
                dg.Rows(index).Cells("proveedorVencimiento").Value = ""
            Else
                dg.Rows(index).Cells("clienteVencimiento").Value = ""
                dg.Rows(index).Cells("proveedorVencimiento").Value = v.ProveedorDeVencimiento.NombreDeProveedor
            End If
            dg.Rows(index).Cells("formaPagoVencimiento").Value = v.FormaPagoDeVencimiento.NombreDePago
            dg.Rows(index).Cells("plazoVencimiento").Value = $"{v.PlazoActualDeVencimiento} de {v.PlazosDeVencimiento}"
            dg.Rows(index).Cells("importeVencimiento").Value = v.ImporteDeVencimiento
            dg.Rows(index).Cells("fechaVencimiento").Value = v.FechaDeVencimiento.ToString("d")
            If v.EstadoDeVencimiento = 0 Then
                dg.Rows(index).Cells("estadoVencimiento").Value = "Pendiente"
            Else
                dg.Rows(index).Cells("estadoVencimiento").Value = "Pagado"
            End If
            dg.Rows(index).Cells("importePendienteVencimiento").Value = v.ImportePendiente.ToString("N2")
        Next
        frmVencimiento.btn_eliminar_vencimiento.Enabled = False
        frmVencimiento.btn_cobrar_vencimiento.Enabled = False
        frmVencimiento.btn_cobro_parcial_vencimiento.Enabled = False
        recalcularBalance()
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
    Private Sub text_changed_txt_busqueda_vencimientos(sender As Object, e As EventArgs)
        Dim textoBusqueda As String = frmVencimiento.txt_busqueda_entidad_vencimiento.Text
        Dim dg As DataGridView = frmVencimiento.dg_vencimientos
        Dim criterioBusqueda As String = "clienteVencimiento"
        If entidadSeleccionada.Equals("P") Then
            criterioBusqueda = "proveedorVencimiento"
        End If

        If textoBusqueda = Nothing Then
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
        recalcularBalance()
    End Sub
    Private Sub click_btn_buscar_vencimiento(sender As Object, e As EventArgs)
        Dim fechaInicio As DateTime = frmVencimiento.dp_fecha_inicio_vencimiento.Value
        Dim fechaFin As DateTime = frmVencimiento.dp_fecha_fin_vencimiento.Value

        If fechaFin < fechaInicio Then
            MessageBox.Show("Fecha incorrecta")
            Return
        End If

        For Each fila As DataGridViewRow In dg.Rows
            If fila.Cells("fechaVencimiento").Value >= fechaInicio And fila.Cells("fechaVencimiento").Value <= fechaFin Then
                dg.CurrentCell = Nothing
                fila.Visible = True
            Else
                dg.CurrentCell = Nothing
                fila.Visible = False
            End If
        Next
        recalcularBalance()
    End Sub
    Private Sub eliminarPago()
        If vencimientoSeleccionado.PlazosDeVencimiento = 1 Then
            vencimientoSeleccionado.deleteVencimiento()
            fillDGVencimientos()
            Exit Sub
        End If
        Dim pagoRestanteEliminado As Double = vencimientoSeleccionado.ImportePendiente
        Dim aRepartir As Double = Math.Round(pagoRestanteEliminado / vencimientoSeleccionado.PlazosDeVencimiento - 1, 2)
        Dim repartido As Double = 0
        Dim contador As Integer = 1

        For Each v As Vencimiento In VariablesGlobales.listaVencimientosAux
            If v.CodigoDeFactura = vencimientoSeleccionado.CodigoDeFactura And Not v.CodigoDeVencimiento = vencimientoSeleccionado.CodigoDeVencimiento Then
                If contador = vencimientoSeleccionado.PlazosDeVencimiento - 1 Then
                    v.ImporteDeVencimiento += vencimientoSeleccionado.ImportePendiente - repartido
                Else
                    v.ImporteDeVencimiento += aRepartir
                End If
                v.PlazoActualDeVencimiento = contador
                v.PlazosDeVencimiento = v.PlazosDeVencimiento - 1
                repartido += aRepartir
                contador += 1
                v.modifyVencimiento()
            End If
        Next
        vencimientoSeleccionado.deleteVencimiento()
        fillDGVencimientos()
    End Sub
    Private Sub recalcularBalance()
        Dim pendienteTotal As Double = 0
        Dim cobradoTotal As Double = 0
        Dim pendiente As Double
        Dim cobrado As Double
        Dim balance As Double

        For Each fila As DataGridViewRow In dg.Rows
            pendiente = fila.Cells("importeVencimiento").Value
            cobrado = fila.Cells("importePendienteVencimiento").Value
            pendienteTotal += pendiente
            cobradoTotal += (pendiente - cobrado)
        Next
        balance = cobradoTotal - pendienteTotal

        frmVencimiento.lbl_pendiente_vencimiento.Text = $"Pendiente: {pendienteTotal}"
        frmVencimiento.lbl_cobrado_vencimiento.Text = $"Cobrado: {cobradoTotal}"
        frmVencimiento.lbl_balance_vencimiento.Text = $"Balance: {balance}"
    End Sub
End Class
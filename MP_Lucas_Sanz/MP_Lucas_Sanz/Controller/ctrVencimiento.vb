Public Class ctrVencimiento
    Private frmVencimiento As frmMain
    Private dg As DataGridView
    Private vencimientoSeleccionado As Vencimiento

    Public Sub New(frmmain As frmMain)
        frmVencimiento = frmmain
        dg = frmVencimiento.dg_vencimientos

        AddHandler frmVencimiento.btn_consultar_vencimiento.Click, AddressOf click_btn_consultar_vencimiento
        AddHandler frmVencimiento.btn_cobrar_vencimiento.Click, AddressOf click_btn_cobrar_vencimiento
        AddHandler frmVencimiento.btn_cobro_parcial_vencimiento.Click, AddressOf click_btn_cobro_parcial_vencimiento
        AddHandler frmVencimiento.btn_eliminar_vencimiento.Click, AddressOf click_btn_eliminar_vencimiento
        AddHandler frmVencimiento.dg_vencimientos.CellClick, AddressOf cell_click_dg_vencimientos
    End Sub

    Private Sub click_btn_consultar_vencimiento(sender As Object, e As EventArgs)
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

    End Sub
    Private Sub fillDGVencimientos()
        dg.Rows.Clear()
        For Each v As Vencimiento In VariablesGlobales.listaVencimientosAux
            Dim index As Integer = dg.Rows.Add()
            dg.Rows(index).Cells("idVencimiento").Value = v.CodigoDeVencimiento
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
    End Sub

End Class
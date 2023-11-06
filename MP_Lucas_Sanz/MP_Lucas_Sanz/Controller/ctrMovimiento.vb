Public Class ctrMovimiento
    Dim frmMovimiento As frmMain
    Dim listaMovimientos As List(Of Movimiento)
    Dim proveedorTemp As Proveedor = New Proveedor()
    Dim clienteTemp As Cliente = New Cliente()
    Dim articuloTemp As Articulo = New Articulo()
    Dim movimientoTemp As Movimiento = New Movimiento()
    Dim ctrInventarioMovimiento As ctrInventario
    Dim cantidadNueva As Integer = Nothing
    Dim currentCell As DataGridViewCell

    Public Sub New(frmMovimientoPasado As frmMain)
        MyBase.New()
        frmMovimiento = frmMovimientoPasado

        AddHandler frmMovimiento.tab_main.SelectedIndexChanged, AddressOf tab_main_SelectedIndexChanged
        AddHandler frmMovimiento.dg_movimientos.CellClick, AddressOf cell_click_dg_movimientos
        AddHandler frmMovimiento.dg_movimientos.CellValueChanged, AddressOf cell_value_changed_dg_movimientos
        AddHandler frmMovimiento.dg_movimientos.CellEndEdit, AddressOf cell_end_edit_dg_movimientos
        AddHandler frmMovimiento.dg_movimientos.CellBeginEdit, AddressOf cell_begin_edit_dg_movimientos
    End Sub
    Public Sub fillDGMovimientos()
        Dim dg As DataGridView = frmMovimiento.dg_movimientos
        dg.Rows.Clear()
        listaMovimientos = listaMovimientosAux
        listaMovimientos = listaMovimientos.OrderBy(Function(m) m.FechaDeMovimiento).ToList()
        For Each m As Movimiento In listaMovimientos
            Dim index As Integer = frmMovimiento.dg_movimientos.Rows.Add()
            articuloTemp = getArticuloPorCodigo(m.ArticuloDeMovimiento)
            With dg.Rows(index)
                .Cells("idMovimiento").Value = m.CodigoDeMovimiento
                .Cells("articuloMovimiento").Value = articuloTemp.NombreDeArticulo
                .Cells("tipoMovimiento").Value = m.TipoDeMovimiento
                .Cells("facturaMovimiento").Value = m.FacturaDeMovimiento
                .Cells("fechaMovimiento").Value = m.FechaDeMovimiento
                .Cells("stockMovimiento").Value = m.StockActualDeMovimiento
                .Cells("cantidadMovimiento").Value = m.CantidadDeMovimiento
            End With
            If m.TipoDeMovimiento.Equals("V") Then
                clienteTemp = VariablesGlobales.getClientePorCodigo(m.ClienteDeMovimiento)
                dg.Rows(index).Cells("usuarioMovimiento").Value = clienteTemp.NombreDelCliente
            ElseIf m.TipoDeMovimiento.Equals("C") Then
                proveedorTemp = VariablesGlobales.getProveedorPorCodigo(m.ProveedorDeMovimiento)
                dg.Rows(index).Cells("usuarioMovimiento").Value = proveedorTemp.NombreDeProveedor
            Else
                dg.Rows(index).Cells("usuarioMovimiento").Value = ""
            End If
        Next
        frmMovimiento.txt_busqueda_inventario.Clear()
        dg.ClearSelection()
    End Sub
    Private Sub cell_click_dg_movimientos(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            movimientoTemp = VariablesGlobales.getMovimientoPorCodigo(frmMovimiento.dg_movimientos.Rows(e.RowIndex).Cells("idMovimiento").Value)
        End If
    End Sub
    Private Sub cell_value_changed_dg_movimientos(sender As Object, e As DataGridViewCellEventArgs)
        If frmMovimiento.dg_movimientos.Columns(e.ColumnIndex).Name = "cantidadMovimiento" AndAlso e.RowIndex >= 0 Then
            cantidadNueva = frmMovimiento.dg_movimientos.Rows(e.RowIndex).Cells("cantidadMovimiento").Value
        End If
    End Sub
    Private Sub cell_begin_edit_dg_movimientos(sender As Object, e As DataGridViewCellCancelEventArgs)
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            currentCell = frmMovimiento.dg_movimientos.CurrentCell

            currentCell.Style.BackColor = Color.Beige
            currentCell.Style.Font = New Font(currentCell.InheritedStyle.Font.FontFamily, 12, FontStyle.Bold)
        End If
    End Sub
    Private Sub cell_end_edit_dg_movimientos(sender As Object, e As DataGridViewCellEventArgs)
        currentCell.Style.BackColor = Color.White
        currentCell.Style.Font = New Font(currentCell.InheritedStyle.Font.FontFamily, 8, FontStyle.Regular)
        If cantidadNueva = Nothing Or cantidadNueva = movimientoTemp.CantidadDeMovimiento Then
            Exit Sub
        End If
        Dim cantidadActual As Integer = movimientoTemp.CantidadDeMovimiento
        Dim cantidadModificar As Integer

        If movimientoTemp.TipoDeMovimiento.Equals("V") Then
            cantidadModificar = cantidadActual - cantidadNueva
        End If
        If movimientoTemp.TipoDeMovimiento.Equals("C") Or movimientoTemp.TipoDeMovimiento.Equals("R") Then
            cantidadModificar = cantidadNueva - cantidadActual
        End If

        managerMovimientoAux.reajustarStock(movimientoTemp, cantidadModificar, cantidadNueva)
        managerInventarioAux.addUnidades(cantidadModificar, movimientoTemp.ArticuloDeMovimiento)
        cantidadNueva = 0
        movimientoTemp = New Movimiento()
        cantidadModificar = 0
        ctrInventarioMovimiento = New ctrInventario(frmMovimiento)
        ctrInventarioMovimiento.fillDGInventario()
    End Sub
    Private Sub tab_main_SelectedIndexChanged(sender As Object, e As EventArgs)
        If frmMovimiento.tab_main.SelectedTab.Text.Equals("INVENTARIO") Then
            fillDGMovimientos()
        End If
    End Sub
End Class
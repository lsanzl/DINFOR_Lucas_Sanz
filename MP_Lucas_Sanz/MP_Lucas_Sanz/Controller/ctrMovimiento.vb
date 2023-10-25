Public Class ctrMovimiento
    Dim frmMovimiento As frmMain
    Dim listaMovimientos As List(Of Movimiento)
    Dim proveedorTemp As Proveedor = New Proveedor()
    Dim clienteTemp As Cliente = New Cliente()
    Dim articuloTemp As Articulo = New Articulo()

    Public Sub New(frmMovimientoPasado As frmMain)
        MyBase.New()
        frmMovimiento = frmMovimientoPasado

        AddHandler frmMovimiento.tab_main.SelectedIndexChanged, AddressOf tab_main_SelectedIndexChanged
    End Sub
    Public Sub fillDGMovimientos()
        listaMovimientos = New List(Of Movimiento)
        listaMovimientos = managerMovimientoAux.getMovimientos()
        frmMovimiento.dg_movimientos.Rows.Clear()

        For Each item As Movimiento In listaMovimientos
            Dim index As Integer = frmMovimiento.dg_movimientos.Rows.Add()
            articuloTemp = getArticuloPorCodigo(item.ArticuloDeMovimiento)

            frmMovimiento.dg_movimientos.Rows(index).Cells("idMovimiento").Value = item.CodigoDeMovimiento
            If item.TipoDeMovimiento.Equals("V") Then
                clienteTemp = VariablesGlobales.getClientePorCodigo(item.ClienteDeMovimiento)
                frmMovimiento.dg_movimientos.Rows(index).Cells("usuarioMovimiento").Value = clienteTemp.NombreDelCliente
            ElseIf item.TipoDeMovimiento.Equals("C") Then
                proveedorTemp = VariablesGlobales.getProveedorPorCodigo(item.ProveedorDeMovimiento)
                frmMovimiento.dg_movimientos.Rows(index).Cells("usuarioMovimiento").Value = item.ProveedorDeMovimiento
            Else
                frmMovimiento.dg_movimientos.Rows(index).Cells("usuarioMovimiento").Value = ""
            End If
            frmMovimiento.dg_movimientos.Rows(index).Cells("articuloMovimiento").Value = articuloTemp.NombreDeArticulo
            frmMovimiento.dg_movimientos.Rows(index).Cells("tipoMovimiento").Value = item.TipoDeMovimiento
            frmMovimiento.dg_movimientos.Rows(index).Cells("facturaMovimiento").Value = item.FacturaDeMovimiento
            frmMovimiento.dg_movimientos.Rows(index).Cells("fechaMovimiento").Value = item.FechaDeMovimiento
            frmMovimiento.dg_movimientos.Rows(index).Cells("stockMovimiento").Value = item.StockActualDeMovimiento
        Next
    End Sub
    Private Sub tab_main_SelectedIndexChanged(sender As Object, e As EventArgs)
        If frmMovimiento.tab_main.SelectedTab.Text.Equals("INVENTARIO") Then
            fillDGMovimientos()
        End If
    End Sub
End Class
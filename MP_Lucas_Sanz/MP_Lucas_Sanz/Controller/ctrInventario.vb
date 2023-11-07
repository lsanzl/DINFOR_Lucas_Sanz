Imports System.Net
Imports System.Net.Mail
Imports MP_Lucas_Sanz.VariablesGlobales

Public Class ctrInventario
    Dim frmInventario As frmMain
    Dim ctrMovimiento As ctrMovimiento
    Dim inventarioTemp As Inventario
    Dim listaInventario As List(Of Inventario) = New List(Of Inventario)
    Dim cantidadNueva As Integer

    Public Sub New(frmPasado As frmMain)
        MyBase.New()
        frmInventario = frmPasado

        AddHandler frmInventario.btn_añadir_unidades.Click, AddressOf click_btn_añadir_unidades
        AddHandler frmInventario.btn_restar_unidades.Click, AddressOf click_btn_restar_unidades
        AddHandler frmInventario.btn_añadir_articulo_inventario.Click, AddressOf click_btn_añadir_articulo_inventario
        AddHandler frmInventario.btn_eliminar_articulo_inventario.Click, AddressOf click_btn_eliminar_articulo_inventario
        AddHandler frmInventario.txt_busqueda_inventario.TextChanged, AddressOf text_changed_txt_busqueda_inventario
        AddHandler frmInventario.tab_main.SelectedIndexChanged, AddressOf tab_main_SelectedIndexChanged
        AddHandler frmInventario.dg_inventario.CellClick, AddressOf click_cell_dg_inventario
        AddHandler frmInventario.dg_inventario.CellEndEdit, AddressOf cell_end_edit_dg_inventarios
    End Sub

    Public Sub fillDGInventario()
        frmInventario.dg_inventario.ClearSelection()
        frmInventario.btn_añadir_unidades.Enabled = False
        frmInventario.btn_restar_unidades.Enabled = False
        frmInventario.btn_eliminar_articulo_inventario.Enabled = False

        frmUnidadesInventario.btn_confirmar_unidades.Text = "Confirmar"
        frmUnidadesInventario.txt_unidades_inventario.Clear()
        frmInventario.dg_inventario.Rows.Clear()

        Dim dg As DataGridView = frmInventario.dg_inventario
        listaInventario = listaInventariosAux
        For Each i As Inventario In listaInventario
            Dim index As Integer = dg.Rows.Add()
            With dg.Rows(index)
                .Cells("idInventario").Value = i.CodigoDeInventario
                .Cells("nombreArticulo").Value = i.ArticuloDeInventario.NombreDeArticulo
                .Cells("stockActual").Value = i.UnidadesDisponibles
            End With
        Next
        frmInventario.txt_busqueda_inventario.Clear()
        dg.ClearSelection()
    End Sub
    Private Sub cell_end_edit_dg_inventarios(sender As Object, e As DataGridViewCellEventArgs)
        If frmInventario.dg_inventario.Columns(e.ColumnIndex).Name = "stockActual" AndAlso e.RowIndex >= 0 Then
            cantidadNueva = frmInventario.dg_inventario.Rows(e.RowIndex).Cells("stockActual").Value
            Dim cantidadVariar As Integer = cantidadNueva - inventarioTemp.UnidadesDisponibles
            managerInventarioAux.setUnidades(cantidadNueva, inventarioTemp.ArticuloDeInventario.CodigoDeArticulo)
            reajusteStock(cantidadVariar, inventarioTemp)
        End If
    End Sub
    Private Sub reajusteStock(cantidad As Integer, inventario As Inventario)
        Dim nuevoMovimiento As Movimiento = New Movimiento("R", "", 0, DateTime.Now.ToString("dd/MM/yyyy"), inventario.ArticuloDeInventario.CodigoDeArticulo, inventario.UnidadesDisponibles + cantidad, cantidad)
        nuevoMovimiento.addMovimiento()
        ctrMovimiento = New ctrMovimiento(frmInventario)
        ctrMovimiento.fillDGMovimientos()
    End Sub
    Private Sub click_btn_añadir_unidades(sender As Object, e As EventArgs)
        frmUnidadesInventario.Text = $"Añadir unidades de {inventarioTemp.ArticuloDeInventario.NombreDeArticulo}"
        frmUnidadesInventario.btn_confirmar_unidades.Text = "Añadir"
        frmUnidadesInventario.ShowDialog()
        If frmUnidadesInventario.confirmado Then
            inventarioTemp.addUnidades(frmUnidadesInventario.cantidadVariar)
            reajusteStock(frmUnidadesInventario.cantidadVariar, inventarioTemp)
        End If
        fillDGInventario()
    End Sub
    Private Sub click_btn_restar_unidades(sender As Object, e As EventArgs)
        frmUnidadesInventario.Text = $"Restar unidades de {inventarioTemp.ArticuloDeInventario.NombreDeArticulo}"
        frmUnidadesInventario.btn_confirmar_unidades.Text = "Restar"
        frmUnidadesInventario.ShowDialog()
        If frmUnidadesInventario.confirmado Then
            inventarioTemp.deleteUnidades(frmUnidadesInventario.cantidadVariar)
            reajusteStock(-frmUnidadesInventario.cantidadVariar, inventarioTemp)
        End If
        fillDGInventario()
    End Sub
    Private Sub click_btn_añadir_articulo_inventario(sender As Object, e As EventArgs)
        frmAñadirArticuloInventario.ShowDialog()
        fillDGInventario()
    End Sub
    Private Sub click_btn_eliminar_articulo_inventario(sender As Object, e As EventArgs)
        inventarioTemp.deleteInventario()
        fillDGInventario()
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
    Private Sub text_changed_txt_busqueda_inventario(sender As Object, e As EventArgs)
        Dim textoBusqueda As String = frmInventario.txt_busqueda_inventario.Text
        Dim dg_inv As DataGridView = frmInventario.dg_inventario
        Dim dg_mov As DataGridView = frmInventario.dg_movimientos

        If frmInventario.txt_busqueda_inventario.Text = Nothing Then
            For Each fila As DataGridViewRow In dg_inv.Rows
                fila.Visible = True
            Next
            For Each fila As DataGridViewRow In dg_mov.Rows
                fila.Visible = True
            Next
            Exit Sub
        End If
        For Each fila As DataGridViewRow In dg_inv.Rows
            If lookForText(fila.Cells("nombreArticulo").Value.ToString().Trim, textoBusqueda.Trim) Then
                dg_inv.CurrentCell = Nothing
                fila.Visible = True
            Else
                dg_inv.CurrentCell = Nothing
                fila.Visible = False
            End If
        Next
        For Each fila As DataGridViewRow In dg_mov.Rows
            If lookForText(fila.Cells("articuloMovimiento").Value.ToString().Trim, textoBusqueda.Trim) Then
                dg_inv.CurrentCell = Nothing
                fila.Visible = True
            Else
                dg_inv.CurrentCell = Nothing
                fila.Visible = False
            End If
        Next
    End Sub
    Private Sub click_cell_dg_inventario(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            frmInventario.btn_añadir_unidades.Enabled = True
            frmInventario.btn_restar_unidades.Enabled = True
            frmInventario.btn_eliminar_articulo_inventario.Enabled = True
            inventarioTemp = getInventarioPorCodigo(frmInventario.dg_inventario.Rows(e.RowIndex).Cells("idInventario").Value)
        End If
    End Sub
    Private Sub tab_main_SelectedIndexChanged(sender As Object, e As EventArgs)
        If frmInventario.tab_main.SelectedTab.Text.Equals("INVENTARIO") Then
            fillDGInventario()
        End If
    End Sub
End Class
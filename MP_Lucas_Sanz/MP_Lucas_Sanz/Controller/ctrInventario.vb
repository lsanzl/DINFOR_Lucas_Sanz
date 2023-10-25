Imports System.Net
Imports System.Net.Mail

Public Class ctrInventario
    Dim frmInventario As frmMain
    Dim inventarioTemp As Inventario
    Dim listaInventario As List(Of Inventario) = New List(Of Inventario)

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
    End Sub

    Private Sub fillDGInventario()
        frmInventario.btn_añadir_unidades.Enabled = False
        frmInventario.btn_restar_unidades.Enabled = False
        frmInventario.btn_eliminar_articulo_inventario.Enabled = False

        frmUnidadesInventario.btn_confirmar_unidades.Text = "Confirmar"
        frmUnidadesInventario.txt_unidades_inventario.Clear()
        frmInventario.dg_inventario.Rows.Clear()

        listaInventario = New List(Of Inventario)
        listaInventario = inventarioAux.getInventario()
        For Each item As Inventario In listaInventario
            Dim index As Integer = frmInventario.dg_inventario.Rows.Add()
            frmInventario.dg_inventario.Rows(index).Cells("idAlmacen").Value = item.CodigoDeInventario
            frmInventario.dg_inventario.Rows(index).Cells("nombreArticulo").Value = item.ArticuloDeInventario.NombreDeArticulo
            frmInventario.dg_inventario.Rows(index).Cells("stockActual").Value = item.UnidadesDisponibles
        Next
        frmInventario.dg_inventario.ClearSelection()
    End Sub

    Private Sub click_btn_añadir_unidades(sender As Object, e As EventArgs)
        frmUnidadesInventario.Text = $"Añadir unidades de {inventarioTemp.ArticuloDeInventario.NombreDeArticulo}"
        frmUnidadesInventario.btn_confirmar_unidades.Text = "Añadir"
        frmUnidadesInventario.ShowDialog()
        If frmUnidadesInventario.confirmado Then
            inventarioTemp.addUnidades(frmUnidadesInventario.cantidadVariar)
        End If
        fillDGInventario()
    End Sub
    Private Sub click_btn_restar_unidades(sender As Object, e As EventArgs)
        frmUnidadesInventario.Text = $"Restar unidades de {inventarioTemp.ArticuloDeInventario.NombreDeArticulo}"
        frmUnidadesInventario.btn_confirmar_unidades.Text = "Restar"
        frmUnidadesInventario.ShowDialog()
        If frmUnidadesInventario.confirmado Then
            inventarioTemp.deleteUnidades(frmUnidadesInventario.cantidadVariar)
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
        resultado = InStr(1, textoOrigen, textoBusqueda)
        If resultado > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub text_changed_txt_busqueda_inventario(sender As Object, e As EventArgs)
        Dim textoBusqueda As String = frmInventario.txt_busqueda_inventario.Text
        Dim dg As DataGridView = frmInventario.dg_inventario

        If frmInventario.txt_busqueda_inventario.Text = Nothing Then   'SI BUSQUEDA VACIA -> TODAS LAS FILAS NORMALES'
            For Each fila As DataGridViewRow In dg.Rows
                fila.Visible = True
            Next
            Exit Sub
        End If

        For Each fila As DataGridViewRow In dg.Rows
            If lookForText(fila.Cells("NombreDeArticuloDataGridViewTextBoxColumn1").Value.ToString().Trim, textoBusqueda.Trim) Then
                dg.CurrentCell = Nothing
                fila.Visible = True
            Else
                dg.CurrentCell = Nothing
                fila.Visible = False
            End If
        Next
    End Sub

    Private Sub click_cell_dg_inventario(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            frmInventario.btn_añadir_unidades.Enabled = True
            frmInventario.btn_restar_unidades.Enabled = True
            frmInventario.btn_eliminar_articulo_inventario.Enabled = True
            Dim codigoInventario As Integer = frmInventario.dg_inventario.Rows(e.RowIndex).Cells("idAlmacen").Value
            inventarioTemp = managerInventarioAux.getInventario(codigoInventario)
        End If
    End Sub
    Private Sub tab_main_SelectedIndexChanged(sender As Object, e As EventArgs)
        If frmInventario.tab_main.SelectedTab.Text.Equals("INVENTARIO") Then
            fillDGInventario()
        End If
    End Sub
End Class
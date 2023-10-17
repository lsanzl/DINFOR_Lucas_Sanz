Public Class frmBusquedaVenta
    Dim criterioBusqueda As String = "nombre"
    Public Property codigoSeleccionado As String

    Private Sub frmBusquedaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdb_nombre.Checked = True
    End Sub
    Public Sub New(clase As Object)
        InitializeComponent()

        dg_resultados_busqueda_ventas.Columns.Add("nombre", "Nombre")
        dg_resultados_busqueda_ventas.Columns.Add("codigo", "Código")

        If TypeOf clase Is Cliente Then
            Dim listaClientes As List(Of Cliente) = clienteAux.getClientes()
            Dim contador As Integer = 0
            For Each cliente As Cliente In listaClientes
                dg_resultados_busqueda_ventas.Rows.Add()

                dg_resultados_busqueda_ventas.Rows(contador).Cells(0).Value = cliente.NombreDelCliente
                dg_resultados_busqueda_ventas.Rows(contador).Cells(1).Value = cliente.CodigoDelCliente

                contador += 1
            Next
        End If
        If TypeOf clase Is Articulo Then
            Dim listaArticulos As List(Of Articulo) = articuloAux.getArticulos()
            Dim contador As Integer = 0
            For Each articulo As Articulo In listaArticulos
                dg_resultados_busqueda_ventas.Rows.Add()

                dg_resultados_busqueda_ventas.Rows(contador).Cells(0).Value = articulo.NombreDeArticulo
                dg_resultados_busqueda_ventas.Rows(contador).Cells(1).Value = articulo.CodigoDeArticulo

                contador += 1
            Next
        End If
    End Sub

    Private Sub txtchanged_txt_busqueda(sender As Object, e As EventArgs) Handles txt_busqueda_generica_ventas.TextChanged
        Dim textoBusqueda As String = txt_busqueda_generica_ventas.Text
        Dim dg As DataGridView = dg_resultados_busqueda_ventas

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

    Private Sub checked_changed_grupobox(sender As Object, e As EventArgs) Handles rdb_nombre.CheckedChanged, rdb_codigo.CheckedChanged
        If rdb_nombre.Checked Then
            criterioBusqueda = "nombre"
        Else
            criterioBusqueda = "codigo"
        End If
    End Sub

    Private Sub double_click_cell_dg_resultados_busqueda(sender As Object, e As DataGridViewCellEventArgs) Handles dg_resultados_busqueda_ventas.CellDoubleClick
        codigoSeleccionado = dg_resultados_busqueda_ventas.Rows(e.RowIndex).Cells(1).Value.ToString()
        Close()
    End Sub
End Class
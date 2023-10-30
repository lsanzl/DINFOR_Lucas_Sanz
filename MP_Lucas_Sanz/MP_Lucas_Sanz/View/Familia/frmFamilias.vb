Public Class frmFamilias
    Public familiaSeleccionada As Integer = Nothing
    Public impuestoSeleccionado As Integer = Nothing
    Dim familiaTemp As Familia = New Familia()
    Dim impuestoTemp As Impuesto = New Impuesto()
    Dim listaFamilias As List(Of Familia) = New List(Of Familia)
    Dim listaImpuestos As List(Of Impuesto) = New List(Of Impuesto)

    Private Sub frmFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_modificar_familia.Enabled = False
        btn_eliminar_familia.Enabled = False
        btn_seleccionar_familia.Enabled = False
        dg_familias.ClearSelection()
        fillDGFamilias()
    End Sub
    Private Sub fillDGFamilias()
        dg_familias.Columns.Clear()
        dg_familias.Rows.Clear()
        Dim columna As New DataGridViewTextBoxColumn()
        columna.HeaderText = "ID"
        columna.Name = "idGenerico"
        columna.Visible = False
        dg_familias.Columns.Add(columna)
        If Me.Text.Equals("Familias") Then
            btn_modificar_familia.Visible = True
            listaFamilias = managerFamiliaAux.getFamilias()

            columna = New DataGridViewTextBoxColumn()
            columna.HeaderText = "Familias"
            columna.Name = "nombreFamilia"
            dg_familias.Columns.Add(columna)
            dg_familias.Columns("nombreFamilia").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            For Each fam As Familia In listaFamilias
                Dim index As Integer = dg_familias.Rows.Add()
                dg_familias.Rows(index).Cells("idGenerico").Value = fam.CodigoDeFamilia
                dg_familias.Rows(index).Cells("nombreFamilia").Value = fam.NombreDeFamilia
            Next
        Else
            btn_modificar_familia.Visible = False
            listaImpuestos = managerImpuestoAux.getImpuestos()
            columna = New DataGridViewTextBoxColumn()
            columna.HeaderText = "Impuestos"
            columna.Name = "cantidadImpuesto"
            dg_familias.Columns.Add(columna)
            dg_familias.Columns("cantidadImpuesto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            For Each imp As Impuesto In listaImpuestos
                Dim index As Integer = dg_familias.Rows.Add()
                dg_familias.Rows(index).Cells("idGenerico").Value = imp.CodigoDeImpuesto
                dg_familias.Rows(index).Cells("cantidadImpuesto").Value = imp.CantidadImpuesto
            Next
        End If

        btn_modificar_familia.Enabled = False
        btn_eliminar_familia.Enabled = False
        btn_seleccionar_familia.Enabled = False
        dg_familias.ClearSelection()
    End Sub

    Private Sub click_cell_dg_familias(sender As Object, e As DataGridViewCellEventArgs) Handles dg_familias.CellClick
        If e.RowIndex >= 0 Then
            btn_modificar_familia.Enabled = True
            btn_eliminar_familia.Enabled = True
            btn_seleccionar_familia.Enabled = True
            Dim codigoSeleccionado As Integer = CInt(dg_familias.Rows(e.RowIndex).Cells("idGenerico").Value)
            If Me.Text.Equals("Familias") Then
                listaFamilias = managerFamiliaAux.getFamilias()
                familiaTemp = listaFamilias.Find(Function(f) f.CodigoDeFamilia = codigoSeleccionado)
            Else
                listaImpuestos = managerImpuestoAux.getImpuestos()
                impuestoTemp = listaImpuestos.Find(Function(i) i.CodigoDeImpuesto = codigoSeleccionado)
            End If
        End If
    End Sub

    Private Sub click_btn_seleccionar_familia(sender As Object, e As EventArgs) Handles btn_seleccionar_familia.Click
        If Me.Text.Equals("Familias") Then
            familiaSeleccionada = familiaTemp.CodigoDeFamilia
        Else
            impuestoSeleccionado = impuestoTemp.CantidadImpuesto
        End If
        dg_familias.ClearSelection()
        Close()
    End Sub
    Private Sub click_btn_añadir_familia(sender As Object, e As EventArgs) Handles btn_añadir_familia.Click
        frmNuevaFamilia.btn_confirmar_familia.Text = "Confirmar"
        If Me.Text.Equals("Familias") Then
            frmNuevaFamilia.Text = "Nueva familia"
        Else
            frmNuevaFamilia.Text = "Nuevo impuesto"
        End If
        frmNuevaFamilia.ShowDialog()
        fillDGFamilias()
    End Sub
    Private Sub click_btn_modificar_familia(sender As Object, e As EventArgs) Handles btn_modificar_familia.Click
        frmNuevaFamilia.Text = "Modificar Familia"
        frmNuevaFamilia.btn_confirmar_familia.Text = "Modificar"
        frmNuevaFamilia.txt_codigo_familia.Text = familiaTemp.CodigoDeFamilia
        frmNuevaFamilia.txt_codigo_familia.Enabled = False
        frmNuevaFamilia.txt_nombre_familia.Text = familiaTemp.NombreDeFamilia
        frmNuevaFamilia.ShowDialog()
        fillDGFamilias()
    End Sub
    Private Sub click_btn_eliminar_familia(sender As Object, e As EventArgs) Handles btn_eliminar_familia.Click
        If Me.Text.Equals("Familias") Then
            familiaTemp.deleteFamilia()
        Else
            impuestoTemp.deleteImpuesto()
        End If
        fillDGFamilias()
    End Sub

    Private Sub double_click_dg_familias(sender As Object, e As EventArgs) Handles dg_familias.DoubleClick
        If Me.Text.Equals("Familias") Then
            familiaSeleccionada = familiaTemp.CodigoDeFamilia
        Else
            impuestoSeleccionado = impuestoTemp.CodigoDeImpuesto
        End If
        dg_familias.ClearSelection()
        Close()
    End Sub
End Class
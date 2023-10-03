Public Class frmSeleccionEmpresa
    Dim listaEmpresas As List(Of Empresa)
    Dim filaSeleccionada As Integer
    Dim empresaSeleccionada As Empresa
    Dim empresaAux As Empresa = New Empresa("", "")

    Private Sub frmSeleccionEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillDataGrid()
    End Sub

    Public Sub fillDataGrid()
        dg_empresas.DataSource = Nothing
        dg_empresas.CurrentCell = Nothing
        empresaSeleccionada = Nothing
        dg_empresas.Rows.Clear()
        listaEmpresas = empresaAux.getEmpresas()
        dg_empresas.DataSource = listaEmpresas
    End Sub

    Private Sub click_btn_seleccionar(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        VariablesGlobales.getEmpresaSeleccionadaDB(empresaSeleccionada.NombreEmpresa)
        Me.Close()
    End Sub

    Private Sub click_cell_dg_empresas(sender As Object, e As DataGridViewCellEventArgs) Handles dg_empresas.CellClick
        empresaSeleccionada = dg_empresas.Rows(e.RowIndex).DataBoundItem
    End Sub

    Private Sub click_btn_modificar(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If empresaSeleccionada Is Nothing Then
            MessageBox.Show("Seleccione primero una empresa a modificar")
            Return
        End If
        frmNuevoNombreEmpresa.Text = "Modificación nombre de empresa"
        frmNuevoNombreEmpresa.ShowDialog()

        If frmNuevoNombreEmpresa.estaAceptado() Then
            empresaSeleccionada.nombreAntiguo = empresaSeleccionada.NombreEmpresa
            empresaSeleccionada.NombreEmpresa = frmNuevoNombreEmpresa.getNuevoNombre()
            empresaSeleccionada.modifyEmpresa()
            fillDataGrid()
        End If
    End Sub

    Private Sub click_btn_eliminar_empresa(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If empresaSeleccionada Is Nothing Then
            MessageBox.Show("Seleccione empresa primero")
            Return
        End If
        empresaSeleccionada.deleteEmpresa()
        fillDataGrid()
    End Sub

    Private Sub click_btn_añadir(sender As Object, e As EventArgs) Handles btn_añadir.Click
        frmNuevaEmpresa.Text = "Introduzca nombre para nueva empresa"
        frmNuevaEmpresa.ShowDialog()
        fillDataGrid()
    End Sub
End Class
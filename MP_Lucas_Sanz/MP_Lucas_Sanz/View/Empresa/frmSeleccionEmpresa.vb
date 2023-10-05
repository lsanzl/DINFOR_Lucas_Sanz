Public Class frmSeleccionEmpresa
    Dim listaEmpresas As List(Of Empresa)
    Dim filaSeleccionada As Integer
    Dim empresaSeleccionada As Empresa
    Dim empresaAux As Empresa = New Empresa()

    Private Sub frmSeleccionEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AjustarFormulario(Me)
        PosicionarCentro(Me)
        fillDataGrid()
    End Sub

    Public Sub fillDataGrid()
        dg_empresas.DataSource = Nothing
        empresaSeleccionada = Nothing
        dg_empresas.Rows.Clear()
        listaEmpresas = empresaAux.getEmpresas()
        dg_empresas.DataSource = listaEmpresas

        btn_seleccionar.Enabled = False
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False

        dg_empresas.ClearSelection()
    End Sub

    Private Sub click_btn_seleccionar(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        If empresaSeleccionada Is Nothing Then
            MessageBox.Show("Seleccione primero una empresa")
            Return
        End If
        VariablesGlobales.setEmpresaSeleccionadaDB(empresaSeleccionada.NombreEmpresa)
        managerEmpAux.selectEmpresa()
        Me.Close()
    End Sub

    Private Sub click_cell_dg_empresas(sender As Object, e As DataGridViewCellEventArgs) Handles dg_empresas.CellClick
        empresaSeleccionada = dg_empresas.Rows(e.RowIndex).DataBoundItem
        btn_modificar.Enabled = True
        btn_eliminar.Enabled = True
        btn_seleccionar.Enabled = True
    End Sub

    Private Sub double_click_cell_dg_empresa(sender As Object, e As DataGridViewCellEventArgs) Handles dg_empresas.CellDoubleClick
        empresaSeleccionada = dg_empresas.Rows(e.RowIndex).DataBoundItem
        VariablesGlobales.setEmpresaSeleccionadaDB(empresaSeleccionada.NombreEmpresa)
        managerEmpAux.selectEmpresa()
        VariablesGlobales.setSeleccionadaEmpresa(True)
        Me.Close()
    End Sub

    Private Sub click_btn_modificar(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If empresaSeleccionada Is Nothing Then
            MessageBox.Show("Seleccione primero una empresa a modificar")
            Return
        End If
        frmNuevoNombreEmpresa.Text = "Modificación nombre de empresa"
        frmNuevoNombreEmpresa.txt_nuevo_nombre_empresa.Text = empresaSeleccionada.NombreEmpresa
        frmNuevoNombreEmpresa.ShowDialog()
        frmNuevoNombreEmpresa.txt_nuevo_nombre_empresa.Clear()

        If frmNuevoNombreEmpresa.estaAceptado() Then
            empresaSeleccionada.setNombreAntiguo(empresaSeleccionada.NombreEmpresa)
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

    Private Sub frmSeleccionEmpresa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If getEmpresaSeleccionada() = Nothing Then
            Application.Exit()
        Else
            VariablesGlobales.setSeleccionadaEmpresa(True)
        End If
    End Sub
End Class
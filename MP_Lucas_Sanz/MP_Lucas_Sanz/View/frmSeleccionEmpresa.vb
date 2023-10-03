Public Class frmSeleccionEmpresa
    Dim managerEmp As ManagerEmpresas = New ManagerEmpresas()
    Dim listaEmpresas As List(Of Empresa)

    Private Sub frmSeleccionEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillDataGrid()
    End Sub

    Public Sub fillDataGrid()
        listaEmpresas = managerEmp.getEmpresas()

        For Each Empresa In listaEmpresas
            Dim n = dg_empresas.Rows.Add()
            dg_empresas.Rows(n).Cells(0).Value = Empresa.getNombreEmp()
            dg_empresas.Rows(n).Cells(1).Value = Empresa.getCodigoEmp()
        Next
    End Sub
End Class
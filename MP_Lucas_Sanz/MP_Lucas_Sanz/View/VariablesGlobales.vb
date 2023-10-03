Module VariablesGlobales
    Public connectionDB As ConnectionDB = New ConnectionDB
    Private empresaSeleccionadaDB As String = ""

    Public Sub getEmpresaSeleccionadaDB(nombre As String)
        empresaSeleccionadaDB = nombre
    End Sub
End Module
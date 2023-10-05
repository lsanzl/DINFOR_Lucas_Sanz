Public Class frmNuevoNombreEmpresa
    Dim nuevoNombre As String
    Dim aceptado As Boolean = False

    Private Sub frmNuevoNombreEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PosicionarCentro(Me)
        aceptado = False
    End Sub

    Private Sub click_btn_confirmar_nuevo_nombre(sender As Object, e As EventArgs) Handles btn_confirmar_nuevo_nombre.Click
        If Not VariablesGlobales.empresaAux.checkNombre(txt_nuevo_nombre_empresa.Text) Then
            MessageBox.Show("Introduzca nombre válido (Emp + número)")
            Return
        End If
        If Not VariablesGlobales.managerEmpAux.checkEmpresa(txt_nuevo_nombre_empresa.Text) Then
            MessageBox.Show("Esa empresa ya existe")
            Return
        End If
        nuevoNombre = txt_nuevo_nombre_empresa.Text
        aceptado = True
        Me.Close()
    End Sub

    Public Function estaAceptado() As Boolean
        Return aceptado
    End Function
    Public Function getNuevoNombre() As String
        Return nuevoNombre
    End Function
End Class
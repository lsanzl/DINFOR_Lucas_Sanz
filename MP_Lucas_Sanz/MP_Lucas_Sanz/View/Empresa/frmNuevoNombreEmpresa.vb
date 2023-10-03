Public Class frmNuevoNombreEmpresa
    Dim nuevoNombre As String
    Dim aceptado As Boolean = False

    Private Sub click_btn_confirmar_nuevo_nombre(sender As Object, e As EventArgs) Handles btn_confirmar_nuevo_nombre.Click
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
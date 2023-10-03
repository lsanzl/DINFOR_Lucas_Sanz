Imports System.Data.SqlClient

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Marco Polo - Versión Lucas Sanz"
        frmSeleccionEmpresa.Text = "Seleccione empresa con la que desea trabajar"
        frmSeleccionEmpresa.ShowDialog()
    End Sub
End Class
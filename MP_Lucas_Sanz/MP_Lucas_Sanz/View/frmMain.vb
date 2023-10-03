Imports System.Data.SqlClient

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSeleccionEmpresa.ShowDialog()
    End Sub
End Class
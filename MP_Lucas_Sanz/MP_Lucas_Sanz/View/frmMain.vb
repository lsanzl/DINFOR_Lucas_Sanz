﻿Imports System.Data.SqlClient

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AjustarFormulario(Me)
        PosicionarCentro(Me)
        Me.Text = "Marco Polo - Versión Lucas Sanz"
        frmSeleccionEmpresa.Text = "Seleccione empresa con la que desea trabajar"
        frmSeleccionEmpresa.ShowDialog()
        Dim ctrBancoController As ctrBanco = New ctrBanco(Me)
        Dim ctrFormaPagoController As ctrFormasPago = New ctrFormasPago(Me)
    End Sub
End Class
Imports System.Data.SqlClient

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AjustarFormulario(Me)
        PosicionarCentro(Me)
        Me.Text = "Marco Polo - Versión Lucas Sanz"
        frmSeleccionEmpresa.Text = "Seleccione empresa con la que desea trabajar"
        frmSeleccionEmpresa.ShowDialog()
        Dim ctrBancoController As ctrBanco = New ctrBanco(Me)
        Dim ctrFormaPagoController As ctrFormaPago = New ctrFormaPago(Me)
        Dim ctrGrupoController As ctrGrupo = New ctrGrupo(Me)
        Dim ctrCliente As ctrCliente = New ctrCliente(Me)
        Dim ctrProveedor As ctrProveedor = New ctrProveedor(Me)
        Dim ctrArticulo As ctrArticulo = New ctrArticulo(Me)
        Dim ctrInventario As ctrInventario = New ctrInventario(Me)
        Dim ctrMenu As ctrMenu = New ctrMenu(Me)
        Dim ctrConfiguraciones As ctrConfiguraciones = New ctrConfiguraciones(Me)
        Dim ctrMovimiento As ctrMovimiento = New ctrMovimiento(Me)
    End Sub
End Class
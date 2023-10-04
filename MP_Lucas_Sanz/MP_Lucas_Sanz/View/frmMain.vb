Imports System.Data.SqlClient

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AjustarFormulario(Me)
        PosicionarCentro(Me)
        Me.Text = "Marco Polo - Versión Lucas Sanz"
        frmSeleccionEmpresa.Text = "Seleccione empresa con la que desea trabajar"
        frmSeleccionEmpresa.ShowDialog()
    End Sub

    Private Sub tab_main_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tab_main.SelectedIndexChanged
        If tab_main.SelectedIndex = 1 Then
            ctrBancoAux.fillDGBancos()
        End If
    End Sub



    ' ----------- PESTAÑA BANCOS Y PAGOS --------------
    Private Sub click_btn_añadir_banco(sender As Object, e As EventArgs) Handles btn_añadir_banco.Click
        ctrBancoAux.addBanco()
    End Sub

    Private Sub click_cell_dg_bancos(sender As Object, e As DataGridViewCellEventArgs) Handles dg_bancos.CellClick
        ctrBancoAux.procesoSeleccionBanco(e.RowIndex)
    End Sub

    Private Sub click_btn_modificar_banco(sender As Object, e As EventArgs) Handles btn_modificar_banco.Click
        ctrBancoAux.modifyBanco()
    End Sub

    Private Sub click_btn_eliminar_banco(sender As Object, e As EventArgs) Handles btn_eliminar_banco.Click
        ctrBancoAux.deleteBanco()
    End Sub
End Class
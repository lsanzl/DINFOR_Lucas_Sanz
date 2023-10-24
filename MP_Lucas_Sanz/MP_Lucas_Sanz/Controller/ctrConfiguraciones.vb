Imports System.Data.SqlClient

Public Class ctrConfiguraciones
    Dim frmConfiguraciones As frmMain

    Public Sub New(frmPasado As frmMain)
        MyBase.New()
        frmConfiguraciones = frmPasado

        AddHandler frmConfiguraciones.btn_actualizacion_campo_extra.Click, AddressOf click_btn_actualizacion_campo_extra
        AddHandler frmConfiguraciones.btn_actualizacion_añadir_tabla.Click, AddressOf click_btn_actualizacion_añadir_tabla
        AddHandler frmConfiguraciones.btn_actualizacion_añadir_fk.Click, AddressOf click_btn_actualizacion_añadir_fk
    End Sub

    Private Sub click_btn_actualizacion_campo_extra(sender As Object, e As EventArgs)
        managerConfiguracionAux.actualizarCampoTabla()
    End Sub
    Private Sub click_btn_actualizacion_añadir_tabla(sender As Object, e As EventArgs)
        managerConfiguracionAux.actualizarTablaNueva()
    End Sub
    Private Sub click_btn_actualizacion_añadir_fk(sender As Object, e As EventArgs)
        managerConfiguracionAux.actualizarFKNueva()
    End Sub
End Class
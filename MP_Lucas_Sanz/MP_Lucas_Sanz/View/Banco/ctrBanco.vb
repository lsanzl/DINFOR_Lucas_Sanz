Public Class ctrBanco
    Dim dg_bancos As DataGridView = frmMain.dg_bancos
    Dim listaBancos As List(Of Banco) = New List(Of Banco)
    Dim bancoSeleccionado As Boolean = False
    Dim bancoTemp As Banco

    Public Sub fillDGBancos()
        bancoSeleccionado = False
        frmMain.btn_modificar_banco.Enabled = False
        frmMain.btn_eliminar_banco.Enabled = False
        frmNuevoBanco.btn_confirmar_nuevo_banco.Text = "Confirmar"
        dg_bancos.DataSource = Nothing
        dg_bancos.Rows.Clear()
        listaBancos = bancoAux.getBancos()
        dg_bancos.DataSource = listaBancos
    End Sub

    Public Sub procesoSeleccionBanco(fila As Integer)
        bancoSeleccionado = True
        frmMain.btn_modificar_banco.Enabled = True
        frmMain.btn_eliminar_banco.Enabled = True
        bancoTemp = dg_bancos.Rows(fila).DataBoundItem
    End Sub

    Public Sub addBanco()
        frmNuevoBanco.Text = "Creación nuevo banco"
        frmNuevoBanco.ShowDialog()
        fillDGBancos()
    End Sub

    Public Sub deleteBanco()
        bancoTemp.deleteBanco()
        fillDGBancos()
    End Sub

    Public Sub modifyBanco()
        frmNuevoBanco.Text = "Modificación de banco"
        frmNuevoBanco.txt_codigo_banco.Text = bancoTemp.CodigoDeBanco
        frmNuevoBanco.txt_codigo_banco.Enabled = False
        frmNuevoBanco.txt_nombre_banco.Text = bancoTemp.NombreDeBanco
        frmNuevoBanco.btn_confirmar_nuevo_banco.Text = "Modificar"
        frmNuevoBanco.ShowDialog()

        frmNuevoBanco.txt_codigo_banco.Clear()
        frmNuevoBanco.txt_codigo_banco.Enabled = True
        frmNuevoBanco.txt_nombre_banco.Clear()

        fillDGBancos()
    End Sub
End Class
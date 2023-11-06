Public Class ctrGrupo
    Public frmGrupo As frmMain
    Dim listaGrupos As List(Of Grupo) = New List(Of Grupo)
    Dim grupoTemp As Grupo
    Dim criterioBusqueda As String = "idGrupo"

    Public Sub New(frmGrupoPasado As frmMain)
        MyBase.New()
        frmGrupo = frmGrupoPasado
        frmGrupo.rdb_nombre_grupo.Checked = True

        AddHandler frmGrupo.btn_añadir_grupo.Click, AddressOf click_btn_añadir_grupo
        AddHandler frmGrupo.btn_modificar_grupo.Click, AddressOf click_btn_modificar_grupo
        AddHandler frmGrupo.btn_eliminar_grupo.Click, AddressOf click_btn_eliminar_grupo
        AddHandler frmGrupo.dg_grupos.CellClick, AddressOf click_cell_dg_grupos
        AddHandler frmGrupo.tab_main.SelectedIndexChanged, AddressOf tab_main_SelectedIndexChanged
        AddHandler frmGrupo.rdb_codigo_grupo.CheckedChanged, AddressOf checked_changed_gb_grupos
        AddHandler frmGrupo.rdb_nombre_grupo.CheckedChanged, AddressOf checked_changed_gb_grupos
        AddHandler frmGrupo.txt_busqueda_grupo.TextChanged, AddressOf text_changed_txt_busqueda_grupo
    End Sub

    Public Sub fillDGGrupos()
        frmMain.btn_modificar_grupo.Enabled = False
        frmMain.btn_eliminar_grupo.Enabled = False

        frmNuevoGrupo.btn_confirmar_nuevo_grupo.Text = "Confirmar"
        frmNuevoGrupo.txt_codigo_grupo.Clear()
        frmNuevoGrupo.txt_nombre_grupo.Clear()

        Dim dg As DataGridView = frmGrupo.dg_grupos
        dg.Rows.Clear()
        listaGrupos = listaGruposAux
        For Each g As Grupo In listaGrupos
            Dim index As Integer = dg.Rows.Add()
            With dg.Rows(index)
                .Cells("idGrupo").Value = g.CodigoDeGrupo
                .Cells("nombreGrupo").Value = g.NombreDeGrupo
            End With
        Next
        frmGrupo.dg_grupos.ClearSelection()
        frmGrupo.txt_busqueda_grupo.Clear()
    End Sub

    Public Sub click_btn_añadir_grupo(sender As Object, e As EventArgs)
        frmNuevoGrupo.Text = "Creación nuevo grupo"
        frmNuevoGrupo.ShowDialog()
        fillDGGrupos()
    End Sub

    Private Sub click_btn_modificar_grupo(sender As Object, e As EventArgs)
        Dim frm As frmNuevoGrupo = New frmNuevoGrupo()
        frm.Text = "Modificación de grupo"
        frm.txt_codigo_grupo.Text = grupoTemp.CodigoDeGrupo
        frm.txt_codigo_grupo.Enabled = False
        frm.txt_nombre_grupo.Text = grupoTemp.NombreDeGrupo
        frm.btn_confirmar_nuevo_grupo.Text = "Modificar"
        frm.ShowDialog()

        frm.txt_codigo_grupo.Clear()
        frm.txt_codigo_grupo.Enabled = True
        frm.txt_nombre_grupo.Clear()

        fillDGGrupos()
    End Sub

    Private Sub click_btn_eliminar_grupo(sender As Object, e As EventArgs)
        grupoTemp.deleteGrupo()
        Dim ctrGrupoCliente As ctrCliente = New ctrCliente(frmGrupo)
        ctrGrupoCliente.fillDGClientes()
        fillDGGrupos()
    End Sub

    Private Sub click_cell_dg_grupos(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            frmGrupo.btn_modificar_grupo.Enabled = True
            frmGrupo.btn_eliminar_grupo.Enabled = True
            grupoTemp = getGrupoPorCodigo(frmGrupo.dg_grupos.Rows(e.RowIndex).Cells("idGrupo").Value)
        End If
    End Sub
    Private Sub checked_changed_gb_grupos(sender As Object, e As EventArgs)
        If frmGrupo.rdb_codigo_grupo.Checked Then
            criterioBusqueda = "idGrupo"
        Else
            criterioBusqueda = "nombreGrupo"
        End If
    End Sub
    Private Function lookForText(textoOrigen As String, textoBusqueda As String) As Boolean
        Dim resultado As Integer
        resultado = InStr(1, textoOrigen, textoBusqueda)
        If resultado > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub text_changed_txt_busqueda_grupo(sender As Object, e As EventArgs)
        Dim textoBusqueda As String = frmGrupo.txt_busqueda_grupo.Text
        Dim dg As DataGridView = frmGrupo.dg_grupos

        If frmGrupo.txt_busqueda_grupo.Text = Nothing Then
            For Each fila As DataGridViewRow In dg.Rows
                fila.Visible = True
            Next
            Exit Sub
        End If
        For Each fila As DataGridViewRow In dg.Rows
            If lookForText(fila.Cells(criterioBusqueda).Value.ToString().Trim, textoBusqueda.Trim) Then
                dg.CurrentCell = Nothing
                fila.Visible = True
            Else
                dg.CurrentCell = Nothing
                fila.Visible = False
            End If
        Next
    End Sub
    Private Sub tab_main_SelectedIndexChanged(sender As Object, e As EventArgs)
        If frmGrupo.tab_main.SelectedTab.Text.Equals("CLIENTES/GRUPOS") Then
            fillDGGrupos()
        End If
    End Sub
End Class
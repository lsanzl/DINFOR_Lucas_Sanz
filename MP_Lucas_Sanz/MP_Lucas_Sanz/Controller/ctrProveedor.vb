﻿Public Class ctrProveedor
    Dim frmProveedor As frmMain
    Dim listaProveedores As List(Of Proveedor)
    Dim proveedorTemp As Proveedor
    Dim criterioBusqueda As String = "nombreProveedor"

    Public Sub New(frmPasado As frmMain)
        MyBase.New()
        frmProveedor = frmPasado
        listaProveedores = New List(Of Proveedor)
        frmProveedor.rdb_nombre_proveedor.Checked = True

        AddHandler frmProveedor.btn_añadir_proveedor.Click, AddressOf click_btn_añadir_proveedor
        AddHandler frmProveedor.btn_modificar_proveedor.Click, AddressOf click_btn_modificar_proveedor
        AddHandler frmProveedor.btn_eliminar_proveedor.Click, AddressOf click_btn_eliminar_proveedor
        AddHandler frmProveedor.dg_proveedores.CellClick, AddressOf click_cell_dg_proveedores
        AddHandler frmProveedor.tab_main.SelectedIndexChanged, AddressOf tab_main_SelectedIndexChanged
        AddHandler frmProveedor.rdb_codigo_proveedor.CheckedChanged, AddressOf checked_changed_gb_proveedores
        AddHandler frmProveedor.rdb_nombre_proveedor.CheckedChanged, AddressOf checked_changed_gb_proveedores
        AddHandler frmProveedor.txt_busqueda_proveedor.TextChanged, AddressOf text_changed_txt_busqueda_proveedor
    End Sub

    Private Sub fillDGProveedores()
        frmProveedor.btn_modificar_proveedor.Enabled = False
        frmProveedor.btn_eliminar_proveedor.Enabled = False

        frmNuevoProveedor.btn_confirmar_proveedor.Text = "Confirmar"
        clearFields()

        frmProveedor.dg_proveedores.DataSource = Nothing
        frmProveedor.dg_proveedores.Rows.Clear()

        listaProveedores = proveedorAux.getProveedores()
        frmProveedor.dg_proveedores.DataSource = listaProveedores
        frmProveedor.dg_proveedores.ClearSelection()
    End Sub

    Public Sub click_btn_añadir_proveedor(sender As Object, e As EventArgs)
        frmNuevoProveedor.Text = "Creación nuevo proveedor"
        frmNuevoProveedor.ShowDialog()
        fillDGProveedores()
    End Sub
    Private Sub click_btn_modificar_proveedor(sender As Object, e As EventArgs)
        frmNuevoProveedor.Text = "Modificación de proveedor"
        frmNuevoProveedor.txt_codigo_proveedor.Text = proveedorTemp.CodigoDeProveedor
        frmNuevoProveedor.txt_codigo_proveedor.Enabled = False
        frmNuevoProveedor.txt_nombre_proveedor.Text = proveedorTemp.NombreDeProveedor
        frmNuevoProveedor.txt_nif_proveedor.Text = proveedorTemp.NifDeProveedor
        frmNuevoProveedor.txt_direccion_proveedor.Text = proveedorTemp.DireccionDeProveedor
        frmNuevoProveedor.txt_poblacion_proveedor.Text = proveedorTemp.PoblacionDeProveedor
        frmNuevoProveedor.txt_telefono_proveedor.Text = proveedorTemp.TelefonoDeProveedor
        frmNuevoProveedor.btn_confirmar_proveedor.Text = "Modificar"
        frmNuevoProveedor.ShowDialog()

        clearFields()
        fillDGProveedores()
    End Sub
    Private Sub click_btn_eliminar_proveedor(sender As Object, e As EventArgs)
        proveedorTemp.deleteProveedor()
        fillDGProveedores()
    End Sub
    Private Sub clearFields()
        frmNuevoProveedor.txt_codigo_proveedor.Clear()
        frmNuevoProveedor.txt_codigo_proveedor.Enabled = True
        frmNuevoProveedor.txt_nombre_proveedor.Clear()
        frmNuevoProveedor.txt_nif_proveedor.Clear()
        frmNuevoProveedor.txt_direccion_proveedor.Clear()
        frmNuevoProveedor.txt_poblacion_proveedor.Clear()
        frmNuevoProveedor.txt_telefono_proveedor.Clear()
    End Sub
    Private Sub click_cell_dg_proveedores(sender As Object, e As DataGridViewCellEventArgs)
        If Not e.RowIndex >= 0 Then
            Return
        End If
        Dim currentCelll As DataGridViewCell = frmProveedor.dg_proveedores.CurrentCell
        If currentCelll.Value.Equals("VER DATOS") Then
            proveedorTemp = frmProveedor.dg_proveedores.Rows(e.RowIndex).DataBoundItem
            frmVerDatosProveedor.Text = $"Datos de {proveedorTemp.NombreDeProveedor}"
            frmVerDatosProveedor.txt_codigo_proveedor.Text = proveedorTemp.CodigoDeProveedor
            frmVerDatosProveedor.txt_nombre_proveedor.Text = proveedorTemp.NombreDeProveedor
            frmVerDatosProveedor.txt_nif_proveedor.Text = proveedorTemp.NifDeProveedor
            frmVerDatosProveedor.txt_direccion_proveedor.Text = proveedorTemp.DireccionDeProveedor
            frmVerDatosProveedor.txt_poblacion_proveedor.Text = proveedorTemp.PoblacionDeProveedor
            frmVerDatosProveedor.txt_telefono_proveedor.Text = proveedorTemp.TelefonoDeProveedor

            frmVerDatosProveedor.txt_codigo_proveedor.Enabled = False
            frmVerDatosProveedor.txt_nombre_proveedor.Enabled = False
            frmVerDatosProveedor.txt_nif_proveedor.Enabled = False
            frmVerDatosProveedor.txt_direccion_proveedor.Enabled = False
            frmVerDatosProveedor.txt_poblacion_proveedor.Enabled = False
            frmVerDatosProveedor.txt_telefono_proveedor.Enabled = False
            frmVerDatosProveedor.ShowDialog()
            fillDGProveedores()
            Return
        End If

        frmProveedor.btn_modificar_proveedor.Enabled = True
        frmProveedor.btn_eliminar_proveedor.Enabled = True
        proveedorTemp = frmProveedor.dg_proveedores.Rows(e.RowIndex).DataBoundItem
    End Sub
    Private Sub checked_changed_gb_proveedores(sender As Object, e As EventArgs)
        If frmProveedor.rdb_codigo_proveedor.Checked Then
            criterioBusqueda = "codigoProveedor"
        Else
            criterioBusqueda = "nombreProveedor"
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
    Private Sub text_changed_txt_busqueda_proveedor(sender As Object, e As EventArgs)
        Dim textoBusqueda As String = frmProveedor.txt_busqueda_proveedor.Text
        Dim dg As DataGridView = frmProveedor.dg_proveedores

        If frmProveedor.txt_busqueda_proveedor.Text = Nothing Then
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
        If frmProveedor.tab_main.SelectedTab.Text.Equals("ARTÍCULOS/PROVEEDORES") Then
            fillDGProveedores()
        End If
    End Sub
End Class
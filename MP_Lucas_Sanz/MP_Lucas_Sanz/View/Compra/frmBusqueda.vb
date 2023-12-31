﻿Public Class frmBusqueda
    Dim criterioBusqueda As String = "nombre"
    Dim clase As Object
    Public Property codigoSeleccionado As Integer
    Public Property articuloSeleccionado As Articulo
    Public Property proveedorSeleccionado As Proveedor
    Dim listaProveedores As List(Of Proveedor)
    Dim listaArticulos As List(Of Articulo)

    Private Sub frmBusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdb_nombre.Checked = True
        Dim listaProveedores As List(Of Proveedor) = managerProveedorAux.getProveedores()
        Dim listaArticulos As List(Of Articulo) = managerArticuloAux.getArticulos()
    End Sub
    Public Sub New(claseP As Object)
        MyBase.New()
        InitializeComponent()
        clase = claseP

        dg_resultados_busqueda.Columns.Add("nombre", "Nombre")
        dg_resultados_busqueda.Columns.Add("codigo", "Código")

        If TypeOf clase Is Proveedor Then
            listaProveedores = proveedorAux.getProveedores()
            Dim contador As Integer = 0
            For Each proveedor As Proveedor In listaProveedores
                dg_resultados_busqueda.Rows.Add()

                dg_resultados_busqueda.Rows(contador).Cells(0).Value = proveedor.NombreDeProveedor
                dg_resultados_busqueda.Rows(contador).Cells(1).Value = proveedor.CodigoDeProveedor

                contador += 1
            Next
        End If
        If TypeOf clase Is Articulo Then
            listaArticulos = articuloAux.getArticulos()
            Dim contador As Integer = 0
            For Each articulo As Articulo In listaArticulos
                dg_resultados_busqueda.Rows.Add()

                dg_resultados_busqueda.Rows(contador).Cells(0).Value = articulo.NombreDeArticulo
                dg_resultados_busqueda.Rows(contador).Cells(1).Value = articulo.CodigoDeArticulo

                contador += 1
            Next
        End If
    End Sub

    Private Sub txtchanged_txt_busqueda(sender As Object, e As EventArgs) Handles txt_busqueda_generica.TextChanged
        Dim textoBusqueda As String = txt_busqueda_generica.Text
        Dim dg As DataGridView = dg_resultados_busqueda

        If textoBusqueda = Nothing Then
            For Each fila As DataGridViewRow In dg.Rows
                fila.Visible = True
            Next
            Exit Sub
        End If

        For Each fila As DataGridViewRow In dg.Rows
            If lookForText(fila.Cells(criterioBusqueda).Value.ToString().Trim(), textoBusqueda.Trim()) Then
                dg.CurrentCell = Nothing
                fila.Visible = True
            Else
                dg.CurrentCell = Nothing
                fila.Visible = False
            End If
        Next
    End Sub
    Private Function lookForText(textoOrigen As String, textoBusqueda As String) As Boolean
        Dim resultado As Integer
        resultado = InStr(1, textoOrigen.ToUpper(), textoBusqueda.ToUpper())
        If resultado > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub checked_changed_grupobox(sender As Object, e As EventArgs) Handles rdb_nombre.CheckedChanged, rdb_codigo.CheckedChanged
        If rdb_nombre.Checked Then
            criterioBusqueda = "nombre"
        Else
            criterioBusqueda = "codigo"
        End If
    End Sub

    Private Sub double_click_cell_dg_resultados_busqueda(sender As Object, e As DataGridViewCellEventArgs) Handles dg_resultados_busqueda.CellDoubleClick
        If TypeOf clase Is Articulo Then
            codigoSeleccionado = dg_resultados_busqueda.Rows(e.RowIndex).Cells(1).Value.ToString()
            articuloSeleccionado = listaArticulos.Find(Function(a) a.CodigoDeArticulo = codigoSeleccionado)
        Else
            codigoSeleccionado = dg_resultados_busqueda.Rows(e.RowIndex).Cells(1).Value.ToString()
            proveedorSeleccionado = listaProveedores.Find(Function(p) p.CodigoDeProveedor = codigoSeleccionado)
        End If
        Close()
    End Sub
End Class
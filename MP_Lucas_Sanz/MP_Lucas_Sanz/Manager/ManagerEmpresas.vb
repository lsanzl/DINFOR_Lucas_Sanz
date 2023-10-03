Imports System.Data.SqlClient

Public Class ManagerEmpresas

    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private empresaAux As Empresa
    Private listaEmpresas As List(Of Empresa) = New List(Of Empresa)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Function getEmpresas() As List(Of Empresa)
        listaEmpresas.Clear()
        cmd = New SqlCommand("SELECT name, database_id From sys.databases;", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Do
                If dr(0).ToString().StartsWith("Emp") Then
                    empresaAux = New Empresa(dr(0).ToString(), dr(1).ToString())
                    listaEmpresas.Add(empresaAux)
                End If
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaEmpresas
    End Function

    Public Sub modificarEmpresa(nuevoNombre As String, nombreAntiguo As String)
        cmd = New SqlCommand("ALTER DATABASE " + nombreAntiguo + " MODIFY NAME = " + nuevoNombre + ";", connectionDBManager)
        If cmd.ExecuteNonQuery() = -1 Then
            MessageBox.Show("Empresa actualizada")
            frmSeleccionEmpresa.fillDataGrid()
        Else
            MessageBox.Show("Ninguna empresa actualizada")
        End If
    End Sub
    Public Sub deleteEmpresa(nombreEmpresa As String)
        cmd = New SqlCommand("DROP DATABASE " + nombreEmpresa, connectionDBManager)
        If cmd.ExecuteNonQuery() = -1 Then
            MessageBox.Show("Empresa eliminada")
        Else
            MessageBox.Show("Ninguna empresa eliminada")
        End If
    End Sub
    Public Sub addEmpresa(nombreEmpresa As String)
        cmd = New SqlCommand("CREATE DATABASE " + nombreEmpresa, connectionDBManager)
        If cmd.ExecuteNonQuery() = -1 Then
            MessageBox.Show("Empresa creada")
            frmSeleccionEmpresa.fillDataGrid()
        Else
            MessageBox.Show("Ninguna empresa creada")
        End If
    End Sub
End Class
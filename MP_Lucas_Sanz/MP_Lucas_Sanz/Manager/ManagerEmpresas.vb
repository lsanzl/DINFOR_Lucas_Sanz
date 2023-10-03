Imports System.Data.SqlClient

Public Class ManagerEmpresas

    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private empresaAux As Empresa
    Private listaEmpresas As List(Of Empresa) = New List(Of Empresa)
    Private nombreEmp As String
    Private codigoEmp As String

    Public Function getEmpresas() As List(Of Empresa)
        listaEmpresas.Clear()
        cmd = New SqlCommand("SELECT name, database_id From sys.databases;", VariablesGlobales.connectionDB.connectionDB)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Do
                nombreEmp = dr(0).ToString()
                If nombreEmp.StartsWith("Emp") Then
                    codigoEmp = dr(1).ToString()
                    empresaAux = New Empresa(nombreEmp, codigoEmp)
                    listaEmpresas.Add(empresaAux)
                End If
            Loop While dr.Read()
        End If
        Return listaEmpresas
    End Function

End Class
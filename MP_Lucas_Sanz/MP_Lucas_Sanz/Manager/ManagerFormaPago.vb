Imports System.Data.SqlClient
Imports MP_Lucas_Sanz.VariablesGlobales

Public Class ManagerFormaPago
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaFormaPagos As List(Of FormaPago) = New List(Of FormaPago)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Function getFormaPagos() As List(Of FormaPago)
        listaFormaPagos.Clear()
        cmd = New SqlCommand("SELECT NOMBREBANCO, CODIGOBANCO FROM BANCOS;", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Do
                formaPagoAux = New FormaPago()
                listaFormaPagos.Add(formaPagoAux)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaFormaPagos
    End Function
End Class
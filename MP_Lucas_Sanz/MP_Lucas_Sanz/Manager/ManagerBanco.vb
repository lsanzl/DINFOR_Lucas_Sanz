Imports System.Data.SqlClient

Public Class ManagerBanco
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaBancos As List(Of Banco) = New List(Of Banco)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Function getBancos() As List(Of Banco)
        listaBancos.Clear()
        cmd = New SqlCommand("SELECT NOMBREBANCO, CODIGOBANCO FROM BANCOS;", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Do
                bancoAux = New Banco(dr(0).ToString(), dr(1).ToString())
                listaBancos.Add(bancoAux)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaBancos
    End Function

    Public Sub addBanco(bancoTemp As Banco)
        cmd = New SqlCommand($"INSERT INTO BANCOS (CODIGOBANCO, NOMBREBANCO)
                                VALUES ({bancoTemp.CodigoDeBanco}, '{bancoTemp.NombreDeBanco}');", connectionDBManager)
        If cmd.ExecuteNonQuery > 0 Then
            MessageBox.Show("Banco introducido")
        Else
            MessageBox.Show("Banco no introducido")
        End If
    End Sub
    Public Sub modifyBanco(bancoTemp As Banco)
        cmd = New SqlCommand($"UPDATE BANCOS
                                SET NOMBREBANCO = '{bancoTemp.NombreDeBanco}'
                                WHERE CODIGOBANCO = '{bancoTemp.CodigoDeBanco}';", connectionDBManager)
        If cmd.ExecuteNonQuery > 0 Then
            MessageBox.Show("Banco modificado")
        Else
            MessageBox.Show("Banco no modificado")
        End If
    End Sub

    Public Sub deleteBanco(bancoTemp As Banco)
        cmd = New SqlCommand($"DELETE FROM BANCOS
                                WHERE CODIGOBANCO = {bancoTemp.CodigoDeBanco};", connectionDBManager)
        If cmd.ExecuteNonQuery > 0 Then
            MessageBox.Show("Banco eliminado")
        Else
            MessageBox.Show("Banco no eliminado")
        End If
    End Sub

    Public Function checkBanco(codigoBanco As String) As Boolean
        cmd = New SqlCommand($"SELECT NOMBREBANCO
                                FROM BANCOS
                                WHERE CODIGOBANCO = {codigoBanco};", connectionDBManager)
        dr = cmd.ExecuteReader()
        If Not dr.HasRows Then
            dr.Close()
            Return True
        End If
        dr.Close()
        Return False
    End Function
End Class

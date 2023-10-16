Imports System.Data.SqlClient

Public Class ManagerFamilia
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaFamilias As List(Of Familia) = New List(Of Familia)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Function getFamilias() As List(Of Familia)
        listaFamilias = New List(Of Familia)
        cmd = New SqlCommand("SELECT * FROM FAMILIAS", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Dim familiaTemp As Familia
            dr.Read()
            Do
                familiaTemp = New Familia(dr(0).ToString(), dr(1).ToString())
                listaFamilias.Add(familiaTemp)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaFamilias
    End Function

    Public Sub addFamilia(familiaTemp As Familia)
        If checkCodigoFamilia(familiaTemp.CodigoDeFamilia) Then
            MessageBox.Show("Ya existe dicha familia")
            Return
        End If
        cmd = New SqlCommand($"INSERT INTO FAMILIAS VALUES ('{familiaTemp.CodigoDeFamilia}', 
                            '{familiaTemp.NombreDeFamilia}');", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Familia creada")
        Else
            MessageBox.Show("Familia no creada")
        End If
    End Sub
    Public Sub modifyFamilia(familiaTemp As Familia)
        cmd = New SqlCommand($"UPDATE FAMILIAS SET NOMBREFAMILIA = '{familiaTemp.NombreDeFamilia}'
                            WHERE CODIGOFAMILIA = '{familiaTemp.CodigoDeFamilia}';", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Familia modificada")
        Else
            MessageBox.Show("Familia no modificada")
        End If
    End Sub
    Public Sub deleteFamilia(familiaTemp As Familia)
        cmd = New SqlCommand($"DELETE FROM FAMILIAS 
                            WHERE CODIGOFAMILIA = '{familiaTemp.CodigoDeFamilia}';", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Familia eliminada")
        Else
            MessageBox.Show("Familia no eliminada")
        End If
    End Sub
    Public Function checkCodigoFamilia(codigoPasado As String) As Boolean
        cmd = New SqlCommand($"SELECT * FROM FAMILIAS 
                            WHERE CODIGOFAMILIA = '{codigoPasado}';", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Close()
            Return True
        Else
            dr.Close()
            Return False
        End If
    End Function
End Class
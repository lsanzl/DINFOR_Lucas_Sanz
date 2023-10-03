Imports System.Data.SqlClient

Public Class ConnectionDB

    Dim strInstancia As String = "127.0.0.1"
    Dim strPuerto As String = "49172"
    Dim strBD As String = "master"
    Dim strUsuario As String = "Lucas"
    Dim strPassword As String = "lusalo96"
    Dim strSQL As String = "Data Source =" + strInstancia.Trim() + "," + strPuerto.Trim() + ";" +
                                "Network Library = DBMSSOCN;" +
                                "Initial Catalog = " & strBD & ";" &
                                "User ID =" + strUsuario.Trim() + ";" +
                                "Password =" + strPassword.Trim() + ";"

    Public connectionDB As SqlConnection = New SqlConnection(strSQL)

    Public Sub ConectarDB()
        connectionDB.Open()
        MessageBox.Show("Conexión con BD realizada")
    End Sub
    Public Sub DesconectarDB()
        connectionDB.Close()
        MessageBox.Show("Desconexión con BD")
    End Sub
End Class
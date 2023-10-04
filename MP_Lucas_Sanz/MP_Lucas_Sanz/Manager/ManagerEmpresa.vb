Imports System.Data.SqlClient

Public Class ManagerEmpresa

    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private codigoTemp As String
    Private empresaTemp As Empresa
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
                    codigoTemp = Right(dr(0).ToString(), dr(0).ToString().Length - 3)
                    empresaTemp = New Empresa(dr(0).ToString(), codigoTemp)
                    listaEmpresas.Add(empresaTemp)
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
        Else
            MessageBox.Show("Ninguna empresa creada")
        End If
        selectEmpresa(nombreEmpresa)
        cmd = New SqlCommand("CREATE TABLE BANCOS(
                            CODIGOBANCO INT PRIMARY KEY,
                            NOMBREBANCO VARCHAR(100)
                            );", connectionDBManager)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("CREATE TABLE FORMASPAGO(
                                CODIGOPAGO VARCHAR(5) PRIMARY KEY,
                                NOMBREFORMAPAGO VARCHAR(100),
                                BANCO INTEGER,
                                ESTADO BIT,
                                NUMEROPLAZOS INTEGER,
                                PRIMERPLAZO INTEGER,
                                DIASENTREPLAZOS INTEGER,
                                FOREIGN KEY (BANCO) REFERENCES BANCOS(CODIGOBANCO) ON DELETE CASCADE
                                );", connectionDBManager)
        cmd.ExecuteNonQuery()
    End Sub
    Public Function checkEmpresa(nombreEmpresa As String) As Boolean
        cmd = New SqlCommand("SELECT NAME
                                FROM sys.databases
                                WHERE NAME = '" + nombreEmpresa + "';", connectionDBManager)
        dr = cmd.ExecuteReader()
        If Not dr.HasRows Then
            dr.Close()
            Return True
        End If
        dr.Close()
        Return False
    End Function

    Public Sub selectEmpresa()
        cmd = New SqlCommand("USE " + getEmpresaSeleccionada() + ";", connectionDBManager)
        cmd.ExecuteNonQuery()
    End Sub
    Public Sub selectEmpresa(nombreEmp As String)
        cmd = New SqlCommand("USE " + nombreEmp + ";", connectionDBManager)
        cmd.ExecuteNonQuery()
    End Sub
End Class
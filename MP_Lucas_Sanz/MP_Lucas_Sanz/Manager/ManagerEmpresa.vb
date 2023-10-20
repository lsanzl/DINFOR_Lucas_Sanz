﻿Imports System.Data.SqlClient

Public Class ManagerEmpresa

    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private codigoTemp As String
    Private empresaTemp As Empresa
    Private listaEmpresas As List(Of Empresa) = New List(Of Empresa)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Function getEmpresas() As List(Of Empresa)
        listaEmpresas = New List(Of Empresa)
        cmd = New SqlCommand("SELECT name, database_id From sys.databases;", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Do
                If dr(0).ToString().StartsWith("Emp") Then
                    empresaTemp = New Empresa(dr(0).ToString())
                    listaEmpresas.Add(empresaTemp)
                End If
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaEmpresas
    End Function

    Public Sub modificarEmpresa(empTemp As Empresa)
        cmd = New SqlCommand("ALTER DATABASE @NombreAntiguo MODIFY NAME = @NombreNuevo;", connectionDBManager)
        With cmd.Parameters
            .Add("@NombreAntiguo", SqlDbType.Char, 50).Value = empTemp.getNombreAntiguo()
            .Add("@NombreNuevo", SqlDbType.Char, 50).Value = empTemp.NombreEmpresa
        End With
        Try
            cmd.ExecuteNonQuery()
            frmSeleccionEmpresa.fillDataGrid()
        Catch ex As Exception
            MessageBox.Show("No se pudo actualizar la empresa: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteEmpresa(empAux As Empresa)
        cmd = New SqlCommand("DROP DATABASE @Nombre;", connectionDBManager)
        cmd.Parameters.Add("@Nombre", SqlDbType.Char, 50).Value = empAux.NombreEmpresa
        Try
            cmd.ExecuteNonQuery()
            frmSeleccionEmpresa.fillDataGrid()
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar la empresa: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub addEmpresa(empAux As Empresa)
        cmd = New SqlCommand($"CREATE DATABASE {empAux.NombreEmpresa};", connectionDBManager)
        Try
            cmd.ExecuteNonQuery()
            frmSeleccionEmpresa.fillDataGrid()
        Catch ex As Exception
            MessageBox.Show("No se pudo crear la empresa: " + vbCrLf + ex.ToString())
        End Try
        selectEmpresa(empAux.NombreEmpresa)
        cmd = New SqlCommand("CREATE TABLE BANCOS(
                            ID_BANCO INT PRIMARY KEY,
                            NOMBRE_BANCO VARCHAR(100)
                            );", connectionDBManager)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("CREATE TABLE FORMASPAGO(
                            ID_FORMA_PAGO INT PRIMARY KEY,
                            ID_BANCO INT,
                            NOMBRE_FORMA_PAGO VARCHAR(100),
                            ESTADO BIT,
                            NUMERO_PLAZOS INT,
                            DIAS_PRIMER_PLAZO INT,
                            DIAS_ENTRE_PLAZOS INT,
                            FOREIGN KEY (ID_BANCO) REFERENCES BANCOS(ID_BANCO)
                            );", connectionDBManager)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("CREATE TABLE GRUPOS(
                            ID_GRUPO INT PRIMARY KEY,
                            NOMBRE_GRUPO VARCHAR(100)
                            );", connectionDBManager)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("CREATE TABLE CLIENTES(
                            ID_CLIENTE INT PRIMARY KEY,
                            ID_GRUPO INT,
                            ID_BANCO INT,
                            NOMBRE_CLIENTE VARCHAR(100),
                            NIF_CLIENTE VARCHAR(12),
                            DIRECCION_CLIENTE VARCHAR(150),
                            FECHA_NACIMIENTO_CLIENTE DATE,
                            EMAIL_CLIENTE VARCHAR(100),
                            FOREIGN KEY(ID_GRUPO) REFERENCES GRUPOS(ID_GRUPO),
                            FOREIGN KEY(ID_BANCO) REFERENCES BANCOS(ID_BANCO)
                            );", connectionDBManager)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("CREATE TABLE PROVEEDORES(
                            ID_PROVEEDOR INT PRIMARY KEY,
                            NOMBRE_PROVEEDOR VARCHAR(100),
                            NIF_PROVEEDOR VARCHAR(12),
                            DIRECCION_PROVEEDOR VARCHAR(150),
                            POBLACION_PROVEEDOR VARCHAR(100),
                            TELEFONO_PROVEEDOR INT
                            );", connectionDBManager)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("CREATE TABLE FAMILIAS(
                            ID_FAMILIA INT PRIMARY KEY,
                            NOMBRE_FAMILIA VARCHAR(100)
                            );", connectionDBManager)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("CREATE TABLE ARTICULOS(
                            ID_ARTICULO INT PRIMARY KEY,
                            ID_FAMILIA INT,
                            NOMBRE_ARTICULO VARCHAR(100),
                            DESCRIPCION_ARTICULO VARCHAR(150),
                            PRECIO_COMPRA_ARTICULO DECIMAL(10,2),
                            PORC_BENEFICIO_ARTICULO DECIMAL(5,2),
                            TIPO_UNIDAD VARCHAR(50),
                            FOREIGN KEY(ID_FAMILIA) REFERENCES FAMILIAS(ID_FAMILIA)
                            );", connectionDBManager)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("CREATE TABLE INVENTARIOS(
                            ID_INVENTARIO INT PRIMARY KEY,
                            ID_ARTICULO INT,
                            UNIDADES_INVENTARIO INT,
                            FOREIGN KEY(ID_ARTICULO) REFERENCES ARTICULOS(ID_ARTICULO)
                            );", connectionDBManager)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("CREATE TABLE COMPRAS(
                            ID_COMPRA INT PRIMARY KEY,
                            ID_PROVEEDOR INT,
                            ID_ARTICULO INT,
                            ID_FORMA_PAGO INT,
                            PRECIO_ARTICULO_COMPRA DECIMAL(10,2),
                            CANTIDAD_COMPRA INT,
                            FECHA_COMPRA DATE,
                            FOREIGN KEY(ID_PROVEEDOR) REFERENCES PROVEEDORES(ID_PROVEEDOR),
                            FOREIGN KEY(ID_ARTICULO) REFERENCES ARTICULOS(ID_ARTICULO),
                            FOREIGN KEY(ID_FORMA_PAGO) REFERENCES FORMASPAGO(ID_FORMA_PAGO)
                            );", connectionDBManager)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("CREATE TABLE VENTAS(
                            ID_VENTA INT PRIMARY KEY,
                            ID_CLIENTE INT,
                            ID_ARTICULO INT,
                            ID_FORMA_PAGO INT,
                            PRECIO_VENTA_ARTICULO DECIMAL(10,2),
                            CANTIDAD_VENTA INT,
                            FECHA_VENTA DATE,
                            FOREIGN KEY(ID_CLIENTE) REFERENCES CLIENTES(ID_CLIENTE),
                            FOREIGN KEY(ID_ARTICULO) REFERENCES ARTICULOS(ID_ARTICULO),
                            FOREIGN KEY(ID_FORMA_PAGO) REFERENCES FORMASPAGO(ID_FORMA_PAGO)
                            );", connectionDBManager)
        cmd.ExecuteNonQuery()
    End Sub
    Public Function checkEmpresa(nombreEmpresa As String) As Boolean
        cmd = New SqlCommand("SELECT NAME
                                FROM sys.databases
                                WHERE NAME = @Nombre;", connectionDBManager)
        cmd.Parameters.Add("@Nombre", SqlDbType.Char, 50).Value = nombreEmpresa
        dr = cmd.ExecuteReader()
        If Not dr.HasRows Then
            dr.Close()
            Return True
        End If
        dr.Close()
        Return False
    End Function

    Public Sub selectEmpresa()
        cmd = New SqlCommand($"USE {getEmpresaSeleccionada()};", connectionDBManager)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub selectEmpresa(nombreEmp As String)
        cmd = New SqlCommand($"USE {nombreEmp};", connectionDBManager)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class
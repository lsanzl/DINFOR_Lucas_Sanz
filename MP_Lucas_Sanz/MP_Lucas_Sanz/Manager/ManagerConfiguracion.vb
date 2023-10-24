Imports System.Data.SqlClient

Public Class ManagerConfiguracion
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaEmpresas As List(Of String)
    Private listaEmpresasActualizar As List(Of String)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB
    Dim nombreEmpresa As String = VariablesGlobales.getEmpresaSeleccionada()

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub actualizarCampoTabla()
        cmd = New SqlCommand("SELECT * FROM INFORMATION_SCHEMA.TABLES
                            WHERE TABLE_NAME = 'CLIENTES';", connectionDBManager)
        dr = cmd.ExecuteReader
        If Not dr.HasRows Then
            dr.Close()
            MessageBox.Show("No existe la tabla CLIENTES en la empresa, no se pueden añadir campos")
            Return
        End If
        dr.Close()

        cmd = New SqlCommand("SELECT * FROM INFORMATION_SCHEMA.COLUMNS
                            WHERE COLUMN_NAME = 'EMAIL_CLIENTE' 
                            AND TABLE_NAME = 'CLIENTES';", connectionDBManager)
        dr = cmd.ExecuteReader
        If Not dr.HasRows Then
            dr.Close()
            addCampoEmailCliente()
            MessageBox.Show($"La empresa {nombreEmpresa} no contenía en la tabla CLIENTES el campo EMAIL_CLIENTE, se ha creado")
        Else
            dr.Close()
            MessageBox.Show($"La empresa {nombreEmpresa} contenía en la tabla CLIENTES el campo EMAIL_CLIENTE")
        End If
    End Sub
    Public Sub addCampoEmailCliente()
        cmd = New SqlCommand("ALTER TABLE CLIENTES ADD EMAIL_CLIENTE VARCHAR(100);", connectionDBManager)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error al añadir campo", Nothing, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub actualizarTablaNueva()
        Dim mensajeResumen As String = ""
        cmd = New SqlCommand("SELECT * FROM INFORMATION_SCHEMA.TABLES
                            WHERE TABLE_NAME = 'COMPRAS';", connectionDBManager)
        dr = cmd.ExecuteReader
        If Not dr.HasRows Then
            dr.Close()
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
            Try
                cmd.ExecuteNonQuery()
                mensajeResumen += $"La empresa {nombreEmpresa} no contenía la tabla COMPRAS, se ha creado"
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        Else
            dr.Close()
            mensajeResumen += $"La empresa {nombreEmpresa} ya contenía la tabla COMPRAS"
        End If
        mensajeResumen += vbCrLf
        cmd = New SqlCommand("SELECT * FROM INFORMATION_SCHEMA.TABLES
                            WHERE TABLE_NAME = 'VENTAS';", connectionDBManager)
        dr = cmd.ExecuteReader
        If Not dr.HasRows Then
            dr.Close()
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
            Try
                cmd.ExecuteNonQuery()
                mensajeResumen += $"La empresa {nombreEmpresa} no contenía la tabla VENTAS, se ha creado"
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        Else
            dr.Close()
            mensajeResumen += $"La empresa {nombreEmpresa} ya contenía la tabla VENTAS"
        End If
        MessageBox.Show(mensajeResumen)
    End Sub
    Public Sub actualizarFKNueva()
        Dim mensajeResumen As String = ""
        Dim existeFK As Boolean = False
        Dim constraintActual As String

        cmd = New SqlCommand("SELECT * FROM INFORMATION_SCHEMA.TABLES
                            WHERE TABLE_NAME = 'INVENTARIOS';", connectionDBManager)
        dr = cmd.ExecuteReader
        If Not dr.HasRows Then
            dr.Close()
            MessageBox.Show("No existe la tabla INVENTARIOS en la empresa, no se puede añadir la restricción")
            Return
        End If
        dr.Close()
        cmd = New SqlCommand("SELECT CONSTRAINT_NAME
                            FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
                            WHERE TABLE_NAME='INVENTARIOS';", connectionDBManager)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            Do
                constraintActual = dr(0).ToString()
                If constraintActual.StartsWith("FK__INVENTARI__ID_AR") Then
                    mensajeResumen += "La tabla INVENTARIOS ya contiene la FK"
                    existeFK = True
                End If
            Loop While dr.Read()
            dr.Close()
        End If
        If Not existeFK Then
            cmd = New SqlCommand("ALTER TABLE INVENTARIOS
                                ADD FOREIGN KEY (ID_ARTICULO) 
                                REFERENCES ARTICULOS(ID_ARTICULO);", connectionDBManager)
            Try
                cmd.ExecuteNonQuery()
                mensajeResumen += "La tabla INVENTARIOS no contenía la FK, ha sido creada"
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
        MessageBox.Show(mensajeResumen)
    End Sub
End Class
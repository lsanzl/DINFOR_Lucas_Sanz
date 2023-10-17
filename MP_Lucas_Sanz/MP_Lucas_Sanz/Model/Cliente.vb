Public Class Cliente
    Private codigoCliente As String
    Private nombreCliente As String
    Private nif As String
    Private direccion As String
    Private fechaNacimiento As Date
    Private bancoCliente As Integer
    Private grupoCliente As String
    Private email As String

    Public Property CodigoDelCliente() As String
        Get
            Return codigoCliente
        End Get
        Set(value As String)
            codigoCliente = value
        End Set
    End Property
    Public Property NombreDelCliente() As String
        Get
            Return nombreCliente
        End Get
        Set(value As String)
            nombreCliente = value
        End Set
    End Property
    Public Property NifDelCliente() As String
        Get
            Return nif
        End Get
        Set(value As String)
            nif = value
        End Set
    End Property
    Public Property DireccionDelCliente() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property
    Public Property FechaDeNacimientoDelCliente() As Date
        Get
            Return fechaNacimiento
        End Get
        Set(value As Date)
            fechaNacimiento = value
        End Set
    End Property
    Public Property BancoDelCliente() As Integer
        Get
            Return bancoCliente
        End Get
        Set(value As Integer)
            bancoCliente = value
        End Set
    End Property
    Public Property GrupoDelCliente() As String
        Get
            Return grupoCliente
        End Get
        Set(value As String)
            grupoCliente = value
        End Set
    End Property
    Public Property EmailDelCliente() As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(codigoPasado As String, nombrePasado As String, nifPasado As String, direccionPasada As String, fechaPasada As Date,
                   bancoPasado As Integer, grupoPasado As String, emailPasado As String)
        MyBase.New()
        CodigoDelCliente = codigoPasado
        NombreDelCliente = nombrePasado
        NifDelCliente = nifPasado
        DireccionDelCliente = direccionPasada
        FechaDeNacimientoDelCliente = fechaPasada
        BancoDelCliente = bancoPasado
        GrupoDelCliente = grupoPasado
        EmailDelCliente = emailPasado
    End Sub

    Public Function getClientes() As List(Of Cliente)
        Return managerClienteAux.getClientes()
    End Function
    Public Sub addCliente()
        managerClienteAux.addCliente(Me)
    End Sub
    Public Sub modifyCliente()
        managerClienteAux.modifyCliente(Me)
    End Sub
    Public Sub deleteCliente()
        managerClienteAux.deleteCliente(Me)
    End Sub
    Public Function checkCodigoCliente(codigoPasado As String)
        If codigoPasado.Length > 6 Then
            MessageBox.Show("Máxima longitud de 6")
            Return False
        End If
        Return True
    End Function
End Class
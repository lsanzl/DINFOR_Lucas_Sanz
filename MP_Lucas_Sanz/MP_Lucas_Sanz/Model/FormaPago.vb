﻿Public Class FormaPago
    Private codigoPago As Integer
    Private nombrePago As String
    Private bancoAsignadoPago As Integer
    Private estadoPago As Integer
    Private numPlazosPago As Integer
    Private diasPrimerPlazo As Integer
    Private diasEntrePlazos As Integer

    Public Property CodigoDePago() As Integer
        Get
            Return codigoPago
        End Get
        Set(value As Integer)
            codigoPago = value
        End Set
    End Property
    Public Property NombreDePago() As String
        Get
            Return nombrePago
        End Get
        Set(value As String)
            nombrePago = value
        End Set
    End Property
    Public Property BancoAsignado() As Integer
        Get
            Return bancoAsignadoPago
        End Get
        Set(value As Integer)
            bancoAsignadoPago = value
        End Set
    End Property
    Public Property Activo() As Integer
        Get
            Return estadoPago
        End Get
        Set(value As Integer)
            estadoPago = value
        End Set
    End Property
    Public Property NumeroPlazosPago() As Integer
        Get
            Return numPlazosPago
        End Get
        Set(value As Integer)
            numPlazosPago = value
        End Set
    End Property
    Public Property PrimerPlazo() As Integer
        Get
            Return diasPrimerPlazo
        End Get
        Set(value As Integer)
            diasPrimerPlazo = value
        End Set
    End Property
    Public Property DiasPlazos() As Integer
        Get
            Return diasEntrePlazos
        End Get
        Set(value As Integer)
            diasEntrePlazos = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(codigoPagoP As Integer, nombrePagoP As String, bancoAsignadoP As Integer,
                   estadoPagoP As Integer, numPlazosPagoP As Integer, diasPrimerPlazoP As Integer,
                   diasEntrePlazosP As Integer)
        MyBase.New()
        codigoPago = codigoPagoP
        nombrePago = nombrePagoP
        BancoAsignado = bancoAsignadoP
        estadoPago = estadoPagoP
        numPlazosPago = numPlazosPagoP
        diasPrimerPlazo = diasPrimerPlazoP
        diasEntrePlazos = diasEntrePlazosP
    End Sub

    Public Sub addFormaPago()
        managerFormaPagoAux.addFormaPago(Me)
    End Sub
    Public Sub modifyFormaPago()
        managerFormaPagoAux.modifyFormaPago(Me)
    End Sub
    Public Sub deleteFormaPago()
        managerFormaPagoAux.deleteFormaPago(Me)
    End Sub
    Public Function getFormasPago() As List(Of FormaPago)
        Return managerFormaPagoAux.getFormaPagos()
    End Function
    Public Sub changeEstado()
        If Me.Activo = 1 Then
            Me.Activo = 0
        Else
            Me.Activo = 1
        End If
        managerFormaPagoAux.changeEstado(Me)
    End Sub

End Class
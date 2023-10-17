Imports System.Net.Mail
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class viewerRPTVenta

    Dim pdfExportado As Boolean = False

    Private Sub viewerRPTVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()
        MyBase.New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        pdfExportado = False
    End Sub
    Private Sub exportPDF()
        Dim exportPath As String = "C:\\Users\\Puesto\\Desktop"
        If Not System.IO.Directory.Exists(exportPath) Then
            System.IO.Directory.CreateDirectory(exportPath)
        End If
        MessageBox.Show("TRAZA: Dirección válida")
        Dim dirGuardado As String = "C:\Users\Puesto\Desktop\reporteExportado.pdf"
        Dim reportDocument As New ReportDocument
        'reportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, dirGuardado)
        pdfExportado = True
    End Sub
    Private Sub sendCorreo(smtpP As SmtpClient, correoRemitente As String, correoDestinatario As String)
        Dim correo As New MailMessage(correoRemitente, correoDestinatario)
        correo.Subject = "Informe Crystal Reports"
        correo.Body = "Adjunto encontrarás el informe que solicitaste."
        'Dim adjunto As New Attachment("C:\\Users\\Puesto\\Desktop\\reporteExportado.pdf")
        'correo.Attachments.Add(adjunto)

        smtpP.Send(correo)
        'adjunto.Dispose()
    End Sub
    Private Sub click_btn_enviar_correo(sender As Object, e As EventArgs) Handles btn_enviar_correo.Click
        exportPDF()

        If pdfExportado Then
            Dim correoDestinatario As String = "locitronki@gmail.com"
            Dim correoRemitente As String = "locitronki2@gmail.com"

            Dim smtp As New SmtpClient()
            smtp.Host = "smtp-relay.gmail.com"
            smtp.Port = 587
            smtp.Credentials = New System.Net.NetworkCredential("locitronki2@gmail.com", "Lusalo_96")
            smtp.EnableSsl = True

            sendCorreo(smtp, correoRemitente, correoDestinatario)
        End If
    End Sub
End Class
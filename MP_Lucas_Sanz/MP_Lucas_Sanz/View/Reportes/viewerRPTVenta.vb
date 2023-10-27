Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class viewerRPTVenta

    Dim pdfExportado As Boolean = False
    Dim report As rptVenta
    Dim venta As Venta
    Dim exportedFile As String
    Dim clienteFind As Cliente

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        pdfExportado = False
    End Sub
    Public Sub New(reportP As rptVenta, ventaP As Venta)
        MyBase.New()
        InitializeComponent()

        report = reportP
        venta = ventaP
        clienteFind = VariablesGlobales.getClientePorCodigo(venta.ClienteDeVenta)
        pdfExportado = False
    End Sub

    Private Sub exportPDF()
        Dim exportPath As String = "C:\Users\Puesto\Desktop\Reportes\Ventas\"
        exportedFile = exportPath + venta.FacturaDeVenta + ".pdf"
        If Not System.IO.Directory.Exists(exportPath) Then
            System.IO.Directory.CreateDirectory(exportPath)
        End If
        Try
            Dim cExportOptions As ExportOptions
            Dim cFinalDestination As New DiskFileDestinationOptions
            Dim cFormatOptions As New PdfRtfWordFormatOptions

            cFinalDestination.DiskFileName = exportedFile
            cExportOptions = report.ExportOptions

            With cExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .ExportDestinationOptions = cFinalDestination
                .ExportFormatOptions = cFormatOptions
            End With
            report.Export()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        pdfExportado = True
    End Sub
    Private Sub sendEmail()
        If Not pdfExportado Then
            MessageBox.Show("PDF NO GENERADO")
            Return
        End If
        Dim pdfFilePath As String = exportedFile
        Dim pdfAttachment As New Attachment(pdfFilePath, MediaTypeNames.Application.Pdf)
        pdfAttachment.Name = venta.FacturaDeVenta

        Dim fromAddress As New MailAddress("locitronki@gmail.com", "Lucas")
        Dim toAddress As New MailAddress("locitronki2@gmail.com", "Lucas 2")
        Dim subject As String = $"Factura: {venta.FacturaDeVenta}"
        Dim body As String = $"Hola {clienteFind.NombreDelCliente}, aquí tienes tu factura número {venta.FacturaDeVenta} con fecha {venta.FechaDeVenta.ToString("dd/MM/yyyy")}"

        Dim smtpClient As New SmtpClient()
        smtpClient.Host = "smtp.gmail.com"
        smtpClient.Port = 587
        smtpClient.UseDefaultCredentials = False
        smtpClient.Credentials = New NetworkCredential("locitronki@gmail.com", "ljjq nlph vrjf renj")
        smtpClient.EnableSsl = True

        Dim mailMessage As New MailMessage(fromAddress, toAddress)
        mailMessage.Subject = subject
        mailMessage.Body = body
        mailMessage.Attachments.Add(pdfAttachment)
        Try
            smtpClient.Send(mailMessage)
            MessageBox.Show("Correo enviado exitosamente.")
        Catch ex As Exception
            MessageBox.Show("Error al enviar el correo: " & ex.ToString())
        End Try
    End Sub

    Private Sub click_btn_enviar_correo_venta(sender As Object, e As EventArgs) Handles btn_enviar_correo_venta.Click
        exportPDF()
        sendEmail()
    End Sub
    Private Sub click_btn_guardar_venta_pdf(sender As Object, e As EventArgs) Handles btn_guardar_venta_pdf.Click
        exportPDF()
    End Sub

    Private Sub viewerRPTVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
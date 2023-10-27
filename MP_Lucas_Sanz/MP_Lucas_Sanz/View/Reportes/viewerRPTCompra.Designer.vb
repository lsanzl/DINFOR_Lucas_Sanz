<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewerRPTCompra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewerRPTCompra))
        Me.crvCompra = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btn_guardar_compra_pdf = New System.Windows.Forms.Button()
        Me.btn_enviar_correo_compra = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'crvCompra
        '
        Me.crvCompra.ActiveViewIndex = -1
        Me.crvCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvCompra.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvCompra.DisplayStatusBar = False
        Me.crvCompra.DisplayToolbar = False
        Me.crvCompra.EnableToolTips = False
        Me.crvCompra.Location = New System.Drawing.Point(90, 0)
        Me.crvCompra.Name = "crvCompra"
        Me.crvCompra.Size = New System.Drawing.Size(711, 451)
        Me.crvCompra.TabIndex = 0
        '
        'btn_guardar_compra_pdf
        '
        Me.btn_guardar_compra_pdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar_compra_pdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_compra_pdf.Location = New System.Drawing.Point(5, 25)
        Me.btn_guardar_compra_pdf.Name = "btn_guardar_compra_pdf"
        Me.btn_guardar_compra_pdf.Size = New System.Drawing.Size(79, 40)
        Me.btn_guardar_compra_pdf.TabIndex = 4
        Me.btn_guardar_compra_pdf.Text = "Guardar PDF"
        Me.btn_guardar_compra_pdf.UseVisualStyleBackColor = True
        '
        'btn_enviar_correo_compra
        '
        Me.btn_enviar_correo_compra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_enviar_correo_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enviar_correo_compra.Location = New System.Drawing.Point(5, 71)
        Me.btn_enviar_correo_compra.Name = "btn_enviar_correo_compra"
        Me.btn_enviar_correo_compra.Size = New System.Drawing.Size(79, 40)
        Me.btn_enviar_correo_compra.TabIndex = 3
        Me.btn_enviar_correo_compra.Text = "Enviar Correo"
        Me.btn_enviar_correo_compra.UseVisualStyleBackColor = True
        '
        'viewerRPTCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_guardar_compra_pdf)
        Me.Controls.Add(Me.btn_enviar_correo_compra)
        Me.Controls.Add(Me.crvCompra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "viewerRPTCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvCompra As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btn_guardar_compra_pdf As Button
    Friend WithEvents btn_enviar_correo_compra As Button
End Class

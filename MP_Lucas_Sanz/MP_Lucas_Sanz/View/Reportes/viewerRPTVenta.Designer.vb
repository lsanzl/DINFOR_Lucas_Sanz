<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewerRPTVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewerRPTVenta))
        Me.crvVenta = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btn_enviar_correo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'crvVenta
        '
        Me.crvVenta.ActiveViewIndex = -1
        Me.crvVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvVenta.DisplayStatusBar = False
        Me.crvVenta.Location = New System.Drawing.Point(91, -1)
        Me.crvVenta.Name = "crvVenta"
        Me.crvVenta.Size = New System.Drawing.Size(711, 451)
        Me.crvVenta.TabIndex = 0
        '
        'btn_enviar_correo
        '
        Me.btn_enviar_correo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_enviar_correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enviar_correo.Location = New System.Drawing.Point(10, 398)
        Me.btn_enviar_correo.Name = "btn_enviar_correo"
        Me.btn_enviar_correo.Size = New System.Drawing.Size(75, 40)
        Me.btn_enviar_correo.TabIndex = 1
        Me.btn_enviar_correo.Text = "Enviar Correo"
        Me.btn_enviar_correo.UseVisualStyleBackColor = True
        '
        'viewerRPTVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_enviar_correo)
        Me.Controls.Add(Me.crvVenta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "viewerRPTVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvVenta As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btn_enviar_correo As Button
End Class

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
        Me.SuspendLayout()
        '
        'crvCompra
        '
        Me.crvCompra.ActiveViewIndex = -1
        Me.crvCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvCompra.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvCompra.Location = New System.Drawing.Point(0, 0)
        Me.crvCompra.Name = "crvCompra"
        Me.crvCompra.Size = New System.Drawing.Size(800, 450)
        Me.crvCompra.TabIndex = 0
        '
        'viewerRPTCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.crvCompra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "viewerRPTCompra"
        Me.Text = "rptCompra"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvCompra As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

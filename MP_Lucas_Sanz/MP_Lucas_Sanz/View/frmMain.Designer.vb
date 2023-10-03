<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.tab_main = New System.Windows.Forms.TabControl()
        Me.tab_bancos = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tab_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_main
        '
        Me.tab_main.Controls.Add(Me.tab_bancos)
        Me.tab_main.Controls.Add(Me.TabPage2)
        Me.tab_main.Location = New System.Drawing.Point(1, 2)
        Me.tab_main.Name = "tab_main"
        Me.tab_main.SelectedIndex = 0
        Me.tab_main.Size = New System.Drawing.Size(799, 449)
        Me.tab_main.TabIndex = 1
        '
        'tab_bancos
        '
        Me.tab_bancos.Location = New System.Drawing.Point(4, 22)
        Me.tab_bancos.Name = "tab_bancos"
        Me.tab_bancos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_bancos.Size = New System.Drawing.Size(791, 423)
        Me.tab_bancos.TabIndex = 0
        Me.tab_bancos.Text = "BANCOS"
        Me.tab_bancos.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(791, 423)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tab_main)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tab_main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_main As TabControl
    Friend WithEvents tab_bancos As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class

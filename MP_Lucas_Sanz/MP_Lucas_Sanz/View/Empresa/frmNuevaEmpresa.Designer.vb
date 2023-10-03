<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNuevaEmpresa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_nueva_empresa = New System.Windows.Forms.TextBox()
        Me.lbl_nueva_empresa = New System.Windows.Forms.Label()
        Me.btn_confirmar_nueva_empresa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_nueva_empresa
        '
        Me.txt_nueva_empresa.Location = New System.Drawing.Point(189, 18)
        Me.txt_nueva_empresa.Name = "txt_nueva_empresa"
        Me.txt_nueva_empresa.Size = New System.Drawing.Size(237, 20)
        Me.txt_nueva_empresa.TabIndex = 3
        '
        'lbl_nueva_empresa
        '
        Me.lbl_nueva_empresa.AutoSize = True
        Me.lbl_nueva_empresa.Location = New System.Drawing.Point(28, 21)
        Me.lbl_nueva_empresa.Name = "lbl_nueva_empresa"
        Me.lbl_nueva_empresa.Size = New System.Drawing.Size(109, 13)
        Me.lbl_nueva_empresa.TabIndex = 2
        Me.lbl_nueva_empresa.Text = "Nombre de Empresa: "
        '
        'btn_confirmar_nueva_empresa
        '
        Me.btn_confirmar_nueva_empresa.Location = New System.Drawing.Point(351, 63)
        Me.btn_confirmar_nueva_empresa.Name = "btn_confirmar_nueva_empresa"
        Me.btn_confirmar_nueva_empresa.Size = New System.Drawing.Size(75, 23)
        Me.btn_confirmar_nueva_empresa.TabIndex = 4
        Me.btn_confirmar_nueva_empresa.Text = "Confirmar"
        Me.btn_confirmar_nueva_empresa.UseVisualStyleBackColor = True
        '
        'frmNuevaEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 98)
        Me.Controls.Add(Me.btn_confirmar_nueva_empresa)
        Me.Controls.Add(Me.txt_nueva_empresa)
        Me.Controls.Add(Me.lbl_nueva_empresa)
        Me.Name = "frmNuevaEmpresa"
        Me.Text = "frmNuevaEmpresa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nueva_empresa As TextBox
    Friend WithEvents lbl_nueva_empresa As Label
    Friend WithEvents btn_confirmar_nueva_empresa As Button
End Class

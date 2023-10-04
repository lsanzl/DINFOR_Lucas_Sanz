<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoNombreEmpresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoNombreEmpresa))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nuevo_nombre_empresa = New System.Windows.Forms.TextBox()
        Me.btn_confirmar_nuevo_nombre = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nuevo nombre de empresa: "
        '
        'txt_nuevo_nombre_empresa
        '
        Me.txt_nuevo_nombre_empresa.Location = New System.Drawing.Point(185, 27)
        Me.txt_nuevo_nombre_empresa.Name = "txt_nuevo_nombre_empresa"
        Me.txt_nuevo_nombre_empresa.Size = New System.Drawing.Size(237, 20)
        Me.txt_nuevo_nombre_empresa.TabIndex = 1
        '
        'btn_confirmar_nuevo_nombre
        '
        Me.btn_confirmar_nuevo_nombre.Location = New System.Drawing.Point(347, 63)
        Me.btn_confirmar_nuevo_nombre.Name = "btn_confirmar_nuevo_nombre"
        Me.btn_confirmar_nuevo_nombre.Size = New System.Drawing.Size(75, 23)
        Me.btn_confirmar_nuevo_nombre.TabIndex = 2
        Me.btn_confirmar_nuevo_nombre.Text = "Confirmar"
        Me.btn_confirmar_nuevo_nombre.UseVisualStyleBackColor = True
        '
        'frmNuevoNombreEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 98)
        Me.Controls.Add(Me.btn_confirmar_nuevo_nombre)
        Me.Controls.Add(Me.txt_nuevo_nombre_empresa)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNuevoNombreEmpresa"
        Me.Text = "frmNuevoNombreEmpresa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nuevo_nombre_empresa As TextBox
    Friend WithEvents btn_confirmar_nuevo_nombre As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoCliente))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_codigo_cliente = New System.Windows.Forms.Label()
        Me.lbl_nombre_cliente = New System.Windows.Forms.Label()
        Me.lbl_nif_cliente = New System.Windows.Forms.Label()
        Me.lbl_direccion_cliente = New System.Windows.Forms.Label()
        Me.lbl_email_cliente = New System.Windows.Forms.Label()
        Me.lbl_fecha_nacimiento_cliente = New System.Windows.Forms.Label()
        Me.lbl_banco_cliente = New System.Windows.Forms.Label()
        Me.lbl_grupo_cliente = New System.Windows.Forms.Label()
        Me.txt_codigo_cliente = New System.Windows.Forms.TextBox()
        Me.txt_nombre_cliente = New System.Windows.Forms.TextBox()
        Me.txt_nif_cliente = New System.Windows.Forms.TextBox()
        Me.txt_direccion_cliente = New System.Windows.Forms.TextBox()
        Me.txt_email_cliente = New System.Windows.Forms.TextBox()
        Me.dp_fecha_nacimiento_cliente = New System.Windows.Forms.DateTimePicker()
        Me.cb_banco_cliente = New System.Windows.Forms.ComboBox()
        Me.cb_grupo_cliente = New System.Windows.Forms.ComboBox()
        Me.btn_confirmar_cliente = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_codigo_cliente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_nombre_cliente, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_nif_cliente, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_direccion_cliente, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_email_cliente, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_fecha_nacimiento_cliente, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_banco_cliente, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_grupo_cliente, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_codigo_cliente, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_nombre_cliente, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_nif_cliente, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_direccion_cliente, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_email_cliente, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.dp_fecha_nacimiento_cliente, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_banco_cliente, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_grupo_cliente, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_confirmar_cliente, 3, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(776, 191)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbl_codigo_cliente
        '
        Me.lbl_codigo_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_codigo_cliente.AutoSize = True
        Me.lbl_codigo_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo_cliente.Location = New System.Drawing.Point(3, 12)
        Me.lbl_codigo_cliente.Name = "lbl_codigo_cliente"
        Me.lbl_codigo_cliente.Size = New System.Drawing.Size(65, 13)
        Me.lbl_codigo_cliente.TabIndex = 0
        Me.lbl_codigo_cliente.Text = "Código:"
        Me.lbl_codigo_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_nombre_cliente
        '
        Me.lbl_nombre_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nombre_cliente.AutoSize = True
        Me.lbl_nombre_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_cliente.Location = New System.Drawing.Point(3, 50)
        Me.lbl_nombre_cliente.Name = "lbl_nombre_cliente"
        Me.lbl_nombre_cliente.Size = New System.Drawing.Size(65, 13)
        Me.lbl_nombre_cliente.TabIndex = 1
        Me.lbl_nombre_cliente.Text = "Nombre:"
        Me.lbl_nombre_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_nif_cliente
        '
        Me.lbl_nif_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nif_cliente.AutoSize = True
        Me.lbl_nif_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nif_cliente.Location = New System.Drawing.Point(3, 88)
        Me.lbl_nif_cliente.Name = "lbl_nif_cliente"
        Me.lbl_nif_cliente.Size = New System.Drawing.Size(65, 13)
        Me.lbl_nif_cliente.TabIndex = 2
        Me.lbl_nif_cliente.Text = "NIF:"
        Me.lbl_nif_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_direccion_cliente
        '
        Me.lbl_direccion_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_direccion_cliente.AutoSize = True
        Me.lbl_direccion_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion_cliente.Location = New System.Drawing.Point(3, 126)
        Me.lbl_direccion_cliente.Name = "lbl_direccion_cliente"
        Me.lbl_direccion_cliente.Size = New System.Drawing.Size(65, 13)
        Me.lbl_direccion_cliente.TabIndex = 3
        Me.lbl_direccion_cliente.Text = "Dirección:"
        Me.lbl_direccion_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_email_cliente
        '
        Me.lbl_email_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_email_cliente.AutoSize = True
        Me.lbl_email_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email_cliente.Location = New System.Drawing.Point(3, 165)
        Me.lbl_email_cliente.Name = "lbl_email_cliente"
        Me.lbl_email_cliente.Size = New System.Drawing.Size(65, 13)
        Me.lbl_email_cliente.TabIndex = 4
        Me.lbl_email_cliente.Text = "Email:"
        Me.lbl_email_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_fecha_nacimiento_cliente
        '
        Me.lbl_fecha_nacimiento_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_fecha_nacimiento_cliente.AutoSize = True
        Me.lbl_fecha_nacimiento_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha_nacimiento_cliente.Location = New System.Drawing.Point(333, 12)
        Me.lbl_fecha_nacimiento_cliente.Name = "lbl_fecha_nacimiento_cliente"
        Me.lbl_fecha_nacimiento_cliente.Size = New System.Drawing.Size(113, 13)
        Me.lbl_fecha_nacimiento_cliente.TabIndex = 5
        Me.lbl_fecha_nacimiento_cliente.Text = "Fecha Nacimiento:"
        Me.lbl_fecha_nacimiento_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_banco_cliente
        '
        Me.lbl_banco_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_banco_cliente.AutoSize = True
        Me.lbl_banco_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_banco_cliente.Location = New System.Drawing.Point(333, 50)
        Me.lbl_banco_cliente.Name = "lbl_banco_cliente"
        Me.lbl_banco_cliente.Size = New System.Drawing.Size(113, 13)
        Me.lbl_banco_cliente.TabIndex = 6
        Me.lbl_banco_cliente.Text = "Banco:"
        Me.lbl_banco_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_grupo_cliente
        '
        Me.lbl_grupo_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_grupo_cliente.AutoSize = True
        Me.lbl_grupo_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grupo_cliente.Location = New System.Drawing.Point(333, 88)
        Me.lbl_grupo_cliente.Name = "lbl_grupo_cliente"
        Me.lbl_grupo_cliente.Size = New System.Drawing.Size(113, 13)
        Me.lbl_grupo_cliente.TabIndex = 7
        Me.lbl_grupo_cliente.Text = "Grupo:"
        Me.lbl_grupo_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_codigo_cliente
        '
        Me.txt_codigo_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_codigo_cliente.Location = New System.Drawing.Point(74, 9)
        Me.txt_codigo_cliente.Name = "txt_codigo_cliente"
        Me.txt_codigo_cliente.Size = New System.Drawing.Size(253, 20)
        Me.txt_codigo_cliente.TabIndex = 8
        '
        'txt_nombre_cliente
        '
        Me.txt_nombre_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre_cliente.Location = New System.Drawing.Point(74, 47)
        Me.txt_nombre_cliente.Name = "txt_nombre_cliente"
        Me.txt_nombre_cliente.Size = New System.Drawing.Size(253, 20)
        Me.txt_nombre_cliente.TabIndex = 9
        '
        'txt_nif_cliente
        '
        Me.txt_nif_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nif_cliente.Location = New System.Drawing.Point(74, 85)
        Me.txt_nif_cliente.Name = "txt_nif_cliente"
        Me.txt_nif_cliente.Size = New System.Drawing.Size(253, 20)
        Me.txt_nif_cliente.TabIndex = 10
        '
        'txt_direccion_cliente
        '
        Me.txt_direccion_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_direccion_cliente.Location = New System.Drawing.Point(74, 123)
        Me.txt_direccion_cliente.Name = "txt_direccion_cliente"
        Me.txt_direccion_cliente.Size = New System.Drawing.Size(253, 20)
        Me.txt_direccion_cliente.TabIndex = 11
        '
        'txt_email_cliente
        '
        Me.txt_email_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_email_cliente.Location = New System.Drawing.Point(74, 161)
        Me.txt_email_cliente.Name = "txt_email_cliente"
        Me.txt_email_cliente.Size = New System.Drawing.Size(253, 20)
        Me.txt_email_cliente.TabIndex = 12
        '
        'dp_fecha_nacimiento_cliente
        '
        Me.dp_fecha_nacimiento_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_fecha_nacimiento_cliente.Location = New System.Drawing.Point(452, 9)
        Me.dp_fecha_nacimiento_cliente.Name = "dp_fecha_nacimiento_cliente"
        Me.dp_fecha_nacimiento_cliente.Size = New System.Drawing.Size(321, 20)
        Me.dp_fecha_nacimiento_cliente.TabIndex = 13
        '
        'cb_banco_cliente
        '
        Me.cb_banco_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_banco_cliente.FormattingEnabled = True
        Me.cb_banco_cliente.Location = New System.Drawing.Point(452, 46)
        Me.cb_banco_cliente.Name = "cb_banco_cliente"
        Me.cb_banco_cliente.Size = New System.Drawing.Size(321, 21)
        Me.cb_banco_cliente.TabIndex = 14
        '
        'cb_grupo_cliente
        '
        Me.cb_grupo_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_grupo_cliente.FormattingEnabled = True
        Me.cb_grupo_cliente.Location = New System.Drawing.Point(452, 84)
        Me.cb_grupo_cliente.Name = "cb_grupo_cliente"
        Me.cb_grupo_cliente.Size = New System.Drawing.Size(321, 21)
        Me.cb_grupo_cliente.TabIndex = 15
        '
        'btn_confirmar_cliente
        '
        Me.btn_confirmar_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_confirmar_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar_cliente.Location = New System.Drawing.Point(452, 160)
        Me.btn_confirmar_cliente.Name = "btn_confirmar_cliente"
        Me.btn_confirmar_cliente.Size = New System.Drawing.Size(321, 23)
        Me.btn_confirmar_cliente.TabIndex = 16
        Me.btn_confirmar_cliente.Text = "Confirmar"
        Me.btn_confirmar_cliente.UseVisualStyleBackColor = True
        '
        'frmNuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 215)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevoCliente"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmNuevoCliente"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_codigo_cliente As Label
    Friend WithEvents lbl_nombre_cliente As Label
    Friend WithEvents lbl_nif_cliente As Label
    Friend WithEvents lbl_direccion_cliente As Label
    Friend WithEvents lbl_email_cliente As Label
    Friend WithEvents lbl_fecha_nacimiento_cliente As Label
    Friend WithEvents lbl_banco_cliente As Label
    Friend WithEvents lbl_grupo_cliente As Label
    Friend WithEvents txt_codigo_cliente As TextBox
    Friend WithEvents txt_nombre_cliente As TextBox
    Friend WithEvents txt_nif_cliente As TextBox
    Friend WithEvents txt_direccion_cliente As TextBox
    Friend WithEvents txt_email_cliente As TextBox
    Friend WithEvents dp_fecha_nacimiento_cliente As DateTimePicker
    Friend WithEvents cb_banco_cliente As ComboBox
    Friend WithEvents cb_grupo_cliente As ComboBox
    Friend WithEvents btn_confirmar_cliente As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaFormaPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevaFormaPago))
        Me.checkb_estado_forma_pago = New System.Windows.Forms.CheckBox()
        Me.txt_codigo_forma_pago = New System.Windows.Forms.TextBox()
        Me.txt_nombre_forma_pago = New System.Windows.Forms.TextBox()
        Me.txt_numero_plazos = New System.Windows.Forms.TextBox()
        Me.lbl_codigo_forma_pago = New System.Windows.Forms.Label()
        Me.lbl_nombre_forma_pago = New System.Windows.Forms.Label()
        Me.lbl_num_plazos = New System.Windows.Forms.Label()
        Me.lbl_primer_plazo = New System.Windows.Forms.Label()
        Me.lbl_dias_entre_plazos = New System.Windows.Forms.Label()
        Me.lbl_banco_asignado = New System.Windows.Forms.Label()
        Me.cb_banco_asignado = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_confirmar_forma_pago = New System.Windows.Forms.Button()
        Me.txt_dias_primer_plazo = New System.Windows.Forms.TextBox()
        Me.txt_dias_entre_plazos = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'checkb_estado_forma_pago
        '
        Me.checkb_estado_forma_pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkb_estado_forma_pago.AutoSize = True
        Me.checkb_estado_forma_pago.Location = New System.Drawing.Point(561, 38)
        Me.checkb_estado_forma_pago.Name = "checkb_estado_forma_pago"
        Me.checkb_estado_forma_pago.Size = New System.Drawing.Size(250, 17)
        Me.checkb_estado_forma_pago.TabIndex = 0
        Me.checkb_estado_forma_pago.Text = "Activado"
        Me.checkb_estado_forma_pago.UseVisualStyleBackColor = True
        '
        'txt_codigo_forma_pago
        '
        Me.txt_codigo_forma_pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_codigo_forma_pago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_codigo_forma_pago.Location = New System.Drawing.Point(63, 5)
        Me.txt_codigo_forma_pago.Name = "txt_codigo_forma_pago"
        Me.txt_codigo_forma_pago.Size = New System.Drawing.Size(233, 20)
        Me.txt_codigo_forma_pago.TabIndex = 1
        '
        'txt_nombre_forma_pago
        '
        Me.txt_nombre_forma_pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre_forma_pago.Location = New System.Drawing.Point(63, 36)
        Me.txt_nombre_forma_pago.Name = "txt_nombre_forma_pago"
        Me.txt_nombre_forma_pago.Size = New System.Drawing.Size(233, 20)
        Me.txt_nombre_forma_pago.TabIndex = 2
        '
        'txt_numero_plazos
        '
        Me.txt_numero_plazos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_numero_plazos.Location = New System.Drawing.Point(63, 67)
        Me.txt_numero_plazos.Name = "txt_numero_plazos"
        Me.txt_numero_plazos.Size = New System.Drawing.Size(233, 20)
        Me.txt_numero_plazos.TabIndex = 4
        '
        'lbl_codigo_forma_pago
        '
        Me.lbl_codigo_forma_pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_codigo_forma_pago.AutoSize = True
        Me.lbl_codigo_forma_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo_forma_pago.Location = New System.Drawing.Point(3, 9)
        Me.lbl_codigo_forma_pago.Name = "lbl_codigo_forma_pago"
        Me.lbl_codigo_forma_pago.Size = New System.Drawing.Size(54, 13)
        Me.lbl_codigo_forma_pago.TabIndex = 6
        Me.lbl_codigo_forma_pago.Text = "Código:"
        Me.lbl_codigo_forma_pago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_nombre_forma_pago
        '
        Me.lbl_nombre_forma_pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nombre_forma_pago.AutoSize = True
        Me.lbl_nombre_forma_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_forma_pago.Location = New System.Drawing.Point(3, 40)
        Me.lbl_nombre_forma_pago.Name = "lbl_nombre_forma_pago"
        Me.lbl_nombre_forma_pago.Size = New System.Drawing.Size(54, 13)
        Me.lbl_nombre_forma_pago.TabIndex = 7
        Me.lbl_nombre_forma_pago.Text = "Nombre:"
        Me.lbl_nombre_forma_pago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_num_plazos
        '
        Me.lbl_num_plazos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_num_plazos.AutoSize = True
        Me.lbl_num_plazos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_num_plazos.Location = New System.Drawing.Point(3, 71)
        Me.lbl_num_plazos.Name = "lbl_num_plazos"
        Me.lbl_num_plazos.Size = New System.Drawing.Size(54, 13)
        Me.lbl_num_plazos.TabIndex = 8
        Me.lbl_num_plazos.Text = "Plazos:"
        Me.lbl_num_plazos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_primer_plazo
        '
        Me.lbl_primer_plazo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_primer_plazo.AutoSize = True
        Me.lbl_primer_plazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_primer_plazo.Location = New System.Drawing.Point(302, 71)
        Me.lbl_primer_plazo.Name = "lbl_primer_plazo"
        Me.lbl_primer_plazo.Size = New System.Drawing.Size(80, 13)
        Me.lbl_primer_plazo.TabIndex = 9
        Me.lbl_primer_plazo.Text = "Primer plazo:"
        Me.lbl_primer_plazo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_dias_entre_plazos
        '
        Me.lbl_dias_entre_plazos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_dias_entre_plazos.AutoSize = True
        Me.lbl_dias_entre_plazos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dias_entre_plazos.Location = New System.Drawing.Point(494, 71)
        Me.lbl_dias_entre_plazos.Name = "lbl_dias_entre_plazos"
        Me.lbl_dias_entre_plazos.Size = New System.Drawing.Size(61, 13)
        Me.lbl_dias_entre_plazos.TabIndex = 10
        Me.lbl_dias_entre_plazos.Text = "Intervalo:"
        Me.lbl_dias_entre_plazos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_banco_asignado
        '
        Me.lbl_banco_asignado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_banco_asignado.AutoSize = True
        Me.lbl_banco_asignado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_banco_asignado.Location = New System.Drawing.Point(494, 9)
        Me.lbl_banco_asignado.Name = "lbl_banco_asignado"
        Me.lbl_banco_asignado.Size = New System.Drawing.Size(61, 13)
        Me.lbl_banco_asignado.TabIndex = 11
        Me.lbl_banco_asignado.Text = "Banco:"
        Me.lbl_banco_asignado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cb_banco_asignado
        '
        Me.cb_banco_asignado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_banco_asignado.FormattingEnabled = True
        Me.cb_banco_asignado.Location = New System.Drawing.Point(561, 5)
        Me.cb_banco_asignado.Name = "cb_banco_asignado"
        Me.cb_banco_asignado.Size = New System.Drawing.Size(250, 21)
        Me.cb_banco_asignado.TabIndex = 12
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.checkb_estado_forma_pago, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_dias_entre_plazos, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_numero_plazos, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_banco_asignado, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_codigo_forma_pago, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_banco_asignado, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_nombre_forma_pago, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_primer_plazo, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_nombre_forma_pago, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_codigo_forma_pago, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_num_plazos, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_dias_primer_plazo, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_dias_entre_plazos, 5, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(14, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(814, 93)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'btn_confirmar_forma_pago
        '
        Me.btn_confirmar_forma_pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_confirmar_forma_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar_forma_pago.Location = New System.Drawing.Point(742, 111)
        Me.btn_confirmar_forma_pago.Name = "btn_confirmar_forma_pago"
        Me.btn_confirmar_forma_pago.Size = New System.Drawing.Size(87, 23)
        Me.btn_confirmar_forma_pago.TabIndex = 14
        Me.btn_confirmar_forma_pago.Text = "Confirmar"
        Me.btn_confirmar_forma_pago.UseVisualStyleBackColor = True
        '
        'txt_dias_primer_plazo
        '
        Me.txt_dias_primer_plazo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_dias_primer_plazo.Location = New System.Drawing.Point(388, 67)
        Me.txt_dias_primer_plazo.Name = "txt_dias_primer_plazo"
        Me.txt_dias_primer_plazo.Size = New System.Drawing.Size(100, 20)
        Me.txt_dias_primer_plazo.TabIndex = 13
        '
        'txt_dias_entre_plazos
        '
        Me.txt_dias_entre_plazos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_dias_entre_plazos.Location = New System.Drawing.Point(561, 67)
        Me.txt_dias_entre_plazos.Name = "txt_dias_entre_plazos"
        Me.txt_dias_entre_plazos.Size = New System.Drawing.Size(250, 20)
        Me.txt_dias_entre_plazos.TabIndex = 14
        '
        'frmNuevaFormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 142)
        Me.Controls.Add(Me.btn_confirmar_forma_pago)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevaFormaPago"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Formulario Forma de Pago"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents checkb_estado_forma_pago As CheckBox
    Friend WithEvents txt_codigo_forma_pago As TextBox
    Friend WithEvents txt_nombre_forma_pago As TextBox
    Friend WithEvents txt_numero_plazos As TextBox
    Friend WithEvents lbl_codigo_forma_pago As Label
    Friend WithEvents lbl_nombre_forma_pago As Label
    Friend WithEvents lbl_num_plazos As Label
    Friend WithEvents lbl_primer_plazo As Label
    Friend WithEvents lbl_dias_entre_plazos As Label
    Friend WithEvents lbl_banco_asignado As Label
    Friend WithEvents cb_banco_asignado As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_confirmar_forma_pago As Button
    Friend WithEvents txt_dias_primer_plazo As TextBox
    Friend WithEvents txt_dias_entre_plazos As TextBox
End Class

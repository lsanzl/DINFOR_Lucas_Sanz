<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCobroParcial
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_importe_pendiente = New System.Windows.Forms.Label()
        Me.txt_pago_pacial = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_confirmar_pago_parcial = New System.Windows.Forms.Button()
        Me.btn_cancelar_pago_parcial = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_importe_pendiente, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_pago_pacial, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(248, 195)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pago"
        '
        'lbl_importe_pendiente
        '
        Me.lbl_importe_pendiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_importe_pendiente.AutoSize = True
        Me.lbl_importe_pendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_importe_pendiente.Location = New System.Drawing.Point(15, 37)
        Me.lbl_importe_pendiente.Margin = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.lbl_importe_pendiente.Name = "lbl_importe_pendiente"
        Me.lbl_importe_pendiente.Size = New System.Drawing.Size(218, 13)
        Me.lbl_importe_pendiente.TabIndex = 0
        Me.lbl_importe_pendiente.Text = "Importe pendiente:"
        '
        'txt_pago_pacial
        '
        Me.txt_pago_pacial.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_pago_pacial.Location = New System.Drawing.Point(15, 96)
        Me.txt_pago_pacial.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.txt_pago_pacial.Name = "txt_pago_pacial"
        Me.txt_pago_pacial.Size = New System.Drawing.Size(156, 20)
        Me.txt_pago_pacial.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btn_confirmar_pago_parcial, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_cancelar_pago_parcial, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 129)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(242, 33)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'btn_confirmar_pago_parcial
        '
        Me.btn_confirmar_pago_parcial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_confirmar_pago_parcial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar_pago_parcial.Location = New System.Drawing.Point(136, 5)
        Me.btn_confirmar_pago_parcial.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.btn_confirmar_pago_parcial.Name = "btn_confirmar_pago_parcial"
        Me.btn_confirmar_pago_parcial.Size = New System.Drawing.Size(91, 23)
        Me.btn_confirmar_pago_parcial.TabIndex = 1
        Me.btn_confirmar_pago_parcial.Text = "CONFIRMAR"
        Me.btn_confirmar_pago_parcial.UseVisualStyleBackColor = True
        '
        'btn_cancelar_pago_parcial
        '
        Me.btn_cancelar_pago_parcial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar_pago_parcial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar_pago_parcial.Location = New System.Drawing.Point(15, 5)
        Me.btn_cancelar_pago_parcial.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.btn_cancelar_pago_parcial.Name = "btn_cancelar_pago_parcial"
        Me.btn_cancelar_pago_parcial.Size = New System.Drawing.Size(91, 23)
        Me.btn_cancelar_pago_parcial.TabIndex = 0
        Me.btn_cancelar_pago_parcial.Text = "CANCELAR"
        Me.btn_cancelar_pago_parcial.UseVisualStyleBackColor = True
        '
        'frmCobroParcial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 195)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCobroParcial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmCobroParcial"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_importe_pendiente As Label
    Friend WithEvents txt_pago_pacial As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btn_cancelar_pago_parcial As Button
    Friend WithEvents btn_confirmar_pago_parcial As Button
End Class

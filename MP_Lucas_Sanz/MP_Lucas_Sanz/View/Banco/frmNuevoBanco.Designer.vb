<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoBanco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoBanco))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_nombre_banco = New System.Windows.Forms.Label()
        Me.lbl_codigo_banco = New System.Windows.Forms.Label()
        Me.txt_nombre_banco = New System.Windows.Forms.TextBox()
        Me.txt_codigo_banco = New System.Windows.Forms.TextBox()
        Me.btn_confirmar_nuevo_banco = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_nombre_banco, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_codigo_banco, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_nombre_banco, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_codigo_banco, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(423, 85)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'lbl_nombre_banco
        '
        Me.lbl_nombre_banco.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nombre_banco.AutoSize = True
        Me.lbl_nombre_banco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_banco.Location = New System.Drawing.Point(3, 0)
        Me.lbl_nombre_banco.Name = "lbl_nombre_banco"
        Me.lbl_nombre_banco.Size = New System.Drawing.Size(142, 42)
        Me.lbl_nombre_banco.TabIndex = 0
        Me.lbl_nombre_banco.Text = "Nombre del Banco:"
        Me.lbl_nombre_banco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_codigo_banco
        '
        Me.lbl_codigo_banco.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_codigo_banco.AutoSize = True
        Me.lbl_codigo_banco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo_banco.Location = New System.Drawing.Point(3, 42)
        Me.lbl_codigo_banco.Name = "lbl_codigo_banco"
        Me.lbl_codigo_banco.Size = New System.Drawing.Size(142, 43)
        Me.lbl_codigo_banco.TabIndex = 1
        Me.lbl_codigo_banco.Text = "Código del Banco:"
        Me.lbl_codigo_banco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_nombre_banco
        '
        Me.txt_nombre_banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre_banco.Location = New System.Drawing.Point(151, 11)
        Me.txt_nombre_banco.Name = "txt_nombre_banco"
        Me.txt_nombre_banco.Size = New System.Drawing.Size(269, 20)
        Me.txt_nombre_banco.TabIndex = 2
        '
        'txt_codigo_banco
        '
        Me.txt_codigo_banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_codigo_banco.Location = New System.Drawing.Point(151, 53)
        Me.txt_codigo_banco.Name = "txt_codigo_banco"
        Me.txt_codigo_banco.Size = New System.Drawing.Size(269, 20)
        Me.txt_codigo_banco.TabIndex = 3
        '
        'btn_confirmar_nuevo_banco
        '
        Me.btn_confirmar_nuevo_banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_confirmar_nuevo_banco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar_nuevo_banco.Location = New System.Drawing.Point(360, 103)
        Me.btn_confirmar_nuevo_banco.Name = "btn_confirmar_nuevo_banco"
        Me.btn_confirmar_nuevo_banco.Size = New System.Drawing.Size(75, 23)
        Me.btn_confirmar_nuevo_banco.TabIndex = 2
        Me.btn_confirmar_nuevo_banco.Text = "Confirmar"
        Me.btn_confirmar_nuevo_banco.UseVisualStyleBackColor = True
        '
        'frmNuevoBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 138)
        Me.Controls.Add(Me.btn_confirmar_nuevo_banco)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevoBanco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmNuevoBanco"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_nombre_banco As Label
    Friend WithEvents lbl_codigo_banco As Label
    Friend WithEvents txt_nombre_banco As TextBox
    Friend WithEvents txt_codigo_banco As TextBox
    Friend WithEvents btn_confirmar_nuevo_banco As Button
End Class

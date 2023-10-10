<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaFamilia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevaFamilia))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_confirmar_familia = New System.Windows.Forms.Button()
        Me.lbl_codigo_familia = New System.Windows.Forms.Label()
        Me.lbl_nombre_familia = New System.Windows.Forms.Label()
        Me.txt_codigo_familia = New System.Windows.Forms.TextBox()
        Me.txt_nombre_familia = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.txt_nombre_familia, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_codigo_familia, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_nombre_familia, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_codigo_familia, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(322, 79)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btn_confirmar_familia
        '
        Me.btn_confirmar_familia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_confirmar_familia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar_familia.Location = New System.Drawing.Point(259, 97)
        Me.btn_confirmar_familia.Name = "btn_confirmar_familia"
        Me.btn_confirmar_familia.Size = New System.Drawing.Size(75, 23)
        Me.btn_confirmar_familia.TabIndex = 1
        Me.btn_confirmar_familia.Text = "Confirmar"
        Me.btn_confirmar_familia.UseVisualStyleBackColor = True
        '
        'lbl_codigo_familia
        '
        Me.lbl_codigo_familia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_codigo_familia.AutoSize = True
        Me.lbl_codigo_familia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo_familia.Location = New System.Drawing.Point(3, 13)
        Me.lbl_codigo_familia.Name = "lbl_codigo_familia"
        Me.lbl_codigo_familia.Size = New System.Drawing.Size(54, 13)
        Me.lbl_codigo_familia.TabIndex = 0
        Me.lbl_codigo_familia.Text = "Código:"
        Me.lbl_codigo_familia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_nombre_familia
        '
        Me.lbl_nombre_familia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nombre_familia.AutoSize = True
        Me.lbl_nombre_familia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_familia.Location = New System.Drawing.Point(3, 52)
        Me.lbl_nombre_familia.Name = "lbl_nombre_familia"
        Me.lbl_nombre_familia.Size = New System.Drawing.Size(54, 13)
        Me.lbl_nombre_familia.TabIndex = 1
        Me.lbl_nombre_familia.Text = "Nombre:"
        Me.lbl_nombre_familia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_codigo_familia
        '
        Me.txt_codigo_familia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_codigo_familia.Location = New System.Drawing.Point(63, 9)
        Me.txt_codigo_familia.Name = "txt_codigo_familia"
        Me.txt_codigo_familia.Size = New System.Drawing.Size(256, 20)
        Me.txt_codigo_familia.TabIndex = 2
        '
        'txt_nombre_familia
        '
        Me.txt_nombre_familia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre_familia.Location = New System.Drawing.Point(63, 49)
        Me.txt_nombre_familia.Name = "txt_nombre_familia"
        Me.txt_nombre_familia.Size = New System.Drawing.Size(256, 20)
        Me.txt_nombre_familia.TabIndex = 3
        '
        'frmNuevaFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 132)
        Me.Controls.Add(Me.btn_confirmar_familia)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevaFamilia"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nueva Familia"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_confirmar_familia As Button
    Friend WithEvents txt_nombre_familia As TextBox
    Friend WithEvents lbl_codigo_familia As Label
    Friend WithEvents lbl_nombre_familia As Label
    Friend WithEvents txt_codigo_familia As TextBox
End Class

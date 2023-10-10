<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnidadesInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUnidadesInventario))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_confirmar_unidades = New System.Windows.Forms.Button()
        Me.lbl_unidades_inventario = New System.Windows.Forms.Label()
        Me.txt_unidades_inventario = New System.Windows.Forms.TextBox()
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
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_unidades_inventario, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_unidades_inventario, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(370, 72)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btn_confirmar_unidades
        '
        Me.btn_confirmar_unidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_confirmar_unidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar_unidades.Location = New System.Drawing.Point(307, 103)
        Me.btn_confirmar_unidades.Name = "btn_confirmar_unidades"
        Me.btn_confirmar_unidades.Size = New System.Drawing.Size(75, 23)
        Me.btn_confirmar_unidades.TabIndex = 1
        Me.btn_confirmar_unidades.Text = "Confirmar"
        Me.btn_confirmar_unidades.UseVisualStyleBackColor = True
        '
        'lbl_unidades_inventario
        '
        Me.lbl_unidades_inventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_unidades_inventario.AutoSize = True
        Me.lbl_unidades_inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unidades_inventario.Location = New System.Drawing.Point(3, 29)
        Me.lbl_unidades_inventario.Name = "lbl_unidades_inventario"
        Me.lbl_unidades_inventario.Size = New System.Drawing.Size(64, 13)
        Me.lbl_unidades_inventario.TabIndex = 0
        Me.lbl_unidades_inventario.Text = "Unidades:"
        Me.lbl_unidades_inventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_unidades_inventario
        '
        Me.txt_unidades_inventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_unidades_inventario.Location = New System.Drawing.Point(73, 26)
        Me.txt_unidades_inventario.Name = "txt_unidades_inventario"
        Me.txt_unidades_inventario.Size = New System.Drawing.Size(294, 20)
        Me.txt_unidades_inventario.TabIndex = 1
        '
        'frmUnidadesInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 138)
        Me.Controls.Add(Me.btn_confirmar_unidades)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUnidadesInventario"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Unidades Inventario"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_unidades_inventario As Label
    Friend WithEvents txt_unidades_inventario As TextBox
    Friend WithEvents btn_confirmar_unidades As Button
End Class

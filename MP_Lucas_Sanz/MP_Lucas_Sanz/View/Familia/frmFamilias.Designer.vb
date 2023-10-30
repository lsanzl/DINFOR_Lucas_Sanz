<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFamilias
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFamilias))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_eliminar_familia = New System.Windows.Forms.Button()
        Me.btn_modificar_familia = New System.Windows.Forms.Button()
        Me.btn_añadir_familia = New System.Windows.Forms.Button()
        Me.btn_seleccionar_familia = New System.Windows.Forms.Button()
        Me.dg_familias = New System.Windows.Forms.DataGridView()
        Me.FamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dg_familias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FamiliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dg_familias, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(473, 220)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btn_seleccionar_familia, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_añadir_familia, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_eliminar_familia, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_modificar_familia, 0, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(334, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(136, 214)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btn_eliminar_familia
        '
        Me.btn_eliminar_familia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_familia.Enabled = False
        Me.btn_eliminar_familia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_familia.Location = New System.Drawing.Point(3, 68)
        Me.btn_eliminar_familia.Name = "btn_eliminar_familia"
        Me.btn_eliminar_familia.Size = New System.Drawing.Size(130, 23)
        Me.btn_eliminar_familia.TabIndex = 3
        Me.btn_eliminar_familia.Text = "Eliminar"
        Me.btn_eliminar_familia.UseVisualStyleBackColor = True
        '
        'btn_modificar_familia
        '
        Me.btn_modificar_familia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_familia.Enabled = False
        Me.btn_modificar_familia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_familia.Location = New System.Drawing.Point(3, 100)
        Me.btn_modificar_familia.Name = "btn_modificar_familia"
        Me.btn_modificar_familia.Size = New System.Drawing.Size(130, 23)
        Me.btn_modificar_familia.TabIndex = 2
        Me.btn_modificar_familia.Text = "Modificar"
        Me.btn_modificar_familia.UseVisualStyleBackColor = True
        '
        'btn_añadir_familia
        '
        Me.btn_añadir_familia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_familia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_familia.Location = New System.Drawing.Point(3, 36)
        Me.btn_añadir_familia.Name = "btn_añadir_familia"
        Me.btn_añadir_familia.Size = New System.Drawing.Size(130, 23)
        Me.btn_añadir_familia.TabIndex = 1
        Me.btn_añadir_familia.Text = "Añadir"
        Me.btn_añadir_familia.UseVisualStyleBackColor = True
        '
        'btn_seleccionar_familia
        '
        Me.btn_seleccionar_familia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_seleccionar_familia.Enabled = False
        Me.btn_seleccionar_familia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_seleccionar_familia.Location = New System.Drawing.Point(3, 4)
        Me.btn_seleccionar_familia.Name = "btn_seleccionar_familia"
        Me.btn_seleccionar_familia.Size = New System.Drawing.Size(130, 23)
        Me.btn_seleccionar_familia.TabIndex = 0
        Me.btn_seleccionar_familia.Text = "Seleccionar"
        Me.btn_seleccionar_familia.UseVisualStyleBackColor = True
        '
        'dg_familias
        '
        Me.dg_familias.AllowUserToAddRows = False
        Me.dg_familias.AllowUserToDeleteRows = False
        Me.dg_familias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_familias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_familias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_familias.Location = New System.Drawing.Point(3, 3)
        Me.dg_familias.Name = "dg_familias"
        Me.dg_familias.ReadOnly = True
        Me.dg_familias.RowHeadersVisible = False
        Me.dg_familias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dg_familias.Size = New System.Drawing.Size(325, 214)
        Me.dg_familias.TabIndex = 1
        '
        'FamiliaBindingSource
        '
        Me.FamiliaBindingSource.DataSource = GetType(MP_Lucas_Sanz.Familia)
        '
        'frmFamilias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 244)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFamilias"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Familias"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.dg_familias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FamiliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btn_eliminar_familia As Button
    Friend WithEvents btn_modificar_familia As Button
    Friend WithEvents btn_añadir_familia As Button
    Friend WithEvents btn_seleccionar_familia As Button
    Friend WithEvents FamiliaBindingSource As BindingSource
    Friend WithEvents dg_familias As DataGridView
End Class

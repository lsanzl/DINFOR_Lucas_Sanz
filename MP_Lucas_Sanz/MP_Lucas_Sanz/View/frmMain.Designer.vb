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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tab_main = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tab_bancos = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dg_bancos = New System.Windows.Forms.DataGridView()
        Me.dg_formas_pago = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_añadir_banco = New System.Windows.Forms.Button()
        Me.btn_modificar_banco = New System.Windows.Forms.Button()
        Me.btn_eliminar_banco = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tab_main.SuspendLayout()
        Me.tab_bancos.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dg_bancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_formas_pago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_main
        '
        Me.tab_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_main.Controls.Add(Me.TabPage2)
        Me.tab_main.Controls.Add(Me.tab_bancos)
        Me.tab_main.ImageList = Me.ImageList1
        Me.tab_main.ItemSize = New System.Drawing.Size(78, 50)
        Me.tab_main.Location = New System.Drawing.Point(0, 2)
        Me.tab_main.Name = "tab_main"
        Me.tab_main.SelectedIndex = 0
        Me.tab_main.Size = New System.Drawing.Size(799, 449)
        Me.tab_main.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 54)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(791, 391)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tab_bancos
        '
        Me.tab_bancos.Controls.Add(Me.TableLayoutPanel1)
        Me.tab_bancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_bancos.ImageIndex = 0
        Me.tab_bancos.Location = New System.Drawing.Point(4, 54)
        Me.tab_bancos.Name = "tab_bancos"
        Me.tab_bancos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_bancos.Size = New System.Drawing.Size(791, 391)
        Me.tab_bancos.TabIndex = 0
        Me.tab_bancos.Text = "BANCOS"
        Me.tab_bancos.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dg_bancos, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dg_formas_pago, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(3)
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(791, 391)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dg_bancos
        '
        Me.dg_bancos.AllowUserToAddRows = False
        Me.dg_bancos.AllowUserToDeleteRows = False
        Me.dg_bancos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_bancos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_bancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_bancos.Location = New System.Drawing.Point(6, 6)
        Me.dg_bancos.Name = "dg_bancos"
        Me.dg_bancos.ReadOnly = True
        Me.dg_bancos.Size = New System.Drawing.Size(386, 321)
        Me.dg_bancos.TabIndex = 0
        '
        'dg_formas_pago
        '
        Me.dg_formas_pago.AllowUserToAddRows = False
        Me.dg_formas_pago.AllowUserToDeleteRows = False
        Me.dg_formas_pago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_formas_pago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_formas_pago.Location = New System.Drawing.Point(398, 6)
        Me.dg_formas_pago.Name = "dg_formas_pago"
        Me.dg_formas_pago.ReadOnly = True
        Me.dg_formas_pago.Size = New System.Drawing.Size(387, 321)
        Me.dg_formas_pago.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.btn_añadir_banco, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_modificar_banco, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_eliminar_banco, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 333)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(386, 52)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btn_añadir_banco
        '
        Me.btn_añadir_banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_banco.Location = New System.Drawing.Point(3, 14)
        Me.btn_añadir_banco.Name = "btn_añadir_banco"
        Me.btn_añadir_banco.Size = New System.Drawing.Size(122, 23)
        Me.btn_añadir_banco.TabIndex = 0
        Me.btn_añadir_banco.Text = "Añadir Banco"
        Me.btn_añadir_banco.UseVisualStyleBackColor = True
        '
        'btn_modificar_banco
        '
        Me.btn_modificar_banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_banco.Enabled = False
        Me.btn_modificar_banco.Location = New System.Drawing.Point(131, 14)
        Me.btn_modificar_banco.Name = "btn_modificar_banco"
        Me.btn_modificar_banco.Size = New System.Drawing.Size(122, 23)
        Me.btn_modificar_banco.TabIndex = 1
        Me.btn_modificar_banco.Text = "Modificar Banco"
        Me.btn_modificar_banco.UseVisualStyleBackColor = True
        '
        'btn_eliminar_banco
        '
        Me.btn_eliminar_banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_banco.Enabled = False
        Me.btn_eliminar_banco.Location = New System.Drawing.Point(259, 14)
        Me.btn_eliminar_banco.Name = "btn_eliminar_banco"
        Me.btn_eliminar_banco.Size = New System.Drawing.Size(124, 23)
        Me.btn_eliminar_banco.TabIndex = 2
        Me.btn_eliminar_banco.Text = "Eliminar Banco"
        Me.btn_eliminar_banco.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Controls.Add(Me.Button4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Button5, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Button6, 2, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(398, 333)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(387, 52)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(3, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 23)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(132, 14)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(123, 23)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(261, 14)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(123, 23)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "banco.ico")
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tab_main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "MARCO POLO - VERSIÓN LUCA SANZ"
        Me.tab_main.ResumeLayout(False)
        Me.tab_bancos.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dg_bancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_formas_pago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_main As TabControl
    Friend WithEvents tab_bancos As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dg_bancos As DataGridView
    Friend WithEvents dg_formas_pago As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btn_añadir_banco As Button
    Friend WithEvents btn_modificar_banco As Button
    Friend WithEvents btn_eliminar_banco As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class

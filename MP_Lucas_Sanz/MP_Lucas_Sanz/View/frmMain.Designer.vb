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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tab_main = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tab_bancos_pagos = New System.Windows.Forms.TabPage()
        Me.tlp_main_bancos_pagos = New System.Windows.Forms.TableLayoutPanel()
        Me.dg_bancos = New System.Windows.Forms.DataGridView()
        Me.dg_formas_pago = New System.Windows.Forms.DataGridView()
        Me.tlp_bancos = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_añadir_banco = New System.Windows.Forms.Button()
        Me.btn_modificar_banco = New System.Windows.Forms.Button()
        Me.btn_eliminar_banco = New System.Windows.Forms.Button()
        Me.tlp_pagos = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_añadir_forma_pago = New System.Windows.Forms.Button()
        Me.btn_modificar_forma_pago = New System.Windows.Forms.Button()
        Me.btn_eliminar_forma_pago = New System.Windows.Forms.Button()
        Me.tab_clientes_grupos = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dg_clientes = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_añadir_grupo = New System.Windows.Forms.Button()
        Me.btn_modificar_grupo = New System.Windows.Forms.Button()
        Me.btn_eliminar_grupo = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dg_grupos = New System.Windows.Forms.DataGridView()
        Me.NombreDeBancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDeBancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigoDePagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDePagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoAsignadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NumeroPlazosPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerPlazoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasPlazosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDeGrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDeGrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tab_main.SuspendLayout()
        Me.tab_bancos_pagos.SuspendLayout()
        Me.tlp_main_bancos_pagos.SuspendLayout()
        CType(Me.dg_bancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_formas_pago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlp_bancos.SuspendLayout()
        Me.tlp_pagos.SuspendLayout()
        Me.tab_clientes_grupos.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dg_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.dg_grupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_main
        '
        Me.tab_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_main.Controls.Add(Me.TabPage2)
        Me.tab_main.Controls.Add(Me.tab_bancos_pagos)
        Me.tab_main.Controls.Add(Me.tab_clientes_grupos)
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
        'tab_bancos_pagos
        '
        Me.tab_bancos_pagos.Controls.Add(Me.tlp_main_bancos_pagos)
        Me.tab_bancos_pagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_bancos_pagos.ImageIndex = 0
        Me.tab_bancos_pagos.Location = New System.Drawing.Point(4, 54)
        Me.tab_bancos_pagos.Name = "tab_bancos_pagos"
        Me.tab_bancos_pagos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_bancos_pagos.Size = New System.Drawing.Size(791, 391)
        Me.tab_bancos_pagos.TabIndex = 0
        Me.tab_bancos_pagos.Text = "BANCOS/PAGOS"
        Me.tab_bancos_pagos.UseVisualStyleBackColor = True
        '
        'tlp_main_bancos_pagos
        '
        Me.tlp_main_bancos_pagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlp_main_bancos_pagos.ColumnCount = 2
        Me.tlp_main_bancos_pagos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tlp_main_bancos_pagos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.tlp_main_bancos_pagos.Controls.Add(Me.dg_bancos, 0, 0)
        Me.tlp_main_bancos_pagos.Controls.Add(Me.dg_formas_pago, 1, 0)
        Me.tlp_main_bancos_pagos.Controls.Add(Me.tlp_bancos, 0, 1)
        Me.tlp_main_bancos_pagos.Controls.Add(Me.tlp_pagos, 1, 1)
        Me.tlp_main_bancos_pagos.Location = New System.Drawing.Point(0, 0)
        Me.tlp_main_bancos_pagos.Name = "tlp_main_bancos_pagos"
        Me.tlp_main_bancos_pagos.Padding = New System.Windows.Forms.Padding(3)
        Me.tlp_main_bancos_pagos.RowCount = 2
        Me.tlp_main_bancos_pagos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.tlp_main_bancos_pagos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_main_bancos_pagos.Size = New System.Drawing.Size(791, 391)
        Me.tlp_main_bancos_pagos.TabIndex = 0
        '
        'dg_bancos
        '
        Me.dg_bancos.AllowUserToAddRows = False
        Me.dg_bancos.AllowUserToDeleteRows = False
        Me.dg_bancos.AutoGenerateColumns = False
        Me.dg_bancos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_bancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_bancos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDeBancoDataGridViewTextBoxColumn, Me.CodigoDeBancoDataGridViewTextBoxColumn})
        Me.dg_bancos.DataSource = Me.BancoBindingSource
        Me.dg_bancos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_bancos.Location = New System.Drawing.Point(6, 6)
        Me.dg_bancos.Name = "dg_bancos"
        Me.dg_bancos.ReadOnly = True
        Me.dg_bancos.Size = New System.Drawing.Size(268, 321)
        Me.dg_bancos.TabIndex = 0
        '
        'dg_formas_pago
        '
        Me.dg_formas_pago.AllowUserToAddRows = False
        Me.dg_formas_pago.AllowUserToDeleteRows = False
        Me.dg_formas_pago.AutoGenerateColumns = False
        Me.dg_formas_pago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_formas_pago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_formas_pago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDePagoDataGridViewTextBoxColumn, Me.NombreDePagoDataGridViewTextBoxColumn, Me.BancoAsignadoDataGridViewTextBoxColumn, Me.ActivoDataGridViewTextBoxColumn, Me.NumeroPlazosPagoDataGridViewTextBoxColumn, Me.PrimerPlazoDataGridViewTextBoxColumn, Me.DiasPlazosDataGridViewTextBoxColumn})
        Me.dg_formas_pago.DataSource = Me.FormaPagoBindingSource
        Me.dg_formas_pago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_formas_pago.Location = New System.Drawing.Point(280, 6)
        Me.dg_formas_pago.MultiSelect = False
        Me.dg_formas_pago.Name = "dg_formas_pago"
        Me.dg_formas_pago.Size = New System.Drawing.Size(505, 321)
        Me.dg_formas_pago.TabIndex = 1
        '
        'tlp_bancos
        '
        Me.tlp_bancos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlp_bancos.ColumnCount = 3
        Me.tlp_bancos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlp_bancos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlp_bancos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlp_bancos.Controls.Add(Me.btn_añadir_banco, 0, 0)
        Me.tlp_bancos.Controls.Add(Me.btn_modificar_banco, 1, 0)
        Me.tlp_bancos.Controls.Add(Me.btn_eliminar_banco, 2, 0)
        Me.tlp_bancos.Location = New System.Drawing.Point(6, 333)
        Me.tlp_bancos.Name = "tlp_bancos"
        Me.tlp_bancos.RowCount = 1
        Me.tlp_bancos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_bancos.Size = New System.Drawing.Size(268, 52)
        Me.tlp_bancos.TabIndex = 2
        '
        'btn_añadir_banco
        '
        Me.btn_añadir_banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_banco.Location = New System.Drawing.Point(3, 8)
        Me.btn_añadir_banco.Name = "btn_añadir_banco"
        Me.btn_añadir_banco.Size = New System.Drawing.Size(83, 35)
        Me.btn_añadir_banco.TabIndex = 0
        Me.btn_añadir_banco.Text = "Añadir Banco"
        Me.btn_añadir_banco.UseVisualStyleBackColor = True
        '
        'btn_modificar_banco
        '
        Me.btn_modificar_banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_banco.Enabled = False
        Me.btn_modificar_banco.Location = New System.Drawing.Point(92, 8)
        Me.btn_modificar_banco.Name = "btn_modificar_banco"
        Me.btn_modificar_banco.Size = New System.Drawing.Size(83, 35)
        Me.btn_modificar_banco.TabIndex = 1
        Me.btn_modificar_banco.Text = "Modificar Banco"
        Me.btn_modificar_banco.UseVisualStyleBackColor = True
        '
        'btn_eliminar_banco
        '
        Me.btn_eliminar_banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_banco.Enabled = False
        Me.btn_eliminar_banco.Location = New System.Drawing.Point(181, 8)
        Me.btn_eliminar_banco.Name = "btn_eliminar_banco"
        Me.btn_eliminar_banco.Size = New System.Drawing.Size(84, 35)
        Me.btn_eliminar_banco.TabIndex = 2
        Me.btn_eliminar_banco.Text = "Eliminar Banco"
        Me.btn_eliminar_banco.UseVisualStyleBackColor = True
        '
        'tlp_pagos
        '
        Me.tlp_pagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlp_pagos.ColumnCount = 3
        Me.tlp_pagos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlp_pagos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlp_pagos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlp_pagos.Controls.Add(Me.btn_añadir_forma_pago, 0, 0)
        Me.tlp_pagos.Controls.Add(Me.btn_modificar_forma_pago, 1, 0)
        Me.tlp_pagos.Controls.Add(Me.btn_eliminar_forma_pago, 2, 0)
        Me.tlp_pagos.Location = New System.Drawing.Point(280, 333)
        Me.tlp_pagos.Name = "tlp_pagos"
        Me.tlp_pagos.RowCount = 1
        Me.tlp_pagos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_pagos.Size = New System.Drawing.Size(505, 52)
        Me.tlp_pagos.TabIndex = 3
        '
        'btn_añadir_forma_pago
        '
        Me.btn_añadir_forma_pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_forma_pago.Location = New System.Drawing.Point(3, 8)
        Me.btn_añadir_forma_pago.Name = "btn_añadir_forma_pago"
        Me.btn_añadir_forma_pago.Size = New System.Drawing.Size(162, 35)
        Me.btn_añadir_forma_pago.TabIndex = 0
        Me.btn_añadir_forma_pago.Text = "Añadir Forma Pago"
        Me.btn_añadir_forma_pago.UseVisualStyleBackColor = True
        '
        'btn_modificar_forma_pago
        '
        Me.btn_modificar_forma_pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_forma_pago.Enabled = False
        Me.btn_modificar_forma_pago.Location = New System.Drawing.Point(171, 8)
        Me.btn_modificar_forma_pago.Name = "btn_modificar_forma_pago"
        Me.btn_modificar_forma_pago.Size = New System.Drawing.Size(162, 35)
        Me.btn_modificar_forma_pago.TabIndex = 1
        Me.btn_modificar_forma_pago.Text = "Modificar Forma Pago"
        Me.btn_modificar_forma_pago.UseVisualStyleBackColor = True
        '
        'btn_eliminar_forma_pago
        '
        Me.btn_eliminar_forma_pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_forma_pago.Enabled = False
        Me.btn_eliminar_forma_pago.Location = New System.Drawing.Point(339, 8)
        Me.btn_eliminar_forma_pago.Name = "btn_eliminar_forma_pago"
        Me.btn_eliminar_forma_pago.Size = New System.Drawing.Size(163, 35)
        Me.btn_eliminar_forma_pago.TabIndex = 2
        Me.btn_eliminar_forma_pago.Text = "Eliminar Forma Pago"
        Me.btn_eliminar_forma_pago.UseVisualStyleBackColor = True
        '
        'tab_clientes_grupos
        '
        Me.tab_clientes_grupos.Controls.Add(Me.TableLayoutPanel1)
        Me.tab_clientes_grupos.ImageIndex = 1
        Me.tab_clientes_grupos.Location = New System.Drawing.Point(4, 54)
        Me.tab_clientes_grupos.Name = "tab_clientes_grupos"
        Me.tab_clientes_grupos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_clientes_grupos.Size = New System.Drawing.Size(791, 391)
        Me.tab_clientes_grupos.TabIndex = 2
        Me.tab_clientes_grupos.Text = "CLIENTES/GRUPOS"
        Me.tab_clientes_grupos.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dg_clientes, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dg_grupos, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 8)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(3)
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(791, 391)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'dg_clientes
        '
        Me.dg_clientes.AllowUserToAddRows = False
        Me.dg_clientes.AllowUserToDeleteRows = False
        Me.dg_clientes.AutoGenerateColumns = False
        Me.dg_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_clientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dg_clientes.DataSource = Me.FormaPagoBindingSource
        Me.dg_clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_clientes.Location = New System.Drawing.Point(280, 6)
        Me.dg_clientes.MultiSelect = False
        Me.dg_clientes.Name = "dg_clientes"
        Me.dg_clientes.Size = New System.Drawing.Size(505, 321)
        Me.dg_clientes.TabIndex = 1
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
        Me.TableLayoutPanel2.Controls.Add(Me.btn_añadir_grupo, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_modificar_grupo, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_eliminar_grupo, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 333)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(268, 52)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btn_añadir_grupo
        '
        Me.btn_añadir_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_grupo.Location = New System.Drawing.Point(3, 8)
        Me.btn_añadir_grupo.Name = "btn_añadir_grupo"
        Me.btn_añadir_grupo.Size = New System.Drawing.Size(83, 35)
        Me.btn_añadir_grupo.TabIndex = 0
        Me.btn_añadir_grupo.Text = "Añadir Grupo"
        Me.btn_añadir_grupo.UseVisualStyleBackColor = True
        '
        'btn_modificar_grupo
        '
        Me.btn_modificar_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_grupo.Enabled = False
        Me.btn_modificar_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_grupo.Location = New System.Drawing.Point(92, 8)
        Me.btn_modificar_grupo.Name = "btn_modificar_grupo"
        Me.btn_modificar_grupo.Size = New System.Drawing.Size(83, 35)
        Me.btn_modificar_grupo.TabIndex = 1
        Me.btn_modificar_grupo.Text = "Modificar Grupo"
        Me.btn_modificar_grupo.UseVisualStyleBackColor = True
        '
        'btn_eliminar_grupo
        '
        Me.btn_eliminar_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_grupo.Enabled = False
        Me.btn_eliminar_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_grupo.Location = New System.Drawing.Point(181, 8)
        Me.btn_eliminar_grupo.Name = "btn_eliminar_grupo"
        Me.btn_eliminar_grupo.Size = New System.Drawing.Size(84, 35)
        Me.btn_eliminar_grupo.TabIndex = 2
        Me.btn_eliminar_grupo.Text = "Eliminar Grupo"
        Me.btn_eliminar_grupo.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(280, 333)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(505, 52)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(3, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(162, 35)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Añadir Forma Pago"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(171, 8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(162, 35)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Modificar Forma Pago"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(339, 8)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(163, 35)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Eliminar Forma Pago"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "banco.ico")
        Me.ImageList1.Images.SetKeyName(1, "cliente.ico")
        '
        'dg_grupos
        '
        Me.dg_grupos.AllowUserToAddRows = False
        Me.dg_grupos.AllowUserToDeleteRows = False
        Me.dg_grupos.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_grupos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_grupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_grupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDeGrupoDataGridViewTextBoxColumn, Me.NombreDeGrupoDataGridViewTextBoxColumn})
        Me.dg_grupos.DataSource = Me.GrupoBindingSource
        Me.dg_grupos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_grupos.Location = New System.Drawing.Point(6, 6)
        Me.dg_grupos.MultiSelect = False
        Me.dg_grupos.Name = "dg_grupos"
        Me.dg_grupos.ReadOnly = True
        Me.dg_grupos.Size = New System.Drawing.Size(268, 321)
        Me.dg_grupos.TabIndex = 4
        '
        'NombreDeBancoDataGridViewTextBoxColumn
        '
        Me.NombreDeBancoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDeBancoDataGridViewTextBoxColumn.DataPropertyName = "NombreDeBanco"
        Me.NombreDeBancoDataGridViewTextBoxColumn.HeaderText = "Nombre Banco"
        Me.NombreDeBancoDataGridViewTextBoxColumn.Name = "NombreDeBancoDataGridViewTextBoxColumn"
        Me.NombreDeBancoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoDeBancoDataGridViewTextBoxColumn
        '
        Me.CodigoDeBancoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CodigoDeBancoDataGridViewTextBoxColumn.DataPropertyName = "CodigoDeBanco"
        Me.CodigoDeBancoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDeBancoDataGridViewTextBoxColumn.Name = "CodigoDeBancoDataGridViewTextBoxColumn"
        Me.CodigoDeBancoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BancoBindingSource
        '
        Me.BancoBindingSource.DataSource = GetType(MP_Lucas_Sanz.Banco)
        '
        'CodigoDePagoDataGridViewTextBoxColumn
        '
        Me.CodigoDePagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CodigoDePagoDataGridViewTextBoxColumn.DataPropertyName = "CodigoDePago"
        Me.CodigoDePagoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDePagoDataGridViewTextBoxColumn.Name = "CodigoDePagoDataGridViewTextBoxColumn"
        Me.CodigoDePagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDePagoDataGridViewTextBoxColumn
        '
        Me.NombreDePagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDePagoDataGridViewTextBoxColumn.DataPropertyName = "NombreDePago"
        Me.NombreDePagoDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDePagoDataGridViewTextBoxColumn.Name = "NombreDePagoDataGridViewTextBoxColumn"
        Me.NombreDePagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BancoAsignadoDataGridViewTextBoxColumn
        '
        Me.BancoAsignadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BancoAsignadoDataGridViewTextBoxColumn.DataPropertyName = "BancoAsignado"
        Me.BancoAsignadoDataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.BancoAsignadoDataGridViewTextBoxColumn.Name = "BancoAsignadoDataGridViewTextBoxColumn"
        Me.BancoAsignadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActivoDataGridViewTextBoxColumn
        '
        Me.ActivoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ActivoDataGridViewTextBoxColumn.DataPropertyName = "Activo"
        Me.ActivoDataGridViewTextBoxColumn.FalseValue = "0"
        Me.ActivoDataGridViewTextBoxColumn.HeaderText = "Activo"
        Me.ActivoDataGridViewTextBoxColumn.Name = "ActivoDataGridViewTextBoxColumn"
        Me.ActivoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ActivoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ActivoDataGridViewTextBoxColumn.TrueValue = "1"
        '
        'NumeroPlazosPagoDataGridViewTextBoxColumn
        '
        Me.NumeroPlazosPagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NumeroPlazosPagoDataGridViewTextBoxColumn.DataPropertyName = "NumeroPlazosPago"
        Me.NumeroPlazosPagoDataGridViewTextBoxColumn.HeaderText = "Núm Plazos"
        Me.NumeroPlazosPagoDataGridViewTextBoxColumn.Name = "NumeroPlazosPagoDataGridViewTextBoxColumn"
        Me.NumeroPlazosPagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrimerPlazoDataGridViewTextBoxColumn
        '
        Me.PrimerPlazoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PrimerPlazoDataGridViewTextBoxColumn.DataPropertyName = "PrimerPlazo"
        Me.PrimerPlazoDataGridViewTextBoxColumn.HeaderText = "Primer Plazo"
        Me.PrimerPlazoDataGridViewTextBoxColumn.Name = "PrimerPlazoDataGridViewTextBoxColumn"
        Me.PrimerPlazoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiasPlazosDataGridViewTextBoxColumn
        '
        Me.DiasPlazosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DiasPlazosDataGridViewTextBoxColumn.DataPropertyName = "DiasPlazos"
        Me.DiasPlazosDataGridViewTextBoxColumn.HeaderText = "Intervalo"
        Me.DiasPlazosDataGridViewTextBoxColumn.Name = "DiasPlazosDataGridViewTextBoxColumn"
        Me.DiasPlazosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormaPagoBindingSource
        '
        Me.FormaPagoBindingSource.DataSource = GetType(MP_Lucas_Sanz.FormaPago)
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CodigoDePago"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NombreDePago"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "BancoAsignado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Banco"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Activo"
        Me.DataGridViewCheckBoxColumn1.FalseValue = "0"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.TrueValue = "1"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NumeroPlazosPago"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Núm Plazos"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PrimerPlazo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Primer Plazo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DiasPlazos"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Intervalo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'CodigoDeGrupoDataGridViewTextBoxColumn
        '
        Me.CodigoDeGrupoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodigoDeGrupoDataGridViewTextBoxColumn.DataPropertyName = "CodigoDeGrupo"
        Me.CodigoDeGrupoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDeGrupoDataGridViewTextBoxColumn.Name = "CodigoDeGrupoDataGridViewTextBoxColumn"
        Me.CodigoDeGrupoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDeGrupoDataGridViewTextBoxColumn.Width = 71
        '
        'NombreDeGrupoDataGridViewTextBoxColumn
        '
        Me.NombreDeGrupoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombreDeGrupoDataGridViewTextBoxColumn.DataPropertyName = "NombreDeGrupo"
        Me.NombreDeGrupoDataGridViewTextBoxColumn.HeaderText = "Nombre del Grupo"
        Me.NombreDeGrupoDataGridViewTextBoxColumn.Name = "NombreDeGrupoDataGridViewTextBoxColumn"
        Me.NombreDeGrupoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDeGrupoDataGridViewTextBoxColumn.Width = 92
        '
        'GrupoBindingSource
        '
        Me.GrupoBindingSource.DataSource = GetType(MP_Lucas_Sanz.Grupo)
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
        Me.tab_bancos_pagos.ResumeLayout(False)
        Me.tlp_main_bancos_pagos.ResumeLayout(False)
        CType(Me.dg_bancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_formas_pago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlp_bancos.ResumeLayout(False)
        Me.tlp_pagos.ResumeLayout(False)
        Me.tab_clientes_grupos.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dg_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.dg_grupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_main As TabControl
    Friend WithEvents tab_bancos_pagos As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents tlp_main_bancos_pagos As TableLayoutPanel
    Friend WithEvents dg_bancos As DataGridView
    Friend WithEvents dg_formas_pago As DataGridView
    Friend WithEvents tlp_bancos As TableLayoutPanel
    Friend WithEvents btn_modificar_banco As Button
    Friend WithEvents btn_eliminar_banco As Button
    Friend WithEvents tlp_pagos As TableLayoutPanel
    Friend WithEvents btn_añadir_forma_pago As Button
    Friend WithEvents btn_modificar_forma_pago As Button
    Friend WithEvents btn_eliminar_forma_pago As Button
    Public WithEvents btn_añadir_banco As Button
    Friend WithEvents BancoBindingSource As BindingSource
    Friend WithEvents FormaPagoBindingSource As BindingSource
    Friend WithEvents NombreDeBancoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDeBancoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDePagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDePagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BancoAsignadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActivoDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents NumeroPlazosPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimerPlazoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiasPlazosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tab_clientes_grupos As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dg_clientes As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Public WithEvents btn_añadir_grupo As Button
    Friend WithEvents btn_modificar_grupo As Button
    Friend WithEvents btn_eliminar_grupo As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents dg_grupos As DataGridView
    Friend WithEvents CodigoDeGrupoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDeGrupoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrupoBindingSource As BindingSource
End Class

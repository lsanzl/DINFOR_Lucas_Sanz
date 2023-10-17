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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tab_main = New System.Windows.Forms.TabControl()
        Me.tab_menu_principal = New System.Windows.Forms.TabPage()
        Me.tlp_menu_main = New System.Windows.Forms.TableLayoutPanel()
        Me.tab_bancos_pagos = New System.Windows.Forms.TabPage()
        Me.tlp_main_bancos_pagos = New System.Windows.Forms.TableLayoutPanel()
        Me.dg_bancos = New System.Windows.Forms.DataGridView()
        Me.nombreBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.btn_añadir_cliente = New System.Windows.Forms.Button()
        Me.btn_modificar_cliente = New System.Windows.Forms.Button()
        Me.btn_eliminar_cliente = New System.Windows.Forms.Button()
        Me.dg_grupos = New System.Windows.Forms.DataGridView()
        Me.tab_articulos_proveedores = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.dg_articulos = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_añadir_proveedor = New System.Windows.Forms.Button()
        Me.btn_modificar_proveedor = New System.Windows.Forms.Button()
        Me.btn_eliminar_proveedor = New System.Windows.Forms.Button()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_añadir_articulo = New System.Windows.Forms.Button()
        Me.btn_modificar_articulo = New System.Windows.Forms.Button()
        Me.btn_eliminar_articulo = New System.Windows.Forms.Button()
        Me.dg_proveedores = New System.Windows.Forms.DataGridView()
        Me.datos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tab_inventario = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.dg_inventario = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_restar_unidades = New System.Windows.Forms.Button()
        Me.btn_añadir_unidades = New System.Windows.Forms.Button()
        Me.btn_añadir_articulo_inventario = New System.Windows.Forms.Button()
        Me.btn_eliminar_articulo_inventario = New System.Windows.Forms.Button()
        Me.txt_busqueda_inventario = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_efectuar_venta = New System.Windows.Forms.Button()
        Me.btn_menu_inventario = New System.Windows.Forms.Button()
        Me.btn_menu_configuraciones = New System.Windows.Forms.Button()
        Me.btn_efectuar_compra = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CodigoDePagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDePagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoAsignadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NumeroPlazosPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerPlazoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasPlazosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigoDelClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDelClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NifDelClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDelClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeNacimientoDelClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoDelClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoDelClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDelClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigoDeGrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDeGrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigoDeArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDeArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDeArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PVPCompraDeArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PVPVentaDeArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajeDeBeneficioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDeUnidadArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FamiliaDeArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigoDeProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDeProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreDeArticuloDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadesDisponiblesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GrupoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.tab_main.SuspendLayout()
        Me.tab_menu_principal.SuspendLayout()
        Me.tlp_menu_main.SuspendLayout()
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
        Me.tab_articulos_proveedores.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.dg_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_inventario.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.dg_inventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.FormaPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_main
        '
        Me.tab_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_main.Controls.Add(Me.tab_menu_principal)
        Me.tab_main.Controls.Add(Me.tab_bancos_pagos)
        Me.tab_main.Controls.Add(Me.tab_clientes_grupos)
        Me.tab_main.Controls.Add(Me.tab_articulos_proveedores)
        Me.tab_main.Controls.Add(Me.tab_inventario)
        Me.tab_main.Controls.Add(Me.TabPage1)
        Me.tab_main.ImageList = Me.ImageList1
        Me.tab_main.ItemSize = New System.Drawing.Size(78, 50)
        Me.tab_main.Location = New System.Drawing.Point(0, 2)
        Me.tab_main.Name = "tab_main"
        Me.tab_main.SelectedIndex = 0
        Me.tab_main.Size = New System.Drawing.Size(799, 449)
        Me.tab_main.TabIndex = 1
        '
        'tab_menu_principal
        '
        Me.tab_menu_principal.Controls.Add(Me.tlp_menu_main)
        Me.tab_menu_principal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_menu_principal.Location = New System.Drawing.Point(4, 54)
        Me.tab_menu_principal.Name = "tab_menu_principal"
        Me.tab_menu_principal.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_menu_principal.Size = New System.Drawing.Size(791, 391)
        Me.tab_menu_principal.TabIndex = 1
        Me.tab_menu_principal.Text = "MENÚ"
        Me.tab_menu_principal.UseVisualStyleBackColor = True
        '
        'tlp_menu_main
        '
        Me.tlp_menu_main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlp_menu_main.ColumnCount = 2
        Me.tlp_menu_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_menu_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_menu_main.Controls.Add(Me.btn_efectuar_venta, 0, 0)
        Me.tlp_menu_main.Controls.Add(Me.btn_menu_inventario, 1, 0)
        Me.tlp_menu_main.Controls.Add(Me.btn_menu_configuraciones, 1, 1)
        Me.tlp_menu_main.Controls.Add(Me.btn_efectuar_compra, 0, 1)
        Me.tlp_menu_main.Location = New System.Drawing.Point(0, 0)
        Me.tlp_menu_main.Name = "tlp_menu_main"
        Me.tlp_menu_main.RowCount = 2
        Me.tlp_menu_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_menu_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_menu_main.Size = New System.Drawing.Size(791, 391)
        Me.tlp_menu_main.TabIndex = 0
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
        Me.tlp_main_bancos_pagos.Size = New System.Drawing.Size(799, 399)
        Me.tlp_main_bancos_pagos.TabIndex = 0
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
        Me.dg_bancos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombreBanco, Me.codigoBanco})
        Me.dg_bancos.Location = New System.Drawing.Point(6, 6)
        Me.dg_bancos.Name = "dg_bancos"
        Me.dg_bancos.ReadOnly = True
        Me.dg_bancos.Size = New System.Drawing.Size(271, 328)
        Me.dg_bancos.TabIndex = 0
        '
        'nombreBanco
        '
        Me.nombreBanco.DataPropertyName = "NombreDeBanco"
        Me.nombreBanco.HeaderText = "Nombre Banco"
        Me.nombreBanco.Name = "nombreBanco"
        Me.nombreBanco.ReadOnly = True
        '
        'codigoBanco
        '
        Me.codigoBanco.DataPropertyName = "CodigoDeBanco"
        Me.codigoBanco.HeaderText = "Codigo"
        Me.codigoBanco.Name = "codigoBanco"
        Me.codigoBanco.ReadOnly = True
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
        Me.dg_formas_pago.Location = New System.Drawing.Point(283, 6)
        Me.dg_formas_pago.MultiSelect = False
        Me.dg_formas_pago.Name = "dg_formas_pago"
        Me.dg_formas_pago.Size = New System.Drawing.Size(510, 328)
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
        Me.tlp_bancos.Location = New System.Drawing.Point(6, 340)
        Me.tlp_bancos.Name = "tlp_bancos"
        Me.tlp_bancos.RowCount = 1
        Me.tlp_bancos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_bancos.Size = New System.Drawing.Size(271, 53)
        Me.tlp_bancos.TabIndex = 2
        '
        'btn_añadir_banco
        '
        Me.btn_añadir_banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_banco.Location = New System.Drawing.Point(3, 9)
        Me.btn_añadir_banco.Name = "btn_añadir_banco"
        Me.btn_añadir_banco.Size = New System.Drawing.Size(84, 35)
        Me.btn_añadir_banco.TabIndex = 0
        Me.btn_añadir_banco.Text = "Añadir Banco"
        Me.btn_añadir_banco.UseVisualStyleBackColor = True
        '
        'btn_modificar_banco
        '
        Me.btn_modificar_banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_banco.Enabled = False
        Me.btn_modificar_banco.Location = New System.Drawing.Point(93, 9)
        Me.btn_modificar_banco.Name = "btn_modificar_banco"
        Me.btn_modificar_banco.Size = New System.Drawing.Size(84, 35)
        Me.btn_modificar_banco.TabIndex = 1
        Me.btn_modificar_banco.Text = "Modificar Banco"
        Me.btn_modificar_banco.UseVisualStyleBackColor = True
        '
        'btn_eliminar_banco
        '
        Me.btn_eliminar_banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_banco.Enabled = False
        Me.btn_eliminar_banco.Location = New System.Drawing.Point(183, 9)
        Me.btn_eliminar_banco.Name = "btn_eliminar_banco"
        Me.btn_eliminar_banco.Size = New System.Drawing.Size(85, 35)
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
        Me.tlp_pagos.Location = New System.Drawing.Point(283, 340)
        Me.tlp_pagos.Name = "tlp_pagos"
        Me.tlp_pagos.RowCount = 1
        Me.tlp_pagos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_pagos.Size = New System.Drawing.Size(510, 53)
        Me.tlp_pagos.TabIndex = 3
        '
        'btn_añadir_forma_pago
        '
        Me.btn_añadir_forma_pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_forma_pago.Location = New System.Drawing.Point(3, 9)
        Me.btn_añadir_forma_pago.Name = "btn_añadir_forma_pago"
        Me.btn_añadir_forma_pago.Size = New System.Drawing.Size(164, 35)
        Me.btn_añadir_forma_pago.TabIndex = 0
        Me.btn_añadir_forma_pago.Text = "Añadir Forma Pago"
        Me.btn_añadir_forma_pago.UseVisualStyleBackColor = True
        '
        'btn_modificar_forma_pago
        '
        Me.btn_modificar_forma_pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_forma_pago.Enabled = False
        Me.btn_modificar_forma_pago.Location = New System.Drawing.Point(173, 9)
        Me.btn_modificar_forma_pago.Name = "btn_modificar_forma_pago"
        Me.btn_modificar_forma_pago.Size = New System.Drawing.Size(164, 35)
        Me.btn_modificar_forma_pago.TabIndex = 1
        Me.btn_modificar_forma_pago.Text = "Modificar Forma Pago"
        Me.btn_modificar_forma_pago.UseVisualStyleBackColor = True
        '
        'btn_eliminar_forma_pago
        '
        Me.btn_eliminar_forma_pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_forma_pago.Enabled = False
        Me.btn_eliminar_forma_pago.Location = New System.Drawing.Point(343, 9)
        Me.btn_eliminar_forma_pago.Name = "btn_eliminar_forma_pago"
        Me.btn_eliminar_forma_pago.Size = New System.Drawing.Size(164, 35)
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(3)
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(799, 399)
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
        Me.dg_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDelClienteDataGridViewTextBoxColumn, Me.NombreDelClienteDataGridViewTextBoxColumn, Me.NifDelClienteDataGridViewTextBoxColumn, Me.DireccionDelClienteDataGridViewTextBoxColumn, Me.FechaDeNacimientoDelClienteDataGridViewTextBoxColumn, Me.BancoDelClienteDataGridViewTextBoxColumn, Me.GrupoDelClienteDataGridViewTextBoxColumn, Me.EmailDelClienteDataGridViewTextBoxColumn})
        Me.dg_clientes.DataSource = Me.ClienteBindingSource
        Me.dg_clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_clientes.Location = New System.Drawing.Point(283, 6)
        Me.dg_clientes.MultiSelect = False
        Me.dg_clientes.Name = "dg_clientes"
        Me.dg_clientes.Size = New System.Drawing.Size(510, 328)
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 340)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(271, 53)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btn_añadir_grupo
        '
        Me.btn_añadir_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_grupo.Location = New System.Drawing.Point(3, 9)
        Me.btn_añadir_grupo.Name = "btn_añadir_grupo"
        Me.btn_añadir_grupo.Size = New System.Drawing.Size(84, 35)
        Me.btn_añadir_grupo.TabIndex = 0
        Me.btn_añadir_grupo.Text = "Añadir Grupo"
        Me.btn_añadir_grupo.UseVisualStyleBackColor = True
        '
        'btn_modificar_grupo
        '
        Me.btn_modificar_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_grupo.Enabled = False
        Me.btn_modificar_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_grupo.Location = New System.Drawing.Point(93, 9)
        Me.btn_modificar_grupo.Name = "btn_modificar_grupo"
        Me.btn_modificar_grupo.Size = New System.Drawing.Size(84, 35)
        Me.btn_modificar_grupo.TabIndex = 1
        Me.btn_modificar_grupo.Text = "Modificar Grupo"
        Me.btn_modificar_grupo.UseVisualStyleBackColor = True
        '
        'btn_eliminar_grupo
        '
        Me.btn_eliminar_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_grupo.Enabled = False
        Me.btn_eliminar_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_grupo.Location = New System.Drawing.Point(183, 9)
        Me.btn_eliminar_grupo.Name = "btn_eliminar_grupo"
        Me.btn_eliminar_grupo.Size = New System.Drawing.Size(85, 35)
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
        Me.TableLayoutPanel3.Controls.Add(Me.btn_añadir_cliente, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_modificar_cliente, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_eliminar_cliente, 2, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(283, 340)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(510, 53)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'btn_añadir_cliente
        '
        Me.btn_añadir_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_cliente.Location = New System.Drawing.Point(3, 9)
        Me.btn_añadir_cliente.Name = "btn_añadir_cliente"
        Me.btn_añadir_cliente.Size = New System.Drawing.Size(164, 35)
        Me.btn_añadir_cliente.TabIndex = 0
        Me.btn_añadir_cliente.Text = "Añadir Cliente"
        Me.btn_añadir_cliente.UseVisualStyleBackColor = True
        '
        'btn_modificar_cliente
        '
        Me.btn_modificar_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_cliente.Enabled = False
        Me.btn_modificar_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_cliente.Location = New System.Drawing.Point(173, 9)
        Me.btn_modificar_cliente.Name = "btn_modificar_cliente"
        Me.btn_modificar_cliente.Size = New System.Drawing.Size(164, 35)
        Me.btn_modificar_cliente.TabIndex = 1
        Me.btn_modificar_cliente.Text = "Modificar Cliente"
        Me.btn_modificar_cliente.UseVisualStyleBackColor = True
        '
        'btn_eliminar_cliente
        '
        Me.btn_eliminar_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_cliente.Enabled = False
        Me.btn_eliminar_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_cliente.Location = New System.Drawing.Point(343, 9)
        Me.btn_eliminar_cliente.Name = "btn_eliminar_cliente"
        Me.btn_eliminar_cliente.Size = New System.Drawing.Size(164, 35)
        Me.btn_eliminar_cliente.TabIndex = 2
        Me.btn_eliminar_cliente.Text = "Eliminar Cliente"
        Me.btn_eliminar_cliente.UseVisualStyleBackColor = True
        '
        'dg_grupos
        '
        Me.dg_grupos.AllowUserToAddRows = False
        Me.dg_grupos.AllowUserToDeleteRows = False
        Me.dg_grupos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_grupos.AutoGenerateColumns = False
        Me.dg_grupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
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
        Me.dg_grupos.Location = New System.Drawing.Point(6, 6)
        Me.dg_grupos.MultiSelect = False
        Me.dg_grupos.Name = "dg_grupos"
        Me.dg_grupos.ReadOnly = True
        Me.dg_grupos.Size = New System.Drawing.Size(271, 328)
        Me.dg_grupos.TabIndex = 4
        '
        'tab_articulos_proveedores
        '
        Me.tab_articulos_proveedores.Controls.Add(Me.TableLayoutPanel4)
        Me.tab_articulos_proveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_articulos_proveedores.ImageIndex = 2
        Me.tab_articulos_proveedores.Location = New System.Drawing.Point(4, 54)
        Me.tab_articulos_proveedores.Name = "tab_articulos_proveedores"
        Me.tab_articulos_proveedores.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_articulos_proveedores.Size = New System.Drawing.Size(791, 391)
        Me.tab_articulos_proveedores.TabIndex = 3
        Me.tab_articulos_proveedores.Text = "ARTÍCULOS/PROVEEDORES"
        Me.tab_articulos_proveedores.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.dg_articulos, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.dg_proveedores, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.Padding = New System.Windows.Forms.Padding(3)
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(799, 399)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'dg_articulos
        '
        Me.dg_articulos.AllowUserToAddRows = False
        Me.dg_articulos.AllowUserToDeleteRows = False
        Me.dg_articulos.AutoGenerateColumns = False
        Me.dg_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_articulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDeArticuloDataGridViewTextBoxColumn, Me.NombreDeArticuloDataGridViewTextBoxColumn, Me.DescripcionDeArticuloDataGridViewTextBoxColumn, Me.PVPCompraDeArticuloDataGridViewTextBoxColumn, Me.PVPVentaDeArticuloDataGridViewTextBoxColumn, Me.PorcentajeDeBeneficioDataGridViewTextBoxColumn, Me.TipoDeUnidadArticuloDataGridViewTextBoxColumn, Me.FamiliaDeArticuloDataGridViewTextBoxColumn})
        Me.dg_articulos.DataSource = Me.ArticuloBindingSource
        Me.dg_articulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_articulos.Location = New System.Drawing.Point(283, 6)
        Me.dg_articulos.MultiSelect = False
        Me.dg_articulos.Name = "dg_articulos"
        Me.dg_articulos.Size = New System.Drawing.Size(510, 328)
        Me.dg_articulos.TabIndex = 1
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.Controls.Add(Me.btn_añadir_proveedor, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btn_modificar_proveedor, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btn_eliminar_proveedor, 2, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(6, 340)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(271, 53)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'btn_añadir_proveedor
        '
        Me.btn_añadir_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_proveedor.Location = New System.Drawing.Point(3, 9)
        Me.btn_añadir_proveedor.Name = "btn_añadir_proveedor"
        Me.btn_añadir_proveedor.Size = New System.Drawing.Size(84, 35)
        Me.btn_añadir_proveedor.TabIndex = 0
        Me.btn_añadir_proveedor.Text = "Añadir Proveedor"
        Me.btn_añadir_proveedor.UseVisualStyleBackColor = True
        '
        'btn_modificar_proveedor
        '
        Me.btn_modificar_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_proveedor.Enabled = False
        Me.btn_modificar_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_proveedor.Location = New System.Drawing.Point(93, 9)
        Me.btn_modificar_proveedor.Name = "btn_modificar_proveedor"
        Me.btn_modificar_proveedor.Size = New System.Drawing.Size(84, 35)
        Me.btn_modificar_proveedor.TabIndex = 1
        Me.btn_modificar_proveedor.Text = "Modificar Proveedor"
        Me.btn_modificar_proveedor.UseVisualStyleBackColor = True
        '
        'btn_eliminar_proveedor
        '
        Me.btn_eliminar_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_proveedor.Enabled = False
        Me.btn_eliminar_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_proveedor.Location = New System.Drawing.Point(183, 9)
        Me.btn_eliminar_proveedor.Name = "btn_eliminar_proveedor"
        Me.btn_eliminar_proveedor.Size = New System.Drawing.Size(85, 35)
        Me.btn_eliminar_proveedor.TabIndex = 2
        Me.btn_eliminar_proveedor.Text = "Eliminar Proveedor"
        Me.btn_eliminar_proveedor.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.Controls.Add(Me.btn_añadir_articulo, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.btn_modificar_articulo, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.btn_eliminar_articulo, 2, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(283, 340)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(510, 53)
        Me.TableLayoutPanel6.TabIndex = 3
        '
        'btn_añadir_articulo
        '
        Me.btn_añadir_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_articulo.Location = New System.Drawing.Point(3, 9)
        Me.btn_añadir_articulo.Name = "btn_añadir_articulo"
        Me.btn_añadir_articulo.Size = New System.Drawing.Size(164, 35)
        Me.btn_añadir_articulo.TabIndex = 0
        Me.btn_añadir_articulo.Text = "Añadir Artículo"
        Me.btn_añadir_articulo.UseVisualStyleBackColor = True
        '
        'btn_modificar_articulo
        '
        Me.btn_modificar_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_articulo.Enabled = False
        Me.btn_modificar_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_articulo.Location = New System.Drawing.Point(173, 9)
        Me.btn_modificar_articulo.Name = "btn_modificar_articulo"
        Me.btn_modificar_articulo.Size = New System.Drawing.Size(164, 35)
        Me.btn_modificar_articulo.TabIndex = 1
        Me.btn_modificar_articulo.Text = "Modificar Artículo"
        Me.btn_modificar_articulo.UseVisualStyleBackColor = True
        '
        'btn_eliminar_articulo
        '
        Me.btn_eliminar_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_articulo.Enabled = False
        Me.btn_eliminar_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_articulo.Location = New System.Drawing.Point(343, 9)
        Me.btn_eliminar_articulo.Name = "btn_eliminar_articulo"
        Me.btn_eliminar_articulo.Size = New System.Drawing.Size(164, 35)
        Me.btn_eliminar_articulo.TabIndex = 2
        Me.btn_eliminar_articulo.Text = "Eliminar Artículo"
        Me.btn_eliminar_articulo.UseVisualStyleBackColor = True
        '
        'dg_proveedores
        '
        Me.dg_proveedores.AllowUserToAddRows = False
        Me.dg_proveedores.AllowUserToDeleteRows = False
        Me.dg_proveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_proveedores.AutoGenerateColumns = False
        Me.dg_proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_proveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDeProveedorDataGridViewTextBoxColumn, Me.NombreDeProveedorDataGridViewTextBoxColumn, Me.datos})
        Me.dg_proveedores.DataSource = Me.ProveedorBindingSource
        Me.dg_proveedores.Location = New System.Drawing.Point(6, 6)
        Me.dg_proveedores.MultiSelect = False
        Me.dg_proveedores.Name = "dg_proveedores"
        Me.dg_proveedores.ReadOnly = True
        Me.dg_proveedores.Size = New System.Drawing.Size(271, 328)
        Me.dg_proveedores.TabIndex = 4
        '
        'datos
        '
        Me.datos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datos.DefaultCellStyle = DataGridViewCellStyle3
        Me.datos.HeaderText = " "
        Me.datos.Name = "datos"
        Me.datos.ReadOnly = True
        Me.datos.Text = "VER DATOS"
        Me.datos.UseColumnTextForButtonValue = True
        '
        'tab_inventario
        '
        Me.tab_inventario.Controls.Add(Me.TableLayoutPanel7)
        Me.tab_inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_inventario.ImageIndex = 3
        Me.tab_inventario.Location = New System.Drawing.Point(4, 54)
        Me.tab_inventario.Name = "tab_inventario"
        Me.tab_inventario.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_inventario.Size = New System.Drawing.Size(791, 391)
        Me.tab_inventario.TabIndex = 4
        Me.tab_inventario.Text = "INVENTARIO"
        Me.tab_inventario.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.dg_inventario, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel8, 1, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(791, 391)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'dg_inventario
        '
        Me.dg_inventario.AllowUserToAddRows = False
        Me.dg_inventario.AllowUserToDeleteRows = False
        Me.dg_inventario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_inventario.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_inventario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_inventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDeArticuloDataGridViewTextBoxColumn1, Me.UnidadesDisponiblesDataGridViewTextBoxColumn})
        Me.dg_inventario.DataSource = Me.InventarioBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_inventario.DefaultCellStyle = DataGridViewCellStyle5
        Me.dg_inventario.Location = New System.Drawing.Point(3, 3)
        Me.dg_inventario.Name = "dg_inventario"
        Me.dg_inventario.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_inventario.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dg_inventario.Size = New System.Drawing.Size(666, 385)
        Me.dg_inventario.TabIndex = 0
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.btn_restar_unidades, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.btn_añadir_unidades, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.btn_añadir_articulo_inventario, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.btn_eliminar_articulo_inventario, 0, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_busqueda_inventario, 0, 4)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(675, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 6
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(113, 385)
        Me.TableLayoutPanel8.TabIndex = 1
        '
        'btn_restar_unidades
        '
        Me.btn_restar_unidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_restar_unidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_restar_unidades.Location = New System.Drawing.Point(3, 45)
        Me.btn_restar_unidades.Name = "btn_restar_unidades"
        Me.btn_restar_unidades.Size = New System.Drawing.Size(107, 23)
        Me.btn_restar_unidades.TabIndex = 1
        Me.btn_restar_unidades.Text = "RESTAR UDS"
        Me.btn_restar_unidades.UseVisualStyleBackColor = True
        '
        'btn_añadir_unidades
        '
        Me.btn_añadir_unidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_unidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_unidades.Location = New System.Drawing.Point(3, 7)
        Me.btn_añadir_unidades.Name = "btn_añadir_unidades"
        Me.btn_añadir_unidades.Size = New System.Drawing.Size(107, 23)
        Me.btn_añadir_unidades.TabIndex = 0
        Me.btn_añadir_unidades.Text = "AÑADIR UDS"
        Me.btn_añadir_unidades.UseVisualStyleBackColor = True
        '
        'btn_añadir_articulo_inventario
        '
        Me.btn_añadir_articulo_inventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_articulo_inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_articulo_inventario.Location = New System.Drawing.Point(3, 83)
        Me.btn_añadir_articulo_inventario.Name = "btn_añadir_articulo_inventario"
        Me.btn_añadir_articulo_inventario.Size = New System.Drawing.Size(107, 23)
        Me.btn_añadir_articulo_inventario.TabIndex = 2
        Me.btn_añadir_articulo_inventario.Text = "AÑADIR ART"
        Me.btn_añadir_articulo_inventario.UseVisualStyleBackColor = True
        '
        'btn_eliminar_articulo_inventario
        '
        Me.btn_eliminar_articulo_inventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_articulo_inventario.Enabled = False
        Me.btn_eliminar_articulo_inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_articulo_inventario.Location = New System.Drawing.Point(3, 121)
        Me.btn_eliminar_articulo_inventario.Name = "btn_eliminar_articulo_inventario"
        Me.btn_eliminar_articulo_inventario.Size = New System.Drawing.Size(107, 23)
        Me.btn_eliminar_articulo_inventario.TabIndex = 3
        Me.btn_eliminar_articulo_inventario.Text = "BORRAR ART"
        Me.btn_eliminar_articulo_inventario.UseVisualStyleBackColor = True
        '
        'txt_busqueda_inventario
        '
        Me.txt_busqueda_inventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_busqueda_inventario.Location = New System.Drawing.Point(3, 161)
        Me.txt_busqueda_inventario.Name = "txt_busqueda_inventario"
        Me.txt_busqueda_inventario.Size = New System.Drawing.Size(107, 20)
        Me.txt_busqueda_inventario.TabIndex = 4
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "banco.ico")
        Me.ImageList1.Images.SetKeyName(1, "cliente.ico")
        Me.ImageList1.Images.SetKeyName(2, "articulo.ico")
        Me.ImageList1.Images.SetKeyName(3, "inventario.ico")
        Me.ImageList1.Images.SetKeyName(4, "configuraciones.ico")
        '
        'btn_efectuar_venta
        '
        Me.btn_efectuar_venta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_efectuar_venta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_efectuar_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_efectuar_venta.Image = Global.MP_Lucas_Sanz.My.Resources.Resources.venta
        Me.btn_efectuar_venta.Location = New System.Drawing.Point(8, 8)
        Me.btn_efectuar_venta.Margin = New System.Windows.Forms.Padding(8)
        Me.btn_efectuar_venta.Name = "btn_efectuar_venta"
        Me.btn_efectuar_venta.Size = New System.Drawing.Size(379, 179)
        Me.btn_efectuar_venta.TabIndex = 0
        Me.btn_efectuar_venta.Text = "VENTA"
        Me.btn_efectuar_venta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_efectuar_venta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_efectuar_venta.UseVisualStyleBackColor = False
        '
        'btn_menu_inventario
        '
        Me.btn_menu_inventario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_menu_inventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_menu_inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_inventario.Image = Global.MP_Lucas_Sanz.My.Resources.Resources.familia
        Me.btn_menu_inventario.Location = New System.Drawing.Point(403, 8)
        Me.btn_menu_inventario.Margin = New System.Windows.Forms.Padding(8)
        Me.btn_menu_inventario.Name = "btn_menu_inventario"
        Me.btn_menu_inventario.Size = New System.Drawing.Size(380, 179)
        Me.btn_menu_inventario.TabIndex = 2
        Me.btn_menu_inventario.Text = "INVENTARIO"
        Me.btn_menu_inventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_menu_inventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_menu_inventario.UseVisualStyleBackColor = False
        '
        'btn_menu_configuraciones
        '
        Me.btn_menu_configuraciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_menu_configuraciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_menu_configuraciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_configuraciones.Image = Global.MP_Lucas_Sanz.My.Resources.Resources.configuraciones
        Me.btn_menu_configuraciones.Location = New System.Drawing.Point(403, 203)
        Me.btn_menu_configuraciones.Margin = New System.Windows.Forms.Padding(8)
        Me.btn_menu_configuraciones.Name = "btn_menu_configuraciones"
        Me.btn_menu_configuraciones.Size = New System.Drawing.Size(380, 180)
        Me.btn_menu_configuraciones.TabIndex = 3
        Me.btn_menu_configuraciones.Text = "CONFIGURACIONES"
        Me.btn_menu_configuraciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_menu_configuraciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_menu_configuraciones.UseVisualStyleBackColor = False
        '
        'btn_efectuar_compra
        '
        Me.btn_efectuar_compra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_efectuar_compra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_efectuar_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_efectuar_compra.Image = Global.MP_Lucas_Sanz.My.Resources.Resources.inventario
        Me.btn_efectuar_compra.Location = New System.Drawing.Point(8, 203)
        Me.btn_efectuar_compra.Margin = New System.Windows.Forms.Padding(8)
        Me.btn_efectuar_compra.Name = "btn_efectuar_compra"
        Me.btn_efectuar_compra.Size = New System.Drawing.Size(379, 180)
        Me.btn_efectuar_compra.TabIndex = 1
        Me.btn_efectuar_compra.Text = "COMPRA"
        Me.btn_efectuar_compra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_efectuar_compra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_efectuar_compra.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.ImageIndex = 4
        Me.TabPage1.Location = New System.Drawing.Point(4, 54)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(791, 391)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "CONFIGURACIONES"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        'CodigoDelClienteDataGridViewTextBoxColumn
        '
        Me.CodigoDelClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CodigoDelClienteDataGridViewTextBoxColumn.DataPropertyName = "CodigoDelCliente"
        Me.CodigoDelClienteDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDelClienteDataGridViewTextBoxColumn.Name = "CodigoDelClienteDataGridViewTextBoxColumn"
        Me.CodigoDelClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDelClienteDataGridViewTextBoxColumn
        '
        Me.NombreDelClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDelClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreDelCliente"
        Me.NombreDelClienteDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDelClienteDataGridViewTextBoxColumn.Name = "NombreDelClienteDataGridViewTextBoxColumn"
        Me.NombreDelClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NifDelClienteDataGridViewTextBoxColumn
        '
        Me.NifDelClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NifDelClienteDataGridViewTextBoxColumn.DataPropertyName = "NifDelCliente"
        Me.NifDelClienteDataGridViewTextBoxColumn.HeaderText = "NIF"
        Me.NifDelClienteDataGridViewTextBoxColumn.Name = "NifDelClienteDataGridViewTextBoxColumn"
        Me.NifDelClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDelClienteDataGridViewTextBoxColumn
        '
        Me.DireccionDelClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DireccionDelClienteDataGridViewTextBoxColumn.DataPropertyName = "DireccionDelCliente"
        Me.DireccionDelClienteDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DireccionDelClienteDataGridViewTextBoxColumn.Name = "DireccionDelClienteDataGridViewTextBoxColumn"
        Me.DireccionDelClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDeNacimientoDelClienteDataGridViewTextBoxColumn
        '
        Me.FechaDeNacimientoDelClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaDeNacimientoDelClienteDataGridViewTextBoxColumn.DataPropertyName = "FechaDeNacimientoDelCliente"
        Me.FechaDeNacimientoDelClienteDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento"
        Me.FechaDeNacimientoDelClienteDataGridViewTextBoxColumn.Name = "FechaDeNacimientoDelClienteDataGridViewTextBoxColumn"
        Me.FechaDeNacimientoDelClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BancoDelClienteDataGridViewTextBoxColumn
        '
        Me.BancoDelClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BancoDelClienteDataGridViewTextBoxColumn.DataPropertyName = "BancoDelCliente"
        Me.BancoDelClienteDataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.BancoDelClienteDataGridViewTextBoxColumn.Name = "BancoDelClienteDataGridViewTextBoxColumn"
        Me.BancoDelClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GrupoDelClienteDataGridViewTextBoxColumn
        '
        Me.GrupoDelClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GrupoDelClienteDataGridViewTextBoxColumn.DataPropertyName = "GrupoDelCliente"
        Me.GrupoDelClienteDataGridViewTextBoxColumn.HeaderText = "Grupo"
        Me.GrupoDelClienteDataGridViewTextBoxColumn.Name = "GrupoDelClienteDataGridViewTextBoxColumn"
        Me.GrupoDelClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDelClienteDataGridViewTextBoxColumn
        '
        Me.EmailDelClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmailDelClienteDataGridViewTextBoxColumn.DataPropertyName = "EmailDelCliente"
        Me.EmailDelClienteDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDelClienteDataGridViewTextBoxColumn.Name = "EmailDelClienteDataGridViewTextBoxColumn"
        Me.EmailDelClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataSource = GetType(MP_Lucas_Sanz.Cliente)
        '
        'CodigoDeGrupoDataGridViewTextBoxColumn
        '
        Me.CodigoDeGrupoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CodigoDeGrupoDataGridViewTextBoxColumn.DataPropertyName = "CodigoDeGrupo"
        Me.CodigoDeGrupoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDeGrupoDataGridViewTextBoxColumn.Name = "CodigoDeGrupoDataGridViewTextBoxColumn"
        Me.CodigoDeGrupoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDeGrupoDataGridViewTextBoxColumn
        '
        Me.NombreDeGrupoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDeGrupoDataGridViewTextBoxColumn.DataPropertyName = "NombreDeGrupo"
        Me.NombreDeGrupoDataGridViewTextBoxColumn.HeaderText = "Nombre del Grupo"
        Me.NombreDeGrupoDataGridViewTextBoxColumn.Name = "NombreDeGrupoDataGridViewTextBoxColumn"
        Me.NombreDeGrupoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GrupoBindingSource
        '
        Me.GrupoBindingSource.DataSource = GetType(MP_Lucas_Sanz.Grupo)
        '
        'CodigoDeArticuloDataGridViewTextBoxColumn
        '
        Me.CodigoDeArticuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CodigoDeArticuloDataGridViewTextBoxColumn.DataPropertyName = "CodigoDeArticulo"
        Me.CodigoDeArticuloDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDeArticuloDataGridViewTextBoxColumn.Name = "CodigoDeArticuloDataGridViewTextBoxColumn"
        Me.CodigoDeArticuloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDeArticuloDataGridViewTextBoxColumn
        '
        Me.NombreDeArticuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDeArticuloDataGridViewTextBoxColumn.DataPropertyName = "NombreDeArticulo"
        Me.NombreDeArticuloDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDeArticuloDataGridViewTextBoxColumn.Name = "NombreDeArticuloDataGridViewTextBoxColumn"
        Me.NombreDeArticuloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDeArticuloDataGridViewTextBoxColumn
        '
        Me.DescripcionDeArticuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDeArticuloDataGridViewTextBoxColumn.DataPropertyName = "DescripcionDeArticulo"
        Me.DescripcionDeArticuloDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDeArticuloDataGridViewTextBoxColumn.Name = "DescripcionDeArticuloDataGridViewTextBoxColumn"
        Me.DescripcionDeArticuloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PVPCompraDeArticuloDataGridViewTextBoxColumn
        '
        Me.PVPCompraDeArticuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PVPCompraDeArticuloDataGridViewTextBoxColumn.DataPropertyName = "PVPCompraDeArticulo"
        Me.PVPCompraDeArticuloDataGridViewTextBoxColumn.HeaderText = "PVP Compra"
        Me.PVPCompraDeArticuloDataGridViewTextBoxColumn.Name = "PVPCompraDeArticuloDataGridViewTextBoxColumn"
        Me.PVPCompraDeArticuloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PVPVentaDeArticuloDataGridViewTextBoxColumn
        '
        Me.PVPVentaDeArticuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PVPVentaDeArticuloDataGridViewTextBoxColumn.DataPropertyName = "PVPVentaDeArticulo"
        Me.PVPVentaDeArticuloDataGridViewTextBoxColumn.HeaderText = "PVP Venta"
        Me.PVPVentaDeArticuloDataGridViewTextBoxColumn.Name = "PVPVentaDeArticuloDataGridViewTextBoxColumn"
        Me.PVPVentaDeArticuloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PorcentajeDeBeneficioDataGridViewTextBoxColumn
        '
        Me.PorcentajeDeBeneficioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PorcentajeDeBeneficioDataGridViewTextBoxColumn.DataPropertyName = "PorcentajeDeBeneficio"
        Me.PorcentajeDeBeneficioDataGridViewTextBoxColumn.HeaderText = "% Beneficio"
        Me.PorcentajeDeBeneficioDataGridViewTextBoxColumn.Name = "PorcentajeDeBeneficioDataGridViewTextBoxColumn"
        Me.PorcentajeDeBeneficioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDeUnidadArticuloDataGridViewTextBoxColumn
        '
        Me.TipoDeUnidadArticuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TipoDeUnidadArticuloDataGridViewTextBoxColumn.DataPropertyName = "TipoDeUnidadArticulo"
        Me.TipoDeUnidadArticuloDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.TipoDeUnidadArticuloDataGridViewTextBoxColumn.Name = "TipoDeUnidadArticuloDataGridViewTextBoxColumn"
        Me.TipoDeUnidadArticuloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FamiliaDeArticuloDataGridViewTextBoxColumn
        '
        Me.FamiliaDeArticuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FamiliaDeArticuloDataGridViewTextBoxColumn.DataPropertyName = "FamiliaDeArticulo"
        Me.FamiliaDeArticuloDataGridViewTextBoxColumn.HeaderText = "Familia"
        Me.FamiliaDeArticuloDataGridViewTextBoxColumn.Name = "FamiliaDeArticuloDataGridViewTextBoxColumn"
        Me.FamiliaDeArticuloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArticuloBindingSource
        '
        Me.ArticuloBindingSource.DataSource = GetType(MP_Lucas_Sanz.Articulo)
        '
        'CodigoDeProveedorDataGridViewTextBoxColumn
        '
        Me.CodigoDeProveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CodigoDeProveedorDataGridViewTextBoxColumn.DataPropertyName = "CodigoDeProveedor"
        Me.CodigoDeProveedorDataGridViewTextBoxColumn.HeaderText = "Código Proveedor"
        Me.CodigoDeProveedorDataGridViewTextBoxColumn.Name = "CodigoDeProveedorDataGridViewTextBoxColumn"
        Me.CodigoDeProveedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDeProveedorDataGridViewTextBoxColumn
        '
        Me.NombreDeProveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDeProveedorDataGridViewTextBoxColumn.DataPropertyName = "NombreDeProveedor"
        Me.NombreDeProveedorDataGridViewTextBoxColumn.HeaderText = "Nombre Proveedor"
        Me.NombreDeProveedorDataGridViewTextBoxColumn.Name = "NombreDeProveedorDataGridViewTextBoxColumn"
        Me.NombreDeProveedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataSource = GetType(MP_Lucas_Sanz.Proveedor)
        '
        'NombreDeArticuloDataGridViewTextBoxColumn1
        '
        Me.NombreDeArticuloDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDeArticuloDataGridViewTextBoxColumn1.DataPropertyName = "NombreDeArticulo"
        Me.NombreDeArticuloDataGridViewTextBoxColumn1.HeaderText = "NOMBRE ARTÍCULO"
        Me.NombreDeArticuloDataGridViewTextBoxColumn1.Name = "NombreDeArticuloDataGridViewTextBoxColumn1"
        Me.NombreDeArticuloDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'UnidadesDisponiblesDataGridViewTextBoxColumn
        '
        Me.UnidadesDisponiblesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UnidadesDisponiblesDataGridViewTextBoxColumn.DataPropertyName = "UnidadesDisponibles"
        Me.UnidadesDisponiblesDataGridViewTextBoxColumn.HeaderText = "UNIDADES DISPONIBLES"
        Me.UnidadesDisponiblesDataGridViewTextBoxColumn.Name = "UnidadesDisponiblesDataGridViewTextBoxColumn"
        Me.UnidadesDisponiblesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InventarioBindingSource
        '
        Me.InventarioBindingSource.DataSource = GetType(MP_Lucas_Sanz.Inventario)
        '
        'BancoBindingSource
        '
        Me.BancoBindingSource.DataSource = GetType(MP_Lucas_Sanz.Banco)
        '
        'GrupoBindingSource1
        '
        Me.GrupoBindingSource1.DataSource = GetType(MP_Lucas_Sanz.Grupo)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tab_main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "MARCO POLO - VERSIÓN LUCAS SANZ"
        Me.tab_main.ResumeLayout(False)
        Me.tab_menu_principal.ResumeLayout(False)
        Me.tlp_menu_main.ResumeLayout(False)
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
        Me.tab_articulos_proveedores.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.dg_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_inventario.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.dg_inventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.FormaPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_main As TabControl
    Friend WithEvents tab_bancos_pagos As TabPage
    Friend WithEvents tab_menu_principal As TabPage
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
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Public WithEvents btn_añadir_grupo As Button
    Friend WithEvents btn_modificar_grupo As Button
    Friend WithEvents btn_eliminar_grupo As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btn_añadir_cliente As Button
    Friend WithEvents btn_modificar_cliente As Button
    Friend WithEvents btn_eliminar_cliente As Button
    Friend WithEvents dg_grupos As DataGridView
    Friend WithEvents GrupoBindingSource As BindingSource
    Friend WithEvents GrupoBindingSource1 As BindingSource
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents CodigoDelClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDelClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NifDelClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDelClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeNacimientoDelClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BancoDelClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrupoDelClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDelClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDeGrupoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDeGrupoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tab_articulos_proveedores As TabPage
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents dg_articulos As DataGridView
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Public WithEvents btn_añadir_proveedor As Button
    Friend WithEvents btn_modificar_proveedor As Button
    Friend WithEvents btn_eliminar_proveedor As Button
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btn_añadir_articulo As Button
    Friend WithEvents btn_modificar_articulo As Button
    Friend WithEvents btn_eliminar_articulo As Button
    Friend WithEvents dg_proveedores As DataGridView
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents CodigoDeProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDeProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents datos As DataGridViewButtonColumn
    Friend WithEvents CodigoDeArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDeArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDeArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PVPCompraDeArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PVPVentaDeArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeDeBeneficioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDeUnidadArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FamiliaDeArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArticuloBindingSource As BindingSource
    Friend WithEvents tab_inventario As TabPage
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents dg_inventario As DataGridView
    Friend WithEvents NombreDeArticuloDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UnidadesDisponiblesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventarioBindingSource As BindingSource
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents btn_restar_unidades As Button
    Friend WithEvents btn_añadir_unidades As Button
    Friend WithEvents btn_añadir_articulo_inventario As Button
    Friend WithEvents btn_eliminar_articulo_inventario As Button
    Friend WithEvents txt_busqueda_inventario As TextBox
    Friend WithEvents tlp_menu_main As TableLayoutPanel
    Friend WithEvents btn_efectuar_venta As Button
    Friend WithEvents btn_efectuar_compra As Button
    Friend WithEvents nombreBanco As DataGridViewTextBoxColumn
    Friend WithEvents codigoBanco As DataGridViewTextBoxColumn
    Friend WithEvents btn_menu_inventario As Button
    Friend WithEvents btn_menu_configuraciones As Button
    Friend WithEvents TabPage1 As TabPage
End Class

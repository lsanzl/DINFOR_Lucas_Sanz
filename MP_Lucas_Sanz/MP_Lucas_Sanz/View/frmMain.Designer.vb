<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tab_main = New System.Windows.Forms.TabControl()
        Me.tab_menu_principal = New System.Windows.Forms.TabPage()
        Me.tlp_menu_main = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_menu_factura = New System.Windows.Forms.Button()
        Me.btn_menu_configuraciones = New System.Windows.Forms.Button()
        Me.TableLayoutPanel16 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_efectuar_venta = New System.Windows.Forms.Button()
        Me.btn_ver_ventas = New System.Windows.Forms.Button()
        Me.TableLayoutPanel17 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_ver_compras = New System.Windows.Forms.Button()
        Me.btn_efectuar_compra = New System.Windows.Forms.Button()
        Me.tab_bancos_pagos = New System.Windows.Forms.TabPage()
        Me.tlp_main_bancos_pagos = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_busqueda_forma_pago = New System.Windows.Forms.TextBox()
        Me.gb_formas_pago = New System.Windows.Forms.GroupBox()
        Me.rdb_nombre_forma_pago = New System.Windows.Forms.RadioButton()
        Me.rdb_codigo_forma_pago = New System.Windows.Forms.RadioButton()
        Me.dg_bancos = New System.Windows.Forms.DataGridView()
        Me.nombreBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg_formas_pago = New System.Windows.Forms.DataGridView()
        Me.idFormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreFormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bancoFormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.activoFormaPago = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.numPlazosFormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.primerPlazoFormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.intervaloFormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlp_bancos = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_añadir_banco = New System.Windows.Forms.Button()
        Me.btn_modificar_banco = New System.Windows.Forms.Button()
        Me.btn_eliminar_banco = New System.Windows.Forms.Button()
        Me.tlp_pagos = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_añadir_forma_pago = New System.Windows.Forms.Button()
        Me.btn_modificar_forma_pago = New System.Windows.Forms.Button()
        Me.btn_eliminar_forma_pago = New System.Windows.Forms.Button()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_busqueda_banco = New System.Windows.Forms.TextBox()
        Me.gb_bancos = New System.Windows.Forms.GroupBox()
        Me.rdb_nombre_banco = New System.Windows.Forms.RadioButton()
        Me.rdb_codigo_banco = New System.Windows.Forms.RadioButton()
        Me.tab_clientes_grupos = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dg_clientes = New System.Windows.Forms.DataGridView()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nifCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNacimientoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccionCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emailCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grupoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bancoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_añadir_grupo = New System.Windows.Forms.Button()
        Me.btn_modificar_grupo = New System.Windows.Forms.Button()
        Me.btn_eliminar_grupo = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_añadir_cliente = New System.Windows.Forms.Button()
        Me.btn_modificar_cliente = New System.Windows.Forms.Button()
        Me.btn_eliminar_cliente = New System.Windows.Forms.Button()
        Me.dg_grupos = New System.Windows.Forms.DataGridView()
        Me.idGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.gb_grupos = New System.Windows.Forms.GroupBox()
        Me.rdb_nombre_grupo = New System.Windows.Forms.RadioButton()
        Me.rdb_codigo_grupo = New System.Windows.Forms.RadioButton()
        Me.txt_busqueda_grupo = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_busqueda_cliente = New System.Windows.Forms.TextBox()
        Me.gb_clientes = New System.Windows.Forms.GroupBox()
        Me.rdb_nif_cliente = New System.Windows.Forms.RadioButton()
        Me.rdb_nombre_cliente = New System.Windows.Forms.RadioButton()
        Me.rdb_id_cliente = New System.Windows.Forms.RadioButton()
        Me.tab_articulos_proveedores = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_busqueda_articulo = New System.Windows.Forms.TextBox()
        Me.gb_articulos = New System.Windows.Forms.GroupBox()
        Me.rdb_nombre_articulo = New System.Windows.Forms.RadioButton()
        Me.rdb_codigo_articulo = New System.Windows.Forms.RadioButton()
        Me.dg_articulos = New System.Windows.Forms.DataGridView()
        Me.idArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreArticuloo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcionArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pvpCompraArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pvpVentaArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impuestoArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.porcBeneficioArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoUnidadArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.familiaArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_añadir_proveedor = New System.Windows.Forms.Button()
        Me.btn_modificar_proveedor = New System.Windows.Forms.Button()
        Me.btn_eliminar_proveedor = New System.Windows.Forms.Button()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_añadir_articulo = New System.Windows.Forms.Button()
        Me.btn_modificar_articulo = New System.Windows.Forms.Button()
        Me.btn_eliminar_articulo = New System.Windows.Forms.Button()
        Me.dg_proveedores = New System.Windows.Forms.DataGridView()
        Me.idProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.gb_proveedores = New System.Windows.Forms.GroupBox()
        Me.rdb_nombre_proveedor = New System.Windows.Forms.RadioButton()
        Me.rdb_codigo_proveedor = New System.Windows.Forms.RadioButton()
        Me.txt_busqueda_proveedor = New System.Windows.Forms.TextBox()
        Me.tab_inventario = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.dg_inventario = New System.Windows.Forms.DataGridView()
        Me.idInventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stockActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_restar_unidades = New System.Windows.Forms.Button()
        Me.btn_añadir_unidades = New System.Windows.Forms.Button()
        Me.btn_añadir_articulo_inventario = New System.Windows.Forms.Button()
        Me.txt_busqueda_inventario = New System.Windows.Forms.TextBox()
        Me.btn_eliminar_articulo_inventario = New System.Windows.Forms.Button()
        Me.dg_movimientos = New System.Windows.Forms.DataGridView()
        Me.idMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuarioMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.articuloMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.facturaMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stockMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab_albaranes = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel18 = New System.Windows.Forms.TableLayoutPanel()
        Me.dg_albaranes = New System.Windows.Forms.DataGridView()
        Me.idAlbaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.personaAlbaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.formaPagoAlbaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaAlbaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoAlbaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.facturaAlbaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.verAlbaran = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TableLayoutPanel19 = New System.Windows.Forms.TableLayoutPanel()
        Me.gb_ver_estado_albaranes = New System.Windows.Forms.GroupBox()
        Me.rdb_albaranes_eliminados = New System.Windows.Forms.RadioButton()
        Me.rdb_albaranes_activos = New System.Windows.Forms.RadioButton()
        Me.btn_eliminar_compra = New System.Windows.Forms.Button()
        Me.gb_ver_albaranes = New System.Windows.Forms.GroupBox()
        Me.rdb_ver_compras = New System.Windows.Forms.RadioButton()
        Me.rdb_ver_ventas = New System.Windows.Forms.RadioButton()
        Me.dp_busqueda_inicio_albaran = New System.Windows.Forms.DateTimePicker()
        Me.dp_busqueda_fin_albaran = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_busqueda_albaran_entidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_busqueda_albaran_factura = New System.Windows.Forms.TextBox()
        Me.tab_facturas = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel20 = New System.Windows.Forms.TableLayoutPanel()
        Me.dg_facturas = New System.Windows.Forms.DataGridView()
        Me.idFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entidadFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.listaAlbaranesFactura = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.estadoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel21 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_busqueda_factura = New System.Windows.Forms.Button()
        Me.btn_facturar_albaran = New System.Windows.Forms.Button()
        Me.btn_cambiar_estado_factura = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tab_configuraciones = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_actualizacion_campo_extra = New System.Windows.Forms.Button()
        Me.btn_actualizacion_añadir_tabla = New System.Windows.Forms.Button()
        Me.btn_actualizacion_añadir_fk = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FormaPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GrupoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.gb_tipos_factura = New System.Windows.Forms.GroupBox()
        Me.rdb_facturas_venta = New System.Windows.Forms.RadioButton()
        Me.rdb_facturas_compra = New System.Windows.Forms.RadioButton()
        Me.tab_main.SuspendLayout()
        Me.tab_menu_principal.SuspendLayout()
        Me.tlp_menu_main.SuspendLayout()
        Me.TableLayoutPanel16.SuspendLayout()
        Me.TableLayoutPanel17.SuspendLayout()
        Me.tab_bancos_pagos.SuspendLayout()
        Me.tlp_main_bancos_pagos.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.gb_formas_pago.SuspendLayout()
        CType(Me.dg_bancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_formas_pago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlp_bancos.SuspendLayout()
        Me.tlp_pagos.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.gb_bancos.SuspendLayout()
        Me.tab_clientes_grupos.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dg_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.dg_grupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.gb_grupos.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.gb_clientes.SuspendLayout()
        Me.tab_articulos_proveedores.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        Me.gb_articulos.SuspendLayout()
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.dg_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.gb_proveedores.SuspendLayout()
        Me.tab_inventario.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.dg_inventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.dg_movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_albaranes.SuspendLayout()
        Me.TableLayoutPanel18.SuspendLayout()
        CType(Me.dg_albaranes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel19.SuspendLayout()
        Me.gb_ver_estado_albaranes.SuspendLayout()
        Me.gb_ver_albaranes.SuspendLayout()
        Me.tab_facturas.SuspendLayout()
        Me.TableLayoutPanel20.SuspendLayout()
        CType(Me.dg_facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel21.SuspendLayout()
        Me.tab_configuraciones.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_tipos_factura.SuspendLayout()
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
        Me.tab_main.Controls.Add(Me.tab_albaranes)
        Me.tab_main.Controls.Add(Me.tab_facturas)
        Me.tab_main.Controls.Add(Me.tab_configuraciones)
        Me.tab_main.ImageList = Me.ImageList1
        Me.tab_main.ItemSize = New System.Drawing.Size(78, 50)
        Me.tab_main.Location = New System.Drawing.Point(0, 2)
        Me.tab_main.Name = "tab_main"
        Me.tab_main.SelectedIndex = 0
        Me.tab_main.Size = New System.Drawing.Size(799, 446)
        Me.tab_main.TabIndex = 0
        '
        'tab_menu_principal
        '
        Me.tab_menu_principal.Controls.Add(Me.tlp_menu_main)
        Me.tab_menu_principal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_menu_principal.Location = New System.Drawing.Point(4, 54)
        Me.tab_menu_principal.Name = "tab_menu_principal"
        Me.tab_menu_principal.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_menu_principal.Size = New System.Drawing.Size(791, 388)
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
        Me.tlp_menu_main.Controls.Add(Me.btn_menu_factura, 1, 0)
        Me.tlp_menu_main.Controls.Add(Me.btn_menu_configuraciones, 1, 1)
        Me.tlp_menu_main.Controls.Add(Me.TableLayoutPanel16, 0, 0)
        Me.tlp_menu_main.Controls.Add(Me.TableLayoutPanel17, 0, 1)
        Me.tlp_menu_main.Location = New System.Drawing.Point(0, 0)
        Me.tlp_menu_main.Name = "tlp_menu_main"
        Me.tlp_menu_main.RowCount = 2
        Me.tlp_menu_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_menu_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_menu_main.Size = New System.Drawing.Size(791, 391)
        Me.tlp_menu_main.TabIndex = 0
        '
        'btn_menu_factura
        '
        Me.btn_menu_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_menu_factura.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_menu_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_factura.Image = Global.MP_Lucas_Sanz.My.Resources.Resources.factura
        Me.btn_menu_factura.Location = New System.Drawing.Point(403, 8)
        Me.btn_menu_factura.Margin = New System.Windows.Forms.Padding(8)
        Me.btn_menu_factura.Name = "btn_menu_factura"
        Me.btn_menu_factura.Size = New System.Drawing.Size(380, 179)
        Me.btn_menu_factura.TabIndex = 2
        Me.btn_menu_factura.Text = "FACTURA"
        Me.btn_menu_factura.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_menu_factura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_menu_factura.UseVisualStyleBackColor = False
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
        'TableLayoutPanel16
        '
        Me.TableLayoutPanel16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel16.ColumnCount = 1
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel16.Controls.Add(Me.btn_efectuar_venta, 0, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.btn_ver_ventas, 0, 1)
        Me.TableLayoutPanel16.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel16.Name = "TableLayoutPanel16"
        Me.TableLayoutPanel16.RowCount = 2
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel16.Size = New System.Drawing.Size(389, 189)
        Me.TableLayoutPanel16.TabIndex = 4
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
        Me.btn_efectuar_venta.Margin = New System.Windows.Forms.Padding(8, 8, 8, 0)
        Me.btn_efectuar_venta.Name = "btn_efectuar_venta"
        Me.btn_efectuar_venta.Size = New System.Drawing.Size(373, 133)
        Me.btn_efectuar_venta.TabIndex = 1
        Me.btn_efectuar_venta.Text = "VENTA"
        Me.btn_efectuar_venta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_efectuar_venta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_efectuar_venta.UseVisualStyleBackColor = False
        '
        'btn_ver_ventas
        '
        Me.btn_ver_ventas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ver_ventas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_ver_ventas.Location = New System.Drawing.Point(8, 144)
        Me.btn_ver_ventas.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.btn_ver_ventas.Name = "btn_ver_ventas"
        Me.btn_ver_ventas.Size = New System.Drawing.Size(373, 41)
        Me.btn_ver_ventas.TabIndex = 2
        Me.btn_ver_ventas.Text = "ALBARANES DE VENTA"
        Me.btn_ver_ventas.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel17
        '
        Me.TableLayoutPanel17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel17.ColumnCount = 1
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel17.Controls.Add(Me.btn_ver_compras, 0, 1)
        Me.TableLayoutPanel17.Controls.Add(Me.btn_efectuar_compra, 0, 0)
        Me.TableLayoutPanel17.Location = New System.Drawing.Point(3, 198)
        Me.TableLayoutPanel17.Name = "TableLayoutPanel17"
        Me.TableLayoutPanel17.RowCount = 2
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel17.Size = New System.Drawing.Size(389, 190)
        Me.TableLayoutPanel17.TabIndex = 5
        '
        'btn_ver_compras
        '
        Me.btn_ver_compras.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ver_compras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_ver_compras.Location = New System.Drawing.Point(8, 145)
        Me.btn_ver_compras.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.btn_ver_compras.Name = "btn_ver_compras"
        Me.btn_ver_compras.Size = New System.Drawing.Size(373, 41)
        Me.btn_ver_compras.TabIndex = 3
        Me.btn_ver_compras.Text = "ALBARANES DE COMPRA"
        Me.btn_ver_compras.UseVisualStyleBackColor = False
        '
        'btn_efectuar_compra
        '
        Me.btn_efectuar_compra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_efectuar_compra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_efectuar_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_efectuar_compra.Image = Global.MP_Lucas_Sanz.My.Resources.Resources.inventario
        Me.btn_efectuar_compra.Location = New System.Drawing.Point(8, 8)
        Me.btn_efectuar_compra.Margin = New System.Windows.Forms.Padding(8, 8, 8, 0)
        Me.btn_efectuar_compra.Name = "btn_efectuar_compra"
        Me.btn_efectuar_compra.Size = New System.Drawing.Size(373, 134)
        Me.btn_efectuar_compra.TabIndex = 2
        Me.btn_efectuar_compra.Text = "COMPRA"
        Me.btn_efectuar_compra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_efectuar_compra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_efectuar_compra.UseVisualStyleBackColor = False
        '
        'tab_bancos_pagos
        '
        Me.tab_bancos_pagos.Controls.Add(Me.tlp_main_bancos_pagos)
        Me.tab_bancos_pagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_bancos_pagos.ImageIndex = 0
        Me.tab_bancos_pagos.Location = New System.Drawing.Point(4, 54)
        Me.tab_bancos_pagos.Name = "tab_bancos_pagos"
        Me.tab_bancos_pagos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_bancos_pagos.Size = New System.Drawing.Size(791, 388)
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
        Me.tlp_main_bancos_pagos.Controls.Add(Me.TableLayoutPanel13, 1, 1)
        Me.tlp_main_bancos_pagos.Controls.Add(Me.dg_bancos, 0, 0)
        Me.tlp_main_bancos_pagos.Controls.Add(Me.dg_formas_pago, 1, 0)
        Me.tlp_main_bancos_pagos.Controls.Add(Me.tlp_bancos, 0, 2)
        Me.tlp_main_bancos_pagos.Controls.Add(Me.tlp_pagos, 1, 2)
        Me.tlp_main_bancos_pagos.Controls.Add(Me.TableLayoutPanel12, 0, 1)
        Me.tlp_main_bancos_pagos.Location = New System.Drawing.Point(0, 0)
        Me.tlp_main_bancos_pagos.Name = "tlp_main_bancos_pagos"
        Me.tlp_main_bancos_pagos.Padding = New System.Windows.Forms.Padding(3)
        Me.tlp_main_bancos_pagos.RowCount = 3
        Me.tlp_main_bancos_pagos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlp_main_bancos_pagos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_main_bancos_pagos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_main_bancos_pagos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_main_bancos_pagos.Size = New System.Drawing.Size(792, 396)
        Me.tlp_main_bancos_pagos.TabIndex = 0
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel13.ColumnCount = 2
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.txt_busqueda_forma_pago, 0, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.gb_formas_pago, 0, 0)
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(281, 279)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(505, 52)
        Me.TableLayoutPanel13.TabIndex = 7
        '
        'txt_busqueda_forma_pago
        '
        Me.txt_busqueda_forma_pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_busqueda_forma_pago.Location = New System.Drawing.Point(154, 16)
        Me.txt_busqueda_forma_pago.Name = "txt_busqueda_forma_pago"
        Me.txt_busqueda_forma_pago.Size = New System.Drawing.Size(348, 20)
        Me.txt_busqueda_forma_pago.TabIndex = 2
        '
        'gb_formas_pago
        '
        Me.gb_formas_pago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_formas_pago.Controls.Add(Me.rdb_nombre_forma_pago)
        Me.gb_formas_pago.Controls.Add(Me.rdb_codigo_forma_pago)
        Me.gb_formas_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_formas_pago.Location = New System.Drawing.Point(3, 3)
        Me.gb_formas_pago.Name = "gb_formas_pago"
        Me.gb_formas_pago.Size = New System.Drawing.Size(145, 46)
        Me.gb_formas_pago.TabIndex = 1
        Me.gb_formas_pago.TabStop = False
        Me.gb_formas_pago.Text = "Criterio"
        '
        'rdb_nombre_forma_pago
        '
        Me.rdb_nombre_forma_pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdb_nombre_forma_pago.AutoSize = True
        Me.rdb_nombre_forma_pago.Location = New System.Drawing.Point(67, 19)
        Me.rdb_nombre_forma_pago.Name = "rdb_nombre_forma_pago"
        Me.rdb_nombre_forma_pago.Size = New System.Drawing.Size(62, 17)
        Me.rdb_nombre_forma_pago.TabIndex = 1
        Me.rdb_nombre_forma_pago.TabStop = True
        Me.rdb_nombre_forma_pago.Text = "Nombre"
        Me.rdb_nombre_forma_pago.UseVisualStyleBackColor = True
        '
        'rdb_codigo_forma_pago
        '
        Me.rdb_codigo_forma_pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdb_codigo_forma_pago.AutoSize = True
        Me.rdb_codigo_forma_pago.Location = New System.Drawing.Point(8, 19)
        Me.rdb_codigo_forma_pago.Name = "rdb_codigo_forma_pago"
        Me.rdb_codigo_forma_pago.Size = New System.Drawing.Size(36, 17)
        Me.rdb_codigo_forma_pago.TabIndex = 0
        Me.rdb_codigo_forma_pago.TabStop = True
        Me.rdb_codigo_forma_pago.Text = "ID"
        Me.rdb_codigo_forma_pago.UseVisualStyleBackColor = True
        '
        'dg_bancos
        '
        Me.dg_bancos.AllowUserToAddRows = False
        Me.dg_bancos.AllowUserToDeleteRows = False
        Me.dg_bancos.AllowUserToResizeRows = False
        Me.dg_bancos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_bancos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_bancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_bancos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombreBanco, Me.codigoBanco})
        Me.dg_bancos.Location = New System.Drawing.Point(6, 6)
        Me.dg_bancos.MultiSelect = False
        Me.dg_bancos.Name = "dg_bancos"
        Me.dg_bancos.ReadOnly = True
        Me.dg_bancos.RowHeadersVisible = False
        Me.dg_bancos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_bancos.Size = New System.Drawing.Size(269, 267)
        Me.dg_bancos.TabIndex = 0
        '
        'nombreBanco
        '
        Me.nombreBanco.HeaderText = "Nombre Banco"
        Me.nombreBanco.Name = "nombreBanco"
        Me.nombreBanco.ReadOnly = True
        '
        'codigoBanco
        '
        Me.codigoBanco.HeaderText = "Código"
        Me.codigoBanco.Name = "codigoBanco"
        Me.codigoBanco.ReadOnly = True
        '
        'dg_formas_pago
        '
        Me.dg_formas_pago.AllowUserToAddRows = False
        Me.dg_formas_pago.AllowUserToDeleteRows = False
        Me.dg_formas_pago.AllowUserToResizeRows = False
        Me.dg_formas_pago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_formas_pago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_formas_pago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_formas_pago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idFormaPago, Me.nombreFormaPago, Me.bancoFormaPago, Me.activoFormaPago, Me.numPlazosFormaPago, Me.primerPlazoFormaPago, Me.intervaloFormaPago})
        Me.dg_formas_pago.Location = New System.Drawing.Point(281, 6)
        Me.dg_formas_pago.MultiSelect = False
        Me.dg_formas_pago.Name = "dg_formas_pago"
        Me.dg_formas_pago.RowHeadersVisible = False
        Me.dg_formas_pago.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_formas_pago.Size = New System.Drawing.Size(505, 267)
        Me.dg_formas_pago.TabIndex = 1
        '
        'idFormaPago
        '
        Me.idFormaPago.HeaderText = "ID"
        Me.idFormaPago.Name = "idFormaPago"
        Me.idFormaPago.ReadOnly = True
        Me.idFormaPago.Visible = False
        '
        'nombreFormaPago
        '
        Me.nombreFormaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombreFormaPago.HeaderText = "Nombre"
        Me.nombreFormaPago.Name = "nombreFormaPago"
        Me.nombreFormaPago.ReadOnly = True
        '
        'bancoFormaPago
        '
        Me.bancoFormaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.bancoFormaPago.HeaderText = "Banco"
        Me.bancoFormaPago.Name = "bancoFormaPago"
        Me.bancoFormaPago.ReadOnly = True
        '
        'activoFormaPago
        '
        Me.activoFormaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.activoFormaPago.HeaderText = "Activo"
        Me.activoFormaPago.Name = "activoFormaPago"
        Me.activoFormaPago.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.activoFormaPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.activoFormaPago.Width = 68
        '
        'numPlazosFormaPago
        '
        Me.numPlazosFormaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.numPlazosFormaPago.HeaderText = "Nº Plazos"
        Me.numPlazosFormaPago.Name = "numPlazosFormaPago"
        Me.numPlazosFormaPago.ReadOnly = True
        '
        'primerPlazoFormaPago
        '
        Me.primerPlazoFormaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.primerPlazoFormaPago.HeaderText = "Primer plazo"
        Me.primerPlazoFormaPago.Name = "primerPlazoFormaPago"
        Me.primerPlazoFormaPago.ReadOnly = True
        '
        'intervaloFormaPago
        '
        Me.intervaloFormaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.intervaloFormaPago.HeaderText = "Intervalo"
        Me.intervaloFormaPago.Name = "intervaloFormaPago"
        Me.intervaloFormaPago.ReadOnly = True
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
        Me.tlp_bancos.Location = New System.Drawing.Point(6, 337)
        Me.tlp_bancos.Name = "tlp_bancos"
        Me.tlp_bancos.RowCount = 1
        Me.tlp_bancos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_bancos.Size = New System.Drawing.Size(269, 53)
        Me.tlp_bancos.TabIndex = 2
        '
        'btn_añadir_banco
        '
        Me.btn_añadir_banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_banco.Location = New System.Drawing.Point(3, 9)
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
        Me.btn_modificar_banco.Location = New System.Drawing.Point(92, 9)
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
        Me.btn_eliminar_banco.Location = New System.Drawing.Point(181, 9)
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
        Me.tlp_pagos.Location = New System.Drawing.Point(281, 337)
        Me.tlp_pagos.Name = "tlp_pagos"
        Me.tlp_pagos.RowCount = 1
        Me.tlp_pagos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_pagos.Size = New System.Drawing.Size(505, 53)
        Me.tlp_pagos.TabIndex = 3
        '
        'btn_añadir_forma_pago
        '
        Me.btn_añadir_forma_pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_forma_pago.Location = New System.Drawing.Point(3, 9)
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
        Me.btn_modificar_forma_pago.Location = New System.Drawing.Point(171, 9)
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
        Me.btn_eliminar_forma_pago.Location = New System.Drawing.Point(339, 9)
        Me.btn_eliminar_forma_pago.Name = "btn_eliminar_forma_pago"
        Me.btn_eliminar_forma_pago.Size = New System.Drawing.Size(163, 35)
        Me.btn_eliminar_forma_pago.TabIndex = 2
        Me.btn_eliminar_forma_pago.Text = "Eliminar Forma Pago"
        Me.btn_eliminar_forma_pago.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel12.ColumnCount = 2
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.txt_busqueda_banco, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.gb_bancos, 0, 0)
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(6, 279)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 1
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(269, 52)
        Me.TableLayoutPanel12.TabIndex = 4
        '
        'txt_busqueda_banco
        '
        Me.txt_busqueda_banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_busqueda_banco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busqueda_banco.Location = New System.Drawing.Point(137, 16)
        Me.txt_busqueda_banco.Name = "txt_busqueda_banco"
        Me.txt_busqueda_banco.Size = New System.Drawing.Size(129, 20)
        Me.txt_busqueda_banco.TabIndex = 2
        '
        'gb_bancos
        '
        Me.gb_bancos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_bancos.Controls.Add(Me.rdb_nombre_banco)
        Me.gb_bancos.Controls.Add(Me.rdb_codigo_banco)
        Me.gb_bancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_bancos.Location = New System.Drawing.Point(3, 3)
        Me.gb_bancos.Name = "gb_bancos"
        Me.gb_bancos.Size = New System.Drawing.Size(128, 46)
        Me.gb_bancos.TabIndex = 1
        Me.gb_bancos.TabStop = False
        Me.gb_bancos.Text = "Criterio"
        '
        'rdb_nombre_banco
        '
        Me.rdb_nombre_banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdb_nombre_banco.AutoSize = True
        Me.rdb_nombre_banco.Location = New System.Drawing.Point(61, 19)
        Me.rdb_nombre_banco.Name = "rdb_nombre_banco"
        Me.rdb_nombre_banco.Size = New System.Drawing.Size(62, 17)
        Me.rdb_nombre_banco.TabIndex = 1
        Me.rdb_nombre_banco.TabStop = True
        Me.rdb_nombre_banco.Text = "Nombre"
        Me.rdb_nombre_banco.UseVisualStyleBackColor = True
        '
        'rdb_codigo_banco
        '
        Me.rdb_codigo_banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdb_codigo_banco.AutoSize = True
        Me.rdb_codigo_banco.Location = New System.Drawing.Point(6, 19)
        Me.rdb_codigo_banco.Name = "rdb_codigo_banco"
        Me.rdb_codigo_banco.Size = New System.Drawing.Size(36, 17)
        Me.rdb_codigo_banco.TabIndex = 0
        Me.rdb_codigo_banco.TabStop = True
        Me.rdb_codigo_banco.Text = "ID"
        Me.rdb_codigo_banco.UseVisualStyleBackColor = True
        '
        'tab_clientes_grupos
        '
        Me.tab_clientes_grupos.Controls.Add(Me.TableLayoutPanel1)
        Me.tab_clientes_grupos.ImageIndex = 1
        Me.tab_clientes_grupos.Location = New System.Drawing.Point(4, 54)
        Me.tab_clientes_grupos.Name = "tab_clientes_grupos"
        Me.tab_clientes_grupos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_clientes_grupos.Size = New System.Drawing.Size(791, 388)
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
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dg_grupos, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel10, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel11, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(3)
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(792, 396)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'dg_clientes
        '
        Me.dg_clientes.AllowUserToAddRows = False
        Me.dg_clientes.AllowUserToDeleteRows = False
        Me.dg_clientes.AllowUserToResizeRows = False
        Me.dg_clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_clientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle32
        Me.dg_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCliente, Me.nombreCliente, Me.nifCliente, Me.fechaNacimientoCliente, Me.direccionCliente, Me.emailCliente, Me.grupoCliente, Me.bancoCliente})
        Me.dg_clientes.Location = New System.Drawing.Point(281, 6)
        Me.dg_clientes.MultiSelect = False
        Me.dg_clientes.Name = "dg_clientes"
        Me.dg_clientes.RowHeadersVisible = False
        Me.dg_clientes.Size = New System.Drawing.Size(505, 267)
        Me.dg_clientes.TabIndex = 1
        '
        'idCliente
        '
        Me.idCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.idCliente.HeaderText = "ID"
        Me.idCliente.Name = "idCliente"
        Me.idCliente.ReadOnly = True
        '
        'nombreCliente
        '
        Me.nombreCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombreCliente.HeaderText = "Nombre"
        Me.nombreCliente.Name = "nombreCliente"
        Me.nombreCliente.ReadOnly = True
        '
        'nifCliente
        '
        Me.nifCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nifCliente.HeaderText = "NIF"
        Me.nifCliente.Name = "nifCliente"
        Me.nifCliente.ReadOnly = True
        '
        'fechaNacimientoCliente
        '
        Me.fechaNacimientoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle33.Format = "d"
        DataGridViewCellStyle33.NullValue = Nothing
        Me.fechaNacimientoCliente.DefaultCellStyle = DataGridViewCellStyle33
        Me.fechaNacimientoCliente.HeaderText = "Fecha nacimiento"
        Me.fechaNacimientoCliente.Name = "fechaNacimientoCliente"
        Me.fechaNacimientoCliente.ReadOnly = True
        '
        'direccionCliente
        '
        Me.direccionCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.direccionCliente.HeaderText = "Dirección"
        Me.direccionCliente.Name = "direccionCliente"
        Me.direccionCliente.ReadOnly = True
        '
        'emailCliente
        '
        Me.emailCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.emailCliente.HeaderText = "Email"
        Me.emailCliente.Name = "emailCliente"
        Me.emailCliente.ReadOnly = True
        '
        'grupoCliente
        '
        Me.grupoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.grupoCliente.HeaderText = "Grupo"
        Me.grupoCliente.Name = "grupoCliente"
        Me.grupoCliente.ReadOnly = True
        '
        'bancoCliente
        '
        Me.bancoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.bancoCliente.HeaderText = "Banco"
        Me.bancoCliente.Name = "bancoCliente"
        Me.bancoCliente.ReadOnly = True
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 337)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(269, 53)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btn_añadir_grupo
        '
        Me.btn_añadir_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_grupo.Location = New System.Drawing.Point(3, 9)
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
        Me.btn_modificar_grupo.Location = New System.Drawing.Point(92, 9)
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
        Me.btn_eliminar_grupo.Location = New System.Drawing.Point(181, 9)
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(281, 337)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(505, 53)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'btn_añadir_cliente
        '
        Me.btn_añadir_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_cliente.Location = New System.Drawing.Point(3, 9)
        Me.btn_añadir_cliente.Name = "btn_añadir_cliente"
        Me.btn_añadir_cliente.Size = New System.Drawing.Size(162, 35)
        Me.btn_añadir_cliente.TabIndex = 0
        Me.btn_añadir_cliente.Text = "Añadir Cliente"
        Me.btn_añadir_cliente.UseVisualStyleBackColor = True
        '
        'btn_modificar_cliente
        '
        Me.btn_modificar_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_cliente.Enabled = False
        Me.btn_modificar_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_cliente.Location = New System.Drawing.Point(171, 9)
        Me.btn_modificar_cliente.Name = "btn_modificar_cliente"
        Me.btn_modificar_cliente.Size = New System.Drawing.Size(162, 35)
        Me.btn_modificar_cliente.TabIndex = 1
        Me.btn_modificar_cliente.Text = "Modificar Cliente"
        Me.btn_modificar_cliente.UseVisualStyleBackColor = True
        '
        'btn_eliminar_cliente
        '
        Me.btn_eliminar_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_cliente.Enabled = False
        Me.btn_eliminar_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_cliente.Location = New System.Drawing.Point(339, 9)
        Me.btn_eliminar_cliente.Name = "btn_eliminar_cliente"
        Me.btn_eliminar_cliente.Size = New System.Drawing.Size(163, 35)
        Me.btn_eliminar_cliente.TabIndex = 2
        Me.btn_eliminar_cliente.Text = "Eliminar Cliente"
        Me.btn_eliminar_cliente.UseVisualStyleBackColor = True
        '
        'dg_grupos
        '
        Me.dg_grupos.AllowUserToAddRows = False
        Me.dg_grupos.AllowUserToDeleteRows = False
        Me.dg_grupos.AllowUserToResizeRows = False
        Me.dg_grupos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_grupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_grupos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle34
        Me.dg_grupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_grupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idGrupo, Me.nombreGrupo})
        Me.dg_grupos.Location = New System.Drawing.Point(6, 6)
        Me.dg_grupos.MultiSelect = False
        Me.dg_grupos.Name = "dg_grupos"
        Me.dg_grupos.ReadOnly = True
        Me.dg_grupos.RowHeadersVisible = False
        Me.dg_grupos.Size = New System.Drawing.Size(269, 267)
        Me.dg_grupos.TabIndex = 4
        '
        'idGrupo
        '
        Me.idGrupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.idGrupo.HeaderText = "ID"
        Me.idGrupo.Name = "idGrupo"
        Me.idGrupo.ReadOnly = True
        '
        'nombreGrupo
        '
        Me.nombreGrupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombreGrupo.HeaderText = "Nombre Grupo"
        Me.nombreGrupo.Name = "nombreGrupo"
        Me.nombreGrupo.ReadOnly = True
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.gb_grupos, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.txt_busqueda_grupo, 1, 0)
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(6, 279)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(269, 52)
        Me.TableLayoutPanel10.TabIndex = 5
        '
        'gb_grupos
        '
        Me.gb_grupos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_grupos.Controls.Add(Me.rdb_nombre_grupo)
        Me.gb_grupos.Controls.Add(Me.rdb_codigo_grupo)
        Me.gb_grupos.Location = New System.Drawing.Point(3, 3)
        Me.gb_grupos.Name = "gb_grupos"
        Me.gb_grupos.Size = New System.Drawing.Size(128, 46)
        Me.gb_grupos.TabIndex = 0
        Me.gb_grupos.TabStop = False
        Me.gb_grupos.Text = "Criterio"
        '
        'rdb_nombre_grupo
        '
        Me.rdb_nombre_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdb_nombre_grupo.AutoSize = True
        Me.rdb_nombre_grupo.Location = New System.Drawing.Point(61, 19)
        Me.rdb_nombre_grupo.Name = "rdb_nombre_grupo"
        Me.rdb_nombre_grupo.Size = New System.Drawing.Size(62, 17)
        Me.rdb_nombre_grupo.TabIndex = 1
        Me.rdb_nombre_grupo.TabStop = True
        Me.rdb_nombre_grupo.Text = "Nombre"
        Me.rdb_nombre_grupo.UseVisualStyleBackColor = True
        '
        'rdb_codigo_grupo
        '
        Me.rdb_codigo_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdb_codigo_grupo.AutoSize = True
        Me.rdb_codigo_grupo.Location = New System.Drawing.Point(6, 19)
        Me.rdb_codigo_grupo.Name = "rdb_codigo_grupo"
        Me.rdb_codigo_grupo.Size = New System.Drawing.Size(36, 17)
        Me.rdb_codigo_grupo.TabIndex = 0
        Me.rdb_codigo_grupo.TabStop = True
        Me.rdb_codigo_grupo.Text = "ID"
        Me.rdb_codigo_grupo.UseVisualStyleBackColor = True
        '
        'txt_busqueda_grupo
        '
        Me.txt_busqueda_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_busqueda_grupo.Location = New System.Drawing.Point(137, 16)
        Me.txt_busqueda_grupo.Name = "txt_busqueda_grupo"
        Me.txt_busqueda_grupo.Size = New System.Drawing.Size(129, 20)
        Me.txt_busqueda_grupo.TabIndex = 1
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel11.ColumnCount = 2
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.txt_busqueda_cliente, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.gb_clientes, 0, 0)
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(281, 279)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(505, 52)
        Me.TableLayoutPanel11.TabIndex = 6
        '
        'txt_busqueda_cliente
        '
        Me.txt_busqueda_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_busqueda_cliente.Location = New System.Drawing.Point(205, 16)
        Me.txt_busqueda_cliente.Name = "txt_busqueda_cliente"
        Me.txt_busqueda_cliente.Size = New System.Drawing.Size(297, 20)
        Me.txt_busqueda_cliente.TabIndex = 2
        '
        'gb_clientes
        '
        Me.gb_clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_clientes.Controls.Add(Me.rdb_nif_cliente)
        Me.gb_clientes.Controls.Add(Me.rdb_nombre_cliente)
        Me.gb_clientes.Controls.Add(Me.rdb_id_cliente)
        Me.gb_clientes.Location = New System.Drawing.Point(3, 3)
        Me.gb_clientes.Name = "gb_clientes"
        Me.gb_clientes.Size = New System.Drawing.Size(196, 46)
        Me.gb_clientes.TabIndex = 1
        Me.gb_clientes.TabStop = False
        Me.gb_clientes.Text = "Criterio"
        '
        'rdb_nif_cliente
        '
        Me.rdb_nif_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdb_nif_cliente.AutoSize = True
        Me.rdb_nif_cliente.Location = New System.Drawing.Point(131, 19)
        Me.rdb_nif_cliente.Name = "rdb_nif_cliente"
        Me.rdb_nif_cliente.Size = New System.Drawing.Size(42, 17)
        Me.rdb_nif_cliente.TabIndex = 2
        Me.rdb_nif_cliente.TabStop = True
        Me.rdb_nif_cliente.Text = "NIF"
        Me.rdb_nif_cliente.UseVisualStyleBackColor = True
        '
        'rdb_nombre_cliente
        '
        Me.rdb_nombre_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdb_nombre_cliente.AutoSize = True
        Me.rdb_nombre_cliente.Location = New System.Drawing.Point(58, 19)
        Me.rdb_nombre_cliente.Name = "rdb_nombre_cliente"
        Me.rdb_nombre_cliente.Size = New System.Drawing.Size(62, 17)
        Me.rdb_nombre_cliente.TabIndex = 1
        Me.rdb_nombre_cliente.TabStop = True
        Me.rdb_nombre_cliente.Text = "Nombre"
        Me.rdb_nombre_cliente.UseVisualStyleBackColor = True
        '
        'rdb_id_cliente
        '
        Me.rdb_id_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdb_id_cliente.AutoSize = True
        Me.rdb_id_cliente.Location = New System.Drawing.Point(8, 19)
        Me.rdb_id_cliente.Name = "rdb_id_cliente"
        Me.rdb_id_cliente.Size = New System.Drawing.Size(36, 17)
        Me.rdb_id_cliente.TabIndex = 0
        Me.rdb_id_cliente.TabStop = True
        Me.rdb_id_cliente.Text = "ID"
        Me.rdb_id_cliente.UseVisualStyleBackColor = True
        '
        'tab_articulos_proveedores
        '
        Me.tab_articulos_proveedores.Controls.Add(Me.TableLayoutPanel4)
        Me.tab_articulos_proveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_articulos_proveedores.ImageIndex = 2
        Me.tab_articulos_proveedores.Location = New System.Drawing.Point(4, 54)
        Me.tab_articulos_proveedores.Name = "tab_articulos_proveedores"
        Me.tab_articulos_proveedores.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_articulos_proveedores.Size = New System.Drawing.Size(791, 388)
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
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel15, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.dg_articulos, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.dg_proveedores, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel14, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.Padding = New System.Windows.Forms.Padding(3)
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(792, 396)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel15.ColumnCount = 2
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel15.Controls.Add(Me.txt_busqueda_articulo, 1, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.gb_articulos, 0, 0)
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(281, 279)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 1
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(505, 52)
        Me.TableLayoutPanel15.TabIndex = 6
        '
        'txt_busqueda_articulo
        '
        Me.txt_busqueda_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_busqueda_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busqueda_articulo.Location = New System.Drawing.Point(154, 16)
        Me.txt_busqueda_articulo.Name = "txt_busqueda_articulo"
        Me.txt_busqueda_articulo.Size = New System.Drawing.Size(348, 20)
        Me.txt_busqueda_articulo.TabIndex = 5
        '
        'gb_articulos
        '
        Me.gb_articulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_articulos.Controls.Add(Me.rdb_nombre_articulo)
        Me.gb_articulos.Controls.Add(Me.rdb_codigo_articulo)
        Me.gb_articulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_articulos.Location = New System.Drawing.Point(3, 3)
        Me.gb_articulos.Name = "gb_articulos"
        Me.gb_articulos.Size = New System.Drawing.Size(145, 46)
        Me.gb_articulos.TabIndex = 3
        Me.gb_articulos.TabStop = False
        Me.gb_articulos.Text = "Criterio"
        '
        'rdb_nombre_articulo
        '
        Me.rdb_nombre_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdb_nombre_articulo.AutoSize = True
        Me.rdb_nombre_articulo.Location = New System.Drawing.Point(63, 19)
        Me.rdb_nombre_articulo.Name = "rdb_nombre_articulo"
        Me.rdb_nombre_articulo.Size = New System.Drawing.Size(62, 17)
        Me.rdb_nombre_articulo.TabIndex = 1
        Me.rdb_nombre_articulo.TabStop = True
        Me.rdb_nombre_articulo.Text = "Nombre"
        Me.rdb_nombre_articulo.UseVisualStyleBackColor = True
        '
        'rdb_codigo_articulo
        '
        Me.rdb_codigo_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdb_codigo_articulo.AutoSize = True
        Me.rdb_codigo_articulo.Location = New System.Drawing.Point(8, 19)
        Me.rdb_codigo_articulo.Name = "rdb_codigo_articulo"
        Me.rdb_codigo_articulo.Size = New System.Drawing.Size(36, 17)
        Me.rdb_codigo_articulo.TabIndex = 0
        Me.rdb_codigo_articulo.TabStop = True
        Me.rdb_codigo_articulo.Text = "ID"
        Me.rdb_codigo_articulo.UseVisualStyleBackColor = True
        '
        'dg_articulos
        '
        Me.dg_articulos.AllowUserToAddRows = False
        Me.dg_articulos.AllowUserToDeleteRows = False
        Me.dg_articulos.AllowUserToResizeRows = False
        Me.dg_articulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_articulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idArticulo, Me.nombreArticuloo, Me.descripcionArticulo, Me.pvpCompraArticulo, Me.pvpVentaArticulo, Me.impuestoArticulo, Me.porcBeneficioArticulo, Me.tipoUnidadArticulo, Me.familiaArticulo})
        Me.dg_articulos.Location = New System.Drawing.Point(281, 6)
        Me.dg_articulos.MultiSelect = False
        Me.dg_articulos.Name = "dg_articulos"
        Me.dg_articulos.RowHeadersVisible = False
        Me.dg_articulos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_articulos.Size = New System.Drawing.Size(505, 267)
        Me.dg_articulos.TabIndex = 1
        '
        'idArticulo
        '
        Me.idArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.idArticulo.HeaderText = "ID"
        Me.idArticulo.Name = "idArticulo"
        Me.idArticulo.ReadOnly = True
        '
        'nombreArticuloo
        '
        Me.nombreArticuloo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombreArticuloo.HeaderText = "Nombre"
        Me.nombreArticuloo.Name = "nombreArticuloo"
        Me.nombreArticuloo.ReadOnly = True
        '
        'descripcionArticulo
        '
        Me.descripcionArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descripcionArticulo.HeaderText = "Descripción"
        Me.descripcionArticulo.Name = "descripcionArticulo"
        Me.descripcionArticulo.ReadOnly = True
        '
        'pvpCompraArticulo
        '
        Me.pvpCompraArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.pvpCompraArticulo.HeaderText = "PVP Compra"
        Me.pvpCompraArticulo.Name = "pvpCompraArticulo"
        Me.pvpCompraArticulo.ReadOnly = True
        '
        'pvpVentaArticulo
        '
        Me.pvpVentaArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.pvpVentaArticulo.HeaderText = "PVP Venta"
        Me.pvpVentaArticulo.Name = "pvpVentaArticulo"
        Me.pvpVentaArticulo.ReadOnly = True
        '
        'impuestoArticulo
        '
        Me.impuestoArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.impuestoArticulo.HeaderText = "Impuesto"
        Me.impuestoArticulo.Name = "impuestoArticulo"
        Me.impuestoArticulo.ReadOnly = True
        '
        'porcBeneficioArticulo
        '
        Me.porcBeneficioArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.porcBeneficioArticulo.HeaderText = "%Beneficio"
        Me.porcBeneficioArticulo.Name = "porcBeneficioArticulo"
        Me.porcBeneficioArticulo.ReadOnly = True
        Me.porcBeneficioArticulo.Width = 94
        '
        'tipoUnidadArticulo
        '
        Me.tipoUnidadArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tipoUnidadArticulo.HeaderText = "Ud"
        Me.tipoUnidadArticulo.Name = "tipoUnidadArticulo"
        Me.tipoUnidadArticulo.ReadOnly = True
        '
        'familiaArticulo
        '
        Me.familiaArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.familiaArticulo.HeaderText = "Familia"
        Me.familiaArticulo.Name = "familiaArticulo"
        Me.familiaArticulo.ReadOnly = True
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
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(6, 337)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(269, 53)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'btn_añadir_proveedor
        '
        Me.btn_añadir_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_proveedor.Location = New System.Drawing.Point(3, 9)
        Me.btn_añadir_proveedor.Name = "btn_añadir_proveedor"
        Me.btn_añadir_proveedor.Size = New System.Drawing.Size(83, 35)
        Me.btn_añadir_proveedor.TabIndex = 0
        Me.btn_añadir_proveedor.Text = "Añadir Proveedor"
        Me.btn_añadir_proveedor.UseVisualStyleBackColor = True
        '
        'btn_modificar_proveedor
        '
        Me.btn_modificar_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_proveedor.Enabled = False
        Me.btn_modificar_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_proveedor.Location = New System.Drawing.Point(92, 9)
        Me.btn_modificar_proveedor.Name = "btn_modificar_proveedor"
        Me.btn_modificar_proveedor.Size = New System.Drawing.Size(83, 35)
        Me.btn_modificar_proveedor.TabIndex = 1
        Me.btn_modificar_proveedor.Text = "Modificar Proveedor"
        Me.btn_modificar_proveedor.UseVisualStyleBackColor = True
        '
        'btn_eliminar_proveedor
        '
        Me.btn_eliminar_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_proveedor.Enabled = False
        Me.btn_eliminar_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_proveedor.Location = New System.Drawing.Point(181, 9)
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
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(281, 337)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(505, 53)
        Me.TableLayoutPanel6.TabIndex = 3
        '
        'btn_añadir_articulo
        '
        Me.btn_añadir_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_articulo.Location = New System.Drawing.Point(3, 9)
        Me.btn_añadir_articulo.Name = "btn_añadir_articulo"
        Me.btn_añadir_articulo.Size = New System.Drawing.Size(162, 35)
        Me.btn_añadir_articulo.TabIndex = 0
        Me.btn_añadir_articulo.Text = "Añadir Artículo"
        Me.btn_añadir_articulo.UseVisualStyleBackColor = True
        '
        'btn_modificar_articulo
        '
        Me.btn_modificar_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_articulo.Enabled = False
        Me.btn_modificar_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_articulo.Location = New System.Drawing.Point(171, 9)
        Me.btn_modificar_articulo.Name = "btn_modificar_articulo"
        Me.btn_modificar_articulo.Size = New System.Drawing.Size(162, 35)
        Me.btn_modificar_articulo.TabIndex = 1
        Me.btn_modificar_articulo.Text = "Modificar Artículo"
        Me.btn_modificar_articulo.UseVisualStyleBackColor = True
        '
        'btn_eliminar_articulo
        '
        Me.btn_eliminar_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_articulo.Enabled = False
        Me.btn_eliminar_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_articulo.Location = New System.Drawing.Point(339, 9)
        Me.btn_eliminar_articulo.Name = "btn_eliminar_articulo"
        Me.btn_eliminar_articulo.Size = New System.Drawing.Size(163, 35)
        Me.btn_eliminar_articulo.TabIndex = 2
        Me.btn_eliminar_articulo.Text = "Eliminar Artículo"
        Me.btn_eliminar_articulo.UseVisualStyleBackColor = True
        '
        'dg_proveedores
        '
        Me.dg_proveedores.AllowUserToAddRows = False
        Me.dg_proveedores.AllowUserToDeleteRows = False
        Me.dg_proveedores.AllowUserToResizeRows = False
        Me.dg_proveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_proveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProveedor, Me.nombreProveedor, Me.datos})
        Me.dg_proveedores.Location = New System.Drawing.Point(6, 6)
        Me.dg_proveedores.MultiSelect = False
        Me.dg_proveedores.Name = "dg_proveedores"
        Me.dg_proveedores.ReadOnly = True
        Me.dg_proveedores.RowHeadersVisible = False
        Me.dg_proveedores.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_proveedores.Size = New System.Drawing.Size(269, 267)
        Me.dg_proveedores.TabIndex = 4
        '
        'idProveedor
        '
        Me.idProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.idProveedor.HeaderText = "ID"
        Me.idProveedor.Name = "idProveedor"
        Me.idProveedor.ReadOnly = True
        '
        'nombreProveedor
        '
        Me.nombreProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombreProveedor.HeaderText = "Nombre"
        Me.nombreProveedor.Name = "nombreProveedor"
        Me.nombreProveedor.ReadOnly = True
        '
        'datos
        '
        Me.datos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datos.DefaultCellStyle = DataGridViewCellStyle35
        Me.datos.HeaderText = " "
        Me.datos.Name = "datos"
        Me.datos.ReadOnly = True
        Me.datos.Text = "VER DATOS"
        Me.datos.UseColumnTextForButtonValue = True
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel14.ColumnCount = 2
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.gb_proveedores, 0, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_busqueda_proveedor, 1, 0)
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(6, 279)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 1
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(269, 52)
        Me.TableLayoutPanel14.TabIndex = 5
        '
        'gb_proveedores
        '
        Me.gb_proveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_proveedores.Controls.Add(Me.rdb_nombre_proveedor)
        Me.gb_proveedores.Controls.Add(Me.rdb_codigo_proveedor)
        Me.gb_proveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_proveedores.Location = New System.Drawing.Point(3, 3)
        Me.gb_proveedores.Name = "gb_proveedores"
        Me.gb_proveedores.Size = New System.Drawing.Size(128, 46)
        Me.gb_proveedores.TabIndex = 2
        Me.gb_proveedores.TabStop = False
        Me.gb_proveedores.Text = "Criterio"
        '
        'rdb_nombre_proveedor
        '
        Me.rdb_nombre_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdb_nombre_proveedor.AutoSize = True
        Me.rdb_nombre_proveedor.Location = New System.Drawing.Point(61, 19)
        Me.rdb_nombre_proveedor.Name = "rdb_nombre_proveedor"
        Me.rdb_nombre_proveedor.Size = New System.Drawing.Size(62, 17)
        Me.rdb_nombre_proveedor.TabIndex = 1
        Me.rdb_nombre_proveedor.TabStop = True
        Me.rdb_nombre_proveedor.Text = "Nombre"
        Me.rdb_nombre_proveedor.UseVisualStyleBackColor = True
        '
        'rdb_codigo_proveedor
        '
        Me.rdb_codigo_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdb_codigo_proveedor.AutoSize = True
        Me.rdb_codigo_proveedor.Location = New System.Drawing.Point(6, 19)
        Me.rdb_codigo_proveedor.Name = "rdb_codigo_proveedor"
        Me.rdb_codigo_proveedor.Size = New System.Drawing.Size(36, 17)
        Me.rdb_codigo_proveedor.TabIndex = 0
        Me.rdb_codigo_proveedor.TabStop = True
        Me.rdb_codigo_proveedor.Text = "ID"
        Me.rdb_codigo_proveedor.UseVisualStyleBackColor = True
        '
        'txt_busqueda_proveedor
        '
        Me.txt_busqueda_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_busqueda_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busqueda_proveedor.Location = New System.Drawing.Point(137, 16)
        Me.txt_busqueda_proveedor.Name = "txt_busqueda_proveedor"
        Me.txt_busqueda_proveedor.Size = New System.Drawing.Size(129, 20)
        Me.txt_busqueda_proveedor.TabIndex = 3
        '
        'tab_inventario
        '
        Me.tab_inventario.Controls.Add(Me.TableLayoutPanel7)
        Me.tab_inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_inventario.ImageIndex = 3
        Me.tab_inventario.Location = New System.Drawing.Point(4, 54)
        Me.tab_inventario.Name = "tab_inventario"
        Me.tab_inventario.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_inventario.Size = New System.Drawing.Size(791, 388)
        Me.tab_inventario.TabIndex = 4
        Me.tab_inventario.Text = "INVENTARIO"
        Me.tab_inventario.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.dg_inventario, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel8, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.dg_movimientos, 2, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.Padding = New System.Windows.Forms.Padding(3)
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(792, 388)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'dg_inventario
        '
        Me.dg_inventario.AllowUserToAddRows = False
        Me.dg_inventario.AllowUserToDeleteRows = False
        Me.dg_inventario.AllowUserToResizeRows = False
        Me.dg_inventario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_inventario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle36
        Me.dg_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_inventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idInventario, Me.nombreArticulo, Me.stockActual})
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_inventario.DefaultCellStyle = DataGridViewCellStyle37
        Me.dg_inventario.Location = New System.Drawing.Point(6, 6)
        Me.dg_inventario.MultiSelect = False
        Me.dg_inventario.Name = "dg_inventario"
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_inventario.RowHeadersDefaultCellStyle = DataGridViewCellStyle38
        Me.dg_inventario.RowHeadersVisible = False
        Me.dg_inventario.Size = New System.Drawing.Size(190, 376)
        Me.dg_inventario.TabIndex = 0
        '
        'idInventario
        '
        Me.idInventario.HeaderText = "ID"
        Me.idInventario.Name = "idInventario"
        Me.idInventario.ReadOnly = True
        Me.idInventario.Visible = False
        '
        'nombreArticulo
        '
        Me.nombreArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombreArticulo.HeaderText = "Artículo"
        Me.nombreArticulo.Name = "nombreArticulo"
        Me.nombreArticulo.ReadOnly = True
        '
        'stockActual
        '
        Me.stockActual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.stockActual.HeaderText = "Stock Actal"
        Me.stockActual.Name = "stockActual"
        Me.stockActual.ReadOnly = True
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
        Me.TableLayoutPanel8.Controls.Add(Me.txt_busqueda_inventario, 0, 4)
        Me.TableLayoutPanel8.Controls.Add(Me.btn_eliminar_articulo_inventario, 0, 3)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(202, 6)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 6
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(88, 376)
        Me.TableLayoutPanel8.TabIndex = 1
        '
        'btn_restar_unidades
        '
        Me.btn_restar_unidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_restar_unidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_restar_unidades.Location = New System.Drawing.Point(3, 48)
        Me.btn_restar_unidades.Name = "btn_restar_unidades"
        Me.btn_restar_unidades.Size = New System.Drawing.Size(82, 39)
        Me.btn_restar_unidades.TabIndex = 1
        Me.btn_restar_unidades.Text = "RESTAR UDS"
        Me.btn_restar_unidades.UseVisualStyleBackColor = True
        '
        'btn_añadir_unidades
        '
        Me.btn_añadir_unidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_unidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_unidades.Location = New System.Drawing.Point(3, 3)
        Me.btn_añadir_unidades.Name = "btn_añadir_unidades"
        Me.btn_añadir_unidades.Size = New System.Drawing.Size(82, 39)
        Me.btn_añadir_unidades.TabIndex = 0
        Me.btn_añadir_unidades.Text = "AÑADIR UDS"
        Me.btn_añadir_unidades.UseVisualStyleBackColor = True
        '
        'btn_añadir_articulo_inventario
        '
        Me.btn_añadir_articulo_inventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_articulo_inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_articulo_inventario.Location = New System.Drawing.Point(3, 93)
        Me.btn_añadir_articulo_inventario.Name = "btn_añadir_articulo_inventario"
        Me.btn_añadir_articulo_inventario.Size = New System.Drawing.Size(82, 39)
        Me.btn_añadir_articulo_inventario.TabIndex = 2
        Me.btn_añadir_articulo_inventario.Text = "AÑADIR ART"
        Me.btn_añadir_articulo_inventario.UseVisualStyleBackColor = True
        '
        'txt_busqueda_inventario
        '
        Me.txt_busqueda_inventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_busqueda_inventario.Location = New System.Drawing.Point(3, 192)
        Me.txt_busqueda_inventario.Name = "txt_busqueda_inventario"
        Me.txt_busqueda_inventario.Size = New System.Drawing.Size(82, 20)
        Me.txt_busqueda_inventario.TabIndex = 4
        '
        'btn_eliminar_articulo_inventario
        '
        Me.btn_eliminar_articulo_inventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_articulo_inventario.Enabled = False
        Me.btn_eliminar_articulo_inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_articulo_inventario.Location = New System.Drawing.Point(3, 138)
        Me.btn_eliminar_articulo_inventario.Name = "btn_eliminar_articulo_inventario"
        Me.btn_eliminar_articulo_inventario.Size = New System.Drawing.Size(82, 39)
        Me.btn_eliminar_articulo_inventario.TabIndex = 3
        Me.btn_eliminar_articulo_inventario.Text = "BORRAR ART"
        Me.btn_eliminar_articulo_inventario.UseVisualStyleBackColor = True
        '
        'dg_movimientos
        '
        Me.dg_movimientos.AllowUserToAddRows = False
        Me.dg_movimientos.AllowUserToDeleteRows = False
        Me.dg_movimientos.AllowUserToResizeRows = False
        Me.dg_movimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_movimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle39
        Me.dg_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_movimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMovimiento, Me.usuarioMovimiento, Me.articuloMovimiento, Me.cantidadMovimiento, Me.tipoMovimiento, Me.facturaMovimiento, Me.fechaMovimiento, Me.stockMovimiento})
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_movimientos.DefaultCellStyle = DataGridViewCellStyle41
        Me.dg_movimientos.Location = New System.Drawing.Point(296, 6)
        Me.dg_movimientos.MultiSelect = False
        Me.dg_movimientos.Name = "dg_movimientos"
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_movimientos.RowHeadersDefaultCellStyle = DataGridViewCellStyle42
        Me.dg_movimientos.RowHeadersVisible = False
        Me.dg_movimientos.Size = New System.Drawing.Size(490, 376)
        Me.dg_movimientos.TabIndex = 3
        '
        'idMovimiento
        '
        Me.idMovimiento.HeaderText = "ID"
        Me.idMovimiento.Name = "idMovimiento"
        Me.idMovimiento.ReadOnly = True
        Me.idMovimiento.Visible = False
        '
        'usuarioMovimiento
        '
        Me.usuarioMovimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.usuarioMovimiento.HeaderText = "Usuario"
        Me.usuarioMovimiento.Name = "usuarioMovimiento"
        Me.usuarioMovimiento.ReadOnly = True
        '
        'articuloMovimiento
        '
        Me.articuloMovimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.articuloMovimiento.HeaderText = "Artículo"
        Me.articuloMovimiento.Name = "articuloMovimiento"
        Me.articuloMovimiento.ReadOnly = True
        '
        'cantidadMovimiento
        '
        Me.cantidadMovimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cantidadMovimiento.HeaderText = "Cantidad"
        Me.cantidadMovimiento.Name = "cantidadMovimiento"
        '
        'tipoMovimiento
        '
        Me.tipoMovimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tipoMovimiento.HeaderText = "Tipo"
        Me.tipoMovimiento.Name = "tipoMovimiento"
        Me.tipoMovimiento.ReadOnly = True
        '
        'facturaMovimiento
        '
        Me.facturaMovimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.facturaMovimiento.HeaderText = "Factura"
        Me.facturaMovimiento.Name = "facturaMovimiento"
        Me.facturaMovimiento.ReadOnly = True
        '
        'fechaMovimiento
        '
        Me.fechaMovimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle40.Format = "d"
        DataGridViewCellStyle40.NullValue = Nothing
        Me.fechaMovimiento.DefaultCellStyle = DataGridViewCellStyle40
        Me.fechaMovimiento.HeaderText = "Fecha"
        Me.fechaMovimiento.Name = "fechaMovimiento"
        Me.fechaMovimiento.ReadOnly = True
        '
        'stockMovimiento
        '
        Me.stockMovimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.stockMovimiento.HeaderText = "Stock"
        Me.stockMovimiento.Name = "stockMovimiento"
        Me.stockMovimiento.ReadOnly = True
        '
        'tab_albaranes
        '
        Me.tab_albaranes.Controls.Add(Me.TableLayoutPanel18)
        Me.tab_albaranes.ImageIndex = 5
        Me.tab_albaranes.Location = New System.Drawing.Point(4, 54)
        Me.tab_albaranes.Name = "tab_albaranes"
        Me.tab_albaranes.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_albaranes.Size = New System.Drawing.Size(791, 388)
        Me.tab_albaranes.TabIndex = 6
        Me.tab_albaranes.Text = "ALBARANES"
        Me.tab_albaranes.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel18
        '
        Me.TableLayoutPanel18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel18.ColumnCount = 2
        Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel18.Controls.Add(Me.dg_albaranes, 0, 0)
        Me.TableLayoutPanel18.Controls.Add(Me.TableLayoutPanel19, 1, 0)
        Me.TableLayoutPanel18.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel18.Name = "TableLayoutPanel18"
        Me.TableLayoutPanel18.Padding = New System.Windows.Forms.Padding(3)
        Me.TableLayoutPanel18.RowCount = 1
        Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel18.Size = New System.Drawing.Size(791, 388)
        Me.TableLayoutPanel18.TabIndex = 0
        '
        'dg_albaranes
        '
        Me.dg_albaranes.AllowUserToAddRows = False
        Me.dg_albaranes.AllowUserToResizeRows = False
        Me.dg_albaranes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_albaranes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle43
        Me.dg_albaranes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_albaranes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idAlbaran, Me.personaAlbaran, Me.formaPagoAlbaran, Me.fechaAlbaran, Me.tipoAlbaran, Me.facturaAlbaran, Me.verAlbaran})
        Me.dg_albaranes.Location = New System.Drawing.Point(6, 6)
        Me.dg_albaranes.MultiSelect = False
        Me.dg_albaranes.Name = "dg_albaranes"
        Me.dg_albaranes.ReadOnly = True
        Me.dg_albaranes.RowHeadersVisible = False
        Me.dg_albaranes.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_albaranes.Size = New System.Drawing.Size(582, 376)
        Me.dg_albaranes.TabIndex = 1
        '
        'idAlbaran
        '
        Me.idAlbaran.HeaderText = "ID"
        Me.idAlbaran.Name = "idAlbaran"
        Me.idAlbaran.ReadOnly = True
        Me.idAlbaran.Visible = False
        '
        'personaAlbaran
        '
        Me.personaAlbaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.personaAlbaran.HeaderText = "Entidad"
        Me.personaAlbaran.Name = "personaAlbaran"
        Me.personaAlbaran.ReadOnly = True
        '
        'formaPagoAlbaran
        '
        Me.formaPagoAlbaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.formaPagoAlbaran.HeaderText = "Forma Pago"
        Me.formaPagoAlbaran.Name = "formaPagoAlbaran"
        Me.formaPagoAlbaran.ReadOnly = True
        '
        'fechaAlbaran
        '
        Me.fechaAlbaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle44.Format = "d"
        DataGridViewCellStyle44.NullValue = Nothing
        Me.fechaAlbaran.DefaultCellStyle = DataGridViewCellStyle44
        Me.fechaAlbaran.HeaderText = "Fecha"
        Me.fechaAlbaran.Name = "fechaAlbaran"
        Me.fechaAlbaran.ReadOnly = True
        '
        'tipoAlbaran
        '
        Me.tipoAlbaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tipoAlbaran.HeaderText = "Tipo Movimiento"
        Me.tipoAlbaran.Name = "tipoAlbaran"
        Me.tipoAlbaran.ReadOnly = True
        '
        'facturaAlbaran
        '
        Me.facturaAlbaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.facturaAlbaran.HeaderText = "Factura"
        Me.facturaAlbaran.Name = "facturaAlbaran"
        Me.facturaAlbaran.ReadOnly = True
        '
        'verAlbaran
        '
        Me.verAlbaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verAlbaran.DefaultCellStyle = DataGridViewCellStyle45
        Me.verAlbaran.HeaderText = ""
        Me.verAlbaran.Name = "verAlbaran"
        Me.verAlbaran.ReadOnly = True
        '
        'TableLayoutPanel19
        '
        Me.TableLayoutPanel19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel19.ColumnCount = 1
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel19.Controls.Add(Me.gb_ver_estado_albaranes, 0, 8)
        Me.TableLayoutPanel19.Controls.Add(Me.btn_eliminar_compra, 0, 7)
        Me.TableLayoutPanel19.Controls.Add(Me.gb_ver_albaranes, 0, 6)
        Me.TableLayoutPanel19.Controls.Add(Me.dp_busqueda_inicio_albaran, 0, 2)
        Me.TableLayoutPanel19.Controls.Add(Me.dp_busqueda_fin_albaran, 0, 3)
        Me.TableLayoutPanel19.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel19.Controls.Add(Me.txt_busqueda_albaran_entidad, 0, 1)
        Me.TableLayoutPanel19.Controls.Add(Me.Label2, 0, 4)
        Me.TableLayoutPanel19.Controls.Add(Me.txt_busqueda_albaran_factura, 0, 5)
        Me.TableLayoutPanel19.Location = New System.Drawing.Point(594, 6)
        Me.TableLayoutPanel19.Name = "TableLayoutPanel19"
        Me.TableLayoutPanel19.RowCount = 9
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel19.Size = New System.Drawing.Size(191, 376)
        Me.TableLayoutPanel19.TabIndex = 2
        '
        'gb_ver_estado_albaranes
        '
        Me.gb_ver_estado_albaranes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_ver_estado_albaranes.Controls.Add(Me.rdb_albaranes_eliminados)
        Me.gb_ver_estado_albaranes.Controls.Add(Me.rdb_albaranes_activos)
        Me.gb_ver_estado_albaranes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_ver_estado_albaranes.Location = New System.Drawing.Point(15, 308)
        Me.gb_ver_estado_albaranes.Margin = New System.Windows.Forms.Padding(15, 10, 15, 10)
        Me.gb_ver_estado_albaranes.Name = "gb_ver_estado_albaranes"
        Me.gb_ver_estado_albaranes.Size = New System.Drawing.Size(161, 58)
        Me.gb_ver_estado_albaranes.TabIndex = 2
        Me.gb_ver_estado_albaranes.TabStop = False
        Me.gb_ver_estado_albaranes.Text = "Estado albaranes"
        '
        'rdb_albaranes_eliminados
        '
        Me.rdb_albaranes_eliminados.AutoSize = True
        Me.rdb_albaranes_eliminados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_albaranes_eliminados.Location = New System.Drawing.Point(50, 36)
        Me.rdb_albaranes_eliminados.Name = "rdb_albaranes_eliminados"
        Me.rdb_albaranes_eliminados.Size = New System.Drawing.Size(75, 17)
        Me.rdb_albaranes_eliminados.TabIndex = 3
        Me.rdb_albaranes_eliminados.TabStop = True
        Me.rdb_albaranes_eliminados.Text = "Eliminados"
        Me.rdb_albaranes_eliminados.UseVisualStyleBackColor = True
        '
        'rdb_albaranes_activos
        '
        Me.rdb_albaranes_activos.AutoSize = True
        Me.rdb_albaranes_activos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_albaranes_activos.Location = New System.Drawing.Point(50, 16)
        Me.rdb_albaranes_activos.Name = "rdb_albaranes_activos"
        Me.rdb_albaranes_activos.Size = New System.Drawing.Size(60, 17)
        Me.rdb_albaranes_activos.TabIndex = 2
        Me.rdb_albaranes_activos.TabStop = True
        Me.rdb_albaranes_activos.Text = "Activos"
        Me.rdb_albaranes_activos.UseVisualStyleBackColor = True
        '
        'btn_eliminar_compra
        '
        Me.btn_eliminar_compra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_compra.Location = New System.Drawing.Point(15, 268)
        Me.btn_eliminar_compra.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.btn_eliminar_compra.Name = "btn_eliminar_compra"
        Me.btn_eliminar_compra.Size = New System.Drawing.Size(161, 23)
        Me.btn_eliminar_compra.TabIndex = 1
        Me.btn_eliminar_compra.Text = "Eliminar"
        Me.btn_eliminar_compra.UseVisualStyleBackColor = True
        '
        'gb_ver_albaranes
        '
        Me.gb_ver_albaranes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_ver_albaranes.Controls.Add(Me.rdb_ver_compras)
        Me.gb_ver_albaranes.Controls.Add(Me.rdb_ver_ventas)
        Me.gb_ver_albaranes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_ver_albaranes.Location = New System.Drawing.Point(15, 196)
        Me.gb_ver_albaranes.Margin = New System.Windows.Forms.Padding(15, 10, 15, 10)
        Me.gb_ver_albaranes.Name = "gb_ver_albaranes"
        Me.gb_ver_albaranes.Size = New System.Drawing.Size(161, 55)
        Me.gb_ver_albaranes.TabIndex = 0
        Me.gb_ver_albaranes.TabStop = False
        Me.gb_ver_albaranes.Text = "Ver albaranes"
        '
        'rdb_ver_compras
        '
        Me.rdb_ver_compras.AutoSize = True
        Me.rdb_ver_compras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_ver_compras.Location = New System.Drawing.Point(50, 34)
        Me.rdb_ver_compras.Name = "rdb_ver_compras"
        Me.rdb_ver_compras.Size = New System.Drawing.Size(66, 17)
        Me.rdb_ver_compras.TabIndex = 1
        Me.rdb_ver_compras.TabStop = True
        Me.rdb_ver_compras.Text = "Compras"
        Me.rdb_ver_compras.UseVisualStyleBackColor = True
        '
        'rdb_ver_ventas
        '
        Me.rdb_ver_ventas.AutoSize = True
        Me.rdb_ver_ventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_ver_ventas.Location = New System.Drawing.Point(50, 15)
        Me.rdb_ver_ventas.Name = "rdb_ver_ventas"
        Me.rdb_ver_ventas.Size = New System.Drawing.Size(58, 17)
        Me.rdb_ver_ventas.TabIndex = 0
        Me.rdb_ver_ventas.TabStop = True
        Me.rdb_ver_ventas.Text = "Ventas"
        Me.rdb_ver_ventas.UseVisualStyleBackColor = True
        '
        'dp_busqueda_inicio_albaran
        '
        Me.dp_busqueda_inicio_albaran.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_busqueda_inicio_albaran.CustomFormat = "Inicio"
        Me.dp_busqueda_inicio_albaran.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dp_busqueda_inicio_albaran.Location = New System.Drawing.Point(15, 66)
        Me.dp_busqueda_inicio_albaran.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.dp_busqueda_inicio_albaran.Name = "dp_busqueda_inicio_albaran"
        Me.dp_busqueda_inicio_albaran.Size = New System.Drawing.Size(161, 20)
        Me.dp_busqueda_inicio_albaran.TabIndex = 3
        '
        'dp_busqueda_fin_albaran
        '
        Me.dp_busqueda_fin_albaran.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_busqueda_fin_albaran.CustomFormat = "Fin"
        Me.dp_busqueda_fin_albaran.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dp_busqueda_fin_albaran.Location = New System.Drawing.Point(15, 99)
        Me.dp_busqueda_fin_albaran.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.dp_busqueda_fin_albaran.Name = "dp_busqueda_fin_albaran"
        Me.dp_busqueda_fin_albaran.Size = New System.Drawing.Size(161, 20)
        Me.dp_busqueda_fin_albaran.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Entidad:"
        '
        'txt_busqueda_albaran_entidad
        '
        Me.txt_busqueda_albaran_entidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_busqueda_albaran_entidad.Location = New System.Drawing.Point(15, 35)
        Me.txt_busqueda_albaran_entidad.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.txt_busqueda_albaran_entidad.Name = "txt_busqueda_albaran_entidad"
        Me.txt_busqueda_albaran_entidad.Size = New System.Drawing.Size(161, 20)
        Me.txt_busqueda_albaran_entidad.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Factura:"
        '
        'txt_busqueda_albaran_factura
        '
        Me.txt_busqueda_albaran_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_busqueda_albaran_factura.Location = New System.Drawing.Point(15, 161)
        Me.txt_busqueda_albaran_factura.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.txt_busqueda_albaran_factura.Name = "txt_busqueda_albaran_factura"
        Me.txt_busqueda_albaran_factura.Size = New System.Drawing.Size(161, 20)
        Me.txt_busqueda_albaran_factura.TabIndex = 8
        '
        'tab_facturas
        '
        Me.tab_facturas.Controls.Add(Me.TableLayoutPanel20)
        Me.tab_facturas.ImageIndex = 6
        Me.tab_facturas.Location = New System.Drawing.Point(4, 54)
        Me.tab_facturas.Name = "tab_facturas"
        Me.tab_facturas.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_facturas.Size = New System.Drawing.Size(791, 388)
        Me.tab_facturas.TabIndex = 7
        Me.tab_facturas.Text = "FACTURAS"
        Me.tab_facturas.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel20
        '
        Me.TableLayoutPanel20.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel20.ColumnCount = 2
        Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel20.Controls.Add(Me.dg_facturas, 0, 0)
        Me.TableLayoutPanel20.Controls.Add(Me.TableLayoutPanel21, 1, 0)
        Me.TableLayoutPanel20.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel20.Name = "TableLayoutPanel20"
        Me.TableLayoutPanel20.RowCount = 1
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel20.Size = New System.Drawing.Size(791, 388)
        Me.TableLayoutPanel20.TabIndex = 0
        '
        'dg_facturas
        '
        Me.dg_facturas.AllowUserToAddRows = False
        Me.dg_facturas.AllowUserToDeleteRows = False
        Me.dg_facturas.AllowUserToResizeColumns = False
        Me.dg_facturas.AllowUserToResizeRows = False
        Me.dg_facturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_facturas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle31
        Me.dg_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_facturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idFactura, Me.entidadFactura, Me.listaAlbaranesFactura, Me.estadoFactura})
        Me.dg_facturas.Location = New System.Drawing.Point(3, 3)
        Me.dg_facturas.MultiSelect = False
        Me.dg_facturas.Name = "dg_facturas"
        Me.dg_facturas.RowHeadersVisible = False
        Me.dg_facturas.Size = New System.Drawing.Size(547, 382)
        Me.dg_facturas.TabIndex = 0
        '
        'idFactura
        '
        Me.idFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.idFactura.HeaderText = "ID"
        Me.idFactura.Name = "idFactura"
        Me.idFactura.ReadOnly = True
        '
        'entidadFactura
        '
        Me.entidadFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.entidadFactura.HeaderText = "Entidad"
        Me.entidadFactura.Name = "entidadFactura"
        Me.entidadFactura.ReadOnly = True
        '
        'listaAlbaranesFactura
        '
        Me.listaAlbaranesFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.listaAlbaranesFactura.HeaderText = "Albaranes"
        Me.listaAlbaranesFactura.Name = "listaAlbaranesFactura"
        Me.listaAlbaranesFactura.ReadOnly = True
        '
        'estadoFactura
        '
        Me.estadoFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.estadoFactura.HeaderText = "Estado"
        Me.estadoFactura.Name = "estadoFactura"
        Me.estadoFactura.ReadOnly = True
        '
        'TableLayoutPanel21
        '
        Me.TableLayoutPanel21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel21.ColumnCount = 1
        Me.TableLayoutPanel21.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel21.Controls.Add(Me.gb_tipos_factura, 0, 0)
        Me.TableLayoutPanel21.Controls.Add(Me.btn_cambiar_estado_factura, 0, 8)
        Me.TableLayoutPanel21.Controls.Add(Me.btn_facturar_albaran, 0, 7)
        Me.TableLayoutPanel21.Controls.Add(Me.btn_busqueda_factura, 0, 5)
        Me.TableLayoutPanel21.Controls.Add(Me.DateTimePicker2, 0, 4)
        Me.TableLayoutPanel21.Controls.Add(Me.DateTimePicker1, 0, 3)
        Me.TableLayoutPanel21.Controls.Add(Me.TextBox1, 0, 2)
        Me.TableLayoutPanel21.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel21.Location = New System.Drawing.Point(556, 3)
        Me.TableLayoutPanel21.Name = "TableLayoutPanel21"
        Me.TableLayoutPanel21.RowCount = 9
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel21.Size = New System.Drawing.Size(232, 382)
        Me.TableLayoutPanel21.TabIndex = 1
        '
        'btn_busqueda_factura
        '
        Me.btn_busqueda_factura.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_busqueda_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_busqueda_factura.Location = New System.Drawing.Point(142, 239)
        Me.btn_busqueda_factura.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.btn_busqueda_factura.Name = "btn_busqueda_factura"
        Me.btn_busqueda_factura.Size = New System.Drawing.Size(75, 23)
        Me.btn_busqueda_factura.TabIndex = 2
        Me.btn_busqueda_factura.Text = "Buscar"
        Me.btn_busqueda_factura.UseVisualStyleBackColor = True
        '
        'btn_facturar_albaran
        '
        Me.btn_facturar_albaran.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_facturar_albaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_facturar_albaran.Location = New System.Drawing.Point(15, 311)
        Me.btn_facturar_albaran.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.btn_facturar_albaran.Name = "btn_facturar_albaran"
        Me.btn_facturar_albaran.Size = New System.Drawing.Size(202, 23)
        Me.btn_facturar_albaran.TabIndex = 5
        Me.btn_facturar_albaran.Text = "FACTURAR ALBARÁN"
        Me.btn_facturar_albaran.UseVisualStyleBackColor = True
        '
        'btn_cambiar_estado_factura
        '
        Me.btn_cambiar_estado_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cambiar_estado_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cambiar_estado_factura.Location = New System.Drawing.Point(15, 350)
        Me.btn_cambiar_estado_factura.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.btn_cambiar_estado_factura.Name = "btn_cambiar_estado_factura"
        Me.btn_cambiar_estado_factura.Size = New System.Drawing.Size(202, 23)
        Me.btn_cambiar_estado_factura.TabIndex = 6
        Me.btn_cambiar_estado_factura.Text = "MARCAR COMO PAGADO"
        Me.btn_cambiar_estado_factura.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker2.CustomFormat = "Día fin"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(15, 207)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(202, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(15, 131)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(202, 20)
        Me.TextBox1.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CustomFormat = "Día inicio"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(15, 169)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(202, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cliente / Proveedor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tab_configuraciones
        '
        Me.tab_configuraciones.Controls.Add(Me.TableLayoutPanel9)
        Me.tab_configuraciones.ImageIndex = 4
        Me.tab_configuraciones.Location = New System.Drawing.Point(4, 54)
        Me.tab_configuraciones.Name = "tab_configuraciones"
        Me.tab_configuraciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_configuraciones.Size = New System.Drawing.Size(791, 388)
        Me.tab_configuraciones.TabIndex = 5
        Me.tab_configuraciones.Text = "CONFIGURACIONES"
        Me.tab_configuraciones.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.btn_actualizacion_campo_extra, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.btn_actualizacion_añadir_tabla, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.btn_actualizacion_añadir_fk, 0, 2)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(119, 38)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 3
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(534, 314)
        Me.TableLayoutPanel9.TabIndex = 0
        '
        'btn_actualizacion_campo_extra
        '
        Me.btn_actualizacion_campo_extra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_actualizacion_campo_extra.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_actualizacion_campo_extra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizacion_campo_extra.Location = New System.Drawing.Point(3, 3)
        Me.btn_actualizacion_campo_extra.Name = "btn_actualizacion_campo_extra"
        Me.btn_actualizacion_campo_extra.Size = New System.Drawing.Size(528, 98)
        Me.btn_actualizacion_campo_extra.TabIndex = 0
        Me.btn_actualizacion_campo_extra.Text = "ACTUALIZACIÓN 1:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AÑADIR EMAIL CLIENTE"
        Me.btn_actualizacion_campo_extra.UseVisualStyleBackColor = False
        '
        'btn_actualizacion_añadir_tabla
        '
        Me.btn_actualizacion_añadir_tabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_actualizacion_añadir_tabla.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_actualizacion_añadir_tabla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizacion_añadir_tabla.Location = New System.Drawing.Point(3, 107)
        Me.btn_actualizacion_añadir_tabla.Name = "btn_actualizacion_añadir_tabla"
        Me.btn_actualizacion_añadir_tabla.Size = New System.Drawing.Size(528, 98)
        Me.btn_actualizacion_añadir_tabla.TabIndex = 1
        Me.btn_actualizacion_añadir_tabla.Text = "ACTUALIZACIÓN 2:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AÑADIR TABLAS COMPRA Y VENTA"
        Me.btn_actualizacion_añadir_tabla.UseVisualStyleBackColor = False
        '
        'btn_actualizacion_añadir_fk
        '
        Me.btn_actualizacion_añadir_fk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_actualizacion_añadir_fk.BackColor = System.Drawing.Color.Plum
        Me.btn_actualizacion_añadir_fk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizacion_añadir_fk.Location = New System.Drawing.Point(3, 211)
        Me.btn_actualizacion_añadir_fk.Name = "btn_actualizacion_añadir_fk"
        Me.btn_actualizacion_añadir_fk.Size = New System.Drawing.Size(528, 100)
        Me.btn_actualizacion_añadir_fk.TabIndex = 2
        Me.btn_actualizacion_añadir_fk.Text = "ACTUALIZACIÓN 3:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AÑADIR FK INVENTARIO"
        Me.btn_actualizacion_añadir_fk.UseVisualStyleBackColor = False
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
        Me.ImageList1.Images.SetKeyName(5, "albaran.png")
        Me.ImageList1.Images.SetKeyName(6, "factura.png")
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataSource = GetType(MP_Lucas_Sanz.Proveedor)
        '
        'ArticuloBindingSource
        '
        Me.ArticuloBindingSource.DataSource = GetType(MP_Lucas_Sanz.Articulo)
        '
        'GrupoBindingSource
        '
        Me.GrupoBindingSource.DataSource = GetType(MP_Lucas_Sanz.Grupo)
        '
        'FormaPagoBindingSource
        '
        Me.FormaPagoBindingSource.DataSource = GetType(MP_Lucas_Sanz.FormaPago)
        '
        'InventarioBindingSource
        '
        Me.InventarioBindingSource.DataSource = GetType(MP_Lucas_Sanz.Inventario)
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataSource = GetType(MP_Lucas_Sanz.Cliente)
        '
        'BancoBindingSource
        '
        Me.BancoBindingSource.DataSource = GetType(MP_Lucas_Sanz.Banco)
        '
        'GrupoBindingSource1
        '
        Me.GrupoBindingSource1.DataSource = GetType(MP_Lucas_Sanz.Grupo)
        '
        'gb_tipos_factura
        '
        Me.gb_tipos_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_tipos_factura.Controls.Add(Me.rdb_facturas_venta)
        Me.gb_tipos_factura.Controls.Add(Me.rdb_facturas_compra)
        Me.gb_tipos_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_tipos_factura.Location = New System.Drawing.Point(3, 3)
        Me.gb_tipos_factura.Name = "gb_tipos_factura"
        Me.gb_tipos_factura.Size = New System.Drawing.Size(226, 78)
        Me.gb_tipos_factura.TabIndex = 9
        Me.gb_tipos_factura.TabStop = False
        Me.gb_tipos_factura.Text = "Mostrar"
        '
        'rdb_facturas_venta
        '
        Me.rdb_facturas_venta.AutoSize = True
        Me.rdb_facturas_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_facturas_venta.Location = New System.Drawing.Point(56, 48)
        Me.rdb_facturas_venta.Name = "rdb_facturas_venta"
        Me.rdb_facturas_venta.Size = New System.Drawing.Size(112, 17)
        Me.rdb_facturas_venta.TabIndex = 1
        Me.rdb_facturas_venta.TabStop = True
        Me.rdb_facturas_venta.Text = "Facturas de Venta"
        Me.rdb_facturas_venta.UseVisualStyleBackColor = True
        '
        'rdb_facturas_compra
        '
        Me.rdb_facturas_compra.AutoSize = True
        Me.rdb_facturas_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_facturas_compra.Location = New System.Drawing.Point(56, 19)
        Me.rdb_facturas_compra.Name = "rdb_facturas_compra"
        Me.rdb_facturas_compra.Size = New System.Drawing.Size(120, 17)
        Me.rdb_facturas_compra.TabIndex = 0
        Me.rdb_facturas_compra.TabStop = True
        Me.rdb_facturas_compra.Text = "Facturas de Compra"
        Me.rdb_facturas_compra.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel16.ResumeLayout(False)
        Me.TableLayoutPanel17.ResumeLayout(False)
        Me.tab_bancos_pagos.ResumeLayout(False)
        Me.tlp_main_bancos_pagos.ResumeLayout(False)
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel13.PerformLayout()
        Me.gb_formas_pago.ResumeLayout(False)
        Me.gb_formas_pago.PerformLayout()
        CType(Me.dg_bancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_formas_pago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlp_bancos.ResumeLayout(False)
        Me.tlp_pagos.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.gb_bancos.ResumeLayout(False)
        Me.gb_bancos.PerformLayout()
        Me.tab_clientes_grupos.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dg_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.dg_grupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.gb_grupos.ResumeLayout(False)
        Me.gb_grupos.PerformLayout()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.gb_clientes.ResumeLayout(False)
        Me.gb_clientes.PerformLayout()
        Me.tab_articulos_proveedores.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.TableLayoutPanel15.PerformLayout()
        Me.gb_articulos.ResumeLayout(False)
        Me.gb_articulos.PerformLayout()
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.dg_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.TableLayoutPanel14.PerformLayout()
        Me.gb_proveedores.ResumeLayout(False)
        Me.gb_proveedores.PerformLayout()
        Me.tab_inventario.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.dg_inventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.dg_movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_albaranes.ResumeLayout(False)
        Me.TableLayoutPanel18.ResumeLayout(False)
        CType(Me.dg_albaranes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel19.ResumeLayout(False)
        Me.TableLayoutPanel19.PerformLayout()
        Me.gb_ver_estado_albaranes.ResumeLayout(False)
        Me.gb_ver_estado_albaranes.PerformLayout()
        Me.gb_ver_albaranes.ResumeLayout(False)
        Me.gb_ver_albaranes.PerformLayout()
        Me.tab_facturas.ResumeLayout(False)
        Me.TableLayoutPanel20.ResumeLayout(False)
        CType(Me.dg_facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel21.ResumeLayout(False)
        Me.TableLayoutPanel21.PerformLayout()
        Me.tab_configuraciones.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_tipos_factura.ResumeLayout(False)
        Me.gb_tipos_factura.PerformLayout()
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
    Friend WithEvents ArticuloBindingSource As BindingSource
    Friend WithEvents tab_inventario As TabPage
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents dg_inventario As DataGridView
    Friend WithEvents NombreDeArticuloDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents InventarioBindingSource As BindingSource
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents btn_restar_unidades As Button
    Friend WithEvents btn_añadir_unidades As Button
    Friend WithEvents btn_añadir_articulo_inventario As Button
    Friend WithEvents btn_eliminar_articulo_inventario As Button
    Friend WithEvents txt_busqueda_inventario As TextBox
    Friend WithEvents tlp_menu_main As TableLayoutPanel
    Friend WithEvents btn_menu_factura As Button
    Friend WithEvents btn_menu_configuraciones As Button
    Friend WithEvents tab_configuraciones As TabPage
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents btn_actualizacion_campo_extra As Button
    Friend WithEvents btn_actualizacion_añadir_tabla As Button
    Friend WithEvents btn_actualizacion_añadir_fk As Button
    Friend WithEvents dg_movimientos As DataGridView
    Friend WithEvents idMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents usuarioMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents articuloMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents cantidadMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents tipoMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents facturaMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents fechaMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents stockMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents gb_grupos As GroupBox
    Friend WithEvents rdb_codigo_grupo As RadioButton
    Friend WithEvents txt_busqueda_grupo As TextBox
    Friend WithEvents rdb_nombre_grupo As RadioButton
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents txt_busqueda_cliente As TextBox
    Friend WithEvents gb_clientes As GroupBox
    Friend WithEvents rdb_nif_cliente As RadioButton
    Friend WithEvents rdb_nombre_cliente As RadioButton
    Friend WithEvents rdb_id_cliente As RadioButton
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents txt_busqueda_banco As TextBox
    Friend WithEvents gb_bancos As GroupBox
    Friend WithEvents rdb_nombre_banco As RadioButton
    Friend WithEvents rdb_codigo_banco As RadioButton
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents txt_busqueda_forma_pago As TextBox
    Friend WithEvents gb_formas_pago As GroupBox
    Friend WithEvents rdb_nombre_forma_pago As RadioButton
    Friend WithEvents rdb_codigo_forma_pago As RadioButton
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents gb_proveedores As GroupBox
    Friend WithEvents rdb_nombre_proveedor As RadioButton
    Friend WithEvents rdb_codigo_proveedor As RadioButton
    Friend WithEvents txt_busqueda_proveedor As TextBox
    Friend WithEvents txt_busqueda_articulo As TextBox
    Friend WithEvents gb_articulos As GroupBox
    Friend WithEvents rdb_nombre_articulo As RadioButton
    Friend WithEvents rdb_codigo_articulo As RadioButton
    Friend WithEvents TableLayoutPanel16 As TableLayoutPanel
    Friend WithEvents btn_efectuar_venta As Button
    Friend WithEvents btn_ver_ventas As Button
    Friend WithEvents TableLayoutPanel17 As TableLayoutPanel
    Friend WithEvents btn_ver_compras As Button
    Friend WithEvents btn_efectuar_compra As Button
    Friend WithEvents tab_albaranes As TabPage
    Friend WithEvents TableLayoutPanel18 As TableLayoutPanel
    Friend WithEvents dg_albaranes As DataGridView
    Friend WithEvents TableLayoutPanel19 As TableLayoutPanel
    Friend WithEvents idAlbaran As DataGridViewTextBoxColumn
    Friend WithEvents personaAlbaran As DataGridViewTextBoxColumn
    Friend WithEvents formaPagoAlbaran As DataGridViewTextBoxColumn
    Friend WithEvents fechaAlbaran As DataGridViewTextBoxColumn
    Friend WithEvents tipoAlbaran As DataGridViewTextBoxColumn
    Friend WithEvents facturaAlbaran As DataGridViewTextBoxColumn
    Friend WithEvents verAlbaran As DataGridViewButtonColumn
    Friend WithEvents gb_ver_albaranes As GroupBox
    Friend WithEvents rdb_ver_compras As RadioButton
    Friend WithEvents rdb_ver_ventas As RadioButton
    Friend WithEvents nombreBanco As DataGridViewTextBoxColumn
    Friend WithEvents codigoBanco As DataGridViewTextBoxColumn
    Friend WithEvents idFormaPago As DataGridViewTextBoxColumn
    Friend WithEvents nombreFormaPago As DataGridViewTextBoxColumn
    Friend WithEvents bancoFormaPago As DataGridViewTextBoxColumn
    Friend WithEvents activoFormaPago As DataGridViewCheckBoxColumn
    Friend WithEvents numPlazosFormaPago As DataGridViewTextBoxColumn
    Friend WithEvents primerPlazoFormaPago As DataGridViewTextBoxColumn
    Friend WithEvents intervaloFormaPago As DataGridViewTextBoxColumn
    Friend WithEvents idCliente As DataGridViewTextBoxColumn
    Friend WithEvents nombreCliente As DataGridViewTextBoxColumn
    Friend WithEvents nifCliente As DataGridViewTextBoxColumn
    Friend WithEvents fechaNacimientoCliente As DataGridViewTextBoxColumn
    Friend WithEvents direccionCliente As DataGridViewTextBoxColumn
    Friend WithEvents emailCliente As DataGridViewTextBoxColumn
    Friend WithEvents grupoCliente As DataGridViewTextBoxColumn
    Friend WithEvents bancoCliente As DataGridViewTextBoxColumn
    Friend WithEvents idGrupo As DataGridViewTextBoxColumn
    Friend WithEvents nombreGrupo As DataGridViewTextBoxColumn
    Friend WithEvents idArticulo As DataGridViewTextBoxColumn
    Friend WithEvents nombreArticuloo As DataGridViewTextBoxColumn
    Friend WithEvents descripcionArticulo As DataGridViewTextBoxColumn
    Friend WithEvents pvpCompraArticulo As DataGridViewTextBoxColumn
    Friend WithEvents pvpVentaArticulo As DataGridViewTextBoxColumn
    Friend WithEvents impuestoArticulo As DataGridViewTextBoxColumn
    Friend WithEvents porcBeneficioArticulo As DataGridViewTextBoxColumn
    Friend WithEvents tipoUnidadArticulo As DataGridViewTextBoxColumn
    Friend WithEvents familiaArticulo As DataGridViewTextBoxColumn
    Friend WithEvents idProveedor As DataGridViewTextBoxColumn
    Friend WithEvents nombreProveedor As DataGridViewTextBoxColumn
    Friend WithEvents datos As DataGridViewButtonColumn
    Friend WithEvents idInventario As DataGridViewTextBoxColumn
    Friend WithEvents nombreArticulo As DataGridViewTextBoxColumn
    Friend WithEvents stockActual As DataGridViewTextBoxColumn
    Friend WithEvents btn_eliminar_compra As Button
    Friend WithEvents gb_ver_estado_albaranes As GroupBox
    Friend WithEvents rdb_albaranes_eliminados As RadioButton
    Friend WithEvents rdb_albaranes_activos As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents dp_busqueda_inicio_albaran As DateTimePicker
    Public WithEvents dp_busqueda_fin_albaran As DateTimePicker
    Public WithEvents txt_busqueda_albaran_entidad As TextBox
    Public WithEvents txt_busqueda_albaran_factura As TextBox
    Friend WithEvents tab_facturas As TabPage
    Friend WithEvents TableLayoutPanel20 As TableLayoutPanel
    Friend WithEvents dg_facturas As DataGridView
    Friend WithEvents idFactura As DataGridViewTextBoxColumn
    Friend WithEvents entidadFactura As DataGridViewTextBoxColumn
    Friend WithEvents listaAlbaranesFactura As DataGridViewComboBoxColumn
    Friend WithEvents estadoFactura As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel21 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Public WithEvents TextBox1 As TextBox
    Public WithEvents btn_facturar_albaran As Button
    Public WithEvents btn_cambiar_estado_factura As Button
    Public WithEvents DateTimePicker1 As DateTimePicker
    Public WithEvents DateTimePicker2 As DateTimePicker
    Public WithEvents btn_busqueda_factura As Button
    Friend WithEvents gb_tipos_factura As GroupBox
    Friend WithEvents rdb_facturas_venta As RadioButton
    Friend WithEvents rdb_facturas_compra As RadioButton
End Class

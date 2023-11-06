<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompra))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_descuento_compra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_proveedor_seleccionado = New System.Windows.Forms.TextBox()
        Me.txt_articulo_seleccionado = New System.Windows.Forms.TextBox()
        Me.txt_cantidad_seleccionada = New System.Windows.Forms.TextBox()
        Me.btn_busqueda_proveedor = New System.Windows.Forms.Button()
        Me.btn_busqueda_articulo = New System.Windows.Forms.Button()
        Me.cb_forma_pago_seleccionada = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dp_fecha_compra = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_modificar_compra = New System.Windows.Forms.Button()
        Me.btn_eliminar_compra = New System.Windows.Forms.Button()
        Me.btn_añadir_compra = New System.Windows.Forms.Button()
        Me.dg_compras = New System.Windows.Forms.DataGridView()
        Me.idCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proveedorCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.articuloCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.formaPagoCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioBrutoCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuentoCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.baseImponibleCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impuestoCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioTotalCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_guardar_pdf = New System.Windows.Forms.Button()
        Me.lbl_impuesto = New System.Windows.Forms.Label()
        Me.lbl_base_imponible = New System.Windows.Forms.Label()
        Me.lbl_total_compra = New System.Windows.Forms.Label()
        Me.lbl_bruto = New System.Windows.Forms.Label()
        Me.btn_confirmar_compra = New System.Windows.Forms.Button()
        Me.CompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.dg_compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.CompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dg_compras, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(890, 398)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.txt_descuento_compra, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_proveedor_seleccionado, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_articulo_seleccionado, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_cantidad_seleccionada, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_busqueda_proveedor, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_busqueda_articulo, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cb_forma_pago_seleccionada, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.dp_fecha_compra, 4, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(884, 153)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'txt_descuento_compra
        '
        Me.txt_descuento_compra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_descuento_compra.Location = New System.Drawing.Point(81, 117)
        Me.txt_descuento_compra.Name = "txt_descuento_compra"
        Me.txt_descuento_compra.Size = New System.Drawing.Size(299, 20)
        Me.txt_descuento_compra.TabIndex = 13
        Me.txt_descuento_compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Descuento:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Artículo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(417, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Forma de Pago:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(417, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_proveedor_seleccionado
        '
        Me.txt_proveedor_seleccionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_proveedor_seleccionado.Enabled = False
        Me.txt_proveedor_seleccionado.Location = New System.Drawing.Point(81, 15)
        Me.txt_proveedor_seleccionado.Name = "txt_proveedor_seleccionado"
        Me.txt_proveedor_seleccionado.ReadOnly = True
        Me.txt_proveedor_seleccionado.Size = New System.Drawing.Size(299, 20)
        Me.txt_proveedor_seleccionado.TabIndex = 4
        Me.txt_proveedor_seleccionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_articulo_seleccionado
        '
        Me.txt_articulo_seleccionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_articulo_seleccionado.Enabled = False
        Me.txt_articulo_seleccionado.Location = New System.Drawing.Point(81, 66)
        Me.txt_articulo_seleccionado.Name = "txt_articulo_seleccionado"
        Me.txt_articulo_seleccionado.ReadOnly = True
        Me.txt_articulo_seleccionado.Size = New System.Drawing.Size(299, 20)
        Me.txt_articulo_seleccionado.TabIndex = 5
        Me.txt_articulo_seleccionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cantidad_seleccionada
        '
        Me.txt_cantidad_seleccionada.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cantidad_seleccionada.Location = New System.Drawing.Point(519, 66)
        Me.txt_cantidad_seleccionada.Name = "txt_cantidad_seleccionada"
        Me.txt_cantidad_seleccionada.Size = New System.Drawing.Size(362, 20)
        Me.txt_cantidad_seleccionada.TabIndex = 6
        Me.txt_cantidad_seleccionada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_busqueda_proveedor
        '
        Me.btn_busqueda_proveedor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_busqueda_proveedor.Image = Global.MP_Lucas_Sanz.My.Resources.Resources.lupa
        Me.btn_busqueda_proveedor.Location = New System.Drawing.Point(386, 13)
        Me.btn_busqueda_proveedor.Name = "btn_busqueda_proveedor"
        Me.btn_busqueda_proveedor.Size = New System.Drawing.Size(25, 25)
        Me.btn_busqueda_proveedor.TabIndex = 7
        Me.btn_busqueda_proveedor.UseVisualStyleBackColor = True
        '
        'btn_busqueda_articulo
        '
        Me.btn_busqueda_articulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_busqueda_articulo.Image = Global.MP_Lucas_Sanz.My.Resources.Resources.lupa
        Me.btn_busqueda_articulo.Location = New System.Drawing.Point(386, 64)
        Me.btn_busqueda_articulo.Name = "btn_busqueda_articulo"
        Me.btn_busqueda_articulo.Size = New System.Drawing.Size(25, 25)
        Me.btn_busqueda_articulo.TabIndex = 8
        Me.btn_busqueda_articulo.UseVisualStyleBackColor = True
        '
        'cb_forma_pago_seleccionada
        '
        Me.cb_forma_pago_seleccionada.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_forma_pago_seleccionada.FormattingEnabled = True
        Me.cb_forma_pago_seleccionada.Location = New System.Drawing.Point(519, 15)
        Me.cb_forma_pago_seleccionada.Name = "cb_forma_pago_seleccionada"
        Me.cb_forma_pago_seleccionada.Size = New System.Drawing.Size(362, 21)
        Me.cb_forma_pago_seleccionada.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(417, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dp_fecha_compra
        '
        Me.dp_fecha_compra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_fecha_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dp_fecha_compra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dp_fecha_compra.Location = New System.Drawing.Point(519, 117)
        Me.dp_fecha_compra.Name = "dp_fecha_compra"
        Me.dp_fecha_compra.Size = New System.Drawing.Size(362, 20)
        Me.dp_fecha_compra.TabIndex = 11
        Me.dp_fecha_compra.Value = New Date(2023, 10, 17, 0, 0, 0, 0)
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
        Me.TableLayoutPanel3.Controls.Add(Me.btn_modificar_compra, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_eliminar_compra, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_añadir_compra, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 162)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(884, 33)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'btn_modificar_compra
        '
        Me.btn_modificar_compra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_compra.Location = New System.Drawing.Point(681, 3)
        Me.btn_modificar_compra.Name = "btn_modificar_compra"
        Me.btn_modificar_compra.Size = New System.Drawing.Size(110, 27)
        Me.btn_modificar_compra.TabIndex = 2
        Me.btn_modificar_compra.Text = "MODIFICAR"
        Me.btn_modificar_compra.UseVisualStyleBackColor = True
        '
        'btn_eliminar_compra
        '
        Me.btn_eliminar_compra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_compra.Location = New System.Drawing.Point(386, 3)
        Me.btn_eliminar_compra.Name = "btn_eliminar_compra"
        Me.btn_eliminar_compra.Size = New System.Drawing.Size(110, 27)
        Me.btn_eliminar_compra.TabIndex = 1
        Me.btn_eliminar_compra.Text = "ELIMINAR"
        Me.btn_eliminar_compra.UseVisualStyleBackColor = True
        '
        'btn_añadir_compra
        '
        Me.btn_añadir_compra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_compra.Location = New System.Drawing.Point(92, 3)
        Me.btn_añadir_compra.Name = "btn_añadir_compra"
        Me.btn_añadir_compra.Size = New System.Drawing.Size(110, 27)
        Me.btn_añadir_compra.TabIndex = 0
        Me.btn_añadir_compra.Text = "AÑADIR"
        Me.btn_añadir_compra.UseVisualStyleBackColor = True
        '
        'dg_compras
        '
        Me.dg_compras.AllowUserToAddRows = False
        Me.dg_compras.AllowUserToDeleteRows = False
        Me.dg_compras.AllowUserToResizeRows = False
        Me.dg_compras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_compras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_compras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCompra, Me.proveedorCompra, Me.articuloCompra, Me.formaPagoCompra, Me.precioUnitario, Me.precioBrutoCompra, Me.cantidadCompra, Me.descuentoCompra, Me.baseImponibleCompra, Me.impuestoCompra, Me.precioTotalCompra})
        Me.dg_compras.Location = New System.Drawing.Point(3, 201)
        Me.dg_compras.MultiSelect = False
        Me.dg_compras.Name = "dg_compras"
        Me.dg_compras.RowHeadersVisible = False
        Me.dg_compras.Size = New System.Drawing.Size(884, 153)
        Me.dg_compras.TabIndex = 2
        '
        'idCompra
        '
        Me.idCompra.HeaderText = "ID"
        Me.idCompra.Name = "idCompra"
        Me.idCompra.ReadOnly = True
        Me.idCompra.Visible = False
        '
        'proveedorCompra
        '
        Me.proveedorCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.proveedorCompra.HeaderText = "Proveedor"
        Me.proveedorCompra.Name = "proveedorCompra"
        Me.proveedorCompra.ReadOnly = True
        '
        'articuloCompra
        '
        Me.articuloCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.articuloCompra.HeaderText = "Artículo"
        Me.articuloCompra.Name = "articuloCompra"
        Me.articuloCompra.ReadOnly = True
        '
        'formaPagoCompra
        '
        Me.formaPagoCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.formaPagoCompra.HeaderText = "Pago"
        Me.formaPagoCompra.Name = "formaPagoCompra"
        Me.formaPagoCompra.ReadOnly = True
        '
        'precioUnitario
        '
        Me.precioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.precioUnitario.HeaderText = "Precio Ud"
        Me.precioUnitario.Name = "precioUnitario"
        '
        'precioBrutoCompra
        '
        Me.precioBrutoCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.precioBrutoCompra.DefaultCellStyle = DataGridViewCellStyle2
        Me.precioBrutoCompra.HeaderText = "Bruto"
        Me.precioBrutoCompra.Name = "precioBrutoCompra"
        Me.precioBrutoCompra.ReadOnly = True
        '
        'cantidadCompra
        '
        Me.cantidadCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cantidadCompra.HeaderText = "Cantidad"
        Me.cantidadCompra.Name = "cantidadCompra"
        Me.cantidadCompra.ReadOnly = True
        '
        'descuentoCompra
        '
        Me.descuentoCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descuentoCompra.HeaderText = "Descuento"
        Me.descuentoCompra.Name = "descuentoCompra"
        Me.descuentoCompra.ReadOnly = True
        '
        'baseImponibleCompra
        '
        Me.baseImponibleCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.baseImponibleCompra.DefaultCellStyle = DataGridViewCellStyle3
        Me.baseImponibleCompra.HeaderText = "Base Imponible"
        Me.baseImponibleCompra.Name = "baseImponibleCompra"
        Me.baseImponibleCompra.ReadOnly = True
        '
        'impuestoCompra
        '
        Me.impuestoCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Format = "N2"
        Me.impuestoCompra.DefaultCellStyle = DataGridViewCellStyle4
        Me.impuestoCompra.HeaderText = "Impuesto"
        Me.impuestoCompra.Name = "impuestoCompra"
        Me.impuestoCompra.ReadOnly = True
        '
        'precioTotalCompra
        '
        Me.precioTotalCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Format = "N2"
        Me.precioTotalCompra.DefaultCellStyle = DataGridViewCellStyle5
        Me.precioTotalCompra.HeaderText = "Total"
        Me.precioTotalCompra.Name = "precioTotalCompra"
        Me.precioTotalCompra.ReadOnly = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 6
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btn_guardar_pdf, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_impuesto, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_base_imponible, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_total_compra, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_bruto, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_confirmar_compra, 5, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 360)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(884, 35)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'btn_guardar_pdf
        '
        Me.btn_guardar_pdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar_pdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_pdf.Location = New System.Drawing.Point(531, 6)
        Me.btn_guardar_pdf.Name = "btn_guardar_pdf"
        Me.btn_guardar_pdf.Size = New System.Drawing.Size(170, 23)
        Me.btn_guardar_pdf.TabIndex = 14
        Me.btn_guardar_pdf.Text = "GUARDAR PDF"
        Me.btn_guardar_pdf.UseVisualStyleBackColor = True
        '
        'lbl_impuesto
        '
        Me.lbl_impuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_impuesto.AutoSize = True
        Me.lbl_impuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_impuesto.Location = New System.Drawing.Point(135, 11)
        Me.lbl_impuesto.Name = "lbl_impuesto"
        Me.lbl_impuesto.Size = New System.Drawing.Size(126, 13)
        Me.lbl_impuesto.TabIndex = 12
        Me.lbl_impuesto.Text = "Impuesto:"
        Me.lbl_impuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_impuesto.Visible = False
        '
        'lbl_base_imponible
        '
        Me.lbl_base_imponible.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_base_imponible.AutoSize = True
        Me.lbl_base_imponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_base_imponible.Location = New System.Drawing.Point(267, 11)
        Me.lbl_base_imponible.Name = "lbl_base_imponible"
        Me.lbl_base_imponible.Size = New System.Drawing.Size(126, 13)
        Me.lbl_base_imponible.TabIndex = 11
        Me.lbl_base_imponible.Text = "Base Imp:"
        Me.lbl_base_imponible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_base_imponible.Visible = False
        '
        'lbl_total_compra
        '
        Me.lbl_total_compra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total_compra.AutoSize = True
        Me.lbl_total_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_compra.ForeColor = System.Drawing.Color.Black
        Me.lbl_total_compra.Location = New System.Drawing.Point(399, 11)
        Me.lbl_total_compra.Name = "lbl_total_compra"
        Me.lbl_total_compra.Size = New System.Drawing.Size(126, 13)
        Me.lbl_total_compra.TabIndex = 9
        Me.lbl_total_compra.Text = "Importe Total:"
        Me.lbl_total_compra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_total_compra.Visible = False
        '
        'lbl_bruto
        '
        Me.lbl_bruto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_bruto.AutoSize = True
        Me.lbl_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bruto.Location = New System.Drawing.Point(3, 11)
        Me.lbl_bruto.Name = "lbl_bruto"
        Me.lbl_bruto.Size = New System.Drawing.Size(126, 13)
        Me.lbl_bruto.TabIndex = 10
        Me.lbl_bruto.Text = "Bruto:"
        Me.lbl_bruto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_bruto.Visible = False
        '
        'btn_confirmar_compra
        '
        Me.btn_confirmar_compra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_confirmar_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar_compra.Location = New System.Drawing.Point(707, 6)
        Me.btn_confirmar_compra.Name = "btn_confirmar_compra"
        Me.btn_confirmar_compra.Size = New System.Drawing.Size(174, 23)
        Me.btn_confirmar_compra.TabIndex = 4
        Me.btn_confirmar_compra.Text = "CONFIRMAR COMPRA"
        Me.btn_confirmar_compra.UseVisualStyleBackColor = True
        '
        'CompraBindingSource
        '
        Me.CompraBindingSource.DataSource = GetType(MP_Lucas_Sanz.Compra)
        '
        'frmCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 402)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompra"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EFECTUAR COMPRA"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.dg_compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.CompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_proveedor_seleccionado As TextBox
    Friend WithEvents txt_articulo_seleccionado As TextBox
    Friend WithEvents txt_cantidad_seleccionada As TextBox
    Friend WithEvents btn_busqueda_proveedor As Button
    Friend WithEvents btn_busqueda_articulo As Button
    Friend WithEvents cb_forma_pago_seleccionada As ComboBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btn_modificar_compra As Button
    Friend WithEvents btn_eliminar_compra As Button
    Friend WithEvents btn_añadir_compra As Button
    Friend WithEvents dg_compras As DataGridView
    Friend WithEvents CompraBindingSource As BindingSource
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btn_confirmar_compra As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dp_fecha_compra As DateTimePicker
    Friend WithEvents txt_descuento_compra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_impuesto As Label
    Friend WithEvents lbl_total_compra As Label
    Friend WithEvents lbl_bruto As Label
    Friend WithEvents idCompra As DataGridViewTextBoxColumn
    Friend WithEvents proveedorCompra As DataGridViewTextBoxColumn
    Friend WithEvents articuloCompra As DataGridViewTextBoxColumn
    Friend WithEvents formaPagoCompra As DataGridViewTextBoxColumn
    Friend WithEvents precioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents precioBrutoCompra As DataGridViewTextBoxColumn
    Friend WithEvents cantidadCompra As DataGridViewTextBoxColumn
    Friend WithEvents descuentoCompra As DataGridViewTextBoxColumn
    Friend WithEvents baseImponibleCompra As DataGridViewTextBoxColumn
    Friend WithEvents impuestoCompra As DataGridViewTextBoxColumn
    Friend WithEvents precioTotalCompra As DataGridViewTextBoxColumn
    Friend WithEvents btn_guardar_pdf As Button
    Friend WithEvents lbl_base_imponible As Label
End Class

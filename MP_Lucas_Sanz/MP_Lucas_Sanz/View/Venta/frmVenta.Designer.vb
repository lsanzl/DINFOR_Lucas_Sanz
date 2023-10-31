<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenta))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cliente_seleccionado = New System.Windows.Forms.TextBox()
        Me.txt_articulo_seleccionado_venta = New System.Windows.Forms.TextBox()
        Me.txt_cantidad_seleccionada_venta = New System.Windows.Forms.TextBox()
        Me.btn_busqueda_cliente = New System.Windows.Forms.Button()
        Me.btn_busqueda_articulo_venta = New System.Windows.Forms.Button()
        Me.cb_forma_pago_seleccionada_venta = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dp_fecha_venta = New System.Windows.Forms.DateTimePicker()
        Me.txt_descuento_venta = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_modificar_venta = New System.Windows.Forms.Button()
        Me.btn_eliminar_venta = New System.Windows.Forms.Button()
        Me.btn_añadir_venta = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_impuesto = New System.Windows.Forms.Label()
        Me.lbl_base_imponible = New System.Windows.Forms.Label()
        Me.btn_confirmar_venta = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_bruto = New System.Windows.Forms.Label()
        Me.dg_ventas = New System.Windows.Forms.DataGridView()
        Me.idVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clienteVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.articuloVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.formaPagoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioBrutoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuentoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.baseImponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impuestoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioTotalVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.dg_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.dg_ventas, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(845, 394)
        Me.TableLayoutPanel1.TabIndex = 1
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
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_cliente_seleccionado, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_articulo_seleccionado_venta, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_cantidad_seleccionada_venta, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_busqueda_cliente, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_busqueda_articulo_venta, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cb_forma_pago_seleccionada_venta, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.dp_fecha_venta, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_descuento_venta, 1, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(839, 151)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 119)
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
        Me.Label3.Location = New System.Drawing.Point(3, 68)
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
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(380, 18)
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
        Me.Label4.Location = New System.Drawing.Point(380, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_cliente_seleccionado
        '
        Me.txt_cliente_seleccionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cliente_seleccionado.Enabled = False
        Me.txt_cliente_seleccionado.Location = New System.Drawing.Point(81, 15)
        Me.txt_cliente_seleccionado.Name = "txt_cliente_seleccionado"
        Me.txt_cliente_seleccionado.ReadOnly = True
        Me.txt_cliente_seleccionado.Size = New System.Drawing.Size(262, 20)
        Me.txt_cliente_seleccionado.TabIndex = 4
        Me.txt_cliente_seleccionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_articulo_seleccionado_venta
        '
        Me.txt_articulo_seleccionado_venta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_articulo_seleccionado_venta.Enabled = False
        Me.txt_articulo_seleccionado_venta.Location = New System.Drawing.Point(81, 65)
        Me.txt_articulo_seleccionado_venta.Name = "txt_articulo_seleccionado_venta"
        Me.txt_articulo_seleccionado_venta.ReadOnly = True
        Me.txt_articulo_seleccionado_venta.Size = New System.Drawing.Size(262, 20)
        Me.txt_articulo_seleccionado_venta.TabIndex = 5
        Me.txt_articulo_seleccionado_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cantidad_seleccionada_venta
        '
        Me.txt_cantidad_seleccionada_venta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cantidad_seleccionada_venta.Location = New System.Drawing.Point(482, 65)
        Me.txt_cantidad_seleccionada_venta.Name = "txt_cantidad_seleccionada_venta"
        Me.txt_cantidad_seleccionada_venta.Size = New System.Drawing.Size(354, 20)
        Me.txt_cantidad_seleccionada_venta.TabIndex = 6
        Me.txt_cantidad_seleccionada_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_busqueda_cliente
        '
        Me.btn_busqueda_cliente.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_busqueda_cliente.Image = Global.MP_Lucas_Sanz.My.Resources.Resources.lupa
        Me.btn_busqueda_cliente.Location = New System.Drawing.Point(349, 12)
        Me.btn_busqueda_cliente.Name = "btn_busqueda_cliente"
        Me.btn_busqueda_cliente.Size = New System.Drawing.Size(25, 25)
        Me.btn_busqueda_cliente.TabIndex = 7
        Me.btn_busqueda_cliente.UseVisualStyleBackColor = True
        '
        'btn_busqueda_articulo_venta
        '
        Me.btn_busqueda_articulo_venta.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_busqueda_articulo_venta.Image = Global.MP_Lucas_Sanz.My.Resources.Resources.lupa
        Me.btn_busqueda_articulo_venta.Location = New System.Drawing.Point(349, 62)
        Me.btn_busqueda_articulo_venta.Name = "btn_busqueda_articulo_venta"
        Me.btn_busqueda_articulo_venta.Size = New System.Drawing.Size(25, 25)
        Me.btn_busqueda_articulo_venta.TabIndex = 8
        Me.btn_busqueda_articulo_venta.UseVisualStyleBackColor = True
        '
        'cb_forma_pago_seleccionada_venta
        '
        Me.cb_forma_pago_seleccionada_venta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_forma_pago_seleccionada_venta.FormattingEnabled = True
        Me.cb_forma_pago_seleccionada_venta.Location = New System.Drawing.Point(482, 14)
        Me.cb_forma_pago_seleccionada_venta.Name = "cb_forma_pago_seleccionada_venta"
        Me.cb_forma_pago_seleccionada_venta.Size = New System.Drawing.Size(354, 21)
        Me.cb_forma_pago_seleccionada_venta.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(380, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dp_fecha_venta
        '
        Me.dp_fecha_venta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_fecha_venta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dp_fecha_venta.Location = New System.Drawing.Point(482, 115)
        Me.dp_fecha_venta.Name = "dp_fecha_venta"
        Me.dp_fecha_venta.Size = New System.Drawing.Size(354, 20)
        Me.dp_fecha_venta.TabIndex = 11
        Me.dp_fecha_venta.Value = New Date(2023, 10, 17, 0, 0, 0, 0)
        '
        'txt_descuento_venta
        '
        Me.txt_descuento_venta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_descuento_venta.Location = New System.Drawing.Point(81, 115)
        Me.txt_descuento_venta.Name = "txt_descuento_venta"
        Me.txt_descuento_venta.Size = New System.Drawing.Size(262, 20)
        Me.txt_descuento_venta.TabIndex = 13
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
        Me.TableLayoutPanel3.Controls.Add(Me.btn_modificar_venta, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_eliminar_venta, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_añadir_venta, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 160)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(839, 33)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'btn_modificar_venta
        '
        Me.btn_modificar_venta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_venta.Enabled = False
        Me.btn_modificar_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_venta.Location = New System.Drawing.Point(643, 3)
        Me.btn_modificar_venta.Name = "btn_modificar_venta"
        Me.btn_modificar_venta.Size = New System.Drawing.Size(110, 27)
        Me.btn_modificar_venta.TabIndex = 2
        Me.btn_modificar_venta.Text = "MODIFICAR"
        Me.btn_modificar_venta.UseVisualStyleBackColor = True
        '
        'btn_eliminar_venta
        '
        Me.btn_eliminar_venta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar_venta.Enabled = False
        Me.btn_eliminar_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_venta.Location = New System.Drawing.Point(363, 3)
        Me.btn_eliminar_venta.Name = "btn_eliminar_venta"
        Me.btn_eliminar_venta.Size = New System.Drawing.Size(110, 27)
        Me.btn_eliminar_venta.TabIndex = 1
        Me.btn_eliminar_venta.Text = "ELIMINAR"
        Me.btn_eliminar_venta.UseVisualStyleBackColor = True
        '
        'btn_añadir_venta
        '
        Me.btn_añadir_venta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btn_añadir_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_venta.Location = New System.Drawing.Point(84, 3)
        Me.btn_añadir_venta.Name = "btn_añadir_venta"
        Me.btn_añadir_venta.Size = New System.Drawing.Size(110, 27)
        Me.btn_añadir_venta.TabIndex = 0
        Me.btn_añadir_venta.Text = "AÑADIR"
        Me.btn_añadir_venta.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_impuesto, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_base_imponible, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_confirmar_venta, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_total, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_bruto, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 356)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(839, 35)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'lbl_impuesto
        '
        Me.lbl_impuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_impuesto.AutoSize = True
        Me.lbl_impuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_impuesto.Location = New System.Drawing.Point(337, 10)
        Me.lbl_impuesto.Name = "lbl_impuesto"
        Me.lbl_impuesto.Size = New System.Drawing.Size(161, 15)
        Me.lbl_impuesto.TabIndex = 8
        Me.lbl_impuesto.Text = "Impuesto:"
        Me.lbl_impuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_impuesto.Visible = False
        '
        'lbl_base_imponible
        '
        Me.lbl_base_imponible.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_base_imponible.AutoSize = True
        Me.lbl_base_imponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_base_imponible.Location = New System.Drawing.Point(170, 10)
        Me.lbl_base_imponible.Name = "lbl_base_imponible"
        Me.lbl_base_imponible.Size = New System.Drawing.Size(161, 15)
        Me.lbl_base_imponible.TabIndex = 7
        Me.lbl_base_imponible.Text = "Base Imponible:"
        Me.lbl_base_imponible.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_base_imponible.Visible = False
        '
        'btn_confirmar_venta
        '
        Me.btn_confirmar_venta.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_confirmar_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar_venta.Location = New System.Drawing.Point(696, 6)
        Me.btn_confirmar_venta.Name = "btn_confirmar_venta"
        Me.btn_confirmar_venta.Size = New System.Drawing.Size(140, 23)
        Me.btn_confirmar_venta.TabIndex = 4
        Me.btn_confirmar_venta.Text = "CONFIRMAR VENTA"
        Me.btn_confirmar_venta.UseVisualStyleBackColor = True
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(504, 10)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(161, 15)
        Me.lbl_total.TabIndex = 5
        Me.lbl_total.Text = "Importe Total:"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_total.Visible = False
        '
        'lbl_bruto
        '
        Me.lbl_bruto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_bruto.AutoSize = True
        Me.lbl_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bruto.Location = New System.Drawing.Point(3, 10)
        Me.lbl_bruto.Name = "lbl_bruto"
        Me.lbl_bruto.Size = New System.Drawing.Size(161, 15)
        Me.lbl_bruto.TabIndex = 6
        Me.lbl_bruto.Text = "Bruto:"
        Me.lbl_bruto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_bruto.Visible = False
        '
        'dg_ventas
        '
        Me.dg_ventas.AllowUserToAddRows = False
        Me.dg_ventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_ventas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_ventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idVenta, Me.clienteVenta, Me.articuloVenta, Me.formaPagoVenta, Me.precioUnitario, Me.precioBrutoVenta, Me.cantidadVenta, Me.descuentoVenta, Me.baseImponible, Me.impuestoVenta, Me.precioTotalVenta})
        Me.dg_ventas.Location = New System.Drawing.Point(3, 199)
        Me.dg_ventas.Name = "dg_ventas"
        Me.dg_ventas.RowHeadersVisible = False
        Me.dg_ventas.Size = New System.Drawing.Size(839, 151)
        Me.dg_ventas.TabIndex = 4
        '
        'idVenta
        '
        Me.idVenta.HeaderText = "ID"
        Me.idVenta.Name = "idVenta"
        Me.idVenta.Visible = False
        '
        'clienteVenta
        '
        Me.clienteVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clienteVenta.HeaderText = "Cliente"
        Me.clienteVenta.Name = "clienteVenta"
        '
        'articuloVenta
        '
        Me.articuloVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.articuloVenta.HeaderText = "Artículo"
        Me.articuloVenta.Name = "articuloVenta"
        '
        'formaPagoVenta
        '
        Me.formaPagoVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.formaPagoVenta.HeaderText = "Pago"
        Me.formaPagoVenta.Name = "formaPagoVenta"
        '
        'precioUnitario
        '
        Me.precioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.precioUnitario.HeaderText = "Precio Ud"
        Me.precioUnitario.Name = "precioUnitario"
        '
        'precioBrutoVenta
        '
        Me.precioBrutoVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.precioBrutoVenta.DefaultCellStyle = DataGridViewCellStyle2
        Me.precioBrutoVenta.HeaderText = "Bruto"
        Me.precioBrutoVenta.Name = "precioBrutoVenta"
        '
        'cantidadVenta
        '
        Me.cantidadVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cantidadVenta.HeaderText = "Cantidad"
        Me.cantidadVenta.Name = "cantidadVenta"
        '
        'descuentoVenta
        '
        Me.descuentoVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.descuentoVenta.DefaultCellStyle = DataGridViewCellStyle3
        Me.descuentoVenta.HeaderText = "Descuento"
        Me.descuentoVenta.Name = "descuentoVenta"
        '
        'baseImponible
        '
        Me.baseImponible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.baseImponible.DefaultCellStyle = DataGridViewCellStyle4
        Me.baseImponible.HeaderText = "Base Imponible"
        Me.baseImponible.Name = "baseImponible"
        '
        'impuestoVenta
        '
        Me.impuestoVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.impuestoVenta.DefaultCellStyle = DataGridViewCellStyle5
        Me.impuestoVenta.HeaderText = "Impuesto"
        Me.impuestoVenta.Name = "impuestoVenta"
        '
        'precioTotalVenta
        '
        Me.precioTotalVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.precioTotalVenta.DefaultCellStyle = DataGridViewCellStyle6
        Me.precioTotalVenta.HeaderText = "Total"
        Me.precioTotalVenta.Name = "precioTotalVenta"
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 398)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVenta"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EFECTUAR VENTA"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.dg_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cliente_seleccionado As TextBox
    Friend WithEvents txt_articulo_seleccionado_venta As TextBox
    Friend WithEvents txt_cantidad_seleccionada_venta As TextBox
    Friend WithEvents btn_busqueda_cliente As Button
    Friend WithEvents btn_busqueda_articulo_venta As Button
    Friend WithEvents cb_forma_pago_seleccionada_venta As ComboBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btn_modificar_venta As Button
    Friend WithEvents btn_eliminar_venta As Button
    Friend WithEvents btn_añadir_venta As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btn_confirmar_venta As Button
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dp_fecha_venta As DateTimePicker
    Friend WithEvents dg_ventas As DataGridView
    Friend WithEvents lbl_impuesto As Label
    Friend WithEvents lbl_base_imponible As Label
    Friend WithEvents lbl_bruto As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_descuento_venta As TextBox
    Friend WithEvents idVenta As DataGridViewTextBoxColumn
    Friend WithEvents clienteVenta As DataGridViewTextBoxColumn
    Friend WithEvents articuloVenta As DataGridViewTextBoxColumn
    Friend WithEvents formaPagoVenta As DataGridViewTextBoxColumn
    Friend WithEvents precioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents precioBrutoVenta As DataGridViewTextBoxColumn
    Friend WithEvents cantidadVenta As DataGridViewTextBoxColumn
    Friend WithEvents descuentoVenta As DataGridViewTextBoxColumn
    Friend WithEvents baseImponible As DataGridViewTextBoxColumn
    Friend WithEvents impuestoVenta As DataGridViewTextBoxColumn
    Friend WithEvents precioTotalVenta As DataGridViewTextBoxColumn
End Class

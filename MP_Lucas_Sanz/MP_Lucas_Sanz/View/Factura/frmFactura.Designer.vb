<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFactura))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gb_cliente_factura = New System.Windows.Forms.GroupBox()
        Me.btn_busqueda_cliente = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gb_albaranes_factura = New System.Windows.Forms.GroupBox()
        Me.dg_albaranes_factura = New System.Windows.Forms.DataGridView()
        Me.idAlbaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaAlbaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.incluidoAlbaran = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_descuento_factura = New System.Windows.Forms.TextBox()
        Me.txt_impuestos_factura = New System.Windows.Forms.TextBox()
        Me.txt_base_imponible_factura = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_bruto_factura = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_total_factura = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.gb_datos_factura = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_forma_pago_factura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dp_factura = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gb_cliente_factura.SuspendLayout()
        Me.gb_albaranes_factura.SuspendLayout()
        CType(Me.dg_albaranes_factura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.gb_datos_factura.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.gb_cliente_factura, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gb_albaranes_factura, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(798, 562)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'gb_cliente_factura
        '
        Me.gb_cliente_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_cliente_factura.Controls.Add(Me.btn_busqueda_cliente)
        Me.gb_cliente_factura.Controls.Add(Me.TextBox8)
        Me.gb_cliente_factura.Controls.Add(Me.Label10)
        Me.gb_cliente_factura.Controls.Add(Me.TextBox7)
        Me.gb_cliente_factura.Controls.Add(Me.Label9)
        Me.gb_cliente_factura.Controls.Add(Me.TextBox6)
        Me.gb_cliente_factura.Controls.Add(Me.Label8)
        Me.gb_cliente_factura.Controls.Add(Me.TextBox4)
        Me.gb_cliente_factura.Controls.Add(Me.Label6)
        Me.gb_cliente_factura.Controls.Add(Me.TextBox3)
        Me.gb_cliente_factura.Controls.Add(Me.Label5)
        Me.gb_cliente_factura.Controls.Add(Me.TextBox2)
        Me.gb_cliente_factura.Controls.Add(Me.Label4)
        Me.gb_cliente_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_cliente_factura.Location = New System.Drawing.Point(402, 3)
        Me.gb_cliente_factura.Name = "gb_cliente_factura"
        Me.gb_cliente_factura.Size = New System.Drawing.Size(393, 275)
        Me.gb_cliente_factura.TabIndex = 1
        Me.gb_cliente_factura.TabStop = False
        Me.gb_cliente_factura.Text = "Datos del cliente"
        '
        'btn_busqueda_cliente
        '
        Me.btn_busqueda_cliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_busqueda_cliente.Image = Global.MP_Lucas_Sanz.My.Resources.Resources.lupa
        Me.btn_busqueda_cliente.Location = New System.Drawing.Point(180, 59)
        Me.btn_busqueda_cliente.Name = "btn_busqueda_cliente"
        Me.btn_busqueda_cliente.Size = New System.Drawing.Size(24, 24)
        Me.btn_busqueda_cliente.TabIndex = 15
        Me.btn_busqueda_cliente.UseVisualStyleBackColor = True
        Me.btn_busqueda_cliente.Visible = False
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.Location = New System.Drawing.Point(17, 234)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(357, 22)
        Me.TextBox8.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 218)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Dirección"
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.Location = New System.Drawing.Point(17, 176)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(357, 22)
        Me.TextBox7.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Email"
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.Location = New System.Drawing.Point(212, 118)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(162, 22)
        Me.TextBox6.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(210, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Grupo"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Location = New System.Drawing.Point(17, 118)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(162, 22)
        Me.TextBox4.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Teléfono"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(212, 60)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(162, 22)
        Me.TextBox3.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(210, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "NIF"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(17, 60)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(162, 22)
        Me.TextBox2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cliente"
        '
        'gb_albaranes_factura
        '
        Me.gb_albaranes_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_albaranes_factura.Controls.Add(Me.dg_albaranes_factura)
        Me.gb_albaranes_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_albaranes_factura.Location = New System.Drawing.Point(3, 284)
        Me.gb_albaranes_factura.Name = "gb_albaranes_factura"
        Me.gb_albaranes_factura.Size = New System.Drawing.Size(393, 275)
        Me.gb_albaranes_factura.TabIndex = 2
        Me.gb_albaranes_factura.TabStop = False
        Me.gb_albaranes_factura.Text = "Albaranes"
        '
        'dg_albaranes_factura
        '
        Me.dg_albaranes_factura.AllowUserToAddRows = False
        Me.dg_albaranes_factura.AllowUserToDeleteRows = False
        Me.dg_albaranes_factura.AllowUserToResizeColumns = False
        Me.dg_albaranes_factura.AllowUserToResizeRows = False
        Me.dg_albaranes_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_albaranes_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_albaranes_factura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idAlbaran, Me.fechaAlbaran, Me.incluidoAlbaran})
        Me.dg_albaranes_factura.Location = New System.Drawing.Point(11, 21)
        Me.dg_albaranes_factura.MultiSelect = False
        Me.dg_albaranes_factura.Name = "dg_albaranes_factura"
        Me.dg_albaranes_factura.RowHeadersVisible = False
        Me.dg_albaranes_factura.Size = New System.Drawing.Size(360, 248)
        Me.dg_albaranes_factura.TabIndex = 0
        '
        'idAlbaran
        '
        Me.idAlbaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.idAlbaran.HeaderText = "Código"
        Me.idAlbaran.Name = "idAlbaran"
        Me.idAlbaran.ReadOnly = True
        '
        'fechaAlbaran
        '
        Me.fechaAlbaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.fechaAlbaran.HeaderText = "Fecha"
        Me.fechaAlbaran.Name = "fechaAlbaran"
        Me.fechaAlbaran.ReadOnly = True
        '
        'incluidoAlbaran
        '
        Me.incluidoAlbaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.incluidoAlbaran.HeaderText = "Incluido"
        Me.incluidoAlbaran.Name = "incluidoAlbaran"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(402, 284)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(393, 275)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txt_descuento_factura, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_impuestos_factura, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_base_imponible_factura, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label14, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_bruto_factura, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(8, 8)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(8)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(377, 66)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'txt_descuento_factura
        '
        Me.txt_descuento_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_descuento_factura.Location = New System.Drawing.Point(290, 38)
        Me.txt_descuento_factura.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.txt_descuento_factura.Name = "txt_descuento_factura"
        Me.txt_descuento_factura.ReadOnly = True
        Me.txt_descuento_factura.Size = New System.Drawing.Size(76, 20)
        Me.txt_descuento_factura.TabIndex = 7
        Me.txt_descuento_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_impuestos_factura
        '
        Me.txt_impuestos_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_impuestos_factura.Location = New System.Drawing.Point(197, 38)
        Me.txt_impuestos_factura.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.txt_impuestos_factura.Name = "txt_impuestos_factura"
        Me.txt_impuestos_factura.ReadOnly = True
        Me.txt_impuestos_factura.Size = New System.Drawing.Size(74, 20)
        Me.txt_impuestos_factura.TabIndex = 6
        Me.txt_impuestos_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_base_imponible_factura
        '
        Me.txt_base_imponible_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_base_imponible_factura.Location = New System.Drawing.Point(104, 38)
        Me.txt_base_imponible_factura.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.txt_base_imponible_factura.Name = "txt_base_imponible_factura"
        Me.txt_base_imponible_factura.ReadOnly = True
        Me.txt_base_imponible_factura.Size = New System.Drawing.Size(74, 20)
        Me.txt_base_imponible_factura.TabIndex = 5
        Me.txt_base_imponible_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Bruto"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(99, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "B.Imponible"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(192, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Impuestos"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(285, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Descuento"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_bruto_factura
        '
        Me.txt_bruto_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_bruto_factura.Location = New System.Drawing.Point(11, 38)
        Me.txt_bruto_factura.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.txt_bruto_factura.Name = "txt_bruto_factura"
        Me.txt_bruto_factura.ReadOnly = True
        Me.txt_bruto_factura.Size = New System.Drawing.Size(74, 20)
        Me.txt_bruto_factura.TabIndex = 4
        Me.txt_bruto_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.txt_total_factura, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(213, 90)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(8)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(172, 66)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'txt_total_factura
        '
        Me.txt_total_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_total_factura.Location = New System.Drawing.Point(11, 38)
        Me.txt_total_factura.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.txt_total_factura.Name = "txt_total_factura"
        Me.txt_total_factura.ReadOnly = True
        Me.txt_total_factura.Size = New System.Drawing.Size(150, 20)
        Me.txt_total_factura.TabIndex = 5
        Me.txt_total_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(160, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "TOTAL"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Button1, 3, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Button2, 2, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Button3, 1, 1)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 167)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(387, 105)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(291, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "FACTURAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(195, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "GUARDAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(99, 67)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "CANCELAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'gb_datos_factura
        '
        Me.gb_datos_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_datos_factura.Controls.Add(Me.TextBox5)
        Me.gb_datos_factura.Controls.Add(Me.Label7)
        Me.gb_datos_factura.Controls.Add(Me.TextBox1)
        Me.gb_datos_factura.Controls.Add(Me.Label3)
        Me.gb_datos_factura.Controls.Add(Me.txt_forma_pago_factura)
        Me.gb_datos_factura.Controls.Add(Me.Label1)
        Me.gb_datos_factura.Controls.Add(Me.dp_factura)
        Me.gb_datos_factura.Controls.Add(Me.Label2)
        Me.gb_datos_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_datos_factura.Location = New System.Drawing.Point(4, 4)
        Me.gb_datos_factura.Margin = New System.Windows.Forms.Padding(8)
        Me.gb_datos_factura.Name = "gb_datos_factura"
        Me.gb_datos_factura.Size = New System.Drawing.Size(393, 275)
        Me.gb_datos_factura.TabIndex = 3
        Me.gb_datos_factura.TabStop = False
        Me.gb_datos_factura.Text = "Identificación de factura"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(206, 118)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(165, 22)
        Me.TextBox5.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(204, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Banco"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(11, 60)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(165, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Referencia"
        '
        'txt_forma_pago_factura
        '
        Me.txt_forma_pago_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_forma_pago_factura.Location = New System.Drawing.Point(206, 60)
        Me.txt_forma_pago_factura.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.txt_forma_pago_factura.Name = "txt_forma_pago_factura"
        Me.txt_forma_pago_factura.ReadOnly = True
        Me.txt_forma_pago_factura.Size = New System.Drawing.Size(165, 22)
        Me.txt_forma_pago_factura.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Forma de pago"
        '
        'dp_factura
        '
        Me.dp_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dp_factura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dp_factura.Location = New System.Drawing.Point(11, 120)
        Me.dp_factura.Name = "dp_factura"
        Me.dp_factura.Size = New System.Drawing.Size(165, 20)
        Me.dp_factura.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha facturación"
        '
        'frmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 564)
        Me.Controls.Add(Me.gb_datos_factura)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gb_cliente_factura.ResumeLayout(False)
        Me.gb_cliente_factura.PerformLayout()
        Me.gb_albaranes_factura.ResumeLayout(False)
        CType(Me.dg_albaranes_factura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.gb_datos_factura.ResumeLayout(False)
        Me.gb_datos_factura.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents gb_cliente_factura As GroupBox
    Public WithEvents gb_datos_factura As GroupBox
    Public WithEvents TextBox1 As TextBox
    Public WithEvents Label3 As Label
    Public WithEvents txt_forma_pago_factura As TextBox
    Public WithEvents Label1 As Label
    Friend WithEvents dp_factura As DateTimePicker
    Friend WithEvents Label2 As Label
    Public WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Public WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Public WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Public WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Public WithEvents TextBox8 As TextBox
    Friend WithEvents Label10 As Label
    Public WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Public WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents gb_albaranes_factura As GroupBox
    Public WithEvents dg_albaranes_factura As DataGridView
    Friend WithEvents idAlbaran As DataGridViewTextBoxColumn
    Friend WithEvents fechaAlbaran As DataGridViewTextBoxColumn
    Friend WithEvents incluidoAlbaran As DataGridViewCheckBoxColumn
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_descuento_factura As TextBox
    Friend WithEvents txt_impuestos_factura As TextBox
    Friend WithEvents txt_base_imponible_factura As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_bruto_factura As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txt_total_factura As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_busqueda_cliente As Button
End Class

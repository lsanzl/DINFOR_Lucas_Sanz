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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFactura))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gb_cliente_factura = New System.Windows.Forms.GroupBox()
        Me.txt_telefono_cliente_factura = New System.Windows.Forms.TextBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.btn_busqueda_cliente = New System.Windows.Forms.Button()
        Me.txt_direccion_cliente_factura = New System.Windows.Forms.TextBox()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.txt_email_cliente_factura = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_grupo_cliente_factura = New System.Windows.Forms.TextBox()
        Me.lbl_grupo = New System.Windows.Forms.Label()
        Me.txt_nif_cliente_factura = New System.Windows.Forms.TextBox()
        Me.lbl_nif = New System.Windows.Forms.Label()
        Me.txt_cliente_factura = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.gb_albaranes_factura = New System.Windows.Forms.GroupBox()
        Me.dg_albaranes_factura = New System.Windows.Forms.DataGridView()
        Me.idAlbaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaAlbaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.incluidoAlbaran = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.btn_modificar_factura = New System.Windows.Forms.Button()
        Me.btn_facturar_factura = New System.Windows.Forms.Button()
        Me.btn_guardar_factura = New System.Windows.Forms.Button()
        Me.btn_cancelar_factura = New System.Windows.Forms.Button()
        Me.gb_datos_factura = New System.Windows.Forms.GroupBox()
        Me.txt_banco_factura = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_referencia_factura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_forma_pago_factura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dp_factura = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gb_cliente_factura.SuspendLayout()
        Me.gb_albaranes_factura.SuspendLayout()
        CType(Me.dg_albaranes_factura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 1)
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
        Me.gb_cliente_factura.Controls.Add(Me.txt_telefono_cliente_factura)
        Me.gb_cliente_factura.Controls.Add(Me.lbl_telefono)
        Me.gb_cliente_factura.Controls.Add(Me.btn_busqueda_cliente)
        Me.gb_cliente_factura.Controls.Add(Me.txt_direccion_cliente_factura)
        Me.gb_cliente_factura.Controls.Add(Me.lbl_direccion)
        Me.gb_cliente_factura.Controls.Add(Me.txt_email_cliente_factura)
        Me.gb_cliente_factura.Controls.Add(Me.lbl_email)
        Me.gb_cliente_factura.Controls.Add(Me.txt_grupo_cliente_factura)
        Me.gb_cliente_factura.Controls.Add(Me.lbl_grupo)
        Me.gb_cliente_factura.Controls.Add(Me.txt_nif_cliente_factura)
        Me.gb_cliente_factura.Controls.Add(Me.lbl_nif)
        Me.gb_cliente_factura.Controls.Add(Me.txt_cliente_factura)
        Me.gb_cliente_factura.Controls.Add(Me.lbl_nombre)
        Me.gb_cliente_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_cliente_factura.Location = New System.Drawing.Point(402, 3)
        Me.gb_cliente_factura.Name = "gb_cliente_factura"
        Me.gb_cliente_factura.Size = New System.Drawing.Size(393, 275)
        Me.gb_cliente_factura.TabIndex = 1
        Me.gb_cliente_factura.TabStop = False
        Me.gb_cliente_factura.Text = "Datos del cliente"
        '
        'txt_telefono_cliente_factura
        '
        Me.txt_telefono_cliente_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_telefono_cliente_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono_cliente_factura.Location = New System.Drawing.Point(213, 118)
        Me.txt_telefono_cliente_factura.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.txt_telefono_cliente_factura.Name = "txt_telefono_cliente_factura"
        Me.txt_telefono_cliente_factura.ReadOnly = True
        Me.txt_telefono_cliente_factura.Size = New System.Drawing.Size(162, 20)
        Me.txt_telefono_cliente_factura.TabIndex = 17
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono.Location = New System.Drawing.Point(211, 102)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(57, 13)
        Me.lbl_telefono.TabIndex = 16
        Me.lbl_telefono.Text = "Teléfono"
        '
        'btn_busqueda_cliente
        '
        Me.btn_busqueda_cliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_busqueda_cliente.Image = Global.MP_Lucas_Sanz.My.Resources.Resources.lupa
        Me.btn_busqueda_cliente.Location = New System.Drawing.Point(180, 58)
        Me.btn_busqueda_cliente.Name = "btn_busqueda_cliente"
        Me.btn_busqueda_cliente.Size = New System.Drawing.Size(24, 24)
        Me.btn_busqueda_cliente.TabIndex = 15
        Me.btn_busqueda_cliente.UseVisualStyleBackColor = True
        Me.btn_busqueda_cliente.Visible = False
        '
        'txt_direccion_cliente_factura
        '
        Me.txt_direccion_cliente_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_direccion_cliente_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion_cliente_factura.Location = New System.Drawing.Point(17, 234)
        Me.txt_direccion_cliente_factura.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.txt_direccion_cliente_factura.Name = "txt_direccion_cliente_factura"
        Me.txt_direccion_cliente_factura.ReadOnly = True
        Me.txt_direccion_cliente_factura.Size = New System.Drawing.Size(357, 20)
        Me.txt_direccion_cliente_factura.TabIndex = 14
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion.Location = New System.Drawing.Point(15, 218)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(61, 13)
        Me.lbl_direccion.TabIndex = 13
        Me.lbl_direccion.Text = "Dirección"
        '
        'txt_email_cliente_factura
        '
        Me.txt_email_cliente_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_email_cliente_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email_cliente_factura.Location = New System.Drawing.Point(17, 176)
        Me.txt_email_cliente_factura.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.txt_email_cliente_factura.Name = "txt_email_cliente_factura"
        Me.txt_email_cliente_factura.ReadOnly = True
        Me.txt_email_cliente_factura.Size = New System.Drawing.Size(357, 20)
        Me.txt_email_cliente_factura.TabIndex = 12
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(15, 160)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(37, 13)
        Me.lbl_email.TabIndex = 11
        Me.lbl_email.Text = "Email"
        '
        'txt_grupo_cliente_factura
        '
        Me.txt_grupo_cliente_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_grupo_cliente_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_grupo_cliente_factura.Location = New System.Drawing.Point(18, 118)
        Me.txt_grupo_cliente_factura.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.txt_grupo_cliente_factura.Name = "txt_grupo_cliente_factura"
        Me.txt_grupo_cliente_factura.ReadOnly = True
        Me.txt_grupo_cliente_factura.Size = New System.Drawing.Size(162, 20)
        Me.txt_grupo_cliente_factura.TabIndex = 10
        '
        'lbl_grupo
        '
        Me.lbl_grupo.AutoSize = True
        Me.lbl_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grupo.Location = New System.Drawing.Point(16, 102)
        Me.lbl_grupo.Name = "lbl_grupo"
        Me.lbl_grupo.Size = New System.Drawing.Size(41, 13)
        Me.lbl_grupo.TabIndex = 9
        Me.lbl_grupo.Text = "Grupo"
        '
        'txt_nif_cliente_factura
        '
        Me.txt_nif_cliente_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nif_cliente_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nif_cliente_factura.Location = New System.Drawing.Point(212, 60)
        Me.txt_nif_cliente_factura.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.txt_nif_cliente_factura.Name = "txt_nif_cliente_factura"
        Me.txt_nif_cliente_factura.ReadOnly = True
        Me.txt_nif_cliente_factura.Size = New System.Drawing.Size(162, 20)
        Me.txt_nif_cliente_factura.TabIndex = 6
        '
        'lbl_nif
        '
        Me.lbl_nif.AutoSize = True
        Me.lbl_nif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nif.Location = New System.Drawing.Point(210, 44)
        Me.lbl_nif.Name = "lbl_nif"
        Me.lbl_nif.Size = New System.Drawing.Size(27, 13)
        Me.lbl_nif.TabIndex = 5
        Me.lbl_nif.Text = "NIF"
        '
        'txt_cliente_factura
        '
        Me.txt_cliente_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cliente_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cliente_factura.Location = New System.Drawing.Point(17, 60)
        Me.txt_cliente_factura.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.txt_cliente_factura.Name = "txt_cliente_factura"
        Me.txt_cliente_factura.ReadOnly = True
        Me.txt_cliente_factura.Size = New System.Drawing.Size(162, 20)
        Me.txt_cliente_factura.TabIndex = 4
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(15, 44)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(46, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Cliente"
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_albaranes_factura.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_albaranes_factura.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.fechaAlbaran.DefaultCellStyle = DataGridViewCellStyle1
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(402, 284)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 275)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resumen"
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 14)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(379, 255)
        Me.TableLayoutPanel2.TabIndex = 4
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(363, 60)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'txt_descuento_factura
        '
        Me.txt_descuento_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_descuento_factura.Location = New System.Drawing.Point(281, 34)
        Me.txt_descuento_factura.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.txt_descuento_factura.Name = "txt_descuento_factura"
        Me.txt_descuento_factura.ReadOnly = True
        Me.txt_descuento_factura.Size = New System.Drawing.Size(71, 22)
        Me.txt_descuento_factura.TabIndex = 7
        Me.txt_descuento_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_impuestos_factura
        '
        Me.txt_impuestos_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_impuestos_factura.Location = New System.Drawing.Point(191, 34)
        Me.txt_impuestos_factura.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.txt_impuestos_factura.Name = "txt_impuestos_factura"
        Me.txt_impuestos_factura.ReadOnly = True
        Me.txt_impuestos_factura.Size = New System.Drawing.Size(71, 22)
        Me.txt_impuestos_factura.TabIndex = 6
        Me.txt_impuestos_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_base_imponible_factura
        '
        Me.txt_base_imponible_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_base_imponible_factura.Location = New System.Drawing.Point(101, 34)
        Me.txt_base_imponible_factura.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.txt_base_imponible_factura.Name = "txt_base_imponible_factura"
        Me.txt_base_imponible_factura.ReadOnly = True
        Me.txt_base_imponible_factura.Size = New System.Drawing.Size(71, 22)
        Me.txt_base_imponible_factura.TabIndex = 5
        Me.txt_base_imponible_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Bruto"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(96, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "B.Imponible"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(186, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Impuestos"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(276, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Descuento"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_bruto_factura
        '
        Me.txt_bruto_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_bruto_factura.Location = New System.Drawing.Point(11, 34)
        Me.txt_bruto_factura.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.txt_bruto_factura.Name = "txt_bruto_factura"
        Me.txt_bruto_factura.ReadOnly = True
        Me.txt_bruto_factura.Size = New System.Drawing.Size(71, 22)
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
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(199, 84)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(8)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(172, 60)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'txt_total_factura
        '
        Me.txt_total_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_total_factura.Location = New System.Drawing.Point(11, 34)
        Me.txt_total_factura.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.txt_total_factura.Name = "txt_total_factura"
        Me.txt_total_factura.ReadOnly = True
        Me.txt_total_factura.Size = New System.Drawing.Size(150, 22)
        Me.txt_total_factura.TabIndex = 5
        Me.txt_total_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 9)
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
        Me.TableLayoutPanel5.Controls.Add(Me.btn_modificar_factura, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.btn_facturar_factura, 3, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.btn_guardar_factura, 2, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.btn_cancelar_factura, 0, 1)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 155)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(373, 97)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'btn_modificar_factura
        '
        Me.btn_modificar_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_factura.Location = New System.Drawing.Point(96, 61)
        Me.btn_modificar_factura.Name = "btn_modificar_factura"
        Me.btn_modificar_factura.Size = New System.Drawing.Size(87, 23)
        Me.btn_modificar_factura.TabIndex = 3
        Me.btn_modificar_factura.Text = "MODIFICAR"
        Me.btn_modificar_factura.UseVisualStyleBackColor = True
        Me.btn_modificar_factura.Visible = False
        '
        'btn_facturar_factura
        '
        Me.btn_facturar_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_facturar_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_facturar_factura.Location = New System.Drawing.Point(282, 61)
        Me.btn_facturar_factura.Name = "btn_facturar_factura"
        Me.btn_facturar_factura.Size = New System.Drawing.Size(88, 23)
        Me.btn_facturar_factura.TabIndex = 0
        Me.btn_facturar_factura.Text = "FACTURAR"
        Me.btn_facturar_factura.UseVisualStyleBackColor = True
        '
        'btn_guardar_factura
        '
        Me.btn_guardar_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_factura.Location = New System.Drawing.Point(189, 61)
        Me.btn_guardar_factura.Name = "btn_guardar_factura"
        Me.btn_guardar_factura.Size = New System.Drawing.Size(87, 23)
        Me.btn_guardar_factura.TabIndex = 1
        Me.btn_guardar_factura.Text = "GUARDAR"
        Me.btn_guardar_factura.UseVisualStyleBackColor = True
        '
        'btn_cancelar_factura
        '
        Me.btn_cancelar_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar_factura.Location = New System.Drawing.Point(3, 61)
        Me.btn_cancelar_factura.Name = "btn_cancelar_factura"
        Me.btn_cancelar_factura.Size = New System.Drawing.Size(87, 23)
        Me.btn_cancelar_factura.TabIndex = 2
        Me.btn_cancelar_factura.Text = "CANCELAR"
        Me.btn_cancelar_factura.UseVisualStyleBackColor = True
        '
        'gb_datos_factura
        '
        Me.gb_datos_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_datos_factura.Controls.Add(Me.txt_banco_factura)
        Me.gb_datos_factura.Controls.Add(Me.Label7)
        Me.gb_datos_factura.Controls.Add(Me.txt_referencia_factura)
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
        'txt_banco_factura
        '
        Me.txt_banco_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_banco_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_banco_factura.Location = New System.Drawing.Point(206, 118)
        Me.txt_banco_factura.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.txt_banco_factura.Name = "txt_banco_factura"
        Me.txt_banco_factura.ReadOnly = True
        Me.txt_banco_factura.Size = New System.Drawing.Size(165, 20)
        Me.txt_banco_factura.TabIndex = 10
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
        'txt_referencia_factura
        '
        Me.txt_referencia_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_referencia_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_referencia_factura.Location = New System.Drawing.Point(11, 60)
        Me.txt_referencia_factura.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.txt_referencia_factura.Name = "txt_referencia_factura"
        Me.txt_referencia_factura.ReadOnly = True
        Me.txt_referencia_factura.Size = New System.Drawing.Size(165, 20)
        Me.txt_referencia_factura.TabIndex = 1
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
        Me.txt_forma_pago_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_forma_pago_factura.Location = New System.Drawing.Point(206, 60)
        Me.txt_forma_pago_factura.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.txt_forma_pago_factura.Name = "txt_forma_pago_factura"
        Me.txt_forma_pago_factura.ReadOnly = True
        Me.txt_forma_pago_factura.Size = New System.Drawing.Size(165, 20)
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
        Me.dp_factura.Location = New System.Drawing.Point(11, 118)
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
        Me.Label2.Location = New System.Drawing.Point(8, 102)
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
        Me.GroupBox1.ResumeLayout(False)
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
    Public WithEvents txt_referencia_factura As TextBox
    Public WithEvents Label3 As Label
    Public WithEvents txt_forma_pago_factura As TextBox
    Public WithEvents Label1 As Label
    Friend WithEvents dp_factura As DateTimePicker
    Friend WithEvents Label2 As Label
    Public WithEvents txt_banco_factura As TextBox
    Friend WithEvents Label7 As Label
    Public WithEvents txt_nif_cliente_factura As TextBox
    Friend WithEvents lbl_nif As Label
    Public WithEvents txt_cliente_factura As TextBox
    Friend WithEvents lbl_nombre As Label
    Public WithEvents txt_direccion_cliente_factura As TextBox
    Friend WithEvents lbl_direccion As Label
    Public WithEvents txt_email_cliente_factura As TextBox
    Friend WithEvents lbl_email As Label
    Public WithEvents txt_grupo_cliente_factura As TextBox
    Friend WithEvents lbl_grupo As Label
    Friend WithEvents gb_albaranes_factura As GroupBox
    Public WithEvents dg_albaranes_factura As DataGridView
    Friend WithEvents btn_busqueda_cliente As Button
    Public WithEvents txt_telefono_cliente_factura As TextBox
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents idAlbaran As DataGridViewTextBoxColumn
    Friend WithEvents fechaAlbaran As DataGridViewTextBoxColumn
    Friend WithEvents incluidoAlbaran As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txt_descuento_factura As TextBox
    Friend WithEvents txt_impuestos_factura As TextBox
    Friend WithEvents txt_base_imponible_factura As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_bruto_factura As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txt_total_factura As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btn_facturar_factura As Button
    Friend WithEvents btn_guardar_factura As Button
    Friend WithEvents btn_cancelar_factura As Button
    Friend WithEvents btn_modificar_factura As Button
End Class

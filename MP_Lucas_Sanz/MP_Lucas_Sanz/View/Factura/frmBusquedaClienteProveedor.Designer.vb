<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaClienteProveedor
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dg_busqueda_cliente_proveedor = New System.Windows.Forms.DataGridView()
        Me.idEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.gb_busqueda_entidad = New System.Windows.Forms.GroupBox()
        Me.rdb_busqueda_proveedor = New System.Windows.Forms.RadioButton()
        Me.rdb_busqueda_cliente = New System.Windows.Forms.RadioButton()
        Me.txt_busqueda_entidad = New System.Windows.Forms.TextBox()
        Me.btn_cancelar_busqueda_entidad = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dg_busqueda_cliente_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.gb_busqueda_entidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dg_busqueda_cliente_proveedor, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(484, 221)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dg_busqueda_cliente_proveedor
        '
        Me.dg_busqueda_cliente_proveedor.AllowUserToAddRows = False
        Me.dg_busqueda_cliente_proveedor.AllowUserToDeleteRows = False
        Me.dg_busqueda_cliente_proveedor.AllowUserToResizeRows = False
        Me.dg_busqueda_cliente_proveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_busqueda_cliente_proveedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_busqueda_cliente_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_busqueda_cliente_proveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEntidad, Me.nombreEntidad})
        Me.dg_busqueda_cliente_proveedor.Location = New System.Drawing.Point(3, 3)
        Me.dg_busqueda_cliente_proveedor.MultiSelect = False
        Me.dg_busqueda_cliente_proveedor.Name = "dg_busqueda_cliente_proveedor"
        Me.dg_busqueda_cliente_proveedor.RowHeadersVisible = False
        Me.dg_busqueda_cliente_proveedor.Size = New System.Drawing.Size(308, 215)
        Me.dg_busqueda_cliente_proveedor.TabIndex = 0
        '
        'idEntidad
        '
        Me.idEntidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.idEntidad.HeaderText = "ID"
        Me.idEntidad.Name = "idEntidad"
        Me.idEntidad.ReadOnly = True
        '
        'nombreEntidad
        '
        Me.nombreEntidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombreEntidad.HeaderText = "Nombre"
        Me.nombreEntidad.Name = "nombreEntidad"
        Me.nombreEntidad.ReadOnly = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.gb_busqueda_entidad, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_busqueda_entidad, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_cancelar_busqueda_entidad, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(317, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(164, 215)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'gb_busqueda_entidad
        '
        Me.gb_busqueda_entidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_busqueda_entidad.Controls.Add(Me.rdb_busqueda_proveedor)
        Me.gb_busqueda_entidad.Controls.Add(Me.rdb_busqueda_cliente)
        Me.gb_busqueda_entidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_busqueda_entidad.Location = New System.Drawing.Point(15, 10)
        Me.gb_busqueda_entidad.Margin = New System.Windows.Forms.Padding(15, 10, 15, 10)
        Me.gb_busqueda_entidad.Name = "gb_busqueda_entidad"
        Me.gb_busqueda_entidad.Size = New System.Drawing.Size(134, 87)
        Me.gb_busqueda_entidad.TabIndex = 0
        Me.gb_busqueda_entidad.TabStop = False
        Me.gb_busqueda_entidad.Text = "Tipo entidad"
        '
        'rdb_busqueda_proveedor
        '
        Me.rdb_busqueda_proveedor.AutoSize = True
        Me.rdb_busqueda_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_busqueda_proveedor.Location = New System.Drawing.Point(28, 51)
        Me.rdb_busqueda_proveedor.Name = "rdb_busqueda_proveedor"
        Me.rdb_busqueda_proveedor.Size = New System.Drawing.Size(74, 17)
        Me.rdb_busqueda_proveedor.TabIndex = 1
        Me.rdb_busqueda_proveedor.TabStop = True
        Me.rdb_busqueda_proveedor.Text = "Proveedor"
        Me.rdb_busqueda_proveedor.UseVisualStyleBackColor = True
        '
        'rdb_busqueda_cliente
        '
        Me.rdb_busqueda_cliente.AutoSize = True
        Me.rdb_busqueda_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_busqueda_cliente.Location = New System.Drawing.Point(28, 25)
        Me.rdb_busqueda_cliente.Name = "rdb_busqueda_cliente"
        Me.rdb_busqueda_cliente.Size = New System.Drawing.Size(57, 17)
        Me.rdb_busqueda_cliente.TabIndex = 0
        Me.rdb_busqueda_cliente.TabStop = True
        Me.rdb_busqueda_cliente.Text = "Cliente"
        Me.rdb_busqueda_cliente.UseVisualStyleBackColor = True
        '
        'txt_busqueda_entidad
        '
        Me.txt_busqueda_entidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_busqueda_entidad.Location = New System.Drawing.Point(15, 118)
        Me.txt_busqueda_entidad.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.txt_busqueda_entidad.Name = "txt_busqueda_entidad"
        Me.txt_busqueda_entidad.Size = New System.Drawing.Size(134, 20)
        Me.txt_busqueda_entidad.TabIndex = 1
        '
        'btn_cancelar_busqueda_entidad
        '
        Me.btn_cancelar_busqueda_entidad.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_cancelar_busqueda_entidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar_busqueda_entidad.Location = New System.Drawing.Point(56, 160)
        Me.btn_cancelar_busqueda_entidad.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.btn_cancelar_busqueda_entidad.Name = "btn_cancelar_busqueda_entidad"
        Me.btn_cancelar_busqueda_entidad.Size = New System.Drawing.Size(93, 23)
        Me.btn_cancelar_busqueda_entidad.TabIndex = 2
        Me.btn_cancelar_busqueda_entidad.Text = "CANCELAR"
        Me.btn_cancelar_busqueda_entidad.UseVisualStyleBackColor = True
        '
        'frmBusquedaClienteProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 226)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBusquedaClienteProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBusquedaClienteProveedor"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dg_busqueda_cliente_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.gb_busqueda_entidad.ResumeLayout(False)
        Me.gb_busqueda_entidad.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dg_busqueda_cliente_proveedor As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents gb_busqueda_entidad As GroupBox
    Friend WithEvents rdb_busqueda_proveedor As RadioButton
    Friend WithEvents rdb_busqueda_cliente As RadioButton
    Friend WithEvents txt_busqueda_entidad As TextBox
    Friend WithEvents idEntidad As DataGridViewTextBoxColumn
    Friend WithEvents nombreEntidad As DataGridViewTextBoxColumn
    Friend WithEvents btn_cancelar_busqueda_entidad As Button
End Class

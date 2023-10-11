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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompra))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_proveedor_seleccionado = New System.Windows.Forms.TextBox()
        Me.txt_articulo_seleccionado = New System.Windows.Forms.TextBox()
        Me.txt_cantidad_seleccionada = New System.Windows.Forms.TextBox()
        Me.cb_forma_pago_seleccionada = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_modificar_compra = New System.Windows.Forms.Button()
        Me.btn_eliminar_compra = New System.Windows.Forms.Button()
        Me.btn_añadir_compra = New System.Windows.Forms.Button()
        Me.dg_compras = New System.Windows.Forms.DataGridView()
        Me.btn_confirmar_compra = New System.Windows.Forms.Button()
        Me.btn_busqueda_proveedor = New System.Windows.Forms.Button()
        Me.btn_busqueda_articulo = New System.Windows.Forms.Button()
        Me.CompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorDeCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticuloDeCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaDePagoCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDeArticuloCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDeCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTotalDeCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.dg_compras, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Controls.Add(Me.btn_confirmar_compra, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(720, 394)
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(714, 151)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Artículo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(377, 31)
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
        Me.Label4.Location = New System.Drawing.Point(377, 106)
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
        Me.txt_proveedor_seleccionado.Location = New System.Drawing.Point(78, 27)
        Me.txt_proveedor_seleccionado.Name = "txt_proveedor_seleccionado"
        Me.txt_proveedor_seleccionado.ReadOnly = True
        Me.txt_proveedor_seleccionado.Size = New System.Drawing.Size(262, 20)
        Me.txt_proveedor_seleccionado.TabIndex = 4
        Me.txt_proveedor_seleccionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_articulo_seleccionado
        '
        Me.txt_articulo_seleccionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_articulo_seleccionado.Enabled = False
        Me.txt_articulo_seleccionado.Location = New System.Drawing.Point(78, 103)
        Me.txt_articulo_seleccionado.Name = "txt_articulo_seleccionado"
        Me.txt_articulo_seleccionado.ReadOnly = True
        Me.txt_articulo_seleccionado.Size = New System.Drawing.Size(262, 20)
        Me.txt_articulo_seleccionado.TabIndex = 5
        Me.txt_articulo_seleccionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cantidad_seleccionada
        '
        Me.txt_cantidad_seleccionada.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cantidad_seleccionada.Location = New System.Drawing.Point(479, 103)
        Me.txt_cantidad_seleccionada.Name = "txt_cantidad_seleccionada"
        Me.txt_cantidad_seleccionada.Size = New System.Drawing.Size(232, 20)
        Me.txt_cantidad_seleccionada.TabIndex = 6
        Me.txt_cantidad_seleccionada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cb_forma_pago_seleccionada
        '
        Me.cb_forma_pago_seleccionada.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_forma_pago_seleccionada.FormattingEnabled = True
        Me.cb_forma_pago_seleccionada.Location = New System.Drawing.Point(479, 27)
        Me.cb_forma_pago_seleccionada.Name = "cb_forma_pago_seleccionada"
        Me.cb_forma_pago_seleccionada.Size = New System.Drawing.Size(232, 21)
        Me.cb_forma_pago_seleccionada.TabIndex = 9
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 160)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(714, 33)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'btn_modificar_compra
        '
        Me.btn_modificar_compra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_compra.Location = New System.Drawing.Point(540, 3)
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
        Me.btn_eliminar_compra.Location = New System.Drawing.Point(302, 3)
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
        Me.btn_añadir_compra.Location = New System.Drawing.Point(64, 3)
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
        Me.dg_compras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_compras.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_compras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_compras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProveedorDeCompraDataGridViewTextBoxColumn, Me.ArticuloDeCompraDataGridViewTextBoxColumn, Me.FormaDePagoCompraDataGridViewTextBoxColumn, Me.PrecioDeArticuloCompraDataGridViewTextBoxColumn, Me.CantidadDeCompraDataGridViewTextBoxColumn, Me.PrecioTotalDeCompraDataGridViewTextBoxColumn})
        Me.dg_compras.DataSource = Me.CompraBindingSource
        Me.dg_compras.Location = New System.Drawing.Point(3, 199)
        Me.dg_compras.Name = "dg_compras"
        Me.dg_compras.ReadOnly = True
        Me.dg_compras.Size = New System.Drawing.Size(714, 151)
        Me.dg_compras.TabIndex = 2
        '
        'btn_confirmar_compra
        '
        Me.btn_confirmar_compra.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_confirmar_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar_compra.Location = New System.Drawing.Point(552, 362)
        Me.btn_confirmar_compra.Name = "btn_confirmar_compra"
        Me.btn_confirmar_compra.Size = New System.Drawing.Size(165, 23)
        Me.btn_confirmar_compra.TabIndex = 3
        Me.btn_confirmar_compra.Text = "CONFIRMAR COMPRA"
        Me.btn_confirmar_compra.UseVisualStyleBackColor = True
        '
        'btn_busqueda_proveedor
        '
        Me.btn_busqueda_proveedor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_busqueda_proveedor.Image = Global.MP_Lucas_Sanz.My.Resources.Resources.lupa
        Me.btn_busqueda_proveedor.Location = New System.Drawing.Point(346, 25)
        Me.btn_busqueda_proveedor.Name = "btn_busqueda_proveedor"
        Me.btn_busqueda_proveedor.Size = New System.Drawing.Size(25, 25)
        Me.btn_busqueda_proveedor.TabIndex = 7
        Me.btn_busqueda_proveedor.UseVisualStyleBackColor = True
        '
        'btn_busqueda_articulo
        '
        Me.btn_busqueda_articulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_busqueda_articulo.Image = Global.MP_Lucas_Sanz.My.Resources.Resources.lupa
        Me.btn_busqueda_articulo.Location = New System.Drawing.Point(346, 100)
        Me.btn_busqueda_articulo.Name = "btn_busqueda_articulo"
        Me.btn_busqueda_articulo.Size = New System.Drawing.Size(25, 25)
        Me.btn_busqueda_articulo.TabIndex = 8
        Me.btn_busqueda_articulo.UseVisualStyleBackColor = True
        '
        'CompraBindingSource
        '
        Me.CompraBindingSource.DataSource = GetType(MP_Lucas_Sanz.Compra)
        '
        'ProveedorDeCompraDataGridViewTextBoxColumn
        '
        Me.ProveedorDeCompraDataGridViewTextBoxColumn.DataPropertyName = "ProveedorDeCompra"
        Me.ProveedorDeCompraDataGridViewTextBoxColumn.HeaderText = "ProveedorDeCompra"
        Me.ProveedorDeCompraDataGridViewTextBoxColumn.Name = "ProveedorDeCompraDataGridViewTextBoxColumn"
        Me.ProveedorDeCompraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArticuloDeCompraDataGridViewTextBoxColumn
        '
        Me.ArticuloDeCompraDataGridViewTextBoxColumn.DataPropertyName = "ArticuloDeCompra"
        Me.ArticuloDeCompraDataGridViewTextBoxColumn.HeaderText = "ArticuloDeCompra"
        Me.ArticuloDeCompraDataGridViewTextBoxColumn.Name = "ArticuloDeCompraDataGridViewTextBoxColumn"
        Me.ArticuloDeCompraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormaDePagoCompraDataGridViewTextBoxColumn
        '
        Me.FormaDePagoCompraDataGridViewTextBoxColumn.DataPropertyName = "FormaDePagoCompra"
        Me.FormaDePagoCompraDataGridViewTextBoxColumn.HeaderText = "FormaDePagoCompra"
        Me.FormaDePagoCompraDataGridViewTextBoxColumn.Name = "FormaDePagoCompraDataGridViewTextBoxColumn"
        Me.FormaDePagoCompraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDeArticuloCompraDataGridViewTextBoxColumn
        '
        Me.PrecioDeArticuloCompraDataGridViewTextBoxColumn.DataPropertyName = "PrecioDeArticuloCompra"
        Me.PrecioDeArticuloCompraDataGridViewTextBoxColumn.HeaderText = "PrecioDeArticuloCompra"
        Me.PrecioDeArticuloCompraDataGridViewTextBoxColumn.Name = "PrecioDeArticuloCompraDataGridViewTextBoxColumn"
        Me.PrecioDeArticuloCompraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDeCompraDataGridViewTextBoxColumn
        '
        Me.CantidadDeCompraDataGridViewTextBoxColumn.DataPropertyName = "CantidadDeCompra"
        Me.CantidadDeCompraDataGridViewTextBoxColumn.HeaderText = "CantidadDeCompra"
        Me.CantidadDeCompraDataGridViewTextBoxColumn.Name = "CantidadDeCompraDataGridViewTextBoxColumn"
        Me.CantidadDeCompraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioTotalDeCompraDataGridViewTextBoxColumn
        '
        Me.PrecioTotalDeCompraDataGridViewTextBoxColumn.DataPropertyName = "PrecioTotalDeCompra"
        Me.PrecioTotalDeCompraDataGridViewTextBoxColumn.HeaderText = "PrecioTotalDeCompra"
        Me.PrecioTotalDeCompraDataGridViewTextBoxColumn.Name = "PrecioTotalDeCompraDataGridViewTextBoxColumn"
        Me.PrecioTotalDeCompraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 398)
        Me.Controls.Add(Me.TableLayoutPanel1)
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
    Friend WithEvents btn_confirmar_compra As Button
    Friend WithEvents ProveedorDeCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArticuloDeCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormaDePagoCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDeArticuloCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDeCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioTotalDeCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompraBindingSource As BindingSource
End Class

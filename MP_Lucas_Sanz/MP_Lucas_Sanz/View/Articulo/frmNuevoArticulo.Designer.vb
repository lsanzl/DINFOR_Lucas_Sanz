<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoArticulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoArticulo))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_descripcion_articulo = New System.Windows.Forms.TextBox()
        Me.lbl_codigo_articulo = New System.Windows.Forms.Label()
        Me.lbl_descripcion_articulo = New System.Windows.Forms.Label()
        Me.lbl_nombre_articulo = New System.Windows.Forms.Label()
        Me.lbl_precio_compra_articulo = New System.Windows.Forms.Label()
        Me.lbl_unidad_articulo = New System.Windows.Forms.Label()
        Me.lbl_porcentaje_articulo = New System.Windows.Forms.Label()
        Me.lbl_precio_venta_articulo = New System.Windows.Forms.Label()
        Me.txt_codigo_articulo = New System.Windows.Forms.TextBox()
        Me.txt_nombre_articulo = New System.Windows.Forms.TextBox()
        Me.txt_pvp_compra_articulo = New System.Windows.Forms.TextBox()
        Me.txt_porc_beneficio_articulo = New System.Windows.Forms.TextBox()
        Me.txt_pvp_venta_articulo = New System.Windows.Forms.TextBox()
        Me.txt_familia_articulo = New System.Windows.Forms.TextBox()
        Me.cb_tipo_unidad_articulo = New System.Windows.Forms.ComboBox()
        Me.btn_familias_articulos = New System.Windows.Forms.Button()
        Me.btn_confirmar_articulo = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_descripcion_articulo, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_codigo_articulo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_descripcion_articulo, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_nombre_articulo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_precio_compra_articulo, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_unidad_articulo, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_porcentaje_articulo, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_precio_venta_articulo, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_codigo_articulo, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_nombre_articulo, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_pvp_compra_articulo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_porc_beneficio_articulo, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_pvp_venta_articulo, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_familia_articulo, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_tipo_unidad_articulo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_familias_articulos, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_confirmar_articulo, 5, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(776, 195)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txt_descripcion_articulo
        '
        Me.txt_descripcion_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.txt_descripcion_articulo, 3)
        Me.txt_descripcion_articulo.Location = New System.Drawing.Point(390, 3)
        Me.txt_descripcion_articulo.Multiline = True
        Me.txt_descripcion_articulo.Name = "txt_descripcion_articulo"
        Me.TableLayoutPanel1.SetRowSpan(Me.txt_descripcion_articulo, 2)
        Me.txt_descripcion_articulo.Size = New System.Drawing.Size(383, 89)
        Me.txt_descripcion_articulo.TabIndex = 10
        '
        'lbl_codigo_articulo
        '
        Me.lbl_codigo_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_codigo_articulo.AutoSize = True
        Me.lbl_codigo_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo_articulo.Location = New System.Drawing.Point(3, 17)
        Me.lbl_codigo_articulo.Name = "lbl_codigo_articulo"
        Me.lbl_codigo_articulo.Size = New System.Drawing.Size(123, 13)
        Me.lbl_codigo_articulo.TabIndex = 0
        Me.lbl_codigo_articulo.Text = "Código:"
        Me.lbl_codigo_articulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_descripcion_articulo
        '
        Me.lbl_descripcion_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_descripcion_articulo.AutoSize = True
        Me.lbl_descripcion_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcion_articulo.Location = New System.Drawing.Point(261, 17)
        Me.lbl_descripcion_articulo.Name = "lbl_descripcion_articulo"
        Me.lbl_descripcion_articulo.Size = New System.Drawing.Size(123, 13)
        Me.lbl_descripcion_articulo.TabIndex = 1
        Me.lbl_descripcion_articulo.Text = "Descripción:"
        Me.lbl_descripcion_articulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_nombre_articulo
        '
        Me.lbl_nombre_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nombre_articulo.AutoSize = True
        Me.lbl_nombre_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_articulo.Location = New System.Drawing.Point(3, 65)
        Me.lbl_nombre_articulo.Name = "lbl_nombre_articulo"
        Me.lbl_nombre_articulo.Size = New System.Drawing.Size(123, 13)
        Me.lbl_nombre_articulo.TabIndex = 2
        Me.lbl_nombre_articulo.Text = "Nombre:"
        Me.lbl_nombre_articulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_precio_compra_articulo
        '
        Me.lbl_precio_compra_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_precio_compra_articulo.AutoSize = True
        Me.lbl_precio_compra_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio_compra_articulo.Location = New System.Drawing.Point(3, 113)
        Me.lbl_precio_compra_articulo.Name = "lbl_precio_compra_articulo"
        Me.lbl_precio_compra_articulo.Size = New System.Drawing.Size(123, 13)
        Me.lbl_precio_compra_articulo.TabIndex = 3
        Me.lbl_precio_compra_articulo.Text = "PVP Compra:"
        Me.lbl_precio_compra_articulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_unidad_articulo
        '
        Me.lbl_unidad_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_unidad_articulo.AutoSize = True
        Me.lbl_unidad_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unidad_articulo.Location = New System.Drawing.Point(3, 163)
        Me.lbl_unidad_articulo.Name = "lbl_unidad_articulo"
        Me.lbl_unidad_articulo.Size = New System.Drawing.Size(123, 13)
        Me.lbl_unidad_articulo.TabIndex = 4
        Me.lbl_unidad_articulo.Text = "Unidad:"
        Me.lbl_unidad_articulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_porcentaje_articulo
        '
        Me.lbl_porcentaje_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_porcentaje_articulo.AutoSize = True
        Me.lbl_porcentaje_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_porcentaje_articulo.Location = New System.Drawing.Point(261, 113)
        Me.lbl_porcentaje_articulo.Name = "lbl_porcentaje_articulo"
        Me.lbl_porcentaje_articulo.Size = New System.Drawing.Size(123, 13)
        Me.lbl_porcentaje_articulo.TabIndex = 5
        Me.lbl_porcentaje_articulo.Text = "% Beneficio:"
        Me.lbl_porcentaje_articulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_precio_venta_articulo
        '
        Me.lbl_precio_venta_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_precio_venta_articulo.AutoSize = True
        Me.lbl_precio_venta_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio_venta_articulo.Location = New System.Drawing.Point(519, 113)
        Me.lbl_precio_venta_articulo.Name = "lbl_precio_venta_articulo"
        Me.lbl_precio_venta_articulo.Size = New System.Drawing.Size(123, 13)
        Me.lbl_precio_venta_articulo.TabIndex = 7
        Me.lbl_precio_venta_articulo.Text = "PVP Venta:"
        Me.lbl_precio_venta_articulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_codigo_articulo
        '
        Me.txt_codigo_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_codigo_articulo.Location = New System.Drawing.Point(132, 14)
        Me.txt_codigo_articulo.Name = "txt_codigo_articulo"
        Me.txt_codigo_articulo.Size = New System.Drawing.Size(123, 20)
        Me.txt_codigo_articulo.TabIndex = 8
        '
        'txt_nombre_articulo
        '
        Me.txt_nombre_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre_articulo.Location = New System.Drawing.Point(132, 62)
        Me.txt_nombre_articulo.Name = "txt_nombre_articulo"
        Me.txt_nombre_articulo.Size = New System.Drawing.Size(123, 20)
        Me.txt_nombre_articulo.TabIndex = 9
        '
        'txt_pvp_compra_articulo
        '
        Me.txt_pvp_compra_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_pvp_compra_articulo.Location = New System.Drawing.Point(132, 110)
        Me.txt_pvp_compra_articulo.Name = "txt_pvp_compra_articulo"
        Me.txt_pvp_compra_articulo.Size = New System.Drawing.Size(123, 20)
        Me.txt_pvp_compra_articulo.TabIndex = 11
        '
        'txt_porc_beneficio_articulo
        '
        Me.txt_porc_beneficio_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_porc_beneficio_articulo.Location = New System.Drawing.Point(390, 110)
        Me.txt_porc_beneficio_articulo.Name = "txt_porc_beneficio_articulo"
        Me.txt_porc_beneficio_articulo.Size = New System.Drawing.Size(123, 20)
        Me.txt_porc_beneficio_articulo.TabIndex = 12
        '
        'txt_pvp_venta_articulo
        '
        Me.txt_pvp_venta_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_pvp_venta_articulo.Location = New System.Drawing.Point(648, 110)
        Me.txt_pvp_venta_articulo.Name = "txt_pvp_venta_articulo"
        Me.txt_pvp_venta_articulo.ReadOnly = True
        Me.txt_pvp_venta_articulo.Size = New System.Drawing.Size(125, 20)
        Me.txt_pvp_venta_articulo.TabIndex = 13
        '
        'txt_familia_articulo
        '
        Me.txt_familia_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_familia_articulo.Location = New System.Drawing.Point(390, 159)
        Me.txt_familia_articulo.Name = "txt_familia_articulo"
        Me.txt_familia_articulo.ReadOnly = True
        Me.txt_familia_articulo.Size = New System.Drawing.Size(123, 20)
        Me.txt_familia_articulo.TabIndex = 14
        '
        'cb_tipo_unidad_articulo
        '
        Me.cb_tipo_unidad_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_tipo_unidad_articulo.FormattingEnabled = True
        Me.cb_tipo_unidad_articulo.Location = New System.Drawing.Point(132, 159)
        Me.cb_tipo_unidad_articulo.Name = "cb_tipo_unidad_articulo"
        Me.cb_tipo_unidad_articulo.Size = New System.Drawing.Size(123, 21)
        Me.cb_tipo_unidad_articulo.TabIndex = 15
        '
        'btn_familias_articulos
        '
        Me.btn_familias_articulos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_familias_articulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_familias_articulos.Location = New System.Drawing.Point(261, 158)
        Me.btn_familias_articulos.Name = "btn_familias_articulos"
        Me.btn_familias_articulos.Size = New System.Drawing.Size(123, 23)
        Me.btn_familias_articulos.TabIndex = 16
        Me.btn_familias_articulos.Text = "Familia"
        Me.btn_familias_articulos.UseVisualStyleBackColor = True
        '
        'btn_confirmar_articulo
        '
        Me.btn_confirmar_articulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_confirmar_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar_articulo.Location = New System.Drawing.Point(648, 158)
        Me.btn_confirmar_articulo.Name = "btn_confirmar_articulo"
        Me.btn_confirmar_articulo.Size = New System.Drawing.Size(125, 23)
        Me.btn_confirmar_articulo.TabIndex = 17
        Me.btn_confirmar_articulo.Text = "Confirmar"
        Me.btn_confirmar_articulo.UseVisualStyleBackColor = True
        '
        'frmNuevoArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 219)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevoArticulo"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmNuevoArticulo"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_codigo_articulo As Label
    Friend WithEvents lbl_descripcion_articulo As Label
    Friend WithEvents lbl_nombre_articulo As Label
    Friend WithEvents lbl_precio_compra_articulo As Label
    Friend WithEvents lbl_unidad_articulo As Label
    Friend WithEvents lbl_porcentaje_articulo As Label
    Friend WithEvents lbl_precio_venta_articulo As Label
    Friend WithEvents txt_descripcion_articulo As TextBox
    Friend WithEvents txt_codigo_articulo As TextBox
    Friend WithEvents txt_nombre_articulo As TextBox
    Friend WithEvents txt_pvp_compra_articulo As TextBox
    Friend WithEvents txt_porc_beneficio_articulo As TextBox
    Friend WithEvents txt_pvp_venta_articulo As TextBox
    Friend WithEvents txt_familia_articulo As TextBox
    Friend WithEvents cb_tipo_unidad_articulo As ComboBox
    Friend WithEvents btn_familias_articulos As Button
    Friend WithEvents btn_confirmar_articulo As Button
End Class

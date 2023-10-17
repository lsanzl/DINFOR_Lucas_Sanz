<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusquedaVenta))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dg_resultados_busqueda_ventas = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb_criterio_busqueda_ventas = New System.Windows.Forms.GroupBox()
        Me.rdb_nombre = New System.Windows.Forms.RadioButton()
        Me.rdb_codigo = New System.Windows.Forms.RadioButton()
        Me.txt_busqueda_generica_ventas = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dg_resultados_busqueda_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.gb_criterio_busqueda_ventas.SuspendLayout()
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
        Me.TableLayoutPanel1.Controls.Add(Me.dg_resultados_busqueda_ventas, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(460, 222)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'dg_resultados_busqueda_ventas
        '
        Me.dg_resultados_busqueda_ventas.AllowUserToAddRows = False
        Me.dg_resultados_busqueda_ventas.AllowUserToDeleteRows = False
        Me.dg_resultados_busqueda_ventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_resultados_busqueda_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_resultados_busqueda_ventas.Location = New System.Drawing.Point(3, 3)
        Me.dg_resultados_busqueda_ventas.Name = "dg_resultados_busqueda_ventas"
        Me.dg_resultados_busqueda_ventas.ReadOnly = True
        Me.dg_resultados_busqueda_ventas.Size = New System.Drawing.Size(293, 216)
        Me.dg_resultados_busqueda_ventas.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.gb_criterio_busqueda_ventas, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_busqueda_generica_ventas, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(302, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(155, 216)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BÚSQUEDA:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_criterio_busqueda_ventas
        '
        Me.gb_criterio_busqueda_ventas.Controls.Add(Me.rdb_nombre)
        Me.gb_criterio_busqueda_ventas.Controls.Add(Me.rdb_codigo)
        Me.gb_criterio_busqueda_ventas.Location = New System.Drawing.Point(3, 35)
        Me.gb_criterio_busqueda_ventas.Name = "gb_criterio_busqueda_ventas"
        Me.gb_criterio_busqueda_ventas.Size = New System.Drawing.Size(149, 80)
        Me.gb_criterio_busqueda_ventas.TabIndex = 4
        Me.gb_criterio_busqueda_ventas.TabStop = False
        Me.gb_criterio_busqueda_ventas.Text = "Criterio búsqueda"
        '
        'rdb_nombre
        '
        Me.rdb_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdb_nombre.AutoSize = True
        Me.rdb_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_nombre.Location = New System.Drawing.Point(6, 18)
        Me.rdb_nombre.Name = "rdb_nombre"
        Me.rdb_nombre.Size = New System.Drawing.Size(68, 17)
        Me.rdb_nombre.TabIndex = 2
        Me.rdb_nombre.TabStop = True
        Me.rdb_nombre.Text = "Nombre"
        Me.rdb_nombre.UseVisualStyleBackColor = True
        '
        'rdb_codigo
        '
        Me.rdb_codigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdb_codigo.AutoSize = True
        Me.rdb_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_codigo.Location = New System.Drawing.Point(6, 41)
        Me.rdb_codigo.Name = "rdb_codigo"
        Me.rdb_codigo.Size = New System.Drawing.Size(64, 17)
        Me.rdb_codigo.TabIndex = 3
        Me.rdb_codigo.TabStop = True
        Me.rdb_codigo.Text = "Código"
        Me.rdb_codigo.UseVisualStyleBackColor = True
        '
        'txt_busqueda_generica_ventas
        '
        Me.txt_busqueda_generica_ventas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_busqueda_generica_ventas.Location = New System.Drawing.Point(3, 124)
        Me.txt_busqueda_generica_ventas.Name = "txt_busqueda_generica_ventas"
        Me.txt_busqueda_generica_ventas.Size = New System.Drawing.Size(149, 20)
        Me.txt_busqueda_generica_ventas.TabIndex = 1
        Me.txt_busqueda_generica_ventas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmBusquedaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 246)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBusquedaVenta"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Búsqueda"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dg_resultados_busqueda_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.gb_criterio_busqueda_ventas.ResumeLayout(False)
        Me.gb_criterio_busqueda_ventas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dg_resultados_busqueda_ventas As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents gb_criterio_busqueda_ventas As GroupBox
    Friend WithEvents rdb_nombre As RadioButton
    Friend WithEvents rdb_codigo As RadioButton
    Friend WithEvents txt_busqueda_generica_ventas As TextBox
End Class

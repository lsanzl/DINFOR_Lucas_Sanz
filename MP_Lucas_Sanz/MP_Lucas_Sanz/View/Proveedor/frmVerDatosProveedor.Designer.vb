<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerDatosProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerDatosProveedor))
        Me.tlp_nuevo_proveedor = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_telefono_proveedor = New System.Windows.Forms.TextBox()
        Me.txt_poblacion_proveedor = New System.Windows.Forms.TextBox()
        Me.txt_direccion_proveedor = New System.Windows.Forms.TextBox()
        Me.lbl_codigo_proveedor = New System.Windows.Forms.Label()
        Me.lbl_telefono_proveedor = New System.Windows.Forms.Label()
        Me.lbl_poblacion_proveedor = New System.Windows.Forms.Label()
        Me.lbl_nif_proveedor = New System.Windows.Forms.Label()
        Me.lbl_direccion_proveedor = New System.Windows.Forms.Label()
        Me.lbl_nombre_proveedor = New System.Windows.Forms.Label()
        Me.txt_codigo_proveedor = New System.Windows.Forms.TextBox()
        Me.txt_nombre_proveedor = New System.Windows.Forms.TextBox()
        Me.txt_nif_proveedor = New System.Windows.Forms.TextBox()
        Me.btn_modificar_proveedor = New System.Windows.Forms.Button()
        Me.tlp_nuevo_proveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp_nuevo_proveedor
        '
        Me.tlp_nuevo_proveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlp_nuevo_proveedor.ColumnCount = 4
        Me.tlp_nuevo_proveedor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp_nuevo_proveedor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_nuevo_proveedor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp_nuevo_proveedor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_nuevo_proveedor.Controls.Add(Me.txt_telefono_proveedor, 3, 2)
        Me.tlp_nuevo_proveedor.Controls.Add(Me.txt_poblacion_proveedor, 3, 1)
        Me.tlp_nuevo_proveedor.Controls.Add(Me.txt_direccion_proveedor, 3, 0)
        Me.tlp_nuevo_proveedor.Controls.Add(Me.lbl_codigo_proveedor, 0, 0)
        Me.tlp_nuevo_proveedor.Controls.Add(Me.lbl_telefono_proveedor, 2, 2)
        Me.tlp_nuevo_proveedor.Controls.Add(Me.lbl_poblacion_proveedor, 2, 1)
        Me.tlp_nuevo_proveedor.Controls.Add(Me.lbl_nif_proveedor, 0, 2)
        Me.tlp_nuevo_proveedor.Controls.Add(Me.lbl_direccion_proveedor, 2, 0)
        Me.tlp_nuevo_proveedor.Controls.Add(Me.lbl_nombre_proveedor, 0, 1)
        Me.tlp_nuevo_proveedor.Controls.Add(Me.txt_codigo_proveedor, 1, 0)
        Me.tlp_nuevo_proveedor.Controls.Add(Me.txt_nombre_proveedor, 1, 1)
        Me.tlp_nuevo_proveedor.Controls.Add(Me.txt_nif_proveedor, 1, 2)
        Me.tlp_nuevo_proveedor.Controls.Add(Me.btn_modificar_proveedor, 3, 3)
        Me.tlp_nuevo_proveedor.Location = New System.Drawing.Point(12, 12)
        Me.tlp_nuevo_proveedor.Name = "tlp_nuevo_proveedor"
        Me.tlp_nuevo_proveedor.RowCount = 4
        Me.tlp_nuevo_proveedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_nuevo_proveedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_nuevo_proveedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_nuevo_proveedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_nuevo_proveedor.Size = New System.Drawing.Size(776, 145)
        Me.tlp_nuevo_proveedor.TabIndex = 1
        '
        'txt_telefono_proveedor
        '
        Me.txt_telefono_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_telefono_proveedor.Location = New System.Drawing.Point(457, 80)
        Me.txt_telefono_proveedor.Name = "txt_telefono_proveedor"
        Me.txt_telefono_proveedor.Size = New System.Drawing.Size(316, 20)
        Me.txt_telefono_proveedor.TabIndex = 11
        '
        'txt_poblacion_proveedor
        '
        Me.txt_poblacion_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_poblacion_proveedor.Location = New System.Drawing.Point(457, 44)
        Me.txt_poblacion_proveedor.Name = "txt_poblacion_proveedor"
        Me.txt_poblacion_proveedor.Size = New System.Drawing.Size(316, 20)
        Me.txt_poblacion_proveedor.TabIndex = 10
        '
        'txt_direccion_proveedor
        '
        Me.txt_direccion_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_direccion_proveedor.Location = New System.Drawing.Point(457, 8)
        Me.txt_direccion_proveedor.Name = "txt_direccion_proveedor"
        Me.txt_direccion_proveedor.Size = New System.Drawing.Size(316, 20)
        Me.txt_direccion_proveedor.TabIndex = 9
        '
        'lbl_codigo_proveedor
        '
        Me.lbl_codigo_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_codigo_proveedor.AutoSize = True
        Me.lbl_codigo_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo_proveedor.Location = New System.Drawing.Point(3, 11)
        Me.lbl_codigo_proveedor.Name = "lbl_codigo_proveedor"
        Me.lbl_codigo_proveedor.Size = New System.Drawing.Size(54, 13)
        Me.lbl_codigo_proveedor.TabIndex = 0
        Me.lbl_codigo_proveedor.Text = "Código:"
        Me.lbl_codigo_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_telefono_proveedor
        '
        Me.lbl_telefono_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_telefono_proveedor.AutoSize = True
        Me.lbl_telefono_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono_proveedor.Location = New System.Drawing.Point(384, 83)
        Me.lbl_telefono_proveedor.Name = "lbl_telefono_proveedor"
        Me.lbl_telefono_proveedor.Size = New System.Drawing.Size(67, 13)
        Me.lbl_telefono_proveedor.TabIndex = 5
        Me.lbl_telefono_proveedor.Text = "Teléfono:"
        Me.lbl_telefono_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_poblacion_proveedor
        '
        Me.lbl_poblacion_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_poblacion_proveedor.AutoSize = True
        Me.lbl_poblacion_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_poblacion_proveedor.Location = New System.Drawing.Point(384, 47)
        Me.lbl_poblacion_proveedor.Name = "lbl_poblacion_proveedor"
        Me.lbl_poblacion_proveedor.Size = New System.Drawing.Size(67, 13)
        Me.lbl_poblacion_proveedor.TabIndex = 4
        Me.lbl_poblacion_proveedor.Text = "Población:"
        Me.lbl_poblacion_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_nif_proveedor
        '
        Me.lbl_nif_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nif_proveedor.AutoSize = True
        Me.lbl_nif_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nif_proveedor.Location = New System.Drawing.Point(3, 83)
        Me.lbl_nif_proveedor.Name = "lbl_nif_proveedor"
        Me.lbl_nif_proveedor.Size = New System.Drawing.Size(54, 13)
        Me.lbl_nif_proveedor.TabIndex = 2
        Me.lbl_nif_proveedor.Text = "NIF:"
        Me.lbl_nif_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_direccion_proveedor
        '
        Me.lbl_direccion_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_direccion_proveedor.AutoSize = True
        Me.lbl_direccion_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion_proveedor.Location = New System.Drawing.Point(384, 11)
        Me.lbl_direccion_proveedor.Name = "lbl_direccion_proveedor"
        Me.lbl_direccion_proveedor.Size = New System.Drawing.Size(67, 13)
        Me.lbl_direccion_proveedor.TabIndex = 3
        Me.lbl_direccion_proveedor.Text = "Dirección:"
        Me.lbl_direccion_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_nombre_proveedor
        '
        Me.lbl_nombre_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nombre_proveedor.AutoSize = True
        Me.lbl_nombre_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_proveedor.Location = New System.Drawing.Point(3, 47)
        Me.lbl_nombre_proveedor.Name = "lbl_nombre_proveedor"
        Me.lbl_nombre_proveedor.Size = New System.Drawing.Size(54, 13)
        Me.lbl_nombre_proveedor.TabIndex = 1
        Me.lbl_nombre_proveedor.Text = "Nombre:"
        Me.lbl_nombre_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_codigo_proveedor
        '
        Me.txt_codigo_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_codigo_proveedor.Location = New System.Drawing.Point(63, 8)
        Me.txt_codigo_proveedor.Name = "txt_codigo_proveedor"
        Me.txt_codigo_proveedor.Size = New System.Drawing.Size(315, 20)
        Me.txt_codigo_proveedor.TabIndex = 6
        '
        'txt_nombre_proveedor
        '
        Me.txt_nombre_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre_proveedor.Location = New System.Drawing.Point(63, 44)
        Me.txt_nombre_proveedor.Name = "txt_nombre_proveedor"
        Me.txt_nombre_proveedor.Size = New System.Drawing.Size(315, 20)
        Me.txt_nombre_proveedor.TabIndex = 7
        '
        'txt_nif_proveedor
        '
        Me.txt_nif_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nif_proveedor.Location = New System.Drawing.Point(63, 80)
        Me.txt_nif_proveedor.Name = "txt_nif_proveedor"
        Me.txt_nif_proveedor.Size = New System.Drawing.Size(315, 20)
        Me.txt_nif_proveedor.TabIndex = 8
        '
        'btn_modificar_proveedor
        '
        Me.btn_modificar_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar_proveedor.Location = New System.Drawing.Point(698, 119)
        Me.btn_modificar_proveedor.Name = "btn_modificar_proveedor"
        Me.btn_modificar_proveedor.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificar_proveedor.TabIndex = 12
        Me.btn_modificar_proveedor.Text = "Modificar"
        Me.btn_modificar_proveedor.UseVisualStyleBackColor = True
        '
        'frmVerDatosProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 167)
        Me.Controls.Add(Me.tlp_nuevo_proveedor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVerDatosProveedor"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmVerDatosProveedor"
        Me.tlp_nuevo_proveedor.ResumeLayout(False)
        Me.tlp_nuevo_proveedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_nuevo_proveedor As TableLayoutPanel
    Friend WithEvents txt_telefono_proveedor As TextBox
    Friend WithEvents txt_poblacion_proveedor As TextBox
    Friend WithEvents txt_direccion_proveedor As TextBox
    Friend WithEvents lbl_codigo_proveedor As Label
    Friend WithEvents lbl_telefono_proveedor As Label
    Friend WithEvents lbl_poblacion_proveedor As Label
    Friend WithEvents lbl_nif_proveedor As Label
    Friend WithEvents lbl_direccion_proveedor As Label
    Friend WithEvents lbl_nombre_proveedor As Label
    Friend WithEvents txt_codigo_proveedor As TextBox
    Friend WithEvents txt_nombre_proveedor As TextBox
    Friend WithEvents txt_nif_proveedor As TextBox
    Friend WithEvents btn_modificar_proveedor As Button
End Class

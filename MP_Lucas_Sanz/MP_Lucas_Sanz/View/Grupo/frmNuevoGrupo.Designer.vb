<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoGrupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoGrupo))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_codigo_grupo = New System.Windows.Forms.Label()
        Me.lbl_nombre_grupo = New System.Windows.Forms.Label()
        Me.txt_codigo_grupo = New System.Windows.Forms.TextBox()
        Me.txt_nombre_grupo = New System.Windows.Forms.TextBox()
        Me.btn_confirmar_nuevo_grupo = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_codigo_grupo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_nombre_grupo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_codigo_grupo, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_nombre_grupo, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(423, 85)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'lbl_codigo_grupo
        '
        Me.lbl_codigo_grupo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_codigo_grupo.AutoSize = True
        Me.lbl_codigo_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo_grupo.Location = New System.Drawing.Point(3, 0)
        Me.lbl_codigo_grupo.Name = "lbl_codigo_grupo"
        Me.lbl_codigo_grupo.Size = New System.Drawing.Size(142, 42)
        Me.lbl_codigo_grupo.TabIndex = 0
        Me.lbl_codigo_grupo.Text = "Código del Grupo:"
        Me.lbl_codigo_grupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_nombre_grupo
        '
        Me.lbl_nombre_grupo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nombre_grupo.AutoSize = True
        Me.lbl_nombre_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_grupo.Location = New System.Drawing.Point(3, 42)
        Me.lbl_nombre_grupo.Name = "lbl_nombre_grupo"
        Me.lbl_nombre_grupo.Size = New System.Drawing.Size(142, 43)
        Me.lbl_nombre_grupo.TabIndex = 1
        Me.lbl_nombre_grupo.Text = "Nombre del Grupo:"
        Me.lbl_nombre_grupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_codigo_grupo
        '
        Me.txt_codigo_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_codigo_grupo.Location = New System.Drawing.Point(151, 11)
        Me.txt_codigo_grupo.Name = "txt_codigo_grupo"
        Me.txt_codigo_grupo.Size = New System.Drawing.Size(269, 20)
        Me.txt_codigo_grupo.TabIndex = 2
        '
        'txt_nombre_grupo
        '
        Me.txt_nombre_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre_grupo.Location = New System.Drawing.Point(151, 53)
        Me.txt_nombre_grupo.Name = "txt_nombre_grupo"
        Me.txt_nombre_grupo.Size = New System.Drawing.Size(269, 20)
        Me.txt_nombre_grupo.TabIndex = 3
        '
        'btn_confirmar_nuevo_grupo
        '
        Me.btn_confirmar_nuevo_grupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_confirmar_nuevo_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar_nuevo_grupo.Location = New System.Drawing.Point(360, 103)
        Me.btn_confirmar_nuevo_grupo.Name = "btn_confirmar_nuevo_grupo"
        Me.btn_confirmar_nuevo_grupo.Size = New System.Drawing.Size(75, 23)
        Me.btn_confirmar_nuevo_grupo.TabIndex = 3
        Me.btn_confirmar_nuevo_grupo.Text = "Confirmar"
        Me.btn_confirmar_nuevo_grupo.UseVisualStyleBackColor = True
        '
        'frmNuevoGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 138)
        Me.Controls.Add(Me.btn_confirmar_nuevo_grupo)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevoGrupo"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmNuevoGrupo"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_codigo_grupo As Label
    Friend WithEvents lbl_nombre_grupo As Label
    Friend WithEvents txt_codigo_grupo As TextBox
    Friend WithEvents txt_nombre_grupo As TextBox
    Friend WithEvents btn_confirmar_nuevo_grupo As Button
End Class

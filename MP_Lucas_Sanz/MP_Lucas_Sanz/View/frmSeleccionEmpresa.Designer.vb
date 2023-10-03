<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionEmpresa
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
        Me.dg_empresas = New System.Windows.Forms.DataGridView()
        Me.nombreEmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoEmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dg_empresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_empresas
        '
        Me.dg_empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_empresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombreEmp, Me.codigoEmp})
        Me.dg_empresas.Location = New System.Drawing.Point(0, 0)
        Me.dg_empresas.Name = "dg_empresas"
        Me.dg_empresas.Size = New System.Drawing.Size(801, 404)
        Me.dg_empresas.TabIndex = 0
        '
        'nombreEmp
        '
        Me.nombreEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombreEmp.HeaderText = "Nombre Empresa"
        Me.nombreEmp.Name = "nombreEmp"
        Me.nombreEmp.ReadOnly = True
        '
        'codigoEmp
        '
        Me.codigoEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.codigoEmp.HeaderText = "Código Empresa"
        Me.codigoEmp.Name = "codigoEmp"
        Me.codigoEmp.ReadOnly = True
        '
        'frmSeleccionEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dg_empresas)
        Me.Name = "frmSeleccionEmpresa"
        Me.Text = "frmSeleccionEmpresa"
        CType(Me.dg_empresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dg_empresas As DataGridView
    Friend WithEvents nombreEmp As DataGridViewTextBoxColumn
    Friend WithEvents codigoEmp As DataGridViewTextBoxColumn
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelTipoDoc
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelTipoDoc))
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmditems = New System.Windows.Forms.Button
        Me.lbtipo = New System.Windows.Forms.Label
        Me.gitems = New System.Windows.Forms.DataGridView
        Me.buscar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupPanel1.SuspendLayout()
        CType(Me.gitems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cmditems)
        Me.GroupPanel1.Location = New System.Drawing.Point(4, 401)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(561, 85)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 75
        '
        'cmditems
        '
        Me.cmditems.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmditems.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmditems.ForeColor = System.Drawing.Color.Transparent
        Me.cmditems.Image = Global.SAE.My.Resources.Resources.seleecionar
        Me.cmditems.Location = New System.Drawing.Point(238, 7)
        Me.cmditems.Name = "cmditems"
        Me.cmditems.Size = New System.Drawing.Size(72, 68)
        Me.cmditems.TabIndex = 67
        Me.cmditems.Text = "&S"
        Me.cmditems.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.cmditems, "seleccionar vendedor  Alt+S")
        Me.cmditems.UseVisualStyleBackColor = False
        '
        'lbtipo
        '
        Me.lbtipo.AutoSize = True
        Me.lbtipo.ForeColor = System.Drawing.Color.Transparent
        Me.lbtipo.Location = New System.Drawing.Point(67, 338)
        Me.lbtipo.Name = "lbtipo"
        Me.lbtipo.Size = New System.Drawing.Size(13, 13)
        Me.lbtipo.TabIndex = 68
        Me.lbtipo.Text = "1"
        Me.lbtipo.Visible = False
        '
        'gitems
        '
        Me.gitems.AllowUserToAddRows = False
        Me.gitems.AllowUserToDeleteRows = False
        Me.gitems.AllowUserToResizeColumns = False
        Me.gitems.AllowUserToResizeRows = False
        Me.gitems.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gitems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.gitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gitems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.buscar, Me.nombre, Me.nit})
        Me.gitems.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gitems.Location = New System.Drawing.Point(4, 4)
        Me.gitems.MultiSelect = False
        Me.gitems.Name = "gitems"
        Me.gitems.RowHeadersVisible = False
        Me.gitems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gitems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gitems.Size = New System.Drawing.Size(561, 394)
        Me.gitems.StandardTab = True
        Me.gitems.TabIndex = 74
        '
        'buscar
        '
        Me.buscar.Frozen = True
        Me.buscar.HeaderText = "TIPO"
        Me.buscar.MinimumWidth = 100
        Me.buscar.Name = "buscar"
        Me.buscar.ReadOnly = True
        Me.buscar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.buscar.ToolTipText = "buscar por apellidos"
        '
        'nombre
        '
        Me.nombre.HeaderText = "GRUPO"
        Me.nombre.MaxInputLength = 300
        Me.nombre.MinimumWidth = 100
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'nit
        '
        Me.nit.HeaderText = "DESCRIPCION"
        Me.nit.MinimumWidth = 330
        Me.nit.Name = "nit"
        Me.nit.ReadOnly = True
        Me.nit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.nit.Width = 330
        '
        'FrmSelTipoDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(572, 491)
        Me.Controls.Add(Me.lbtipo)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.gitems)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSelTipoDoc"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SAE TIPOS DE DOCUMENTOS= Alt+S"
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.gitems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmditems As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents gitems As System.Windows.Forms.DataGridView
    Friend WithEvents lbtipo As System.Windows.Forms.Label
    Friend WithEvents buscar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nit As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelPedidos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ok = New System.Windows.Forms.Button
        Me.gitems = New System.Windows.Forms.DataGridView
        Me.buscar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.docu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.con = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtcuenta = New System.Windows.Forms.TextBox
        Me.lbfila = New System.Windows.Forms.Label
        Me.lbform = New System.Windows.Forms.Label
        Me.cmditems = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmbBusc = New System.Windows.Forms.ComboBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.lbltabla = New System.Windows.Forms.Label
        CType(Me.gitems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(521, 16)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(45, 23)
        Me.ok.TabIndex = 1
        Me.ok.Text = "Ok"
        Me.ok.UseVisualStyleBackColor = True
        '
        'gitems
        '
        Me.gitems.AllowUserToDeleteRows = False
        Me.gitems.AllowUserToResizeColumns = False
        Me.gitems.AllowUserToResizeRows = False
        Me.gitems.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gitems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.gitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gitems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.buscar, Me.docu, Me.fecha, Me.cliente, Me.con, Me.total, Me.tipo, Me.numero})
        Me.gitems.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gitems.Location = New System.Drawing.Point(4, 58)
        Me.gitems.MultiSelect = False
        Me.gitems.Name = "gitems"
        Me.gitems.RowHeadersVisible = False
        Me.gitems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gitems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gitems.Size = New System.Drawing.Size(848, 335)
        Me.gitems.StandardTab = True
        Me.gitems.TabIndex = 16
        '
        'buscar
        '
        Me.buscar.Frozen = True
        Me.buscar.HeaderText = "BUSCAR"
        Me.buscar.MinimumWidth = 150
        Me.buscar.Name = "buscar"
        Me.buscar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.buscar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.buscar.ToolTipText = "buscar por apellidos"
        Me.buscar.Visible = False
        Me.buscar.Width = 150
        '
        'docu
        '
        Me.docu.Frozen = True
        Me.docu.HeaderText = "DOC INTERNO"
        Me.docu.MinimumWidth = 110
        Me.docu.Name = "docu"
        Me.docu.Width = 110
        '
        'fecha
        '
        Me.fecha.Frozen = True
        Me.fecha.HeaderText = "FECHA "
        Me.fecha.MinimumWidth = 80
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 80
        '
        'cliente
        '
        Me.cliente.Frozen = True
        Me.cliente.HeaderText = "CLIENTE"
        Me.cliente.MinimumWidth = 300
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Width = 300
        '
        'con
        '
        Me.con.Frozen = True
        Me.con.HeaderText = "CONCEPTO"
        Me.con.MinimumWidth = 220
        Me.con.Name = "con"
        Me.con.ReadOnly = True
        Me.con.Width = 220
        '
        'total
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.total.DefaultCellStyle = DataGridViewCellStyle1
        Me.total.HeaderText = "TOTAL FACTURA"
        Me.total.MinimumWidth = 120
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 120
        '
        'tipo
        '
        Me.tipo.HeaderText = "TIPO"
        Me.tipo.Name = "tipo"
        Me.tipo.Visible = False
        '
        'numero
        '
        Me.numero.HeaderText = "NUMERO"
        Me.numero.Name = "numero"
        Me.numero.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "BUSCAR POR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtcuenta
        '
        Me.txtcuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcuenta.Location = New System.Drawing.Point(290, 18)
        Me.txtcuenta.MaxLength = 100
        Me.txtcuenta.Name = "txtcuenta"
        Me.txtcuenta.Size = New System.Drawing.Size(225, 20)
        Me.txtcuenta.TabIndex = 0
        '
        'lbfila
        '
        Me.lbfila.AutoSize = True
        Me.lbfila.Location = New System.Drawing.Point(90, 48)
        Me.lbfila.Name = "lbfila"
        Me.lbfila.Size = New System.Drawing.Size(20, 13)
        Me.lbfila.TabIndex = 70
        Me.lbfila.Text = "fila"
        Me.lbfila.Visible = False
        '
        'lbform
        '
        Me.lbform.AutoSize = True
        Me.lbform.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbform.Location = New System.Drawing.Point(90, 26)
        Me.lbform.Name = "lbform"
        Me.lbform.Size = New System.Drawing.Size(52, 13)
        Me.lbform.TabIndex = 68
        Me.lbform.Text = "formulario"
        Me.lbform.Visible = False
        '
        'cmditems
        '
        Me.cmditems.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmditems.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmditems.ForeColor = System.Drawing.Color.Transparent
        Me.cmditems.Image = Global.SAE.My.Resources.Resources.seleecionar
        Me.cmditems.Location = New System.Drawing.Point(388, 3)
        Me.cmditems.Name = "cmditems"
        Me.cmditems.Size = New System.Drawing.Size(72, 68)
        Me.cmditems.TabIndex = 0
        Me.cmditems.Text = "&S"
        Me.cmditems.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.cmditems, "seleccionar cliente  Alt+S")
        Me.cmditems.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbBusc)
        Me.GroupBox3.Controls.Add(Me.ok)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtcuenta)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(848, 52)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'cmbBusc
        '
        Me.cmbBusc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBusc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBusc.FormattingEnabled = True
        Me.cmbBusc.Items.AddRange(New Object() {"DOCUMENTO", "FECHA", "CLIENTE"})
        Me.cmbBusc.Location = New System.Drawing.Point(118, 18)
        Me.cmbBusc.Name = "cmbBusc"
        Me.cmbBusc.Size = New System.Drawing.Size(166, 21)
        Me.cmbBusc.TabIndex = 74
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.lbltabla)
        Me.GroupPanel1.Controls.Add(Me.lbfila)
        Me.GroupPanel1.Controls.Add(Me.lbform)
        Me.GroupPanel1.Controls.Add(Me.cmditems)
        'Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(4, 396)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(848, 85)
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
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 17
        '
        'lbltabla
        '
        Me.lbltabla.AutoSize = True
        Me.lbltabla.Location = New System.Drawing.Point(259, 46)
        Me.lbltabla.Name = "lbltabla"
        Me.lbltabla.Size = New System.Drawing.Size(30, 13)
        Me.lbltabla.TabIndex = 71
        Me.lbltabla.Text = "tabla"
        Me.lbltabla.Visible = False
        '
        'FrmSelPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(857, 484)
        Me.Controls.Add(Me.gitems)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSelPedidos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "    SAE Seleccionar Pedidos"
        CType(Me.gitems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents gitems As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcuenta As System.Windows.Forms.TextBox
    Friend WithEvents lbfila As System.Windows.Forms.Label
    Friend WithEvents lbform As System.Windows.Forms.Label
    Friend WithEvents cmditems As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents buscar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents con As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbBusc As System.Windows.Forms.ComboBox
    Friend WithEvents lbltabla As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHenry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpData = New System.Windows.Forms.GroupBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.cboTable = New System.Windows.Forms.ComboBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.cboSearch = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVal = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.grpInventory = New System.Windows.Forms.GroupBox()
        Me.dgrInventory = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpData.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        Me.grpInventory.SuspendLayout()
        CType(Me.dgrInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpData
        '
        Me.grpData.Controls.Add(Me.btnShow)
        Me.grpData.Controls.Add(Me.cboTable)
        Me.grpData.Controls.Add(Me.lblSelect)
        Me.grpData.Location = New System.Drawing.Point(12, 12)
        Me.grpData.Name = "grpData"
        Me.grpData.Size = New System.Drawing.Size(311, 122)
        Me.grpData.TabIndex = 0
        Me.grpData.TabStop = False
        Me.grpData.Text = "Display Table Data"
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(6, 27)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(69, 13)
        Me.lblSelect.TabIndex = 0
        Me.lblSelect.Text = "Select table:"
        '
        'cboTable
        '
        Me.cboTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTable.FormattingEnabled = True
        Me.cboTable.Location = New System.Drawing.Point(80, 24)
        Me.cboTable.Name = "cboTable"
        Me.cboTable.Size = New System.Drawing.Size(218, 21)
        Me.cboTable.TabIndex = 1
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(223, 61)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show Data"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.txtVal)
        Me.grpSearch.Controls.Add(Me.Label1)
        Me.grpSearch.Controls.Add(Me.cboSearch)
        Me.grpSearch.Controls.Add(Me.lblSearch)
        Me.grpSearch.Location = New System.Drawing.Point(361, 13)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(504, 121)
        Me.grpSearch.TabIndex = 1
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(7, 25)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(110, 13)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Search inventory by:"
        '
        'cboSearch
        '
        Me.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Location = New System.Drawing.Point(123, 22)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(360, 21)
        Me.cboSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Value:"
        '
        'txtVal
        '
        Me.txtVal.Location = New System.Drawing.Point(123, 51)
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Size = New System.Drawing.Size(360, 22)
        Me.txtVal.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(408, 85)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'grpInventory
        '
        Me.grpInventory.Controls.Add(Me.dgrInventory)
        Me.grpInventory.Location = New System.Drawing.Point(12, 150)
        Me.grpInventory.Name = "grpInventory"
        Me.grpInventory.Size = New System.Drawing.Size(853, 368)
        Me.grpInventory.TabIndex = 2
        Me.grpInventory.TabStop = False
        Me.grpInventory.Text = "Inventory"
        '
        'dgrInventory
        '
        Me.dgrInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrInventory.Location = New System.Drawing.Point(32, 39)
        Me.dgrInventory.Name = "dgrInventory"
        Me.dgrInventory.Size = New System.Drawing.Size(789, 297)
        Me.dgrInventory.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(762, 527)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 37)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmHenry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 576)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpInventory)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpData)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmHenry"
        Me.Text = "Database Sample"
        Me.grpData.ResumeLayout(False)
        Me.grpData.PerformLayout()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.grpInventory.ResumeLayout(False)
        CType(Me.dgrInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpData As GroupBox
    Friend WithEvents btnShow As Button
    Friend WithEvents cboTable As ComboBox
    Friend WithEvents lblSelect As Label
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtVal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSearch As ComboBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents grpInventory As GroupBox
    Friend WithEvents dgrInventory As DataGridView
    Friend WithEvents btnExit As Button
End Class

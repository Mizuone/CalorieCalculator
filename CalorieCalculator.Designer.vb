<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalorieCalculator
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
        Me.lblDayAmount = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lstFruitsVeg = New System.Windows.Forms.ListBox()
        Me.lstGrains = New System.Windows.Forms.ListBox()
        Me.lstProtein = New System.Windows.Forms.ListBox()
        Me.lstCalorieCount = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunctionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstMiscellaneous = New System.Windows.Forms.ListBox()
        Me.lstJunkFood = New System.Windows.Forms.ListBox()
        Me.lblFruitVeg = New System.Windows.Forms.Label()
        Me.lblGrains = New System.Windows.Forms.Label()
        Me.lblProtein = New System.Windows.Forms.Label()
        Me.lblMiscellaneous = New System.Windows.Forms.Label()
        Me.lblJunkFood = New System.Windows.Forms.Label()
        Me.lblCalorieCount = New System.Windows.Forms.Label()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDayAmount
        '
        Me.lblDayAmount.AutoSize = True
        Me.lblDayAmount.Location = New System.Drawing.Point(23, 379)
        Me.lblDayAmount.Name = "lblDayAmount"
        Me.lblDayAmount.Size = New System.Drawing.Size(121, 13)
        Me.lblDayAmount.TabIndex = 50
        Me.lblDayAmount.Text = "Amount of daliy calories:"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(26, 395)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(132, 20)
        Me.txtTotal.TabIndex = 51
        '
        'lstFruitsVeg
        '
        Me.lstFruitsVeg.FormattingEnabled = True
        Me.lstFruitsVeg.Location = New System.Drawing.Point(246, 48)
        Me.lstFruitsVeg.Name = "lstFruitsVeg"
        Me.lstFruitsVeg.Size = New System.Drawing.Size(172, 264)
        Me.lstFruitsVeg.TabIndex = 53
        '
        'lstGrains
        '
        Me.lstGrains.FormattingEnabled = True
        Me.lstGrains.Location = New System.Drawing.Point(424, 48)
        Me.lstGrains.Name = "lstGrains"
        Me.lstGrains.Size = New System.Drawing.Size(162, 264)
        Me.lstGrains.TabIndex = 54
        '
        'lstProtein
        '
        Me.lstProtein.FormattingEnabled = True
        Me.lstProtein.Location = New System.Drawing.Point(592, 48)
        Me.lstProtein.Name = "lstProtein"
        Me.lstProtein.Size = New System.Drawing.Size(161, 264)
        Me.lstProtein.TabIndex = 55
        '
        'lstCalorieCount
        '
        Me.lstCalorieCount.FormattingEnabled = True
        Me.lstCalorieCount.Location = New System.Drawing.Point(26, 48)
        Me.lstCalorieCount.Name = "lstCalorieCount"
        Me.lstCalorieCount.Size = New System.Drawing.Size(204, 329)
        Me.lstCalorieCount.TabIndex = 56
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.FunctionsToolStripMenuItem, Me.InstructionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(787, 24)
        Me.MenuStrip1.TabIndex = 57
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'FunctionsToolStripMenuItem
        '
        Me.FunctionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.FunctionsToolStripMenuItem.Name = "FunctionsToolStripMenuItem"
        Me.FunctionsToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.FunctionsToolStripMenuItem.Text = "&Functions"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionsToolStripMenuItem1, Me.InformationToolStripMenuItem, Me.ContactToolStripMenuItem})
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.InstructionsToolStripMenuItem.Text = "&Information"
        '
        'InstructionsToolStripMenuItem1
        '
        Me.InstructionsToolStripMenuItem1.Name = "InstructionsToolStripMenuItem1"
        Me.InstructionsToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.InstructionsToolStripMenuItem1.Text = "I&nstructions"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InformationToolStripMenuItem.Text = "&Developer"
        '
        'lstMiscellaneous
        '
        Me.lstMiscellaneous.FormattingEnabled = True
        Me.lstMiscellaneous.Location = New System.Drawing.Point(297, 341)
        Me.lstMiscellaneous.Name = "lstMiscellaneous"
        Me.lstMiscellaneous.Size = New System.Drawing.Size(172, 95)
        Me.lstMiscellaneous.TabIndex = 58
        '
        'lstJunkFood
        '
        Me.lstJunkFood.FormattingEnabled = True
        Me.lstJunkFood.Location = New System.Drawing.Point(518, 341)
        Me.lstJunkFood.Name = "lstJunkFood"
        Me.lstJunkFood.Size = New System.Drawing.Size(172, 95)
        Me.lstJunkFood.TabIndex = 59
        '
        'lblFruitVeg
        '
        Me.lblFruitVeg.AutoSize = True
        Me.lblFruitVeg.Location = New System.Drawing.Point(243, 32)
        Me.lblFruitVeg.Name = "lblFruitVeg"
        Me.lblFruitVeg.Size = New System.Drawing.Size(97, 13)
        Me.lblFruitVeg.TabIndex = 60
        Me.lblFruitVeg.Text = "Fruits && Vegetables"
        '
        'lblGrains
        '
        Me.lblGrains.AutoSize = True
        Me.lblGrains.Location = New System.Drawing.Point(421, 32)
        Me.lblGrains.Name = "lblGrains"
        Me.lblGrains.Size = New System.Drawing.Size(40, 13)
        Me.lblGrains.TabIndex = 61
        Me.lblGrains.Text = "Grains:"
        '
        'lblProtein
        '
        Me.lblProtein.AutoSize = True
        Me.lblProtein.Location = New System.Drawing.Point(589, 32)
        Me.lblProtein.Name = "lblProtein"
        Me.lblProtein.Size = New System.Drawing.Size(43, 13)
        Me.lblProtein.TabIndex = 62
        Me.lblProtein.Text = "Protein:"
        '
        'lblMiscellaneous
        '
        Me.lblMiscellaneous.AutoSize = True
        Me.lblMiscellaneous.Location = New System.Drawing.Point(294, 325)
        Me.lblMiscellaneous.Name = "lblMiscellaneous"
        Me.lblMiscellaneous.Size = New System.Drawing.Size(77, 13)
        Me.lblMiscellaneous.TabIndex = 63
        Me.lblMiscellaneous.Text = "Miscellaneous:"
        '
        'lblJunkFood
        '
        Me.lblJunkFood.AutoSize = True
        Me.lblJunkFood.Location = New System.Drawing.Point(515, 325)
        Me.lblJunkFood.Name = "lblJunkFood"
        Me.lblJunkFood.Size = New System.Drawing.Size(60, 13)
        Me.lblJunkFood.TabIndex = 64
        Me.lblJunkFood.Text = "Junk Food:"
        '
        'lblCalorieCount
        '
        Me.lblCalorieCount.AutoSize = True
        Me.lblCalorieCount.Location = New System.Drawing.Point(23, 32)
        Me.lblCalorieCount.Name = "lblCalorieCount"
        Me.lblCalorieCount.Size = New System.Drawing.Size(73, 13)
        Me.lblCalorieCount.TabIndex = 65
        Me.lblCalorieCount.Text = "Calorie Count:"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ContactToolStripMenuItem.Text = "Contac&t"
        '
        'CalorieCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 438)
        Me.Controls.Add(Me.lblCalorieCount)
        Me.Controls.Add(Me.lblJunkFood)
        Me.Controls.Add(Me.lblMiscellaneous)
        Me.Controls.Add(Me.lblProtein)
        Me.Controls.Add(Me.lblGrains)
        Me.Controls.Add(Me.lblFruitVeg)
        Me.Controls.Add(Me.lstJunkFood)
        Me.Controls.Add(Me.lstMiscellaneous)
        Me.Controls.Add(Me.lstCalorieCount)
        Me.Controls.Add(Me.lstProtein)
        Me.Controls.Add(Me.lstGrains)
        Me.Controls.Add(Me.lstFruitsVeg)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblDayAmount)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CalorieCalculator"
        Me.Text = "Calorie App"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDayAmount As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lstFruitsVeg As System.Windows.Forms.ListBox
    Friend WithEvents lstGrains As System.Windows.Forms.ListBox
    Friend WithEvents lstProtein As System.Windows.Forms.ListBox
    Friend WithEvents lstCalorieCount As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FunctionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstMiscellaneous As System.Windows.Forms.ListBox
    Friend WithEvents lstJunkFood As System.Windows.Forms.ListBox
    Friend WithEvents lblFruitVeg As System.Windows.Forms.Label
    Friend WithEvents lblGrains As System.Windows.Forms.Label
    Friend WithEvents lblProtein As System.Windows.Forms.Label
    Friend WithEvents lblMiscellaneous As System.Windows.Forms.Label
    Friend WithEvents lblJunkFood As System.Windows.Forms.Label
    Friend WithEvents lblCalorieCount As System.Windows.Forms.Label
    Friend WithEvents InformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

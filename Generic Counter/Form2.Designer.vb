<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class appearance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(appearance))
        Me.btnChangeForeground = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnChangeBackground = New System.Windows.Forms.Button()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.cbSwitchDeathMode = New System.Windows.Forms.CheckBox()
        Me.cbAnimalCrossing = New System.Windows.Forms.CheckBox()
        Me.cbAnimalCrossingDark = New System.Windows.Forms.CheckBox()
        Me.btnCustomImage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnChangeForeground
        '
        Me.btnChangeForeground.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.btnChangeForeground.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeForeground.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeForeground.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnChangeForeground.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnChangeForeground.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChangeForeground.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeForeground.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.btnChangeForeground.Location = New System.Drawing.Point(23, 12)
        Me.btnChangeForeground.Name = "btnChangeForeground"
        Me.btnChangeForeground.Size = New System.Drawing.Size(149, 26)
        Me.btnChangeForeground.TabIndex = 0
        Me.btnChangeForeground.Text = "Change Text Color"
        Me.btnChangeForeground.UseVisualStyleBackColor = False
        '
        'btnChangeBackground
        '
        Me.btnChangeBackground.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.btnChangeBackground.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeBackground.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnChangeBackground.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnChangeBackground.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnChangeBackground.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChangeBackground.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeBackground.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.btnChangeBackground.Location = New System.Drawing.Point(23, 44)
        Me.btnChangeBackground.Name = "btnChangeBackground"
        Me.btnChangeBackground.Size = New System.Drawing.Size(149, 26)
        Me.btnChangeBackground.TabIndex = 1
        Me.btnChangeBackground.Text = "Change Background Color"
        Me.btnChangeBackground.UseVisualStyleBackColor = False
        '
        'btnRename
        '
        Me.btnRename.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.btnRename.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnRename.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnRename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRename.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRename.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRename.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.btnRename.Location = New System.Drawing.Point(23, 76)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(149, 26)
        Me.btnRename.TabIndex = 2
        Me.btnRename.Text = "Rename Counting Word"
        Me.btnRename.UseVisualStyleBackColor = False
        '
        'cbSwitchDeathMode
        '
        Me.cbSwitchDeathMode.AutoSize = True
        Me.cbSwitchDeathMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSwitchDeathMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbSwitchDeathMode.Location = New System.Drawing.Point(23, 137)
        Me.cbSwitchDeathMode.Name = "cbSwitchDeathMode"
        Me.cbSwitchDeathMode.Size = New System.Drawing.Size(155, 20)
        Me.cbSwitchDeathMode.TabIndex = 3
        Me.cbSwitchDeathMode.Text = "Switch to Death Mode"
        Me.cbSwitchDeathMode.UseVisualStyleBackColor = True
        '
        'cbAnimalCrossing
        '
        Me.cbAnimalCrossing.AutoSize = True
        Me.cbAnimalCrossing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAnimalCrossing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbAnimalCrossing.Location = New System.Drawing.Point(21, 163)
        Me.cbAnimalCrossing.Name = "cbAnimalCrossing"
        Me.cbAnimalCrossing.Size = New System.Drawing.Size(161, 20)
        Me.cbAnimalCrossing.TabIndex = 4
        Me.cbAnimalCrossing.Text = "Animal Counting (Light)"
        Me.cbAnimalCrossing.UseVisualStyleBackColor = True
        '
        'cbAnimalCrossingDark
        '
        Me.cbAnimalCrossingDark.AutoSize = True
        Me.cbAnimalCrossingDark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAnimalCrossingDark.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbAnimalCrossingDark.Location = New System.Drawing.Point(20, 186)
        Me.cbAnimalCrossingDark.Name = "cbAnimalCrossingDark"
        Me.cbAnimalCrossingDark.Size = New System.Drawing.Size(162, 20)
        Me.cbAnimalCrossingDark.TabIndex = 5
        Me.cbAnimalCrossingDark.Text = "Animal Counting (Dark)"
        Me.cbAnimalCrossingDark.UseVisualStyleBackColor = True
        '
        'btnCustomImage
        '
        Me.btnCustomImage.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.btnCustomImage.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustomImage.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCustomImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCustomImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCustomImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustomImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomImage.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.btnCustomImage.Location = New System.Drawing.Point(23, 108)
        Me.btnCustomImage.Name = "btnCustomImage"
        Me.btnCustomImage.Size = New System.Drawing.Size(149, 26)
        Me.btnCustomImage.TabIndex = 6
        Me.btnCustomImage.Text = "Set Custom Image"
        Me.btnCustomImage.UseVisualStyleBackColor = False
        '
        'appearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.ClientSize = New System.Drawing.Size(194, 216)
        Me.Controls.Add(Me.btnCustomImage)
        Me.Controls.Add(Me.cbAnimalCrossingDark)
        Me.Controls.Add(Me.cbAnimalCrossing)
        Me.Controls.Add(Me.cbSwitchDeathMode)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.btnChangeBackground)
        Me.Controls.Add(Me.btnChangeForeground)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "appearance"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appearance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnChangeForeground As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnChangeBackground As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents cbSwitchDeathMode As CheckBox
    Friend WithEvents cbAnimalCrossing As CheckBox
    Friend WithEvents cbAnimalCrossingDark As CheckBox
    Friend WithEvents btnCustomImage As Button
End Class

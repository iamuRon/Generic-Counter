<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class genericCounter

    Inherits System.Windows.Forms.Form

    Dim red, green, blue As Integer

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(genericCounter))
        Me.lblName = New System.Windows.Forms.Label()
        Me.EditDirectlyText = New System.Windows.Forms.Label()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnClearEdit = New System.Windows.Forms.Button()
        Me.txtTextFilePath = New System.Windows.Forms.TextBox()
        Me.TextFilePathText = New System.Windows.Forms.Label()
        Me.btnFindPath = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.txtEditDeaths = New System.Windows.Forms.MaskedTextBox()
        Me.ttAdd = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttRemove = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AppearanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CounterSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmIncrements = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSound = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoSoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UwUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YouDiedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OofToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRemoveDeath = New System.Windows.Forms.Button()
        Me.btnAddDeath = New System.Windows.Forms.Button()
        Me.cbSave = New System.Windows.Forms.CheckBox()
        Me.ttSave = New System.Windows.Forms.ToolTip(Me.components)
        Me.picGenericCounter = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtTotalDeaths = New System.Windows.Forms.Label()
        Me.picAnimalCrossing = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picGenericCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAnimalCrossing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.lblName.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblName.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblName.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.lblName.Location = New System.Drawing.Point(12, 465)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(84, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Generic Counter"
        '
        'EditDirectlyText
        '
        Me.EditDirectlyText.AutoSize = True
        Me.EditDirectlyText.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.EditDirectlyText.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EditDirectlyText.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EditDirectlyText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditDirectlyText.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.EditDirectlyText.Location = New System.Drawing.Point(57, 194)
        Me.EditDirectlyText.Name = "EditDirectlyText"
        Me.EditDirectlyText.Size = New System.Drawing.Size(111, 20)
        Me.EditDirectlyText.TabIndex = 3
        Me.EditDirectlyText.Text = "Edit Directly:"
        '
        'btnCommit
        '
        Me.btnCommit.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.btnCommit.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCommit.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnCommit.Enabled = False
        Me.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCommit.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.btnCommit.Location = New System.Drawing.Point(174, 226)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(75, 23)
        Me.btnCommit.TabIndex = 5
        Me.btnCommit.Text = "Commit"
        Me.btnCommit.UseVisualStyleBackColor = False
        '
        'btnClearEdit
        '
        Me.btnClearEdit.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.btnClearEdit.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnClearEdit.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnClearEdit.Enabled = False
        Me.btnClearEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearEdit.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.btnClearEdit.Location = New System.Drawing.Point(255, 226)
        Me.btnClearEdit.Name = "btnClearEdit"
        Me.btnClearEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnClearEdit.TabIndex = 6
        Me.btnClearEdit.Text = "Clear"
        Me.btnClearEdit.UseVisualStyleBackColor = False
        '
        'txtTextFilePath
        '
        Me.txtTextFilePath.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.txtTextFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTextFilePath.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtTextFilePath.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtTextFilePath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Generic_Counter.My.MySettings.Default, "textFilePath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtTextFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTextFilePath.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.txtTextFilePath.Location = New System.Drawing.Point(133, 287)
        Me.txtTextFilePath.Name = "txtTextFilePath"
        Me.txtTextFilePath.ReadOnly = True
        Me.txtTextFilePath.Size = New System.Drawing.Size(242, 26)
        Me.txtTextFilePath.TabIndex = 7
        Me.txtTextFilePath.Text = Global.Generic_Counter.My.MySettings.Default.textFilePath
        Me.txtTextFilePath.UseSystemPasswordChar = True
        '
        'TextFilePathText
        '
        Me.TextFilePathText.AutoSize = True
        Me.TextFilePathText.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.TextFilePathText.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextFilePathText.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextFilePathText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFilePathText.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.TextFilePathText.Location = New System.Drawing.Point(3, 290)
        Me.TextFilePathText.Name = "TextFilePathText"
        Me.TextFilePathText.Size = New System.Drawing.Size(124, 20)
        Me.TextFilePathText.TabIndex = 8
        Me.TextFilePathText.Text = "Text File Path:"
        '
        'btnFindPath
        '
        Me.btnFindPath.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.btnFindPath.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnFindPath.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnFindPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindPath.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.btnFindPath.Location = New System.Drawing.Point(133, 319)
        Me.btnFindPath.Name = "btnFindPath"
        Me.btnFindPath.Size = New System.Drawing.Size(75, 23)
        Me.btnFindPath.TabIndex = 9
        Me.btnFindPath.Text = "Browse"
        Me.btnFindPath.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.btnShow.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnShow.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShow.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.btnShow.Location = New System.Drawing.Point(215, 319)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 10
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.btnExit.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnExit.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.btnExit.Location = New System.Drawing.Point(292, 452)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 26)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnEnable
        '
        Me.btnEnable.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.btnEnable.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEnable.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnable.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.btnEnable.Location = New System.Drawing.Point(300, 319)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(75, 23)
        Me.btnEnable.TabIndex = 12
        Me.btnEnable.Text = "Enable"
        Me.btnEnable.UseVisualStyleBackColor = False
        '
        'txtEditDeaths
        '
        Me.txtEditDeaths.AllowPromptAsInput = False
        Me.txtEditDeaths.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.txtEditDeaths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditDeaths.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtEditDeaths.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtEditDeaths.Enabled = False
        Me.txtEditDeaths.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditDeaths.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.txtEditDeaths.HidePromptOnLeave = True
        Me.txtEditDeaths.Location = New System.Drawing.Point(174, 194)
        Me.txtEditDeaths.Mask = "999999999"
        Me.txtEditDeaths.Name = "txtEditDeaths"
        Me.txtEditDeaths.Size = New System.Drawing.Size(156, 26)
        Me.txtEditDeaths.TabIndex = 16
        Me.txtEditDeaths.ValidatingType = GetType(Integer)
        '
        'ttAdd
        '
        '
        'ttRemove
        '
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVersion.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblVersion.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblVersion.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.lblVersion.Location = New System.Drawing.Point(97, 463)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(30, 15)
        Me.lblVersion.TabIndex = 19
        Me.lblVersion.Text = "v1.2"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppearanceToolStripMenuItem, Me.CounterSettingsToolStripMenuItem, Me.LogsToolStripMenuItem, Me.tsmHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(407, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "msOptions"
        '
        'AppearanceToolStripMenuItem
        '
        Me.AppearanceToolStripMenuItem.Name = "AppearanceToolStripMenuItem"
        Me.AppearanceToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.AppearanceToolStripMenuItem.Text = "Appearance"
        '
        'CounterSettingsToolStripMenuItem
        '
        Me.CounterSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmIncrements, Me.tsmSound})
        Me.CounterSettingsToolStripMenuItem.Name = "CounterSettingsToolStripMenuItem"
        Me.CounterSettingsToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.CounterSettingsToolStripMenuItem.Text = "Counter Settings"
        '
        'tsmIncrements
        '
        Me.tsmIncrements.Name = "tsmIncrements"
        Me.tsmIncrements.Size = New System.Drawing.Size(133, 22)
        Me.tsmIncrements.Text = "Increments"
        '
        'tsmSound
        '
        Me.tsmSound.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoSoundToolStripMenuItem, Me.UwUToolStripMenuItem, Me.YouDiedToolStripMenuItem, Me.OofToolStripMenuItem, Me.FlopToolStripMenuItem})
        Me.tsmSound.Name = "tsmSound"
        Me.tsmSound.Size = New System.Drawing.Size(133, 22)
        Me.tsmSound.Text = "Sound"
        '
        'NoSoundToolStripMenuItem
        '
        Me.NoSoundToolStripMenuItem.Checked = True
        Me.NoSoundToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NoSoundToolStripMenuItem.Name = "NoSoundToolStripMenuItem"
        Me.NoSoundToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.NoSoundToolStripMenuItem.Text = "No Sound"
        '
        'UwUToolStripMenuItem
        '
        Me.UwUToolStripMenuItem.Name = "UwUToolStripMenuItem"
        Me.UwUToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.UwUToolStripMenuItem.Text = "UwU"
        '
        'YouDiedToolStripMenuItem
        '
        Me.YouDiedToolStripMenuItem.Name = "YouDiedToolStripMenuItem"
        Me.YouDiedToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.YouDiedToolStripMenuItem.Text = "You Died"
        '
        'OofToolStripMenuItem
        '
        Me.OofToolStripMenuItem.Name = "OofToolStripMenuItem"
        Me.OofToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.OofToolStripMenuItem.Text = "Oof"
        '
        'FlopToolStripMenuItem
        '
        Me.FlopToolStripMenuItem.Name = "FlopToolStripMenuItem"
        Me.FlopToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.FlopToolStripMenuItem.Text = "Flop"
        '
        'LogsToolStripMenuItem
        '
        Me.LogsToolStripMenuItem.Name = "LogsToolStripMenuItem"
        Me.LogsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.LogsToolStripMenuItem.Text = "Logs"
        '
        'tsmHelp
        '
        Me.tsmHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TutorialToolStripMenuItem, Me.DiscordToolStripMenuItem})
        Me.tsmHelp.Name = "tsmHelp"
        Me.tsmHelp.Size = New System.Drawing.Size(44, 20)
        Me.tsmHelp.Text = "Help"
        '
        'TutorialToolStripMenuItem
        '
        Me.TutorialToolStripMenuItem.Name = "TutorialToolStripMenuItem"
        Me.TutorialToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.TutorialToolStripMenuItem.Text = "Tutorial"
        '
        'DiscordToolStripMenuItem
        '
        Me.DiscordToolStripMenuItem.Name = "DiscordToolStripMenuItem"
        Me.DiscordToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.DiscordToolStripMenuItem.Text = "Discord"
        '
        'btnRemoveDeath
        '
        Me.btnRemoveDeath.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.btnRemoveDeath.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnRemoveDeath.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnRemoveDeath.Enabled = False
        Me.btnRemoveDeath.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemoveDeath.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveDeath.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.btnRemoveDeath.Location = New System.Drawing.Point(215, 62)
        Me.btnRemoveDeath.Name = "btnRemoveDeath"
        Me.btnRemoveDeath.Size = New System.Drawing.Size(160, 93)
        Me.btnRemoveDeath.TabIndex = 2
        Me.btnRemoveDeath.Text = "Remove"
        Me.btnRemoveDeath.UseVisualStyleBackColor = False
        '
        'btnAddDeath
        '
        Me.btnAddDeath.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.btnAddDeath.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnAddDeath.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnAddDeath.Enabled = False
        Me.btnAddDeath.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddDeath.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDeath.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.btnAddDeath.Location = New System.Drawing.Point(31, 62)
        Me.btnAddDeath.Name = "btnAddDeath"
        Me.btnAddDeath.Size = New System.Drawing.Size(160, 93)
        Me.btnAddDeath.TabIndex = 0
        Me.btnAddDeath.Text = "Add"
        Me.btnAddDeath.UseVisualStyleBackColor = False
        '
        'cbSave
        '
        Me.cbSave.AutoSize = True
        Me.cbSave.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.cbSave.Checked = Global.Generic_Counter.My.MySettings.Default.checked
        Me.cbSave.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSave.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSave.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Generic_Counter.My.MySettings.Default, "checked", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSave.Enabled = False
        Me.cbSave.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.cbSave.Location = New System.Drawing.Point(15, 323)
        Me.cbSave.Name = "cbSave"
        Me.cbSave.Size = New System.Drawing.Size(57, 17)
        Me.cbSave.TabIndex = 22
        Me.cbSave.Text = "Save?"
        Me.cbSave.UseVisualStyleBackColor = False
        '
        'picGenericCounter
        '
        Me.picGenericCounter.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.picGenericCounter.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.picGenericCounter.Image = CType(resources.GetObject("picGenericCounter.Image"), System.Drawing.Image)
        Me.picGenericCounter.Location = New System.Drawing.Point(-39, 304)
        Me.picGenericCounter.Name = "picGenericCounter"
        Me.picGenericCounter.Size = New System.Drawing.Size(313, 207)
        Me.picGenericCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGenericCounter.TabIndex = 23
        Me.picGenericCounter.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.PictureBox2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-9, 313)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(313, 207)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'txtTotalDeaths
        '
        Me.txtTotalDeaths.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.txtTotalDeaths.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTotalDeaths.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.Generic_Counter.My.MySettings.Default, "forecolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtTotalDeaths.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtTotalDeaths.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtTotalDeaths.ForeColor = Global.Generic_Counter.My.MySettings.Default.forecolor
        Me.txtTotalDeaths.Location = New System.Drawing.Point(234, 390)
        Me.txtTotalDeaths.Name = "txtTotalDeaths"
        Me.txtTotalDeaths.Size = New System.Drawing.Size(96, 27)
        Me.txtTotalDeaths.TabIndex = 25
        Me.txtTotalDeaths.Text = "0"
        Me.txtTotalDeaths.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picAnimalCrossing
        '
        Me.picAnimalCrossing.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.picAnimalCrossing.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.picAnimalCrossing.Image = CType(resources.GetObject("picAnimalCrossing.Image"), System.Drawing.Image)
        Me.picAnimalCrossing.Location = New System.Drawing.Point(-39, 304)
        Me.picAnimalCrossing.Name = "picAnimalCrossing"
        Me.picAnimalCrossing.Size = New System.Drawing.Size(313, 207)
        Me.picAnimalCrossing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAnimalCrossing.TabIndex = 26
        Me.picAnimalCrossing.TabStop = False
        '
        'genericCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Generic_Counter.My.MySettings.Default.backcolor
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(407, 487)
        Me.Controls.Add(Me.txtTotalDeaths)
        Me.Controls.Add(Me.cbSave)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.txtEditDeaths)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnFindPath)
        Me.Controls.Add(Me.TextFilePathText)
        Me.Controls.Add(Me.txtTextFilePath)
        Me.Controls.Add(Me.btnClearEdit)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.EditDirectlyText)
        Me.Controls.Add(Me.btnRemoveDeath)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnAddDeath)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.picGenericCounter)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picAnimalCrossing)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Generic_Counter.My.MySettings.Default, "backcolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "genericCounter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ragan's Generic Counter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picGenericCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAnimalCrossing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddDeath As Button
    Friend WithEvents lblName As Label
    Friend WithEvents btnRemoveDeath As Button
    Friend WithEvents EditDirectlyText As Label
    Friend WithEvents btnCommit As Button
    Friend WithEvents btnClearEdit As Button
    Friend WithEvents txtTextFilePath As TextBox
    Friend WithEvents TextFilePathText As Label
    Friend WithEvents btnFindPath As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnEnable As Button
    Friend WithEvents txtEditDeaths As MaskedTextBox
    Friend WithEvents ttAdd As ToolTip
    Friend WithEvents ttRemove As ToolTip
    Friend WithEvents lblVersion As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AppearanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CounterSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbSave As CheckBox
    Friend WithEvents ttSave As ToolTip
    Friend WithEvents picGenericCounter As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents tsmIncrements As ToolStripMenuItem
    Friend WithEvents tsmSound As ToolStripMenuItem
    Friend WithEvents tsmHelp As ToolStripMenuItem
    Friend WithEvents NoSoundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UwUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YouDiedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OofToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiscordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtTotalDeaths As Label
    Friend WithEvents TutorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picAnimalCrossing As PictureBox
End Class

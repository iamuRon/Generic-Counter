Imports System.Runtime.InteropServices




'=============================
'           Main
'=============================



Public Class genericCounter

    ReadOnly placeholders As Dictionary(Of String, ValueDelegate) = New Dictionary(Of String, ValueDelegate)()

    ReadOnly audios = New List(Of Tuple(Of String, ToolStripMenuItem, IO.Stream))

    Dim counting As String = My.Settings.name
    Dim new_save As String = My.Settings.textFilePath
    Dim checked As Boolean = My.Settings.checked
    Dim deathChecked As Boolean = My.Settings.deathChecked
    Dim animalCrossingChecked As Boolean = My.Settings.animalCrossingChecked
    Dim new_nosound, new_uwu, new_youdied, new_oof, new_flop As Boolean
    Dim new_stepAmount As Integer
    Dim stepAmount As Integer = My.Settings.stepAmount


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form3.lbLogs.Items.Add("Loading...")
        placeholders.Add("<c>", AddressOf GetCounting)

        ttAdd.SetToolTip(btnAddDeath, "Shortcut: [PgUp]")
        ttRemove.SetToolTip(btnRemoveDeath, "Shortcut: [PgDn]")
        ttSave.SetToolTip(cbSave, "UNCHECKING THIS WILL DISABLE ALL ACTIVE FEATURES!")
        If deathChecked = True Then
            picGenericCounter.Visible = False
            PictureBox2.Visible = True
            picAnimalCrossing.Visible = False
        ElseIf animalCrossingChecked = True Then
            picAnimalCrossing.Visible = True
            picGenericCounter.Visible = False
            PictureBox2.Visible = False
        Else
            picGenericCounter.Visible = True
            PictureBox2.Visible = False
            picAnimalCrossing.Visible = False
        End If

        UpdateCounting()

        If new_nosound = True Then
            NoSoundToolStripMenuItem.Checked = True
            UwUToolStripMenuItem.Checked = False
            YouDiedToolStripMenuItem.Checked = False
            OofToolStripMenuItem.Checked = False
            FlopToolStripMenuItem.Checked = False
        ElseIf new_uwu = True Then
            NoSoundToolStripMenuItem.Checked = False
            UwUToolStripMenuItem.Checked = True
            YouDiedToolStripMenuItem.Checked = False
            OofToolStripMenuItem.Checked = False
            FlopToolStripMenuItem.Checked = False
        ElseIf new_youdied = True Then
            NoSoundToolStripMenuItem.Checked = False
            UwUToolStripMenuItem.Checked = False
            YouDiedToolStripMenuItem.Checked = True
            OofToolStripMenuItem.Checked = False
            FlopToolStripMenuItem.Checked = False
        ElseIf new_flop = True Then
            NoSoundToolStripMenuItem.Checked = False
            UwUToolStripMenuItem.Checked = False
            YouDiedToolStripMenuItem.Checked = False
            OofToolStripMenuItem.Checked = False
            FlopToolStripMenuItem.Checked = True
        ElseIf new_oof = True Then
            NoSoundToolStripMenuItem.Checked = False
            UwUToolStripMenuItem.Checked = False
            YouDiedToolStripMenuItem.Checked = False
            OofToolStripMenuItem.Checked = True
            FlopToolStripMenuItem.Checked = False
        End If

        If cbSave.Checked = False Then
            txtTextFilePath.Text = ""
        End If

        If txtTextFilePath.Text IsNot "" Then
            txtEditDeaths.Enabled = True
            btnCommit.Enabled = True
            btnAddDeath.Enabled = True
            btnRemoveDeath.Enabled = True
            cbSave.Enabled = True
            btnClearEdit.Enabled = True
        End If
        Form3.lbLogs.Items.Add("Loaded")
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        InitSettings()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub InitSettings()
        new_save = My.Settings.textFilePath
        checked = My.Settings.checked
        deathChecked = My.Settings.deathChecked
        new_nosound = My.Settings.nosound
        new_uwu = My.Settings.uwu
        new_youdied = My.Settings.youdied
        new_oof = My.Settings.oof
        new_flop = My.Settings.flop
        stepAmount = My.Settings.stepAmount


    End Sub

    Function GetCounting() As String
        Return counting
    End Function

    Function SetCounting(new_counting) As String
        counting = new_counting
        My.Settings.name = counting
        My.Settings.Save()
        UpdateCounting()
        Form3.lbLogs.Items.Add("New Counting Name set to: " & counting)
    End Function



    Sub UpdateCounting()
        btnAddDeath.Text = Fix("Add <c>")
        btnRemoveDeath.Text = Fix("Remove <c>")
        Form3.lbLogs.Items.Add("Counting Updated...")
    End Sub

    Private Sub btnFindPath_Click(sender As Object, e As EventArgs) Handles btnFindPath.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "Text files (*.txt)|*.txt|Text files (*.txt)|*.txt"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            txtTextFilePath.Text = strFileName
        Else
            Form3.lbLogs.Items.Add("Text File Path ERROR")
        End If
        Form3.lbLogs.Items.Add("Text File Path Found.")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Dim hidden As Boolean = True

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If (hidden) Then
            hidden = False
            btnShow.Text = "Hide"
            Form3.lbLogs.Items.Add("Text File Path Shown")
        Else
            hidden = True
            btnShow.Text = "Show"
            Form3.lbLogs.Items.Add("Text File Path Hidden")
        End If
        txtTextFilePath.UseSystemPasswordChar = hidden
    End Sub

    Private Sub txtEditDeath_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        Dim readFile As System.IO.StreamReader
        Dim ctx As String
        If txtTextFilePath.Text IsNot "" Then
            txtEditDeaths.Enabled = True
            btnCommit.Enabled = True
            btnAddDeath.Enabled = True
            btnRemoveDeath.Enabled = True
            cbSave.Enabled = True
            btnClearEdit.Enabled = True
            readFile = My.Computer.FileSystem.OpenTextFileReader(txtTextFilePath.Text)
            ctx = readFile.ReadLine()
            readFile.Close()
            txtTotalDeaths.Text = ctx
            Form3.lbLogs.Items.Add("Enabled")
        Else
            MsgBox("Text File Path Cannot be blank!")
            Form3.lbLogs.Items.Add("Tried to enable without specifying text file path")
        End If

    End Sub

    Private Sub btnRemoveDeath_Click(sender As Object, e As EventArgs) Handles btnRemoveDeath.Click
        Dim file As System.IO.StreamWriter
        Dim readFile As System.IO.StreamReader
        Dim ctx As String
        readFile = My.Computer.FileSystem.OpenTextFileReader(txtTextFilePath.Text)
        ctx = readFile.ReadLine()
        readFile.Close()
        If ctx = "" Then
            ctx = 0
        End If
        file = My.Computer.FileSystem.OpenTextFileWriter(txtTextFilePath.Text, False)
        file.Write(Convert.ToInt32(ctx) - stepAmount)
        file.Close()
        Form3.lbLogs.Items.Add("Removed " & stepAmount & " from total")
        txtTotalDeaths.Text = Convert.ToInt32(ctx) - stepAmount
        If NoSoundToolStripMenuItem.Checked = True Then
            Return
        ElseIf UwUToolStripMenuItem.Checked = True Then
            My.Computer.Audio.Play(My.Resources.uwu, AudioPlayMode.Background)
        ElseIf YouDiedToolStripMenuItem.Checked = True Then
            My.Computer.Audio.Play(My.Resources.youdied, AudioPlayMode.Background)
        ElseIf OofToolStripMenuItem.Checked = True Then
            My.Computer.Audio.Play(My.Resources.oof, AudioPlayMode.Background)
        ElseIf FlopToolStripMenuItem.Checked = True Then
            My.Computer.Audio.Play(My.Resources.flop, AudioPlayMode.Background)
        End If


    End Sub

    Private Sub btnAddDeath_Click(sender As Object, e As EventArgs) Handles btnAddDeath.Click
        Dim file As System.IO.StreamWriter
        Dim readFile As System.IO.StreamReader
        Dim ctx As String
        readFile = My.Computer.FileSystem.OpenTextFileReader(txtTextFilePath.Text)
        ctx = readFile.ReadLine()
        readFile.Close()
        If ctx = "" Then
            ctx = 0
        End If
        file = My.Computer.FileSystem.OpenTextFileWriter(txtTextFilePath.Text, False)
        file.Write(Convert.ToInt32(ctx) + stepAmount)
        file.Close()
        txtTotalDeaths.Text = Convert.ToInt32(ctx) + stepAmount
        Form3.lbLogs.Items.Add("Added " & stepAmount & " to total")
        If NoSoundToolStripMenuItem.Checked = True Then
            Return
        ElseIf UwUToolStripMenuItem.Checked = True Then
            My.Computer.Audio.Play(My.Resources.uwu, AudioPlayMode.Background)
        ElseIf YouDiedToolStripMenuItem.Checked = True Then
            My.Computer.Audio.Play(My.Resources.youdied, AudioPlayMode.Background)
        ElseIf OofToolStripMenuItem.Checked = True Then
            My.Computer.Audio.Play(My.Resources.oof, AudioPlayMode.Background)
        ElseIf FlopToolStripMenuItem.Checked = True Then
            My.Computer.Audio.Play(My.Resources.flop, AudioPlayMode.Background)
        End If


    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        Dim file As System.IO.StreamWriter
        If txtEditDeaths.Text = "" Then
            MsgBox("Death's Cannot be blank!")
            Form3.lbLogs.Items.Add("Tried to edit count but cannot send NULL data to file")
        Else
            file = My.Computer.FileSystem.OpenTextFileWriter(txtTextFilePath.Text, False)
            file.Write(txtEditDeaths.Text)
            file.Close()
            txtTotalDeaths.Text = txtEditDeaths.Text
            Form3.lbLogs.Items.Add("Changed count to: " & txtEditDeaths.Text)
        End If


    End Sub

    Private Sub btnAddDeath_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles btnAddDeath.PreviewKeyDown

    End Sub

    Private WithEvents kbHook As New KeyboardHook

    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        Debug.WriteLine(Key.ToString)
        Select Case Key
            Case Keys.PageUp
                btnAddDeath.PerformClick()
            Case Keys.PageDown
                btnRemoveDeath.PerformClick()
        End Select
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ttAdd.Popup

    End Sub

    Private Sub ToolTip2_Popup(sender As Object, e As PopupEventArgs) Handles ttRemove.Popup

    End Sub

    Private Sub txtEditDeath_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEditDeaths.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnCommit.PerformClick()
        End Select
    End Sub



    Function Fix(str As String)
        Dim str1 As String = str
        For i = 0 To placeholders.Count - 1
            str1 = Strings.Replace(str1, placeholders.Keys(i), placeholders.Values(i)())
        Next i
        Return str1
    End Function
    Delegate Function ValueDelegate() As String

    Private Sub AppearanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppearanceToolStripMenuItem.Click
        appearance.Show()
        appearance.BringToFront()
    End Sub

    Private Sub txtTotalDeaths_TextChanged(sender As Object, e As EventArgs) Handles txtTotalDeaths.TextChanged

    End Sub

    Private Sub cbSave_CheckedChanged(sender As Object, e As EventArgs) Handles cbSave.CheckedChanged
        If cbSave.Checked = True Then
            My.Settings.checked = True
            My.Settings.textFilePath = txtTextFilePath.Text
            My.Settings.Save()
            Form3.lbLogs.Items.Add("Text file path saved for next session")
        Else
            My.Settings.checked = False
            My.Settings.textFilePath = ""
            My.Settings.Save()
            txtEditDeaths.Enabled = False
            btnCommit.Enabled = False
            btnAddDeath.Enabled = False
            btnRemoveDeath.Enabled = False
            cbSave.Enabled = False
            btnClearEdit.Enabled = False
            Form3.lbLogs.Items.Add("Text file path will not be saved. ")
            Form3.lbLogs.Items.Add("Disabling all assets until text file path Is specified And enabled.")
        End If
    End Sub

    Private Sub tsmIncrements_Click(sender As Object, e As EventArgs) Handles tsmIncrements.Click
        new_stepAmount = InputBox("Enter Increment Rate:", "Change Counting Increment")
        My.Settings.stepAmount = new_stepAmount
        My.Settings.Save()
        stepAmount = My.Settings.stepAmount
        Form3.lbLogs.Items.Add("Step Amount changed to: " & stepAmount)

    End Sub

    Private Sub LogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogsToolStripMenuItem.Click
        Form3.Show()
        Form3.BringToFront()
    End Sub

    Private Sub btnClearEdit_Click_1(sender As Object, e As EventArgs) Handles btnClearEdit.Click
        txtEditDeaths.Clear()
        Form3.lbLogs.Items.Add("Edit Directly Cleared.")
    End Sub

    Private Sub DiscordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscordToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://discord.gg/cmbVRDUyt2")
    End Sub

    Private Sub TutorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutorialToolStripMenuItem.Click
        MsgBox("WARNING: DO NOT HOLD DOWN PgUp OR PgDn IT WILL CRASH!" & Environment.NewLine & Environment.NewLine &
                "To get started hit the browse button and find the text file that you want to save your count to." & Environment.NewLine & Environment.NewLine &
                "After you define the text file hit the 'Enable' button. This will enable the rest of the applications features. You can also hit the SAVE check box to save your file path on next launch." & Environment.NewLine & Environment.NewLine &
                "After all of that is done you can add counts manually with the 'Edit Directly' Text box or you can click the 'Add' or 'Remove' buttons to change your count." & Environment.NewLine & Environment.NewLine &
                "Alternatively, You can also use the PgUp Key to add a count or use the PgDn Key to remove a count (NOTE: The PgUp and PgDn WILL STILL work when minimized!)" & Environment.NewLine & Environment.NewLine &
                "If you need help add me on discord! : iamu#8814 ")
        Form3.lbLogs.Items.Add("Help Loaded")
    End Sub

    '===============================
    '       SOUND GOES HERE
    '===============================

    Private Sub NoSoundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoSoundToolStripMenuItem.Click
        My.Settings.nosound = True
        My.Settings.uwu = False
        My.Settings.youdied = False
        UwUToolStripMenuItem.Checked = False
        NoSoundToolStripMenuItem.Checked = True
        YouDiedToolStripMenuItem.Checked = False
        OofToolStripMenuItem.Checked = False
        FlopToolStripMenuItem.Checked = False
        Form3.lbLogs.Items.Add("Sound set to NONE")
    End Sub

    Private Sub UwUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UwUToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.uwu, AudioPlayMode.Background)
        My.Settings.nosound = False
        My.Settings.uwu = True
        My.Settings.youdied = False
        UwUToolStripMenuItem.Checked = True
        NoSoundToolStripMenuItem.Checked = False
        YouDiedToolStripMenuItem.Checked = False
        OofToolStripMenuItem.Checked = False
        FlopToolStripMenuItem.Checked = False
        Form3.lbLogs.Items.Add("Sound set to UwU")
    End Sub
    Private Sub YouDiedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouDiedToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.youdied, AudioPlayMode.Background)
        My.Settings.nosound = False
        My.Settings.uwu = False
        My.Settings.youdied = True
        UwUToolStripMenuItem.Checked = False
        NoSoundToolStripMenuItem.Checked = False
        YouDiedToolStripMenuItem.Checked = True
        OofToolStripMenuItem.Checked = False
        FlopToolStripMenuItem.Checked = False
        Form3.lbLogs.Items.Add("Sound set to You Died")
    End Sub
    Private Sub OofToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OofToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.oof, AudioPlayMode.Background)
        My.Settings.nosound = False
        My.Settings.uwu = False
        My.Settings.youdied = False
        My.Settings.oof = True
        My.Settings.flop = False
        UwUToolStripMenuItem.Checked = False
        NoSoundToolStripMenuItem.Checked = False
        YouDiedToolStripMenuItem.Checked = False
        OofToolStripMenuItem.Checked = True
        FlopToolStripMenuItem.Checked = False
        Form3.lbLogs.Items.Add("Sound set to Oof")
    End Sub
    Private Sub FlopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlopToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.flop, AudioPlayMode.Background)
        My.Settings.nosound = False
        My.Settings.uwu = False
        My.Settings.youdied = False
        My.Settings.oof = False
        My.Settings.flop = True
        UwUToolStripMenuItem.Checked = False
        NoSoundToolStripMenuItem.Checked = False
        YouDiedToolStripMenuItem.Checked = False
        OofToolStripMenuItem.Checked = False
        FlopToolStripMenuItem.Checked = True
        Form3.lbLogs.Items.Add("Sound set to Flop")
    End Sub

End Class

'=============================
'       KeyBoard Hook
'=============================


Public Class KeyboardHook

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal HookProc As KBDLLHookProc, ByVal hInstance As IntPtr, ByVal wParam As Integer) As Integer
    End Function
    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function CallNextHookEx(ByVal idHook As Integer, ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    End Function
    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function UnhookWindowsHookEx(ByVal idHook As Integer) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Private Structure KBDLLHOOKSTRUCT
        Public vkCode As UInt32
        Public scanCode As UInt32
        Public flags As KBDLLHOOKSTRUCTFlags
        Public time As UInt32
        Public dwExtraInfo As UIntPtr
    End Structure

    <Flags()>
    Private Enum KBDLLHOOKSTRUCTFlags As UInt32
        LLKHF_EXTENDED = &H1
        LLKHF_INJECTED = &H10
        LLKHF_ALTDOWN = &H20
        LLKHF_UP = &H80
    End Enum

    Public Shared Event KeyDown(ByVal Key As Keys)
    Public Shared Event KeyUp(ByVal Key As Keys)

    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const HC_ACTION As Integer = 0
    Private Const WM_KEYDOWN = &H100
    Private Const WM_KEYUP = &H101
    Private Const WM_SYSKEYDOWN = &H104
    Private Const WM_SYSKEYUP = &H105

    Private Delegate Function KBDLLHookProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer

    Private KBDLLHookProcDelegate As KBDLLHookProc = New KBDLLHookProc(AddressOf KeyboardProc)
    Private HHookID As IntPtr = IntPtr.Zero

    Private Function KeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
        If (nCode = HC_ACTION) Then
            Dim struct As KBDLLHOOKSTRUCT
            Select Case wParam
                Case WM_KEYDOWN, WM_SYSKEYDOWN
                    RaiseEvent KeyDown(CType(CType(Marshal.PtrToStructure(lParam, struct.GetType()), KBDLLHOOKSTRUCT).vkCode, Keys))
                Case WM_KEYUP, WM_SYSKEYUP
                    RaiseEvent KeyUp(CType(CType(Marshal.PtrToStructure(lParam, struct.GetType()), KBDLLHOOKSTRUCT).vkCode, Keys))
            End Select
        End If
        Return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam)
    End Function

    Public Sub New()
        HHookID = SetWindowsHookEx(WH_KEYBOARD_LL, KBDLLHookProcDelegate, System.Runtime.InteropServices.Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0)).ToInt32, 0)
        If HHookID = IntPtr.Zero Then
            Throw New Exception("Could not set keyboard hook")
        End If
    End Sub

    Protected Overrides Sub Finalize()
        If Not HHookID = IntPtr.Zero Then
            UnhookWindowsHookEx(HHookID)
        End If
        MyBase.Finalize()
    End Sub

End Class
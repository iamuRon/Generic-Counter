Public Class appearance
    Dim new_forecolor, new_backgroundColor As Color
    Dim colors As DialogResult
    Dim new_countWord As String
    Dim deathChecked, animalCrossingChecked As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        InitSettings()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub InitSettings()
        new_forecolor = My.Settings.forecolor
        new_backgroundColor = My.Settings.backcolor
        new_countWord = My.Settings.name
        deathChecked = My.Settings.deathChecked
        animalCrossingChecked = My.Settings.animalCrossingChecked


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnChangeForeground.Click
        colors = ColorDialog1.ShowDialog()
        If colors = Windows.Forms.DialogResult.OK Then
            new_forecolor = ColorDialog1.Color
        End If
        My.Settings.forecolor = new_forecolor
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnRename.Click
        new_countWord = InputBox("Enter new counting name:", "New Name")
        My.Settings.name = new_countWord
        genericCounter.SetCounting(new_countWord)
        My.Settings.Save()



    End Sub

    Private Sub cbSwitchDeathMode_CheckedChanged(sender As Object, e As EventArgs) Handles cbSwitchDeathMode.CheckedChanged
        If cbSwitchDeathMode.Checked = True Then
            cbAnimalCrossing.Checked = False
            cbAnimalCrossingDark.Checked = False
            My.Settings.deathChecked = True
            My.Settings.animalCrossingChecked = False
            My.Settings.animalCrossingDarkChecked = False
            My.Settings.backcolor = Color.FromArgb(69, 69, 69)
            My.Settings.forecolor = Color.FromArgb(255, 192, 192)
            My.Settings.picDeathEnable = True
            genericCounter.picGenericCounter.Visible = False
            genericCounter.PictureBox2.Visible = True
            genericCounter.picAnimalCrossing.Visible = False
            genericCounter.SetCounting("Deaths")
            My.Settings.Save()
        Else
            genericCounter.SetCounting("")
            My.Settings.deathChecked = False
            genericCounter.picGenericCounter.Visible = True
            genericCounter.PictureBox2.Visible = False
            genericCounter.picAnimalCrossing.Visible = False
            My.Settings.backcolor = Color.FromArgb(69, 69, 69)
            My.Settings.forecolor = Color.FromArgb(192, 255, 255)
            genericCounter.SetCounting("")
            My.Settings.Save()
        End If
    End Sub

    Private Sub appearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbSwitchDeathMode.Checked = My.Settings.deathChecked
        cbAnimalCrossing.Checked = My.Settings.animalCrossingChecked
        cbAnimalCrossingDark.Checked = My.Settings.animalCrossingDarkChecked
    End Sub

    Private Sub cbAnimalCrossing_CheckedChanged(sender As Object, e As EventArgs) Handles cbAnimalCrossing.CheckedChanged
        If cbAnimalCrossing.Checked = True Then
            cbSwitchDeathMode.Checked = False
            cbAnimalCrossingDark.Checked = False
            My.Settings.animalCrossingChecked = True
            My.Settings.deathChecked = False
            My.Settings.animalCrossingDarkChecked = False
            My.Settings.backcolor = Color.FromArgb(166, 247, 220) '(196, 141, 63)
            My.Settings.forecolor = Color.FromArgb(224, 177, 0) '(129, 241, 247)
            My.Settings.picDeathEnable = True
            genericCounter.picGenericCounter.Visible = False
            genericCounter.PictureBox2.Visible = False
            genericCounter.picAnimalCrossing.Visible = True
            genericCounter.SetCounting("Islands")
            My.Settings.Save()
        Else
            genericCounter.SetCounting("")
            My.Settings.animalCrossingChecked = False
            genericCounter.picGenericCounter.Visible = True
            genericCounter.PictureBox2.Visible = False
            genericCounter.picAnimalCrossing.Visible = False
            My.Settings.backcolor = Color.FromArgb(69, 69, 69)
            My.Settings.forecolor = Color.FromArgb(192, 255, 255)
            genericCounter.SetCounting("")
            My.Settings.Save()
        End If
    End Sub
    Private Sub cbAnimalCrossingDark_CheckedChanged(sender As Object, e As EventArgs) Handles cbAnimalCrossingDark.CheckedChanged
        If cbAnimalCrossingDark.Checked = True Then
            cbSwitchDeathMode.Checked = False
            cbAnimalCrossing.Checked = False
            My.Settings.animalCrossingChecked = False
            My.Settings.deathChecked = False
            My.Settings.animalCrossingDarkChecked = True
            My.Settings.backcolor = Color.FromArgb(196, 141, 63) '(196, 141, 63)
            My.Settings.forecolor = Color.FromArgb(255, 195, 0) '(129, 241, 247)
            My.Settings.picDeathEnable = True
            genericCounter.picGenericCounter.Visible = False
            genericCounter.PictureBox2.Visible = False
            genericCounter.picAnimalCrossing.Visible = True
            genericCounter.SetCounting("Islands")
            My.Settings.Save()
        Else
            genericCounter.SetCounting("")
            My.Settings.animalCrossingChecked = False
            genericCounter.picGenericCounter.Visible = True
            genericCounter.PictureBox2.Visible = False
            genericCounter.picAnimalCrossing.Visible = False
            My.Settings.backcolor = Color.FromArgb(69, 69, 69)
            My.Settings.forecolor = Color.FromArgb(192, 255, 255)
            genericCounter.SetCounting("")
            My.Settings.Save()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnChangeBackground.Click
        colors = ColorDialog1.ShowDialog()
        If colors = Windows.Forms.DialogResult.OK Then
            new_backgroundColor = ColorDialog1.Color
        End If
        My.Settings.backcolor = new_backgroundColor
        My.Settings.Save()
    End Sub
End Class
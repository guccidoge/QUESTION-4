Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '1)write down full name
        'click button, inputBox1 will appear
        'inputBox1 request for full name, OK /
        'inputBox2 request for birth date, OK /
        'getting today's date and calculate how old are you in DAYS
        'display your age in DAYS (eg: 7300 days old)/
        'state (first name)(chapter 5:use indexOf function)(to locate specific character in string)
        'eg:     Emma, you are 7300 years old

        'IndexOf explanation
        'eg:     James Bond
        'txtname.IndexOf(" ")
        'eg: 23.45
        'txtnum.IndexOf(".")

        '8) subString explanation
        '-->to split words into desired
        'Dim a = James Bond
        'a.subString(0, n) = James
        'a.subString(0, n + 1) = Bond

        'Dim i As Integer
        ' Dim InpName As String

        'For i = 1 To 4
        ' InpName = InputBox("What is your name?")
        '  If InpName = "computer literacy" Then
        '  TextBox1.Text = InpName
        '   ElseIf InpName = "engineering" Then
        '  TextBox1.Text = InpName
        'Else
        '  MsgBox("We only offer computer literacy and engineering")
        '    End If
        '  Next i

        Dim a As String
        Dim b As Integer

        a = InputBox("What is your name?")

        Label1.Text = a

        b = MsgBox("Hello " & a & ", please choose your birthdate")

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim datecheck As String
        Dim today As System.DateTime = System.DateTime.Now
        datecheck = DateTimePicker1.Text

        Dim yearnow As Integer = today.Year
        Dim yeardtp As Integer = DateTimePicker1.Value.Year
        Dim rightyear As Integer = DateTimePicker1.Value.Year
        Dim minimage As Integer = yeardtp - rightyear
        Dim currentage As Integer = yearnow - yeardtp

        Label2.Text = currentage.ToString
        Label2.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim today As String = Date.Today
        Dim dob As String = DateTimePicker1.Text

        Dim d1 As DateTime = DateTime.Parse(today).Date
        Dim d2 As DateTime = DateTime.Parse(dob).Date

        Dim days As Single = (d1 - d2).TotalDays

        'Dim fullName As String = Label1.Text
        'Dim splitName As String() = fullName.Split(" ")
        'Dim firstName As String = splitName(0).Substring(0, 1) & splitName(1).Substring(0, 1)

        Label3.Text = Label1.Text.Split(" "c)(0) & ", you are " & days & " days old!"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class

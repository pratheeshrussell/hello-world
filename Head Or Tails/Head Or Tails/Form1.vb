Imports System.Text

Public Class Form1
    Dim p As String = Nothing
    Dim q As Integer = Nothing
    Dim RandomKey As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    PictureBox1.Hide()
        Label1.Hide()
        Label2.Hide()
        
        TextBox2.Text = TextBox2.Text + 1
        If q >= 3 Then
            q = 0
            If p = "h" Then
                RandomKey = 2
            ElseIf p = "t" Then
                RandomKey = 1
            End If
        Else
            Dim KeyGen As RandomKeyGenerator
            Dim NumKeys As Integer
            Dim i_Keys As Integer

            NumKeys = 20

            KeyGen = New RandomKeyGenerator
            KeyGen.KeyLetters = "1"
            KeyGen.KeyNumbers = "2"
            KeyGen.KeyChars = 1
            For i_Keys = 1 To NumKeys
                RandomKey = KeyGen.Generate()
            Next
        End If
        If RandomKey = 1 Then
            heads()
  ElseIf RandomKey = 2 Then
            tails()
        End If
    End Sub
    Function heads()

        If p = "t" Or p = Nothing Then
            p = "h"
            q = "1"
        ElseIf p = "h" Then
            q = q + 1
            'MsgBox(q)
        End If

        PictureBox2.Hide()
        Label3.Hide()
        TextBox1.Text = "Heads"

        TextBox3.Text = TextBox3.Text + 1
        PictureBox3.Show()
        Label4.Show()
    End Function
    Function tails()
        If p = "h" Or p = Nothing Then
            p = "t"
            q = "1"
        ElseIf p = "t" Then
            q = q + 1
            'MsgBox(q)
        End If


        PictureBox3.Hide()
        Label4.Hide()
        TextBox1.Text = "Tails"
        PictureBox2.Show()
        Label3.Show()
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox2.Hide()
        PictureBox3.Hide()
        TextBox1.Text = Nothing
        TextBox2.Text = 0
        TextBox3.Text = 0
        Label3.Hide()
        Label4.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        reset()

    End Sub
    Function reset()
        PictureBox1.Show()
        PictureBox2.Hide()
        PictureBox3.Hide()
        Label1.Show()
        Label2.Show()
        Label3.Hide()
        Label4.Hide()
        TextBox1.Text = ""
        p = Nothing
        q = Nothing
        TextBox2.Text = 0
        TextBox3.Text = 0
        Me.Refresh()
        Exit Function
    End Function

End Class
Public Class RandomKeyGenerator
    Dim Key_Letters As String
    Dim Key_Numbers As String
    Dim Key_Chars As Integer
    Dim LettersArray As Char()
    Dim NumbersArray As Char()

    Protected Friend WriteOnly Property KeyLetters() As String
        Set(ByVal Value As String)
            Key_Letters = Value
        End Set
    End Property
    Protected Friend WriteOnly Property KeyNumbers() As String
        Set(ByVal Value As String)
            Key_Numbers = Value
        End Set
    End Property
    Protected Friend WriteOnly Property KeyChars() As Integer
        Set(ByVal Value As Integer)
            Key_Chars = Value
        End Set
    End Property
    Function Generate() As String
        Dim i_key As Integer
        Dim Random1 As Single
        Dim arrIndex As Int16
        Dim sb As New StringBuilder
        Dim RandomLetter As String
        LettersArray = Key_Letters.ToCharArray
        NumbersArray = Key_Numbers.ToCharArray

        For i_key = 1 To Key_Chars


            Randomize()
            Random1 = Rnd()
            arrIndex = -1

            If (CType(Random1 * 111, Integer)) Mod 2 = 0 Then

                Do While arrIndex < 0
                    arrIndex = _
                     Convert.ToInt16(LettersArray.GetUpperBound(0) _
                     * Random1)
                Loop
                RandomLetter = LettersArray(arrIndex)
                If (CType(arrIndex * Random1 * 99, Integer)) Mod 2 <> 0 Then
                    RandomLetter = LettersArray(arrIndex).ToString
                    RandomLetter = RandomLetter.ToUpper
                End If
                sb.Append(RandomLetter)
            Else

                Do While arrIndex < 0
                    arrIndex = _
                      Convert.ToInt16(NumbersArray.GetUpperBound(0) _
                      * Random1)
                Loop
                sb.Append(NumbersArray(arrIndex))
            End If
        Next
        Return sb.ToString
    End Function

End Class

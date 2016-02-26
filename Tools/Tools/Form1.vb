Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("C:\WINDOWS\system32\regedt32.exe")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("C:\WINDOWS\system32\services.msc")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("C:\WINDOWS\system32\cmd.exe")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("C:\WINDOWS\system32\calc.exe")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("C:\WINDOWS\system32\clipbrd.exe")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        System.Diagnostics.Process.Start("C:\WINDOWS\system32\mspaint.exe")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        System.Diagnostics.Process.Start("C:\WINDOWS\system32\taskmgr.exe")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        System.Diagnostics.Process.Start("C:\WINDOWS\system32\magnify.exe")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        System.Diagnostics.Process.Start("C:\WINDOWS\pchealth\helpctr\binaries\msconfig.exe")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        System.Diagnostics.Process.Start("C:\WINDOWS\system32\notepad.exe")
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        System.Diagnostics.Process.Start("C:\WINDOWS\system32\mrt.exe")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        System.Diagnostics.Process.Start("C:\WINDOWS\system32\winmine.exe")
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        System.Diagnostics.Process.Start("C:\WINDOWS\system32\dfrg.msc")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        System.Diagnostics.Process.Start("C:\WINDOWS\system32\sysdm.cpl")
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        System.Diagnostics.Process.Start("C:\WINDOWS\system32\narrator.exe")
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim f2 As New form2
        f2.show()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Dim pratheesh
        pratheesh = MsgBox("Programed By Pratheesh", 0, "About")
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Dim pratheesh
        pratheesh = MsgBox("Each Button Acts As A Shortcut To The Corresponding Program Just Click It" & Chr(13) & "Works Only In XP That Too Only If U Have Windows Installed In C-Drive", 0, "Help")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetBounds(400, 150, 359, 380)
    End Sub
End Class

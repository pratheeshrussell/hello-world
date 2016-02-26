Public Class Form2
   
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        WebBrowser1.Navigate("192.168.1.1")
        Threading.Thread.Sleep(1000)
        SendKeys.Send("a")
        SendKeys.Send("d")
        SendKeys.Send("m")
        SendKeys.Send("i")
        SendKeys.Send("n")
        SendKeys.Send("{TAB}")
        SendKeys.Send("a")
        SendKeys.Send("d")
        SendKeys.Send("m")
        SendKeys.Send("i")
        SendKeys.Send("n")
        SendKeys.Send("{ENTER}")
    End Sub
End Class
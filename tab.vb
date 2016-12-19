Public Class tab
    Private Sub tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Visible = True
        WebBrowser1.Dock = DockStyle.Fill
        Me.WebBrowser1.Navigate("https://en.wikipedia.org/wiki/Tarot")

    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Console.Beep(500, 50)
        Me.Visible = False
    End Sub
End Class
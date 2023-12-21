Imports Guna.UI.WinForms

Public Class home
    Private Sub GunaGradient2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaGradient2Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click

    End Sub
    Dim sidebar As String = "close "
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If sidebar = "open" Then
            Panel1.Width += 35
            If Panel1.Width >= 250 Then
                sidebar = "close"
                Timer1.Stop()
            End If
        Else
            Panel1.Width -= 35
            If Panel1.Width <= 50 Then
                sidebar = "open"
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Timer1.Start()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class
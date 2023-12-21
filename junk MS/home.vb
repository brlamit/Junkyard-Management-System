Imports Guna.UI.WinForms

Public Class home
    Private Sub GunaGradient2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


End Class
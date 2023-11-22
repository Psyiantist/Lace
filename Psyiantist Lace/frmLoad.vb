Imports System.Net
Imports System.Net.Http

Public Class frmLoad
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Private Async Sub frmLoad_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Await IsWebsiteReachableAsync("https://kitsune--mattfawn.repl.co/") Then
            Dim mainForm As New frmMain()
            Me.Hide()
            mainForm.Show()
        Else
            MsgBox("Please check your internet connection and try again.", MsgBoxStyle.Critical, "Network Error")
            Application.Exit()
        End If
    End Sub

    Private Async Function IsWebsiteReachableAsync(url As String) As Task(Of Boolean)
        Try
            Using client As New HttpClient()
                Dim response = Await client.GetAsync(url)
                If response.StatusCode = HttpStatusCode.NotFound Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub frmLoad_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Private Sub frmLoad_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Sub frmLoad_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
        End If
    End Sub
End Class

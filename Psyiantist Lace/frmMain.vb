Imports System.Net.Http
Imports System.Net.NetworkInformation
Imports System.Text
Imports System.Text.Json
Imports System.Threading
Imports System.Drawing.Imaging

Public Class frmMain
    Public streamline As Boolean = False
    Public onProcess As Boolean = False
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Private cts As CancellationTokenSource
    Private sl As CancellationTokenSource

    Dim url As String = "https://kitsune--mattfawn.repl.co/llama70"

    Private Sub AdjustBrightness(image As Image, brightness As Single)
        Dim matrix As New ColorMatrix(New Single()() _
        {
            New Single() {1, 0, 0, 0, 0},
            New Single() {0, 1, 0, 0, 0},
            New Single() {0, 0, 1, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {brightness, brightness, brightness, 0, 1}
        })

        Dim imageAttributes As New ImageAttributes()
        imageAttributes.SetColorMatrix(matrix)

        Dim rect As New Rectangle(0, 0, image.Width, image.Height)

        Dim bmp As New Bitmap(image.Width, image.Height)

        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(image, rect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes)
        End Using

        PictureBox1.Image = bmp
    End Sub


    Private Async Function AnimateText(ByVal textToAnimate As String, ByVal textbox As RichTextBox, token As CancellationToken) As Task
        barProgress.Maximum = textToAnimate.Length
        btnStreamline.Show()
        Dim stringBuilder As New StringBuilder()
        streamline = False

        For Each c As Char In textToAnimate

            If streamline Then
                textbox.Text = textToAnimate
                Exit For
            End If

            If token.IsCancellationRequested Then
                Exit For
            End If

            stringBuilder.Append(c)
            textbox.AppendText(c.ToString())

            lblProgress.Text = $"{stringBuilder.Length}/{barProgress.Maximum}"
            barProgress.Value = stringBuilder.Length

            Await Task.Delay(1)
        Next
        txtboxMsg.Enabled = True
        btnSend.Enabled = True
        btnStreamline.Hide()
    End Function

    Private Function GetResponseValue(ByVal jsonString As String) As String
        Try
            Dim jsonDict As Dictionary(Of String, String) = JsonSerializer.Deserialize(Of Dictionary(Of String, String))(jsonString)

            If jsonDict.ContainsKey("response") Then
                Return jsonDict("response")
            Else
                Return "Response key not found"
            End If
        Catch ex As Exception
            Return "Error parsing JSON"
        End Try
    End Function

    Public Function ProcessListViewToJson(listView As ListView) As String
        Dim jsonObj As New StringBuilder()

        jsonObj.Append("[")

        For Each item As ListViewItem In listView.Items
            Dim column1Content As String = item.SubItems(0).Text
            Dim column2Content As String = item.SubItems(1).Text

            jsonObj.Append("{""role"": ""user"", ""content"": """ & column1Content & """}, ")
            jsonObj.Append("{""role"": ""assistant"", ""content"": """ & column2Content & """}, ")
        Next

        jsonObj.Append("{""role"": ""user"", ""content"":  """ & txtboxMsg.Text & """}]")

        Clipboard.SetText(jsonObj.ToString())
        Return jsonObj.ToString()
    End Function

    Private Async Function PostRequestAsync(ByVal url As String, ByVal jsonData As String, token As CancellationToken) As Task(Of String)
        Using client As New HttpClient()
            Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")

            Dim response = Await client.PostAsync(url, content, token).ConfigureAwait(False)
            token.ThrowIfCancellationRequested()

            Dim responseContent = Await response.Content.ReadAsStringAsync().ConfigureAwait(False)
            token.ThrowIfCancellationRequested()

            responseContent = GetResponseValue(responseContent)

            lblLoading.Invoke(Sub() lblLoading.Hide())

            Return responseContent
        End Using
    End Function

    Private Async Function CheckPing(ByVal websiteUrl As String) As Task(Of Long)
        Try
            If Not websiteUrl.StartsWith("http://") AndAlso Not websiteUrl.StartsWith("https://") Then
                websiteUrl = "http://" & websiteUrl
            End If

            Dim uri As New Uri(websiteUrl)
            Dim host As String = uri.Host

            Dim pingSender As New Ping()
            Dim reply As PingReply = Await Task.Run(Function() pingSender.Send(host))

            If reply.Status = IPStatus.Success Then
                pnlWait.Hide()

                If Not onProcess Then
                    txtboxMsg.Enabled = True
                    btnSend.Enabled = True
                End If


                If reply.RoundtripTime >= 0 AndAlso reply.RoundtripTime <= 30 Then
                    lblPing.ForeColor = Color.LightBlue
                ElseIf reply.RoundtripTime >= 31 AndAlso reply.RoundtripTime <= 60 Then
                    lblPing.ForeColor = Color.Green
                ElseIf reply.RoundtripTime >= 61 AndAlso reply.RoundtripTime <= 100 Then
                    lblPing.ForeColor = Color.Orange
                ElseIf reply.RoundtripTime > 100 Then
                    lblPing.ForeColor = Color.Red
                End If

                Return reply.RoundtripTime
            Else
                pnlWait.Show()
                txtboxMsg.Enabled = False
                btnSend.Enabled = False
                Return 0
            End If
        Catch ex As Exception
            Label12.Text = "Pinging Error: " & ex.Message
            pnlWait.Show()
            Return 0
        End Try
    End Function


    Private Async Sub sendMessage()
        onProcess = True
        barProgress.Value = 0
        txtboxMsg.Enabled = False
        btnSend.Enabled = False
        btnCancel.Show()
        txtboxResp.Clear()
        pnlSettings.Enabled = False
        cts = New CancellationTokenSource()
        Dim newItem As New ListViewItem(txtboxMsg.Text)
        lblLoading.Show()

        Try
            If cmbTypeAni.Text = "Enabled" Then
                Await AnimateText(Await PostRequestAsync(url, ProcessListViewToJson(lvHistory), cts.Token), txtboxResp, cts.Token)
            Else
                txtboxResp.Text = Await PostRequestAsync(url, ProcessListViewToJson(lvHistory), cts.Token)
            End If

            newItem.SubItems.Add(txtboxResp.Text)
            lvHistory.Items.Add(newItem)
        Catch ex As OperationCanceledException
            txtboxResp.Text = "Generation Cancelled."
        End Try

        btnCancel.Hide()
        pnlSettings.Enabled = True
        txtboxMsg.Clear()
        onProcess = False
    End Sub

    Private Async Sub pinger_Tick(sender As Object, e As EventArgs) Handles pinger.Tick
        Dim pingTime As Long = Await CheckPing("https://kitsune--mattfawn.repl.co/")
        lblPing.Text = pingTime.ToString & " ms"
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If txtboxMsg.Text.Length > 0 Then
            sendMessage()
        End If
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        If pnlSettings.Visible = False Then
            btnAbout.FlatAppearance.BorderSize = 0
            pnlAbout.Hide()
            btnSettings.FlatAppearance.BorderSize = 1
            pnlSettings.Show()
        Else
            btnSettings.FlatAppearance.BorderSize = 0
            pnlSettings.Hide()
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdjustBrightness(PictureBox1.Image, 10.0)

        lblModelName.Text = "LLaMa-2-70B-chat"
        lblModelType.Text = "Language Model"
        lblParamCount.Text = "70 Billion"
        lblTrained.Text = "True"

        cmbModel.SelectedItem = "LLaMa-2-70B-chat"
        cmbShowP.SelectedItem = "Enabled"
        cmbTypeAni.SelectedItem = "Enabled"
    End Sub

    Private Sub cmbModel_Changed(sender As Object, e As EventArgs) Handles cmbModel.TextChanged
        If cmbModel.Text = "LLaMa-2-70B-chat" Then
            lblModelName.Text = "LLaMa-2-70B-chat"
            lblModelType.Text = "Language Model"
            lblParamCount.Text = "70 Billion"
            lblTrained.Text = "True"
            url = "https://kitsune--mattfawn.repl.co/llama70"
        ElseIf cmbModel.Text = "LLaMa-13B" Then
            lblModelName.Text = "LLaMA-13B"
            lblModelType.Text = "Language Model"
            lblParamCount.Text = "13 Billion"
            lblTrained.Text = "True"
            url = "https://kitsune--mattfawn.repl.co/llama13"
        ElseIf cmbModel.Text = "LLaMa-2-7B" Then
            lblModelName.Text = "LLaMa-2 - 7B"
            lblModelType.Text = "Language Model"
            lblParamCount.Text = "7 Billion"
            lblTrained.Text = "True"
            url = "https://kitsune--mattfawn.repl.co/llama7"
        End If
    End Sub

    Private Sub cmbShowP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbShowP.SelectedIndexChanged
        If cmbShowP.Text = "Disabled" Then
            Label5.Hide()
            lblPing.Hide()
        Else
            Label5.Show()
            lblPing.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
        End If
    End Sub

    Private Sub txtboxMsg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxMsg.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If txtboxMsg.Text.Length > 0 Then
                txtboxResp.Focus()
                sendMessage()
            End If
        End If
    End Sub

    Private Sub lvHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvHistory.SelectedIndexChanged
        If lvHistory.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvHistory.SelectedItems(0)

            Dim firstColumnContent As String = selectedItem.SubItems(0).Text
            Dim secondColumnContent As String = selectedItem.SubItems(1).Text

            txtboxMsg.Text = firstColumnContent
            txtboxResp.Text = secondColumnContent
        End If
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        If pnlAbout.Visible = False Then
            btnSettings.FlatAppearance.BorderSize = 0
            pnlSettings.Hide()
            btnAbout.FlatAppearance.BorderSize = 1
            pnlAbout.Show()
        Else
            btnAbout.FlatAppearance.BorderSize = 0
            pnlAbout.Hide()
        End If
    End Sub

    Private Sub trackbarOpacity_Scroll(sender As Object, e As EventArgs) Handles trackbarOpacity.Scroll
        Me.Opacity = trackbarOpacity.Value * 0.01
        lblOpac.Text = trackbarOpacity.Value.ToString & "%"
    End Sub

    Private Sub outFocus(sender As Object, e As EventArgs) Handles txtboxMsg.Enter, lvHistory.Enter, Panel1.Enter, Panel2.Enter, Panel3.Enter
        btnAbout.FlatAppearance.BorderSize = 0
        btnSettings.FlatAppearance.BorderSize = 0
        pnlAbout.Hide()
        pnlSettings.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If cts IsNot Nothing Then
            cts.Cancel()
            lblLoading.Hide()
        End If
    End Sub

    Private Sub btnShowExtra_Click(sender As Object, e As EventArgs) Handles btnShowExtra.Click
        Me.Size = New Size(If(Me.Size.Width = 800, 1050, 800), Me.Size.Height)

        If Me.Size.Width = 1050 Then
            btnShowExtra.BackColor = pnlExtra.BackColor
            btnShowExtra.ForeColor = Color.White
        Else
            btnShowExtra.BackColor = Me.BackColor
            btnShowExtra.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub btnBackColorChange_Click(sender As Object, e As EventArgs) Handles btnBackColorChange.Click
        If cldBackC.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            lblBC.Text = "Background Color: #" & cldBackC.Color.ToArgb().ToString("X6")
            Dim darkerColor As Color = ControlPaint.Dark(cldBackC.Color)
            Me.BackColor = darkerColor
            lvHistory.BackColor = darkerColor
            txtboxMsg.BackColor = darkerColor
            txtboxResp.BackColor = darkerColor
            Dim lighterColor As Color = ControlPaint.Light(darkerColor)
            pnlExtra.BackColor = lighterColor
            btnShowExtra.BackColor = lighterColor
        End If
    End Sub

    Private Sub ChangeAllTextColors(container As Control, color As Color)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is Control Then
                DirectCast(ctrl, Control).ForeColor = color
            End If
            If ctrl.Controls.Count > 0 Then
                ChangeAllTextColors(ctrl, color)
            End If
        Next
    End Sub

    Private Sub ChangeAllTextFont(container As Control, font As Font)
        For Each ctrl As Control In container.Controls
            If Not Panel1.Contains(ctrl) Then
                If TypeOf ctrl Is Control Then
                    DirectCast(ctrl, Control).Font = New Font(font.FontFamily, ctrl.Font.Size, ctrl.Font.Style)
                End If
                If ctrl.Controls.Count > 0 Then
                    ChangeAllTextFont(ctrl, font)
                End If
            End If
        Next
        lblTFS.Text = "Text Font: " & font.FontFamily.Name
    End Sub

    Private Sub btnTextColorBlack_Click(sender As Object, e As EventArgs) Handles btnTextColorBlack.Click
        lblTC.Text = "Text Color: Black"
        ChangeAllTextColors(Me, Color.Black)
        AdjustBrightness(PictureBox1.Image, -10.0)
    End Sub

    Private Sub btnTextColorGray_Click(sender As Object, e As EventArgs) Handles btnTextColorGray.Click
        If lblTC.Text = "Text Color: Black" Then
            AdjustBrightness(PictureBox1.Image, 0.5)
        ElseIf lblTC.Text = "Text Color: White" Then
            AdjustBrightness(PictureBox1.Image, -0.5)
        End If

        lblTC.Text = "Text Color: Gray"
        ChangeAllTextColors(Me, Color.Gray)
    End Sub

    Private Sub btnTextColorWhite_Click(sender As Object, e As EventArgs) Handles btnTextColorWhite.Click
        lblTC.Text = "Text Color: White"
        ChangeAllTextColors(Me, Color.White)
        AdjustBrightness(PictureBox1.Image, 10.0)
    End Sub

    Private Sub btnFontChange_Click(sender As Object, e As EventArgs) Handles btnFontChange.Click
        If FontDialog1.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            ChangeAllTextFont(Me, FontDialog1.Font)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ChangeAllTextFont(Me, Button1.Font)
        ChangeAllTextColors(Me, Color.White)

        Me.BackColor = Color.FromArgb(25, 25, 25)
        lvHistory.BackColor = Color.FromArgb(25, 25, 25)
        txtboxMsg.BackColor = Color.FromArgb(25, 25, 25)
        txtboxResp.BackColor = Color.FromArgb(25, 25, 25)
        pnlExtra.BackColor = Color.FromArgb(35, 35, 35)
        btnShowExtra.BackColor = Color.FromArgb(35, 35, 35)
        lblTC.Text = "Text Color: White"
        lblBC.Text = "Background Color: #191919"
        AdjustBrightness(PictureBox1.Image, 10.0)
    End Sub

    Private Sub btnStreamline_Click(sender As Object, e As EventArgs) Handles btnStreamline.Click
        streamline = True
        barProgress.Value = barProgress.Maximum
        lblProgress.Text = "Streamlined"
    End Sub

    Private Sub scrollAbout_Scroll(sender As Object, e As ScrollEventArgs) Handles scrollAbout.Scroll
        pnlScrollableAbout.Location = New Point(pnlScrollableAbout.Location.X, 4 - scrollAbout.Value)
    End Sub
End Class
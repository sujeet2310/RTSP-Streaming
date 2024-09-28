Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.InteropServices

Public Class Form1
    ' Import the AnimateWindow function from user32.dll
    <DllImport("user32")>
    Private Shared Function AnimateWindow(ByVal hWnd As IntPtr, ByVal dwTime As Integer, ByVal dwFlags As Integer) As Boolean
    End Function

    ' Animation flags for different effects
    Private Const AW_HOR_POSITIVE As Integer = &H1 ' Slide from left to right
    Private Const AW_HOR_NEGATIVE As Integer = &H2 ' Slide from right to left
    Private Const AW_VER_POSITIVE As Integer = &H4 ' Slide from top to bottom
    Private Const AW_VER_NEGATIVE As Integer = &H8 ' Slide from bottom to top
    Private Const AW_SLIDE As Integer = &H40000 ' Use slide effect
    Private Const AW_CENTER As Integer = &H10 ' Collapse or expand inward
    Private Const AW_HIDE As Integer = &H10000 ' Hide the window
    Private Const AW_ACTIVATE As Integer = &H20000 ' Activate the window
    Private Const AW_BLEND As Integer = &H80000 ' Fade effect

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply fade-in animation for 500 milliseconds
        AnimateWindow(Me.Handle, 400, AW_CENTER)
        pnlSettings.Visible = False
        txtUsername.Text = My.Settings.txtUsernameEdit
        txtPassword.Text = My.Settings.txtPasswordEdit
        txtIPAddress.Text = My.Settings.txtIPaddressEdit
        txtChannel.Text = My.Settings.txtChannelEdit
    End Sub
    Private Sub btnStream_Click(sender As Object, e As EventArgs) Handles btnStream.Click
        Try
            Dim username As String = txtUsername.Text.Trim()
            Dim password As String = txtPassword.Text.Trim()
            Dim ipAddress As String = txtIPAddress.Text.Trim()
            Dim channel As String = txtChannel.Text.Trim()

            ' Construct the RTSP URL using the provided details
            Dim streamURL As String = $"rtsp://{username}:{password}@{ipAddress}/Streaming/Channels/{channel}"

            If String.IsNullOrEmpty(streamURL) Then
                MessageBox.Show("Please enter a valid URL.")
                Return
            End If

            ' Start streaming the camera
            AxVLCPlugin21.playlist.add(streamURL)
            AxVLCPlugin21.playlist.play()
            SetTextBoxProperties(txtStreamURL, "Streaming Started", Color.White, Color.ForestGreen)
            'txtStreamURL.Text = "Streaming Started"
            ' tmrStopStatus.Start()
        Catch ex As Exception
            MessageBox.Show("Error starting stream: " & ex.Message)
        End Try
    End Sub
    Private Sub RefreshStream()
        Try
            ' Stop the current stream
            AxVLCPlugin21.playlist.stop()
            AxVLCPlugin21.playlist.items.clear()
            ' Construct the new RTSP URL
            Dim streamURL As String = $"rtsp://{txtUsername.Text}:{txtPassword.Text}@{txtIPAddress.Text}/Streaming/Channels/{txtChannel.Text}"

            '' Start the stream again with the new URL
            AxVLCPlugin21.playlist.add(streamURL)
            AxVLCPlugin21.playlist.play()
            SetTextBoxProperties(txtStreamURL, "Refresh stream URL", Color.White, Color.ForestGreen)
        Catch ex As Exception
            SetTextBoxProperties(txtStreamURL, "Error refreshing stream: " & ex.Message, Color.White, Color.OrangeRed)
            MessageBox.Show("Error refreshing stream: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCaptureScreenshot_Click(sender As Object, e As EventArgs) Handles btnCaptureScreenshot.Click
        Try

            AxVLCPlugin21.video.takeSnapshot()


            System.Threading.Thread.Sleep(3000)

            ' path to move the screenshot
            Dim targetDirectory As String = Application.StartupPath & "\Screenshots\"
            If Not Directory.Exists(targetDirectory) Then
                Directory.CreateDirectory(targetDirectory)
            End If

            ' Get the debug folder path
            Dim debugFolder As String = Application.StartupPath

            ' Find the latest .bmp file in the debug folder (default format of VLC screenshots)
            Dim latestFile As String = Directory.GetFiles(debugFolder, "*.bmp").OrderByDescending(Function(f) File.GetCreationTime(f)).FirstOrDefault()

            ' If a screenshot was found, move it to the target directory
            If latestFile IsNot Nothing Then
                Dim newFileName As String = "screenshot_" & DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") & ".bmp"
                Dim newFilePath As String = Path.Combine(targetDirectory, newFileName)
                File.Move(latestFile, newFilePath)

                ' txtStreamURL.Text = $"Screenshot saved to: " & newFilePath
                SetTextBoxProperties(txtStreamURL, $"Screenshot saved to: " & newFilePath, Color.White, Color.ForestGreen)
                lblFolderpath.Text = "Screenshot Path: " & Application.StartupPath & "\Screenshots\"
            Else
                SetTextBoxProperties(txtStreamURL, "No screenshot found in the debug folder.", Color.White, Color.OrangeRed)
            End If

        Catch ex As Exception
            SetTextBoxProperties(txtStreamURL, "Error capturing or moving screenshot: " & ex.Message, Color.White, Color.OrangeRed)
        End Try
    End Sub
    Private Sub TextBoxDisabled()
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        txtIPAddress.Enabled = False
        txtChannel.Enabled = False

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.txtUsernameEdit = txtUsername.Text
        My.Settings.txtPasswordEdit = txtPassword.Text
        My.Settings.txtIPaddressEdit = txtIPAddress.Text
        My.Settings.txtChannelEdit = txtChannel.Text
        My.Settings.Save()
        TextBoxDisabled()
        pnlSettings.Visible = False
        SetTextBoxProperties(txtStreamURL, "Settings Saved Successfully. Please Refresh Stream.", Color.White, Color.OrangeRed)
    End Sub
    Private Sub picEdit_Click(sender As Object, e As EventArgs) Handles picEdit.Click
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        txtIPAddress.Enabled = True
        txtChannel.Enabled = True
    End Sub

    Private Sub picSettings_Click(sender As Object, e As EventArgs) Handles picSettings.Click
        TextBoxDisabled()
        If pnlSettings.Visible = False Then
            pnlSettings.Visible = True

        Else pnlSettings.Visible = False

        End If
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshStream()
        SetTextBoxProperties(txtStreamURL, "Stream refreshed Successfully.", Color.White, Color.ForestGreen)
    End Sub

    Private Sub tmrStopStatus_Tick(sender As Object, e As EventArgs) Handles tmrStopStatus.Tick
        tmrStopStatus.Stop()
        txtStreamURL.Text = Nothing
        txtStreamURL.FillColor = Color.White
        txtStreamURL.ForeColor = Color.Black
    End Sub

    Public Sub SetTextBoxProperties(ByRef txtBox As Guna.UI2.WinForms.Guna2TextBox, ByVal textValue As String, ByVal textColor As Color, ByVal backColor As Color)
        txtBox.Text = textValue
        txtBox.ForeColor = textColor
        txtBox.FillColor = backColor
        tmrStopStatus.Start()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Trigger the native Windows animation before the form closes
        'AnimateWindow(Me.Handle, 3000, AW_CENTER) ' 1000ms (1 second), fade out
        ' AnimateWindow(Me.Handle, 1000, AW_HIDE Or AW_SLIDE Or AW_VER_NEGATIVE)
        ' AnimateWindow(Me.Handle, 1000, AW_HIDE Or AW_SLIDE Or AW_VER_POSITIVE)
        AnimateWindow(Me.Handle, 500, AW_HIDE Or AW_SLIDE Or AW_HOR_POSITIVE)


        ' Optionally, delay closing to allow the animation to finish
        ' System.Threading.Thread.Sleep(1000)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim aboutForm As New About()

        Me.Opacity = 0.9

        aboutForm.ShowDialog()


        Me.Opacity = 1.0
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' Get the application path
        Dim appPath As String = Application.StartupPath & "\Screenshots\"

        ' Open the application folder in Windows Explorer
        Process.Start("explorer.exe", appPath)
    End Sub

End Class


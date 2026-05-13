Imports System.IO
Imports System.Text
Public Class Main
    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        If SplitRadioButton.Checked Then
            Dim OpenFileResult As DialogResult = OpenFileDialog1.ShowDialog
            If OpenFileResult = DialogResult.OK Then
                FileTextBox.Text = OpenFileDialog1.FileName
            End If
        Else
            Dim OpenFileResult As DialogResult = OpenFileDialog2.ShowDialog
            If OpenFileResult = DialogResult.OK Then
                FileTextBox.Text = OpenFileDialog2.FileName
            End If
        End If
    End Sub
    Private Sub SplitButton_Click(sender As Object, e As EventArgs) Handles SplitButton.Click
        Enabled = False
        UseWaitCursor = True
        ProgressBar.Value = 0
        ProgressBar.Visible = True
        Application.DoEvents()
        If SplitRadioButton.Checked Then
            Dim SplitSizeInMB As ULong = SplitSize.Value * 1024000
            Try
                Dim FileLength As ULong = New FileInfo(FileTextBox.Text).Length
                ProgressBar.Maximum = FileLength
                Application.DoEvents()
                Using FileReader As New StreamReader(FileTextBox.Text, Encoding.Default)
                    For i = 1 To Integer.MaxValue
                        Using FileWriter As New StreamWriter(FileTextBox.Text & ".s" & i.ToString("000"), False, Encoding.Default)
                            If FileLength >= SplitSizeInMB Then
                                Dim ContentBuffer(SplitSizeInMB - 1) As Char
                                FileReader.Read(ContentBuffer, 0, SplitSizeInMB)
                                FileWriter.Write(New String(ContentBuffer))
                                FileLength -= SplitSizeInMB
                                ProgressBar.Value += SplitSizeInMB
                                Application.DoEvents()
                            Else
                                Dim ContentBuffer(FileLength - 1) As Char
                                FileReader.Read(ContentBuffer, 0, FileLength)
                                FileWriter.Write(New String(ContentBuffer))
                                ProgressBar.Value += FileLength
                                Application.DoEvents()
                                Exit For
                            End If
                            FileWriter.Flush()
                            FileWriter.Close()
                        End Using
                    Next
                End Using
                File.Delete(FileTextBox.Text)
            Catch
            End Try
        Else
            Dim FileName As String = FileTextBox.Text.Replace(".s001", "")
            Dim Append As Boolean = False
            Try
                For i = 1 To Integer.MaxValue
                    If File.Exists(FileName & ".s" & i.ToString("000")) Then
                        Dim FileLength As ULong = New FileInfo(FileName & ".s" & i.ToString("000")).Length
                        ProgressBar.Value = 0
                        ProgressBar.Maximum = FileLength
                        ProgressBar.Visible = True
                        Application.DoEvents()
                        If i = 1 Then
                            Append = False
                        Else
                            Append = True
                        End If
                        Using FileWriter As New StreamWriter(FileName, Append, Encoding.Default)
                            FileWriter.Write(File.ReadAllText(FileName & ".s" & i.ToString("000"), Encoding.Default))
                            FileWriter.Flush()
                            FileWriter.Close()
                        End Using
                        File.Delete(FileName & ".s" & i.ToString("000"))
                        ProgressBar.Value = FileLength
                        Application.DoEvents()
                    Else
                        Exit For
                    End If
                Next
            Catch
            End Try
        End If
        ProgressBar.Value = 0
        ProgressBar.Visible = False
        UseWaitCursor = False
        Enabled = True
        Application.DoEvents()
    End Sub
    Private Sub SplitRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SplitRadioButton.CheckedChanged
        If SplitRadioButton.Checked Then
            FileTextBox.Text = ""
            JoinRadioButton.Checked = False
            SplitLabel.Visible = True
            SplitSize.Visible = True
            SplitMBLabel.Visible = True
            SplitButton.Text = "Split"
        End If
    End Sub
    Private Sub JoinRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles JoinRadioButton.CheckedChanged
        If JoinRadioButton.Checked Then
            FileTextBox.Text = ""
            SplitRadioButton.Checked = False
            SplitLabel.Visible = False
            SplitSize.Visible = False
            SplitMBLabel.Visible = False
            SplitButton.Text = "Join"
        End If
    End Sub

    Private Sub FileTextBox_TextChanged(sender As Object, e As EventArgs) Handles FileTextBox.TextChanged
        Try
            If File.Exists(FileTextBox.Text) Then
                SplitButton.Enabled = True
            Else
                SplitButton.Enabled = False
            End If
        Catch
            SplitButton.Enabled = False
        End Try
    End Sub
End Class

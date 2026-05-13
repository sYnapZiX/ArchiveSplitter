<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FileTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SplitLabel = New System.Windows.Forms.Label()
        Me.SplitSize = New System.Windows.Forms.NumericUpDown()
        Me.SplitMBLabel = New System.Windows.Forms.Label()
        Me.SplitButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SplitRadioButton = New System.Windows.Forms.RadioButton()
        Me.JoinRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.SplitSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileTextBox
        '
        Me.FileTextBox.Location = New System.Drawing.Point(76, 20)
        Me.FileTextBox.Name = "FileTextBox"
        Me.FileTextBox.Size = New System.Drawing.Size(251, 20)
        Me.FileTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Archive:"
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(333, 19)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.BrowseButton.TabIndex = 2
        Me.BrowseButton.Text = "Browse..."
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "ZIP Archive|*.zip"
        Me.OpenFileDialog1.Title = "Select the archive you want to split..."
        '
        'SplitLabel
        '
        Me.SplitLabel.AutoSize = True
        Me.SplitLabel.Location = New System.Drawing.Point(11, 52)
        Me.SplitLabel.Name = "SplitLabel"
        Me.SplitLabel.Size = New System.Drawing.Size(48, 13)
        Me.SplitLabel.TabIndex = 3
        Me.SplitLabel.Text = "Splitsize:"
        '
        'SplitSize
        '
        Me.SplitSize.Location = New System.Drawing.Point(76, 50)
        Me.SplitSize.Maximum = New Decimal(New Integer() {128000, 0, 0, 0})
        Me.SplitSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SplitSize.Name = "SplitSize"
        Me.SplitSize.Size = New System.Drawing.Size(60, 20)
        Me.SplitSize.TabIndex = 4
        Me.SplitSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SplitSize.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'SplitMBLabel
        '
        Me.SplitMBLabel.AutoSize = True
        Me.SplitMBLabel.Location = New System.Drawing.Point(142, 52)
        Me.SplitMBLabel.Name = "SplitMBLabel"
        Me.SplitMBLabel.Size = New System.Drawing.Size(23, 13)
        Me.SplitMBLabel.TabIndex = 5
        Me.SplitMBLabel.Text = "MB"
        '
        'SplitButton
        '
        Me.SplitButton.Location = New System.Drawing.Point(333, 47)
        Me.SplitButton.Name = "SplitButton"
        Me.SplitButton.Size = New System.Drawing.Size(75, 23)
        Me.SplitButton.TabIndex = 6
        Me.SplitButton.Text = "Split"
        Me.SplitButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Filter = "Split-File|*.s001"
        Me.OpenFileDialog2.Title = "Select the archive you want to join..."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProgressBar)
        Me.GroupBox1.Controls.Add(Me.SplitRadioButton)
        Me.GroupBox1.Controls.Add(Me.JoinRadioButton)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.FileTextBox)
        Me.GroupBox1.Controls.Add(Me.SplitButton)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SplitMBLabel)
        Me.GroupBox1.Controls.Add(Me.BrowseButton)
        Me.GroupBox1.Controls.Add(Me.SplitSize)
        Me.GroupBox1.Controls.Add(Me.SplitLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 84)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mode:"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(76, 20)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(250, 20)
        Me.ProgressBar.TabIndex = 10
        Me.ProgressBar.Visible = False
        '
        'SplitRadioButton
        '
        Me.SplitRadioButton.AutoSize = True
        Me.SplitRadioButton.Checked = True
        Me.SplitRadioButton.Location = New System.Drawing.Point(83, -2)
        Me.SplitRadioButton.Name = "SplitRadioButton"
        Me.SplitRadioButton.Size = New System.Drawing.Size(45, 17)
        Me.SplitRadioButton.TabIndex = 8
        Me.SplitRadioButton.TabStop = True
        Me.SplitRadioButton.Text = "Split"
        Me.SplitRadioButton.UseVisualStyleBackColor = True
        '
        'JoinRadioButton
        '
        Me.JoinRadioButton.AutoSize = True
        Me.JoinRadioButton.Location = New System.Drawing.Point(149, -2)
        Me.JoinRadioButton.Name = "JoinRadioButton"
        Me.JoinRadioButton.Size = New System.Drawing.Size(44, 17)
        Me.JoinRadioButton.TabIndex = 9
        Me.JoinRadioButton.Text = "Join"
        Me.JoinRadioButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "                                 "
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 109)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArchiveSplitter"
        CType(Me.SplitSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FileTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BrowseButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SplitLabel As Label
    Friend WithEvents SplitSize As NumericUpDown
    Friend WithEvents SplitMBLabel As Label
    Friend WithEvents SplitButton As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SplitRadioButton As RadioButton
    Friend WithEvents JoinRadioButton As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents ProgressBar As ProgressBar
End Class

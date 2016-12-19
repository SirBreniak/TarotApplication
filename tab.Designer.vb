<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tab
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tab))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(938, 553)
        Me.WebBrowser1.TabIndex = 17
        Me.WebBrowser1.Visible = False
        '
        'Close
        '
        Me.Close.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close.Font = New System.Drawing.Font("Kristen ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close.ForeColor = System.Drawing.Color.Red
        Me.Close.Location = New System.Drawing.Point(832, 518)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(94, 35)
        Me.Close.TabIndex = 18
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = False
        '
        'tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 553)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tab"
        Me.Text = "Major Arcana"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Close As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnPapar = New System.Windows.Forms.Button()
        Me.lblTeks = New System.Windows.Forms.Label()
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BtnPapar
        '
        Me.BtnPapar.Location = New System.Drawing.Point(80, 124)
        Me.BtnPapar.Name = "BtnPapar"
        Me.BtnPapar.Size = New System.Drawing.Size(75, 23)
        Me.BtnPapar.TabIndex = 0
        Me.BtnPapar.Text = "Button1"
        Me.BtnPapar.UseVisualStyleBackColor = True
        '
        'lblTeks
        '
        Me.lblTeks.AutoSize = True
        Me.lblTeks.Location = New System.Drawing.Point(31, 9)
        Me.lblTeks.Name = "lblTeks"
        Me.lblTeks.Size = New System.Drawing.Size(41, 15)
        Me.lblTeks.TabIndex = 1
        Me.lblTeks.Text = "Label1"
        '
        'lstBox
        '
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.ItemHeight = 15
        Me.lstBox.Location = New System.Drawing.Point(285, 94)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(127, 154)
        Me.lstBox.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstBox)
        Me.Controls.Add(Me.lblTeks)
        Me.Controls.Add(Me.BtnPapar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnPapar As Button
    Friend WithEvents lblTeks As Label
    Friend WithEvents lstBox As ListBox
End Class

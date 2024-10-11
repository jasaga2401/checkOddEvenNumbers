<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnOddEvenNumbers = New System.Windows.Forms.Button()
        Me.txtCheckOddEven = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnOddEvenNumbers
        '
        Me.btnOddEvenNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOddEvenNumbers.Location = New System.Drawing.Point(222, 239)
        Me.btnOddEvenNumbers.Name = "btnOddEvenNumbers"
        Me.btnOddEvenNumbers.Size = New System.Drawing.Size(327, 74)
        Me.btnOddEvenNumbers.TabIndex = 0
        Me.btnOddEvenNumbers.Text = "Odd or Even?"
        Me.btnOddEvenNumbers.UseVisualStyleBackColor = True
        '
        'txtCheckOddEven
        '
        Me.txtCheckOddEven.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckOddEven.Location = New System.Drawing.Point(222, 181)
        Me.txtCheckOddEven.Name = "txtCheckOddEven"
        Me.txtCheckOddEven.Size = New System.Drawing.Size(327, 38)
        Me.txtCheckOddEven.TabIndex = 1
        Me.txtCheckOddEven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtCheckOddEven)
        Me.Controls.Add(Me.btnOddEvenNumbers)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOddEvenNumbers As Button
    Friend WithEvents txtCheckOddEven As TextBox
End Class

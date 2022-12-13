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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.single_btn = New System.Windows.Forms.RadioButton()
        Me.double_btn = New System.Windows.Forms.RadioButton()
        Me.integer_btn = New System.Windows.Forms.RadioButton()
        Me.long_btn = New System.Windows.Forms.RadioButton()
        Me.currency_btn = New System.Windows.Forms.RadioButton()
        Me.string_btn = New System.Windows.Forms.RadioButton()
        Me.boolean_btn = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select DataType"
        '
        'single_btn
        '
        Me.single_btn.AutoSize = True
        Me.single_btn.Location = New System.Drawing.Point(12, 60)
        Me.single_btn.Name = "single_btn"
        Me.single_btn.Size = New System.Drawing.Size(54, 17)
        Me.single_btn.TabIndex = 1
        Me.single_btn.TabStop = True
        Me.single_btn.Text = "Single"
        Me.single_btn.UseVisualStyleBackColor = True
        '
        'double_btn
        '
        Me.double_btn.AutoSize = True
        Me.double_btn.Location = New System.Drawing.Point(12, 83)
        Me.double_btn.Name = "double_btn"
        Me.double_btn.Size = New System.Drawing.Size(59, 17)
        Me.double_btn.TabIndex = 2
        Me.double_btn.TabStop = True
        Me.double_btn.Text = "Double"
        Me.double_btn.UseVisualStyleBackColor = True
        '
        'integer_btn
        '
        Me.integer_btn.AutoSize = True
        Me.integer_btn.Location = New System.Drawing.Point(12, 106)
        Me.integer_btn.Name = "integer_btn"
        Me.integer_btn.Size = New System.Drawing.Size(58, 17)
        Me.integer_btn.TabIndex = 3
        Me.integer_btn.TabStop = True
        Me.integer_btn.Text = "Integer"
        Me.integer_btn.UseVisualStyleBackColor = True
        '
        'long_btn
        '
        Me.long_btn.AutoSize = True
        Me.long_btn.Location = New System.Drawing.Point(12, 129)
        Me.long_btn.Name = "long_btn"
        Me.long_btn.Size = New System.Drawing.Size(49, 17)
        Me.long_btn.TabIndex = 4
        Me.long_btn.TabStop = True
        Me.long_btn.Text = "Long"
        Me.long_btn.UseVisualStyleBackColor = True
        '
        'currency_btn
        '
        Me.currency_btn.AutoSize = True
        Me.currency_btn.Location = New System.Drawing.Point(12, 152)
        Me.currency_btn.Name = "currency_btn"
        Me.currency_btn.Size = New System.Drawing.Size(67, 17)
        Me.currency_btn.TabIndex = 5
        Me.currency_btn.TabStop = True
        Me.currency_btn.Text = "Currency"
        Me.currency_btn.UseVisualStyleBackColor = True
        '
        'string_btn
        '
        Me.string_btn.AutoSize = True
        Me.string_btn.Location = New System.Drawing.Point(12, 175)
        Me.string_btn.Name = "string_btn"
        Me.string_btn.Size = New System.Drawing.Size(52, 17)
        Me.string_btn.TabIndex = 6
        Me.string_btn.TabStop = True
        Me.string_btn.Text = "String"
        Me.string_btn.UseVisualStyleBackColor = True
        '
        'boolean_btn
        '
        Me.boolean_btn.AutoSize = True
        Me.boolean_btn.Location = New System.Drawing.Point(12, 198)
        Me.boolean_btn.Name = "boolean_btn"
        Me.boolean_btn.Size = New System.Drawing.Size(64, 17)
        Me.boolean_btn.TabIndex = 7
        Me.boolean_btn.TabStop = True
        Me.boolean_btn.Text = "Boolean"
        Me.boolean_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 331)
        Me.Controls.Add(Me.boolean_btn)
        Me.Controls.Add(Me.string_btn)
        Me.Controls.Add(Me.currency_btn)
        Me.Controls.Add(Me.long_btn)
        Me.Controls.Add(Me.integer_btn)
        Me.Controls.Add(Me.double_btn)
        Me.Controls.Add(Me.single_btn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents single_btn As RadioButton
    Friend WithEvents double_btn As RadioButton
    Friend WithEvents integer_btn As RadioButton
    Friend WithEvents long_btn As RadioButton
    Friend WithEvents currency_btn As RadioButton
    Friend WithEvents string_btn As RadioButton
    Friend WithEvents boolean_btn As RadioButton
End Class

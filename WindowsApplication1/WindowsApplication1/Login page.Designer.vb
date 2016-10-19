<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lb3 = New System.Windows.Forms.Label()
        Me.lb2 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb3
        '
        Me.lb3.AutoSize = True
        Me.lb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb3.Location = New System.Drawing.Point(154, 217)
        Me.lb3.Name = "lb3"
        Me.lb3.Size = New System.Drawing.Size(89, 20)
        Me.lb3.TabIndex = 0
        Me.lb3.Text = "User Name"
        '
        'lb2
        '
        Me.lb2.AutoSize = True
        Me.lb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb2.Location = New System.Drawing.Point(154, 270)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(78, 20)
        Me.lb2.TabIndex = 1
        Me.lb2.Text = "Password"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(302, 217)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(199, 20)
        Me.txt1.TabIndex = 2
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(302, 270)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(199, 20)
        Me.txt2.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(252, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Green
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(393, 392)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(116, 49)
        Me.btn2.TabIndex = 5
        Me.btn2.Text = "Submit"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(657, 509)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lb2)
        Me.Controls.Add(Me.lb3)
        Me.Name = "Form2"
        Me.Text = "Login Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb3 As System.Windows.Forms.Label
    Friend WithEvents lb2 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn2 As System.Windows.Forms.Button
End Class

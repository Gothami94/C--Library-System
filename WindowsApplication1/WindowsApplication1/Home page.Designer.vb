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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lb1 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb1
        '
        Me.lb1.BackColor = System.Drawing.Color.Navy
        Me.lb1.Font = New System.Drawing.Font("Verdana", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb1.Location = New System.Drawing.Point(1, -2)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(609, 94)
        Me.lb1.TabIndex = 0
        Me.lb1.Text = "Library Management System"
        Me.lb1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.ForestGreen
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(387, 384)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(121, 47)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "Log In"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(609, 505)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lb1)
        Me.Name = "Form1"
        Me.Text = "UCSC LIBRARY"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lb1 As System.Windows.Forms.Label
    Friend WithEvents btn1 As System.Windows.Forms.Button

End Class

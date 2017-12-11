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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btn_proxima = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.tb_tentativas = New System.Windows.Forms.TextBox()
        Me.btn_reiniciar = New System.Windows.Forms.Button()
        Me.lbl_tentativas = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Amarelo", "Azul", "Laranja", "Rosa", "Roxo", "Verde"})
        Me.ListBox1.Location = New System.Drawing.Point(50, 78)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 1
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"Amarelo", "Azul", "Laranja", "Rosa", "Roxo", "Verde"})
        Me.ListBox2.Location = New System.Drawing.Point(227, 78)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.Sorted = True
        Me.ListBox2.TabIndex = 2
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Items.AddRange(New Object() {"Amarelo", "Azul", "Laranja", "Rosa", "Roxo", "Verde"})
        Me.ListBox3.Location = New System.Drawing.Point(399, 78)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 95)
        Me.ListBox3.Sorted = True
        Me.ListBox3.TabIndex = 3
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Items.AddRange(New Object() {"Amarelo", "Azul", "Laranja", "Rosa", "Roxo", "Verde"})
        Me.ListBox4.Location = New System.Drawing.Point(572, 78)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(120, 95)
        Me.ListBox4.Sorted = True
        Me.ListBox4.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(50, 245)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(118, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(227, 245)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(118, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(399, 245)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(118, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(572, 245)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(118, 20)
        Me.TextBox4.TabIndex = 8
        '
        'btn_proxima
        '
        Me.btn_proxima.Location = New System.Drawing.Point(62, 363)
        Me.btn_proxima.Name = "btn_proxima"
        Me.btn_proxima.Size = New System.Drawing.Size(148, 51)
        Me.btn_proxima.TabIndex = 10
        Me.btn_proxima.Text = "&Proxima Tentativa"
        Me.btn_proxima.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(371, 477)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(148, 51)
        Me.btn_sair.TabIndex = 11
        Me.btn_sair.Text = "&Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'tb_tentativas
        '
        Me.tb_tentativas.Location = New System.Drawing.Point(552, 377)
        Me.tb_tentativas.Name = "tb_tentativas"
        Me.tb_tentativas.ReadOnly = True
        Me.tb_tentativas.Size = New System.Drawing.Size(100, 20)
        Me.tb_tentativas.TabIndex = 12
        '
        'btn_reiniciar
        '
        Me.btn_reiniciar.Location = New System.Drawing.Point(161, 477)
        Me.btn_reiniciar.Name = "btn_reiniciar"
        Me.btn_reiniciar.Size = New System.Drawing.Size(148, 51)
        Me.btn_reiniciar.TabIndex = 13
        Me.btn_reiniciar.Text = "&Reiniciar"
        Me.btn_reiniciar.UseVisualStyleBackColor = True
        '
        'lbl_tentativas
        '
        Me.lbl_tentativas.AutoSize = True
        Me.lbl_tentativas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tentativas.Location = New System.Drawing.Point(427, 380)
        Me.lbl_tentativas.Name = "lbl_tentativas"
        Me.lbl_tentativas.Size = New System.Drawing.Size(78, 17)
        Me.lbl_tentativas.TabIndex = 14
        Me.lbl_tentativas.Text = "Tentativas:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 550)
        Me.Controls.Add(Me.lbl_tentativas)
        Me.Controls.Add(Me.btn_reiniciar)
        Me.Controls.Add(Me.tb_tentativas)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_proxima)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Mastermind"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btn_proxima As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents tb_tentativas As TextBox
    Friend WithEvents btn_reiniciar As Button
    Friend WithEvents lbl_tentativas As Label
End Class

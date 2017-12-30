<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Account
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Account))
        Me.Lbl_camaro = New System.Windows.Forms.Label()
        Me.Lbl_Ibiza = New System.Windows.Forms.Label()
        Me.lbl_jaguar = New System.Windows.Forms.Label()
        Me.Lbl_AudiTT = New System.Windows.Forms.Label()
        Me.lbl_masseratti = New System.Windows.Forms.Label()
        Me.Lbl_name = New System.Windows.Forms.Label()
        Me.Btn_buy = New System.Windows.Forms.Button()
        Me.Lbl_account = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Pic_jaguar = New System.Windows.Forms.PictureBox()
        Me.pic_audi = New System.Windows.Forms.PictureBox()
        Me.Pic_telsa = New System.Windows.Forms.PictureBox()
        Me.pic_ibiza = New System.Windows.Forms.PictureBox()
        Me.Pic_mustang = New System.Windows.Forms.PictureBox()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.lbl_carroscomprados = New System.Windows.Forms.Label()
        Me.btn_delivery = New System.Windows.Forms.Button()
        CType(Me.Pic_jaguar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_audi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_telsa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_ibiza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_mustang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_camaro
        '
        Me.Lbl_camaro.AutoSize = True
        Me.Lbl_camaro.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_camaro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lbl_camaro.Location = New System.Drawing.Point(12, 178)
        Me.Lbl_camaro.Name = "Lbl_camaro"
        Me.Lbl_camaro.Size = New System.Drawing.Size(249, 26)
        Me.Lbl_camaro.TabIndex = 22
        Me.Lbl_camaro.Text = "The all american is still the champ of all muscle cars" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Camaro."
        '
        'Lbl_Ibiza
        '
        Me.Lbl_Ibiza.AutoSize = True
        Me.Lbl_Ibiza.Location = New System.Drawing.Point(177, 89)
        Me.Lbl_Ibiza.Name = "Lbl_Ibiza"
        Me.Lbl_Ibiza.Size = New System.Drawing.Size(222, 13)
        Me.Lbl_Ibiza.TabIndex = 21
        Me.Lbl_Ibiza.Text = "For a small yet elgant choice, Ibiza awaits you"
        '
        'lbl_jaguar
        '
        Me.lbl_jaguar.AutoSize = True
        Me.lbl_jaguar.Location = New System.Drawing.Point(164, 89)
        Me.lbl_jaguar.Name = "lbl_jaguar"
        Me.lbl_jaguar.Size = New System.Drawing.Size(371, 26)
        Me.lbl_jaguar.TabIndex = 20
        Me.lbl_jaguar.Text = "Jaguar brings to you the elegance combined with the power in one single car," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jag" & _
    "uar F Type."
        '
        'Lbl_AudiTT
        '
        Me.Lbl_AudiTT.AutoSize = True
        Me.Lbl_AudiTT.Location = New System.Drawing.Point(261, 372)
        Me.Lbl_AudiTT.Name = "Lbl_AudiTT"
        Me.Lbl_AudiTT.Size = New System.Drawing.Size(394, 13)
        Me.Lbl_AudiTT.TabIndex = 19
        Me.Lbl_AudiTT.Text = "Our best sports car yet, the Audi TT, offering up to 420 HP and a magnific exteri" & _
    "or."
        '
        'lbl_masseratti
        '
        Me.lbl_masseratti.AutoSize = True
        Me.lbl_masseratti.Location = New System.Drawing.Point(12, 359)
        Me.lbl_masseratti.Name = "lbl_masseratti"
        Me.lbl_masseratti.Size = New System.Drawing.Size(332, 26)
        Me.lbl_masseratti.TabIndex = 18
        Me.lbl_masseratti.Text = "Tesla offering the best quality in technology and confort since 2003.  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tesla mo" & _
    "del S"
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.Location = New System.Drawing.Point(46, 50)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(84, 13)
        Me.Lbl_name.TabIndex = 17
        Me.Lbl_name.Text = "Hello, NOMBRE"
        '
        'Btn_buy
        '
        Me.Btn_buy.BackColor = System.Drawing.Color.Maroon
        Me.Btn_buy.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_buy.Location = New System.Drawing.Point(527, 31)
        Me.Btn_buy.Name = "Btn_buy"
        Me.Btn_buy.Size = New System.Drawing.Size(108, 50)
        Me.Btn_buy.TabIndex = 15
        Me.Btn_buy.Text = "Browse cars"
        Me.Btn_buy.UseVisualStyleBackColor = False
        '
        'Lbl_account
        '
        Me.Lbl_account.AutoSize = True
        Me.Lbl_account.Location = New System.Drawing.Point(46, 15)
        Me.Lbl_account.Name = "Lbl_account"
        Me.Lbl_account.Size = New System.Drawing.Size(64, 13)
        Me.Lbl_account.TabIndex = 14
        Me.Lbl_account.Text = "My Account"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'Timer5
        '
        '
        'Pic_jaguar
        '
        Me.Pic_jaguar.Image = CType(resources.GetObject("Pic_jaguar.Image"), System.Drawing.Image)
        Me.Pic_jaguar.Location = New System.Drawing.Point(-1, 0)
        Me.Pic_jaguar.Name = "Pic_jaguar"
        Me.Pic_jaguar.Size = New System.Drawing.Size(683, 419)
        Me.Pic_jaguar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_jaguar.TabIndex = 27
        Me.Pic_jaguar.TabStop = False
        '
        'pic_audi
        '
        Me.pic_audi.Image = CType(resources.GetObject("pic_audi.Image"), System.Drawing.Image)
        Me.pic_audi.Location = New System.Drawing.Point(-1, 0)
        Me.pic_audi.Name = "pic_audi"
        Me.pic_audi.Size = New System.Drawing.Size(683, 419)
        Me.pic_audi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_audi.TabIndex = 23
        Me.pic_audi.TabStop = False
        '
        'Pic_telsa
        '
        Me.Pic_telsa.Image = CType(resources.GetObject("Pic_telsa.Image"), System.Drawing.Image)
        Me.Pic_telsa.Location = New System.Drawing.Point(-1, 0)
        Me.Pic_telsa.Name = "Pic_telsa"
        Me.Pic_telsa.Size = New System.Drawing.Size(683, 419)
        Me.Pic_telsa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_telsa.TabIndex = 26
        Me.Pic_telsa.TabStop = False
        '
        'pic_ibiza
        '
        Me.pic_ibiza.Image = CType(resources.GetObject("pic_ibiza.Image"), System.Drawing.Image)
        Me.pic_ibiza.Location = New System.Drawing.Point(-1, 0)
        Me.pic_ibiza.Name = "pic_ibiza"
        Me.pic_ibiza.Size = New System.Drawing.Size(683, 419)
        Me.pic_ibiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_ibiza.TabIndex = 25
        Me.pic_ibiza.TabStop = False
        '
        'Pic_mustang
        '
        Me.Pic_mustang.Image = CType(resources.GetObject("Pic_mustang.Image"), System.Drawing.Image)
        Me.Pic_mustang.Location = New System.Drawing.Point(-1, 0)
        Me.Pic_mustang.Name = "Pic_mustang"
        Me.Pic_mustang.Size = New System.Drawing.Size(683, 419)
        Me.Pic_mustang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_mustang.TabIndex = 24
        Me.Pic_mustang.TabStop = False
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.Maroon
        Me.BtnLogout.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnLogout.Location = New System.Drawing.Point(547, 325)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(121, 35)
        Me.BtnLogout.TabIndex = 28
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'lbl_carroscomprados
        '
        Me.lbl_carroscomprados.AutoSize = True
        Me.lbl_carroscomprados.Location = New System.Drawing.Point(237, 15)
        Me.lbl_carroscomprados.Name = "lbl_carroscomprados"
        Me.lbl_carroscomprados.Size = New System.Drawing.Size(54, 13)
        Me.lbl_carroscomprados.TabIndex = 30
        Me.lbl_carroscomprados.Text = "NUMBER"
        '
        'btn_delivery
        '
        Me.btn_delivery.BackColor = System.Drawing.Color.Maroon
        Me.btn_delivery.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_delivery.Location = New System.Drawing.Point(136, 7)
        Me.btn_delivery.Name = "btn_delivery"
        Me.btn_delivery.Size = New System.Drawing.Size(95, 28)
        Me.btn_delivery.TabIndex = 32
        Me.btn_delivery.Text = "Cars on delivery"
        Me.btn_delivery.UseVisualStyleBackColor = False
        '
        'Frm_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 416)
        Me.Controls.Add(Me.btn_delivery)
        Me.Controls.Add(Me.lbl_carroscomprados)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.Lbl_camaro)
        Me.Controls.Add(Me.Lbl_Ibiza)
        Me.Controls.Add(Me.lbl_jaguar)
        Me.Controls.Add(Me.Lbl_AudiTT)
        Me.Controls.Add(Me.lbl_masseratti)
        Me.Controls.Add(Me.Lbl_name)
        Me.Controls.Add(Me.Btn_buy)
        Me.Controls.Add(Me.Lbl_account)
        Me.Controls.Add(Me.Pic_jaguar)
        Me.Controls.Add(Me.pic_audi)
        Me.Controls.Add(Me.Pic_telsa)
        Me.Controls.Add(Me.pic_ibiza)
        Me.Controls.Add(Me.Pic_mustang)
        Me.Name = "Frm_Account"
        Me.Text = "My Account"
        CType(Me.Pic_jaguar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_audi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_telsa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_ibiza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_mustang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_camaro As System.Windows.Forms.Label
    Friend WithEvents Lbl_Ibiza As System.Windows.Forms.Label
    Friend WithEvents lbl_jaguar As System.Windows.Forms.Label
    Friend WithEvents Lbl_AudiTT As System.Windows.Forms.Label
    Friend WithEvents lbl_masseratti As System.Windows.Forms.Label
    Friend WithEvents Lbl_name As System.Windows.Forms.Label
    Friend WithEvents Btn_buy As System.Windows.Forms.Button
    Friend WithEvents Lbl_account As System.Windows.Forms.Label
    Friend WithEvents pic_audi As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_mustang As System.Windows.Forms.PictureBox
    Friend WithEvents pic_ibiza As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_telsa As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_jaguar As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents lbl_carroscomprados As System.Windows.Forms.Label
    Friend WithEvents btn_delivery As System.Windows.Forms.Button
End Class

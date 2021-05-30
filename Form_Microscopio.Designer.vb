<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Microscopio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Microscopio))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox_Camara = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Button_Capturar = New System.Windows.Forms.ToolStripButton()
        Me.Button_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Button_CapturarCamara = New System.Windows.Forms.Button()
        Me.Timer_Cam = New System.Windows.Forms.Timer(Me.components)
        Me.Button_CapurarIntantanea = New System.Windows.Forms.Button()
        Me.GroupBox_Camara = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Resolucion = New System.Windows.Forms.ComboBox()
        Me.TextBox_TiempoFotos = New System.Windows.Forms.TextBox()
        Me.TextBox_ResolucionAlto = New System.Windows.Forms.TextBox()
        Me.Label_Resolucion = New System.Windows.Forms.Label()
        Me.TextBox_ResolucionAncho = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label_TiempoActulizacion = New System.Windows.Forms.Label()
        Me.TextBoxl_TiempoActulizacion = New System.Windows.Forms.TextBox()
        Me.Button_PararCam = New System.Windows.Forms.Button()
        Me.Label_TiempoFotos = New System.Windows.Forms.Label()
        Me.Button_IniciarCam = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox_Camara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox_Camara.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 531)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1137, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'PictureBox_Camara
        '
        Me.PictureBox_Camara.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Camara.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_Camara.Location = New System.Drawing.Point(12, 37)
        Me.PictureBox_Camara.Name = "PictureBox_Camara"
        Me.PictureBox_Camara.Size = New System.Drawing.Size(640, 480)
        Me.PictureBox_Camara.TabIndex = 1
        Me.PictureBox_Camara.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Button_Capturar, Me.Button_Grabar, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1137, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Button_Capturar
        '
        Me.Button_Capturar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Capturar.Image = CType(resources.GetObject("Button_Capturar.Image"), System.Drawing.Image)
        Me.Button_Capturar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Capturar.Name = "Button_Capturar"
        Me.Button_Capturar.Size = New System.Drawing.Size(23, 22)
        Me.Button_Capturar.Text = "Capturar"
        '
        'Button_Grabar
        '
        Me.Button_Grabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button_Grabar.Image = CType(resources.GetObject("Button_Grabar.Image"), System.Drawing.Image)
        Me.Button_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button_Grabar.Name = "Button_Grabar"
        Me.Button_Grabar.Size = New System.Drawing.Size(23, 22)
        Me.Button_Grabar.Text = "Grabar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Button_CapturarCamara
        '
        Me.Button_CapturarCamara.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_CapturarCamara.Location = New System.Drawing.Point(658, 37)
        Me.Button_CapturarCamara.Name = "Button_CapturarCamara"
        Me.Button_CapturarCamara.Size = New System.Drawing.Size(130, 30)
        Me.Button_CapturarCamara.TabIndex = 3
        Me.Button_CapturarCamara.Text = "Capturar"
        Me.Button_CapturarCamara.UseVisualStyleBackColor = True
        '
        'Timer_Cam
        '
        Me.Timer_Cam.Interval = 250
        '
        'Button_CapurarIntantanea
        '
        Me.Button_CapurarIntantanea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_CapurarIntantanea.Location = New System.Drawing.Point(658, 76)
        Me.Button_CapurarIntantanea.Name = "Button_CapurarIntantanea"
        Me.Button_CapurarIntantanea.Size = New System.Drawing.Size(130, 30)
        Me.Button_CapurarIntantanea.TabIndex = 4
        Me.Button_CapurarIntantanea.Text = "Intantanea"
        Me.Button_CapurarIntantanea.UseVisualStyleBackColor = True
        '
        'GroupBox_Camara
        '
        Me.GroupBox_Camara.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Camara.Controls.Add(Me.ComboBox_Resolucion)
        Me.GroupBox_Camara.Controls.Add(Me.TextBox_TiempoFotos)
        Me.GroupBox_Camara.Controls.Add(Me.TextBox_ResolucionAlto)
        Me.GroupBox_Camara.Controls.Add(Me.Label_Resolucion)
        Me.GroupBox_Camara.Controls.Add(Me.TextBox_ResolucionAncho)
        Me.GroupBox_Camara.Controls.Add(Me.Button1)
        Me.GroupBox_Camara.Controls.Add(Me.Label_TiempoActulizacion)
        Me.GroupBox_Camara.Controls.Add(Me.TextBoxl_TiempoActulizacion)
        Me.GroupBox_Camara.Controls.Add(Me.Button_PararCam)
        Me.GroupBox_Camara.Controls.Add(Me.Label_TiempoFotos)
        Me.GroupBox_Camara.Controls.Add(Me.Button_IniciarCam)
        Me.GroupBox_Camara.Location = New System.Drawing.Point(658, 112)
        Me.GroupBox_Camara.Name = "GroupBox_Camara"
        Me.GroupBox_Camara.Size = New System.Drawing.Size(392, 125)
        Me.GroupBox_Camara.TabIndex = 29
        Me.GroupBox_Camara.TabStop = False
        Me.GroupBox_Camara.Text = "Camara"
        '
        'ComboBox_Resolucion
        '
        Me.ComboBox_Resolucion.FormattingEnabled = True
        Me.ComboBox_Resolucion.Items.AddRange(New Object() {"2592·1944", "1920·1080", "1280·720", "640·480"})
        Me.ComboBox_Resolucion.Location = New System.Drawing.Point(135, 20)
        Me.ComboBox_Resolucion.Name = "ComboBox_Resolucion"
        Me.ComboBox_Resolucion.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Resolucion.TabIndex = 11
        '
        'TextBox_TiempoFotos
        '
        Me.TextBox_TiempoFotos.Location = New System.Drawing.Point(276, 92)
        Me.TextBox_TiempoFotos.Name = "TextBox_TiempoFotos"
        Me.TextBox_TiempoFotos.Size = New System.Drawing.Size(75, 20)
        Me.TextBox_TiempoFotos.TabIndex = 10
        Me.TextBox_TiempoFotos.Text = "2000"
        '
        'TextBox_ResolucionAlto
        '
        Me.TextBox_ResolucionAlto.Location = New System.Drawing.Point(135, 92)
        Me.TextBox_ResolucionAlto.Name = "TextBox_ResolucionAlto"
        Me.TextBox_ResolucionAlto.Size = New System.Drawing.Size(77, 20)
        Me.TextBox_ResolucionAlto.TabIndex = 5
        Me.TextBox_ResolucionAlto.Text = "1944"
        '
        'Label_Resolucion
        '
        Me.Label_Resolucion.AutoSize = True
        Me.Label_Resolucion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_Resolucion.Location = New System.Drawing.Point(135, 50)
        Me.Label_Resolucion.Name = "Label_Resolucion"
        Me.Label_Resolucion.Size = New System.Drawing.Size(62, 15)
        Me.Label_Resolucion.TabIndex = 6
        Me.Label_Resolucion.Text = "Resolucion"
        '
        'TextBox_ResolucionAncho
        '
        Me.TextBox_ResolucionAncho.Location = New System.Drawing.Point(135, 66)
        Me.TextBox_ResolucionAncho.Name = "TextBox_ResolucionAncho"
        Me.TextBox_ResolucionAncho.Size = New System.Drawing.Size(77, 20)
        Me.TextBox_ResolucionAncho.TabIndex = 4
        Me.TextBox_ResolucionAncho.Text = "2592"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Capturar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label_TiempoActulizacion
        '
        Me.Label_TiempoActulizacion.AutoSize = True
        Me.Label_TiempoActulizacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_TiempoActulizacion.Location = New System.Drawing.Point(276, 29)
        Me.Label_TiempoActulizacion.Name = "Label_TiempoActulizacion"
        Me.Label_TiempoActulizacion.Size = New System.Drawing.Size(118, 15)
        Me.Label_TiempoActulizacion.TabIndex = 7
        Me.Label_TiempoActulizacion.Text = "Tiempo de actulizacion"
        '
        'TextBoxl_TiempoActulizacion
        '
        Me.TextBoxl_TiempoActulizacion.Location = New System.Drawing.Point(276, 45)
        Me.TextBoxl_TiempoActulizacion.Name = "TextBoxl_TiempoActulizacion"
        Me.TextBoxl_TiempoActulizacion.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxl_TiempoActulizacion.TabIndex = 9
        Me.TextBoxl_TiempoActulizacion.Text = "250"
        '
        'Button_PararCam
        '
        Me.Button_PararCam.Location = New System.Drawing.Point(12, 54)
        Me.Button_PararCam.Name = "Button_PararCam"
        Me.Button_PararCam.Size = New System.Drawing.Size(106, 23)
        Me.Button_PararCam.TabIndex = 2
        Me.Button_PararCam.Text = "Parar"
        Me.Button_PararCam.UseVisualStyleBackColor = True
        '
        'Label_TiempoFotos
        '
        Me.Label_TiempoFotos.AutoSize = True
        Me.Label_TiempoFotos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_TiempoFotos.Location = New System.Drawing.Point(276, 76)
        Me.Label_TiempoFotos.Name = "Label_TiempoFotos"
        Me.Label_TiempoFotos.Size = New System.Drawing.Size(97, 15)
        Me.Label_TiempoFotos.TabIndex = 8
        Me.Label_TiempoFotos.Text = "Tiempo entre fotos"
        '
        'Button_IniciarCam
        '
        Me.Button_IniciarCam.Location = New System.Drawing.Point(12, 24)
        Me.Button_IniciarCam.Name = "Button_IniciarCam"
        Me.Button_IniciarCam.Size = New System.Drawing.Size(106, 23)
        Me.Button_IniciarCam.TabIndex = 1
        Me.Button_IniciarCam.Text = "Iniciar"
        Me.Button_IniciarCam.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"AutoSize", "CenterImage", "Normal", "StretchImage", "Zoom"})
        Me.ComboBox1.Location = New System.Drawing.Point(658, 496)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 30
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"2592·1944", "1920·1080", "1280·720", "640·480"})
        Me.ComboBox2.Location = New System.Drawing.Point(658, 469)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 31
        '
        'Form_Microscopio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 553)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox_Camara)
        Me.Controls.Add(Me.Button_CapurarIntantanea)
        Me.Controls.Add(Me.Button_CapturarCamara)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PictureBox_Camara)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form_Microscopio"
        Me.Text = "Form_Microscopio"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox_Camara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox_Camara.ResumeLayout(False)
        Me.GroupBox_Camara.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox_Camara As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Button_Capturar As ToolStripButton
    Friend WithEvents Button_Grabar As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Button_CapturarCamara As Button
    Friend WithEvents Timer_Cam As Timer
    Friend WithEvents Button_CapurarIntantanea As Button
    Friend WithEvents GroupBox_Camara As GroupBox
    Friend WithEvents ComboBox_Resolucion As ComboBox
    Friend WithEvents TextBox_TiempoFotos As TextBox
    Friend WithEvents TextBox_ResolucionAlto As TextBox
    Friend WithEvents Label_Resolucion As Label
    Friend WithEvents TextBox_ResolucionAncho As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label_TiempoActulizacion As Label
    Friend WithEvents TextBoxl_TiempoActulizacion As TextBox
    Friend WithEvents Button_PararCam As Button
    Friend WithEvents Label_TiempoFotos As Label
    Friend WithEvents Button_IniciarCam As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class

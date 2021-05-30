Imports System.Threading

Public Class Form_Microscopio

    Dim webcam_0 As New Class_Cam

    Event Trama()
    '  Dim t As New Thread(AddressOf UpdateUI)
    Private t_Pausa As Thread

    'Public Delegate Sub AddTexto(ByVal myString As String)
    'Private Property Delegado_FORM As AddTexto

    Delegate Sub UIDelegate()
    Private callingThread As Integer

    Public Delegate Sub AddTexto(myString As String)
    Private Property Delegado_Suceso As AddTexto

    Private Sub Form_Microscopio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ToolStripStatusLabel1.Text = " "
            t_Pausa = New Thread(AddressOf UpdateUI)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateUI()

        Try
            'Thread.Sleep(CInt(TextBox_TiempoFotos.Text.Trim))

            If Button_CapturarCamara.InvokeRequired Then
                callingThread = System.Threading.Thread.CurrentThread.ManagedThreadId()
                Dim newDelegate As New UIDelegate(AddressOf ActulizaRetadoFotosCaptura)
                Button_CapturarCamara.Invoke(newDelegate)
            Else
                ' Thread.Sleep(CInt(TextBox_TiempoFotos.Text.Trim))
                Button_Capturar.Text = "No captura"
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ActulizaRetadoFotosCaptura()
        Try
            Button_Capturar.Text = "No captura"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_Capturar_Click(sender As Object, e As EventArgs) Handles Button_Capturar.Click
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_Grabar_Click(sender As Object, e As EventArgs) Handles Button_Grabar.Click
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_CapturarCamara_Click(sender As Object, e As EventArgs) Handles Button_CapturarCamara.Click

    End Sub


#Region "Camara"

    Private Sub Button_IniciarCam_Click(sender As System.Object, e As System.EventArgs) Handles Button_IniciarCam.Click
        Try
            If Timer_Cam.Enabled = True Then
                If Button_IniciarCam.ForeColor = Color.Aqua Then
                    Button_IniciarCam.ForeColor = Color.Red
                Else
                    Button_IniciarCam.ForeColor = Color.Aqua
                    Timer_Cam.Enabled = True
                End If
            Else
                Button_IniciarCam.ForeColor = Color.Black
                webcam_0.Iniciar(Timer_Cam, Me)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_PararCam_Click(sender As System.Object, e As System.EventArgs) Handles Button_PararCam.Click
        Try
            Timer_Cam.Enabled = False
            webcam_0.Detener(Timer_Cam)
            'If (Not (Me.WiaObj) Is Nothing) Then
            '    Marshal.FinalReleaseComObject(Me.WiaObj)
            'End If

            'If (Not (Me.WiaVideoObj) Is Nothing) Then
            '    Marshal.FinalReleaseComObject(Me.WiaVideoObj)
            'End If

            'If (Not (Me.DefaultDevice) Is Nothing) Then
            '    Marshal.FinalReleaseComObject(Me.DefaultDevice)
            'End If

            'If (Not (Me.Devices) Is Nothing) Then
            '    Marshal.FinalReleaseComObject(Me.Devices)
            'End If

            'Me.DeviceIsOpen = False
            GC.Collect()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
    End Sub


    Private Sub TirarTrama() Handles Me.Trama
        Try
            ' t_Pausa = New Thread(AddressOf UpdateUI)
            t_Pausa.Start()
            'Thread.Sleep(CInt(TextBox_TiempoFotos.Text))
            'If t_Pausa.ThreadState = ThreadState.Running Then
            '    t_Pausa.Abort()
            '    Button_Capturar.Text = "No captura"
            'Else
            '    t_Pausa.Join()
            'End If
        Catch ex As Exception

        End Try

    End Sub
    '  qqqqq

    Private Sub Button_CapurarIntantanea_Click(sender As System.Object, e As System.EventArgs) Handles Button_CapurarIntantanea.Click
        Try
            webcam_0.Capturar(PictureBox_Camara)


            ToolStripStatusLabel1.Text &= vbCr & "_"

            Catch ex As Exception

            End Try

    End Sub

    Private Sub ComboBox_Resolucion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Resolucion.SelectedIndexChanged
        Try
            If ComboBox_Resolucion.Text = "640·480" Then
                TextBox_ResolucionAncho.Text = "640"
                TextBox_ResolucionAlto.Text = "480"
            ElseIf ComboBox_Resolucion.Text = "1280·720" Then
                TextBox_ResolucionAncho.Text = "1280"
                TextBox_ResolucionAlto.Text = "720"
            ElseIf ComboBox_Resolucion.Text = "1920·1080" Then
                TextBox_ResolucionAncho.Text = "1920"
                TextBox_ResolucionAlto.Text = "1080"
            ElseIf ComboBox_Resolucion.Text = "2592·1944" Then
                TextBox_ResolucionAncho.Text = "2592"
                TextBox_ResolucionAlto.Text = "1944"
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer_Cam_Tick(sender As Object, e As EventArgs) Handles Timer_Cam.Tick
        Try
            webcam_0.timer_tick(PictureBox_Camara)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBoxl_TiempoActulizacion_TextChanged(sender As Object, e As EventArgs) Handles TextBoxl_TiempoActulizacion.TextChanged
        Try
            Timer_Cam.Interval = TextBoxl_TiempoActulizacion.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            If ComboBox1.Text = "AutoSize" Then
                PictureBox_Camara.SizeMode = PictureBoxSizeMode.AutoSize
            ElseIf ComboBox1.Text = "CenterImage" Then
                PictureBox_Camara.SizeMode = PictureBoxSizeMode.CenterImage
            ElseIf ComboBox1.Text = "Normal" Then
                PictureBox_Camara.SizeMode = PictureBoxSizeMode.Normal
            ElseIf ComboBox1.Text = "StretchImage" Then
                PictureBox_Camara.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf ComboBox1.Text = "Zoom" Then
                PictureBox_Camara.SizeMode = PictureBoxSizeMode.Zoom
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            If ComboBox_Resolucion.Text = "640·480" Then
                PictureBox_Camara.Width = "640"
                PictureBox_Camara.Height = "480"
            ElseIf ComboBox_Resolucion.Text = "1280·720" Then
                PictureBox_Camara.Width = "1280"
                PictureBox_Camara.Height = "720"
            ElseIf ComboBox_Resolucion.Text = "1920·1080" Then
                PictureBox_Camara.Width = "1920"
                PictureBox_Camara.Height = "1080"
            ElseIf ComboBox_Resolucion.Text = "2592·1944" Then
                PictureBox_Camara.Width = "2592"
                PictureBox_Camara.Height = "1944"
            End If

        Catch ex As Exception

        End Try
    End Sub

#End Region


End Class

Imports System.Runtime.InteropServices


Public Class Class_Cam


    Dim CapHwnd As Integer
    'Tamaño de la ventana del webcam
    Dim Ancho As Integer = 640   '320
    Dim Alto As Integer = 360 ' 240


#Region "Ajustes"
    Friend Sub AjustarResolucion(ByVal ByVal_Ancho As Integer, ByVal ByVal_Alto As Integer)
        Ancho = ByVal_Ancho
        Alto = ByVal_Alto
    End Sub

#End Region



    '"libreria.DLL" = El nombre del API que se desea importar
    ' EntryPoint = indica el nombre exacto de la función del API que queremos usar
#Region "Librerias DLL"
    'La función SendMessage llama al procedimiento de ventana para la ventana especificada y no vuelve hasta que el procedimiento de ventana se ha procesado el mensaje
    'LRESULT SendMessage(
    'HWND hWnd, // handle of destination window
    'UINT Msg, // message to send
    'WPARAM wParam, // first message parameter
    'LPARAM lParam // second message parameter
    ');
    <DllImport("user32.dll", EntryPoint:="SendMessage")> _
    Public Shared Function SendMessage(ByVal hWnd As Integer, ByVal Msg As UInteger, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    'Crea una ventana de captura
    <DllImport("avicap32.dll", EntryPoint:="capCreateCaptureWindowA")> _
    Public Shared Function capCreateCaptureWindowA(ByVal Nombre As String, ByVal dwStyle As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hWnd As Integer, ByVal nID As Integer) As Integer
    End Function

#End Region

#Region "Constantes API - no se que significan todas :) "
    Const WM_USER As Integer = 1024
    Const WM_CAP_CONNECT As Integer = 1034
    Const WM_CAP_DISCONNECT As Integer = 1035
    Const WM_CAP_GET_FRAME As Integer = 1084
    Const WM_CAP_COPY As Integer = 1054
    Const WM_CAP_START As Integer = WM_USER
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_USER + 52
    Const WM_CAP_DLG_VIDEOFORMAT As Integer = WM_CAP_START + 41
    Const WM_CAP_DLG_VIDEOSOURCE As Integer = WM_CAP_START + 42
    Const WM_CAP_DLG_VIDEODISPLAY As Integer = WM_CAP_START + 43
    Const WM_CAP_GET_VIDEOFORMAT As Integer = WM_CAP_START + 44
    Const WM_CAP_SET_VIDEOFORMAT As Integer = WM_CAP_START + 45
    Const WM_CAP_DLG_VIDEOCOMPRESSION As Integer = WM_CAP_START + 46
    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP_START + 50
#End Region

    'Captura frame y deposita en el portapapeles
    Public Sub timer_tick(ByVal picture As PictureBox)
        SendMessage(CapHwnd, WM_CAP_GET_FRAME, 0, 0)
        SendMessage(CapHwnd, WM_CAP_COPY, 0, 0)
        picture.Image = Clipboard.GetImage()
        'Application.DoEvents()
    End Sub

    'guarda el frame que esta en memoria en un archivo JPG
    Public Sub Capturar(ByVal picture As PictureBox)
        Dim FuchaNombre As String = Class_Codifica.LimpiarNombreArchivo(Date.Now).ToString.Trim
        Dim DirectoriFotos As String = My.Application.Info.DirectoryPath & "\Fotos"
        If My.Computer.FileSystem.DirectoryExists(DirectoriFotos) = False Then
            My.Computer.FileSystem.CreateDirectory(DirectoriFotos)
        End If


        Dim sfile_JPG As String = DirectoriFotos & "\Foto" & FuchaNombre & ".jpg"
        Dim obj_bitMap As New Bitmap(Ancho, Alto)
        Try
            picture.DrawToBitmap(obj_bitMap, New Rectangle(0, 0, Ancho, Alto))
            obj_bitMap.Save(sfile_JPG, Imaging.ImageFormat.Jpeg)

            ' MessageBox.Show("Imagen capturada en [" & sfile_JPG & " ]")
        Catch ex As Exception
            System.Console.WriteLine(ex)
        End Try
    End Sub

    Public Sub Iniciar(ByVal timer As Timer, ByVal padre As Form)
        Try
            'Configura la ventana de captura
            CapHwnd = capCreateCaptureWindowA("WebCam", 0, 0, 0, Ancho, Alto, padre.Handle.ToInt32(), 0)

            Application.DoEvents()

            SendMessage(CapHwnd, WM_CAP_CONNECT, 0, 0)
            SendMessage(CapHwnd, WM_CAP_SET_PREVIEWRATE, 69, 0)
            SendMessage(CapHwnd, WM_CAP_SET_PREVIEW, 0, 0)
            'se inicia el Timer
            timer.Start()
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub
    Public Sub IniciarSolo(ByVal padre As Form)
        Try
            'Configura la ventana de captura
            CapHwnd = capCreateCaptureWindowA("WebCam", 0, 0, 0, Ancho, Alto, padre.Handle.ToInt32(), 0)
            Application.DoEvents()
            SendMessage(CapHwnd, WM_CAP_CONNECT, 0, 0)
            SendMessage(CapHwnd, WM_CAP_SET_PREVIEWRATE, 69, 0)
            SendMessage(CapHwnd, WM_CAP_SET_PREVIEW, 0, 0)
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub
    Public Sub Detener(ByVal timer As Timer)
        Try
            timer.Stop()
            Application.DoEvents()
            SendMessage(CapHwnd, WM_CAP_DISCONNECT, 0, 0)

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub

End Class
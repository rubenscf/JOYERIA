Module ftp
    'Dim servidor As String = PDV.My.Settings.ftpServer
    'Dim usuario As String = PDV.My.Settings.uftp
    'Dim contraseña As String = PDV.My.Settings.pftp
    'Sub abrirImgLocal(ByRef pb As PictureBox)
    '    Dim DPIF As New OpenFileDialog
    '    DPIF.Filter = "Imagenes Fotograficas (*.jpg)|*.JPG"
    '    DPIF.ShowDialog()
    '    pb.ImageLocation = DPIF.FileName.ToString()
    'End Sub
    'Sub SubirImagen(ByRef pb As PictureBox, ByVal archivo As String)
    '    Try
    '        My.Computer.Network.UploadFile(pb.ImageLocation, servidor + archivo, usuario, contraseña, True, 1000)
    '        _estado("Imagen " + archivo + " guardada en el servidor", 1)
    '    Catch ex As Exception
    '        MsgBox(ex.Message, vbCritical)
    '    End Try

    'End Sub
    'Sub DescargaImagen(ByRef pb As PictureBox, ByVal archivo As String)
    '    Try
    '        My.Computer.Network.DownloadFile(servidor + archivo, frmMain.carpeta + "\" + archivo, usuario, contraseña, True, 1000, True)
    '        pb.ImageLocation = frmMain.carpeta + "\" + archivo
    '    Catch ex As Exception
    '        My.Computer.FileSystem.DeleteFile(frmMain.carpeta + "\" + archivo, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
    '        '  MsgBox(ex.Message, vbExclamation)
    '    End Try
    'End Sub
End Module

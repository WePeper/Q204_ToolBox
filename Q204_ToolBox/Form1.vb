
Public Class Form1
    Private readAndGetIni As New ini_writeAndGet
    Public configPath As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configPath = My.Application.Info.DirectoryPath + "\config.ini"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OpenExE = readAndGetIni.GetINI("AppOpen", "01", "", configPath)
        open(OpenExE)
    End Sub

    Function open(OpenExE As String) As String
        Dim pInfo As New ProcessStartInfo()
        pInfo.FileName = My.Application.Info.DirectoryPath + "\" + OpenExE
        Dim p As Process = Process.Start(pInfo)
        Return OpenExE
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim OpenExE = readAndGetIni.GetINI("AppOpen", "02", "", configPath)
        open(OpenExE)
    End Sub


End Class

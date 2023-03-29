Public Class ini_writeAndGet
    ''' <summary>
    ''' 调用外部DLL文件对ini文件进行写操作
    ''' </summary>
    ''' <param name="Section"></param>
    ''' <param name="AppName"></param>
    ''' <param name="lpDefault"></param>
    ''' <param name="FileName"></param>
    ''' <returns></returns>
    Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As Long
        WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, FileName)
    End Function
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32
    ''' <summary>
    ''' 调用外部DLL文件对ini文件进行读操作
    ''' </summary>
    ''' <param name="Section"></param>
    ''' <param name="AppName"></param>
    ''' <param name="lpDefault"></param>
    ''' <param name="FileName"></param>
    ''' <returns></returns>
    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As String
        Dim Str As String = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), FileName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32

End Class

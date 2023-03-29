Imports System.Net
Imports System.IO
Public Class xml_ReadAndWrite
    ''' <summary>
    ''' 保存内容至xml文件
    ''' </summary>
    ''' <param name="obj"></param>
    ''' <param name="type"></param>
    ''' <param name="savepath"></param>
    Public Function SaveXML(ByVal obj As Object, ByVal type As Type, ByVal savepath As String) As Boolean
        Try
            Dim myserializer As New Xml.Serialization.XmlSerializer(type)
            Dim myWriter As StreamWriter = New StreamWriter(savepath)
            myserializer.Serialize(myWriter, obj)
            myWriter.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return False
    End Function
    Public Function ReadXML(ByVal type As Type, ByVal savepath As String) As Object
        Try
            Dim myserializer As New Xml.Serialization.XmlSerializer(type)
            Dim Mystream As FileStream = New FileStream(savepath, FileMode.Open)
            Dim obj As Object = myserializer.Deserialize(Mystream)
            Mystream.Close()
            Return obj
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return False
    End Function
End Class

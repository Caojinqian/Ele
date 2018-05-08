<ComClass(ComClass1.ClassId, ComClass1.InterfaceId, ComClass1.EventsId)> _
Public Class ComClass1

#Region "COM GUID"
    ' 这些 GUID 提供此类的 COM 标识 
    ' 及其 COM 接口。若更改它们，则现有的
    ' 客户端将不再能访问此类。
    Public Const ClassId As String = "dbc6ad8b-d775-4cbb-9f1c-f65354a2cacf"
    Public Const InterfaceId As String = "0162df55-6c83-4255-8df3-a09a31a8493e"
    Public Const EventsId As String = "af5aba3a-45c4-4a1f-9e9a-8261b58afbf9"
#End Region

    ' 可创建的 COM 类必须具有一个不带参数的 Public Sub New() 
    ' 否则， 将不会在 
    ' COM 注册表中注册此类，且无法通过
    ' CreateObject 创建此类。
    Public Sub New()
        MyBase.New()
    End Sub

End Class



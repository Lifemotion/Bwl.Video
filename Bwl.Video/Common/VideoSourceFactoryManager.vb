Public Class VideoSourceFactoryManager
    Private list As New List(Of IVideoCaptureFactory)
    Public Sub AddFactory(ByVal factory As IVideoCaptureFactory)
        list.Add(factory)
    End Sub
    Public Sub ClearFactoryList()
        list.Clear()
    End Sub
    Public Function FindByName(ByVal factoryName As String) As IVideoCaptureFactory
        For Each factory In list
            If factory.Name.ToUpper = factoryName.ToUpper Then
                Return factory
            End If
        Next
        Return Nothing
    End Function
    Public ReadOnly Property FactoryList() As List(Of IVideoCaptureFactory)
        Get
            Dim newList As New List(Of IVideoCaptureFactory)
            For Each factory In list
                newList.Add(factory)
            Next
            Return newList
        End Get
    End Property
End Class

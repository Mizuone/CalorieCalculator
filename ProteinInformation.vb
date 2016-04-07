Public Class ProteinInformation
    Public Property ProteinItem As String
    Public Property ProteinCalorie As Double
    Public Sub New(ByVal ProteinItems As String, ByVal ProteinCalories As Double)
        ProteinItem = ProteinItems
        ProteinCalorie = ProteinCalories
    End Sub
End Class

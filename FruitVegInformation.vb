Public Class FruitVegInformation
    Public Property FruitItem As String
    Public Property FruitCalorie As Double
    Public Sub New(ByVal FruitVegItems As String, ByVal FruitVegCalories As Double)
        FruitItem = FruitVegItems
        FruitCalorie = FruitVegCalories
    End Sub
End Class
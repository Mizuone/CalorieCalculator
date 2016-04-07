Public Class JunkFoodInformation
    Public Property JunkFoodItem As String
    Public Property JunkFoodCalorie As Double
    Public Sub New(ByVal JunkFoodItems As String, ByVal JunkFoodCalories As Double)
        JunkFoodItem = JunkFoodItems
        JunkFoodCalorie = JunkFoodCalories
    End Sub
End Class

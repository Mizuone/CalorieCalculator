'Kyle Orlinski
'Calorie Calculator App
Public Class CalorieCalculator
    Private FruitVegArray(5) As FruitVegInformation
    Private GrainArray(1) As GrainInformation
    Private ProteinArray(7) As ProteinInformation
    Private MiscellaneousArray(2) As MiscellaneousInformation
    Private JunkFoodArray(1) As JunkFoodInformation
    Private Amount As Integer
    Private Sub CalorieCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FruitVegArray(0) = New FruitVegInformation("Apple", 95)
        FruitVegArray(1) = New FruitVegInformation("Orange", 62)
        FruitVegArray(2) = New FruitVegInformation("Prune", 23)
        FruitVegArray(3) = New FruitVegInformation("Yam(1 cup)", 177)
        FruitVegArray(4) = New FruitVegInformation("Brussel Sprouts(1 cup)", 38)
        FruitVegArray(5) = New FruitVegInformation("Green Beans(1.5 cups)", 31)

        GrainArray(0) = New GrainInformation("Wheat Bread(1 Slice)", 75)
        GrainArray(1) = New GrainInformation("Stuffing(1 cup)", 366)

        ProteinArray(0) = New ProteinInformation("Peanut Butter(1 tbsp)", 94)
        ProteinArray(1) = New ProteinInformation("Sliced Ham (1 Slice)", 34)
        ProteinArray(2) = New ProteinInformation("Sliced Pork Salami(1 Slice)", 41)
        ProteinArray(3) = New ProteinInformation("Sliced Chicken(1 Slice)", 14)
        ProteinArray(4) = New ProteinInformation("Turkey Breast(4 oz)", 153)
        ProteinArray(5) = New ProteinInformation("American Cheese(1 Slice)", 104)
        ProteinArray(6) = New ProteinInformation("Greek Yogurt(Fat Free)", 100)
        ProteinArray(7) = New ProteinInformation("Bacon Bits(2 tbsp)", 50)

        MiscellaneousArray(0) = New MiscellaneousInformation("Coffee(Creamer)", 26)
        MiscellaneousArray(1) = New MiscellaneousInformation("Butter(1 tbsp)", 102)
        MiscellaneousArray(2) = New MiscellaneousInformation("Barbecue sauce(1 tbsp)", 29)

        JunkFoodArray(0) = New JunkFoodInformation("Onion Dip(1 tbsp)", 30)
        JunkFoodArray(1) = New JunkFoodInformation("Potatoe Chips(11 chips)", 106)

        For Each i As FruitVegInformation In FruitVegArray
            lstFruitsVeg.Items.Add(i.FruitItem)
        Next
        For Each x As GrainInformation In GrainArray
            lstGrains.Items.Add(x.GrainItem)
        Next
        For Each a As ProteinInformation In ProteinArray
            lstProtein.Items.Add(a.ProteinItem)
        Next
        For Each t As MiscellaneousInformation In MiscellaneousArray
            lstMiscellaneous.Items.Add(t.MiscellaneousItem)
        Next
        For Each y As JunkFoodInformation In JunkFoodArray
            lstJunkFood.Items.Add(y.JunkFoodItem)
        Next
    End Sub

    Private Sub lstFruitsVeg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFruitsVeg.SelectedIndexChanged
        For Each i In FruitVegArray
            If i.FruitItem Is lstFruitsVeg.SelectedItem Then
                lstCalorieCount.Items.Add(i.FruitCalorie)
                Amount += i.FruitCalorie
            End If
        Next
        txtTotal.Text = Amount
    End Sub
    Private Sub lstGrains_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGrains.SelectedIndexChanged
        For Each i In GrainArray
            If i.GrainItem Is lstGrains.SelectedItem Then
                lstCalorieCount.Items.Add(i.GriainCalorie)
                Amount += i.GriainCalorie
            End If
        Next
        txtTotal.Text = Amount
    End Sub

    Private Sub lstProtein_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProtein.SelectedIndexChanged
        For Each i In ProteinArray
            If i.ProteinItem Is lstProtein.SelectedItem Then
                lstCalorieCount.Items.Add(i.ProteinCalorie)
                Amount += i.ProteinCalorie
            End If
        Next
        txtTotal.Text = Amount
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        lstCalorieCount.Items.Clear()
        txtTotal.Text = ""
        Amount = 0
        lstFruitsVeg.ClearSelected()
        lstGrains.ClearSelected()
        lstProtein.ClearSelected()
        lstMiscellaneous.ClearSelected()
        lstJunkFood.ClearSelected()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub lstSnacks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMiscellaneous.SelectedIndexChanged
        For Each i In MiscellaneousArray
            If i.MiscellaneousItem Is lstMiscellaneous.SelectedItem Then
                lstCalorieCount.Items.Add(i.MiscellaneousCalorie)
                Amount += i.MiscellaneousCalorie
            End If
        Next
        txtTotal.Text = Amount
    End Sub

    Private Sub lstJunkFood_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstJunkFood.SelectedIndexChanged
        For Each i In JunkFoodArray
            If i.JunkFoodItem Is lstJunkFood.SelectedItem Then
                lstCalorieCount.Items.Add(i.JunkFoodCalorie)
                Amount += i.JunkFoodCalorie
            End If
        Next
        txtTotal.Text = Amount
    End Sub

    Private Sub InformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationToolStripMenuItem.Click
        MessageBox.Show("Developer: Kyle Orlinski", "Creator of App")
    End Sub

    Private Sub InstructionsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem1.Click
        MessageBox.Show("Click on the following items within the list boxes. Each item will be calculated into the total amount of calories.", "Instructions")
    End Sub

    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        MessageBox.Show("Contact Email: orlinskikyle@gmail.com", "Contact")
    End Sub
End Class

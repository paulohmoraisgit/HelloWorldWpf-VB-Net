Class MainWindow
  Private Sub MyButton1_Click(sender As Object, e As RoutedEventArgs) Handles MyButton1.Click
    MyComboBox.Items.Clear()

    Dim cidades() As String = {"Ilhabela", "Blumenau", "Piracicaba", "Itu"}

    For Each item In cidades
      MyComboBox.Items.Add(item)
    Next

    MyComboBox.SelectedIndex = 0
  End Sub

  Private Sub MyButton2_Click(sender As Object, e As RoutedEventArgs) Handles MyButton2.Click
    MyTextBox1.Text = MyComboBox.SelectedItem
  End Sub

  Private Sub MyComboBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles MyComboBox.SelectionChanged
    MyTextBox1.Text = MyComboBox.SelectedItem
  End Sub
End Class

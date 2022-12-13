Public Class Form1
    Public Const single_val As Single = 10.0254
    Public Const double_val As Double = 10.025454654654
    Public Const integer_val As Integer = 1200
    Public Const long_val As Long = 4654654654454
    Public Const currency_val As Double = 50.75
    Public Const string_val As String = "Hello World"
    Public Const boolean_val As Boolean = True



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles single_btn.Click


        outs.Text = "The Literal of Single Data Type is: " & single_val

    End Sub

    Private Sub double_btn_CheckedChanged(sender As Object, e As EventArgs) Handles double_btn.Click

        outs.Text = "The Literal of Double Data Type is: " & double_val

    End Sub

    Private Sub integer_btn_CheckedChanged(sender As Object, e As EventArgs) Handles integer_btn.Click

        outs.Text = "The Literal of Integer Data Type is: " & integer_val
    End Sub

    Private Sub long_btn_CheckedChanged(sender As Object, e As EventArgs) Handles long_btn.Click

        outs.Text = "The Literal of Long Data Type is: " & long_val
    End Sub

    Private Sub currency_btn_CheckedChanged(sender As Object, e As EventArgs) Handles currency_btn.Click

        outs.Text = "The Literal of Currency is: $ " & currency_val
    End Sub

    Private Sub string_btn_CheckedChanged(sender As Object, e As EventArgs) Handles string_btn.Click

        outs.Text = "The Literal of String Data Type is: '" & string_val & "'"
    End Sub

    Private Sub boolean_btn_CheckedChanged(sender As Object, e As EventArgs) Handles boolean_btn.Click

        outs.Text = "The Literal of Boolean Data Type is: " & boolean_val
    End Sub
End Class

Public Class Form1

    ' Variable to store the first operand
    Private operand1 As Double
    ' Variable to store the selected operation (+, -, *, /)
    Private operation As String
    Private memory As Double = 0

    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        ' Handle digit buttons
        Dim button As Button = DirectCast(sender, Button)
        txtDisplay.Text &= button.Text
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If Not txtDisplay.Text.Contains(".") Then
            txtDisplay.Text &= "."
        End If
    End Sub

    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1)
        End If
    End Sub



    Private Sub btnOperation_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSubtract.Click, btnMultiply.Click, btnDivide.Click
        ' Handle operation buttons
        Dim button As Button = DirectCast(sender, Button)
        operand1 = CDbl(txtDisplay.Text)
        operation = button.Text
        txtDisplay.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Clear the display and reset variables
        txtDisplay.Clear()
        operand1 = 0
        operation = ""

    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        ' Perform the calculation based on the selected operation
        If Not String.IsNullOrEmpty(operation) AndAlso Double.TryParse(txtDisplay.Text, Nothing) Then
            Dim operand2 As Double = CDbl(txtDisplay.Text)
            Dim result As Double

            Select Case operation
                Case "+"
                    result = operand1 + operand2
                Case "-"
                    result = operand1 - operand2
                Case "*"
                    result = operand1 * operand2
                Case "/"
                    If operand2 <> 0 Then
                        result = operand1 / operand2
                    Else
                        MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
            End Select

            ' Display the result
            txtDisplay.Text = result.ToString()
            ' Reset variables
            operand1 = 0
            operation = ""
        End If

    End Sub


    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        If Double.TryParse(txtDisplay.Text, Nothing) AndAlso CDbl(txtDisplay.Text) >= 0 Then
            txtDisplay.Text = Math.Sqrt(CDbl(txtDisplay.Text)).ToString()
        Else
            MessageBox.Show("Invalid input for square root.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnPercentage_Click(sender As Object, e As EventArgs) Handles btnPercentage.Click
        If Double.TryParse(txtDisplay.Text, Nothing) Then
            txtDisplay.Text = (CDbl(txtDisplay.Text) / 100).ToString()
        Else
            MessageBox.Show("Invalid input for percentage.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnNegate_Click(sender As Object, e As EventArgs) Handles btnNegate.Click
        If Double.TryParse(txtDisplay.Text, Nothing) Then
            txtDisplay.Text = (-CDbl(txtDisplay.Text)).ToString()
        Else
            MessageBox.Show("Invalid input for negation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnMemorySave_Click(sender As Object, e As EventArgs) Handles btnMemorySave.Click
        If Double.TryParse(txtDisplay.Text, Nothing) Then
            memory = CDbl(txtDisplay.Text)
        Else
            MessageBox.Show("Invalid input for memory save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnMemoryRecall_Click(sender As Object, e As EventArgs) Handles btnMemoryRecall.Click
        txtDisplay.Text = memory.ToString()
    End Sub

    Private Sub btnMemoryClear_Click(sender As Object, e As EventArgs) Handles btnMemoryClear.Click
        memory = 0
    End Sub

    Private Sub btnSin_Click(sender As Object, e As EventArgs) Handles btnSin.Click
        If Double.TryParse(txtDisplay.Text, Nothing) Then
            txtDisplay.Text = Math.Sin(CDbl(txtDisplay.Text)).ToString()
        Else
            MessageBox.Show("Invalid input for sine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCos_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        If Double.TryParse(txtDisplay.Text, Nothing) Then
            txtDisplay.Text = Math.Cos(CDbl(txtDisplay.Text)).ToString()
        Else
            MessageBox.Show("Invalid input for cosine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnTan_Click(sender As Object, e As EventArgs) Handles btnTan.Click
        If Double.TryParse(txtDisplay.Text, Nothing) Then
            txtDisplay.Text = Math.Tan(CDbl(txtDisplay.Text)).ToString()
        Else
            MessageBox.Show("Invalid input for tangent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        If Double.TryParse(txtDisplay.Text, Nothing) Then
            txtDisplay.Text = Math.Exp(CDbl(txtDisplay.Text)).ToString()
        Else
            MessageBox.Show("Invalid input for exponential.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        If Double.TryParse(txtDisplay.Text, Nothing) AndAlso CDbl(txtDisplay.Text) > 0 Then
            txtDisplay.Text = Math.Log(CDbl(txtDisplay.Text)).ToString()
        Else
            MessageBox.Show("Invalid input for logarithm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnPi_Click(sender As Object, e As EventArgs) Handles btnPi.Click
        txtDisplay.Text = Math.PI.ToString()
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        txtDisplay.Text = Math.E.ToString()
    End Sub

    Private Sub btnOpenParen_Click(sender As Object, e As EventArgs) Handles btnOpenParen.Click
        txtDisplay.Text &= "("
    End Sub

    Private Sub btnCloseParen_Click(sender As Object, e As EventArgs) Handles btnCloseParen.Click
        txtDisplay.Text &= ")"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Clear the display and reset variables
        txtDisplay.Clear()
        operand1 = 0
        operation = ""
        operation = ""

    End Sub
End Class

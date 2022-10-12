Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        altura.Select()
        MsgBox("Bem vindo a calculadora IMC", MsgBoxStyle.Information)
    End Sub

    Private Sub altura_TextChanged(sender As Object, e As EventArgs) Handles altura.TextChanged
        If Not IsNumeric(altura.Text) Then
            altura.Text = ""
        End If
    End Sub

    Private Sub peso_TextChanged(sender As Object, e As EventArgs) Handles peso.TextChanged
        If Not IsNumeric(peso.Text) Then
            peso.Text = ""
        End If
    End Sub

    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click
        Dim a, p As Double
        Dim imc As Double

        Double.TryParse(altura.Text, a)
        Double.TryParse(peso.Text, p)

        If altura.Text = "" Or peso.Text = "" Then
            MsgBox("Informe a sua altura e o seu peso", MsgBoxStyle.Exclamation)
        End If

        imc = Math.Round(p / (a * a), 2)

        If imc < 18.5 Then
            MsgBox("O seu indice de massa corporal é " & imc & vbCrLf & "Atenção!! Você está abaixo do peso.", MsgBoxStyle.Exclamation)
        ElseIf imc > 18.5 And imc < 24.9 Then
            MsgBox("O seu indice de massa corporal é " & imc & vbCrLf & "Parabéns!! Você está no peso ideal", MsgBoxStyle.Information)
        ElseIf imc > 24.9 And imc < 29.9 Then
            MsgBox("O seu indice de massa corporal é " & imc & vbCrLf & "Atenção!! Você está acima do peso", MsgBoxStyle.Exclamation)
        ElseIf imc > 29.9 And imc < 39 Then
            MsgBox("O seu indice de massa corporal é " & imc & vbCrLf & "Atenção!! Você está com obsidade", MsgBoxStyle.Exclamation)
        ElseIf imc > 40 Then
            MsgBox("O seu indice de massa corporal é " & imc & vbCrLf & "Atenção!! Você está com obsidade morbida", MsgBoxStyle.Exclamation)
        End If

        altura.Text = ""
        peso.Text = ""
        altura.Select()

    End Sub
End Class

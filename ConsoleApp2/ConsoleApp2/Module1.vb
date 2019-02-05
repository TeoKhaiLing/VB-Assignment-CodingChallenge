Option Explicit On
Option Strict On

Module Module1
    Sub Main()
        Dim num1 As Integer, num2 As String, num3 As String = ""

        Do
            Console.WriteLine("Please enter an integer : ")
            num2 = Console.ReadLine
        Loop Until Integer.TryParse(num2, num1)
        Console.WriteLine("The Binary number is : {0}", Convert.ToString(num1, 2))

        Do While (num1 > 0)
            Dim remainder As Integer = num1 Mod 2
            num3 = remainder.ToString & num3
            num1 = num1 \ 2
        Loop

        Console.WriteLine("The Binary number is : {0}", num3)
        Console.ReadLine()
    End Sub
End Module

Option Strict On
Option Explicit On
Option Compare Text

'Lane Coleman
'RCET 0265
'Fall 2020
'Roll Of The Dice
'https://github.com/colelane/RollOfTheDiceLC
Module RollOfTheDiceLC

    Sub Main()
        Randomize()
        Dim randomNumber As Integer
        Dim data(12) As Integer
        Dim row As Integer

        Console.WriteLine($"Press enter to roll the dice. Press Q to quit.")

        If Console.ReadKey().Key = ConsoleKey.Q Then
            Exit Sub
        End If

        Do

            For i = 1 To 1000
                randomNumber = CInt(GetRandomNumber(1, 13))
                data(randomNumber) += 1
            Next

            For i = 2 To 12
                Console.Write("--------")
            Next
            Console.WriteLine()

            For i = 2 To 12
                Console.Write($"{i} |{vbTab}")
            Next
            Console.WriteLine()

            For i = 2 To 12
                Console.Write("--------")
            Next
            Console.WriteLine()

            For i = 2 To 12
                'Console.Write(i)
                Console.Write($"{data(i)} |{vbTab}")
            Next

            Console.WriteLine(vbNewLine)
            Console.WriteLine($"Press enter to roll the dice again. Press Q to quit")

            If Console.ReadKey().Key = ConsoleKey.Q Then
                Exit Sub
            End If


            'clears the array
            Erase data
            ReDim data(12)

        Loop
    End Sub
    Function GetRandomNumber(ByVal minimum As Double,
                             ByVal maximum As Double) As Double

        Dim value As Double


        Do While value < minimum Or value > maximum
            value = ((maximum - minimum + 1) * Rnd()) + minimum - 1.5
        Loop
        Return CInt(value)

    End Function
End Module

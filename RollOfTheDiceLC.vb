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
        Dim data(10) As Integer


        Console.WriteLine($"Press enter to roll the dice. Press Q to quit.")

        If Console.ReadKey().Key = ConsoleKey.Q Then
            Exit Sub
        End If

        Do

            For i = 1 To 1000
                randomNumber = CInt(GetRandomNumber(1, 12))
                data(randomNumber - 2) += 1
            Next

            For i = 0 To 10
                Console.Write("--------")
            Next
            Console.WriteLine()

            For i = 2 To 12
                Console.Write($"{i} |{vbTab}")
            Next
            Console.WriteLine()

            For i = 0 To 10
                Console.Write("--------")
            Next
            Console.WriteLine()

            For i = 0 To 10
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
            ReDim data(10)

        Loop
    End Sub
    Function GetRandomNumber(ByVal minimum As Double,
                             ByVal maximum As Double) As Double

        Dim value As Double


        Do
            value = ((maximum - minimum + 1) * Rnd()) + minimum
        Loop While value < minimum + 0.5 Or value > maximum + 0.5
        Return CInt(value)

    End Function
End Module

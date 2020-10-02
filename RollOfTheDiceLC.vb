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
        Dim txt As String

        Console.SetWindowSize(150, 40)
        Console.WriteLine($"Press enter to roll the dice. Press Q to quit.")
        'keypress detection for quits
        If Console.ReadKey().Key = ConsoleKey.Q Then
            Exit Sub
        End If

        Do
            'dim data is in the do loop because of the erase data at the bottom of the loop
            'if dim data was outside the do loop we would have to redim it.
            Dim data(10) As Integer

            'Gets a random number from the function and uses it to select a cell to add
            'a tally to.  Does this 1000 times
            For i = 1 To 1000
                randomNumber = CInt(GetRandomNumber(1, 6))
                data(randomNumber - 2) += 1
                'has to be randomnumber - 2 or it would be outside the bounds of the array.
            Next

            Console.Write(StrDup(138, "-"))
            Console.WriteLine()
            Console.Write("Rollable Numbers:")
            'formatted strings or alignment
            For i = 2 To 12
                txt = String.Format("{0, 10}", i) & "|"
                Console.Write(txt)
            Next
            Console.WriteLine()

            Console.Write(StrDup(138, "-"))
            Console.WriteLine()

            Console.Write("Times Rolled:    ")
            For i = 0 To 10
                txt = String.Format("{0,10}", data(i)) & "|"
                Console.Write(txt)
            Next

            Console.WriteLine(vbNewLine)
            Console.WriteLine($"Press enter to roll the dice again. Press Q to quit")

            If Console.ReadKey().Key = ConsoleKey.Q Then
                Exit Sub
            End If


            'clears the array, but also just deletes it so it must be redimmed.
            Erase data
            Console.Clear()
        Loop
    End Sub
    Function GetRandomNumber(ByVal minimum As Single,
                             ByVal maximum As Single) As Single

        Dim value1, value2 As Double
        Dim sum As Integer
        'rolls two 'dice'  each gives a number from 0.5 to 6.5 and rounds to the nearest whole number
        'they are then added together like real dice for a number between 2 and 12
        Do
            value1 = (maximum * Rnd()) + 0.5
            value2 = (maximum * Rnd()) + 0.5
        Loop While value1 < minimum - 0.5 Or value1 >= maximum + 0.5 Or
            value2 < minimum - 0.5 Or value2 >= maximum + 0.5

        sum = CInt(value1) + CInt(value2)
        Return sum

    End Function

End Module

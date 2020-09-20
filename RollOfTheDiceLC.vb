Option Strict Off
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
        Dim txt As String

        Console.SetWindowSize(150, 40)
        Console.WriteLine($"Press enter to roll the dice. Press Q to quit.")

        If Console.ReadKey().Key = ConsoleKey.Q Then
            Exit Sub
        End If

        Do

            For i = 1 To 1000
                randomNumber = CInt(GetRandomNumber(1, 12))
                data(randomNumber - 2) += 1
            Next

            Console.Write(StrDup(138, "-"))
            Console.WriteLine()

            Console.Write("Rollable Numbers:")
            For i = 2 To 12
                txt = String.Format("{0, 10}", i) & "|"
                Console.Write(txt)
            Next
            Console.WriteLine()

            Console.Write(StrDup(138, "-"))
            Console.WriteLine()
            Console.Write("Times Rolled:    ")
            For i = 0 To 10
                txt = String.Format("{0, 10}", data(i)) & "|"
                Console.Write(txt)
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
    Function GetRandomNumber(ByVal minimum As Single,
                             ByVal maximum As Single) As Single

        Dim value As Single
        'Dim rtrn As Integer
        'Dim tmp As Integer
        'Dim goodData As Boolean
        'Do
        '    For i = 1 To 6
        '        value = ((maximum - minimum + 1) * Rnd()) + minimum
        '        tmp = CInt(value)
        '        If tmp = 7 Then
        '            rtrn = 7
        '            Exit Do
        '        End If
        '    Next
        '    For i = 1 To 5
        '        value = ((maximum - minimum + 1) * Rnd()) + minimum
        '        tmp = CInt(value)
        '        If tmp = 6 Then
        '            rtrn = 6
        '            Exit Do
        '        ElseIf tmp = 8 Then
        '            rtrn = 8
        '            Exit Do
        '        End If
        '    Next
        '    For i = 1 To 4
        '        value = ((maximum - minimum + 1) * Rnd()) + minimum
        '        tmp = CInt(value)
        '        If tmp = 5 Then
        '            rtrn = 5
        '            Exit Do
        '        ElseIf tmp = 9 Then
        '            rtrn = 9
        '            Exit Do
        '        End If
        '    Next
        '    For i = 1 To 3
        '        value = ((maximum - minimum + 1) * Rnd()) + minimum
        '        tmp = CInt(value)
        '        If tmp = 4 Then
        '            rtrn = 4
        '            Exit Do
        '        ElseIf tmp = 10 Then
        '            rtrn = 10
        '            Exit Do
        '        End If
        '    Next
        '    For i = 1 To 2
        '        value = ((maximum - minimum + 1) * Rnd()) + minimum
        '        tmp = CInt(value)
        '        If tmp = 3 Then
        '            rtrn = 3
        '            Exit Do
        '        ElseIf tmp = 11 Then
        '            rtrn = 11
        '            Exit Do
        '        End If
        '    Next
        '    For i = 1 To 1
        '        value = ((maximum - minimum + 1) * Rnd()) + minimum
        '        tmp = CInt(value)
        '        If tmp = 2 Then
        '            rtrn = 2
        '            Exit Do
        '        ElseIf tmp = 12 Then
        '            rtrn = 12
        '            Exit Do
        '        End If
        '    Next
        '    If rtrn = Nothing Then
        '        goodData = False
        '    Else
        '        goodData = True
        '    End If
        'Loop Until goodData = True
        'Return rtrn


        Do
            value = ((maximum - minimum + 1) * Rnd()) + minimum
        Loop While value < minimum + 0.5 Or value > maximum + 0.5
        Return CInt(value)

    End Function

End Module

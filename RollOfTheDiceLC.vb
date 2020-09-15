Option Strict On
Option Explicit On
Option Compare Text
Module RollOfTheDiceLC

    Sub Main()
        Randomize()
        Dim randomNumber As Integer
        Dim userInput As String
        Dim data(12) As Integer
        Dim column, row As Integer

        Console.WriteLine("Press enter to roll the dice.")
        Console.ReadLine()
        Do While userInput <> "Q"

            For i = 1 To 100
                randomNumber = GetRandomNumber(1, 12)
                data(randomNumber) += 1
            Next

            For i = 2 To UBound(data)
                Console.Write("--------")
            Next
            Console.WriteLine()

            For i = 2 To UBound(data)
                Console.Write(i & "|" & vbTab)
            Next
            Console.WriteLine()

            For i = 2 To UBound(data)
                Console.Write("--------")
            Next
            Console.WriteLine()

            For i = 2 To UBound(data)
                'Console.Write(i)
                Console.Write(data(i) & "|" & vbTab)
            Next
            Console.WriteLine(vbNewLine)
            Console.WriteLine($"Press enter to roll the dice again")
            Console.ReadLine()


            'clears the array
            For column = 1 To 12
                data(column) = Nothing
            Next
        Loop
    End Sub
    Function GetRandomNumber(ByVal minimum As Integer,
                             ByVal maximum As Integer) As Integer

        Dim value As Single

        Randomize()

        Do While value < minimum Or value > maximum
            value = ((maximum - minimum + 1) * Rnd()) + minimum
        Loop
        Return CInt(value)

    End Function
End Module

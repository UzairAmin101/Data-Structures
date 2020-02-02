Module Module1
    Dim queue(2) As String
    Const fullqueue = 2
    Const nullval = -1
    Dim readpointer As Integer
    Dim writepointer As Integer



    Sub write()
        Dim value As String
        If writepointer = fullqueue Then
            Console.WriteLine("Overflow, there is no more space left to add data")
            Console.ReadKey()
            Exit Sub
        End If
        Console.WriteLine("Enter the value that you want to add")
        value = Console.ReadLine()
        writepointer = writepointer + 1
        queue(writepointer) = value
    End Sub


    Sub read()
        Dim value As String
        If writepointer = -1 Then
            Console.WriteLine("Underflow, there is no data to be read")
            Console.ReadKey()
            Exit Sub
        End If
        readpointer = readpointer + 1
        value = queue(readpointer)
        Console.WriteLine("The value is: " + value)
        For readpointer = 0 To (fullqueue - 1)
            queue(readpointer) = queue(readpointer + 1)

        Next
        readpointer = nullval
        writepointer = writepointer - 1
        Console.ReadKey()
    End Sub

    Sub Main()
        readpointer = nullval
        writepointer = nullval
        Dim choice As Integer
        Do
            Console.WriteLine("Press 1 to Write")
            Console.WriteLine("Press 2 to Read")
            Console.WriteLine("Press 3 to Exit the Program")
            Console.WriteLine()
            choice = Console.ReadLine()
            If choice = 1 Then
                write()

            End If

            If choice = 2 Then
                read()

            End If
            Console.Clear()
        Loop Until choice = 3





    End Sub

End Module

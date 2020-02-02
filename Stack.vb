Module Module1
    Dim stack(1) As String
    Const fullstack = 1
    Const nullstack = -1
    Dim currpointer As Integer = -1
    Dim value As String


    Sub recadder()
        If currpointer = fullstack Then
            Console.WriteLine("Overflow, the stack is full and no further values can be added")
            Console.ReadKey()
            Exit Sub
        End If
        Console.WriteLine("Enter value to be pushed")
        value = Console.ReadLine()
        currpointer = currpointer + 1
        stack(currpointer) = value

    End Sub

    Sub pop()
        If currpointer = nullstack Then
            Console.WriteLine("Underflow, there are no more values to be popped")
            Console.ReadKey()
            Exit Sub
        End If
        Console.WriteLine("The value popped was:" + stack(currpointer))
        currpointer = currpointer - 1
        Console.ReadKey()
    End Sub

    Sub Main()
        Dim choice As Integer
        Do
            Console.WriteLine("To add press 1")
            Console.WriteLine("To pop press 2")
            Console.WriteLine("To exit press 3")
            Console.WriteLine()
            choice = Console.ReadLine()
            If choice = 1 Then
                Console.WriteLine()
                recadder()
            End If

            If choice = 2 Then
                Console.WriteLine()
                pop()
            End If

            Console.Clear()
        Loop Until choice = 3
    End Sub

End Module

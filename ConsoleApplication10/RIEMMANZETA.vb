Module Module1
    Dim n As Integer = 0
    Dim userschoice As Integer = 1 Or 2
    Dim i As Integer
    Dim endpoint As Integer
    Dim s As Decimal
    Dim val As Decimal = 0
    Dim value As Decimal = 0
    Dim r As Integer
    Dim counter As Integer = 0
    Dim factorial As Integer = 1
    Dim p As Integer = 0
    Dim alpha As Integer




    Sub Main()
        Console.WriteLine("enter option (1-2)")
        userschoice = Console.ReadLine()

        Select Case userschoice
            Case 1
                riemman()
            Case 2
                maclaurin()

        End Select
        Console.WriteLine(" process finished with value " & val)
        Console.ReadLine()
    End Sub
    Sub riemman()
        Console.WriteLine("enter s")
        s = Console.ReadLine()
        Console.WriteLine("enter end point")
        endpoint = Console.ReadLine()
        Do Until n = endpoint
            n = n + 1
            val = 1 / n ^ s
            value = value + val
            Console.WriteLine(value)
            Console.ReadLine()

        Loop
    End Sub

    Sub maclaurin()
        Console.WriteLine("enter option 1,4")
        userschoice = Console.ReadLine()
        Select Case userschoice
            Case 1
                ln()
            Case 2
                exp()
            Case 3
                sinx()
            Case 4
                cosx()

            Case Else
                Console.WriteLine("value " & userschoice & " is not >=1 and <=4")
                Main()


        End Select




    End Sub
    Sub ln()
        Console.WriteLine("enter n")
        i = Console.ReadLine()
        Console.WriteLine("enter number of repitions")
        r = Console.ReadLine()
        Do Until counter = r
            counter = counter + 1
            val = val + (i ^ counter) / counter
            counter = counter + 1
            val = val - (i ^ counter) / counter
            Console.WriteLine(val)
            Console.ReadLine()
        Loop

    End Sub
    Sub exp()
        Console.WriteLine("enter n")
        i = Console.ReadLine()
        Console.WriteLine("enter number of repitions")
        r = Console.ReadLine()
        val = 1
        Do Until counter = r

            counter = counter + 1
            p = counter
            Do Until p = 0
                factorial = factorial * p
                p = p - 1



            Loop

            val = val + (i ^ counter) / factorial
            Console.WriteLine(val)
            Console.ReadLine()

        Loop

    End Sub
    Sub sinx()

        Console.WriteLine("enter n")
        i = Console.ReadLine()
        Console.WriteLine("enter number of repitions")
        r = Console.ReadLine()
        counter = 0
        val = i
        Do Until counter = r
            counter = counter + 1
            alpha = 2 * counter + 1
            p = alpha
            Do Until p = 0
                factorial = factorial * p
                p = p - 1




            Loop
            val = val - (i ^ alpha) / p
            Console.WriteLine(val)
            Console.ReadLine()
            counter = counter + 1
            alpha = 2 * counter + 1
            p = alpha
            Do Until p = 0
                factorial = factorial * p
                p = p - 1
            Loop
            val = val + (i ^ alpha)
            Console.WriteLine(val)
            Console.ReadLine()

        Loop





    End Sub
    Sub cosx()
        Console.WriteLine("enter n")
        i = Console.ReadLine()
        Console.WriteLine("enter number of repitions")
        r = Console.ReadLine()
        counter = 0
        val = i
        Do Until counter = r
            counter = counter + 1
            alpha = 2 * counter
            p = alpha
            Do Until p = 0
                factorial = factorial * p
                p = p - 1




            Loop
            val = val - (i ^ alpha) / p
            Console.WriteLine(val)
            Console.ReadLine()
            counter = counter + 1
            alpha = 2 * counter
            p = alpha
            Do Until p = 0
                factorial = factorial * p
                p = p - 1
            Loop
            val = val + (i ^ alpha)
            Console.WriteLine(val)
            Console.ReadLine()

        Loop
    End Sub
End Module

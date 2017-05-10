Module Module1
    Dim n As Integer = 0
    Dim endpoint As Integer
    Dim s As Integer
    Dim val As Decimal
    Dim value As Decimal



    Sub Main()
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

End Module

Module Module1

    Sub Main()
        Dim str As String = "01000a00"
        Dim num As Int32
        Int32.TryParse(str, num)
        Console.WriteLine(String.Format("{0}", str))
        Console.ReadKey()
    End Sub

End Module

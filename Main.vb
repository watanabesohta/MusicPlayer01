Imports System

Module Main
    Sub Main(args As String())
        Dim itow As Integer
        Dim t As New Title

        Console.WriteLine("ipod‚©walkman‚ğ‘I‘ğ‚µ‚Ä‚­‚¾‚³‚¢B")
        Console.Write("1:walkman ")
        Console.WriteLine("2:ipod")
        Console.WriteLine("2:ipod")
        Console.WriteLine("2:ipod")

        itow = Console.ReadLine()
        If itow = 0 Then
            Dim x As New Walkman
            x.UseWalkman()
            t.Display(x.music, x.artist)
        Else
            Dim x As New Ipod
            x.UseIpod()
            t.Display(x.music, x.artist)
        End If


    End Sub
End Module

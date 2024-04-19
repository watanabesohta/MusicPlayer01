Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Walkman
    Property music As String
    Property artist As String

    Sub New()
        Console.WriteLine("walkmanの使用を開始します。")
    End Sub


    Sub UseWalkman()

        Console.WriteLine("曲名を入力してください")
        music = Console.ReadLine()
        Console.WriteLine("アーティスト名を入力してください")
        artist = Console.ReadLine()

        If String.IsNullOrEmpty(music) Then
            'エラー処理
            Console.WriteLine("再生に失敗しました")
            Environment.Exit(0)
        ElseIf String.IsNullOrEmpty(artist) Then
            'エラー処理
            Console.WriteLine("再生に失敗しました")
            Environment.Exit(0)
        End If

        Console.WriteLine("曲名：", music, "アーティスト:", artist)


    End Sub

End Class



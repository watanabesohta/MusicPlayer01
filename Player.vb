Module Player

    Interface TestInterface

        '再生
        Property StartP() As Integer
        Sub StartS(ByVal X As Integer)
        Event StartE()

        '一時停止
        Property PauseP() As Integer
        Sub PauseS(ByVal X As Integer)
        Event PauseE()

        '停止
        Property StopP() As Integer
        Sub StopS(ByVal X As Integer)
        Event StopE()

    End Interface

End Module

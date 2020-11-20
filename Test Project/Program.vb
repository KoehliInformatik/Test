Module Program

    Sub Main()
        Dim newinstance As CreaturesManager = New CreaturesManager()
        Dim newInstance2 As CreaturesManager = New CreaturesManager()
        'newInstance.CreateMonsters()
        CreaturesManager.Instance.CreateMonsters()
    End Sub

End Module

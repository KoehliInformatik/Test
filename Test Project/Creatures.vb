Imports System

Public MustInherit Class Creatures

    Protected health As Single = 200
    Protected attackDamage As Single = 3.7F
    Protected armor As Single = 5
    Protected name As String = "Gobi"
    Public Property AttackSpeed As Single
        Get
            Return AttackSpeed
        End Get
        Protected Set(value As Single)

        End Set
    End Property

    Public Property IsDead As Boolean
        Get
            Return IsDead
        End Get
        Private Set(value As Boolean)

        End Set
    End Property

    Public Sub Attack(ByVal target As Creatures)
        Console.WriteLine(name & " attacked " & target.name)
        target.TakeDamage(attackDamage)
    End Sub



    Public Sub TakeDamage(ByVal damage As Single)
        Console.ForegroundColor = ConsoleColor.DarkRed

        Console.WriteLine(vbLf & "Monster " & name & " has " & health & " hp and " & Math.Max(0, armor) & " armor  left.")

        If armor > 0 Then
            armor -= damage
        Else
            armor = 0
            health -= damage
        End If

        If health <= 0 Then
            Die()
        End If
    End Sub

    Private Sub Interact()
        Console.WriteLine("Ready to Die?")
        Console.Read()
    End Sub

    Public Sub Die()
        Console.WriteLine("Monster " & name & " died! ")
        IsDead = True
        CreaturesManager.creatures.Remove(Me)
    End Sub


End Class

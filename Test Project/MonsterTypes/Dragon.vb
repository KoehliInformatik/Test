Public Class Dragon
    Inherits Creatures

    Public Sub New(ByVal health As Single,
                      ByVal attackDamage As Single,
                      ByVal armor As Single,
                      ByVal attackSpeed As Single,
                      ByVal name As String)

        Me.health = health
        Me.attackDamage = attackDamage
        Me.armor = armor
        Me.AttackSpeed = attackSpeed
        Me.name = name

    End Sub

End Class

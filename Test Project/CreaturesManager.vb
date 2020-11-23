Imports System.Runtime.CompilerServices
Imports System
Imports System.Globalization
Imports System.Linq

Public Class CreaturesManager
    ' Just A COMMENT
    Public Shared Instance As CreaturesManager = New CreaturesManager()
    Public Shared creatures As List(Of Creatures) = New List(Of Creatures)()

    Private Sub New()
        If Instance Is Nothing Then Instance = Me
    End Sub

    Public Sub CreateMonsters()

        Console.BackgroundColor = ConsoleColor.DarkBlue
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.White

        Console.WriteLine(" Hi there! " & vbLf & " Welcome to my Monster Game :-)" & vbLf & " Lets create some hilarious monster fights...! :) ")

        Dim IsCrafting As Boolean = True

        While IsCrafting

            Console.WriteLine(vbLf & " Press the showing inputs to create different type of monsters: " & vbLf &
                              " 1 => Goblin, 2 => Orc, 3 => Wyvern, 4 => Dragon, 5 => Bigfoot, 6 => Vampyre and 7 =>  Werewolve" & vbLf &
                              " Then press Enter to finish the creating prozess")

            Dim key As ConsoleKey = Console.ReadKey().Key

            If key = ConsoleKey.Enter AndAlso creatures.Count >= 2 Then
                Exit While

            ElseIf key = ConsoleKey.Enter AndAlso creatures.Count <= 2 Then
                Console.WriteLine(vbLf & " There must be at least 2 differet type of creatures! Please create another type of monster and try again!")
                Continue While
            End If

            Dim name As String = String.Empty

            While name.Length < 5

                Select Case key

                    Case ConsoleKey.D1,
                         ConsoleKey.NumPad1
                        Console.WriteLine(vbLf & " You'r choose is a Goblin monster! " & vbLf & " Give it a name:")

                    Case ConsoleKey.D2,
                         ConsoleKey.NumPad2
                        Console.WriteLine(vbLf & " You'r choose is a Orc monster! " & vbLf & " Give it a name:")

                    Case ConsoleKey.D3,
                         ConsoleKey.NumPad3
                        Console.WriteLine(vbLf & " You'r choose is a Wyvern monster! " & vbLf & " Give it a name:")

                    Case ConsoleKey.D4,
                         ConsoleKey.NumPad4
                        Console.WriteLine(vbLf & " You'r choose is a Dragon monster! " & vbLf & " Give it a name:")

                    Case ConsoleKey.D5,
                         ConsoleKey.NumPad5
                        Console.WriteLine(vbLf & " You'r choose is a Bigfoot monster! " & vbLf & " Give it a name:")

                    Case ConsoleKey.D6,
                    ConsoleKey.NumPad6
                        Console.WriteLine(vbLf & " You'r choose is a Vampyre monster! " & vbLf & " Give it a name:")

                    Case ConsoleKey.D7,
                         ConsoleKey.NumPad7
                        Console.WriteLine(vbLf & " You'r choose is a Werewolve monster! " & vbLf & " Give it a name:")

                    Case Else
                        Console.WriteLine(vbLf & " Invalid Input")
                        key = Console.ReadKey().Key



                End Select

                name = Console.ReadLine()

                If name.Length < 5 Then
                    Console.WriteLine(vbLf & " Name was too short... it must be at least FIVE characters... so try again!")

                End If

            End While

            Dim health As Single = ReadNumberInput(" Input health", 250, 1250)
            Dim attackDamage As Single = ReadNumberInput(" Input attackDamage", 10, 75)
            Dim armor As Single = ReadNumberInput(" Input armor", 25, 200)
            Dim attackSpeed As Single = ReadNumberInput(" Input attackSpeed", 0.1F, 2.5F)

#Region " Adding different monster types using switch case -->"

            Console.ForegroundColor = ConsoleColor.DarkGreen

            Select Case key


                Case ConsoleKey.D1,
                     ConsoleKey.NumPad1
                    Dim goblin As Creatures = New Goblin(health, attackDamage, armor, attackSpeed, name)
                    creatures.Add(goblin)
                    Console.WriteLine(" You have created a Goblin monster named " & name & ": it has " & health & " hp, " & attackDamage & " attack Damage and " & armor & " armor with " & attackSpeed & " attack Speed! ")

                Case ConsoleKey.D2,
                     ConsoleKey.NumPad2
                    Dim orc As Creatures = New Orc(health, attackDamage, armor, attackSpeed, name)
                    creatures.Add(orc)
                    Console.WriteLine(" You have created a Orc monster named " & name & ": it has " & health & " hp, " & attackDamage & " attack Damage and " & armor & " armor with " & attackSpeed & " attack Speed! ")

                Case ConsoleKey.D3,
                     ConsoleKey.NumPad3
                    Dim wyvern As Creatures = New Wyvern(health, attackDamage, armor, attackSpeed, name)
                    creatures.Add(wyvern)
                    Console.WriteLine(" You have created a Wyvern monster named " & name & ": it has " & health & " hp, " & attackDamage & " attack Damage and " & armor & " armor with " & attackSpeed & " attack Speed! ")

                Case ConsoleKey.D4,
                     ConsoleKey.NumPad4
                    Dim dragon As Creatures = New Dragon(health, attackDamage, armor, attackSpeed, name)
                    creatures.Add(dragon)
                    Console.WriteLine(" You have created a Wyvern monster named " & name & ": it has " & health & " hp, " & attackDamage & " attack Damage and " & armor & " armor with " & attackSpeed & " attack Speed! ")

                Case ConsoleKey.D5,
                     ConsoleKey.NumPad5
                    Dim bigfoot As Creatures = New Bigfoot(health, attackDamage, armor, attackSpeed, name)
                    creatures.Add(bigfoot)
                    Console.WriteLine(" You have created a Wyvern monster named " & name & ": it has " & health & " hp, " & attackDamage & " attack Damage and " & armor & " armor with " & attackSpeed & " attack Speed! ")

                Case ConsoleKey.D6,
                 ConsoleKey.NumPad6
                    Dim vampyre As Creatures = New Vampyre(health, attackDamage, armor, attackSpeed, name)
                    creatures.Add(vampyre)
                    Console.WriteLine(" You have created a Wyvern monster named " & name & ": it has " & health & " hp, " & attackDamage & " attack Damage and " & armor & " armor with " & attackSpeed & " attack Speed! ")

                Case ConsoleKey.D7,
                 ConsoleKey.NumPad7
                    Dim Werewolve As Creatures = New Werewolve(health, attackDamage, armor, attackSpeed, name)
                    creatures.Add(Werewolve)
                    Console.WriteLine(" You have created a Wyvern monster named " & name & ": it has " & health & " hp, " & attackDamage & " attack Damage and " & armor & " armor with " & attackSpeed & " attack Speed! ")

                Case ConsoleKey.Enter
                    If creatures.Count >= 2 Then
                        IsCrafting = False
                    Else
                        Console.WriteLine(" There must be at least 2 differet type of creatures! Please create another type of monster and try again!")
                    End If

                Case Else
                    Console.WriteLine(" Invalid key, Please try again!")

            End Select

#End Region

        End While

        StartBattle()

    End Sub

    Private Sub StartBattle()

        Dim LastManStanding As Boolean = False

        'creatures = creatures.orde(Creature, floa)(Function(creature) creature.AttackSpeed).ToList(Of Creature)()

        Console.WriteLine(" Is sorting...")

        While Not LastManStanding
            For i As Integer = 0 To Creatures.Count - 1
                For j As Integer = 0 To Creatures.Count - 1
                    If Creatures(i).GetType() IsNot Creatures(j).GetType() Then
                        Creatures(i).Attack(Creatures(j))
                        Exit For
                    End If
                Next j
            Next i

            Dim CreateType As Type = Nothing
            Dim IsOtherType As Boolean = False

            For i As Integer = 0 To Creatures.Count - 1
                If CreateType = Nothing AndAlso Creatures(i) IsNot Nothing Then
                    CreateType = Creatures(i).GetType()
                    Console.WriteLine("type = " & CreateType.ToString)
                End If

                If Creatures(i).GetType() IsNot CreateType Then
                    IsOtherType = True
                End If
            Next

            If Not IsOtherType Then
                LastManStanding = True
            End If

            Console.WriteLine(" Round hasended...!")
            Console.Read()

        End While

        Console.Read()

    End Sub

    Public Shared Function ReadNumberInput(ByVal attention As String, ByVal lowestLimit As Single, ByVal highestLimit As Single)

        If lowestLimit >= highestLimit AndAlso highestLimit <= lowestLimit Then
            Console.WriteLine("Whöt...?!?!?!")
        End If

        Console.WriteLine(attention & " (Allowed numbers are between min. " & lowestLimit & " to max. " & highestLimit & ")")

        Dim inputNumber As Single = Nothing

        While True

            If Single.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.CurrentCulture, inputNumber) Then

                If inputNumber <= highestLimit AndAlso inputNumber >= lowestLimit Then
                    Return inputNumber
                End If
            End If

            Console.WriteLine("Invalid input, Please try again and press Enter!")

        End While

        Return False

    End Function

End Class
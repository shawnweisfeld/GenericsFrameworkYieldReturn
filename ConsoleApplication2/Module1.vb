Module Module1

    Sub Main()

        Dim b = New B().GetTs(Of Tester)().First()
        Console.WriteLine("Done in VB!")
        Console.ReadKey()

    End Sub

End Module

Public Class A

    Public Overridable Function GetTs(Of t As {New})() As IEnumerable(Of t)
        Return New t() {New t}
    End Function

End Class

Public Class B
    Inherits A

    Public Overrides Iterator Function GetTs(Of t As New)() As IEnumerable(Of t)
        For Each x In MyBase.GetTs(Of t)()
            Yield x
        Next
    End Function

End Class

Public Class Tester

End Class
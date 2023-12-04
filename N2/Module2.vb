Imports System.Text

Module Module2
    Private Const m_MinimumLength As Integer = 128
    Private Const m_LowercaseChars As String = "abcdefghijklmnopqrstuvqxyz"
    Private Const m_UppercaseChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Private Const m_NumericChars As String = "123456890"
    Function Generate() As String
        Return Generate(m_MinimumLength)
    End Function

    Function Generate(ByVal length As Integer) As String
        Return Generate(length, Environment.TickCount)
    End Function

    Private Function Generate(ByVal length As Integer, ByVal seed As Integer) As String
        If length < 4 Then Throw New ArgumentException("String length must be at least 4 characters")
        Dim SB As StringBuilder = New StringBuilder()
        Dim rand As Random = New Random(seed)
        SB.Append(GetRandomCharacter(m_LowercaseChars, rand))
        SB.Append(GetRandomCharacter(m_UppercaseChars, rand))
        SB.Append(GetRandomCharacter(m_NumericChars, rand))

        While SB.Length < length
            SB.Append(GetRandomCharacter(GetRandomString(rand), rand))
        End While

        Return SB.ToString()
    End Function

    Private Function GetRandomString(ByVal rand As Random) As String
        Dim a As Integer = rand.[Next](2)

        Select Case a
            Case 1
                Return m_UppercaseChars
            Case 2
                Return m_NumericChars
            Case Else
                Return m_LowercaseChars
        End Select
    End Function

    Private Function GetRandomCharacter(ByVal s As String, ByVal rand As Random) As Char
        Dim x As Integer = rand.[Next](s.Length)
        Dim a As String = s.Substring(x, 1)
        Dim b As Char = Convert.ToChar(a)
        Return (b)
    End Function
End Module

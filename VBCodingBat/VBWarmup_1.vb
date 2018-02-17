Imports System.Text
Module VBWarmup_1

    Sub Main()
        Console.WriteLine("sleepIn")
        Console.WriteLine(sleepIn(False, False) = True)
        Console.WriteLine(sleepIn(True, False) = False)
        Console.WriteLine(sleepIn(False, True) = True)

        Console.WriteLine("monkeyTrouble")
        Console.WriteLine(monkeyTrouble(True, True) = True)
        Console.WriteLine(monkeyTrouble(False, False) = True)
        Console.WriteLine(monkeyTrouble(True, False) = False)

        Console.WriteLine("sumDouble")
        Console.WriteLine(sumDouble(1, 2) = 3)
        Console.WriteLine(sumDouble(3, 2) = 5)
        Console.WriteLine(sumDouble(2, 2) = 8)

        Console.WriteLine("close10")
        Console.WriteLine(close10(8, 13) = 8)
        Console.WriteLine(close10(13, 8) = 8)
        Console.WriteLine(close10(13, 7) = 0)

        Console.WriteLine("stringC")
        Console.WriteLine(stringC("Hello", CChar("e"), 1, 3) = True)
        Console.WriteLine(stringC("Everyone", CChar("e"), 1, 3) = True)
        Console.WriteLine(stringC("Heelele", CChar("e"), 1, 3) = False)

        Console.WriteLine("stringCLinq")
        Console.WriteLine(stringCLinq("Hello", CChar("e"), 1, 3) = True)
        Console.WriteLine(stringCLinq("Everyone", CChar("e"), 1, 3) = True)
        Console.WriteLine(stringCLinq("Heelele", CChar("e"), 1, 3) = False)

        Console.WriteLine("lastDigit")
        Console.WriteLine(lastDigit(7, 17) = True)
        Console.WriteLine(lastDigit(6, 17) = False)
        Console.WriteLine(lastDigit(3, 113) = True)

        Console.WriteLine("endUp")
        Console.WriteLine(endUp("Hello", 3) = "HeLLO")
        Console.WriteLine(endUp("hi there", 3) = "hi thERE")
        Console.WriteLine(endUp("hi", 3) = "HI")

        Console.WriteLine("everyNth")
        Console.WriteLine(everyNth("Miracle", 2) = "Mrce")
        Console.WriteLine(everyNth("abcdefg", 2) = "aceg")
        Console.WriteLine(everyNth("abcdefg", 3) = "adg")

        Console.ReadKey()

    End Sub


    'The parameter weekday Is True If it Is a weekday, And the parameter vacation 
    'Is true if we are on vacation. We sleep in if it Is Not a weekday Or we're on 
    'vacation. Return true if we sleep in. 

    'sleepIn(false, false) → true
    'sleepIn(true, false) → false
    'sleepIn(false, true) → true

    Public Function sleepIn(weekday As Boolean, vacation As Boolean) As Boolean
        Return vacation Or Not weekday
    End Function


    'We have two monkeys, a And b, And the parameters aSmile And bSmile indicate 
    'If each Is smiling. We are in trouble if they are both smiling Or if neither 
    'of them Is smiling. Return true if we are in trouble. 

    'monkeyTrouble(true, true) → true
    'monkeyTrouble(false, false) → true
    'monkeyTrouble(true, false) → false

    Public Function monkeyTrouble(aSmile As Boolean, bSmile As Boolean) As Boolean
        Return aSmile = bSmile
    End Function


    'Given two int values, Return their sum. Unless the two values are the same, 
    'then return double their sum. 

    'sumDouble(1, 2) → 3
    'sumDouble(3, 2) → 5
    'sumDouble(2, 2) → 8

    Public Function sumDouble(a As Integer, b As Integer) As Integer

        If (a = b) Then
            Return 2 * (a + b)
        Else
            Return a + b
        End If

    End Function


    'Given 2 int values, return whichever value Is nearest to the value 10, or 
    'return 0 In the Event Of a tie. 

    'close10(8, 13) → 8
    'close10(13, 8) → 8
    'close10(13, 7) → 0

    Public Function close10(a As Integer, b As Integer) As Integer

        Dim a10 As Integer = Math.Abs(a - 10)
        Dim b10 As Integer = Math.Abs(b - 10)

        If (a10 < b10) Then
            Return a
        ElseIf (b10 < a10)
            Return b
        Else
            Return 0
        End If

    End Function


    'Return True If the given String contains between min And max 'c' chars. 

    'stringC("Hello", 'e', 1, 3) → true
    'stringC("Everyone", 'e', 1, 3) → true
    'stringC("Heelele", 'e', 1, 3) → false

    Public Function stringC(str As String, c As Char, min As Integer, max As Integer) As Boolean

        Dim count As Integer = 0

        If (Not String.IsNullOrEmpty(str)) Then
            For Each ch As Char In str
                If (Char.ToLower(ch) = Char.ToLower(c)) Then
                    count += 1
                End If
            Next
        End If

        Return count >= min And count <= max
    End Function


    'Return True If the given String contains between min And max 'c' chars. 
    'Use Linq. Do Not use loops.
    'stringCLinq("Hello", 'e', 1, 3) → true
    'stringCLinq("Everyone", 'e', 1, 3) → true
    'stringCLinq("Heelele", 'e', 1, 3) → false

    Public Function stringCLinq(str As String, c As Char, min As Integer, max As Integer) As Boolean
        Return True
    End Function


    'Given two non-negative int values, Return True If they have the same last digit, 
    'such as with 27 And 57. 

    'lastDigit(7, 17) → true
    'lastDigit(6, 17) → false
    'lastDigit(3, 113) → true

    Public Function lastDigit(a As Integer, b As Integer) As Boolean
        Return a Mod 10 = b Mod 10
    End Function


    'Given a String, Return a New String where the last 'num' chars are 
    'now in upper case. If the string has less than 'num' chars, 
    'uppercase whatever Is there. 

    'endUp("Hello", 3) → "HeLLO"
    'endUp("hi there", 3) → "hi thERE"
    'endUp("hi", 3) → "HI"

    Public Function endUp(str As String, num As Integer) As String

        If (num <= 0) Then
            Return str
        ElseIf (str.Length > num)
            Dim front As String
            front = str.Substring(0, str.Length - num)
            Dim back As String
            back = str.Substring(str.Length - num)
            Return front + back.ToUpper()
        Else
            Return str.ToUpper()
        End If


    End Function


    'Given a non-empty String And an int N, Return the String made starting 
    'With Char 0, And Then every Nth Char Of the String. 
    'So if N Is 3, use char 0, 3, 6, ... And so on. N Is 1 Or more. 

    'everyNth("Miracle", 2) → "Mrce"
    'everyNth("abcdefg", 2) → "aceg"
    'everyNth("abcdefg", 3) → "adg"

    Public Function everyNth(str As String, n As Integer) As String

        Dim sb As New StringBuilder
        For i As Integer = 1 To str.Length Step n
            sb.Append(GetChar(str, i))
        Next
        Return sb.ToString()
    End Function

End Module

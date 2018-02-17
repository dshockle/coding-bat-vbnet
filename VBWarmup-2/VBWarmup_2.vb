Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Module VBWarmup_2

    Sub Main()
        Console.WriteLine("stringTimes")
        Console.WriteLine(stringTimes("Hi", 2) = "HiHi")
        Console.WriteLine(stringTimes("Hi", 3) = "HiHiHi")
        Console.WriteLine(stringTimes("Hi", 1) = "Hi")

        Console.WriteLine("stringTimesLinq")
        Console.WriteLine(stringTimesLinq("Hi", 2) = "HiHi")
        Console.WriteLine(stringTimesLinq("Hi", 3) = "HiHiHi")
        Console.WriteLine(stringTimesLinq("Hi", 1) = "Hi")

        Console.WriteLine("frontTimes")
        Console.WriteLine(frontTimes("Chocolate", 2) = "ChoCho")
        Console.WriteLine(frontTimes("Chocolate", 3) = "ChoChoCho")
        Console.WriteLine(frontTimes("Abc", 3) = "AbcAbcAbc")

        Console.WriteLine("frontTimesLinq")
        Console.WriteLine(frontTimesLinq("Chocolate", 2) = "ChoCho")
        Console.WriteLine(frontTimesLinq("Chocolate", 3) = "ChoChoCho")
        Console.WriteLine(frontTimesLinq("Abc", 3) = "AbcAbcAbc")

        Console.WriteLine("countXX")
        Console.WriteLine(countXX("abcxx") = 1)
        Console.WriteLine(countXX("xxx") = 2)
        Console.WriteLine(countXX("xxxx") = 3)

        Console.WriteLine("countXXLinq")
        Console.WriteLine(countXXLinq("abcxx") = 1)
        Console.WriteLine(countXXLinq("xxx") = 2)
        Console.WriteLine(countXXLinq("xxxx") = 3)

        Console.WriteLine("doubleX")
        Console.WriteLine(doubleX("axXbb") = True)
        Console.WriteLine(doubleX("axaxx") = False)
        Console.WriteLine(doubleX("Xxxxx") = True)

        Console.WriteLine("stringBits")
        Console.WriteLine(stringBits("Hello") = "Hlo")
        Console.WriteLine(stringBits("Hi") = "H")
        Console.WriteLine(stringBits("Heeololeo") = "Hello")

        Console.WriteLine("stringSplosion")
        Console.WriteLine(stringSplosion("Code") = "CCoCodCode")
        Console.WriteLine(stringSplosion("abc") = "aababc")
        Console.WriteLine(stringSplosion("ab") = "aab")

        Console.WriteLine("stringX")
        Console.WriteLine(stringX("xxHxix") = "xHix")
        Console.WriteLine(stringX("abxxxcd") = "abcd")
        Console.WriteLine(stringX("xabxxxcdx") = "xabcdx")

        Console.WriteLine("altPairs")
        Console.WriteLine(altPairs("kitten") = "kien")
        Console.WriteLine(altPairs("Chocolate") = "Chole")
        Console.WriteLine(altPairs("CodingHorror") = "Congrr")

        Console.WriteLine("stringYak")
        Console.WriteLine(stringYak("yakpak") = "pak")
        Console.WriteLine(stringYak("pakyak") = "pak")
        Console.WriteLine(stringYak("yak123ya") = "123ya")

        Console.WriteLine("noTriples")
        Console.WriteLine(noTriples(1, 1, 2, 2, 1) = True)
        Console.WriteLine(noTriples(1, 1, 2, 2, 2, 1) = False)
        Console.WriteLine(noTriples(1, 1, 1, 2, 2, 2, 1) = False)

        Console.WriteLine("noTriplesLinq")
        Console.WriteLine(noTriplesLinq(1, 1, 2, 2, 1) = True)
        Console.WriteLine(noTriplesLinq(1, 1, 2, 2, 2, 1) = False)
        Console.WriteLine(noTriplesLinq(1, 1, 1, 2, 2, 2, 1) = False)

        Console.ReadKey()

    End Sub


    'Given a String And a non-negative int n, Return a larger String 
    'that Is n copies of the original string. 
    'stringTimes("Hi", 2) → "HiHi"
    'stringTimes("Hi", 3) → "HiHiHi"
    'stringTimes("Hi", 1) → "Hi"

    Public Function stringTimes(str As String, n As Integer) As String
        Dim sb As New StringBuilder

        For i As Integer = 1 To n
            sb.Append(str)
        Next

        Return sb.ToString()

    End Function

    'Given a String And a non-negative int n, Return a larger String 
    'that Is n copies of the original string. Use Linq. Do Not use loops.
    'stringTimesLinq("Hi", 2) → "HiHi"
    'stringTimesLinq("Hi", 3) → "HiHiHi"
    'stringTimesLinq("Hi", 1) → "Hi"

    Public Function stringTimesLinq(str As String, n As Integer) As String

        Return String.Concat(Enumerable.Repeat(str, n))

    End Function

    'Given a String And a non-negative int n, 
    'we'll say that the front of the string is the first 3 chars, 
    'Or whatever Is there if the string Is less than length 3. 
    'Return n copies Of the front 

    'frontTimes("Chocolate", 2) → "ChoCho"
    'frontTimes("Chocolate", 3) → "ChoChoCho"
    'frontTimes("Abc", 3) → "AbcAbcAbc"

    Public Function frontTimes(str As String, n As Integer) As String

        Dim sb As New StringBuilder
        Dim front As String = str.Substring(0, Math.Min(str.Length, 3))

        For i As Integer = 1 To n
            sb.Append(front)
        Next
        Return sb.ToString()

    End Function

    'Given a String And a non-negative int n, 
    'we'll say that the front of the string is the first 3 chars, 
    'Or whatever Is there if the string Is less than length 3. 
    'Return n copies Of the front. Use Linq. Do Not use loops.

    'frontTimesLinq("Chocolate", 2) → "ChoCho"
    'frontTimesLinq("Chocolate", 3) → "ChoChoCho"
    'frontTimesLinq("Abc", 3) → "AbcAbcAbc"

    Public Function frontTimesLinq(str As String, n As Integer) As String

        Return String.Concat(Enumerable.Repeat(str.Substring(0, 3), n))

    End Function

    'Count the number Of "xx" In the given String. 
    'We'll say that overlapping is allowed, so "xxx" contains 2. 
    'countXX("abcxx") → 1
    'countXX("xxx") → 2
    'countXX("xxxx") → 3

    Public Function countXX(str As String) As Integer

        Dim count As Integer = 0

        For i As Integer = 1 To str.Length - 1
            If str(i) = CChar("x") And str(i - 1) = "x" Then
                count += 1
            End If
        Next
        Return count

    End Function

    'Count the number Of "xx" In the given String. 
    'We'll say that overlapping is allowed, so "xxx" contains 2. 
    'Use Linq. Do Not use loops.
    'countXXLinq("abcxx") → 1
    'countXXLinq("xxx") → 2
    'countXXLinq("xxxx") → 3

    Public Function countXXLinq(str As String) As Integer
        Dim result As Integer = str.Where((Value) >= Value = CChar("x")).Count()
        Return result
    End Function

    'Given a String, Return True If the first instance Of "x" In the String 
    'Is immediately followed by another "x". 
    'doubleX("axxbb") → true
    'doubleX("axaxx") → false
    'doubleX("xxxxx") → true

    Public Function doubleX(str As String) As Boolean

        Dim lowerCaseStr As String = str.ToLower()
        Dim pos As Integer = lowerCaseStr.IndexOf("x")
        Return pos > -1 And pos < str.Length - 1 And lowerCaseStr(pos + 1) = CChar("x")

    End Function

    'Given a String, Return a New String made Of every other Char starting 
    'With the first, so "Hello" yields "Hlo". 

    'stringBits("Hello") → "Hlo"
    'stringBits("Hi") → "H"
    'stringBits("Heeololeo") → "Hello"


    Public Function stringBits(str As String) As String

        Dim sb As New StringBuilder
        For i As Integer = 0 To str.Length - 1 Step 2
            sb.Append(str(i))
        Next
        Return sb.ToString()

    End Function

    'Given a non-empty String Like "Code" Return a String Like "CCoCodCode". 

    'stringSplosion("Code") → "CCoCodCode"
    'stringSplosion("abc") → "aababc"
    'stringSplosion("ab") → "aab"

    Public Function stringSplosion(str As String) As String

        Dim sb As New StringBuilder
        For i As Integer = 0 To str.Length - 1

            sb.Append(str.Substring(0, i + 1))
        Next
        Return sb.ToString()

    End Function

    'Given a String, Return a version where all the "x" have been removed. 
    'Except an "x" at the very start Or End should Not be removed. 

    'stringX("xxHxix") → "xHix"
    'stringX("abxxxcd") → "abcd"
    'stringX("xabxxxcdx") → "xabcdx"

    Public Function stringX(str As String) As String
        Dim noX As String = Regex.Replace(str.Substring(1, str.Length - 2), "x", "", RegexOptions.IgnoreCase)
        Return str(0) + noX + str(str.Length - 1)

    End Function

    'Given a String, Return a String made Of the chars at 
    'indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien". 

    'altPairs("kitten") → "kien"
    'altPairs("Chocolate") → "Chole"
    'altPairs("CodingHorror") → "Congrr

    Public Function altPairs(str As String) As String
        Dim sb As New StringBuilder

        For i As Integer = 0 To str.Length - 1 Step 4
            sb.Append(str(i))

            If i < str.Length - 1 Then
                sb.Append(str(i + 1))
            End If
        Next

        Return sb.ToString()

    End Function

    'Suppose the string "yak" is unlucky. 
    'Given a string, return a version where all the "yak" are removed, 
    'but the "a" can be any char. The "yak" strings will not overlap. 

    'stringYak("yakpak") → "pak"
    'stringYak("pakyak") → "pak"
    'stringYak("yak123ya") → "123ya"

    Public Function stringYak(str As String) As String

        Return System.Text.RegularExpressions.Regex.Replace(str, "y.k", "")

    End Function


    'Given an array of ints, we'll say that a triple is a value appearing 3 times 
    'in a row in the array. Return true if the array does not contain any triples. 

    'noTriples(1, 1, 2, 2, 1) → true
    'noTriples(1, 1, 2, 2, 2, 1) → false
    'noTriples(1, 1, 1, 2, 2, 2, 1) → false

    Public Function noTriples(nums() As Integer) As Boolean

        For i As Integer = 2 To nums.Length - 1
            If (nums(i) = nums(i - 1) And nums(i) = nums(i - 2)) Then
                Return False
            End If
        Next

        Return True
    End Function



    'Given an array of ints, we'll say that a triple is a value appearing 3 times 
    'in a row in the array. Return true if the array does not contain any triples. 
    'Use Linq. Do not use loops.
    'noTriplesLinq(1, 1, 2, 2, 1) → true
    'noTriplesLinq(1, 1, 2, 2, 2, 1) → false
    'noTriplesLinq(1, 1, 1, 2, 2, 2, 1) → false

    Public Function noTriplesLinq(nums() As Integer) As Boolean
        Return 0
    End Function

End Module

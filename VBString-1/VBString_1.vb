Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Module VBString_1

    Sub Main()

        Console.WriteLine("seeColor")
            Console.WriteLine(seeColor("redxx") = "red")
            Console.WriteLine(seeColor("xxred") = "")
            Console.WriteLine(seeColor("blueTimes") = "blue")

            Console.WriteLine("seeColorLinq")
            Console.WriteLine(seeColorLinq("redxx") = "red")
            Console.WriteLine(seeColorLinq("xxred") = "")
            Console.WriteLine(seeColorLinq("blueTimes") = "blue")
    
            Console.WriteLine("frontAgain")
            Console.WriteLine(frontAgain("edited") = True)
            Console.WriteLine(frontAgain("edit") = False)
            Console.WriteLine(frontAgain("ed") = True)

            Console.WriteLine("minCat")
            Console.WriteLine(minCat("Hello", "Hi") = "loHi")
            Console.WriteLine(minCat("Hello", "java") = "ellojava")
            Console.WriteLine(minCat("java", "Hello") = "javaello")

            Console.WriteLine("extraFront")
            Console.WriteLine(extraFront("Hello", 3) = "HelHelHel")
            Console.WriteLine(extraFront("ab", 2) = "abab")
            Console.WriteLine(extraFront("H", 3) = "HHH")

            Console.WriteLine("without2")
            Console.WriteLine(without2("HelloHe") = "lloHe")
            Console.WriteLine(without2("HelloHi") = "HelloHi")
            Console.WriteLine(without2("") = "")
            Console.WriteLine(without2(null) = "")
            Console.WriteLine(without2("H") = "H")
            Console.WriteLine(without2("Hi") = "")

            Console.WriteLine("deFront")
            Console.WriteLine(deFront("Hello") = "llo")
            Console.WriteLine(deFront("java") = "va")
            Console.WriteLine(deFront("away") = "aay")

            Console.WriteLine("startWord")
            Console.WriteLine(startWord("hippo", "hi") = "hi")
            Console.WriteLine(startWord("hippo", "xip") = "hip")
            Console.WriteLine(startWord("hippo", "z") = "h")

            Console.WriteLine("withoutX")
            Console.WriteLine(withoutX("xHix") = "Hi")
            Console.WriteLine(withoutX("xHi") = "Hi")
            Console.WriteLine(withoutX("Hxix") = "Hxi")

            Console.WriteLine("withoutX2")
            Console.WriteLine(withoutX2("xHi") = "Hi")
            Console.WriteLine(withoutX2("Hxi") = "Hi")
            Console.WriteLine(withoutX2("Hi") = "Hi")

        

        End Function
        Given a String, If the String begins With "red" Or "blue" Return that color String,
        otherwise return the empty string. 

        seeColor("redxx") → "red"
        seeColor("xxred") → ""
        seeColor("blueTimes") → "blue"
        
        Public Function String seeColor(String str)
        
            var values = Enum.GetNames(TypeOf(Colors))
            foreach(String color In values)
            
                If (Str.Trim().ToLower().StartsWith(color)) Then
            Return color
            
            Return ""
        
        Private Enum Colors  red, green, blue, yellow 

        End Function
        Given a String, If the String begins With "red" Or "blue" Return that color String, 
        otherwise return the empty string. Use Linq. Do Not use loops.

        seeColorLinq("redxx") → "red"
        seeColorLinq("xxred") → ""
        seeColorLinq("blueTimes") → "blue"
        
        Public Function String seeColorLinq(String str)
        
            var values = Enum.GetNames(TypeOf(Colors))
            Return values.Where(value >= str.Trim().ToLower().StartsWith(value))
    .DefaultIfEmpty(String.Empty).First()
        

        End Function
        Given a String, Return True If the first 2 chars In the String also appear at 
        the end of the string, such as with "edited". 

        frontAgain("edited") → true
        frontAgain("edit") → false
        frontAgain("ed") → true
        
        Public Function Boolean frontAgain(String str)
        
            Return str.Substring(0, 2)
    .Equals(str.Substring(str.Length - 2),
        StringComparison.CurrentCultureIgnoreCase)
        

        End Function
            Given two strings, append them together And Return the result. 
            However, if the strings are different lengths, omit chars 
            from the longer String so it Is the same length As the 
            shorter string. So "Hello" And "Hi" yield "loHi". 
            The strings may be any length including empty. 

            minCat("Hello", "Hi") → "loHi"
            minCat("Hello", "java") → "ellojava"
            minCat("java", "Hello") → "javaello"        
        
        Public Function String minCat(String a, String b)
        
            If (a.Length > b.Length)
    Return a.Substring(a.Length - b.Length) + b
            ElseIf (a.Length < b.Length)
    Return a + b.Substring(b.Length - a.Length)
            Else
    Return a + b
        

        End Function
        Given a String, Return a New String made Of n copies Of the first n chars. 
        If there are fewer than n chars, use whatever Is there. 

        extraFront("Hello", 3) → "HelHelHel"
        extraFront("ab", 2) → "abab"
        extraFront("H", 3) → "HHH"        
        
        Public Function String extraFront(String str, int n)
        
            String item = str.Substring(0, Math.Min(n, str.Length))
            Return String.Concat(Enumerable.Repeat(item, n))
        

        End Function

        Given a String, If a length 2 substring appears at both its beginning 
        And end, return a string without the substring at the beginning, 
        so "HelloHe" yields "lloHe". The substring may overlap with itself, 
        so "Hi" yields "". Otherwise, return the original string unchanged. 

        without2("HelloHe") → "lloHe"
        without2("HelloHi") → "HelloHi"
        without2("Hi") → ""        
        
        Public Function String without2(String str)
        
            If (String.IsNullOrEmpty(str))
    Return ""
            ElseIf (str.Length < 2)
    Return str
            ElseIf (str.Substring(0, 2).Equals(str.Substring(str.Length - 2),
                StringComparison.CurrentCultureIgnoreCase))
    Return str.Substring(2)
            Else
    Return str
        

        End Function
            Given a String, Return a version without the first 2 chars. 
            Except keep the first Char If it Is 'a' and keep the second 
            Char If it Is 'b'. The string may be any length. Harder than it looks. 

            deFront("Hello") → "llo"
            deFront("java") → "va"
            deFront("away") → "aay"        
        
        Public Function String deFront(String str)
        
            Dim sb As New StringBuilder
            If (str.Length > 0 And str[0] = 'a')
                sb.Append(str[0])
            If (str.Length > 1 And str[1] = 'b')
                sb.Append(str[1])
            If (str.Length > 2)
                sb.Append(str.Substring(2))
            Return sb.ToString()
        

        End Function
            Given a String And a second "word" String, we'll say that the word matches 
            the string if it appears at the front of the string, except its first char 
            does Not need to match exactly. On a match, return the front of the string, 
            Or otherwise return the empty string. So, so with the string "hippo" 
            the word "hi" returns "hi" And "xip" returns "hip". The word will be at 
            least length 1. 

            startWord("hippo", "hi") → "hi"
            startWord("hippo", "xip") → "hip"
            startWord("hippo", "z") → "h"        
        
        Public Function String startWord(String str, String word)
        
            If (str.Substring(1, word.Length - 1).Equals(word.Substring(1)))
    Return str.Substring(0, word.Length)
            Else
    Return ""
        

        End Function
            Given a String, If the first Or last chars are 'x', return the string 
            without those 'x' chars, and otherwise return the string unchanged. 

            withoutX("xHix") → "Hi"
            withoutX("xHi") → "Hi"
            withoutX("Hxix") → "Hxi"        
        
        Public Function String withoutX(String str)
        
            Dim sb As New StringBuilder

            If (str.Length > 0 And str[0] != 'x')
                sb.Append(str[0])

            If (str.Length > 2)
                sb.Append(str.Substring(1, str.Length - 2))

            If (str.Length > 1 And str[str.Length - 1] != 'x')
                sb.Append(str[str.Length - 1])

            Return sb.ToString()
        

        End Function
            Given a String, If one Or both Of the first 2 chars Is 'x', return 
            the string without those 'x' chars, and otherwise return the string 
            unchanged. This Is a little harder than it looks. 

            withoutX2("xHi") → "Hi"
            withoutX2("Hxi") → "Hi"
            withoutX2("Hi") → "Hi"        
        
        Public Function String withoutX2(String str)
        
            Dim sb As New StringBuilder

            If (str.Length > 0 And str[0] != 'x')
                sb.Append(str[0])

            If (str.Length > 1 And str[1] != 'x')
                sb.Append(str[1])

            If (str.Length > 2)
                sb.Append(str.Substring(2))

            Return sb.ToString()
        
    


    End Sub

End Module

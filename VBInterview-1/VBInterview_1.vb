Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Module VBInterview_1

    Sub Main()


        Console.WriteLine("isPalindrome")
            Console.WriteLine(isPalindrome("A man, a plan, a canal: Panama!") = true)

            Console.WriteLine("isPalindromeLinq")
            Console.WriteLine(isPalindromeLinq("A man, a plan, a canal: Panama!") = true)

            Console.WriteLine("countLetters")
            Console.WriteLine(countLetters("The quick brown fox jumped over the lazy dogs."))

            Console.WriteLine("countWords")
            Console.WriteLine(countWords("This is fun and this is easy"))

        

        End Function
        Console.WriteLine("isPalindrome")
        Console.WriteLine("Is it a palindrome ignoring punctuation and case.")
        Console.WriteLine(isPalindrome("A man, a plan, a canal: panama!") = true)
        
        Public Function bool isPalindrome(String word)
        
            Dim sb As New StringBuilder

            foreach (char c in word)
            
                If (Char.IsLetterOrDigit(c))
                    sb.Append(char.ToLower(c))
            
            
            For (Dim i As Integer= 0 i < sb.Length / 2 i++)
                If (sb[i] != sb[sb.Length - 1 - i])
                    Return False

            Return True
        

        End Function
        Console.WriteLine("isPalindrome")
        Console.WriteLine("Is it a palindrome ignoring punctuation and case.")
        Console.WriteLine(isPalindromeLinq("A man, a plan, a canal: panama!") = true)
        Use Linq. Do Not use loops.
        
        Public Function bool isPalindromeLinq(String word)
        
            Char[] chars = word.ToLower().Trim()
                    .Where(c >= Char.IsLetterOrDigit(c))
        .ToArray()

            Return chars.SequenceEqual(chars.Reverse())
        

        End Function
        Console.WriteLine("countLetters")
        Console.WriteLine("Count times each letter appears in string")
        Console.WriteLine(countLetters("The quick brown fox jumped over the lazy dogs."))
        
        Public Function String countLetters(String sentence)
        
            Dictionary<char, int> counts  =  New Dictionary<char, int>()

            foreach (char ch in sentence)
            
                If (Char.IsLetterOrDigit(ch))
                
                    Char c = Char.ToLower(ch)

                    If (counts.ContainsKey(c))
                        counts[c]++
                    Else
                        counts.Add(c, 1)
                
            

            Dim sb As New StringBuilder

            var list = counts.Keys.ToList()
            list.Sort()

            foreach (var key in list)
                sb.AppendLine(key + " : " + counts[key])

            Return sb.ToString()
        

        End Function
        Console.WriteLine("countWords")
        Console.WriteLine("Count times each word appears in string")
        Console.WriteLine(countWords("This is fun and this is easy"))
        
        Public Function String countWords(String sentence)
        
            Dictionary<string, int> counts = New Dictionary<string, int>()
            String[] rawlist = sentence.ToLower().Trim().Split()
            End Function
            var rawlist = sentence
        .ToLower().Trim().Split()
        .Select(word >= word.Trim())
        .Where(word >=!string.IsNullOrEmpty(word))
            
            foreach (string word in rawlist)
            
                If (counts.ContainsKey(word))
                    counts[word]++
                Else
                    counts.Add(word, 1)
            

            Dim sb As New StringBuilder

            var list = counts.Keys.ToList()
            list.Sort()

            foreach (var key in list)
                sb.AppendLine(key + " : " + counts[key])

            Return sb.ToString()

        
    


    End Sub

End Module

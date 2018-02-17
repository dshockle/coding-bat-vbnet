Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Module VBAP_1

    Sub Main()

        Console.WriteLine("scoresIncreasing")
            Console.WriteLine(scoresIncreasing(Dim nums() as Integer =   1, 3, 4 ) = true)
            Console.WriteLine(scoresIncreasing(Dim nums() as Integer =   1, 3, 2 ) = false)
            Console.WriteLine(scoresIncreasing(Dim nums() as Integer =   1, 1, 4 ) = true)

            Console.WriteLine("scoresIncreasingLinq")
            Console.WriteLine(scoresIncreasingLinq(Dim nums() as Integer =   1, 3, 4 ) = true)
            Console.WriteLine(scoresIncreasingLinq(Dim nums() as Integer =   1, 3, 2 ) = false)
            Console.WriteLine(scoresIncreasingLinq(Dim nums() as Integer =   1, 1, 4 ) = true)

            Console.WriteLine("scores100")
            Console.WriteLine(scores100(Dim nums() as Integer =   1, 100, 100 ) = true)
            Console.WriteLine(scores100(Dim nums() as Integer =   1, 100, 99, 100 ) = false)
            Console.WriteLine(scores100(Dim nums() as Integer =   100, 1, 100, 100 ) = true)

            Console.WriteLine("scores100Linq")
            Console.WriteLine(scores100Linq(Dim nums() as Integer =   1, 100, 100 ) = true)
            Console.WriteLine(scores100Linq(Dim nums() as Integer =   1, 100, 99, 100 ) = false)
            Console.WriteLine(scores100Linq(Dim nums() as Integer =   100, 1, 100, 100 ) = true)

            Console.WriteLine("scoresClump")
            Console.WriteLine(scoresClump(Dim nums() as Integer =   3, 4, 5 ) = true)
            Console.WriteLine(scoresClump(Dim nums() as Integer =   3, 4, 6 ) = false)
            Console.WriteLine(scoresClump(Dim nums() as Integer =   1, 3, 5, 5 ) = true)

            Console.WriteLine("scoresClumpLinq")
            Console.WriteLine(scoresClumpLinq(Dim nums() as Integer =   3, 4, 5 ) = true)
            Console.WriteLine(scoresClumpLinq(Dim nums() as Integer =   3, 4, 6 ) = false)
            Console.WriteLine(scoresClumpLinq(Dim nums() as Integer =   1, 3, 5, 5 ) = true)
            
            Console.WriteLine("scoresAverage")
            Console.WriteLine(scoresAverage(Dim nums() as Integer =   2, 2, 4, 4 ) = 4)
            Console.WriteLine(scoresAverage(Dim nums() as Integer =   4, 4, 4, 2, 2, 2 ) = 4)
            Console.WriteLine(scoresAverage(Dim nums() as Integer =   3, 4, 5, 1, 2, 3 ) = 4)

            Console.WriteLine("scoresAverageLinq")
            Console.WriteLine(scoresAverageLinq(Dim nums() as Integer =   2, 2, 4, 4 ) = 4)
            Console.WriteLine(scoresAverageLinq(Dim nums() as Integer =   4, 4, 4, 2, 2, 2 ) = 4)
            Console.WriteLine(scoresAverageLinq(Dim nums() as Integer =   3, 4, 5, 1, 2, 3 ) = 4)

            Console.WriteLine("wordsCount")
            Console.WriteLine(wordsCount(New string[]  "a", "bb", "b", "ccc" , 1) = 2)
            Console.WriteLine(wordsCount(New string[]  "a", "bb", "b", "ccc" , 3) = 1)
            Console.WriteLine(wordsCount(New string[]  "a", "bb", "b", "ccc" , 4) = 0)

            Console.WriteLine("wordsCountLinq")
            Console.WriteLine(wordsCountLinq(New string[]  "a", "bb", "b", "ccc" , 1) = 2)
            Console.WriteLine(wordsCountLinq(New string[]  "a", "bb", "b", "ccc" , 3) = 1)
            Console.WriteLine(wordsCountLinq(New string[]  "a", "bb", "b", "ccc" , 4) = 0)
            
            Console.WriteLine("wordsFront")
            Console.WriteLine(wordsFront(New string[]  "a", "b", "c", "d" , 1).SequenceEqual(New string[]  "a" ))
            Console.WriteLine(wordsFront(New string[]  "a", "b", "c", "d" , 2).SequenceEqual(New string[]  "a", "b" ))
            Console.WriteLine(wordsFront(New string[]  "a", "b", "c", "d" , 3).SequenceEqual(New string[]  "a", "b", "c" ))

            Console.WriteLine("wordsFrontLinq")
            Console.WriteLine(wordsFrontLinq(New string[]  "a", "b", "c", "d" , 1).SequenceEqual(New string[]  "a" ))
            Console.WriteLine(wordsFrontLinq(New string[]  "a", "b", "c", "d" , 2).SequenceEqual(New string[]  "a", "b" ))
            Console.WriteLine(wordsFrontLinq(New string[]  "a", "b", "c", "d" , 3).SequenceEqual(New string[]  "a", "b", "c" ))
            
            Console.WriteLine("wordsWithoutList")
            Console.WriteLine(wordsWithoutList(New string[]  "a", "bb", "b", "ccc" , 1).SequenceEqual(New string[]  "bb", "ccc" ))
            Console.WriteLine(wordsWithoutList(New string[]  "a", "bb", "b", "ccc" , 3).SequenceEqual(New string[]  "a", "bb", "b" ))
            Console.WriteLine(wordsWithoutList(New string[]  "a", "bb", "b", "ccc" , 4).SequenceEqual(New string[]  "a", "bb", "b", "ccc" ))

            Console.WriteLine("wordsWithoutListLinq")
            Console.WriteLine(wordsWithoutListLinq(New string[]  "a", "bb", "b", "ccc" , 1).SequenceEqual(New string[]  "bb", "ccc" ))
            Console.WriteLine(wordsWithoutListLinq(New string[]  "a", "bb", "b", "ccc" , 3).SequenceEqual(New string[]  "a", "bb", "b" ))
            Console.WriteLine(wordsWithoutListLinq(New string[]  "a", "bb", "b", "ccc" , 4).SequenceEqual(New string[]  "a", "bb", "b", "ccc" ))
            
            Console.WriteLine("hasOneLinq")
            Console.WriteLine(hasOneLinq(10) = true)
            Console.WriteLine(hasOneLinq(22) = false)
            Console.WriteLine(hasOneLinq(220) = false)

            Console.WriteLine("hasOne")
            Console.WriteLine(hasOne(10) = true)
            Console.WriteLine(hasOne(22) = false)
            Console.WriteLine(hasOne(220) = false)
            
            Console.WriteLine("dividesSelf")
            Console.WriteLine(dividesSelf(128) = true)
            Console.WriteLine(dividesSelf(12) = true)
            Console.WriteLine(dividesSelf(120) = false)
            
            Console.WriteLine("copyEvens")
            Console.WriteLine(copyEvens(Dim nums() as Integer =   3, 2, 4, 5, 8 , 2).SequenceEqual(Dim nums() as Integer =   2, 4 ))
            Console.WriteLine(copyEvens(Dim nums() as Integer =   3, 2, 4, 5, 8 , 3).SequenceEqual(Dim nums() as Integer =   2, 4, 8 ))
            Console.WriteLine(copyEvens(Dim nums() as Integer =   6, 1, 2, 4, 5, 8 , 3).SequenceEqual(Dim nums() as Integer =   6, 2, 4 ))

            Console.WriteLine("copyEvensLinq")
            Console.WriteLine(copyEvensLinq(Dim nums() as Integer =   3, 2, 4, 5, 8 , 2).SequenceEqual(Dim nums() as Integer =   2, 4 ))
            Console.WriteLine(copyEvensLinq(Dim nums() as Integer =   3, 2, 4, 5, 8 , 3).SequenceEqual(Dim nums() as Integer =   2, 4, 8 ))
            Console.WriteLine(copyEvensLinq(Dim nums() as Integer =   6, 1, 2, 4, 5, 8 , 3).SequenceEqual(Dim nums() as Integer =   6, 2, 4 ))
            
            Console.WriteLine("copyEndy")
            Console.WriteLine(copyEndy(Dim nums() as Integer =   9, 11, 90, 22, 6 , 2).SequenceEqual(Dim nums() as Integer =   9, 90 ))
            Console.WriteLine(copyEndy(Dim nums() as Integer =   9, 11, 90, 22, 6 , 3).SequenceEqual(Dim nums() as Integer =   9, 90, 6 ))
            Console.WriteLine(copyEndy(Dim nums() as Integer =   12, 1, 1, 13, 0, 20 , 2).SequenceEqual(Dim nums() as Integer =   1, 1 ))

            Console.WriteLine("copyEndyLinq")
            Console.WriteLine(copyEndyLinq(Dim nums() as Integer =   9, 11, 90, 22, 6 , 2).SequenceEqual(Dim nums() as Integer =   9, 90 ))
            Console.WriteLine(copyEndyLinq(Dim nums() as Integer =   9, 11, 90, 22, 6 , 3).SequenceEqual(Dim nums() as Integer =   9, 90, 6 ))
            Console.WriteLine(copyEndyLinq(Dim nums() as Integer =   12, 1, 1, 13, 0, 20 , 2).SequenceEqual(Dim nums() as Integer =   1, 1 ))
            
            Console.WriteLine("matchUp")
            Console.WriteLine(matchUp(New string[]  "aa", "bb", "cc" , New string[]  "aaa", "xx", "bb" ) = 1)
            Console.WriteLine(matchUp(New string[]  "aa", "bb", "cc" , New string[]  "aaa", "b", "bb" ) = 2)
            Console.WriteLine(matchUp(New string[]  "aa", "bb", "cc" , New string[]  "", "", "ccc" ) = 1)

            Console.WriteLine("matchUpLinq")
            Console.WriteLine(matchUpLinq(New string[]  "aa", "bb", "cc" , New string[]  "aaa", "xx", "bb" ) = 1)
            Console.WriteLine(matchUpLinq(New string[]  "aa", "bb", "cc" , New string[]  "aaa", "b", "bb" ) = 2)
            Console.WriteLine(matchUpLinq(New string[]  "aa", "bb", "cc" , New string[]  "", "", "ccc" ) = 1)
            
            Console.WriteLine("scoreUp")
            Console.WriteLine(scoreUp(New string[]  "a", "a", "b", "b" , New string[]  "a", "c", "b", "c" ) = 6)
            Console.WriteLine(scoreUp(New string[]  "a", "a", "b", "b" , New string[]  "a", "a", "b", "c" ) = 11)
            Console.WriteLine(scoreUp(New string[]  "a", "a", "b", "b" , New string[]  "a", "a", "b", "b" ) = 16)

            Console.WriteLine("scoreUpLinq")
            Console.WriteLine(scoreUpLinq(New string[]  "a", "a", "b", "b" , New string[]  "a", "c", "b", "c" ) = 6)
            Console.WriteLine(scoreUpLinq(New string[]  "a", "a", "b", "b" , New string[]  "a", "a", "b", "c" ) = 11)
            Console.WriteLine(scoreUpLinq(New string[]  "a", "a", "b", "b" , New string[]  "a", "a", "b", "b" ) = 16)
            
            Console.WriteLine("wordsWithout")
            Console.WriteLine(wordsWithout(New string[]  "a", "b", "c", "a" , "a").SequenceEqual(New string[]  "b", "c" ))
            Console.WriteLine(wordsWithout(New string[]  "a", "b", "c", "a" , "b").SequenceEqual(New string[]  "a", "c", "a" ))
            Console.WriteLine(wordsWithout(New string[]  "a", "b", "c", "a" , "c").SequenceEqual(New string[]  "a", "b", "a" ))

            Console.WriteLine("wordsWithoutLinq")
            Console.WriteLine(wordsWithoutLinq(New string[]  "a", "b", "c", "a" , "a").SequenceEqual(New string[]  "b", "c" ))
            Console.WriteLine(wordsWithoutLinq(New string[]  "a", "b", "c", "a" , "b").SequenceEqual(New string[]  "a", "c", "a" ))
            Console.WriteLine(wordsWithoutLinq(New string[]  "a", "b", "c", "a" , "c").SequenceEqual(New string[]  "a", "b", "a" ))
            
            Console.WriteLine("scoresSpecial")
            Console.WriteLine(scoresSpecial(Dim nums() as Integer =   12, 10, 4 , Dim nums() as Integer =   2, 20, 30 ) = 40)
            Console.WriteLine(scoresSpecial(Dim nums() as Integer =   20, 10, 4 , Dim nums() as Integer =   2, 20, 10 ) = 40)
            Console.WriteLine(scoresSpecial(Dim nums() as Integer =   12, 11, 4 , Dim nums() as Integer =   2, 20, 31 ) = 20)

            Console.WriteLine("scoresSpecialLinq")
            Console.WriteLine(scoresSpecialLinq(Dim nums() as Integer =   12, 10, 4 , Dim nums() as Integer =   2, 20, 30 ) = 40)
            Console.WriteLine(scoresSpecialLinq(Dim nums() as Integer =   20, 10, 4 , Dim nums() as Integer =   2, 20, 10 ) = 40)
            Console.WriteLine(scoresSpecialLinq(Dim nums() as Integer =   12, 11, 4 , Dim nums() as Integer =   2, 20, 31 ) = 20)
            
            Console.WriteLine("sumHeights")
            Console.WriteLine(sumHeights(Dim nums() as Integer =   5, 3, 6, 7, 2 , 2, 4) = 6)
            Console.WriteLine(sumHeights(Dim nums() as Integer =   5, 3, 6, 7, 2 , 0, 1) = 2)
            Console.WriteLine(sumHeights(Dim nums() as Integer =   5, 3, 6, 7, 2 , 0, 4) = 11)

            Console.WriteLine("sumHeightsLinq")
            Console.WriteLine(sumHeightsLinq(Dim nums() as Integer =   5, 3, 6, 7, 2 , 2, 4) = 6)
            Console.WriteLine(sumHeightsLinq(Dim nums() as Integer =   5, 3, 6, 7, 2 , 0, 1) = 2)
            Console.WriteLine(sumHeightsLinq(Dim nums() as Integer =   5, 3, 6, 7, 2 , 0, 4) = 11)

            Console.WriteLine("sumHeights2")
            Console.WriteLine(sumHeights2(Dim nums() as Integer =   5, 3, 6, 7, 2 , 2, 4) = 7)
            Console.WriteLine(sumHeights2(Dim nums() as Integer =   5, 3, 6, 7, 2 , 0, 1) = 2)
            Console.WriteLine(sumHeights2(Dim nums() as Integer =   5, 3, 6, 7, 2 , 0, 4) = 15)
            
            Console.WriteLine("bigHeights")
            Console.WriteLine(bigHeights(Dim nums() as Integer =   5, 3, 6, 7, 2 , 2, 4) = 1)
            Console.WriteLine(bigHeights(Dim nums() as Integer =   5, 3, 6, 7, 2 , 0, 1) = 0)
            Console.WriteLine(bigHeights(Dim nums() as Integer =   5, 3, 6, 7, 2 , 0, 4) = 1)

            Console.WriteLine("bigHeightsLinq")
            Console.WriteLine(bigHeightsLinq(Dim nums() as Integer =   5, 3, 6, 7, 2 , 2, 4) = 1)
            Console.WriteLine(bigHeightsLinq(Dim nums() as Integer =   5, 3, 6, 7, 2 , 0, 1) = 0)
            Console.WriteLine(bigHeightsLinq(Dim nums() as Integer =   5, 3, 6, 7, 2 , 0, 4) = 1)
            
            Console.WriteLine("userCompare")
            Console.WriteLine(userCompare("bb", 1, "zz", 2) = -1)
            Console.WriteLine(userCompare("bb", 1, "aa", 2) = 1)
            Console.WriteLine(userCompare("bb", 1, "bb", 1) = 0)
            
            Console.WriteLine("mergeTwo")
            Console.WriteLine(mergeTwo(New string[]  "a", "c", "z" , New string[]  "b", "f", "z" , 3).SequenceEqual(New string[]  "a", "b", "c" ))
            Console.WriteLine(mergeTwo(New string[]  "a", "c", "z" , New string[]  "c", "f", "z" , 3).SequenceEqual(New string[]  "a", "c", "f" ))
            Console.WriteLine(mergeTwo(New string[]  "f", "g", "z" , New string[]  "c", "f", "g" , 3).SequenceEqual(New string[]  "c", "f", "g" ))

            Console.WriteLine("mergeTwoLinq")
            Console.WriteLine(mergeTwoLinq(New string[]  "a", "c", "z" , New string[]  "b", "f", "z" , 3).SequenceEqual(New string[]  "a", "b", "c" ))
            Console.WriteLine(mergeTwoLinq(New string[]  "a", "c", "z" , New string[]  "c", "f", "z" , 3).SequenceEqual(New string[]  "a", "c", "f" ))
            Console.WriteLine(mergeTwoLinq(New string[]  "f", "g", "z" , New string[]  "c", "f", "g" , 3).SequenceEqual(New string[]  "c", "f", "g" ))
            
            Console.WriteLine("commonTwo")
            Console.WriteLine(commonTwo(New string[]  "a", "c", "c", "x" , New string[]  "b", "c", "d", "x" ) = 2)
            Console.WriteLine(commonTwo(New string[]  "a", "c", "x" , New string[]  "a", "b", "c", "x", "z" ) = 3)
            Console.WriteLine(commonTwo(New string[]  "a", "b", "c" , New string[]  "a", "b", "c" ) = 3)

            Console.WriteLine("commonTwoLinq")
            Console.WriteLine(commonTwoLinq(New string[]  "a", "c", "c", "x" , New string[]  "b", "c", "d", "x" ) = 2)
            Console.WriteLine(commonTwoLinq(New string[]  "a", "c", "x" , New string[]  "a", "b", "c", "x", "z" ) = 3)
            Console.WriteLine(commonTwoLinq(New string[]  "a", "b", "c" , New string[]  "a", "b", "c" ) = 3)
           
        //main

        End Function
        Given an array Of scores, Return True If Each score Is equal Or greater than the one before. 
        The array will be length 2 Or more. 

        scoresIncreasing(1, 3, 4) → true
        scoresIncreasing(1, 3, 2) → false
        scoresIncreasing(1, 1, 4) → true
        

        Public Function bool scoresIncreasing(int[] scores)
        
            For (Dim i As Integer= 1 i < scores.Length i++)
                If (scores[i] < scores(i - 1))
                    Return False
            Return True
        


        End Function
        Given an array Of scores, Return True If Each score Is equal Or greater than the one before.
        The array will be length 2 Or more. Use Linq. Do Not use loops.

        scoresIncreasingLinq( 1, 3, 4) → true
        scoresIncreasingLinq( 1, 3, 2) → false
        scoresIncreasingLinq( 1, 1, 4) → true
        
        Public Function bool scoresIncreasingLinq(int[] scores)
        
            Return!scores.Skip(1)
        .Where((value, index) => value < scores[index])
                          .Any()

        

        End Function
        Given an array Of scores, Return True If there are scores Of 100 Next To Each other In the array. 
        The array length will be at least 2. 

        scores100(1, 100, 100) → true
        scores100(1, 100, 99, 100) → false
        scores100(100, 1, 100, 100) → true
        
        Public Function bool scores100(int[] scores)
        
            For (Dim i As Integer= 1 i < scores.Length i++)
                If (scores[i] = 100 And scores(i - 1) = 100)
                    Return True
            Return False
        


        End Function
            Given an array Of scores, Return True If there are scores Of 100 Next To Each other In the array. 
            The array length will be at least 2. Use Linq. Do Not use loops.

            scores100Linq(1, 100, 100) → true
            scores100Linq(1, 100, 99, 100) → false
            scores100Linq(100, 1, 100, 100) → true
        
        Public Function bool scores100Linq(int[] scores)
        
            Return scores.Skip(1).Where((val, index) >= val = 100 And scores[index] = 100).Any()
        

        End Function
        Given a sorted array, Return True If the array contains 3 adjacent scores 
        that differ from Each other by at most 2, such As With 3, 4, 5 Or 3, 5, 5. 

        scoresClump(3, 4, 5) → true
        scoresClump(3, 4, 6) → false
        scoresClump(1, 3, 5, 5) → true
        
        Public Function bool scoresClump(int[] scores)
        
            For (Dim i As Integer= 1 i < scores.Length - 1 i++)
                If (Math.Abs(scores(i - 1) - scores(i + 1)) <= 2)
        Return True
            Return False
        

        End Function
        Given a sorted array, Return True If the array contains 3 adjacent scores 
        that differ from Each other by at most 2, such As With 3, 4, 5 Or 3, 5, 5. 
        Use Linq. Do Not use loops.
        scoresClump(3, 4, 5) → true
        scoresClump(3, 4, 6) → false
        scoresClump(1, 3, 5, 5) → true
        
        Public Function bool scoresClumpLinq(int[] scores)
        
            Return scores.Skip(2).Where((val, index) >= Math.Abs(val - scores[index]) <= 2).Any()
        

        End Function
        Given an array Of scores, compute the int average Of the first half And the second half, And Return 
        whichever Is larger. We'll say that the second half begins at index length/2. The array length will 
        be at least 2. Normally you would compute averages With doubles, but here we use ints so the expected 
        results are exact. 

        scoresAverage(2, 2, 4, 4) → 4
        scoresAverage(4, 4, 4, 2, 2, 2) → 4
        scoresAverage(3, 4, 5, 1, 2, 3) → 4
        
        Public Function int scoresAverage(int[] scores)
        
            int leftCount = 0
            int rightCount = 0
            int leftSum = 0
            int rightSum = 0

            for(Dim i As Integer= 0 i < scores.Length i++)
            
                if (i < scores.Length / 2)
                
                    leftCount++
                    leftSum += scores[i]
                
                else
                
                    rightCount++
                    rightSum += scores[i]
                
            

            return Math.Max(leftSum / leftCount, rightSum / rightCount)
        

        End Function
        Given an array of scores, compute the int average of the first half and the second half, and return 
        whichever is larger. We'll say that the second half begins at index length/2. The array length will 
        be at least 2. Normally you would compute averages with doubles, but here we use ints so the expected 
        results are exact. Use Linq. Do not use loops.

        scoresAverage(2, 2, 4, 4) → 4
        scoresAverage(4, 4, 4, 2, 2, 2) → 4
        scoresAverage(3, 4, 5, 1, 2, 3) → 4
        
        Public Function int scoresAverageLinq(int[] scores)
        
            return (int)Math.Max(scores.Take(scores.Length / 2).Average(),
                                 scores.Skip(scores.Length / 2).Average())
        

        End Function
        Given an array of strings, return the count of the number of strings with the given length. 

        wordsCount("a", "bb", "b", "ccc", 1) → 2
        wordsCount("a", "bb", "b", "ccc", 3) → 1
        wordsCount("a", "bb", "b", "ccc", 4) → 0
        
        Public Function int wordsCount(string[] words, int len)
        
            int count = 0

            foreach (string word in words)
                if (word.Length = len)
                    count++

            return count
        

        End Function
        Given an array of strings, return the count of the number of strings with the given length. 
        Use Linq. Do not use loops.
        wordsCountLinq("a", "bb", "b", "ccc", 1) → 2
        wordsCountLinq("a", "bb", "b", "ccc", 3) → 1
        wordsCountLinq("a", "bb", "b", "ccc", 4) → 0
        
        Public Function int wordsCountLinq(string[] words, int len)
        
            return words.Where(word => word.Length = len).Count()
        

        End Function
        Given an array of strings, return a new array containing the first N strings. 
        N will be in the range 1..length.

        wordsFront("a", "b", "c", "d", 1) → "a"
        wordsFront("a", "b", "c", "d", 2) → "a", "b"
        wordsFront("a", "b", "c", "d", 3) → "a", "b", "c"
        
        Public Function string[] wordsFront(string[] words, int n)
        
            string[] result = new string[n]
            Array.Copy(words, result, n)
            return result
        

        End Function
        Given an array of strings, return a new array containing the first N strings. 
        N will be in the range 1..length. Use Linq. Do not use loops.

        wordsFrontLinq("a", "b", "c", "d", 1) → "a"
        wordsFrontLinq("a", "b", "c", "d", 2) → "a", "b"
        wordsFrontLinq("a", "b", "c", "d", 3) → "a", "b", "c"
        
        Public Function string[] wordsFrontLinq(string[] words, int n)
        
            return words.Take(n).ToArray()
        

        End Function
        Given an array of strings, return a new List (e.g. an ArrayList) where all the strings of the 
        given length are omitted. 

        wordsWithoutList("a", "bb", "b", "ccc", 1) → "bb", "ccc"
        wordsWithoutList("a", "bb", "b", "ccc", 3) → "a", "bb", "b"
        wordsWithoutList("a", "bb", "b", "ccc", 4) → "a", "bb", "b", "ccc"
        
        Public Function List<string> wordsWithoutList(string[] words, int len)
        
            List<string> result = new List<string>()

            foreach (string word in words)
            
                if (word.Length != len)
                    result.Add(word)
            

            return result
        

        End Function
        Given an array of strings, return a new List(e.g.an ArrayList) where all the strings of the
        given length are omitted. Use Linq. Do not use loops.

        wordsWithoutListLinq( "a", "bb", "b", "ccc", 1) → "bb", "ccc"
        wordsWithoutListLinq( "a", "bb", "b", "ccc", 3) → "a", "bb", "b"
        wordsWithoutListLinq( "a", "bb", "b", "ccc", 4) → "a", "bb", "b", "ccc"
        
        Public Function List<string> wordsWithoutListLinq(string[] words, int len)
        
            return words.Where(word => word.Length != len).ToList<string>()
        

        End Function
        Given an int n, return true if it contains a 1 digit. Use Linq. Do not use loops.
        hasOneLinq(10) → true
        hasOneLinq(22) → false
        hasOneLinq(220) → false
        
        Public Function bool hasOneLinq(int n)
        
            return n.ToString().Contains("1")
        

        End Function
        Given an int n, return true if it contains a 1 digit. Use a loop.
        hasOne(10) → true
        hasOne(22) → false
        hasOne(220) → false
        
        Public Function bool hasOne(int n)
        
            int num = Math.Abs(n)

            while (num > 0)
            
                int digit = num % 10

                if (digit = 1)
                    return true

                num /= 10
            

            return false
        

        End Function
        We'll say that a positive int divides itself if every digit in the number divides into the 
        number evenly. So for example 128 divides itself since 1, 2, and 8 all divide into 128 evenly. 
        We'll say that 0 does not divide into anything evenly, so no number with a 0 digit divides itself. 

        dividesSelf(128) → true
        dividesSelf(12) → true
        dividesSelf(120) → false
        
        Public Function bool dividesSelf(int n)
        
            if (n = 0)
                return false

            int num = Math.Abs(n)

            while (num > 0)
            
                int digit = n % 10

                if (digit = 0)
                    return false
                else if (n % digit != 0)
                    return false

                num /= 10
            

            return true
        

        End Function
        Given an array of positive ints, return a new array of length "count" containing the first even 
        numbers from the original array. The original array will contain at least "count" even numbers. 

        copyEvens(3, 2, 4, 5, 8, 2) → 2, 4
        copyEvens(3, 2, 4, 5, 8, 3) → 2, 4, 8
        copyEvens(6, 1, 2, 4, 5, 8, 3) → 6, 2, 4
        
        Public Function int[] copyEvens(nums() As Integer, int count)
        
            int[] result = new int[count]
            int rpos = 0
            int npos = 0

            while (rpos < count)
            
                if (nums[npos] % 2 = 0)
                
                    result[rpos] = nums[npos]
                    rpos++
                

                npos++
            

            return result
        

        End Function
        Given an array of positive ints, return a new array of length "count" containing the first even 
        numbers from the original array. The original array will contain at least "count" even numbers. 
        Use Linq. Do not use loops.
        copyEvens(3, 2, 4, 5, 8, 2) → 2, 4
        copyEvens(3, 2, 4, 5, 8, 3) → 2, 4, 8
        copyEvens(6, 1, 2, 4, 5, 8, 3) → 6, 2, 4
        
        Public Function int[] copyEvensLinq(nums() As Integer, int count)
        
            return nums.Where(num => num % 2 = 0).Take(count).ToArray()
        

        End Function
        We'll say that a positive int n is "endy" if it is in the range 0..10 or 90..100 (inclusive). 
        Given an array of positive ints, return a new array of length "count" containing the first endy 
        numbers from the original array. 

        copyEndy(9, 11, 90, 22, 6, 2) → 9, 90
        copyEndy(9, 11, 90, 22, 6, 3) → 9, 90, 6
        copyEndy(12, 1, 1, 13, 0, 20, 2) → 1, 1
        
        Public Function int[] copyEndy(nums() As Integer, int count)
        
            int[] result = new int[count]
            int rpos = 0
            int npos = 0

            while (rpos < count)
            
                if ((nums[npos] >= 0  And nums[npos] <= 10) 
                 Or (nums[npos] >= 90 And nums[npos] <= 100))
                
                    result[rpos] = nums[npos]
                    rpos++
                

                npos++
            

            return result
        

        End Function
        We'll say that a positive int n is "endy" if it is in the range 0..10 or 90..100 (inclusive). 
        Given an array of positive ints, return a new array of length "count" containing the first endy 
        numbers from the original array. Use Linq. Do not use loops.

        copyEndyLinq(9, 11, 90, 22, 6, 2) → 9, 90
        copyEndyLinq(9, 11, 90, 22, 6, 3) → 9, 90, 6
        copyEndyLinq(12, 1, 1, 13, 0, 20, 2) → 1, 1
        
        Public Function int[] copyEndyLinq(nums() As Integer, int count)
        
            return nums
                .Where(num => (num >= 0 And num <= 10) Or (num >= 90 And num <= 100))
                .Take(count).ToArray()
        

        End Function
        Given 2 arrays that are the same length containing strings, compare the 1st string in one 
        array to the 1st string in the other array, the 2nd to the 2nd and so on. Count the number 
        of times that the 2 strings are non-empty and start with the same char. The strings may be 
        any length, including 0. 

        matchUp("aa", "bb", "cc", "aaa", "xx", "bb") → 1
        matchUp("aa", "bb", "cc", "aaa", "b", "bb") → 2
        matchUp("aa", "bb", "cc", "", "", "ccc") → 1
        
        Public Function int matchUp(string[] a, string[] b)
        
            int count = 0
            int len = Math.Min(a.Length, b.Length)

            for (Dim i As Integer= 0 i < len i++)
            
                if (!string.IsNullOrEmpty(a[i]) And !string.IsNullOrEmpty(b[i]))
                    if (a[i][0] = b[i][0])
                        count++
            

            return count
        

        End Function
        Given 2 arrays that are the same length containing strings, compare the 1st string in one 
        array to the 1st string in the other array, the 2nd to the 2nd and so on. Count the number 
        of times that the 2 strings are non-empty and start with the same char. The strings may be 
        any length, including 0. Use Linq. Do not use loops.

        matchUpLinq("aa", "bb", "cc", "aaa", "xx", "bb") → 1
        matchUpLinq("aa", "bb", "cc", "aaa", "b", "bb") → 2
        matchUpLinq("aa", "bb", "cc", "", "", "ccc") → 1
        
        Public Function int matchUpLinq(string[] a, string[] b)
        
            var matches = a.Zip(b, (x, y) => !string.IsNullOrEmpty(x) 
                                          And !string.IsNullOrEmpty(y) 
                                          And x[0] = y[0])

            return matches.Where(element => element = true).Count()
        

        End Function
        The "key" array is an array containing the correct answers to an exam, like "a", "a", "b", "b". 
        The "answers" array contains a student's answers, with "?" representing a question left blank. 
        The two arrays are not empty and are the same length. Return the score for this array of answers, 
        giving +4 for each correct answer, -1 for each incorrect answer, and +0 for each blank answer. 

        scoreUp("a", "a", "b", "b", "a", "c", "b", "c") → 6
        scoreUp("a", "a", "b", "b", "a", "a", "b", "c") → 11
        scoreUp("a", "a", "b", "b", "a", "a", "b", "b") → 16
        
        Public Function int scoreUp(string[] key, string[] answers)
        
            int score = 0
            for (Dim i As Integer= 0 i < Math.Min(key.Length, answers.Length) i++)
            
                if (!string.IsNullOrEmpty(key[i]) And !string.IsNullOrEmpty(answers[i]))
                    if (key[i] = answers[i])
                        score += 4
                    else if (answers[i] != "?")
                        score -= 1
            
            return score
        

        End Function
        The "key" array is an array containing the correct answers to an exam, like "a", "a", "b", "b". 
        The "answers" array contains a student's answers, with "?" representing a question left blank. 
        The two arrays are not empty and are the same length. Return the score for this array of answers, 
        giving +4 for each correct answer, -1 for each incorrect answer, and +0 for each blank answer. 

        scoreUpLinq("a", "a", "b", "b", "a", "c", "b", "c") → 6
        scoreUpLinq("a", "a", "b", "b", "a", "a", "b", "c") → 11
        scoreUpLinq("a", "a", "b", "b", "a", "a", "b", "b") → 16
        
        Public Function int scoreUpLinq(string[] key, string[] answers)
        
            const int pointsPerCorrect = 4
            const int wrongPenalty = 1
            const int blankPenalty = 0

            var results = key.Zip(answers, (x, y) => x = y)
            int corrects = results.Where(element => element = true).Count()
            int blanks = answers.Where(x => x = "?").Count()
            int incorrects = answers.Length - corrects - blanks

            return corrects * pointsPerCorrect - incorrects * wrongPenalty - blanks * blankPenalty
        

        End Function
        Given an array of strings, return a new array without the strings that are equal to the target 
        string.  

        wordsWithout("a", "b", "c", "a", "a") → "b", "c"
        wordsWithout("a", "b", "c", "a", "b") → "a", "c", "a"
        wordsWithout("a", "b", "c", "a", "c") → "a", "b", "a"
        
        Public Function string[] wordsWithout(string[] words, string target)
        
            List<string> result = new List<string>()

            foreach (string word in words)
            
                if (word != target)
                    result.Add(word)
            

            return result.ToArray()
        

        End Function
        Given an array of strings, return a new array without the strings that are equal to the target 
        string. Use Linq. Do not use loops.

        wordsWithoutLinq("a", "b", "c", "a", "a") → "b", "c"
        wordsWithoutLinq("a", "b", "c", "a", "b") → "a", "c", "a"
        wordsWithoutLinq("a", "b", "c", "a", "c") → "a", "b", "a"
        
        Public Function string[] wordsWithoutLinq(string[] words, string target)
        
            return words.Where(word => word != target).ToArray()
        

        End Function
        Given two arrays, A and B, of non-negative int scores. A "special" score is one which is a 
        multiple of 10, such as 40 or 90. Return the sum of largest special score in A and the largest 
        special score in B. 

        scoresSpecial(12, 10, 4, 2, 20, 30) → 40
        scoresSpecial(20, 10, 4, 2, 20, 10) → 40
        scoresSpecial(12, 11, 4, 2, 20, 31) → 20
        
        Public Function int scoresSpecial(a As Integer(), b As Integer())
        
            int aMod10Max = 0
            int bMod10Max = 0

            foreach (int num in a)
                if (num % 10 = 0 And num > aMod10Max)
                    aMod10Max = num

            foreach (int num in b)
                if (num % 10 = 0 And num > bMod10Max)
                    bMod10Max = num

            return aMod10Max + bMod10Max
        

        End Function
        Given two arrays, A and B, of non-negative int scores. A "special" score is one which is a 
        multiple of 10, such as 40 or 90. Return the sum of largest special score in A and the largest 
        special score in B. Use Linq. Do not use loops.

        scoresSpecialLinq(12, 10, 4, 2, 20, 30) → 40
        scoresSpecialLinq(20, 10, 4, 2, 20, 10) → 40
        scoresSpecialLinq(12, 11, 4, 2, 20, 31) → 20
        
        Public Function int scoresSpecialLinq(a As Integer(), b As Integer())
        
            int aMod10Max = a.Where(value => value % 10 = 0).DefaultIfEmpty(0).Max()
            int bMod10Max = b.Where(value => value % 10 = 0).DefaultIfEmpty(0).Max()
            return aMod10Max + bMod10Max
        

        End Function
        We have an array of heights, representing the altitude along a walking trail. Given start/end 
        indexes into the array, return the sum of the changes for a walk beginning at the start index 
        and ending at the end index. For example, with the heights 5, 3, 6, 7, 2 and start=2, end=4 
        yields a sum of 1 + 5 = 6. The start end end index will both be valid indexes into the array 
        with start <= end. 

        sumHeights(5, 3, 6, 7, 2, 2, 4) → 6
        sumHeights(5, 3, 6, 7, 2, 0, 1) → 2
        sumHeights(5, 3, 6, 7, 2, 0, 4) → 11
        
        Public Function int sumHeights(int[] heights, int start, int end)
        
            int sum = 0

            for (Dim i As Integer= start i < end i++)
                sum += Math.Abs(heights[i] - heights(i + 1))

            return sum
        

        End Function
        We have an array of heights, representing the altitude along a walking trail. Given start/end 
        indexes into the array, return the sum of the changes for a walk beginning at the start index 
        and ending at the end index. For example, with the heights 5, 3, 6, 7, 2 and start=2, end=4 
        yields a sum of 1 + 5 = 6. The start end end index will both be valid indexes into the array 
        with start <= end. Use Linq. Do not use loops.

        sumHeightsLinq(5, 3, 6, 7, 2, 2, 4) → 6
        sumHeightsLinq(5, 3, 6, 7, 2, 0, 1) → 2
        sumHeightsLinq(5, 3, 6, 7, 2, 0, 4) → 11
        
        Public Function int sumHeightsLinq(int[] heights, int start, int end)
        
            var steps = heights.Skip(start).Take(1 + end - start)

            return steps
                .Zip(steps
                .Skip(1), (x, y) => Math.Abs(y - x))
                .Sum()
        

        End Function
        (A variation on the sumHeights problem.) We have an array of heights, representing the altitude 
        along a walking trail. Given start/end indexes into the array, return the sum of the changes 
        for a walk beginning at the start index and ending at the end index, however increases in height 
        count double. For example, with the heights 5, 3, 6, 7, 2 and start=2, end=4 yields a sum 
        of 1*2 + 5 = 7. The start end end index will both be valid indexes into the array with start <= end. 

        sumHeights2(5, 3, 6, 7, 2, 2, 4) → 7
        sumHeights2(5, 3, 6, 7, 2, 0, 1) → 2
        sumHeights2(5, 3, 6, 7, 2, 0, 4) → 15
        
        Public Function int sumHeights2(int[] heights, int start, int end)
        
            int sum = 0
            for(Dim i As Integer= start i < end i++)
            
                if (heights(i + 1) > heights[i])
                    sum += 2 * (heights(i + 1) - heights[i])
                else
                    sum += heights[i] - heights(i + 1)
            
            return sum
        

        End Function
        (A variation on the sumHeights problem.) We have an array of heights, representing the altitude 
        along a walking trail. Given start/end indexes into the array, return the number of "big" steps 
        for a walk starting at the start index and ending at the end index. We'll say that step is big 
        if it is 5 or more up or down. The start end end index will both be valid indexes into the array 
        with start <= end. 

        bigHeights(5, 3, 6, 7, 2, 2, 4) → 1
        bigHeights(5, 3, 6, 7, 2, 0, 1) → 0
        bigHeights(5, 3, 6, 7, 2, 0, 4) → 1
        
        Public Function int bigHeights(int[] heights, int start, int end)
        
            int count = 0

            for (Dim i As Integer= start i < end i++)
                if (Math.Abs(heights(i + 1) - heights[i]) >= 5)
                    count++

            return count

        

        End Function
        (A variation on the sumHeights problem.) We have an array of heights, representing the altitude 
        along a walking trail. Given start/end indexes into the array, return the number of "big" steps 
        for a walk starting at the start index and ending at the end index. We'll say that step is big 
        if it is 5 or more up or down. The start end end index will both be valid indexes into the array 
        with start <= end. Use Linq. Do not use loops.

        bigHeightsLinq(5, 3, 6, 7, 2, 2, 4) → 1
        bigHeightsLinq(5, 3, 6, 7, 2, 0, 1) → 0
        bigHeightsLinq(5, 3, 6, 7, 2, 0, 4) → 1
        
        Public Function int bigHeightsLinq(int[] heights, int start, int end)
        
            var steps = heights.Skip(start).Take(1 + end - start)

            return steps
                .Zip(steps.Skip(1), (x, y) => Math.Abs(y - x))
                .Where(value => value >= 5).Count()
        

        End Function
        We have data for two users, A and B, each with a String name and an int id. The goal is to order 
        the users such as for sorting. Return -1 if A comes before B, 1 if A comes after B, and 0 if they 
        are the same. Order first by the string names, and then by the id numbers if the names are the same. 
        
        userCompare("bb", 1, "zz", 2) → -1
        userCompare("bb", 1, "aa", 2) → 1
        userCompare("bb", 1, "bb", 1) → 0
        
        Public Function int userCompare(string aName, int aId, string bName, int bId)
        
            if (aName.CompareTo(bName) < 0)
                return -1
            else if (aName.CompareTo(bName) > 0)
                return 1
            else if (aId.CompareTo(bId) < 0)
                return -1
            else if (aId.CompareTo(bId) > 0)
                return 1
            else
                return 0

        

        End Function
        Start with two arrays of strings, A and B, each with its elements in alphabetical order and 
        without duplicates. Return a new array containing the first N elements from the two arrays. 
        The result array should be in alphabetical order and without duplicates. A and B will both 
        have a length which is N or more. The best "linear" solution makes a single pass over A and B, 
        taking advantage of the fact that they are in alphabetical order, copying elements directly 
        to the new array. 

        mergeTwo("a", "c", "z", "b", "f", "z", 3) → "a", "b", "c"
        mergeTwo("a", "c", "z", "c", "f", "z", 3) → "a", "c", "f"
        mergeTwo("f", "g", "z", "c", "f", "g", 3) → "c", "f", "g"
        
        Public Function string[] mergeTwo(string[] a, string[] b, int n)
        
            string[] result = new string[n]
            int apos = 0
            int bpos = 0
            for (Dim i As Integer= 0 i < result.Length i++)
            
                while(apos < a.Length And i > 0 And a[apos].CompareTo(result[i-1]) <= 0)
                    apos++

                while (bpos < b.Length And i > 0 And b[bpos].CompareTo(result[i-1]) <= 0)
                    bpos++

                if (a[apos].CompareTo(b[bpos]) <= 0)
                    result[i] = a[apos++]
                else
                    result[i] = b[bpos++]
            
            return result
        

        End Function
        Start with two arrays of strings, A and B, each with its elements in alphabetical order and 
        without duplicates. Return a new array containing the first N elements from the two arrays. 
        The result array should be in alphabetical order and without duplicates. A and B will both 
        have a length which is N or more. Use Linq. Do not use loops.

        mergeTwoLinq("a", "c", "z", "b", "f", "z", 3) → "a", "b", "c"
        mergeTwoLinq("a", "c", "z", "c", "f", "z", 3) → "a", "c", "f"
        mergeTwoLinq("f", "g", "z", "c", "f", "g", 3) → "c", "f", "g"
        
        Public Function string[] mergeTwoLinq(string[] a, string[] b, int n)
        
            return a.Concat(b).OrderBy(v => v).Distinct().Take(n).ToArray()
        

        End Function
        Start with two arrays of strings, a and b, each in alphabetical order, possibly with duplicates. 
        Return the count of the number of strings which appear in both arrays. The best "linear" solution 
        makes a single pass over both arrays, taking advantage of the fact that they are in alphabetical 
        order. 

        commonTwo("a", "c", "c", "x", "b", "c", "d", "x") → 2
        commonTwo("a", "c", "x", "a", "b", "c", "x", "z") → 3
        commonTwo("a", "b", "c", "a", "b", "c") → 3
        
        Public Function int commonTwo(string[] a, string[] b)
        
            int count = 0
            int apos = 0
            int bpos = 0

            while (apos < a.Length And bpos < b.Length)
            
                while (apos > 0 And a[apos - 1] = a[apos])
                    apos++

                while (bpos > 0 And b[bpos - 1] = b[bpos])
                    bpos++

                if (a[apos].CompareTo(b[bpos]) < 0)
                    apos++
                else if(a[apos].CompareTo(b[bpos]) > 0)
                     bpos++
                else
                
                    count++
                    apos++
                    bpos++
                
            

            return count
        

        End Function
        Start with two arrays of strings, a and b, each in alphabetical order, possibly with duplicates. 
        Return the count of the number of strings which appear in both arrays. The best "linear" solution 
        makes a single pass over both arrays, taking advantage of the fact that they are in alphabetical 
        order. Use Linq. Do not use loops.

        commonTwoLinq("a", "c", "c", "x", "b", "c", "d", "x") → 2
        commonTwoLinq("a", "c", "x", "a", "b", "c", "x", "z") → 3
        commonTwoLinq("a", "b", "c", "a", "b", "c") → 3
        
        Public Function int commonTwoLinq(string[] a, string[] b)
        
            return a.Intersect(b).Count()
        

    


    End Sub

End Module

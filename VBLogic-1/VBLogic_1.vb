Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Module VBLogic_1

    Sub Main()

        Console.WriteLine("lastDigit")
        Console.WriteLine(lastDigit(23, 19, 13) = True)
        Console.WriteLine(lastDigit(23, 19, 12) = False)
        Console.WriteLine(lastDigit(23, 19, 3) = True)

        Console.WriteLine("lessBy10")
        Console.WriteLine(lessBy10(1, 7, 11) = True)
        Console.WriteLine(lessBy10(1, 7, 10) = False)
        Console.WriteLine(lessBy10(11, 1, 7) = True)

        Console.WriteLine("withoutDoubles")
        Console.WriteLine(withoutDoubles(6, 6, True) = 7)
        Console.WriteLine(withoutDoubles(2, 3, True) = 5)
        Console.WriteLine(withoutDoubles(3, 3, True) = 7)
        Console.WriteLine(withoutDoubles(3, 3, False) = 6)

        Console.WriteLine("maxMod5")
        Console.WriteLine(maxMod5(25, 15) = 15)
        Console.WriteLine(maxMod5(6, 2) = 6)
        Console.WriteLine(maxMod5(3, 3) = 0)

        Console.WriteLine("redTicket")
        Console.WriteLine(redTicket(2, 2, 2) = 10)
        Console.WriteLine(redTicket(2, 2, 1) = 0)
        Console.WriteLine(redTicket(0, 0, 0) = 5)

        Console.WriteLine("greenTicket")
        Console.WriteLine(greenTicket(1, 2, 3) = 0)
        Console.WriteLine(greenTicket(2, 2, 2) = 20)
        Console.WriteLine(greenTicket(1, 1, 2) = 10)

        Console.WriteLine("blueTicket")
        Console.WriteLine(blueTicket(14, 1, 4) = 5)
        Console.WriteLine(blueTicket(9, 1, 0) = 10)
        Console.WriteLine(blueTicket(9, 2, 0) = 0)

        Console.WriteLine("shareDigit")
        Console.WriteLine(shareDigit(12, 34, 56, 78, 90, 0) = True)
        Console.WriteLine(shareDigit(12, 23) = True)
        Console.WriteLine(shareDigit(12, 34) = False)
        Console.WriteLine(shareDigit(12, 44) = False)

        Console.WriteLine("shareDigitLinq")
        Console.WriteLine(shareDigitLinq(12, 34, 56, 78, 90, 0) = True)
        Console.WriteLine(shareDigitLinq(12, 23) = True)
        Console.WriteLine(shareDigitLinq(12, 34) = False)
        Console.WriteLine(shareDigitLinq(12, 44) = False)


        Console.WriteLine("sumLimit")
        Console.WriteLine(sumLimit(-12, 3) = -9)
        Console.WriteLine(sumLimit(2, 3) = 5)
        Console.WriteLine(sumLimit(8, 3) = 8)



        'End Function
    ''Given three ints, a b c, Return True If two Or more Of them have the same 
    ''rightmost digit.The ints are non-negative.

    ''lastDigit(23, 19, 13) → True
    ''lastDigit(23, 19, 12) → False
    ''lastDigit(23, 19, 3) → True        
    '
    Public Function bool lastDigit(params int[] values)
        
            List<int> digits = New List<int>()
            foreach (int val in values)
                If (digits.Contains(val % 10))
        Return True
                Else
                    digits.Add(val % 10)
            Return False
        

        'End Function
        'Given three ints, a b c, Return True If one Of them Is 10 Or more less than 
        'one of the others. 

        'lessBy10(1, 7, 11) → true
        'lessBy10(1, 7, 10) → false
        'lessBy10(11, 1, 7) → true        
        '
        Public Function bool lessBy10(params int[] values)
        
            foreach (int val in values)
                If (values.Contains(val - 10) Or values.Contains(val + 10))
                    Return True
            Return False
        


        End Function
            Return the sum Of two 6-sided dice rolls, Each In the range 1..6. 
            However, if noDoubles Is true, if the two dice show the same value, 
            increment one die To the Next value, wrapping around To 1 If its value was 6. 

            withoutDoubles(2, 3, true) → 5
            withoutDoubles(3, 3, true) → 7
            withoutDoubles(3, 3, false) → 6        
        
        Public Function int withoutDoubles(int die1, int die2, bool noDoubles)
        
            If (noDoubles And (die1 = die2))
        If (die1 = 6)
                    die1 = 1
                Else
                    die1++

            Return die1 + die2
        

        End Function
        Given two int values, Return whichever value Is larger. 
        However if the two values have the same remainder when divided by 5, 
        then the return the smaller value. However, in all cases, if the two 
        values are the same, Return 0.

        maxMod5(25, 15) → 15
        maxMod5(6, 2) → 6
        maxMod5(3, 3) → 0        
        
        Public Function int maxMod5(params int[] values)
        
            HashSet<int> vals = New HashSet<int>()
            HashSet<int> mods = New HashSet<int>()
 
            foreach (int val in values)
            
                 vals.Add(val)
                 mods.Add(val % 5)
            

            If (vals.Count <2)
        Return 0
            ElseIf (mods.Count <2)
        Return vals.Min()
        Else
        Return vals.Max()



    End Function
        You have a red lottery ticket showing ints a, b, And c, Each Of which 
        Is 0, 1, Or 2. If they are all the value 2, the result Is 10. Otherwise 
        If they Then are all the same, the result Is 5. Otherwise so Long As both 
        b And c are different from a, the result Is 1. Otherwise the result Is 0. 

        redTicket(2, 2, 2) → 10
        redTicket(2, 2, 1) → 0
        redTicket(0, 0, 0) → 5        
        
        Public Function int redTicket(params int[] values)
        
            HashSet<int> vals = New HashSet<int>(values)
            If (vals.Count = 1)
        If (vals.Contains(2))
        Return 10
                Else
        Return 5
            Else
        Return 0
        
        

        End Function
        You have a green lottery ticket, With ints a, b, And c On it. 
        If the numbers are all different from Each other, the result Is 0. 
        If all Of the numbers are the same, the result Is 20. 
        If two Of the numbers are the same, the result Is 10. 

        greenTicket(1, 2, 3) → 0
        greenTicket(2, 2, 2) → 20
        greenTicket(1, 1, 2) → 10        
        
        Public Function int greenTicket(params int[] values)
        
            bool allSame = True
            bool allDifferent = True

            For (Dim i As Integer= 0 i <values.Length i++)
            
                For (int j = i + 1 j <values.Length j++)
                
                    If (values[i] != values[j])
                        allSame = false
                    If (values[i] = values[j])
                        allDifferent = false
                
            

            If (allSame)
        Return 20
            ElseIf (allDifferent)
        Return 0
            Else
        Return 10


        End Function
        You have a blue lottery ticket, With ints a, b, And c On it. 
        This makes three pairs, which we'll call ab, bc, and ac. 
        Consider the sum Of the numbers In Each pair. 
        If any Then pair sums To exactly 10, the result Is 10. 
        Otherwise If the ab sum Is exactly 10 more than either bc Or ac sums,
        the result Is 5. Otherwise the result Is 0. 

        blueTicket(9, 1, 0) → 10
        blueTicket(9, 2, 0) → 0
        blueTicket(14, 1, 4) → 5        
        
        Public Function int blueTicket(params int[] values)
        
            HashSet<int> pairs = New HashSet<int>()

            For (Dim i As Integer= 0 i <values.Length i++)
            
                For (int j = 0 j <values.Length j++)
                
                    If (i!= j)

                        int pair = values[i] + values[j]
                        If (pair = 10) Then
            Return 10
        ElseIf (pairs.Contains(pair - 10))
            Return 5
        ElseIf (pairs.Contains(pair + 10))
            Return 5
        Else
            pairs.Add(pair)



            Return 0


        End Function
        Given two ints, Each In the range 10..99, Return True If there Is 
        a digit that appears In both numbers, such As the 2 In 12 And 23.

        shareDigit(12, 23) → True
        shareDigit(12, 34) → False
        shareDigit(12, 44) → False        
        
        Public Function bool shareDigit(params int[] values)
        
            List<HashSet<int>> list = New List<HashSet<int>>()

            For (Dim i As Integer= 0 i <values.Length i++)
            
                HashSet<int> digits = New HashSet<int>()

                If (values[i] = 0)
                    digits.Add(values[i])
                Else
                
                    While (values[i] != 0)
                    
                        digits.Add(values[i] % 10)
                        values[i] /= 10
                    
                

                list.Add(digits)
            

            For (Dim i As Integer= 0 i <list.Count - 1 i++)
                For (int j = i + 1 j <list.Count j++)
                    foreach(int n in list[i])
                        If (list[j].Contains(n))
                            Return True

        Return False


    End Function
        Given two ints, Each In the range 10..99, Return True If there Is 
        a digit that appears In both numbers, such As the 2 In 12 And 23.
        Use Linq.Do Not use loops.
        shareDigitLinq(12, 23) → True
        shareDigitLinq(12, 34) → False
        shareDigitLinq(12, 44) → False        
        
        Public Function bool shareDigitLinq(params int[] values)
        
            String[] words = Array.ConvertAll(values, x => x.ToString())

            For (Dim i As Integer= 0 i < words.Length i++)
                For (int() j = 0 j < words.Length j++)
                    If (i! = j And words[i].Intersect(words[j]).Any())
                        Return True

                    Return False


        End Function
            Calculate the sum And the maximum Of the passed-In values. 
            If the sum And maximum have the same number Of digits Then 
            Return the sum, otherwise Return the maximum.

            sumLimit(2, 3) → 5
            sumLimit(8, 3) → 8
            sumLimit(-12, 3) → -9       
        
        Public Function int sumLimit(params int[] values)
        
            int sum = values.Sum()
            int max = values.Max()
            int sumDigits = Math.Abs(sum).ToString().Length
            int maxDigits = Math.Abs(max).ToString().Length
            Return sumDigits = maxDigits ? sum : max




    End Sub

End Module

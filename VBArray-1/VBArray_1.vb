Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Module VBArray_1

    Sub Main()

        Console.WriteLine("biggerTwo")
        Console.WriteLine(biggerTwo(Dim nums() As Integer =   1, 2, Dim nums() As Integer = 3, 4) .SequenceEqual(Dim nums() As Integer =    3, 4))
            Console.WriteLine(biggerTwo(Dim nums() As Integer =   3, 4, Dim nums() As Integer = 1, 2) .SequenceEqual(Dim nums() As Integer =    3, 4))
            Console.WriteLine(biggerTwo(Dim nums() As Integer =   1, 1, Dim nums() As Integer = 1, 2) .SequenceEqual(Dim nums() As Integer =    1, 2))

            Console.WriteLine("biggerTwo")
        Console.WriteLine(biggerTwo(Dim nums() As Integer =   1, 2, Dim nums() As Integer = 3, 4).SequenceEqual(Dim nums() As Integer =   3, 4 ))
            Console.WriteLine(biggerTwo(Dim nums() As Integer =   3, 4, Dim nums() As Integer = 1, 2).SequenceEqual(Dim nums() As Integer =   3, 4 ))
            Console.WriteLine(biggerTwo(Dim nums() As Integer =   1, 1, Dim nums() As Integer = 1, 2).SequenceEqual(Dim nums() As Integer =   1, 2 ))

            Console.WriteLine("makeMiddle")
        Console.WriteLine(makeMiddle(Dim nums() As Integer =   1, 2, 3, 4).SequenceEqual(Dim nums() As Integer = 2, 3))
            Console.WriteLine(makeMiddle(Dim nums() As Integer =   7, 1, 2, 3, 4, 9).SequenceEqual(Dim nums() As Integer = 2, 3))
            Console.WriteLine(makeMiddle(Dim nums() As Integer =   1, 2).SequenceEqual(Dim nums() As Integer = 1, 2))

            Console.WriteLine("plusTwo")
        Console.WriteLine(plusTwo(Dim nums() As Integer =   1, 2, Dim nums() As Integer = 3, 4).SequenceEqual(Dim nums() As Integer =   1, 2, 3, 4))
            Console.WriteLine(plusTwo(Dim nums() As Integer =   4, 4, Dim nums() As Integer = 2, 2).SequenceEqual(Dim nums() As Integer =   4, 4, 2, 2))
            Console.WriteLine(plusTwo(Dim nums() As Integer =   9, 2, Dim nums() As Integer = 3, 4).SequenceEqual(Dim nums() As Integer =   9, 2, 3, 4))

            Console.WriteLine("plusTwo")
        Console.WriteLine(plusTwo(Dim nums() As Integer =   1, 2, Dim nums() As Integer = 3, 4).SequenceEqual(Dim nums() As Integer =   1, 2, 3, 4 ))
            Console.WriteLine(plusTwo(Dim nums() As Integer =   4, 4, Dim nums() As Integer = 2, 2).SequenceEqual(Dim nums() As Integer =   4, 4, 2, 2 ))
            Console.WriteLine(plusTwo(Dim nums() As Integer =   9, 2, Dim nums() As Integer = 3, 4).SequenceEqual(Dim nums() As Integer =   9, 2, 3, 4 ))

            Console.WriteLine("swapEnds")
        Console.WriteLine(swapEnds(Dim nums() As Integer =   1, 2, 3, 4).SequenceEqual(Dim nums() As Integer = 4, 2, 3, 1))
            Console.WriteLine(swapEnds(Dim nums() As Integer =   1, 2, 3).SequenceEqual(Dim nums() As Integer = 3, 2, 1))
            Console.WriteLine(swapEnds(Dim nums() As Integer =   8, 6, 7, 9, 5).SequenceEqual(Dim nums() As Integer = 5, 6, 7, 9, 8))

            Console.WriteLine("midN")
        Console.WriteLine(midThree(Dim nums() As Integer =   1, 2, 3, 4, 5).SequenceEqual(Dim nums() As Integer = 2, 3, 4))
            Console.WriteLine(midThree(Dim nums() As Integer =   8, 6, 7, 5, 3, 0, 9).SequenceEqual(Dim nums() As Integer = 7, 5, 3))
            Console.WriteLine(midThree(Dim nums() As Integer =   1, 2, 3).SequenceEqual(Dim nums() As Integer = 1, 2, 3))

            Console.WriteLine("midN")
        Console.WriteLine(midThree(Dim nums() As Integer =   1, 2, 3, 4, 5).SequenceEqual(Dim nums() As Integer = 2, 3, 4))
            Console.WriteLine(midThree(Dim nums() As Integer =   8, 6, 7, 5, 3, 0, 9).SequenceEqual(Dim nums() As Integer = 7, 5, 3))
            Console.WriteLine(midThree(Dim nums() As Integer =   1, 2, 3).SequenceEqual(Dim nums() As Integer = 1, 2, 3))


            Console.WriteLine("maxTriple")
        Console.WriteLine(maxTriple(Dim nums() As Integer =   1, 2, 3) = 3)
            Console.WriteLine(maxTriple(Dim nums() As Integer =   1, 5, 3) = 5)
            Console.WriteLine(maxTriple(Dim nums() As Integer =   5, 2, 3) = 5)

            Console.WriteLine("front2")
        Console.WriteLine(front2(Dim nums() As Integer =   1, 2, 3).SequenceEqual(Dim nums() As Integer = 1, 2))
            Console.WriteLine(front2(Dim nums() As Integer =   1, 2).SequenceEqual(Dim nums() As Integer = 1, 2))
            Console.WriteLine(front2(Dim nums() As Integer =   1 ).SequenceEqual(Dim nums() As Integer = 1))

            Console.WriteLine("frontN")
        Console.WriteLine(frontN(Dim nums() As Integer =   1, 2, 3, 2).SequenceEqual(Dim nums() As Integer = 1, 2))
            Console.WriteLine(frontN(Dim nums() As Integer =   1, 2, 2).SequenceEqual(Dim nums() As Integer = 1, 2))
            Console.WriteLine(frontN(Dim nums() As Integer =   1 , 2).SequenceEqual(Dim nums() As Integer = 1))

            Console.WriteLine("frontNLinq")
        Console.WriteLine(frontNLinq(Dim nums() As Integer =   1, 2, 3, 2).SequenceEqual(Dim nums() As Integer = 1, 2))
            Console.WriteLine(frontNLinq(Dim nums() As Integer =   1, 2, 2).SequenceEqual(Dim nums() As Integer = 1, 2))
            Console.WriteLine(frontNLinq(Dim nums() As Integer =   1 , 2).SequenceEqual(Dim nums() As Integer = 1))

            Console.WriteLine("unlucky1")
        Console.WriteLine(unlucky1(Dim nums() As Integer =   1, 3, 4, 5) = True)
            Console.WriteLine(unlucky1(Dim nums() As Integer =   2, 1, 3, 4, 5) = True)
            Console.WriteLine(unlucky1(Dim nums() As Integer =   1, 1, 1) = False)

            Console.WriteLine("makeN")
        Console.WriteLine(make2(Dim nums() As Integer =   4, 5, Dim nums() As Integer = 1, 2, 3).SequenceEqual(Dim nums() As Integer =   4, 5))
            Console.WriteLine(make2(Dim nums() As Integer =   4, Dim nums() As Integer = 1, 2, 3).SequenceEqual(Dim nums() As Integer =   4, 1))
            Console.WriteLine(make2(Dim nums() As Integer =   , Dim nums() As Integer = 1, 2).SequenceEqual(Dim nums() As Integer =   1, 2))

            Console.WriteLine("front11")
        Console.WriteLine(front11(Dim nums() As Integer =   1, 2, 3, Dim nums() As Integer = 7, 9, 8).SequenceEqual(Dim nums() As Integer =   1, 7))
            Console.WriteLine(front11(Dim nums() As Integer =   1 , Dim nums() As Integer = 2).SequenceEqual(Dim nums() As Integer =   1, 2))
            Console.WriteLine(front11(Dim nums() As Integer =   1, 7, Dim nums() As Integer = ).SequenceEqual(Dim nums() As Integer =   1 ))

            Console.WriteLine("front11List")
        Console.WriteLine(front11List(Dim nums() As Integer =   1, 2, 3, Dim nums() As Integer = 7, 9, 8).SequenceEqual(Dim nums() As Integer =   1, 7 ))
            Console.WriteLine(front11List(Dim nums() As Integer =   1 , Dim nums() As Integer = 2).SequenceEqual(Dim nums() As Integer =   1, 2 ))
            Console.WriteLine(front11List(Dim nums() As Integer =   1, 7, Dim nums() As Integer = ).SequenceEqual(Dim nums() As Integer =   1 ))

        End Sub

    'Start with 2 int arrays, a And b, each length 2. 
    'Consider the sum Of the values In Each array. 
    'Return the array which has the largest sum. 
    'In event of a tie, return a. 

    'biggerTwo(1, 2, 3, 4) → 3, 4
    'biggerTwo(3, 4, 1, 2) → 3, 4
    'biggerTwo(1, 1, 1, 2) → 1, 2

    Public Function b As Integer()iggerTwo(a As Integer(), b As Integer())
        
            If (sumArray(a) >= sumArray(b)) Then
            Return a
        Else
            Return b


            Private Static int sumArray(a As Integer()rr)
        
            int sum = 0
            foreach(int n In arr)

            sum += n
        End If
        Return sum
        End Function


    'Start with 2 int arrays, a And b, each length 2. 
    'Consider the sum Of the values In Each array. 
    'Return the array which has the largest sum. 
    'In event of a tie, return a. Use Linq. Do Not use loops.

    'biggerTwoLinq(1, 2, 3, 4) → 3, 4
    'biggerTwoLinq(3, 4, 1, 2) → 3, 4
    'biggerTwoLinq(1, 1, 1, 2) → 1, 2

    Public Function b As Integer()iggerTwoLinq(a As Integer(), b As Integer())
        
            If (a.Sum() >= b.Sum()) Then
            Return a
        Else
            Return b
        End If

    End Function
    'Return the two middle elements Of the even-length array.

    '    makeMiddle(1, 2, 3, 4) → 2, 3
    '    makeMiddle(7, 1, 2, 3, 4, 9) → 2, 3
    '    makeMiddle(1, 2) → 1, 2

    Public Function int[] makeMiddle(nums() As Integer)
        
            If (nums.Length < 2) Then
            Return nums
        Else
            Return Dim nums() as Integer =   nums[nums.Length/2-1], nums[nums.Length/2]


        End Function
    'Given 2 int arrays, each length 2, return a New array length 4 
    'containing all their elements. Use an array. Do Not use a list.

    'plusTwo(1, 2, 3, 4) → 1, 2, 3, 4
    'plusTwo(4, 4, 2, 2) → 4, 4, 2, 2
    'plusTwo(9, 2, 3, 4) → 9, 2, 3, 4

    Public Function plusTwo(a As Integer(), b As Integer()) As Integer()

        int()[] result = New int[a.Length + b.Length]
            Array.Copy(a, result, a.Length)
        Array.Copy(b, 0, result, a.Length, b.Length)
        Return result


    End Function
    'Given 2 int arrays, each length 2, return a New array length 4 
    'containing all their elements. Use a list.

    'plusTwoList(1, 2, 3, 4) → 1, 2, 3, 4
    'plusTwoList(4, 4, 2, 2) → 4, 4, 2, 2
    'plusTwoList(9, 2, 3, 4) → 9, 2, 3, 4

    Public Function plusTwoList(a As Integer(), b As Integer()) As Integer()

        var List = New List < int() > ()
            List.AddRange(a)
        List.AddRange(b)
        Return List.ToArray()


    End Function
    'Given an array Of ints, swap the first And last elements In the array. 
    'Return the modified array. 

    'The Array length will be at least 1. 

    'swapEnds(1, 2, 3, 4) → 4, 2, 3, 1
    'swapEnds(1, 2, 3) → 3, 2, 1
    'swapEnds(8, 6, 7, 9, 5) → 5, 6, 7, 9, 8

    Public Function iswapEnds(nums() As Integer) As Integer()

        int temp = nums[0]
            nums[0] = nums[nums.Length - 1]
            nums[nums.Length - 1] = temp
            Return nums


    End Function
    'Given an array Of ints Of odd length, Return a New array length 3 
    'containing the elements from the middle Of the array. The array 
    'length will be at least 3. 

    'midThree(1, 2, 3, 4, 5) → 2, 3, 4
    'midThree(8, 6, 7, 5, 3, 0, 9) → 7, 5, 3
    'midThree(1, 2, 3) → 1, 2, 3        

    Public Function midThree(nums() As Integer) As Integer()

        int Mid() = nums.Length / 2
            Return Dim nums() as Integer =   nums[mid-1], nums[mid], nums[mid+1] 
        

        End Function
    'Given an array Of ints Of odd length, Return a New array length N 
    'containing the elements from the middle Of the array. The array 
    'length will be at least N. 

    'midN(1, 2, 3, 4, 5, 3) → 2, 3, 4
    'midN(8, 6, 7, 5, 3, 0, 9, 3) → 7, 5, 3
    'midN(1, 2, 3, 3) → 1, 2, 3        

    Public Function midN(nums() As Integer, int n) As Integer()

        int()[] result = New int[n]
            int start = nums.Length / 2 - n / 2
            Array.Copy(nums, start, result, 0, n)
        Return result


    End Function
    'Given an array Of ints Of odd length, look at the first, last,
    'And middle values in the array And return the largest. 
    'The Array length will be a least 1. 

    'maxTriple(1, 2, 3) → 3
    'maxTriple(1, 5, 3) → 5
    'maxTriple(5, 2, 3) → 5        

    Public Function maxTriple(nums() As Integer) As Integer

        Return Math.Max(nums[0], Math.Max(nums[nums.Length/2], nums[nums.Length-1]))


    End Function
    'Given an int array Of any length, Return a New array Of its first 2 elements. 
    'If the Then Array Is smaller than length 2, use whatever elements are present. 

    'front2(1, 2, 3) → 1, 2
    'front2(1, 2) → 1, 2
    'front2(1) → 1        

    Public Function front2(nums() As Integer)

        If (nums.Length < 2) Then
            Return nums
        Else
            Return Dim nums() as Integer =   nums[0], nums[1] 


        End Function
    'Given an int array Of any length, Return a New array Of its first N elements. 
    'If the Then Array Is smaller than length N, use whatever elements are present. 

    'frontN(1, 2, 3, 2) → 1, 2
    'frontN(1, 2, 2) → 1, 2
    'frontN(1, 2) → 1        

    Public Function frontN(nums() As Integer, int n) As Integer()

        If (nums.Length < n) Then
            Return nums
        Else

            int()[] result = New int[n]
                Array.Copy(nums, 0, result, 0, n)
            Return result




        End Function
    'Given an int array Of any length, Return a New array Of its first N elements. 
    'If the Then Array Is smaller than length N, use whatever elements are present. 
    'Use Linq.Do Not use loops.
    'frontN(1, 2, 3, 2) → 1, 2
    'frontN(1, 2, 2) → 1, 2
    'frontN(1, 2) → 1        

    Public Function frontNLinq(nums() As Integer, int n) As Integer()
        Return nums.Take(n).ToArray()

    End Function
    'We 'll say that a 1 immediately followed by a 3 in an array is an "unlucky" 1. 
    'Return True If the given array contains an unlucky 1 In the first 2 Or 
    'last 2 positions in the array. 

    'unlucky1(1, 3, 4, 5) → True
    'unlucky1(2, 1, 3, 4, 5) → True
    'unlucky1(1, 1, 1) → False        

    Public Function unlucky1(nums() As Integer) As Boolean

        If (nums.Length < 2) Then
            Return False
        Else
            Return is13(nums, 0) Or is13(nums, 1) Or is13(nums, nums.Length - 2)


            Private Static bool is13(nums() As Integer, int start)
        
            Return start >= 0 And start < nums.Length - 1 And nums[start] = 1 And nums[start + 1] = 3


        End Function
    'We 'll say that a 1 immediately followed by a 3 in an array is an "unlucky" 1. 
    '    Return True If the given array contains an unlucky 1 In the first 2 Or 
    'last 2 positions in the array. Use Linq. Do Not use loops.

    'unlucky1Linq(1, 3, 4, 5) → True
    'unlucky1Linq(2, 1, 3, 4, 5) → True
    'unlucky1Linq(1, 1, 1) → False        

    Public Function unlucky1Linq(nums() As Integer) As Boolean

        If (nums = null Or nums.Length < 2) Then
            Return False

            Return nums.Skip(1)
            .Where((value, Index) => nums[index] = 1 And value = 3)
                       .Any()


        End Function
    'Given 2 int arrays, a And b, return a New array length 2 containing,
    'as much as will fit, the elements from a followed by the elements from b. 
    'The arrays may be any length, including 0, but there will be 2 Or more
    'elements available between the 2 arrays. 

    'make2(4, 5, 1, 2, 3) → 4, 5
    'make2(4, 1, 2, 3) → 4, 1
    'make2(, 1, 2) → 1, 2        

    Public Function make2(a As Integer(), b As Integer()) As Integer()

        int()[] result

            If (a.Length >= 2) Then
            result = Dim nums() as Integer =   a[0], a[1] 
            ElseIf (a.Length = 1)
            result = Dim nums() as Integer =   a[0], b[0] 
            Else
            result = Dim nums() as Integer =   b[0], b[1] 

            Return result


        End Function
    'Given 2 int arrays, a And b, return a New array length N containing,
    'as much as will fit, the elements from a followed by the elements from b. 
    'The arrays may be any length, including 0, but there will be N Or more
    'elements available between the 2 arrays. 

    'makeN(4, 5, 1, 2, 3, 2) → 4, 5
    'makeN(4, 1, 2, 3, 2) → 4, 1
    'makeN(, 1, 2, 2) → 1, 2        

    Public Function makeN(a As Integer(), b As Integer(), int n) As Integer()

        If (a = null Or a.Length = 0) Then

            int()[] result = New int[n]
                Array.Copy(b, result, n)
            Return result


        ElseIf (b() = null Or b.Length = 0)

            int()[] result = New int[n]
                Array.Copy(a, result, n)
            Return result


        Else

            int()[] result = New int[n]
                Array.Copy(a, 0, result, 0, a.Length)
            Array.Copy(b, 0, result, a.Length, n - a.Length)
            Return result



        End Function
    'Given 2 int arrays, a And b, of any length, return a New array with the 
    'first element Of Each array. If either array Is length 0, ignore that array. 
    'Use an array. Do Not use a list.
    'front11(1, 2, 3, 7, 9, 8) → 1, 7
    'front11(1, 2) → 1, 2
    'front11(1, 7, ) → 1        

    Public Function front11(a As Integer(), b As Integer()) As Integer()

        int[] result = New int[Math.Min(a.Length, 1) + Math.Min(b.Length, 1)]
            int rpos = 0
            If (a.Length > 0) Then
            result[rpos++] = a[0]
            If (b.Length > 0) Then
                result[rpos++] = b[0]
            Return result


        End Function
    'Given 2 int arrays, a And b, of any length, return a New array with the 
    'first element Of Each array. If either array Is length 0, ignore that array. 
    'Use a list.
    'front11List(1, 2, 3, 7, 9, 8) → 1, 7
    'front11List(1, 2) → 1, 2
    'front11List(1, 7, ) → 1        

    Public Function front11List(a As Integer(), b As Integer()) As Integer()

        List<int> list = new List<int>()

            if (a != null And a.Length > 0)
                list.Add(a[0])
            End If
            if (b != null And b.Length > 0)
                list.Add(b[0])
            End If
            return list.ToArray()

    End Function


End Module

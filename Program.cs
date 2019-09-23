using System;
using System.Collections.Generic;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);

            int n2 = 5;
            printSeries(n2);

            int n3 = 5;
            printTriangle(n3);

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);

            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            Console.Write("{");
            for (int i = 0; i < r5.Length; i++)
            {
                Console.Write(r5[i] + ",");
            }
            Console.Write("}");

        }
        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                List<int> result = new List<int>(); // List to add the selfdividing numbers in a complete list
                for (int i = x; i <= y; i++)
                {
                    if (selfdividing(i))
                    {
                        result.Add(i); // Add function to add the numbers to the list
                    }
                }
                for (int i = 0; i < result.Count; i++)
                {
                    Console.WriteLine(result[i]);
                }

                bool selfdividing(int z) // Logic to find whether the number is selfdividing or not begins here
                {
                    int d, n = z; // d is the remainder variable and n is the current digit
                    while (n > 0)
                    {
                        d = n % 10; // Returns the remainder to d
                        if ((d == 0 && n != 0) || z % d != 0) // Checks whether the number is self divisble.
                            return false;
                        n /= 10;
                    }
                    return true;
                }
            }

            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }

        public static void printSeries(int a)
        {
            int length = 0; // Count variable
            var arr = new List<int>(); // List to add the numbers to the series
            try
            {
                for (int i = 1; i <= a; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        length++; // Increment the count
                        arr.Add(i); // Add to array
                        Console.Write(i + ","); // Write to array
                    }
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n)
        {
            try
            {
                for (int i = n; i > 0; i--) // Loop to print in inverted manner
                {
                    for (int j = n; j > i; j--)
                    {
                        Console.Write("  ");
                    }
                    for (int k = 0; k < (2 * i) - 1; k++) // Logic to multiply the n and minus 1 to display the triangle
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                int i = 0, count = 0; // Index and count variable initialization
                for (i = 0; i < S.Length; i++)
                {
                    if (Array.IndexOf(J, S[i]) >= 0) // Compares the elements of the array
                        count++; // Increases the count
                }
                return count;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
                return 0;
            }

        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {

            try
            {

                int start1 = 0, length1 = 0, start2 = 0, length2 = 0, i = 0, j = 0; // Variables for indexes and counts
                while (true)
                {
                    if (a[i] == b[j]) // Compares the elements
                    {
                        if (length2 == 0)
                            start2 = i;
                        length2++;  // Increments the indexes
                        i++;              
                        j++;
                    }
                    else
                    {
                        if (length2 >= length1 && start1 <= start2) // Compares the index counts
                        {
                            length1 = length2;
                            start1 = start2;
                        }
                        length2 = 0;
                        if (a[i] > b[j])
                            j++;
                        else
                            i++;
                    }
                    if (i >= a.Length || j >= b.Length) // Compare whether the indexes are past the maximum array length and breaks
                        break;
                }
                if (length2 >= length1 && start1 <= start2)
                {
                    length1 = length2;
                    start1 = start2;
                }
                if (length1 > 0) // If subarray index is greater than 0
                {
                    int[] lcs = new int[length1]; // Initialize the subarray with length1 value
                    for (i = 0; i < length1; i++)
                    {
                        lcs[i] = a[start1 + i]; // Write into the subarray
                    }
                    return lcs;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }
            return null;
        }

    }
}



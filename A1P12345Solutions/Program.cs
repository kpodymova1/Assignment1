using System;
using System.Collections.Generic;
using System.Linq;

namespace A1P12345Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            PrintSelfDividingNumbers(a, b);

            int n2 = 5; printSeries(n2);

            int n3 = 5; printTriangle(n3);

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);

            Console.Write("\n");
            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            displayArray(r5);

        }

        // Problem 1 Solution

        public static void PrintSelfDividingNumbers(int x, int y)
        {
            try
            {
                for (int runs = x; runs <= y; runs++)
                {
                    if (IsSelfDividing(runs))
                        Console.Write(runs + " ");
                }

            }

            catch
            {
                Console.WriteLine("Exception Occured while Computing printSelfDividingNumbers()");
            }

        }

        private static bool IsSelfDividing() // Got help here.
        {
            throw new NotImplementedException();
        }

        private static bool IsSelfDividing(int runs)
        {

            string enter = runs.ToString();
            char[] transformed = enter.ToCharArray();
            List<int> digits = new List<int>();
            foreach (char i in transformed)
            {
                int m = i - '0';
                digits.Add(m);
            }

            foreach (int k in digits)
            {
                if (k == 0)
                {
                    return false; // Got help with these in the beginning but now I figured it out.
                }
                else if (runs % k == 0)
                {
                    // при успехе не выходит из процедуры, а идет на следующую цифру
                }
                else if (runs % k != 0)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            return true;

        }

        // Problem 2 Solution

        public static void printSeries(int n)
        {
            Console.WriteLine("\n");
            try
            {
                for (int i = 0; i <= n; i++)
                {
                    int g = i;

                    for (int m = 1; m <= g; m++)
                    {
                        Console.Write("{0}, ", i);
                    }
                }
                Console.Write("\b\b ");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        // Problem 3 Solution

        public static void printTriangle(int n)

        {
            Console.WriteLine("\n");

            try
            {
                int u = ((n + n) - 1);

                for (int i = 0; i < n; i++)
                {
                    {
                        for (int m = 1; m <= i; m++)
                        {
                            Console.Write(" ");
                        }
                        for (int a = u; a > 0; a--)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    u = u - 2;
                }

                Console.Write("\n");

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        // Problem 4 Solution

        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {

                var count = 0;
                foreach (var i in S)
                {
                    foreach (var m in J)
                    {
                        if (i == m)
                        {
                            count = count + 1;
                        }
                        else
                        {

                        }
                    }
                }

                Console.WriteLine("The number of jewels is: {0}", count);
                Console.WriteLine("***I have nothing to do with the 0 below.***");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;

        }

        // Problem 5 Solution

        private static void displayArray(int[] arr)
        {
            Console.WriteLine(string.Join(",", arr));
        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {
                int[] result = new int[] { };

                List<int> temp = new List<int>();

                foreach (var e1 in a)
                {
                    foreach (var e2 in b)
                    {
                        if (e1 == e2)
                            temp.Add(e1);
                    }
                }

                List<List<int>> r = new List<List<int>>(); // I figured this.

                bool ElementInSequence = false; // HHH

                for (int i = 1; i < temp.Count; i++) // HHH I got help with this loop.
                {
                    if (temp[i] == temp[i - 1] + 1)
                    {
                        if (!ElementInSequence)
                        {
                            r.Add(new List<int>() { temp[i - 1] });
                            ElementInSequence = true;
                        }
                        r[r.Count - 1].Add(temp[i]);
                    }
                    else
                    {
                        ElementInSequence = false; // I figured this.
                    }
                }

                int elemsMax = 0; // HHH
                foreach (var v in r)
                {
                    if (v.Count >= elemsMax)
                    {
                        elemsMax = v.Count;
                        result = v.ToArray();
                    }
                }

                return result;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
                return null; // I figured this!
            }
        }

        // For Problem 5:
        /* Where it says '// HHH'  I got hints from my tutor - I first tried to compare
each integer in 'temp' to the next one but it would not work.
Didn't know how to proceed, so got help. If points are going
to be taken off - I think it is fair. */

    }
}
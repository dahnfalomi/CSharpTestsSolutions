using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTestsSolutions
{
    class Program
    {

        int[] A = {-1, 1, -2, 2, 1000, -1000};

        public int SmallestElement(int[] A)
        {
            int x = A.Min();
            return x;
        }

        public int SmallestElement2(int[] A)
        {
            int min = 0;

            Console.WriteLine("Array Length: " + A.Length);

            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] < min)
                {
                    min = A[i];
                }
            }

            return min;

        }

        public void StringofLenghtN()
        {
            string text = "";

            Console.WriteLine("Enter a Number: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(i);
                int x = i % 2;
                if (x == 0)
                {
                    text += "+";
                } else
                {
                    text += "-";
                }
            }

            Console.WriteLine("String of Lengt N: " + text);
        }

        public int[] test()
        {

            Console.WriteLine("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int n = 0;
            int p = 0;
            int rounded = 0;

            List<int> A = new List<int> { };
            int[] B = new int[] { };

            double z = (double)num / 2;

            if ((num % 2) != 0)
            {
                rounded = (int)Math.Ceiling(z);
                n = num - rounded;
                p = num - rounded;

                // Odd
                for (int i = 0; i < num; i++)
                {
                    if(i == 0)
                    {
                        A.Add(i);
                    } else if(n != 0)
                    {
                        int s = 0 - n;
                        A.Add(s);
                        n--;
                    } else if(p != 0)
                    {
                        A.Add(p);
                        p--;
                    }
                }

            } else
            {
                n = num - (int)z;

                // Even
                for (int i = 0; i < num; i++)
                {
                    int s = 0 - n;
                    A.Add(s);
                    A.Add(n);
                    n--;
                    i += 1;
                }
            }

            foreach (var item in A.ToArray())
            {
                Console.Write(" " + item);
            }

            return A.ToArray();
        }

        //public int solution(int[] A)
        //{
        //    // write your code in C# 6.0 with .NET 4.5 (Mono)

        //    int maxNum = 0;
        //    int positiveNum = 0;
        //    int tempNum = 0;
        //    int tempMax = 0;

        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        if (A[i] > maxNum)
        //        {
        //            maxNum = A[i];
        //        }


        //        tempMax = maxNum;
        //        tempNum = maxNum - 1;

        //        Console.WriteLine("positiveNum0: " + positiveNum);
        //        Console.WriteLine("maxNum0: " + maxNum);
        //        //Console.WriteLine("tempNum0: " + tempNum);
        //        Console.WriteLine("tempMax0: " + tempMax);
        //        Console.WriteLine("A[i]: " + A[i]);

        //        if (maxNum - 1 != A[i] && maxNum > positiveNum && maxNum > 1)
        //        {
        //            positiveNum = maxNum - 1;
        //            tempNum = positiveNum;
        //            Console.WriteLine("positiveNum1: " + positiveNum);
        //            Console.WriteLine("tempNum: " + tempNum);
        //        }
        //        else
        //        {
        //            positiveNum = maxNum + 1;
        //            Console.WriteLine("positiveNum2: " + positiveNum);
        //        }
        //    }

        //    return positiveNum;
        //}

        public int solution2()
        {
            //int[] A = {1, 3, 6, 4, 1, 2}; // 1,1,2,3,4,6
            //int[] A = { 1, 2, 3 };
            int[] A = { -1, -3, 2, 3 };
            //int[] A = { 1, 198, 199, 200 };
            //int[] A = { };

            int ans = 0;
            int cur = 0;
            int prev = 0;

            int[] sorted = A.OrderBy(x => x).ToArray();

            if(sorted.Length > 0)
            {
                int maxNum = A.Max();
                if (maxNum < 0)
                {
                    ans = 1;
                    Console.WriteLine("ans: " + ans);
                    return ans;
                }

                for (int i = 0; i < sorted.Length; i++)
                {
                    cur = sorted[i];

                    if(cur < 0)
                    {
                        prev = cur;
                    }

                    Console.WriteLine("cur: " + cur);
                    Console.WriteLine("prev: " + prev);
                    if (((prev + 1) == cur && sorted[i] != maxNum) || prev == cur)
                    {
                        prev = cur;
                    }
                    else if ((prev + 1) != cur)
                    {
                        ans = prev + 1;
                        if(ans == 0)
                        {
                            ans = 1;
                        }
                        break;
                    }
                    else
                    {
                        ans = maxNum + 1;
                    }
                }
            }

            Console.WriteLine("ans: " + ans);
            return ans;
        }

        public void ReverseString(string text)
        {

            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);

            string newStr = new string(charArray);
            Console.WriteLine("ans: " + newStr);
        }

        public void SortIntegersASC()
        {
            // Ref: https://www.geeksforgeeks.org/bubble-sort/
            int n = A.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        // swap temp and arr[i] 
                        int temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                }
            }

            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            // Display first item in the Array
            //Console.WriteLine(program.A[0]);

            // Display all items in the Array
            //foreach (var item in program.A)
            //{
            //    Console.WriteLine(item);
            //}

            //int x = program.SmallestElement(program.A);
            //int y = program.SmallestElement2(program.A);

            // #1
            // Find Smallest Number from the Array
            //Console.WriteLine("Smallest Number Solution 1: " + x);
            //Console.WriteLine("Smallest Number Solution 2: " + y);

            // #2
            // Ex. Enter a number: 5 and returns: 
            // 0 1 2 3 4 
            // +-+-+
            //program.StringofLenghtN();

            // #3
            // Ex. Enter a number: 5 and returns:
            // 0 -2 -1 2 1
            //program.test();

            // #4
            // Find the next smallest integer from the Array
            //program.solution2();

            // #5
            // Write a method that reverses a String using only String API functions
            //program.ReverseString("Danjo");

            // #6
            // Sort an array of integers from least to greatest without any API functions
            program.SortIntegersASC();

            Console.ReadKey(true);
        }
    }
}

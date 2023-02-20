using System;
using System.Collections.Generic;

//AI - Permutation for n number by recurency - we remember previous output 

namespace Permutation_by_MJas
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int n;
                Console.WriteLine("Hello, waiting for your n: ");
                n = Convert.ToInt32(Console.ReadLine());
                int[] arrayOfN = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arrayOfN[i] += i;
                }
                Console.WriteLine("Permutation for {0} num: \n", n);
                List<string> nList = new List<string>();

                nList = Permutation(arrayOfN, 0, n - 1, nList);
                foreach (string seq in nList)
                {
                    Console.WriteLine(seq + "\n");
                }
                string cmd;
                Console.WriteLine("Wanna Re-Use it?[y(any key)/n(n)] ");
                cmd = Console.ReadLine().ToUpper();
                if (cmd == "N")
                {
                    break;
                }

            }
        }
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }
        public static List<string> Permutation(int[] arrayOfN, int leftI, int rightI, List<string> nList)
        {
            if (leftI == rightI)
            {
                string seq = "";
                for (int i = 0; i <= rightI; i++)
                {
                    seq += Convert.ToString(arrayOfN[i]);
                }
                nList.Add(seq);

            }
            else
            {
                for (int i = leftI; i <= rightI; i++)
                {
                    Swap(ref arrayOfN[leftI], ref arrayOfN[i]);
                    Permutation(arrayOfN, leftI + 1, rightI, nList);
                    Swap(ref arrayOfN[leftI], ref arrayOfN[i]);
                }
            }
            return nList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 9, 3, 9, 3, 9, 7, 9, 7, 11 };
            Console.WriteLine(Solution(A));
        }

        public static int Solution(int[] A)
        {
            Array.Sort(A);
            for (int i = 0; i < A.Length - 1; i = i + 2)
            {
                if (A[i] != A[i + 1])
                {
                    return A[i];
                }
            }
            return A[A.Length - 1];
        }
    }
}

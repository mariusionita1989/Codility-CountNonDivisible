using System.Runtime.CompilerServices;

namespace Codility_CountNonDivisible
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 50000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int[] solution(int[] A)
        {
            int N = A.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                int maxElement = 2 * N;
                // Count the occurrences of each element in A
                Dictionary<int, int> countMap = new Dictionary<int, int>();
                foreach (int num in A)
                {
                    if (countMap.ContainsKey(num))
                        countMap[num]++;
                    else
                        countMap[num] = 1;
                }

                int[] result = new int[N];
                for (int i = 0; i < N; i++)
                {
                    int num = A[i];
                    int divisors = 0;
                    for (int j = 1; j <= Math.Sqrt(num); j++)
                    {
                        if (num % j == 0)
                        {
                            int firstDivisor = j;
                            int secondDivisor = num / j;
                            if (countMap.ContainsKey(firstDivisor))
                                divisors += countMap[firstDivisor];
                           
                            if (firstDivisor != secondDivisor && countMap.ContainsKey(secondDivisor))
                                divisors += countMap[secondDivisor];
                        }
                    }

                    result[i] = N - divisors;
                }

                return result;
            }
            
            return Array.Empty<int>();
        }
    }
}

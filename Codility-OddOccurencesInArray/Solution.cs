using System.Runtime.CompilerServices;

namespace Codility_OddOccurrencesInArray
{
    public class Solution
    {
        private const int RANGE_LOWEST_VALUE = 1;
        private const int RANGE_HIGHEST_VALUE = 1000000;
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            if (A.Length >= RANGE_LOWEST_VALUE && A.Length <= RANGE_HIGHEST_VALUE) 
            {
                int result = 0;
                foreach (int num in A)   // if you XOR all items from the array the paired values will be 0
                    result ^= num;       // and you will get the value that has no pair 
                                         // if we XOR 9^9 this will be  1001^            
                return result;           //                             1001      
            }                            //                             ----
            return 0;                    //                             0000 = 0
        }                                // if we XOR 0^7 the result will be 7 and that is how we can gen the value that has no pair
    }                                    
}
            

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Github_Demo
{
    public class LeetCode2
    {
        public int IdealArrays(int n, int maxValue)
        {
            const int MOD = 1000000007;

            // DP array to store the count of ideal arrays ending with each value
            var dp = new int[maxValue + 1];

            // Base case: for n = 1, every value from 1 to maxValue is a valid array of length 1
            for (int i = 1; i <= maxValue; i++)
            {
                dp[i] = 1;
            }

            // Process for length 2 to n
            for (int length = 2; length <= n; length++)
            {
                var newDp = new int[maxValue + 1];

                // For each possible last value in the array
                for (int lastValue = 1; lastValue <= maxValue; lastValue++)
                {
                    // Sum all values that can be the previous value (i.e., divisors of lastValue)
                    for (int prevValue = lastValue; prevValue <= maxValue; prevValue += lastValue)
                    {
                        newDp[lastValue] = (newDp[lastValue] + dp[prevValue]) % MOD;
                    }
                }

                // Update dp for the next length
                dp = newDp;
            }

            // The answer is the sum of all dp[maxValue]
            int result = 0;
            for (int i = 1; i <= maxValue; i++)
            {
                result = (result + dp[i]) % MOD;
            }

            return result;
        }
    }
}

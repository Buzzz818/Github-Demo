/*File Name: LeetCode2338.cs

*Name: Blake Miller 
*
*email:  mille7be@mail.uc.edu
*Assignment Number: Final Project  
*Due Date: 4/29/2025
*Course #/Section:   001
* Semester / Year:   Spring 2025
*Brief Description of the assignment:  Create a bootstrapped webpage to showcase 4 different leetcode
*solutions 

*Brief Description of what this module does: This is the class for LeetCode2338 
*Citations: https://chatgpt.com/
*Anything else that's relevant: 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Github_Demo
{
    // Solution to LeetCode2338
    public class LeetCode2338
    {
        /// <summary>
        /// Measures the total number of possible arrays based on parameter n and maxvalue
        /// </summary>
        /// <param name="n"> the length of the array </param>
        /// <param name="maxValue"> the max number allowed within the array</param>
        /// <returns> The total amount of possible arrays given size and max value</returns>
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

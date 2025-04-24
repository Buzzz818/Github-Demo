/*File Name: LeetCode123.cs
*Name: Co Nguyen
*      
*email: nguye2co@mail.uc.edu
*Assignment Number: Final Project  
*Due Date: 4/29/2025
*Course #/Section:   001
* Semester / Year:   Spring 2025
*Brief Description of the assignment:  Create a bootstrapped webpage to showcase 4 different leetcode
*solutions 

*Brief Description of what this module does. This is the class for LeetCode123
*Citations: https://chatgpt.com/
*Anything else that's relevant: 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Github_Demo
{   
     // Solution to LeetCode123
    public class LeetCode123
    {
        public string Id => "maxProfit";
        public string Description => "You are given an array prices where prices[i] is the price of a given stock on the ith day. Find the maximum profit you can achieve. You may complete at most two transactions.";
        public int[] TestCase => new[] { 3, 3, 5, 0, 0, 3, 1, 4 };
        /// <summary>
        /// Generates the maximum amount of profit generated off of a given array of stock prices
        /// with a max of two transactions
        /// </summary>
        /// <param name="prices"> array of prices in chronological order</param>
        /// <returns> Maximum profit given the prices </returns>
        public int Solution(int[] prices)
        {
            if (prices.Length == 0) return 0;
            int firstBuy = int.MinValue, firstSell = 0;
            int secondBuy = int.MinValue, secondSell = 0;
            foreach (int price in prices)
            {
                firstBuy = Math.Max(firstBuy, -price);
                firstSell = Math.Max(firstSell, firstBuy + price);
                secondBuy = Math.Max(secondBuy, firstSell - price);
                secondSell = Math.Max(secondSell, secondBuy + price);
            }
            return secondSell;

        }
    }
}
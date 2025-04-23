using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Github_Demo
{
    public class LeetCode123
    {
        public string Id => "maxProfit";
        public string Description => "You are given an array prices where prices[i] is the price of a given stock on the ith day. Find the maximum profit you can achieve. You may complete at most two transactions.";
        public int[] TestCase => new[] { 3, 3, 5, 0, 0, 3, 1, 4 };

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
namespace Algorithms.BestTimeToBuyAndSellStock;


// You are given an array prices where prices[i] is the price of a given stock on the ith day.
// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

// Input: prices = [7,1,5,3,6,4]
// Output: 5
// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

// Input: prices = [7,6,4,3,1]
// Output: 0
// Explanation: In this case, no transactions are done and the max profit = 0.


public class Solution {

    public static int fold(int[] list, int idx, int acc) 
    {
        return (idx > list.Length - 1) switch {
            true => acc,
            _ => fold(list, idx + 1, acc + list[idx])
        };
    }

    public static int getCmp(int[] list, int idx, int val, Func<int, int, int> cmp)
    {
        return (idx > list.Length - 1) switch {
            true => val,
            _ => getCmp(list, idx + 1, cmp(val, list[idx]), cmp)
        };
    }

    // there are peaks and troughs in the timeline    
    public int MaxProfit(int[] prices) {
        return 0;
    }
}
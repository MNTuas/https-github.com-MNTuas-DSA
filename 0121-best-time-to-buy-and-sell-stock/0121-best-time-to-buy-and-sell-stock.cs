public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = prices[0];
        int maxProfit = 0;

        for(int i = 1; i < prices.Length; i++){
            int sell = prices[i];

            if(sell < buy){
                buy = sell;
            }else{
                int profit = sell - buy;
                if(profit > maxProfit){
                    maxProfit = profit;
                }
            }
        }
        return maxProfit;
    }
}
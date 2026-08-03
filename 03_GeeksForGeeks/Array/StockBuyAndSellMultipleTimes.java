public class StockBuyAndSellMultipleTimes {
    public static void main(String[] args) {
        int[] prices = {100, 180, 260, 310, 40, 535, 695};
        int min = 0;
        int maxTotalProfit = 0;
        boolean boughtStock = false;

        for(int i = 0; i < prices.length - 1; i++) {
            if(prices[i+1] > prices[i] && !boughtStock) {
                min = prices[i];
                boughtStock = true;
            }

            if(prices[i+1] < prices[i] && boughtStock) {
                int profit = prices[i] - min;
                maxTotalProfit += profit;
                min = 0;
                boughtStock = false;
            }

            if((i == prices.length-2) && boughtStock) {
                int profit = prices[i+1] - min;
                maxTotalProfit += profit;
            }
        }
        System.out.println(maxTotalProfit);
    }
}

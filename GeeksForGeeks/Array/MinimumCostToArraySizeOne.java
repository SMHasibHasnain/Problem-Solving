//Minimum cost to make array size 1 by removing larger of pairs

public class MinimumCostToArraySizeOne {
    public static void main(String[] args) {
        int[] arr = {4 ,3 ,2 };
        int n = arr.length;
        int min = Integer.MAX_VALUE;
        for (int i = 0; i < n; i++) {
            if(arr[i] < min) {
                min = arr[i];
            }
        }
        int cost = min * (n-1);
        System.out.println(cost);
    }
}

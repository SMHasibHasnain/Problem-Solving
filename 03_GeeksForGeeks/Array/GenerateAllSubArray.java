//Given an array arr[], the task is to generate all the possible subarrays of the given array.

public class GenerateAllSubArray {
    public static void main(String[] args) {
        int[] arr = {1, 2, 3, 4};
        for(int i = 0; i<arr.length; i++){
            for(int j = i; j<arr.length; j++){
                for(int k = i; k<=j; k++){
                    System.out.print(arr[k]+" ");
                }
                System.out.println();
            }
        }
    }
}

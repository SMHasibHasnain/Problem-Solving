public class RemoveDuplicatesFromSortedArray {

    public static int removeDuplicates(int[] nums) {
        int n = nums.length;
        int ptr = -1;
        int k = Integer.MAX_VALUE;

        for (int i = 0; i < n; i++) {
            if(nums[i] != k) {
                ptr++;
                nums[ptr] = nums[i];
                k = nums[i];
            }
        }
        return ptr+1;
    }

    public static void main(String[] args) {
        int[] arr = {};

        int newLength = removeDuplicates(arr);

        for(int i = 0; i < newLength; i++) {
            System.out.print(arr[i] + " ");
        }

    }
}

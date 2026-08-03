public class RotateArray {
    public static void main(String[] args) {
        int[] arr = {1,2,3,4,5,6,7,8,9};
        int n = arr.length;
        int itr = 2;

        for(int i: arr) {
            System.out.print(i + " ");
        }
        System.out.println();

/*
        #BruteForce - Time: O(n*itr); Space:O(1)
        for(int i = 0; i<itr; i++){
            int store = arr[n-1];
            for(int j = n-2; j>=0; j--){
                arr[j+1] = arr[j];
            }
            arr[0] = store;
        }
*/
        // Efficient, Time Compexity: O(n);
        rotate(arr, 0, arr.length-1);
        rotate(arr, 0, itr-1);
        rotate(arr, itr, arr.length-1);

        for(int i: arr) {
            System.out.print(i + " ");
        }
    }

    public static void rotate(int[] arr, int s, int e) {
        int last = e;
        for(int i = s; i<= (s + (e-s)) / 2; i++) {
            int temp = arr[i];
            arr[i] = arr[last];
            arr[last] = temp;
            last--;
        }
    }
}

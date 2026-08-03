public class ArrayReverse {

    public static void main(String[] args) {
        int[] arr = {4, 5, 1, 2};

        for(int i=0; i<(arr.length)/2; i++) {
            int temp = arr[i];
            arr[i] = arr[arr.length-i-1];
            arr[arr.length-i-1] = temp;
        }

        for(int i = 0; i < arr.length; i++) {
            System.out.print(arr[i] + " ");
        }

    }
}

public class IsArraySorted {
    public static void main(String[] args) {
        int[] arr = {10, 20, 30, 40, 50};
        boolean isSorted = true;

        for (int i = 1; i < arr.length; i++) {
            if(arr[i] < arr[i-1]) {
                isSorted = false;
                break;
            }
        }

        System.out.println(isSorted);

    }
}

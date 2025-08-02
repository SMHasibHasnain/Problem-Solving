public class MakeEqual {
    public static void main(String[] args) {
        int[] arr = {-3, -9, -15, -12, -3};
        int max = Integer.MIN_VALUE;
        int k = 3;
        int count = 0;

        for(int i = 0; i < arr.length; i++) {
            if(arr[i] > max) {
                max = arr[i];
            }
        }

        for(int i = 0; i < arr.length; i++) {
            int sub = max - arr[i];
            if(sub % k == 0) {
                count = count + (sub / k);
            } else {
                count = -1;
                break;
            }
        }

        System.out.println(count);
        System.out.println(0%3);

    }
}

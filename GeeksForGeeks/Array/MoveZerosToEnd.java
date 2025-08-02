public class MoveZerosToEnd {
    public static void main(String[] args) {
        int[] arr = {1, 2, 0, 4, 3, 0, 5, 0};
//        int left = 0;
//        int right = arr.length - 1;
//        while (left < right) {
//            if (arr[left] == 0 && arr[right] != 0) {
//                arr[left] = arr[right];
//                arr[right] = 0;
//                left++;
//                right--;
//            } else if (arr[left] == 0 && arr[right] == 0) {
//                right--;
//            } else if(arr[left] != 0 && arr[right] == 0) {
//                left++;
//            } else if(arr[left] != 0 && arr[right] != 0) {
//                left++;
//            }
//        }


        // clear version

        int ptr = 0;

        for(int i=0; i<arr.length; i++){
            if(arr[i] != 0){
                int temp = arr[i];
                arr[i] = arr[ptr];
                arr[ptr] = temp;
                ptr++;
            }
        }


        for(int i: arr) {
            System.out.print(i + " ");
        }
    }
}

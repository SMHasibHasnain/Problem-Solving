import java.util.ArrayList;
import java.util.Arrays;

public class LeadersInAnArray {
    public static void main(String[] args) {
        int[] arr = {1, 2, 3, 4, 5, 2};

        int ptr = arr.length - 1;

        for(int i = arr.length - 2; i >= 0; i--) {
            if(arr[i] > arr[ptr]) {
                arr[--ptr] = arr[i];
            }
        }

        for(int i = ptr; i <= arr.length - 1; i++) {
            System.out.print(arr[i] + " ");
        }

    }
}

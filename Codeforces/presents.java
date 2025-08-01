import java.util.Scanner;

public class presents {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];
        for(int i = 0; i < n; i++) {
            arr1[i] = in.nextInt() - 1;
        }

        for(int i = 0; i < n; i++) {
            for(int j = 0; j < n; j++) {
                if(i == arr1[j]) {
                    arr2[i] = j;
                }
            }
        }

        for(int i = 0; i < n; i++) {
            System.out.print(arr2[i] + 1 + " ");
        }
    }
}

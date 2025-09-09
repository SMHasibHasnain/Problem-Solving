import java.util.Arrays;

public class SumOfTwoArrays {
    public static void main(String[] args) {
        int[] b = {4, 3, 2, 5, 6, 6, 7, 9};
           int[] a = {6, 8, 9, 7, 5, 3, 3};

        int maxLength = Math.max(a.length, b.length);
        int[] sum = new int[maxLength];

        int mod = 0;
        int i, j;
        for(i=a.length-1, j=b.length-1; i>=0 || j>=0; i--, j--) {

            int cal;
            if(i >= 0 && j>= 0) {
                cal = mod + a[i] + b[j];
            } else if(i >= 0 && j < 0) {
                cal = mod + a[i];
            } else {
                cal = mod + b[j];
            }

            mod = cal/10;
            sum[--maxLength] = cal%10;

        }

        if(mod != 0) {
            System.out.print("Sum of two arrays is: " + mod + " ");
        }

        for(int k=0; k<sum.length; k++) {
            System.out.print(sum[k] + " ");
        }

    }
}

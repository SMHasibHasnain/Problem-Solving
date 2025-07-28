import java.util.Scanner;

public class VanyaAndFence {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        int h = sc.nextInt();

        int[] fh = new int[n];

        for(int i = 1; i <= n; i++) {
            fh[i-1] = sc.nextInt();
        }

        int w = 0;

        for(int i = 0; i<n; i++) {
            if(fh[i] > h) {
                w += 2;
            } else {
                w++;
            }

        }

        System.out.println(w);
    }
}

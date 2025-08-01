import java.util.Scanner;

public class Magnets {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        int tracker = 0;
        int groups = 0;
        for (int i = 0; i < n; i++) {
            int x = sc.nextInt();
            if(tracker != x) {
                tracker = x;
                groups++;
            }
        }
        System.out.println(groups);
    }
}

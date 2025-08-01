import java.util.Scanner;

public class InSearchOfEasyProblems {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        boolean isHard = false;
        for (int i = 0; i < n; i++) {
            int a = sc.nextInt();
            if(a == 1) {
                isHard = true;
            }
        }

        if(isHard) {
            System.out.println("HARD");
        } else {
            System.out.println("EASY");
        }
    }
}

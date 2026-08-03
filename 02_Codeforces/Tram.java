import java.util.Scanner;

public class Tram {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();

        int maxCurrPass = 0;
        int currPas = 0;

        for(int i = 1; i <= n; i++) {
            int out = sc.nextInt();
            currPas -= out;
            int in = sc.nextInt();
            currPas += in;

            if(currPas>maxCurrPass) {
                maxCurrPass = currPas;
            }
        }
        System.out.println(maxCurrPass);
    }
}

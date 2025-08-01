import java.util.Scanner;

public class CalculatingFuncton {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        long n = sc.nextLong();

        long cal = (n%2 == 0) ? n/2 : -(n+1)/2;

        System.out.println(cal);
    }
}

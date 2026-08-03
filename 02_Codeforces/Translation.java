import java.util.Scanner;

public class Translation {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String s = sc.nextLine();
        String t = sc.nextLine();

        String r = "";

        char ch;

        for (int i = 0; i < s.length(); i++) {
            ch = s.charAt(i);
            r = ch + r;
        }

        if(t.equals(r)) {
            System.out.println("YES");
        } else {
            System.out.println("NO");
        }
    }
}

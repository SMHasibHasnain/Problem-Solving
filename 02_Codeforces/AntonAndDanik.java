import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        String m = sc.nextLine();
        String s = sc.nextLine();

        int anton = 0;
        int danik = 0;

        for (int i = 0; i < s.length(); i++) {
            if(s.charAt(i) == 'A') {
                anton++;
            } else if(s.charAt(i) == 'D') {
                danik++;
            }
        }

        if(anton > danik) {
            System.out.println("Anton");
        } else if(danik > anton) {
            System.out.println("Danik");
        } else {
            System.out.println("Friendship");
        }

    }


}

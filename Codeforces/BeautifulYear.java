import java.util.Scanner;

public class BeautifulYear {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int year = sc.nextInt();
        boolean isContinue = true;
        while(isContinue) {
            boolean hasDuplicate = false;
            year++;
            String str = Integer.toString(year);

            outer:
            for(int i = 0; i < str.length(); i++) {
                inner:
                for(int j = i+1; j < str.length(); j++) {
                    if(str.charAt(i) == str.charAt(j)) {
                        hasDuplicate = true;
                        break outer;
                    }
                }
            }

            if(!hasDuplicate) {
                isContinue = false;
            }
        }

        System.out.println(year);


    }
}

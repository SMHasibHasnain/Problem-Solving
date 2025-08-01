import java.util.Scanner;

public class QueueAtTheSchool {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int t = in.nextInt();
        char[] s = in.next().toCharArray();

        for(int i = 0; i < t; i++){
            for(int j = 0; j < s.length - 1; j++){
                if(s[j] == 'B' && s[j+1] == 'G'){
                    char temp = s[j];
                    s[j] = s[j+1];
                    s[j+1] = temp;
                    j++;
                }
            }
        }

        System.out.println(String.valueOf(s));

    }
}

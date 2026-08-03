import java.util.Scanner;

public class BeautifulMatrix {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int[][] matrix = new int[5][5];
        int m = 0;
        int n = 0;
        for(int i=0; i<5; i++) {
            for(int j=0; j<5; j++) {
                matrix[i][j] = sc.nextInt();
                if(matrix[i][j]==1) {
                    m = i+1;
                    n = j+1;
                }
            }
        }

        if(m>3) {
            m = m-3;
        } else if(m<3) {
            m = 3-m;
        } else {
            m = 0;
        }

        if(n>3) {
            n = n-3;
        } else if(n<3) {
            n = 3-n;
        } else {
            n = 0;
        }

        System.out.println(m+n);

    }
}

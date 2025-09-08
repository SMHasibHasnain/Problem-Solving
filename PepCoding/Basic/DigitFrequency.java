public class DigitFrequency {
    public static void main(String[] args) {
        int n = 4545834;
        int k = 4;

        int temp = n;
        int count = 0;

        while(temp != 0) {
            if(temp%10 == k) {
                count++;
            }
            temp = temp/10;
        }
        System.out.println(count);
    }
}

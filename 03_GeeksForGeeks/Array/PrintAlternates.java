public class PrintAlternates {
    public static void main(String[] args) {
        int[] arr = {-5, 1, 4, 2, 12};
        for(int i=0; i<arr.length; i+=2){
            System.out.print(arr[i] + " ");
        }
    }
}

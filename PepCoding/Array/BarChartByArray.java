public class BarChartByArray {
    public static void main(String[] arg) {
        int[] arr = {5, 3, 1, 0, 7, 5};
        int max = -9999;
        for(int i=0; i<arr.length; i++) {
            if(arr[i]>max) {
                max = arr[i];
            }
        }

        for(int i=max; i>=1; i--) {
            for(int j=0; j<arr.length; j++) {
                if(arr[j]>=i) {
                    System.out.print("  *");
                } else {
                    System.out.print("   ");
                }
            }
            System.out.println();
        }

    }
}

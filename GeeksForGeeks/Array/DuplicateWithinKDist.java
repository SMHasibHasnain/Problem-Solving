public class DuplicateWithinKDist {
    public static void main(String[] args) {
        int[] arr = {1, 2, 3, 4, 1, 2, 3, 4};
        int k = 3;
        boolean duplicate = false;
        outer:
        for(int i = 0; i < arr.length; i++) {
            for(int j = i+1; j < i+k && i+k <arr.length; j++) {
                if(arr[i] == arr[j]) {
                    duplicate = true;
                    break outer;
                }
            }
        }
        System.out.println(duplicate);
    }
}

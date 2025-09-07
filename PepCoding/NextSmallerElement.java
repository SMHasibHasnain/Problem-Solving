import java.util.*;

public class NextSmallerElement {
    public static void main(String[] args) {
        int[] arr = [4, 5, 3, 2, 6, 1, 7, 2, 3, 2];
        Stack<Integer> stack = new Stack<>();

        stack.push(0);
        for(int i=1; i<arr.length; i++) {
            if(arr[i]<arr[stack.peek()]) {
                while(!stack.isEmpty() && arr[i]<arr[stack.peek()]) {
                    stack.pop();
                    System.out.println(arr[i]);
                }
                stack.push(i);
            } else {
                stack.push(i);
            }
        }
        while(!stack.isEmpty()) {
            stack.pop();
            System.out.println("-1");
        }
    }
}

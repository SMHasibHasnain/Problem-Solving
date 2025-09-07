import java.util.*;

public class StockSpan {
    public static void main(String[] args) {
        int[] arr = {2, 4, 3, 8, 7, 6, 5, 9, 1};
        Stack<Integer> stack = new Stack<>();
        stack.push(0);
        System.out.println("1");
        for(int i=1; i<arr.length; i++) {
            if(arr[i]>arr[stack.peek()]) {
                while(!stack.isEmpty() && arr[i]>arr[stack.peek()]) {
                    stack.pop();
                }
                if(stack.isEmpty()) {
                    System.out.println(i+1);
                } else {
                    System.out.println(i-stack.peek());
                }
            } else {
                System.out.println(i-stack.peek());
            }
            stack.push(i);
        }
    }
}

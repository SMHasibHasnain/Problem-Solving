import java.util.*;

public class LargestAreaHistogram {
    public static void main(String[] args) {
        int[] arr = {2, 6, 5, 7, 1, 3, 2};
        Stack<Integer> stack = new Stack<>();

        int[] leftBound = new int[arr.length];

        for(int i=arr.length-1; i>=0; i--) {
            if(!stack.isEmpty() && arr[i]<arr[stack.peek()]) {
                while(!stack.isEmpty() && arr[i]<arr[stack.peek()]){
                    leftBound[stack.pop()] = i;
                }
                stack.push(i);
            } else {
                stack.push(i);
            }
        }

        while(!stack.isEmpty()) {
            leftBound[stack.pop()] = -1;
        }


        int[] rightBound = new int[arr.length];

        for(int i=0; i<arr.length; i++) {
            if(!stack.isEmpty() && arr[i]<arr[stack.peek()]) {
                while(!stack.isEmpty() && arr[i]<arr[stack.peek()]){
                    rightBound[stack.pop()] = i;
                }
                stack.push(i);
            } else {
                stack.push(i);
            }
        }

        while(!stack.isEmpty()) {
            rightBound[stack.pop()] = arr.length;
        }

        int maxArea = -1;
        for(int i=0; i<arr.length; i++) {
            if(((rightBound[i]-leftBound[i] - 1) * arr[i]) > maxArea) {
                maxArea = (rightBound[i]-leftBound[i] - 1) * arr[i];
            }
        }

        System.out.println(Arrays.toString(leftBound));
        System.out.println(Arrays.toString(rightBound));
        System.out.println(maxArea);


    }
}

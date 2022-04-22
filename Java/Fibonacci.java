import java.util.ArrayList;

//import java.util.*;

public class Fibonacci {
    public static ArrayList<Integer> arrRes = new ArrayList<>();
    public static ArrayList<Integer> recurFib(int[] arr, int range, int left){
        int sum = 0; 
        int index = left + range -1;
        if(index >= arr.length) {
            if(left != arr.length){
                while(left < arr.length) {
            sum += arr[left];
                left++;
            }
            arrRes.add(sum);};
            return arrRes;
        } else {
            for(int i = left; i <= index; i++) {
                sum += arr[i];
            };
            arrRes.add(sum);
            return recurFib(arr, range, index+1);
        }
    }
    public static void main(String[] args){
        int[] arr1 = {1,2,3,4,7,8,9}; // Expect: {3,7,15}
        ArrayList<Integer> arrRes = recurFib(arr1, 2, 0);
        System.out.println(arrRes);
    }
}
//Mission Completeted

import java.util.Random;
import java.util.Arrays;
public class SortList {
    public static int[] sortN(int[] arr) {
        for(int i = 1; i < arr.length; i++) {
            int current = arr[i];
            int j = i-1;
            while(j >= 0 && arr[j] > current) {
                arr[j+1] = arr[j];
                arr[j] = current;
                j--;
            }
            System.out.print(Arrays.toString(arr)+" => ");
        };
        return arr;
    }
    public static void sortMerge1(int[]arr) {
        int arrLength = arr.length;
        if(arrLength < 2){
            return;
        };
        int mid = arrLength/2;
        int[] leftArr = new int[mid];
        int[] rightArr = new int[arrLength - mid];
        for(int i = 0; i < mid; i++) {
            leftArr[i] = arr[i];
        };
        for(int j = mid; j < arrLength; j++) {
            rightArr[j -mid] = arr[j];
        };

        sortMerge1(leftArr);
        sortMerge1(rightArr);
        sortMerge2(arr, leftArr, rightArr);
    }
    public static void sortMerge2(int[] arr, int[] leftHaft, int[] rightHaft) {
        int leftSize = leftHaft.length;
        int rightSize = rightHaft.length;

        int i = 0, j = 0, k = 0;
        while(i < leftSize && j < rightSize) {
            if( leftHaft[i] <= rightHaft[j]){
                arr[k] = leftHaft[i];
                i++;
            } else {
                arr[k] = rightHaft[j];
                j++;
            };
            k++;
        }

        while( i < leftSize) {
            arr[k] = leftHaft[i];
            i++;
            k++;
        }while( j < rightSize) {
            arr[k] = rightHaft[j];
            j++;
            k++;
        }
    }
    public static int[] sortL(int[] arr) {
        for(int i = 0; i < arr.length; i++){
            int min = arr[i];
            for (int j = i+1; j < arr.length;j++) {
                if(arr[j] < min) {
                    int temp = arr[j];
                    arr[j] = min;
                    min = temp;
                    arr[i] = min;
                }
            }

        };
        return arr;
    }
    public static void main(String[] args) {
        int[] xx = {12,4,6,0,9,3,23,-7,32,5,-6,-3,-19};
 //       System.out.println("Result 1: "+Arrays.toString(SortList.sortL(xx)));
   //     System.out.println();
        //System.out.println("\nResult 2: "+Arrays.toString(SortList.sortN(xx)));
        //int[] n = SortList.sortMerge1(xx, 0, xx.length);
        //System.out.println(Arrays.toString(n));
        //System.out.println(Arrays.toString(SortList.sortMerge2(xx)));
        Random rand = new Random();
        int[] arrR= new int[10];
        for (int i = 0; i < arrR.length;i++) {
            arrR[i] = rand.nextInt(100);
        };
        System.out.println("Before: ");
        printArray(arrR);
        printArray(xx);
        sortMerge1(arrR);
        sortMerge1(xx);
        System.out.println("\nAfter: ");
        printArray(arrR);
        printArray(xx);
    }
    private static void printArray(int[] arrR) {
        System.out.println(Arrays.toString(arrR));
    }
}
public class BinarySearch {
    public static int binarySearch(int[] arr, int left, int right, int target) {
        int mid = left + (right-left)/2 ;
        if(target == arr[mid]) {
            return mid;
        } else if(target < arr[mid]) {
            return binarySearch(arr, left, mid-1, target);
        } else if (target > arr[mid]) {
            return binarySearch(arr, mid+1, right, target);
        } else {
            return -1;
        }
    }
    public static void main(String[] args) {
        int[] arr = {2,5,6,8,9,10};
        int target = 8;
        int left = 0;
        int right = arr.length-1;
        int index = binarySearch(arr, left, right, target);
        if(index != -1) {
            System.out.println("Element found at index " + index);
        } else {
            System.out.println("Element not found in the array");
        }
    }
}
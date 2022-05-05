import java.util.*;

public class Array {
    public static void main(String[] agrs){
    //Array- fixed-size order collection of items of the same data type
        int[] num1 = new int[4];
        num1[2] = 6;
        int[] num2 = {9,4,2,6};
        System.out.println(Arrays.toString(num1)); // [0,0,6,0]
        System.out.println(Arrays.toString(num2));

        String[] str1 = {"coffee","crazy","control"};
        System.out.println(Arrays.toString(str1)); // [coffee, crazy, control]
        for(String str : str1) {
            System.out.println(str);
        };
        
        //Find Index
        int x = Arrays.binarySearch(num1, 6); 
        System.out.println(x);
        
        //Copy array
        int[] y = Arrays.copyOf(num1, 5);
        System.out.println(Arrays.toString(y));
        
        //Copy array by range
        String[] z = Arrays.copyOfRange(str1, 1, 2);
        System.out.println(Arrays.toString(z));
        
        //Check 2 arrays if they are equal
        String[] str2 = {"coffee", "crazy","control"};//true
        //String[] str2 = {"Coffee", "Crazy","Control"}; //false
        String[] str3 = {"coffee", "control","crazy","manage"}; //false
        boolean check1 = Arrays.equals(str1, str2); 
        System.out.println(check1);

        //Compare 2 arrays lexicographically - về mặt từ vựng 
        int a = Arrays.compare(str1, str2);//0 no difference
        int b = Arrays.compare(num1, y);// -1 : difference in size();
        //int ? = Arrays.compare(z, y); error (String[], int[])
        int c = Arrays.compare(str1, str3); // 3 
        int d = Arrays.compare(num1, num2); // -1 
        System.out.println(d);

        //Fill array
        int[] num3 = new int[5];
        Arrays.fill(num3, 2);
        System.out.println(Arrays.toString(num3));

        //Sort
        Arrays.sort(num2);
        System.out.println(Arrays.toString(num2));

        System.out.println(num2.length);

        //ArrayList - resizable 
        //import java.util.ArrayList;
        //.add(value); set(index,value); remove(index); size(); get(index); clear()
        ArrayList<Integer> arr1 = new ArrayList<Integer>();
        arr1.add(1);
        arr1.add(9);
        arr1.add(2);
        arr1.add(6);
        arr1.add(2);
        arr1.add(4);
        System.out.println(arr1);
        arr1.set(0,0);
        System.out.println(arr1);
        //Sort ArrayList
        Collections.sort(arr1);
        System.out.println(arr1);
        
        //LinkedList -- has all ArrayList class method
        //But add some additional method
        LinkedList<String> arr2 = new LinkedList<String>();
        arr2.addFirst("I'm");
        arr2.add("crazy");
        arr2.addLast("now");
        System.out.println(arr2);
        arr2.removeLast();
        System.out.println(arr2);
        System.out.println(arr2.getLast());
        arr2.addLast("mad");
        arr2.add("really");
        arr2.add("very");
        System.out.println(arr2);

        //HashMap -- objects stores an unorder collection of items in "key-value" pairs of object data types
        //import java.util.HashMap;
        HashMap<Integer,String> hashmap1 = new HashMap<Integer,String>();
        hashmap1.put(1, "my day");
        hashmap1.put(24, "her day");
        hashmap1.put(9, "my month");
        hashmap1.put(2, "her month");
        System.out.println(hashmap1);

        //put(key,value); remove(key); get(key)= value; size();clear()
        System.out.println(hashmap1.get(2));
        hashmap1.remove(2);
        System.out.println(hashmap1.get(2)); //null
        //Loop -keySet()
        for(int key: hashmap1.keySet()){
            System.out.println("key: "+key+" value: "+hashmap1.get(key));
        };

        //HashSet -- object stores an unorder collection where every item is unique
        HashSet<String> hashset1 = new HashSet<>();
        hashset1.add("knife");
        hashset1.add("gun");
        System.out.println(hashset1);
        hashset1.add("knife");
        System.out.println(hashset1);//still [knife,gun] cause knife has added already
        hashmap1.put(9,"another 9");
        System.out.println(hashmap1);//change value of repeat-key
        //contains - true/false
        System.out.println(hashset1.contains("shotgun"));
        
    }
}

import java.util.*;
public class Lab2 {
    public static void main(String[] args) {
        System.out.println("1. ");
        HashMap<String,Integer> hash1 = new HashMap<>();
        Scanner input = new Scanner(System.in);
        System.out.print("Enter a year: ");
        int num1 = input.nextInt();
        System.out.print("Enter a month: ");
        String str1 = input.next();
        if(num1 < 1700 || num1 > 2022){
            System.out.println("Error input year!");
        };
        hash1.put("Jan", 31);
        hash1.put("Feb", 28);
        hash1.put("Mar", 31);
        hash1.put("Apr", 30);
        hash1.put("May", 31);
        hash1.put("Jun", 30);
        hash1.put("Jul", 31);
        hash1.put("Aug", 31);
        hash1.put("Sep", 30);
        hash1.put("Oct", 31);
        hash1.put("Nov", 30);
        hash1.put("Dec", 31);
        str1 = str1.substring(0,1).toUpperCase() + str1.substring(1);
        if(!hash1.containsKey(str1)){
            System.out.println("Please enter short month like: Jan (January)!");
        } else {
            System.out.printf("%s %d has %d days\n",str1, num1, hash1.get(str1));
        };


        System.out.println("2.");
        String[] arr1 = new String[3];
        System.out.print("Enter the first city: ");
        String str2 = input.next();
        str2 = str2.substring(0,1).toUpperCase() + str2.substring(1);
        arr1[0] = str2;
        System.out.print("Enter the second city: ");
        str2 = input.next();
        str2 = str2.substring(0,1).toUpperCase() + str2.substring(1);
        arr1[1] = str2;
        System.out.print("Enter the third city: ");
        str2 = input.next();
        str2 = str2.substring(0,1).toUpperCase() + str2.substring(1);
        arr1[2] = str2;
        System.out.print("The three cities in alphabetical order are ");
        Arrays.sort(arr1);
        for(String str : arr1) {
            System.out.print(str+ " ");
        };
        
        System.out.println("\n3 & 4. ");
        Scanner input2 = new Scanner(System.in);
        System.out.print("Enter quote to reverse: ");
        String str3 = input2.nextLine();
        Palindrome(str3);
        
        System.out.println("\n5. ");
        System.out.print("Enter list: ");
        String str4 = input2.nextLine();
        ArrayList<Integer> listNum = changeInputStr(str4);
        
        ArrayList<Integer> sorted = checkSort(listNum);
        
        if(listNum.equals(sorted)){
            System.out.println("This list is already sorted");
        }else {
            System.out.println(sorted.toString());
            System.out.println("This list is not sorted");
        };
        System.out.println("\n5.");
        ArrayList<Integer> arr = new ArrayList<Integer>();
        for(int i = 0; i<100;i++) {
            int x = (int) Math.round(Math.random()*9);
            arr.add(x);
        };
        int count2 = 0;
        for (Integer i : arr) {
            System.out.print(i);
            count2++;
            if(count2 == 6){
                System.out.println();
                count2 = 0;
            };
        };
        System.out.println("\n6.");
        System.out.print("Enter list: ");
        String str5 = input2.nextLine();
        ArrayList<Integer> listNum2 = changeInputStr(str5);
        ArrayList<Integer> listDistin = new ArrayList<>();
        HashMap<Integer,Integer> obj = new HashMap<Integer,Integer>();
        for(int i = 0; i < listNum2.size(); i++){
            if(!listDistin.contains(listNum2.get(i))){
                listDistin.add(listNum2.get(i));
                obj.put(listNum2.get(i), 1);
            } else {
                int val = obj.get(listNum2.get(i));
                val++;
                obj.replace(listNum2.get(i), val);
                continue;
            };
        };
        ArrayList<Integer> x = new ArrayList<>();
        for (Integer dis : obj.keySet()) {
            if(obj.get(dis) == 1){
                x.add(dis);
                System.out.printf("%d occurs %d time\n",dis,obj.get(dis));
            } else {
                System.out.printf("%d occurs %d times\n",dis,obj.get(dis));
            };
        }
        System.out.println("The distinct number of distinct number are "+x.toString());
        System.out.print("\n"+listDistin.toString()+"\n");
        input2.close();
        input.close();
    }
    public static void Palindrome(String str) {
        char[] arr1 = new char[str.length()];
        char[] arr2 = new char[str.length()];
        str.getChars(0,str.length(),arr1,0);
        StringBuilder strBuild = new StringBuilder("");
        for(int i = 0; i < str.length(); i++) {
            arr2[i] = arr1[str.length()-1-i];
        };
        System.out.println(strBuild.append(arr2));
        arr1 = toLower(arr1);
        arr2 = toLower(arr2);
        if(Arrays.equals(arr1, arr2)) {
            System.out.println("Yes that's Palindrome");
        } else{
            System.out.println("No, that is not Palindrome");
        }
    }
    public static char[] toLower(char[] arr) {
        for (int i = 0; i < arr.length; i++) {
            arr[i] = Character.toLowerCase(arr[i]);
        } 
        return arr;
    }
    public static ArrayList<Integer> changeInputStr(String str) {
        int i = 0; 
        int j = 1;
        ArrayList<Integer> listNum = new ArrayList<Integer>();
        while(i < str.length()){
            //System.out.print(i + " "+ j +"\n");
            if (i == str.length()-1){
                String y = str.substring(i);
                int z = Integer.parseInt(y);
                listNum.add(z);
                break;
            };
            char x = str.charAt(j);
             if(x == ' '){
                String y = str.substring(i,j);
                //System.out.println("Condition1: "+ y);
                int z = Integer.parseInt(y);
                listNum.add(z);
                i =j+1;
                j += 2;
            }else {
                j++;
                String y = str.substring(i,j);
                //System.out.println("Condition2: "+ y+" new j = "+j);
                int z = Integer.parseInt(y);
                listNum.add(z);
                i = j+1;
                j += 2; 
            }
        };
        return listNum;
    }
    public static ArrayList<Integer> checkSort(ArrayList<Integer> arr) {
        int len = arr.size();
        ArrayList<Integer> sorted = new ArrayList<Integer>();
        //System.out.println(len);
        int count = 0;
        while(count < len){
            int minA = arr.get(0);
            //System.out.println(minA);
            int ind = 1;
            while (ind < arr.size()){
                /*System.out.println(minA);
                System.out.println(arr.get(ind));*/
                if(minA > arr.get(ind)){
                    minA = arr.get(ind);
                    ind++;
                } else {
                    ind++;
                }
            }
            //System.out.println();
            sorted.add(minA);
            int findIN = arr.indexOf(minA);
           // System.out.println(findIN);
            arr.remove(findIN);
            count++;
        };
        return sorted;
    }
    /*private static int findMin(ArrayList<Integer> arr, int min, int j){
        if(min < arr.get(j) || j < arr.size()){
            return min;
        } else {
            return findMin(arr, arr.get(j), j++);
        }
    }*/
}
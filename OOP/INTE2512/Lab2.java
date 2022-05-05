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
        
        System.out.println("\n3. ");
        System.out.print("Enter quote to reverse: ");
        String str3 = input.nextLine();
         
    }
}
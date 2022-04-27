import java.util.Scanner;
import java.util.ArrayList;

public class Lab1 {
    public static void main(String[] agrs){
        boolean reachCondition = false; 
        Scanner myObj = new Scanner(System.in);
        while (!reachCondition) {
            System.out.print("\nEnter a positive integer: ");
            String userInput = myObj.next();
            int inputNum = Integer.parseInt(userInput);
            
            if(inputNum <= 0) {
                System.out.println("Good bye!");
                reachCondition = true;
            }
            else if(inputNum%5 == 0 && inputNum%6 == 0) {
                System.out.println(inputNum +" is divisible by both 5 and 6.");
            } else if(inputNum% 5 == 0 || inputNum%6 ==0) {
                String str = (inputNum%5 == 0) ? inputNum+" is divisible by 5." : inputNum+" is divisible by 6.";
                System.out.println(str);
            } else {
                System.out.println(inputNum+ " is neither divisible by 5 nor 6.");
            }
        }
        ArrayList<Integer> arr = new ArrayList<>();
        for(int i = 100; i <= 200; i++) {
            if(i%5 == 0 && i%6 == 0) {
                continue;
            } else if(i%5 == 0 || i%6 == 0) {
                arr.add(i);
            } else {
                continue;
            };
        };
        int count = 0;
        for(int i = 0; i < arr.size(); i++) {
            System.out.print(arr.get(i) + " ");
            count++;
            if(count == 10 || i == arr.size() -1) {
                count = 0;
                System.out.print("\n");
            };
        }
        float x = 12.232131f;
        System.out.printf("Printing a double: %f\n", x);
    }
    
}

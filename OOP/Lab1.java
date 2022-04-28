import java.util.Scanner;


import java.util.ArrayList;

public class Lab1 {
    public static void main(String[] agrs){
        System.out.println("Answer 1: Too easy => Skip!");
        System.out.println("\n Answer 2:");
        boolean reachCondition = false; 
        Scanner myObj = new Scanner(System.in);
        while (!reachCondition) {
            System.out.print("Enter a positive integer: ");
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
        System.out.println("\n Answer 3:");
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
        };
        System.out.println("\n Answer 4:");
        System.out.println("Milers      Kilometers | Kilometers     Milers");
        int countMi = 1;
        int countKi = 20;
        double miToKi = 1.609;
        while(countMi < 11){
            double a = countMi*miToKi;
            double b = countKi/miToKi;
            if(a < 10){
                System.out.printf("%d                 %.2f | %d              %.2f\n", countMi, a, countKi, b);
                countKi += 5;
                countMi++;
            } else if(a >= 10 && countMi < 10){
                System.out.printf("%d                %.2f | %d              %.2f\n", countMi, a, countKi, b);
                countKi += 5;
                countMi++;
            } else{
                System.out.printf("%d               %.2f | %d              %.2f\n", countMi, a, countKi, b);
                countKi += 5;
                countMi++;
            } 
        };
        System.out.println("\n Answer 5:");
        System.out.print("Enter number of line: ");
        int num = myObj.nextInt();
        for(int i = 1; i <= num; i++){
            for(int j = 0; j < num-i;j++) {
                System.out.print("  ");
            };
            int a = i;
            int b = 1;
            do {
                System.out.print(a+" ");
                a--;
            } while(a > 0);
            while(b < i) {
                b++;
                System.out.print(b+ " ");
            };
            System.out.println();
        };
        System.out.println("\n Answer 6:");
        System.out.print("Enter circle1's center x-, y-coordinates, and radius: ");
        double x1 = myObj.nextDouble();
        double y1 = myObj.nextDouble();
        double r1 = myObj.nextDouble();
        System.out.print("Enter circle2's center x-, y-coordinates, and radius: ");
        double x2 = myObj.nextDouble();
        double y2 = myObj.nextDouble();
        double r2 = myObj.nextDouble();
        double distance = Math.sqrt(Math.pow(Math.abs(x1-x2),2) + Math.pow(Math.abs(y1-y2), 2));
        System.out.printf("Distance between the centers: %.2f\n",distance);
        double condition1 = Math.abs(r1 - r2);
        double condition2 = r1 + r2;
        if(distance <= condition1){
            System.out.println("Circle 1 is inside Circle 2");
        } else if(distance <= condition2) {
            System.out.println("Circle 2 is overlaps Circle 1");
        } else {
            System.out.println("Circle 1 and Circle 2 are far away each other");
        };
    }
    
}

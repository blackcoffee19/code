import java.util.GregorianCalendar;
import java.util.Scanner;


public class Lap3 {
    public static void main(String[] args){
        System.out.printf("1. Year: %s \nMonth: %s\nDay: %s\n", GregorianCalendar.YEAR, GregorianCalendar.MONTH, GregorianCalendar.DAY_OF_MONTH);
        Scanner time = new Scanner(System.in);        
        System.out.print("2. Enter time for StopWatch: ");
        int inputTime = time.nextInt();
        StopWatch stopwWatch = new StopWatch(inputTime);
        stopwWatch.getElapsedTime();
        System.out.print("3.Enter 3 number present for ax^2 + bx + c = 0: ");
        double a = time.nextDouble();
        double b = time.nextDouble();
        double c = time.nextDouble();
        QuadraticEquation test3 = new QuadraticEquation(a, b, c);
        double result = test3.getDiscminant();
        System.out.printf("Result 1 of test QuadraticEquation,getDiscriminant(): %.2f\n", result);
        double root1 = test3.getRoot1();
        double root2 = test3.getRoot2();
        System.out.printf("Result 2 of test QuadraticEquation,GetRoot1(): %.2f\nResult 2 of test QuadraticEquation,GetRoot1(): %.2f\n",root1,root2);
        System.out.println("4. For ax +by = e && cx+dy = f, enter(a,b,c,d,e,f): ");
        int inputA = time.nextInt();
        int inputB = time.nextInt();
        int inputC = time.nextInt();
        int inputD = time.nextInt();
        int inputE = time.nextInt();
        int inputF = time.nextInt();
        LinearEquation le = new LinearEquation(inputA, inputB, inputC, inputD, inputE, inputF);
        if(!le.isSolvable()){
            System.out.println("The operation has no solution");

        } else {
            System.out.printf("X = %.2f\n Y = %.2f \n",le.getX(), le.getY());
        }
    }
}

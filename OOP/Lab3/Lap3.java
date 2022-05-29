import java.security.PublicKey;
import java.util.GregorianCalendar;
import java.util.Scanner;

public class Lap3 {
    public static void main(String[] args){
        System.out.printf("Year: %s \nMonth: %s\nDay: %s\n", GregorianCalendar.YEAR, GregorianCalendar.MONTH, GregorianCalendar.DAY_OF_MONTH);
        Scanner time = new Scanner(System.in);        
        System.out.print("Enter time for StopWatch: ");
        int inputTime = time.nextInt();
        StopWatch stopwWatch = new StopWatch(inputTime);
        stopwWatch.getElapsedTime();
    }
}

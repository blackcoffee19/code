import java.util.LinkedList;
import java.lang.Math;
public class PythagoreanTriplets{
    public static String findPyt(int limit) {
        LinkedList<LinkedList<Integer>> arr = new LinkedList<LinkedList<Integer>>();
        for(int i= 1; i <= limit; i++){
            for(int j=i+1; j <= limit; j++) {
                for(int k = j+1; k<= limit; k++) {
                    
                    int x = i*i + j*j;
                    double xx = Math.sqrt(x); 
                    
                    if (k == xx) {
                        //System.out.println(i+"^2 = "+i*i);
                        //System.out.println(j+"^2 = "+j*j);
                        //System.out.println("log "+x +" = "+ xx);
                        LinkedList<Integer> newA = new LinkedList<Integer>();
                       newA.add(i);
                       newA.add(j);
                       newA.add(k);
                       arr.add(newA); 
                       //System.out.println(String.valueOf(arr));
                       //System.out.println();
                    };
                }
            }
        }
        return String.valueOf(arr);
    }

    public static void main(String[] args) {
        String aStri = findPyt(100);
        System.out.println(aStri);
    }

}
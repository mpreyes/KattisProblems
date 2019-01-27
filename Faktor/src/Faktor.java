/**
 * Created by madelynreyes on 5/23/17.
 */
import java.math.*;
import java.util.*;
public class Faktor {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int A = sc.nextInt(); //number of articles
        int I = sc.nextInt(); //impact factor
        // I = C / A
        double answer = Math.ceil((I * A)- A);
        System.out.println((int)answer+ 1);



    }
}

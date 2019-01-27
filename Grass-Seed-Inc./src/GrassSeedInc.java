/**
 * Created by madelynreyes on 5/23/17.
 */
import java.util.*;
import java.math.*;
public class GrassSeedInc {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        double C = sc.nextDouble(); //cost
        int L = sc.nextInt(); //number of lawns
        double answer  = 0;

        for(int i =0; i < L; i++){

            double w = sc.nextDouble();
            double l = sc.nextDouble();
            double dim  = (w * l);
            answer += dim * C;

        }
        System.out.println(answer);


    }
}

/**
 * Created by madelynreyes on 5/23/17.
 */
import java.util.*;

public class mixedfractions {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int numerator = sc.nextInt();
        int denominator = sc.nextInt();


        while(numerator != 0 && denominator != 0){
                int div = numerator / denominator;
                int rem = numerator % denominator;
                System.out.println(div + " " + rem + " / " + denominator);
                numerator = sc.nextInt();
                denominator = sc.nextInt();


        }




    }
}

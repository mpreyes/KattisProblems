/**
 * Created by madelynreyes on 5/23/17.
 */
import java.util.*;
import java.math.*;

public class onechicken {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int N = sc.nextInt(); //number of people at the buffet
        int M = sc.nextInt(); //pieces of chicken
        int leftOver = M-N;
        int needed = N-M;


        if(M > N){ //if the pieces of chicken is greater than people eating
            if (leftOver == 1) {
                System.out.println("Dr. Chaz will have "+ leftOver+ " piece of chicken left over!");
            }
            else {
                System.out.println("Dr. Chaz will have " + leftOver + " pieces of chicken left over!");
            }

        }
        else{
            if(needed == 1){ // I forgot the period in Dr. and kept getting it wrong
                System.out.println("Dr. Chaz needs " + needed + " more piece of chicken!");
            }
            else {
                System.out.println("Dr. Chaz needs " + needed + " more pieces of chicken!");
            }
        }

    }
}

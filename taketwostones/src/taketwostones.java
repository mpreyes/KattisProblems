/**
 * Created by madelynreyes on 5/5/17.
 */
import java.util.*;
public class taketwostones {

    public static void main(String[] args) {
       Scanner sc = new Scanner(System.in);
       int n = sc.nextInt();

       //alice goes first
        //bob goes second
        //each take two stones


        if(n % 2 == 0) {
            System.out.print("Bob"); //if its even, bob wins
        }
        else {
            System.out.print("Alice"); //if its odd, alice wins
        }



    }
}

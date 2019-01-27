/**
 * Created by madelynreyes on 5/6/17.
 */
import java.util.*;

public class leftbeehind {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        //int sweet = -1;
        //int sour = -1;


        for(int i =0; i<15;i++) {
             int sweet = sc.nextInt(); //int x
             int sour = sc.nextInt(); //int y
            if (sweet == 0 && sour ==0) {
                break;
            }
                else if (sweet + sour == 13) {
                    System.out.println("Never speak again.");
                } else if (sweet == sour) {
                    System.out.println("Undecided.");

                } else if (sour > sweet) {
                    System.out.println("Left beehind.");
                } else {
                    System.out.println("To the convention.");
                }
            }




    }
}

/**
 * Created by madelynreyes on 5/23/17.
 */
import java.util.*;
import java.math.*;

public class sibice  {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int matches = sc.nextInt(); //number of matches
        int width = sc.nextInt(); //width of matches
        int height = sc.nextInt(); //height of matches

        double wsqrd = Math.pow(width,2);
        double hsqrd = Math.pow(height,2);
        int acceptable =(int) Math.sqrt(wsqrd + hsqrd);


      for(int i =0; i < matches; i++) {
          if (sc.nextInt() <= acceptable) {
              System.out.println("DA");
          } else {
              System.out.println("NE");
          }
      }



    }
}

/**
 * Created by madelynreyes on 5/25/17.
 */
import java.util.*;
public class Filip {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String [] l = sc.nextLine().split(" ");
        String j = "";
        String k = "";
        //System.out.println(l[0]);
       // System.out.println(l[1]);
        for(int i = 2; i > -1; i--){
            j += l[0].charAt(i);
            k += l[1].charAt(i);

        }
        int J = Integer.parseInt(j);
        int K = Integer.parseInt(k);

       // System.out.println(J);
       // System.out.println(K);
        System.out.println(getMax(J,K));

    }

    public static int getMax(int a, int b){
        if(a >= b){
            return a;
        }
        else{
            return b;
        }
    }

}

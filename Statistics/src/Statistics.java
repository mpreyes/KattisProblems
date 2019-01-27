/**
 * Created by madelynreyes on 5/24/17.
 */
import java.util.*;
import java.math.*;
public class Statistics {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int g = 1;

        while (sc.hasNext()) {
            String c[] = sc.nextLine().split(" ");
            int p[] = new int[c.length - 1];
            for (int i = 0; i < c.length - 1; i++) {
                p[i] = Integer.parseInt(c[i + 1]); //haha need to ignore the first element

            }
            int max = p[0];
            int min = p[0];
            for (int j = 0; j < p.length; j++) {
                max = getMax(max, p[j]);
                min = getMin(min, p[j]);

            }
            System.out.println("Case " + g + ": " + min + " " + max + " " + (max - min));
            g++;

        }
    }

    public static int getMax(int a,int b) { //beautiful methods made by moi
        if (a >= b) {
            return a;
        }
        else {
            return b;
        }

    }

    public static int getMin(int a, int b){
        if(a <= b){
            return a;
        }
        else{
            return b;
        }
    }


}



/**
 * Created by madelynreyes on 5/23/17.
 */
import java.util.*;

public class Tarifa {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int X = sc.nextInt(); //how many megabytes allowed per month
        int N = sc.nextInt();
        int addedM = 0;


        for(int i =0; i < N; i++){
            addedM += X - sc.nextInt();

        }

        System.out.println(addedM+X);



    }

}

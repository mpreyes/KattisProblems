/**
 * Created by madelynreyes on 5/24/17.
 */
import java.util.*;
public class SpeedLimit {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int N = sc.nextInt();

        while( N != -1){

            int [] speed = new int [N]; //speed in mph
            int [] time = new int [N];  //elapsed time in hours
            int result = 0;

            for(int i =0; i < N; i++){ //number of lines
                speed[i] = sc.nextInt();
                time[i] = sc.nextInt();
            }
            for(int j =speed.length-1; j > 0;j--){

              result += (time[j] - time[j-1]) * speed[j];


            }
            result +=  (time[0]) * speed[0];
            System.out.println(result + " miles");
            N = sc.nextInt();
        }
    }



}

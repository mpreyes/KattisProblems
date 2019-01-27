/**
 * Created by madelynreyes on 5/23/17.
 */
import java.util.*;

public class quickestimates {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int N = sc.nextInt();
        String l = sc.nextLine();
        String arr [] = new String [N];
        //System.out.println(arr.length);
        for(int i =0; i < N; i++) {
            arr[i] = sc.nextLine();

        }
        for(int i =0; i < arr.length;i++){
            System.out.println(arr[i].length());
            //System.out.println(arr[i]);
        }



    }
}

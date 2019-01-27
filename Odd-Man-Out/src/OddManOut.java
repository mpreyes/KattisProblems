/**
 * Created by madelynreyes on 5/24/17.
 */
import java.util.*;

public class OddManOut {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int N = sc.nextInt(); // test cases

        for(int i =1; i < N+1; i++) {
            int G = sc.nextInt(); // guests
            ArrayList<Integer> l = new ArrayList<Integer>();

            for(int j =0; j < G; j++){
                l.add(sc.nextInt());
            }
            Collections.sort(l);
           // System.out.println(l);

            int k = 0;
            while(k < l.size()-1 ){
                if(l.get(k).equals(l.get(k+1))){
                    l.remove(k);
                    l.remove(k);

                    k = Math.max(0, (k - 1));

                }
                else{
                    k++;
                }
            }
            System.out.println("Case #"+ i +": "+ l.get(0));


        }



        }


}

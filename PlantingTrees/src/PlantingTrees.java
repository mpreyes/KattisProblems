/**
 * Created by madelynreyes on 11/19/17.
 */

import java.util.*;
import java.math.*;
public class PlantingTrees {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt(); //number of seedlings
        Integer [] input = new Integer[n];
        for(int i=0; i < n; i++){
            input[i] = sc.nextInt();
        }
        PlantingTrees t1 = new PlantingTrees();
        int answer = t1.partyTime(n, input);
        System.out.println(answer);

    }

    int partyTime(int n, Integer [] input){
        Arrays.sort(input, Collections.reverseOrder());

        int [] output = new int [n];
        for(int i=0; i < input.length;i++){
            output[i] = input[i] + i+1;
        }
        int hold = output[0];
       for(int i=1; i < output.length;i++){ //getting the max number
           if(hold < output[i]) {
               hold = output[i];
           }
       }
      // System.out.println(hold+1);
        return hold + 1;
    }




}

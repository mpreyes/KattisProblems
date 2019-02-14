/**
 * Created by madelynreyes on 1/17/18.
 */
import java.util.*;
class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Map<Character,Integer> dictionary = new HashMap<Character, Integer>();
        dictionary.put('a',1); dictionary.put('d',1); dictionary.put('g',1); dictionary.put('j',1);
        dictionary.put('m',1); dictionary.put('p',1); dictionary.put('t',1); dictionary.put('w',1);
        dictionary.put(' ',1);

        dictionary.put('b',2); dictionary.put('e',2); dictionary.put('h',2); dictionary.put('k',2);
        dictionary.put('n',2); dictionary.put('q',2); dictionary.put('u',2); dictionary.put('x',2);

        dictionary.put('c',3); dictionary.put('f',3); dictionary.put('i',3); dictionary.put('l',3);
        dictionary.put('o',3); dictionary.put('r',3); dictionary.put('v',3); dictionary.put('y',3);

        dictionary.put('s',4); dictionary.put('z',4);



        int T = Integer.parseInt(sc.nextLine());
        int keyPresses = 0;



        for(int i=0; i < T; i++){
            String line = sc.nextLine();
            for (char c: line.toCharArray()) {

                if(dictionary.containsKey(c)){
                    keyPresses += dictionary.get(c);
                }
            }

            System.out.println("Case #" + (i+1) + ": " + keyPresses);
            keyPresses = 0;

        }



    }
}

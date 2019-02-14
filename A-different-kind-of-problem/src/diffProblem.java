/**
 * Created by madelynreyes on 1/8/18.
 */

import javax.swing.plaf.basic.BasicInternalFrameTitlePane;
import java.util.*;
public class diffProblem {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        while(sc.hasNextLine()) {
            String line = sc.nextLine();
            int nums [] = new int [2];

            String splitNums [] = line.split(" ");

            long A = Long.parseLong(splitNums[0]);
            long B = Long.parseLong(splitNums[1]);

            System.out.println(Math.abs(A - B));
        }




    }
}

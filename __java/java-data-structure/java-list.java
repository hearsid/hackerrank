import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static LinkedList<Integer> doOp(LinkedList<Integer> vals, String op, String locationVal) {
        if(op.equals("Insert")) {
            String[] locVal = locationVal.split(" ");
            int loc = Integer.parseInt(locVal[0]);
            int val = Integer.parseInt(locVal[1]);
            vals.add(loc, val);
        }
        
        if(op.equals("Delete")) {
          vals.remove(Integer.parseInt(locationVal));
        }
            return vals;
    }
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int N = sc.nextInt();
          LinkedList<Integer> list = new LinkedList<>();
        for (int i = 0; i<N; i++) {
            int value = sc.nextInt();
            list.add(value);
        }
        int queries = sc.nextInt();
                    sc.nextLine();

        for(int i = 0; i<queries; i++) {
            String op = sc.nextLine();
            String locVal = sc.nextLine();
            list = doOp(list, op, locVal );
        }
        
          sc.close();
        
        for (Integer num : list) {
            System.out.print(num + " ");
        }
    }
    
    

}

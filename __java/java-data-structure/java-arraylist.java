import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

      public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int totalInputs = sc.nextInt();
        ArrayList<String> inputs = new ArrayList<String>();
        for(int i=0; i<totalInputs+1; i++) {
            String input = sc.nextLine();
            if(!input.isEmpty())
             inputs.add(input);
        }
        int queries = sc.nextInt();
        for(int j=0; j<queries; j++) {
            int line= sc.nextInt();
            int location =sc.nextInt();
            try {
                String str = inputs.get(line-1).split(" ")[location];
                System.out.println(str);
            } catch(Exception e) {
                System.out.println("ERROR!");
            }

        }
    }
}

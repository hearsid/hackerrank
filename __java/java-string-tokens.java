import java.io.*;
import java.util.*;
import java.util.regex.Pattern;
import java.util.regex.Matcher;

public class Solution {

    public static final String REGEXP= "[A-Za-z]";
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String s = scan.nextLine();
        // Write your code here.
        scan.close();
        String[] ss = s.split("[^A-Za-z]");
        System.out.println(ss.length-1);
        for(String sss: ss) {
            if (!sss.isEmpty())
                System.out.println(sss);
        }
    }
}



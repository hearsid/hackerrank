import java.util.*;
import java.io.*;

class Solution{
    
            static Integer equation(int a,int b,int n) {
        int result = a;
        for(int j=0; j<n; j++) {
            result += Math.pow(2, j)*b;
        }
        return result;
    }
    static String getSequence(int a, int b, int n) {
        String seq="";
        for(int i=1; i<n+1; i++) {
            seq= seq+" "+equation(a,b,i);
        }
        return seq.trim();
    }
    public static void main(String []argh){
        Scanner in = new Scanner(System.in);
        int t=in.nextInt();
        for(int i=0;i<t;i++){
            int a = in.nextInt();
            int b = in.nextInt();
            int n = in.nextInt();
            String result = getSequence(a,b,n);
            System.out.println(result);
        }

        in.close();
    }
}

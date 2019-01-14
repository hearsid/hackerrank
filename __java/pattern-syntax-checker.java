import java.util.Scanner;
import java.util.regex.*;

public class Solution
{
    
    public static boolean isPatternValid(String pattern) {
        try {
            Pattern p = Pattern.compile(pattern);
            return true;
        } catch (PatternSyntaxException e) {
            return false;
        }
    }
	public static void main(String[] args){
		Scanner in = new Scanner(System.in);
		int testCases = Integer.parseInt(in.nextLine());
		while(testCases>0){
			String pattern = in.nextLine();
          	System.out.println(isPatternValid(pattern)?"Valid": "Invalid");
		}
	}
}





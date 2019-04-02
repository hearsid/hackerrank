import java.util.*;

class Student{
	private int id;
	private String fname;
	private double cgpa;
	public Student(int id, String fname, double cgpa) {
		super();
		this.id = id;
		this.fname = fname;
		this.cgpa = cgpa;
	}
	public int getId() {
		return id;
	}
	public String getFname() {
		return fname;
	}
	public double getCgpa() {
		return cgpa;
	}
}

class SortStudents implements Comparator<Student> {
    public int compare(Student s1, Student s2) {
        if(s1.getCgpa() == s2.getCgpa()){
            return s1.getFname().compareTo(s2.getFname());
        }
        double result = s1.getCgpa() - s2.getCgpa();
        if(result > 0) return -1;
        if(result < 0) return 1;
        return 0;
    }
}

//Complete the code
public class Solution
{
	public static void main(String[] args){
		Scanner in = new Scanner(System.in);
		int testCases = Integer.parseInt(in.nextLine());
		
		List<Student> studentList = new ArrayList<Student>();
		while(testCases>0){
			int id = in.nextInt();
			String fname = in.next();
			double cgpa = in.nextDouble();
			
			Student st = new Student(id, fname, cgpa);
			studentList.add(st);
			
			testCases--;
		}
        
        Collections.sort(studentList, new SortStudents()); 
      	for(Student st: studentList){
			System.out.println(st.getFname());
		}
	}
}





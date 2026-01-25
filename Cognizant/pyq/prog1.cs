class Student
{
    int rollNo;
    String name;
    int [] marks=new int[3];

    public Student(int rollNo,String name,int marks)
    {
        this.rollNo=rollNo;
        this.name=name;
        this.marks[0]=marks;
    }

    static void calculateAverageGrade(int[]marks)
    {
        int sum=0;
        for(int i=0;i<marks.Length;i++)
        {
            sum+=marks[i];
        }
        double average=sum/marks.Length;
        if(average>=90)
        {
            Console.WriteLine("Grade A");
        }
        else if(average>=80)
        {
            Console.WriteLine("Grade B");
        }
        else if(average>=70)
        {
            Console.WriteLine("Grade C");
        }
        else
        {
            Console.WriteLine("Grade F");
        }
    }

    static void Main(String[]args)
    {
        Student student1=new Student(1,"Alice",85);
        Student student2=new Student(2,"Bob",90);

        Console.WriteLine($"Student 1: {student1.name}, Roll No: {student1.rollNo}, Marks: {student1.marks[0]}");
        Console.WriteLine($"Student 2: {student2.name}, Roll No: {student2.rollNo}, Marks: {student2.marks[0]}");

        calculateAverageGrade(student1.marks);
        calculateAverageGrade(student2.marks);
    }
}


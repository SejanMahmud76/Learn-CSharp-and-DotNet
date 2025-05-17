using System;
class Test{
    public static void Main(string[] args){

        string StudentName;
        int StudentAge; 
        double StudentCgpa;   

        Console.WriteLine("Enter your Name");
        StudentName = Console.ReadLine();

        Console.WriteLine("Enter your Age");
        StudentAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your CGPA");
        StudentCgpa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nmae:" + StudentName);
        Console.WriteLine("Age:" + StudentAge +"years old");
        Console.WriteLine("CGPA:" + StudentCgpa );
        



    }
}
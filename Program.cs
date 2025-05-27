using System;


class Person
{
    public string Name;
    public int Age;

    public void DisplayInfo()
    {
        Console.WriteLine($"Nmae of person  is {Name} &  Age :{Age}\n");

    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;


    }
}


class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new Person("Rakibul Hasan ", 28);
       
        p1.DisplayInfo();

        Person p2 = new Person("Rubayet Hasan ", 28);
      
        p2.DisplayInfo();
    }

}
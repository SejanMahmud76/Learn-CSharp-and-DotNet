using System;


class Person
{
    public string Name;
    public int Age;

    public void DisplayInfo()
    {
        Console.WriteLine($"Nmae of person  is {Name} &  Age :{Age}\n");

    }

    public void SetInfo(string name, int age)
    {
        Name = name;
        Age = age;


    }
}


class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.SetInfo("Rakibul Hasan ", 28);
        p1.DisplayInfo();

        Person p2 = new Person();
        p2.SetInfo("Rubayet Hasan ", 28);
        p2.DisplayInfo();
    }

}
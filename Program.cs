using System;


class Person
{
    public string Name;
    public int Age;

    public void DisplayInfo()
    {
        Console.WriteLine($"Nmae of person  is {Name} &  Age :{Age}\n");

    }
}


class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.Name = "Rakibul Hasan Sezan";
        p1.Age = 28;
        p1.DisplayInfo();

        Person p2 = new Person();
        p2.Name = "Sinthiya Tabachoum";
        p2.Age = 24;
        p2.DisplayInfo();
    }

}
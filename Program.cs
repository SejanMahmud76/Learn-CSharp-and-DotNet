using System;


class Person
{
    public string Name;
    public int Age;
}


class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.Name = "Rakibul Hasan Sezan";
        p1.Age = 28;
        Console.WriteLine($"Nmae of person 1 is {p1.Name} &  Age :{p1.Age}\n");


        Person p2 = new Person();
        p2.Name = "Sinthiya Tabachoum";
        p2.Age = 24;
        Console.WriteLine($"Nmae of person 2 is {p2.Name} &  Age :{p2.Age}\n");
    }




}
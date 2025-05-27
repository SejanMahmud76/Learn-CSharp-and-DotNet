using System;



class Person()
{

    public string Name;
    private int Age;

    public void DisplayInfo()
    {
        Console.WriteLine($"Nmae:{Name} & Age: {Age}");


    }

    public void SetAge(int age)
    {

        Age = age;
    }

    

}




class test()
{

    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.Name = "SEZAN";
        p1.SetAge (28);
        p1.DisplayInfo();

        Person p2 = new Person();
        p2.Name = "SINTHIYA";
        p2.SetAge(36);
        p2.DisplayInfo();



    }

}
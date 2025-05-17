# Learn-CSharp-and-DotNet

## Necessary Commands

### To check whether .NET is installed on your system
```
    dotnet --info
```
### clone the project from the GitHub 
```
    git clone https://github.com/SejanMahmud76/Learn-CSharp-and-DotNet.git
```

### navigate to that folder and open it in Visual Studio Code
```
    cd "C:\Users\sejan\Downloads\.net\Learn-CSharp-and-DotNet"
    code .
```

# Tutorial: 4
```
class Test {
    public static void Main(string[] args) {
        System.Console.WriteLine(123);
        System.Console.WriteLine("Anisul Islam");
    }
}
```
#### 1. class Test { ... }

class: This keyword is used to declare a class. In object-oriented programming (which C# is), a class is like a blueprint or a template for creating objects. Think of it like a cookie cutter. The class defines the shape and properties of the cookie, but the actual cookies are the objects.
Test: This is the name you've given to your class. Class names in C# typically start with an uppercase letter and follow a PascalCase convention (where the first letter of each word is capitalized). You can choose almost any name, but it's a good practice to make it descriptive of what the class represents.
{ ... }: These curly braces define the body of the Test class. Everything inside these braces belongs to this class.
In essence, class Test { ... } creates a container named Test that can hold data and actions (methods).

#### 2. public static void Main(string[] args) { ... }

This line declares the Main method, which is the entry point of your C# program. When you run this code, the computer starts executing the instructions inside this Main method. Let's break it down further:

public: This is an access modifier. It specifies the visibility of the Main method. public means that this method can be accessed from anywhere in your program or even from other programs.
static: This keyword indicates that the Main method belongs to the Test class itself, rather than to a specific instance (object) of the Test class. You can call the Main method directly using the class name (e.g., Test.Main(...)) without needing to create an object of the Test class first. For the entry point of a program, static is essential.
void: This specifies the return type of the Main method. void means that this method does not return any value after it finishes executing. It just performs its actions and then ends.
Main: This is a special name for the entry point method in C# applications. The C# compiler and the .NET runtime environment know to look for a method named Main to start the program's execution.
(string[] args): These are the parameters of the Main method.
string[]: This declares an array of strings. An array is a collection of elements of the same type. In this case, it's an array of strings.
args: This is the name of the parameter. It's a common convention to name this parameter args. This parameter is used to receive any command-line arguments that might be passed to your program when it's executed. For example, if you run your program from a command prompt like myprogram.exe hello world, the args array would contain two elements: "hello" and "world". In this simple example, we're not actually using these arguments.
{ ... }: These curly braces define the body of the Main method. The instructions inside these braces are the ones that will be executed when the program runs.
In summary, public static void Main(string[] args) { ... } defines the starting point of your program, which is accessible from anywhere, doesn't return any value, and can potentially receive command-line arguments.

#### 3. System.Console.WriteLine(123);

This line of code does the job of displaying the number 123 on the console (your computer screen's output). Let's break it down:

System: This is a namespace. In C#, namespaces are used to organize related classes and other types. System is a fundamental namespace that contains many core classes.
Console: This is a class within the System namespace. The Console class provides methods for interacting with the console, such as reading input from the user and writing output to the screen.
. (dot operator): This is used to access members (like classes, methods, properties, etc.) within a namespace or an object. Here, we're accessing the Console class within the System namespace.
WriteLine(): This is a method of the Console class. A method is a block of code that performs a specific action. The WriteLine() method writes the specified value to the console, followed by a new line.
(123): These are the arguments being passed to the WriteLine() method. In this case, we're passing the integer value 123. The WriteLine() method takes this value and displays it on the console.
So, System.Console.WriteLine(123); tells the computer to display the number 123 on the console and then move the cursor to the next line.

#### 4. System.Console.WriteLine("Anisul Islam");

This line is very similar to the previous one, but instead of displaying a number, it displays a piece of text.

"Anisul Islam": This is a string literal. In C#, text values are enclosed in double quotes ("). The WriteLine() method takes this string as an argument and displays it on the console.
Therefore, System.Console.WriteLine("Anisul Islam"); instructs the computer to display the text "Anisul Islam" on the console, followed by a new line.

#### In summary, this entire program does the following:

It defines a class named Test.
Inside the Test class, it defines the main entry point of the program, the Main method.
The Main method contains two instructions:
Display the number 123 on the console.
Display the text "Anisul Islam" on the console on the next line.
When you compile and run this C# code, you will see the following output on your console:
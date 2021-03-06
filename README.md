# C# Learning <!-- omit in toc -->

- [About this repository](#about-this-repository)
- [**General**](#general)
- [Lessons Learned](#lessons-learned)
  
## About this repository
* Main goals of this repository:
  * To learn the basics of C#

## **General**
* This repository was built using C# couple with [.NET](https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/)
  * .NET is a virtual execution system called the common language runtime (CLR) and a unified set of class libraries
  
* Different Pieces throughout the repository:
  * basics --> This houses the very first code I wrote while learning C#. Specifically, learned how to output "Hello World" in the console using the WriteLine built in C# method.
  * ConsoleCreations --> This dives a little more into strings and escaping different characters in C#.
  * Variables --> Folder for learning about variables. Found out here that I variables must house data of the same type they were declared.
  * Numbers --> Folder for learning about numbers and how to manipulate them in C#.
  * Calculator --> Expanding on numbers learning, learned how to get user input using the ReadLine built in method.
  * Madlib --> Expanded on both my understanding of user inputs and string manipulation. Learned an alternate to perform string concatenation using the $"{}" syntax.
  * Arrays --> How to create an array and access elements in an array in C#.
  * Methods --> How to create methods (functions) in C#. How to define their parameters, also can give these default values.
  * IfStatments --> if, else if, else syntax in C#. Also explored comparison operators in C# and even dabbled into ternary statements in C#. 
  * SwitchStatements --> Explores the switchStatment syntax for C#. Very similar to JavaScript!
  * PasswordChecker --> Practices switchStatement as well as exploring how to use Regular Expressions in C#;
  * MethodOverloading --> Explores a new concept called method overloading. Essentially its a functions with the same names that have either differing parameters or differing parameter types...See the lessons learned section if you are interested

## Lessons Learned
* C# is a statically-typed language, meaning that it checks data types before the program is run.
* C# is a type-safe programming language, which I am not used to. Essentially it means you have to do a little more planning when assigning/declaring/initializing variables.
  > In computer science, type safety is the extent to which a programming language discourages or prevents type errors.
  > - [Wikipedia](https://en.wikipedia.org/wiki/Type_safety)

* When creating an empty array in C# you still need to specify the length of the array. Here is an example below.
```C#
string [] friends = new string[5]; //Here we create an empty array of strings with a length 5
```

* When creating a method (or a function) in C#, you have to define the data type for each parameter. See the example below:
```C#
//This creates a method called SayHi which has a return type of void (i.e. it wont return anything)
//It has two arguments, the first is named user it has a type of string and a default value of "Default"
//Second, it has an argument name age, a type of integer and a default value of 26
static void SayHi(string User = "Default", int age = 26) 
{
    Console.WriteLine($"Hello {User}, you are {age}");
}
```

* If we want to return data from a function in C#, we need to initialize the function with that data's return type. See below:
```C#
//This tells C# that we want to return an array of strings from this function that we named Friends.
//Also note that we are receiving an argument with that same data type as the only argument for this function.
static string[] friends(string[] friendsArray)
{
    friendsArray[0] = "Chandler";
    return friendsArray;
}
```

* Named arguments
  * C# has a way to distinguish between what argument you would like to specify for a method. See below for an example:
```C#
static void Main(string[] args)
{
  //If we just want to specify one of the parameters we can do that my using its name
  someMethod(d: 20); 
}

static void someMethod(int a = 0; int b = 0; int c = 0; int d = 0)
{
  Console.WriteLine($"a --> {a} b --> {b} c --> {c} d --> {d}");
}
```

* Method overloading
  * Each version of a method that has a either different parameters or different parameter types is called an overload...check out the picture below
![Overloading](MethodOverloading.png)

* Out Parameter
  * Although methods can only return one value, we can sometimes still get two pieces of information from them. 
  * The method below (Int32.TryPare() method) tries to parse its input as an integer.
    * If it can:
      * Returns true and sets a variable to the new Int Value.
    * If it can't:
      * Returns false and sets a variable to null.
```C#
string ageAsString = "45";
bool outcome = Int32.TryParse(ageAsString, out int ageAsInt);
Console.WriteLine(ageAsInt + " " + outcome); //Outputs "true 45" to the console.
```
  * Here is an example of how to create your own method that uses an Out Parameter
```C#
  static void Main(string[] args)
  {
      string whisperText = Whisper("YELLING", out bool outcome);
      Console.WriteLine(whisperText + " " + outcome); //Outputs "yelling true" to the console.
  }

  static string Whisper(string phrase, out bool didWhisper)
  {
      didWhisper = true;
      return phrase.ToLower();
  }
```
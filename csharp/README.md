# [Mosh Hamedani](https://programmingwithmosh.com/)'s C# Courses

A repository aimed to store the code and the notes generated from the lessons of the courses

I will not make a detailed dive into Object Oriented Programming, because this has already been discussed in my [learning Java repository](https://github.com/gagibran/learning-java).

Refer to that [README.md](https://github.com/gagibran/learning-java/blob/dev/README.md) to know more about OOP.

I will only list the main differences between C# and Java.

The courses are:

1. [C# Basics for Beginners: Learn C# Fundamentals by Coding](https://www.udemy.com/course/csharp-tutorial-for-beginners/);
2. [C# Intermediate: Classes, Interfaces and OOP](https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/);
3. [C# Advanced Topics: Prepare for Technical Interviews](https://www.udemy.com/course/csharp-advanced/);
4. [Unit Testing for C# Developers](https://www.udemy.com/course/unit-testing-csharp/).

I will also include some exercises that I see fit from these courses. All of them made using .NET Core 5.

## Table of contents

- [C# naming conventions](#c-naming-conventions)
- [Namespaces](#namespaces)
- [Data types](#data-types)
- [Casting characters to integers](#casting-characters-to-integers)
- [Strings](#strings)
- [Converting types](#converting-types)
- [Structs](#structs)
- [Enums](#enums)
- [Reference types and value types](#reference-types-and-value-types)
- [Random number](#random-number)
- [Returning in void](#returning-in-void)
- [Parsing arguments to methods](#parsing-arguments-to-methods)
- [Access modifiers](#access-modifiers)
- [Arrays](#arrays)
- [Lists](#lists)
- [Working with dates](#working-with-dates)
- [Working with text](#working-with-text)
- [Default or optional arguments](#default-or-optional-arguments)
- [Working with files](#working-with-files)
- [Calling a constructor from a overloaded one](#calling-a-constructor-from-a-overloaded-one)
- [Parameter modifiers](#parameter-modifiers)
    - [Params](#params)
    - [Ref](#ref)
    - [Out](#out)
- [Read-only fields](#read-only-fields)
- [Properties](#properties)
- [Indexers](#indexers)
- [Class coupling](#class-coupling)
- [Inheritance](#inheritance)
- [Composition](#composition)
- [Upcasting and downcasting](#upcasting-and-downcasting)
- [Boxing and unboxing](#boxing-and-unboxing)
- [Method overriding](#method-overriding)
- [Abstract classes and members](#abstract-classes-and-members)
- [Sealed classes and members](#sealed-classes-and-members)
- [Interfaces](#interfaces)
- [Attributes](#attributes)
- [Generics](#generics)
- [Delegates](#delegates)
- [Lambda expressions](#lambda-expressions)
- [Events](#events)
- [Extension methods](#extension-methods)
- [LINQ](#LINQ)
- [Nullable types](#nullable-types)
- [Dynamic](#dynamic)
- [Exception handling](#exception-handling)
- [Asynchronous programming](#asynchronous-programming)
- [Unit testing](#unit-testing)
    - [Unit Test Project](#unit-test-project)

## C# naming conventions

[Here](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines) is Microsoft's official naming convention for the C# language.

[Here](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions) is Microsoft's official coding convention.

[Here](https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md) is a repository from [Konstantin Taranov](https://github.com/ktaranov) that condenses all of the conventions.

[Namespaces](#namespaces), classes, [properties](#properties), methods, and fields are declared in PascalCase.

Local variables, parameters, and constants use camelCase.

Private fields use camelCase prefixed with an underscore. Example: `private string _customerName;`

The [var](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/var) keyword, or **implicit typing**, should be used when the data type in a variable declaration is obvious.

## Namespaces

They are containers for related classes:

```cs
namespace HelloWorld
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Hello, world.");
        }
    }
}
```

We can import namespaces by using the keyword `using` at the beginning of our program. For example:

```cs
using System;
```

## Data types

They behave just like Java, but each data type is a struct mapped to the .NET primitives.

Here is the [official documentation](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types) with all primitive types and their ranges.

They all belong to the `System` namespace.

The most used ones:
- `byte` maps to `System.Byte` and occupies 1 byte;
- `short` maps to `System.Int16` and occupies 2 bytes;
- `int` maps to `System.Int32` and occupies 4 bytes;
- `long` maps to `System.Int64` and occupies 8 bytes;
- `float` maps to `System.Single` and occupies 4 bytes;
- `double` maps to `System.Double` and occupies 8 bytes;
- `decimal` maps to `System.Decimal` and occupies 16 bytes;
- `char` maps to `System.Char` and occupies 2 bytes;
- `bool` maps to `System.Boolean` and occupies 1 byte.

Thus, an `int`, for example, can be declared as `System.Int32 number = 2;`.

Floats and decimals required that we use the keyword `f` and `m`, respectively, in order to not use the system's default, which is `double`.

Decimals have a higher range, so they're more precise than doubles.

The maximum and minimum values of each data type can be checked by accessing their constant variables in each struct, which is `MinValue` and `MaxValue`.

Another difference is that we can user the keyword `var` to create a variable implicitly in the body of a method, instead of explicitly declaring their data type, and the compiler will be able to assign the correct data type and allocate the necessary amount of memory to it. But, we have to keep in mind that `var number = 2;` won't default to `byte` or `short`, but it will default to `int`, unless the number is to big or too small to fit into it. Same with floating numbers, it defaults to `double`.

To create a constant value, we use the `const` keyword. Constants use the PascalCase instead of SCREAMING_CAPS.

## Strings

They're also mapped to a class in the `System` namespace, the `String` class.

They're immutable, meaning that they cannot be changed once declared.

They have an overloaded constructor that builds a string from a character times an amount:

```cs
new string('-', 10); // Builds: "----------".
```

We can iterate though a string by indexing it:

```cs
string name = "Gabriel";
Console.WriteLine(name[0]);
// name[1] = b; // This won't compile.
```

Which prints:

```
G
```

We can use string concatenation, but we can also use the static `Format()` method from the `String` class:

```cs
int a = 1;
bool b = true;
string s = string.Format("a is {0} and b is {1}.", a, b);
Console.WriteLine(s);

```
Which prints:

```
a is 1 and b is true.
```

We see here that the place holders inside the curly braces are 0-indexed.

We don't actually need to use the `Format()` when passing strings to `Console.Write()` or `Console.WriteLine()`. We can straight up pass the string and the arguments there:

```cs
int number = 2;
Console.WriteLine("Number: {0}.", number);
```

This prints:

```
Number: 2.
```

We can also use [string interpolation](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated) to pass variables directly into strings. We use the dollar sign (`$`) to achieve this:

```cs
int a = 2;
int b = 342;
int c = 2786;
Console.WriteLine($"a is {a}, b is {b}, and c is {c}.");
```

This prints:

```
a is 2, b is 342, and c is 2786.
```

We can also join elements from an array or list using the `Join()` method, also in the `String` class:

```cs
int[] a = new int[3] { 1, 2, 3, 4 };
string s = string.Join(",", a);
Console.WriteLine(s);
```

Which prints `a`'s elements joined by a comma:

```
1,2,3,4
```

We also have the `Split()` method, which returns an array of elements separated by the argument passed into the method, of the original string:

```cs
using System;

static void GetMax()
    {
        Console.WriteLine("Enter numbers separated by comma:");
        string[] numbersStr = Console.ReadLine().Split(",");
        int currentMax = int.MinValue;
        foreach (string numberStr in numbersStr)
        {
            int number = int.Parse(numberStr);
            if (number > currentMax)
            {
                currentMax = number;
            }
        }
        Console.WriteLine("Max number: {0}.", currentMax);
    }
```

There's also a special type of string called **verbatim strings**, which are the pure strings, without the use of special or escape characters. For example: `string s = "\n";` jumps a line and in `string a = "variable\\holding\\a\\path";` we have to escape the backslash in order to use it.

We can simply append a `@` sign at the beginning of our string to use the escape character literally: `string s = @"\n";` equals `\n` literally. The path variable can now be declared as `string a = @"variable\holding\a\path";`. We can even type `Enter` to physically input a new line in the string, instead of using `\n`.

We can get input from the user by using `Console.ReadLine()`, which gets the input and converts it into a string. Thus, we have to assign it to a `string` variable.

There is an useful class called `StringBuilder`, defined in `System.Text`, which creates **mutable** strings.

Unlike the `String` class, it's not optimized for searching. So, it doesn't have methods like `IndexOf()`, `LastIndexOf()`, `Contains()`, `StartsWith()` etc.

Instead, it provides useful string manipulation methods, like `Append()`, `Insert()`, `Remove()`, `Replace()`, `Clear()` etc. Just like a linked list.

We can also use an indexer to display different characters of a string, for example: `stringBuilder[2]`.

Some examples:

```cs
using System;
using System.Text;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringBuilder = new StringBuilder("Hello, world."); // Builds a StringBuilder with "Testing".
            stringBuilder.AppendLine(); // Appends a \n to the end of the StringBuilder.
            stringBuilder.Append('-', 10); // Appends the char '-' to the end of the StringBuilder 10 times.
            stringBuilder.AppendLine();
            stringBuilder.Append("Header"); // Appends the string "Header" to the end of the StringBuilder.
            stringBuilder.AppendLine();
            stringBuilder.Append('-', 10);
            Console.WriteLine(stringBuilder);
            Console.WriteLine();
            stringBuilder.Replace('-', '+'); // Replaces the '-' with a '+'.
            Console.WriteLine(stringBuilder);
            Console.WriteLine();
            stringBuilder.Remove(0, 10); // Removes 10 characters starting from index 0.
            Console.WriteLine(stringBuilder);
            Console.WriteLine();
            stringBuilder.Insert(0, new string('=', 10)); // Inserts "==========" at the beginning of the StringBuilder.
            Console.WriteLine(stringBuilder);
            Console.WriteLine();
            Console.WriteLine(stringBuilder[0]); // First character of the StringBuilder.
        }
    }
}
```

Which prints:

```
Hello, world.
----------
Header
----------

Hello, world.
++++++++++
Header
++++++++++

ld.
++++++++++
Header
++++++++++

==========ld.
++++++++++
Header
++++++++++

=
```

Since these methods return the updated `StringBuilder`, we can chain them:

```cs
using System;
using System.Text;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringBuilder = new StringBuilder("Hello, world.");
            stringBuilder.AppendLine();
                         .Append('-', 10);
                         .AppendLine();
                         .Append("Header");
                         .AppendLine();
                         .Append('-', 10);
        }
    }
}
```

## Converting types

We have **implicit** and **explicit** conversions.

In implicit, it converts as long as there's not information loss, like `byte a = 3;` and `int b = a;`, or `float c = 4;` and `int d = c;`

But, we cannot convert `int a = 1;` to `byte b = c;`, because `int` occupies 4 bytes, whereas `byte`, occupies just one. Even though the number `1` fits into a `byte`, the compiler treats it as information loss and doesn't compile.

In these cases, we can use the **explicit** conversion type, or **casting**, which is just like Java: `int a = 1;` and `byte b = (byte) a;`.

To convert a `string` to an `int`, for example, we can use the methods from the `Convert` class from the `System` namespace:

```cs
using System;

string s = "1";
int i = Convert.ToInt32(s);
```

All primitive types have overloaded methods for conversion, that accept each primitive type as an argument.

We can also use the static `Parse` method from each primitive type struct:

```cs
string s = "1";
int i = int.Parse(s);
```

## Casting characters to integers

Since a character is represented by a number when CLR runs, we can actually cast a `char` to an `int`:

```cs
char a = 'a';
int numA = (int) a;
```
Which prints out "97".

This maps to an [ASCII table](https://www.ascii-code.com/)

The reverse also works:

```cs
int numA = 97;
char a = (char) numA;
```

Which prints out `a`.

Another important thing to note is that, instead of concatenating, when we do math operations with a `char` and a number (any number data type), CLR automatically converts the `char` to its related ASCII number and does the operation.

Thus:

```cs
Console.WriteLine('a' + 10);
```

Returns `107`.

## Structs

It's a container in C# that's similar to a class.

They're not really used - we use classes 99% of the time.

They combine related fields and methods together.

There are a lot of tiny differences between classes and structs that's in the [official documentation](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct), but they're not very important to know.

What we should take from **structs**, is that we should use them when we want to create a small lightweight object. For example:

```cs
public struct RgbColor
{
    public int Red;
    public int Green;
    public int Blue;
}
```

It's more efficient to define it as a structure, when we need to create thousands of objects.

## Enums

This data structure is also present in Java.

We create enums when we want to encapsulate similar constant values. It's like a container just for constants.

It works just like a class.

We can create one using the keyword `enum`.

Example: instead of declaring multiple constants like:

```cs
const int RegularAirMail = 1;
const int RegisteredAirMail = 2;
const int Express = 3;
```

We declare a `enum` block:

```cs
public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3
}
```

Notice that we didn't have to explicitly specify the data type, because they're integers by default.

We can change the data type to **another numeric data type only** using a colon:

```cs
public enum ShippingMethod : byte
{
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3
}
```

If we don't specify the values of the constants, the first member will be automatically assigned to 0, and from there, every member's value will be increased by one:

```cs
public enum ShippingMethod
{
    RegularAirMail, // 0.
    RegisteredAirMail, // 1.
    Express // 2.
}
```

But it's best practice to always give these constants a value.

We can access the enums using the dot notation and assigning it's value to a enum type, since it works like a class:

```cs
public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3
}

ShippingMethod method = ShippingMethod.Express;
```

Or, just use `var`:

```cs
var method = ShippingMethod.Express;
```

If we print this variable with `Console.WriteLine()`, we get:

```
Express
```

Which is the name of the constant.

By default, `Console.WriteLine()` **always converts it's argument into a string**. So, if we want to convert the type of this enum from `ShippingMethod` to an actual `string` without printing it, we can use the `ToString()` static method from the `System.Enum` abstract class:

```cs
var methodString = method.ToString();
```

The other around also works. We can also parse a `string` into a `ShippingMethod` using the overloaded `Parse()` static method, also from  from the `System.Enum` abstract class:

```cs
Object shippingArgument = Enum.Parse(typeof(ShippingMethod), "Express"); // Or var shippingArgument = ...
```

Here we used the `typeof` alias to the class `System.Type`, which returns the type of data from that enum (`NamespaceThatIamIn.ShippingMethod`), which is the first argument of this `Parse()` method, and we pass in the `string` that we want to search in the `enum` as the second argument. This prints out:

```
Express
```

If the argument wasn't in `ShippingMethod`, it would've not compiled and thrown us an error.

Notice that `Parse()` returns an `System.Object` type, which is a class in the `System` namespace.

To get the actual value from the constant, we need to cast it to an integer:

```cs
var methodValue = (int) method;
```

Printing this out, we get:

```
3
```

We can also map the values back to the constants by converting them into the enum type:

```cs
Console.WriteLine((ShippingMethod) 2);
```

Prints out:

```
RegisteredAirMail
```

If the value doesn't exist inside the enum, we get the number back:

```cs
Console.WriteLine((ShippingMethod) 4);
```

Returns:

```
4
```

## Reference types and value types

As we learned, all primitive types are [structures](#structs), since they are very small and take no more than some bytes, and arrays, [strings](#strings), and custom classes are classes.

All [structures](#structs) are **value types** and all classes are **reference types**.

When we create a **value type**, we allocate memory **automatically** on the **stack** for it. When we get out of this value's scope, the value is immediately removed from the memory.

With reference types, we need to allocate memory **manually**. We can do that by using the **new** keyword and the value is allocated on the memory **heap**, which is a larger amount of memory, and it's used to store data that have a longer lifetime.

Unlike stack, the heap is more sustainable. Thus, whenever we go out of scope, the value will continue to exist for a little while. It won't be removed immediately.

There's a process called garbage collection that's done by the [CLR](https://docs.microsoft.com/en-us/dotnet/standard/clr) (or runtime) that takes care of this.

So, once in a while, the CLR searches for objects that are no longer in use and removes them from the heap.

Example of **value types**. Here we're using a [struct](#struct) (integers):

```cs
using System;

namespace CSharpLearning
{
    class Program
    {
        static void Main(string[] args)
        {

            // Value types:
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}; b {1}.", a, b)); // a is 10; b is 11.
        }
    }
}
```

Here, `b` **copied** `a`. Thus, they're independent from each other.

Now, an example of **reference types** using classes (arrays):

```cs
using System;

namespace CSharpLearning
{
    public enum ShippingMethod: long
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {

            // Reference types:
            var arrayOne = new int[3] { 1, 2, 3 };
            var arrayTwo = arrayOne;
            arrayOne[0] = 0;
            Console.WriteLine(string.Format("arrayOne[0]: {0}; arrayTwo[0] {1}.", arrayOne[0], arrayTwo[0])); // 0 and 0.
        }
    }
}
```

Here, the first elements of both arrays were changed. That's because we only allocated memory **once** for both arrays, that was when `arrayOne` was created. When we assigned the value of `arrayTwo` to `arrayOne`, we actually just **pointed** `arrayTwo` to the same memory address of `arrayOne`, on the heap.

Thus, when the contents of `arrayOne` were changed, it also changed for `arrayTwo`, because in fact, they are **the same array**.

Another example:

```cs
using System;

namespace CSharpLearning
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(string.Format("The number variable is {0}.", number)); // This value will still be 1.
            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(string.Format("The value of person.Age is: {0}.", person.Age)); // This value will now be 10.
        }
    }
}
```

Here, we created two static methods inside the `Program` class. When calling the `Increment()` method on the `number` integer variable, we **make a copy** of `number` inside the method, allocating new memory in the stack, therefore, change the variable **just inside the method**. Thus, our `number` variable remains unaltered.

Now, when we apply the method `MakeOld()` to increase the field `Age` of the `Person` class. Here, we don't make any copies of the created `person` variable, because it's been created with the `new` keyword and it's allocated in the heap.

Instead, a reference to `person` is passed inside the `MakeOld()` method, which points to the same memory address of `person`. Thus, the age will be incremented by 10, making it 30.

That notation when we created the object is the **object initialization syntax**, and with it, we can quickly initialize public fields when allocating a class to the heap.

## Random number

We can create random numbers by using the `System.Random` class.

It has an overloaded constructor that allows us to input a seed to generate random number from, so that our numbers are not "that random".

We can create an object for this class and use its methods.

Some of them are `System.Random.Next()`, which returns a random integer, respecting the wrapper class' maximum and minimum values.

This method has an overload, that allows us to input a maximum and minimum value - a range that we want our number to be generated from.

Adding an integer to the resulting random number on the interval offsets the whole interval. Thus, [doing operations with a `char` and casting the result back to a `char`](#casting-characters-to-integers) allows us to make some sort of random password generation.

For this generator, because stings are immutable objects, we cannot create an empty string and concatenate it with each new password character generated in the loop. Thus, we have to assign them into a buffer array, and then, when creating a new `string`, we can use one of its overloaded constructors that accepts an array of `char`:

```cs
using System;

namespace CSharpLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            var randNum = new Random();
            const int passwordLength = 10;
            Console.WriteLine("Starting loop...");
            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] =(char) ('a' + randNum.Next(0, 26));
            }
            var randomPass = new string(buffer);
            Console.WriteLine(randomPass);
        }
    }
}
```

We have also `System.Random.NextBytes()`, `System.Random.NextBytes()`, `System.Random.NextDouble()` and so on.

## Returning in void

We can use the `return` keyword in a void method followed by no information to break out of the method:

```cs
static void ExerciseThree()
    {
        int randomInt = new Random().Next(1, 11);
        Console.WriteLine("Guess a number between 1 to 10. You have 4 tries:");
        for (int i = 0; i < 4; i++)
        {
            Console.Write(string.Format("Try {0}: ", i + 1));
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == randomInt)
            {
                Console.WriteLine("You won! The number was {0}", randomInt);
                return;
            }
        }
        Console.WriteLine("You lost. The number was {0}.", randomInt);
    }
```

## Parsing arguments to methods

In C#, if we don't remember the order of the parameters of a function we're calling, we can send them in in any order, as long as we remember their names.

From the [official documentation on named arguments](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments#named-arguments):

```cs
...
PrintOrderDetails(orderNum: 31, productName: "Red Mug", sellerName: "Gift Shop");
PrintOrderDetails(productName: "Red Mug", sellerName: "Gift Shop", orderNum: 31);
...
```

## Access modifiers

Since this was not covered so good in the [Learning Java repository](https://github.com/gagibran/learning-java), I'll put this section here.

We have:
- Public;
- Private;
- Protected;
- Internal;
- Protected internal.

Here's the [official documentation](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers) explaining their permissions.

Modifiers improve the encapsulation/information hiding in our code.

Private and public modifiers are the only ones that are well covered: a public member is accessed everywhere and a private member is only accessible from that class.

If we don't specify one, methods are `public` by default in C#.

A **protected** member is only accessible only from the class and its derived classes. It's often considered a bad practice to use it in C#, but can be used when needed. Example (here I created the classes in the same `.cs` file).

```cs
using System;

namespace Inheritance
{
    public class Customer
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
    }

    public class GoldCustomer : Customer
    {
        public GoldCustomer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            // customer.Id = 10; // Doesn't work.
            var goldCustomer = new GoldCustomer(id: 10, name: "Gabriel"); // This works because Id and Name are protected, not private.
            // Console.WriteLine(goldCustomer.Id); // Doesn't work as well.
        }
    }
}
```

An **internal** member is a member that can only be accessed within the same assembly. It's often used for classes, not its members. It doesn't make sense to use it for methods, properties or fields. If this modifier is applied to a class, we can instantiate it within our assembly (or DLL), but cannot instantiate it in another one.

A **protected internal** is a very bad practice and should not be used. A member with this modifier can be accessed from the same assembly or any derived classes.

## Arrays

We have multi-dimension arrays in C#, they are rectangular  and jagged arrays.

The rectangular arrays (like matrices):

```cs
int[,] matrix = new int[3, 5]; // Uninitialized 3x5.

int [,] anotherMatrix = new[3, 4]
{
    { 1, 2, 3, 4, 5 },
    { 6, 7, 8, 9, 10 },
    { 11, 12, 13, 14, 15 }
}; // Initialized 3x5.

// We can also create them with var:
var oneMoreMatrix = new string[2, 2];

// We can also omit the dimension called by new:
var Matrix2D = new int[,]
{
    { 1, 2, 3, 4 },
    { 2, 3, 4, 5 },
    { 1, 1, 1, 1 },
    { 0, 0, 0, 0 },
}
```

We can, of course, create arrays with more dimensions, like 3 or 4:

```cs
int [,,] colors = new int [3, 5, 4]; // var also works.
```

To access the elements of arrays, we can use:

```cs
Console.WriteLine(colors[0, 0, 0]); // Prints out the element a000.
```

Jagged arrays are array of arrays. So, instead of declaring an array with multiple dimensions, we declare a top-level array.

Each element of this top-level array is an array within itself. We fill this elements with other arrays:

```cs
int[3][] jagged = new int[3][]; // Jagged array with three rows.

// Filling the jagged array's columns:
jagged[0] = new int[6];
jagged[0] = new int[2];
jagged[0] = new int[1];

// var also works here as well:

var anotherJagged = new int[5][];
```

This array looks like this:

![Jagged Array](readme-images/jagged-array.png)

## Lists

Mutable arrays. They belong to the `System.Collections.Generic` namespace. We learn more about generics in the advanced course.

Their syntax:

```cs
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(); // Uninitialized.
            List<int> listTwo = new List<int>() { 1, 2, 3, 4 }; // Initialized.
            var listThree = new List<int>(); // With var.
        }
    }
}
```

We also have `Add()`, `IndexOf()`, `RemoveAt()`, `AddRange()`, `Size`, and so on...

To access the length of a generic list, we use the `Count` property.

**Important**: In C#, we're not allowed to modify a collection inside a foreach-loop. Thus, this is forbidden:

```cs
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3 };
            foreach (var number in numbers) {
                numbers.Remove(number);
            }
        }
    }
}
```

This throws a `InvalidOperationException`.

We need to use a normal for-loop for it:

```cs
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3 };
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers.Remove(numbers[i]);
            }
        }
    }
}
```

## Working with dates

We have a read-only structure defined in `System` called `DateTime` to work with dates and time.

Thus, we can instantiate `DateTime` as an object with its multiple overloaded constructors, allowing us to specify days, months, weeks, hours, minutes, and so on.

With these overloads, we can be as specific as we want to:

```cs
using System;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2021, 3, 21); // Year, month, day.
        }
    }
}
```

We can also parse a string ina time format to a `DateTime` type with `DateTime.Parse()`.

We can get the system's clock with the static property `Now`:

```cs
using System;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(DateTime.Now);
        }
    }
}
```

Which outputs:

```
21/03/2021 17:00:00
```

We can get specific elements of our date-time, like hour, minute, seconds, milliseconds, day, year, and month. We just have to use their respective properties:

```cs
using System;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            Console.WriteLine(now.Millisecond);
            Console.WriteLine(now.Second);
            Console.WriteLine(now.Minute);
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Day);
            Console.WriteLine(now.Month);
            Console.WriteLine(now.Year);
        }
    }
}
```

Which prints:

```
164
58
3
17
21
3
2021
```

We can add values to a `DateTime` object with their `Add` methods, such as `AddYears()`, `AddSeconds()`, and so on...

**These changes are no in-place, meaning that the object won't get modified.**

Example:

```cs
using System;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            Console.WriteLine(now.AddYears(2021)); // Doesn't modify "now".
            Console.WriteLine(now); // Still prints 2021.
        }
    }
}
```

Prints:

```
21/03/4042 17:08:18
21/03/2021 17:08:18
```

We can convert these objects to a string by using their converter methods, such as `ToString()`, `ToLongDateString()`, `To ShortDateString()`, `ToLongTimeString()`, or `ToShortTimeString()`. Here are the differences:

```cs
using System;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
        }
    }
}
```

Prints:

```
domingo, 21 de março de 2021
21/03/2021
17:11:34
17:11
21/03/2021 17:11:34
```

Since my system is set to Portuguese, the `LongTimeString()` method returned it in Portuguese.

We also format specifiers, to print the date-time object in a certain standard. We pass it as a parameter of `ToString()`. For example:

```cs
using System;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            Console.WriteLine(now.ToString("yyyy-MM-dd"));
            Console.WriteLine(now.ToString("yyyy-MM-dd-HH:mm"));
        }
    }
}
```

Prints

```
2021-03-21
2021-03-21-17:17
```

A full list of specifiers can be found in the [official documentation]((https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#standard-format-specifiers)).

We also have a `TimeSpan` structure, which represents a length of time. There are three ways of creating a `TimeSpan` object:

```cs
using System;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1, 2, 3); // 1 hour, 2 minutes, and 3 seconds.
            var secondTimeSpan = TimeSpan.FromHours(1); // 1 hour, 0 minutes, and 0 seconds.

            // Creating a TimeSpan by subtracting two DateTime objects:
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            // Print outs:
            Console.WriteLine(timeSpan);
            Console.WriteLine(secondTimeSpan);
            Console.WriteLine(duration);
        }
    }
}
```

Which prints:

```
01:02:03
01:00:00
00:02:00.0010927
```

As we can see, in the second way, we can call these static methods, such as `FromHours()`, `FromMinutes()`, `FromSeconds()`, and so on, to make all the other measurements of time equals zero.

The first way has overloaded constructors that allows us to be as specific as we can.

The third way involves doing operations with `DateTime` objects. They result in a `TimeSpan`.

There are some useful properties that come in pairs in a `TimeSpan` object, such as `Minutes`, `TotalMinutes`, `Hours`, `TotalHours`, and so on.

The difference between the members of a pair is: one prints the actual measurement of time that our `TimeSpan` has, such as `2` minutes (for `Minutes`) and, the other, prints the total measurement of time that our object has. Example:

```cs
using System;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine(timeSpan.Milliseconds);
            Console.WriteLine(timeSpan.TotalMilliseconds);
        }
    }
}
```

Prints:

```
0
3723000
```

Because our object was created with zero milliseconds (we just used hours, minutes, and seconds in the constructor), but the total milliseconds of 1 hour, 2 minutes, and 3 seconds is 3,723,000 ms.

A `TimeSpan` is also read-only, so, similarly to `DateTime`, we have the methods `Add()` and `Subtract()`:

```cs
using System;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan.Add(TimeSpan.FromSeconds(2)));
            Console.WriteLine(timeSpan.Subtract(TimeSpan.FromSeconds(5)));
        }
    }
}
```

Which prints:

```
01:02:03
01:02:05
01:01:58
```

We also have conversion methods, such as `ToString()`, and a static parsing method, to convert a string into a `TimeSpan`:

```cs
using System;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine(timeSpan.ToString()); // This is redundant here, because Console.WriteLine() automatically converts its parameter to a string.
            Console.WriteLine(TimeSpan.Parse("01:02:03"));
        }
    }
}
```

Which prints:

```
01:02:03
01:02:05
01:01:58
```

## Working with text

In C# we also have `ToUpper()`, `ToLower()`, `Trim()`, `IndexOf()`, `LastIndexOf()`, `Substring()` (to create a string from another one), `Replace()`, `IsNullOrEmpty()`, and `IsNullOrWhiteSpace`.

Since strings are immutable, they return a different string when called.

**Important**: We don't need to use `string.Format()` in `Console.WriteLine()`, we can just specify the placeholders and arguments in `Console.WriteLine()` directly.

Reminder that `ToString()` accepts format specifiers, such as `"C"`, for currency. We also have the specifier, level: `"C0"` for zero decimal points, `"C1"` for one etc.

Common specifiers:

| **Format Specifier** | **Description** | **Example**        |
|----------------------|-----------------|--------------------|
| **c** or **C**      | Currency        | 123456 (C) -> $123,456 |
| **d** or **D**      | Decimal        | 1234 (D6) -> 001234 |
| **e** or **E**      | Exponential        | 1052.32442 (E) -> 1.05232442E+003 |
| **f** or **F**      | Fixed Point        | 1234.567 (F1) -> 1234.5 |
| **x** or **X**      | Hexadecimal        | 255 (X) -> FF |

Some examples:

```cs
using System;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Gabriel Gibran ";
            Console.WriteLine("Trim '{0}'", fullName.Trim()); // Removes whitespace on the beginning and at the end.
            Console.WriteLine("ToUpper '{0}'", fullName.ToUpper());
            Console.WriteLine("ToLower '{0}'", fullName.ToLower());
            Console.WriteLine("IndexOf '{0}'", fullName.ToLower());

            // Creating a substring:
            var index = fullName.IndexOf(' '); // Returns the first instance of a whitespace.
            var firstName = fullName.Substring(0, index); // Creates a substring from the 0th position until the first whitespace. In other words: the first name.
            var lastName = fullName.Substring(index + 1).Trim(); // Creates a substring from after the whitespace until the end. In other words: the last name.

            // Creating a substring from Split():
            Console.WriteLine(fullName.Split(' ')[1]); // Split() returns an array.

            // Replace:
            Console.WriteLine(fullName.Replace("Gabriel", "Gab"));

            // Null strings:
            if (String.IsNullOrEmpty(" ")) // Works for null or "".
            {
                Console.WriteLine("The string is empty or null.");
            }

            // To detect an empty string with whitespace we can either do a trim, or use the better and newer method:
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("The string is empty, null, or filled with whitespace.");
            }

            // Using format strings:
            double price = 12.45;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0")); // Gets rid of the decimal points.
        }
    }
}
```

Which prints:

```
Trim 'Gabriel Gibran'
ToUpper 'GABRIEL GIBRAN '
ToLower 'gabriel gibran '
IndexOf 'gabriel gibran '
Gibran
Gab Gibran
The string is empty, null, or filled with whitespace.
R$ 12,45
R$ 12
```

Since my system is set to Brazil and it's using the Brazilian currency format, it displayed it as BRL.

## Default or optional arguments

Like Python, we can give arguments of a method default values to make them optional. **They also have to appear after all required parameters**.

The following method summarizes a long text:

```cs
...
public static string Summarize(string text, int length = 20)
{
    string[] words = text.Split(' ');
    var summary = "";
    foreach (var word in words)
    {
        if (summary.Length >= length)
        {
            break;
        }
        summary += word + " ";
    }
    return summary.Trim() + "...";
}
...
```

We can see here that `length` already has a pre-defined value. Thus, when we call this method, we don't have to pass in a length if we want to use the default as 20, we can just pass the text.

We can also pass them [using the colon notation](#parsing-arguments-to-methods), in any order, or use the colon notation to specify only the optional arguments that we want to:

```cs
...
public int Test(bool aTest, string testStr, int optInt = 2, double aDouble = 4)
{
    return 0;
}
...
```

When we call this test method in `Main()`, we can specify only the `aDouble` argument, for example:

```cs
...
aClass.Test(true, testStr, aDouble = 3.4);
...
```

## Working with files

We can use the [System.IO](https://docs.microsoft.com/en-us/dotnet/api/system.io?view=net-5.0) namespace to work with files.

Some useful classes within it are `File` and `FileInfo`. They have methods for creating, deleting, moving, and deleting files.

The difference between these two classes is that `FileInfo` provides instance methods, thus, used for a lot of operation and manipulation, whereas `File` provides static methods, used for a small number of operation.

Every time we manipulate files with the static methods, some security checks are done within the OS to make sure that the current user has access to the file, affecting the performance of the operation.

That's why it's more efficient to use `FileInfo` if we need to do a lot of operations with files.

Some methods include: `Create()`, `Copy()` (`CopyTo()` in `FileInfo`), `Delete()`, `Exists()` (it's a property, called `Exists`, in `FileInfo`), `GetAttributes()`, `Move()`, `ReadAllText()` (only available in `File`), `ReadAllByte()` which returns the binary of a file, and many more.

We also have `Directory` and `DirectoryInfo`, which work similarly to `File` and `FileInfo`, but the deal with directories.

Some useful methods: `CreateDirectory()`, `Delete()`, `Exists()`, `GetCurrentDirectory()`, `GetFiles()`, `Move()`, and `GetLogicalDrives()`, which returns the logical drives of a hard-disk, like `C:\`, `D:\` etc., and many more.

We also have the `Path` class, that provides methods to work with a string that contains a file or directory path information.

Some useful methods: `GetDirectoryName()`, `GetFileName()`, `GetExtension()`, `GetTempPath()`, which returns the path of a user's temporary folder, and many more.

Some examples for `File` and `FileInfo`:

```cs
using System;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\gibra\Desktop\Projetos\wizards-of-oslam\readme-images\game.png";
            var pathDest = @"C:\Users\gibra\Desktop\Projetos\learning-csharp-and-unity\csharp-notes-and-exercises\WorkingWithFiles\picture-copied.png";

            // File:
            File.Copy(path, pathDest);
            if (File.Exists(path))
            {
                Console.WriteLine("The file is there.");
            }
            else
            {
                Console.WriteLine("The file isn't there.");

            }
            File.Delete(pathDest);
            if (File.Exists(path))
            {
                Console.WriteLine("The file is there.");
            }
            else
            {
                Console.WriteLine("The file isn't there.");
            }
            File.Copy(path, pathDest);
            Console.WriteLine(File.ReadAllText(pathDest));
            Console.WriteLine(File.ReadAllBytes(pathDest));
            File.Delete(pathDest);
            Console.WriteLine();

            // FileInfo:
            var fileInfo = new FileInfo(path);
            var newFileInfo = fileInfo.CopyTo(pathDest);
            if (newFileInfo.Exists)
            {
                Console.WriteLine("The file is there.");
            }
            else
            {
                Console.WriteLine("The file isn't there.");

            }
            // fileInfo.Delete(); // Deletes the original.
            newFileInfo.Delete();
            if (newFileInfo.Exists)
            {
                Console.WriteLine("The file is there.");
            }
            else
            {
                Console.WriteLine("The file isn't there.");

            }

        }
    }
}
```

Some examples for `Directory` and `DirectoryInfo`:

```cs
using System;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\gibra\Desktop\Projetos\wizards-of-oslam\readme-images\game.png";
            var pathTempDir = @"C:\temp\temp_dir";

            // Directory:
            Directory.CreateDirectory(pathTempDir);
            File.Copy(path, pathTempDir + @"\pic.png");
            Directory.GetFiles(pathTempDir);
            Directory.GetFiles(pathTempDir, "*.png");
            string[] files = Directory.GetFiles(@"C:\Users\gibra\Desktop\Projetos", "*.*", SearchOption.AllDirectories); // Finds all files in the current directory and its children.
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            string[] directories = Directory.GetDirectories(@"C:\Users\gibra\Desktop\Projetos", "*.*", SearchOption.AllDirectories); // Finds all directories in the current directory and its children.
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }
            Directory.Exists(pathTempDir);
            File.Delete(pathTempDir + @"\pic.png");
            Directory.Delete(pathTempDir);
            Console.WriteLine();

            // DirectoryInfo:
            var directoryInfo = new DirectoryInfo(@"C:\Users\gibra\Desktop\Projetos");
            // Etc...
        }
    }
}
```

Some examples for `File`:

```cs
using System;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\gibra\Desktop\Projetos\wizards-of-oslam\readme-images\game.png";

            // Path:
            Console.WriteLine(Path.GetExtension(path)); // Returns ".png".
            Console.WriteLine(Path.GetFileName(path)); // Returns "game.png".
            Console.WriteLine(Path.GetFileNameWithoutExtension(path)); // Returns "game".
            Console.WriteLine(Path.GetDirectoryName(path)); // Returns "C:\Users\gibra\Desktop\Projetos\wizards-of-oslam\readme-images".
        }
    }
}
```

## Calling a constructor from a overloaded one

In C#, we can call a constructor from another one by adding a colon (`:`) followed by the `this()` keyword with the parameters inside of its parenthesis.

We put `this()` right after the constructor's declaration, before their curly brackets:

```cs
using System.Collections.Generic;

namespace Classes
{
    public class Customer
    {
        // Fields:
        private int _id;
        private string _name;
        private List<Order> _orders;

        // Default constructor:
        public Customer()
        {
            _orders = new List<Order>();
        }

        // Constructors:
        // Calls the parameterless constructor:
        public Customer(int id) : this()
        {
            _id = id;
        }

        public Customer(int id, string name)
            : this(id) // Calls the "Id" constructor ("this()" can be put here as well).
        {
            _name = name;
        }
    }
}
```

`Order` is just an empty class:

```cs
namespace Classes
{
    public class Order
    {
    }
}
```

This is definitely not a good practice, as it makes the workflow complicated and the code not so readable.

We have **object initializers** in C#, which is a quick and not messy way to initialize only the fields that we want, without have to creating multiple overloaded constructors.

Using this syntax, we actually don't have create any constructors in our class, only when they are really needed, as it's the case of initializing a list, for example.

An example:

```cs
using System.Collections.Generic;

namespace Classes
{
    public class Customer
    {
        // Fields:
        public int Id;
        public string Name;
        private List<Order> _orders;

        // Constructor to initialize the list:
        public Customer()
        {
            _orders = new List<Order>();
        }

        // We don't need any other constructors here. See how "Name" and "Id" are initialized in "Main()".
    }
}
```

The `Main()` method:

```cs
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            // Initializing the public fields that don't have constructors.
            var customer = new Customer() { Name = "Gabriel", Id = 3124234 };
        }
    }
}
```

In this example I set the fields as `public` so that they can actually be initialized using this syntax without the need of setters.

We can see that only `List<Order> Orders` is being initialized here, otherwise it would be null.

Some developers actually prefer to actually initialize this fields that need initialization in their declaration. For example:

```cs
using System.Collections.Generic;

namespace Classes
{
    public class Customer
    {
        // Fields:
        public int Id;
        public string Name;
        private List<Order> _orders = new List<Order>();
    }
}
```

Here we don't really need any more constructors.

## Parameter modifiers

In C# we have the concept of modifying parameters.

### Params

This modifier can be used by writing the `params` keyword.

This means that we can pass any number of parameters into a method that takes in an array or a list, without having actually creating a new array or list.

Example, for an add operation in a `Calculator` class (method created without using `Sum`, from `System.Linq`):

```cs
namespace Classes
{
    public class Calculator
    {
        public static double Add(double[] numbers)
        {
            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
```

In `Main()`, we would normally pass a array of numbers to this method:

```cs
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(new double[] { 1, 2, 3, 4 })); // This prints out "10".
        }
    }
}
```

When creating the `double` array, we can use the `params` keyword, when declaring the `Add()` method:

```cs
namespace Classes
{
    public class Calculator
    {
        public static double Add(params double[] numbers)
        {
            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
```

Now, in `Main()`, we can simply pass in any numbers that we want as argument, because this method expects any number of parameters when called:

```cs
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(new double[] { 1, 2, 3, 4 })); // This one still works and prints out "10".
            Console.WriteLine(Calculator.Add(1, 2, 3, 4)); // Also prints out "10".
        }
    }
}
```

Note that we can still create a new array to pass in as an argument if we wanted to [*args](https://realpython.com/python-kwargs-and-args/) in Python.

### Ref

It's are not really used. In fact, it should be actually avoided, as it is code smells.

It is used to pass values as reference to a method. For example:

```cs
namespace Classes
{
    public class Calculator
    {
        public static void AddTwo(double a)
        {
            a += 2;
        }
    }
}
```

And `Main()`:

```cs
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 2.4;
            Calculator.AddTwo(a);
            Console.WriteLine(a); // "a" will still be 2.4, because a copy of it is passed to the method. The original variable remains intact.
        }
    }
}
```

Since `a` is passed by value, not by reference, the original `a` won't be changed.

We can use the `ref` keyword in the method declaration to make `a` be passed as a reference:

```cs
namespace Classes
{
    public class Calculator
    {

        // Changes the passed "a" directly in its memory location.
        public static void AddTwo(ref double a)
        {
            a += 2;
        }
    }
}
```

In `Main()`:

```cs
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 2.4;
            Calculator.AddTwo(ref a); // We need to used the "ref" keyword here.
            Console.WriteLine(a); // Now "a" has been changed, because it's value has been changed in it's memory address.
        }
    }
}
```

### Out

We can actually assign a value to one or multiple variables using this modifier:

```cs
namespace Classes
{
    public class Calculator
    {
        public static void AssignValues(out double valueOne, out double valueTwo)
        {
            valueOne = 2;
            valueTwo = 3;
        }
    }
}
```

In `Main()`:

```cs
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 2.4;
            var b = 3.4;
            Calculator.AssignValues(out a, out b);
            Console.WriteLine($"a: {a}, b: {b}."); // "a" will be 2 and "b" will be 3.
        }
    }
}
```

This is also not good practice and this modifier should be avoided.

One place that this is used is in the `TryParse()` methods For example, if we try to parse an invalid string into an integer, this method returns a boolean stating if the conversion was successful or not.

Since it returns a boolean, the actual conversion is done by using an `out` parameter. For example:

```cs
...
int number;
int.TryParse("abc", out number); // Tries to parse "abc" and store it into the "number" variable. Returns "false", since it can't.
int.TryParse("231", out number); // This one works and returns "true".
...
```

Here, we're not only returning a boolean, but we're also modifying `number`.

## Read-only fields

We can declare a field with the `readonly` modifier, to make sure that thi field is **only assigned once**.

Thus, it doesn't matter if a getter tries to change it's value later on, it won't be changed.

This is used to improve robustness in our code. We can keep track of our fields' values like that.

Example:

```cs
using System.Collections.Generic;

namespace Classes
{
    public class Customer
    {
        private int _id;
        private string _name;
        private List<Order> _orders = new List<Order>();

        public Customer(int id)
        {
            _id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            _name = name;
        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public int GetAmountOfOrders()
        {
            return _orders.Count;
        }

        // This method is not good, because it's resetting our orders:
        public void Promote()
        {
            _orders = new List<Order>();
        }
    }
}
```

In `Main()`:

```cs
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1234);
            customer.AddOrder(new Order());
            customer.AddOrder(new Order());
            customer.AddOrder(new Order());
            Console.WriteLine(customer.GetAmountOfOrders()); // Here we have three orders for this customer.
            customer.Promote(); // Here we reinitialized the orders to a new object.
            Console.WriteLine(customer.GetAmountOfOrders()); // Since we reinitialized orders, we lost all of its contents. Thus, this prints 0.

        }
    }
}
```

This prints out:

```
3
0
```

As we can see, our `Orders` field should not be touched by any part of the code, otherwise we lose track of the all the orders from a customer.

To prevent this, we can declare the field as `readonly`:

```cs
...
private readonly List<Order> _orders = new List<Order>();
...
```

Now, we'll actually get a compile error in the `Promote()` method, stating that:

>A readonly field can only take an assignment in a constructor or at declaration.

```cs
public void Promote()
{
    _orders = new List<Order>(); // This no longer works.
}
```

Since properties are a thing in C#, most of the fields can be declared as read-only, since they won't have any setters or getters.

## Properties

It's a class member that encapsulates a getter and a setter for a field with less code.

An example of not using properties:

```cs
using System;

namespace Classes
{
    public class Person
    {
        private DateTime _birthdate;

        // Getter:
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }

        // Setter:
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
    }
}
```

The same example using properties:

```cs
using System;

namespace Classes
{
    public class Person
    {
        public DateTime _birthdate;

        // Property:
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }
    }
}
```

Here `value` assigns whatever value we pass to this property when it's called.

In `Main()`:

```cs
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Birthdate = new DateTime(1994, 26, 3);
            Console.WriteLine(person.Birthdate);
        }
    }
}
```

Note that we can only call this property because it's `public`. In this case, we have to be smart on which properties should be public and which shouldn't.

If we want the getter and the setter of a property to be accessed outside the class, then the property should be `public`.

We can declare the setter and the getter as private, or any access modifier stronger than the property's own modifier:

```cs
...
private set { _birthdate = value; }
...
```

Since we don't want any outsiders messing with the Birthdate of a person, we set it to `private`.

We can actually simplify this even further by using an **auto-implemented property**:

```cs
using System;

namespace Classes
{
    public class Person
    {
        public DateTime Birthdate{ get; private set; }
        }
    }
}
```

The code snippet for it is `prop`.

Here, `get` and `set` are implementing `return _birthdate` and `_birthdate = value` respectively and implicitly. The difference is that we didn't even have to create the field `_birthdate`. C# creates it automatically for us inside the `bin\Debug\<dotnet-version>` folder, in the project's directory.

After building our project and compiling the source code, in this `bin\Debug\net5.0` directory (in my case), we can invoke the Visual Studio command `ildasm <ProjectName.dll>` (intermediate language disassembler) in the integrated terminal from Visual Studio (`Ctrl+'`), also known as the `Developer PowerShell`, passing in as an argument the compiled code, or artifact (in my case, `Classes.dll`), to get the IL file. Note that this won't work in a common terminal, it has to be this integrated one from Visual Studio.

In the disassembler, we can see that inside the `Person` class, we have a `BackingField` for `Birthdate`. We also have two methods, `set_Birthdate` and `get_Birthdate`. These have been implemented behind the scenes by CLR:

![IL DASM](../readme-images/il-dasm.png)

If we double click a method, we can see the intermediate language for it.

For `get_Birthdate`:

```
.method private hidebysig specialname instance valuetype [System.Runtime]System.DateTime 
        get_Birthdate() cil managed
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  // Code size       7 (0x7)
  .maxstack  8
  IL_0000:  ldarg.0
  IL_0001:  ldfld      valuetype [System.Runtime]System.DateTime Classes.Person::'<Birthdate>k__BackingField'
  IL_0006:  ret
} // end of method Person::get_Birthdate
```

If we check the property `Birthdate` there, we can see that it's simply calling the getter and the setter:

```
.property instance valuetype [System.Runtime]System.DateTime
        Birthdate()
{
  .get instance valuetype [System.Runtime]System.DateTime Classes.Person::get_Birthdate()
  .set instance void Classes.Person::set_Birthdate(valuetype [System.Runtime]System.DateTime)
} // end of property Person::Birthdate
```

We also have a default constructor, also created automatically for us in `.ctor : void()`:

```
.method public hidebysig specialname rtspecialname 
        instance void  .ctor() cil managed
{
  // Code size       8 (0x8)
  .maxstack  8
  IL_0000:  ldarg.0
  IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
  IL_0006:  nop
  IL_0007:  ret
} // end of method Person::.ctor
```

We can also straight up not implementing a getter or a setter but just omitting the keyword:

```cs
public DateTime Birthdate{ get; }
```

Or:

```cs
public DateTime Birthdate{ set; }
```

Moving on, if we want to actually create a logic for a getter or a setter, we cannot use auto-implemented properties. For example:

```cs
using System;

namespace Classes
{
    public class Person
    {
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                TimeSpan timeSinceBirth = DateTime.Today - Birthdate; // Returns a TimeSpan object.
                return timeSinceBirth.Days / 365; // Returns the days since the birthday in years - the age.
            }
        }
    }
}
```

Here we're validating `Age` when its getter is called to get the actual age.

We also didn't declare a setter for the age because it doesn't make sense to set the age of a person in this context.

Since the getter for `Birthdate` is private, we added a constructor to set it's value in a `Person` object's creation.

A best practice here is to **always** put properties that are not auto-implemented after the constructors.

In `Main()`:

```cs
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1994, 3, 26));
            Console.WriteLine(person.Age);
        }
    }
}
```

## Indexers

An indexer is a way to access elements in a class that represents a list of values.

We can create indexers, just like the ones used to access elements of a list, or an array, for our classes.

Example using a dictionary:

```cs
using System;
using System.Collections.Generic;

namespace Classes
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        public DateTime Expiry{ get; set; }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

    }
}
```

In `Main()`:

```cs
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Gabriel";
            Console.WriteLine(cookie["name"]); // Prints "Gabriel".
        }
    }
}
```

In this class, the private read-only field `_dictionary` is a `Dictionary` that maps a value to a key.

`readonly` is used so that we assign values to this dictionary only once.

The indexer of a class is declared by using the `this` keyword instead of a property name. It also carries the type of index that the class will have.

Afterwards, it's just like a property: we declare its getter and setter.

In this case, this indexer is just returning the value of the `_dictionary` for a particular `key`, serving as a wrapper for this dictionary.

Another approach for this would be creating a `SetItem()` and a `GetItem()`:

```cs
using System;
using System.Collections.Generic;

namespace Classes
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public string GetItem(string key)
        {
            return _dictionary[key];
        }

        public void SetItem(string key, string value)
        {
            _dictionary[key] = value;
        }
    }
}
```

`Main()`:

```cs
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie.SetItem("name", "Gabriel");
            Console.WriteLine(cookie.GetItem("name"));
        }
    }
}
```

Thus, in this situation, using indexers makes our code cleaner.

## Class coupling

Coupling is a measurement of how interconnected classes and subsystems are.

It's a way that we determine class dependency throughout our software - how many other classes would be affected if one single class needed to be changed.

If changing one class affect a lot of other classes, the system is **tightly coupled**, and this is very bad practice, because it's very hard to measure the impact of one change.

On the other hand, **loosely coupled** systems are ideal, because the classes are isolated, thus, making it easier to track the effects of changing one subsystem.

To design a loosely coupled system, we need to apply the principles of: encapsulation, independence of classes, and interfaces.

## Inheritance

In C#, we use the colon (`:`) notation to represent an inheritance between to classes.

Just like Java, all classes inherit from the `Object` class.

```cs
using System;

namespace AssociationBetweenClasses
{
    public class Text : PresentationObject // Text inherited PresentationObject.
    {
        public double FontSize { get; set; }
        public string FontName { get; set; }

        public Text(string fontName, double fontSize = 10)
        {
            FontSize = fontSize;
            FontName = fontName;
        }

        public void AddHyperlink(string url)
        {
            Console.WriteLine($"Link added to {url}.");
        }
    }
}
```

To call the constructor from the base class we use the `base()` keyword, as opposed to Java's `super()`. The syntax is similar to [calling a constructor from a overloaded one](#calling-a-constructor-from-a-overloaded-one). We pass into the `base()` the arguments of the constructor of the base class, just like in Java.

As opposed to Java, we don't actually need to call the base constructor **if it doesn't initialize any fields or properties**, because it will be called regardless. But, if the base class has any constructors with initialization, `base()` must be used, like in Java:

```cs
using System;

namespace Inheritance
{
    public class Vehicle
    {
        private readonly long _registrationNumber;

        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized.");
        }
    }

    public class Car : Vehicle
    {
        public Car () // : base() doesn't have to be initialized here.
        {
            Console.WriteLine("Car is being initialized.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
        }
    }
}
```

This prints out:

```
Vehicle is being initialized.
Car is being initialized.
```

With initialization:

```cs
using System;

namespace Inheritance
{
    public class Vehicle
    {
        private readonly long _registrationNumber;

        public Vehicle(long registrationNumber)
        {
            registrationNumber = _registrationNumber;
            Console.WriteLine("Vehicle is being initialized.");
        }
    }

    public class Car : Vehicle
    {
        // : base() is no longer optional, because we no longer have a parameterless constructor in the base class:
        public Car (long registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(123344534534);
        }
    }
}
```

## Composition

Like Java, enables multiple a class to be composed of multiple ones. It's all about a ***has a*** relationship.

We simply create a field or a property of the class that will compose an outer one.

For example, a car has an engine, a truck also has an engine. Thus, we can create a private field `Engine _engine` in both classes. A car and a truck also have wheels, thus, we can create a private field `Wheel _wheel` in both classes.

Truck and car are, thus, composed of wheel and engine. This is better than inheritance, because with inheritance, we can only inherit from one class. Composition, we can "inherit" functionalities from multiple classes.

Inheritance also leads to large hierarchies, meaning that changing one base class can affect multiple ones.

Besides, any inheritance relationship can be translated into composition. For instance, if we create an `Animal` class with methods like `Eat()`, `Sleep()`, and `Walk()`, and make a `Person` and a `Dog`, class inherit from it, this could lead to potential problems, because a `Goldfish` class is an `Animal`, but shouldn't be able to `Walk()`.

So, we make a `Walkable` class, with a `Walk()` method on it. We now make `Person` and `Dog` be composed of `Animal` and `Walkable`, and `Goldfish` will now only be composed of `Animal`. We can even make a `Swimmable` class, with a `Swim()` method on it, and make it compose `Goldfish`.

With composition, we can also replace the `Animal` class with an `IAnimal` interface.

Thus, we should always favor composition over inheritance, but use inheritance properly if needed.

## Upcasting and downcasting

In C#, we can convert a value from a derived class to a base class, also called **upcasting**, or convert a base class from a derived class, also known as **downcasting**.

To upcast a value, we can simply assign it to a base class object, as it's implicit. For example:

```cs
using System;

namespace Inheritance
{
 
    public class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public void Draw()
        {
        }
    }


    public class Text : Shape
    {
        public double FontSize { get; set; }
        public string FontName { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            Shape shape = text; // Upcasting the value of "text" to a "Shape" object.
            Shape anotherText = new Text(); // This upcasting also works, as it should because of polymorphism.

            // Changing "Width" in any of the two objects affect both:
            shape.Width = 200;
            text.Width = 100;
            Console.WriteLine($"shape.Width: {shape.Width}, text.Width: {text.Width}."); // Both will be 200.
        }
    }
}
```

Here, both objects `text` and `shape` point to the same memory address, because we're passing by reference. Thus, changing any properties or fields of `text`, also changes it for `shape`.

In a real world scenario, we could use this conversion when using `System.IO.StreamReader`. Its constructor accepts a `Stream` object, or any classes derived from it, like `FileStream`, `MemoryStream` and so on. These objects are automatically upcast to `Stream`.

The same thing can be said to the `Add`

For downcasting, we can use [explicit conversion](#converting-types).

Or, we can use the `as` keyword. If the object cannot be converted to the target type, instead of throwing a `InvalidCastException`, it sets the object to `null`.

We can use the `is` keyword to check the type of an object.

Example:

```cs
using System;

namespace Inheritance
{
    public class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public void Draw()
        {
        }
    }


    public class Text : Shape
    {
        public double FontSize { get; set; }
        public string FontName { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Text(); // Even though we're explicitly declaring it as "Shape", it will be cast to "Text" at runtime.

            // This "shape" object won't have any properties from "Text", because it's converted only at runtime:
            // text.FontName = "Arial"; // This doesn't work

            // We need to downcast this object to give it access to the properties of "Text":
            Text text = (Text)shape;

            // Here we can also use the "as" keyword, if we didn't know the implications of this downcasting:
            Text anotherText = shape as Text;
            Console.WriteLine(anotherText == null); // "false" here, since the conversion is successful.

            // Now, "text" can access "Text"'s properties:
            text.FontName = "Arial";

            // Using "is":
            if (shape is Text)
            {
                Console.WriteLine("shape is Text."); // Prints out the message, since "shape" gets converted at runtime.
            }
        }
    }
}
```

## Boxing and unboxing

It was also covered in the Java course, but very poorly.

It's the process of converting a [value type instance to an object reference](#reference-types-and-value-types).

Whenever we box a value type to a reference type, CLR creates an object in the heap and creates a reference on the stack that points to that object.

Unboxing is the opposite of boxing, we convert a reference type to a value type.

They both have a performance penalty, because of this extra object creation and referencing. Thus, this should be avoided if possible.

An example:

```cs
using System;
using System.Collections;
using System.Collections.Generic;

namespace Inheritance
{
 
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();

            // The "Add()" method takes an argument of type "object", which is the mother of all classes.
            // Thus, we can add any object to this list, which isn't type safe, and should be avoided:
            list.Add(1);
            list.Add(23.4); // Boxing is happening here, because 23.4 is being converted to an "object".
            list.Add("Gabriel"); // Boxing doesn't happen here, because strings are reference type.
            list.Add(DateTime.Today); // DateTime is a struct, which is a value type, so boxing happens here.

            // var forbidden = (int)list[2]; // This will crash on runtime, because "Gabriel" cannot be converted to an integer.
            var convertedDOuble = (double)list[1]; // Unboxing is happening here, because 23.4 is being converted back to a double.

            // If we work with a generic class, such as a "List", boxing and unboxing doesn't happen. We also get type safety:
            var anotherList = new List<int>();
            anotherList.Add(1);
            anotherList.Add(2);
            anotherList.Add(5);
            anotherList.Add(4);
        }
    }
}
```

## Method overriding

In C#, we use the `override` and `virtual` keywords to override methods.

The `virtual` keyword is used in the method to be overridden, whereas the `override`, is used in the actual overridden method from the child class.

The keyword should go **in between the access modifier and the return type**.

Another difference is that we use the `base` keyword to call to parent method, instead of `super`. And, just like in Java, we don't actually need to call the base method if we don't want to.

Example for the classes `Canvas`, `Shape`, `Circle`, which inherits from `Shape`, and `Rectangle`, which also inherits from `Shape`.

`Canvas`:

```cs
using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class Canvas
    {
        private readonly List<Shape> _shapes = new List<Shape>();

        // With polymorphism, the list of shapes can contain any class that's derived from it:
        public void DrawShapes()
        {
            foreach (var shape in _shapes)
            {

                // Thus, we can simply call the Draw() method that will be overridden in all of the classes inheriting from shape:
                shape.Draw();
            }
        }
        public void AddShapeToCanvas(params Shape[] shapesParameter)
        {
            foreach (var shapeParameter in shapesParameter)
            {
                _shapes.Add(shapeParameter);
            }
        }
        public void PrintShapesInCanvas()
        {
            Console.WriteLine("We currently have:");
            foreach (var shape in _shapes)
            {
                Console.WriteLine($"A {shape.GetType().Name}");
            }
            Console.WriteLine("In the canvas.");
        }
    }
}
```

`Shape`:

```cs
using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class Canvas
    {
        private readonly List<Shape> _shapes = new List<Shape>();

        // With polymorphism, the list of shapes can contain any class that's derived from it:
        public void DrawShapes()
        {
            foreach (var shape in _shapes)
            {

                // Thus, we can simply call the Draw() method that will be overridden in all of the classes inheriting from shape:
                shape.Draw();
            }
        }
        public void AddShapeToCanvas(params Shape[] shapesParameter)
        {
            foreach (var shapeParameter in shapesParameter)
            {
                _shapes.Add(shapeParameter);
            }
        }
        public void PrintShapesInCanvas()
        {
            Console.WriteLine("We currently have:");
            foreach (var shape in _shapes)
            {
                Console.WriteLine($"A {shape.GetType().Name}");
            }
            Console.WriteLine("In the canvas.");
        }
    }
}
```

`Circle`:

```cs
using System;

namespace Polymorphism
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("In this case, a circle.");
        }
    }
}
```

`Rectangle`:

```cs
using System;

namespace Polymorphism
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("In this case, a rectangle.");
        }
    }
}
```

Finally, the `Main()` method:

```cs
using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(); // Of type Circle, not Shape.
            var rectangle = new Rectangle(); // Of type Rectangle, not Shape.
            var canvas = new Canvas();
            canvas.AddShapeToCanvas(circle, rectangle);
            canvas.PrintShapesInCanvas();
            Console.WriteLine();
            canvas.DrawShapes();
        }
    }
}
```

Which prints:

```
We currently have:
A Circle
A Rectangle
In the canvas.

Drawing a shape.
In this case, a circle.
Drawing a shape.
In this case, a rectangle.
```

We see here that the `Draw()` method, which carries the `virtual` keyword, is being overridden in both `Circle` and `Rectangle`. And through polymorphism, these overridden methods are being called in the `Canvas` class, inside the list of `Shape` types.

## Abstract classes and members

In C#, we use the `abstract` keyword for abstract classes and its members, just as in Java. These class can also have non-abstract members.

Thus, **we don't use the `virtual` keyword anymore for methods to be overridden, in abstract classes**, but we still use `override` when implementing the abstract methods, just like Java.

A difference from Java is that we don't have any `extends` or `implements` keyword here, we just use the colon, like in inheritance (`:`).

Using the same example for [method overriding](#method-overriding), but declaring `Shape` and its `Draw()` method as `abstract`:

`Shape`:

```cs
namespace Polymorphism
{
    public abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            System.Console.WriteLine("Common copy method across all shape classes.");
        }
    }
}
```

`Rectangle`:

```cs
using System;

namespace Polymorphism
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }
}
```

`Circle`:

```cs
using System;

namespace Polymorphism
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }
}
```

Since `Canvas` and the `Main()` method remain unchanged, executing the code gives us:

```
We currently have:
A Circle
A Rectangle
In the canvas.

Drawing a circle.
Drawing a rectangle.
```

Notice that the properties didn't have to be implemented, nor declared as abstract, **but they totally could've if we wanted to**. In this case, we would have to implement `get` and `set` for a property, thus, we would need to create a field as well, since we can't implement these methods for an auto-implemented property.

In the .NET Framework, we have the class `System.IO.Stream` as an abstract class.

## Sealed classes and members

This are the opposite of derived classes. The keyword `sealed` **prevents other classes from inheriting it**.

We can also apply this to specific class members to **prevent any class derived from a base one to override that method**.

But, note that **`sealed` can only be applied to methods that already are overridden in the first place**. This means that applying `sealed` to a method that doesn't overrides any other, the code won't compile.

Example from the [official documentation](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed):

```cs
class X
{
    protected virtual void F() { Console.WriteLine("X.F"); }
    protected virtual void F2() { Console.WriteLine("X.F2"); }
}

class Y : X
{
    sealed protected override void F() { Console.WriteLine("Y.F"); }
    protected override void F2() { Console.WriteLine("Y.F2"); }
}

class Z : Y
{
    // Attempting to override F causes compiler error CS0239.
    // protected override void F() { Console.WriteLine("Z.F"); }

    // Overriding F2 is allowed.
    protected override void F2() { Console.WriteLine("Z.F2"); }
}
```

Why do we need `sealed`? The documentation says that sealed classes are slightly faster at runtime, but it's not really worth using it, since it makes the code less readable and harder to understand for the sake of a tiny optimization gain.

## Interfaces

They are declared and work just like in Java. Here we append `I` to every interface, as opposed to Java.

That's not taught in the Java course, but interfaces help improve testability.

We use the colon (`:`) notation in a class that implements the interface.

Example:

```cs
namespace Interfaces
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
}
```

And:

```cs
using System;

namespace Interfaces
{
    internal class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }
            return 0;
        }
    }
}
```

Interfaces are a very good solution to help [unit testing](#unit-test-project) and tool extensibility.

For tool extensibility, we have the following example: we want to create a tool for migrating a database. We can extend any tool by adding new classes, instead of messing with the ones that already exist, to change the behavior of our system.

In practice, the cost of making everything extensible is, sometimes, costly, and not worth it. But we should always try to achieve such looseness.

This is also called **OCP**, or **Open Closed Principle**, in software engineering, which states tha a software should be *open for extensions, but closed for modification*.

The example:

`DbMigration.cs`

```cs
using System;

namespace Interfaces
{
    public class DbMigrator
    {
        private readonly ILogger _logger;


        // Dependency injection: we specify the dependencies inside the constructor for the DbMigrator class.
        // Later we create the concrete class to deal with the dependencies:
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo($"Migration started at {DateTime.Now}");
            // We would implement the migration here.
            _logger.LogInfo($"Migration finished at {DateTime.Now}");

        }
    }
}
```

`ILogger.cs`:

```cs
namespace Interfaces
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}
```

`ConsoleLogger.cs`:

```cs
using System;

namespace Interfaces
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red; // Changing the property color of the console log to red.
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Changing the property color of the console log to blue.
            Console.WriteLine(message);
        }
    }
}
```

`FileLog.cs`:

```cs
using System.IO;

namespace Interfaces
{
    public class FileLogger : ILogger
    {

        private readonly string _path;

        // Dependency injection here as well:
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        public void Log(string message, string messageType)
        {
            // Class System.IO.StreamWriter to write files. We give in the path and if values written to it should be appended or not.
            // Since StreamWritter uses a file resource, which is not managed by CLR, we need to dispose of it when we done using it.
            // That can be achieved by using the "using ()" block. This is similar to Python's "with open()".
            // This is the same as just using "streamWriter.Dispose()":
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine($"{messageType}: {message}");
            }
        }
    }
}
```

And `Program.cs`:

```cs
namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger()); // Completing the dependency injection.
            // var dbMigrator = new DbMigrator(new FileLogger("path/to/a/.txt")); // Also works. Also completes the dependency injection.
            dbMigrator.Migrate();
        }
    }
}
```

In this example, we can extend the logging system as long as we want to. With dependency injection injecting an interface, instead of a class, in `DbMigrator`, we extend the code without having to change any other classes.

Just like in Java, a class can implement multiple interfaces, but **be aware**: this is not the same as multiple inheritance, since this isn't available in C#.

People tend to confuse multiple implementation with multiple inheritance, since the notation to implement an interface and to inherit a class is the same, the colon (`:`).

This is specially confusing, because we can also inherit from a class and implement multiple interfaces, and we just use a colon (`:`).

To do a multiple implementation (and optionally, one inheritance), we separate the interfaces (and class) with a comma. For example:

```cs
...
public class TextBox : UiControl, IDraggable, IDroppable
...
```

Where `UiControl` is the class and the rest are interfaces.

A final note on this topic, **interface states a contract with the class that implements it, where as inheritance is used for code reusability**.

Since interfaces provide polymorphic behavior, as seen in the dependency injection in `DbMigration.cs` and `FileLog.cs`

## Attributes

Attributes are just tags, or decorators. They are metadata about our classes and their members. they don't have any logic, they are just markers.

With them, another application or assembly can read this metadata and do something about it.

One example is the `[SerializeField]` attribute [used in Unity](https://github.com/gagibran/learning-game-dev/tree/dev/unity-2d#scriptable-objects).

## Generics

Since this was poorly covered in the Java course, I added this section.

Just like in Java, we use a generic class to solve the problem where the data type is a variable. We could create a generic class and use `object` as the data type, since all classes inherit from it, but the performance of its methods would be penalized, because of [boxing and unboxing](#boxing-and-unboxing).

With generics, we create a class once and use it multiple times.

Just like Java, we use `T` as the generic type at declaration. To improve readability, when we have more than one generic type a declaration, we can name them properly, instead of just using capital letters, like `TKey`, `TValue` and so on.

Example of a generic class:

```cs
using System;

namespace Generics
{
    public class GenericList<T>
    {
        public void Add(T value)
        {
            // Do something.
        }

        public T this [int index]
        {
            // Indexer that does something.
        }
    }

    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
    }
}
```

And in the `Main()` method:

```cs
using System;

namespace Generics
{
    class Program
    {
        public void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "C# Advanced" }

            var numbers = new GenericList<int>();
            numbers.Add(10);
            var books = new GenericList<Book>();
            books.Add(book);
        }
    }
}
```

In practical terms, we will be **using** generic classes instead of creating them, since generic lists normally implement data structure, such as linked lists, array lists and so on.

In .NET, we have the `System.Collections.Generic` namespace, with a bunch of generic collections, such as lists, dictionaries, and hashed maps.

A dictionary is a data structure that uses hashed tables to store keys and values, just like a [Python dictionary](https://docs.python.org/3/tutorial/datastructures.html#dictionaries).


Like in Java, we can also limit the data types passed as parameters to a generic class:

```cs
using System;

namespace Generics
{
    public class Utilities
    {
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a > b ? a : b;
        }
    }
}
```

Note here that we actually don't need to make the whole class generic, we can just make a method generic.

In Java, we [use the `extends` keyword to do bounding](https://github.com/gagibran/learning-java#generic-class). Here, just like with [inheritance](#inheritance), we use the `where` keyword and a colon (`:`) to limit `T`'s types. And just like in Java, we can bound one class and multiple interfaces to a type, but here, we separate them with a comma.

We can also constrain to a **value type**, by limiting it to a [struct](#structs).

In this example, since value types cannot be null, we're creating a generic class **that only accepts value types** (hence the `where T : struct`) and giving them the ability to be null:

```cs
using System;

namespace Generics
{
    public class Nullable<T> where T : struct
    {
        private object _value;

        // Default constructor, in case "_value" isn't set.
        public Nullable()
        {
        }

        public Nullable(T value)
        {
            _value = value; // Converting a value type to a reference type, so that it can be nullable.
        }

        public bool HasValue
        {
            get { return _value != null; } // Returns true if the value passed in the constructor is not null.
        }

        // If the value passed in the constructor is not null, we return its nullable type:
        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_value; // Since "_value" is an object, we're casting it back to the generic type.
            }
            return default(T);
        }
    }
}
```

Here we're using the `default()` keyword, which returns the default value of that data type, when it hasn't been initialized. For example, the default of a boolean is `false` and the default of an integer is `0`.

In `Main()`:

```cs
using System;

namespace Generics
{
    class Program
    {
        public void Main(string[] args)
        {
            var number = new Nullable<int>(5);
            Console.WriteLine($"Does it have value? {number.HasValue}."); // In this case, it's true.
            Console.WriteLine($"The value: {number.GetValueOrDefault()}."); // In this case, it's 5.

            var anotherNumber = new Nullable<int>(); // Here, no value has been passed, but the data type is an integer.
            Console.WriteLine($"Does it have value? {number.HasValue}."); // In this case, it's false.
            Console.WriteLine($"The value: {number.GetValueOrDefault()}."); // In this case, it's 0.
        }
    }
}
```

This example seems rather odd, but if we try to write a program like:

```cs
namespace Generics
{
    class Program
    {
        public void Main(string[] args)
        {
            var number;
            Console.WriteLine(number);
        }
    }
}
```

It wouldn't compile, stating that we're making `use of unassigned local variable`. With this `Nullable` class, we're able to make it default to it's default value when a value type is not initialized.

This class is actually a structure, part of the .NET framework, in `System.Nullable<T>`.

Moving on, we can also make a generic type be bounded to a **reference type**, using `class` instead of `struct`.

Finally, it's also possible to constrain a generic type to a **default constructor**, using `new()` in its declaration:

```cs
using System;

namespace Generics
{
    public class Utilities<T> where T : IComparable, new()
    {
        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }
}
```

In this example, we wouldn't be able to call `DoSomething()` if our generic type was bounded only to `IComparable`, because interfaces don't have default constructors. To solve this problem, we bound it to an anonymous constructor as well using the `new()` keyword. Thus, we can make it `T` a class with a constructor right now.

## Delegates

A delegate is an object that knows how to call a method, or a group of methods. It's a reference to a function.

Why do we need delegates calling methods for us? For designing extensible and flexible applications. For example, frameworks.

In the following example of a photography processor framework:

`Photo.cs`:

```cs
namespace Delegates
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {
        }
    }
}
```

`PhotoProcessor.cs`:

```cs
namespace Delegates
{
    public class PhotoProcessor
    {
        public void Process(string path)
        {
            Photo photo = Photo.Load(path);

            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }
    }
}
```

`PhotoFilters.cs`:

```cs
using System;

namespace Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness.");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast.");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo.");
        }
    }
}
```

And `Program.cs`, acting like the client of this code:

```cs
namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var processor = new PhotoProcessor();

            processor.Process("photo.jpeg");
        }
    }
}
```

Which prints:

```
Apply brightness.
Apply contrast.
Resize photo.
```

There is a problem with this code: it's not extensible. If someone else wanted to apply more filters in the processing workflow, they would have to manually create the filter in `PhotoFilters`, apply this filter in `PhotoProcessor`, recompile, and redeploy the code, when they should only be dealing with the `Main()` method.

With delegates, we can make this code extensible: a developer can create a new filter without relying on us. [Interfaces](#interfaces) also solve this problem, with polymorphism. Later we'll discuss when to use delegates or interfaces.

To use delegates, first we need to declare a delegate type in `PhotoProcessor`:

```cs
namespace Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            Photo photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
```

We defined the delegate type using the `delegate` keyword, `PhotoFilterHandler`, defined the signature of the methods that will call it as `void`, and specified that a delegate should have a `Photo photo` parameter. So, an instance of the delegate can hold a pointer to a function or a group of functions with the same signature.

Now, `Process` doesn't know what kind of filters will be applied, it's not its responsibility anymore. We specified another argument to it, which is an instance of the delegate, `PhotoFilterHandler filterHandler`. `filterHandler` acts like a function to handle the filter applied to this photo.

It's the responsibility of `Main()` to apply the filters, the client class. There, we assign the delegate to a method within our framework:

```cs
namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;

            processor.Process("photo.jpeg", filterHandler);
        }
    }
}
```

This prints:

```
Apply brightness.
```

We instantiated `PhotoFilters`, to have access to its methods, then, we created the delegate function `filterHandler`, which is of type `PhotoProcessor.PhotoFilterHandler` (the delegate), and we passed this function as an argument to `Process`.

Now, every time we want to apply a new filter to the processor, we just have to assign another method from `filters` to `filterHandler`.

To apply more filters to the photo, we can use the overloaded operator `+=`, since delegates can also point to a group of functions:

```cs
namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;

            processor.Process("photo.jpeg", filterHandler);
        }
    }
}
```

Now, this prints:

```
Apply brightness.
Apply contrast.
Resize photo.
```

To create more filters, we can simply create more methods with the same signature (return type and arguments) of our delegate. They can be created anywhere, even in the `Program` class:

```cs
namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += IncreaseRedness;

            processor.Process("photo.jpeg", filterHandler);
        }

        public static void IncreaseRedness(Photo photo)
        {
            Console.WriteLine("Redness increased.");
        }
    }
}
```

Which prints:

```
Apply brightness.
Apply contrast.
Resize photo.
Redness increased.
```

In conclusion, we added a new filter without having to touch any classes within the framework.

**What happens under the hood?** Every delegate that's created is essentially a class, derived from `System.Multicast.Delegate`, which is derived from `System.Delegate`, which has two properties, a method (the method that the delegate is pointing to) and a target (the class the holds that method).

`System.Multicast.Delegate` allows us to have pointers to multiple functions. When we use this functionality, the delegate will have a field called `_invocationList`, which holds the group of methods.

When we point to only one method, it's using `System.Delegate`.

In the example above, our delegate is of type `System.Multicast.Delegate`, since it's pointing to a group of methods.

In .NET, we have to generic delegates: `System.Action<T>` (which also has its non-generic form, `System.Action`), that has 16 overloads, making it possible to point up to 16 methods, and `System.Func<T>`, which also has overloads that allows us to point up to many functions.

The difference between these two is that `Func<T>` points to a method that returns a value, whereas `Action` points to void methods.

`Func<T>` normally takes two or more data type parameters: the first one(s) is the data type(s) of the method's parameter(s), and the second (or method's number of arguments plus one) is the return type of the method, making it `Func<T, U, V, ...>`.

Since these two already exist, we don't have to go on and create multiple delegates ourselves.

Changing `PhotoProcessor` to use `System.Action<T>`:

```cs
using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        public void Process(string path, Action<Photo> filterHandler)
        {
            Photo photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
```

Now, we can pass to `Process` any delegates of type photo that return void, which is the same signature that we had for our methods in `PhotoFilters` and in `Program`, instead of `PhotoProcessor.PhotoFilterHandler`, we use `Action<Photo>` to instantiate the delegate:

```cs
using System;

namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += IncreaseRedness;

            processor.Process("photo.jpeg", filterHandler);
        }

        public static void IncreaseRedness(Photo photo)
        {
            Console.WriteLine("Redness increased.");
        }
    }
}
```

Another use case of delegate functions is for **predicates**, which is a delegate to a function that returns a boolean. For example, in `System.Generics`, we have the `FindAll()` method. This methods returns all the matches that satisfy the predicate's condition.

For example, imagine that we have a list of `Book`s

```cs
...
public bool IsCheaperThan10Dollars(Book book)
{
    return book.Price < 10;
}
...
```

This method can be used as a predicate to `FindAll`:

```cs
...
books.FindAll(IsCheaperThan10Dollars);
...
```

This will return all book within this list that have their prices smaller than 10 dollars.

Notice that we didn't have to pass in any parameters to the predicate, because they **have to** be of type `Book`.

To wrap it up, **a delegate is an object that knows how to call a method, or a group of methods. They are used to achieve extensibility and flexibility within a framework**.

How do we decide when to use interfaces or delegates? In part, it comes down to personal preference, but according to the [official documentation](https://docs.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2010/ms173173(v=vs.100)), we use delegates when an [eventing](#events) design pattern is used, or when the caller doesn't need to access other properties or methods on the object implementing the method.

## Lambda expressions

A lambda expression is an **anonymous method**: it has no access modifier, no name, and no return statement.

Why are they used? For convenience. We can write less code and achieve the same thing. This can aso make our code more readable.

For example, typically this is how we'd write a method that takes a number and returns the square of it:

```cs
using System;

namespace LambdaExpressions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Square(5)); // Prints 25.
        }
        public static int Square(int number)
        {
            return number * number;
        }
    }
}
```

Writing the same code with lambda expressions:

```cs
namespace LambdaExpressions
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // args => expression:
            number => number * number;
        }
    }
}
```

Here we have the arguments, the lambda operator (`=>`), and some expression. We read this as **args goes to expression**. We didn't have to specify a return type, an access modifier, or a return statement; the compiler does that for us.

In this example, we read: **number goes to number times number**.

What do we do with this expression? We assign it to a [delegate](#delegates). In this case, we need to use `Func<T>`, since the lambda expression returns an integer:

```cs
using System;

namespace LambdaExpressions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Func<int, int> square = number => number * number;

            Console.WriteLine(square(5)); // Which prints 25.
        }
    }
}
```

What is happening here: We instantiated the delegate `Func<int, int>`, which points to functions that have an integer parameter and return an integer and, instead of creating a method for it, like we did with `Square()`, we assign it to a lambda expression, that takes a number and goes to the number times itself.

If we don't need any arguments in a lambda expression, we can write it like so `() => ...`. If we have more than one parameters, we have to enclose them in parenthesis: `(x, y, z) => ...`.

In terms of scope, the lambda expression has access to any parameters passed to it and within the scope that it finds itself. For example:

```cs
using System;

namespace LambdaExpressions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            
            Console.WriteLine(multiplier(10)); // Prints out 50.
        }
    }
}
```

Some common use cases of lambda expressions are for predicates. For example, instead of passing a delegate function to `FindAll()` in `System.Generics`, we can just call a lambda expression there. This situation:

```cs
...
public bool IsCheaperThan10Dollars(Book book)
{
    return book.Price < 10;
}
...
```

```cs
...
books.FindAll(IsCheaperThan10Dollars);
...
```

Becomes this one:

```cs
books.FindAll(book => book.Price < 10);
```

Removing the necessity of having to create `IsCheaperThan10Dollars()`.

In C#, it's common to use a single letter to denote the argument of a lambda expression. In the example above, since it's obvious that what's inside `FindAll()` has to return a `Book` object, we can rewrite the argument as `b`:

```cs
books.FindAll(b => b.Price < 10);
```

## Events

Events are a mechanism for communication between objects. They are used in building loosely coupled applications, and they help extend applications.

When something happens inside an object, it can notify other objects about that.

The objects that send an information **publish** message, thus it's called a **publisher**, which will be receive by the objects subscribed to the event publisher, or the **subscribers**.

The publisher class knows absolute nothing about its subscribers, making their relationship loosely coupled.

For a `VideoEncoder` class example, can publish events to any classes that are subscribed to it, such as a `MailService`, or a `MessageService`. If we wanted to create more classes to deal with messaging (extend the application), `VideoEncoder` would not be affected in any way.

To implement this, we could create a `OnVideoEncoded()` method that deals with notify any subscribers. This method is a signature, or a contract, that both publisher and its subscribers have in common. This methods are often called **event handlers**.

Example:

```cs
...
public void OnVideoEncoded(object source, EventArgs e)
{
}
```

This method is called by the publisher when the event is raised. This means that this method is also present in its subscribers, in this, `MailService` and `MessageService`.

How do we tell the `VideoEncoder` what method to call? That where [delegates](#delegates) come in, since they are this agreement between the publisher and subscriber.

We can have a delegate that determines when a video is encoded.

Example:

`Video.cs`:

```cs
namespace Events
{
    public class Video
    {
        public string Title { get; set; }
    }
}
```

`VideoEncoder.cs`:

```cs
using System;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {

        // 1 - Define a delegate:
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        // 2 - Define an event based on that delegate:
        public event VideoEncodedEventHandler VideoEncoded;

        // 3 - Raise, or publish, the event:
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000); // Simulates the encoding process.
            Console.WriteLine("Done.");
            OnVideoEncoded();
        }
    }
}
```

`Program.cs`:

```cs
namespace Events
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();

            videoEncoder.Encode(video);
        }
    }
}
```

Which prints:

```
Encoding video...
Done.
```

With a 3 seconds delay between the messages.

So, there are three steps to create events:

In the first one, we declared a delegate called `VideoEncodedEventHandler()` to deal with the publishing. It's common practice in C# to declare a publisher with arguments as `object source` and `EventArgs args` or `e`, which is basically any additional data that we want to send with the event. Another convention is to name the delegate as the name of the event (`VideoEncoded`) appended with `EventHandler`.

`EventArgs` is a class within `System`. Here's it's [official documentation](https://docs.microsoft.com/en-us/dotnet/api/system.eventargs?view=net-5.0).

In the second one, when we declare the event, we used the keyword `event` and named it in the past sentence, because it will be called when the video has just finished encoding.

In the third step, we created a method to publish the event. It's a convention to have it as protected and void. In terms of naming convention, they should start with the word `On` and be appended with name of the event. We used the `virtual` keyword here because `MailService` and `MessageService` will override it.

In the publisher method, we start by checking if there are any subscribers (`VideoEncoded != null`). If there are, we treat the event `VideoEncoded` as a method with the signature defined by the delegate, so, `VideoEncoded(object source, EventArgs args)`.

In our case, what is the source of the event (who's publishing it)? It's the instantiated object itself, thus, we use `this` for the source. Since we don't want to send any additional data with our event, we'll just use the read-only field `Empty` within `System.EventArgs`. This property returns an instance of `EventArgs`, which is empty.

Now, in the `Encode()` method, we can call `OnVideoEncoded()` when the encoding is done.

Let's crate the subscribers `MailService` and `MessageService`:

`MailService.cs`:

```cs
namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService: Sending an e-mail...");
        }
    }
}
```

And `MessageService.cs`:

```cs
namespace Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MessageService: Sending a message...");
        }
    }
}
```

We just had to override `OnVideoEncoded()`. These classes don't even have to inherit `VideoEncoder.cs`.

Now, in `Main()` we create the subscribers:

```cs
namespace Events
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // Publisher.
            var mailService = new MailService(); // Subscriber.
            var messageService = new MessageService(); // Subscriber.

            // Creating subscriptions:
            videoEncoder.VideoEncoded() += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded() += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
```

Which prints:

```
Encoding Video...
Done.
MailService: Sending an e-mail...
MailService: Sending a message...
```

With a delay of 3 seconds between `Encoding Video...` and `Done.`.

When creating the subscriber, we used the `+=` operator to determine the handler on both `MailService` and `TextService`.

Note that we're not making any calls to the methods (hence the lack of parenthesis when calling `mailService.OnVideoEncoded;` and `messageService.OnVideoEncoded`). We're just **referencing** them.

So, `videoEncoder.VideoEncoded` is just a list of subscribers. Thus, when `videoEncoder.Encode(video)` calls `OnVideoEncoded()`, `VideoEncoded` will, in fact, not be null, and will publish the event to the subscriber.

Now, we can create as many messaging classes as we want to, without changing the publisher.

In this next step, we'll be sending additional data to the subscribers with the event. To do that, we need to create a custom class that inherits from `EventArgs`:

```cs
namespace Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
```

Now, in our delegate in `VideoEncoder.cs`, we change the `EventArgs args` to `VideoEventArgs`. Since `OnVideoEncoded` expects the signature that comes from the delegate, we also change the event that it sends to `VideoEventArgs` and call this class in `OnVideoEncoded()`.

Notice that now we have to pass a `Video video` object to the publisher method, so that we can assign the property `VideoEventArgs.Video`. This property will be sent to the subscribers as well.

```cs
using System;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {

        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); // Changed here.

        public event VideoEncodedEventHandler VideoEncoded;

        protected virtual void OnVideoEncoded(Vide video) //Changed here.
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video }); // Changed here.
            }
        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            Console.WriteLine("Done.");
            OnVideoEncoded(video); // Changed here.
        }
    }
}
```

Now, in `MailService` and in `TextService`, we need to change `OnVideoEncoded()` to comply with their virtual method:

`MailService.cs`:

```cs
namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: The video \"{e.Video.Title}\" is ready. Sending an e-mail...");
        }
    }
}
```

And `MessageService.cs`:

```cs
namespace Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MessageService: The video \"{e.Video.Title}\" is ready. Sending a message...");
        }
    }
}
```

When we run `Main()`, we get:

```
Encoding Video...
Done.
MailService: The video "Video 1" is ready. Sending an e-mail...
MessageService: The video "Video 1" is ready. Sending a message...
```

With a 3 seconds delay between `Encoding video...` and `Done.`.

In more recent versions of .NET, we can write this event system in a simpler way.

We don't actually need to create a new delegate every time we need to create a new event. Just as we have with `Func<>` and `Action`, we have `System.EventHandler` (and its generic form `System.EventHandler<TEventArgs>`):

```cs
using System;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {

        // We don't have to create a delegate explicitly, we can just use this class:
        public event EventHandler<VideoEventArgs> VideoEncoded;

        protected virtual void OnVideoEncoded(Vide video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            Console.WriteLine("Done.");
            OnVideoEncoded(video);
        }
    }
}
```

And to send an event without additional data, we use the normal form of `EventHandler`, not its generic:

```cs
using System;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {

        // We don't have to create a delegate explicitly, we can just use this class:
        public event EventHandler VideoEncoded;

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            Console.WriteLine("Done.");
            OnVideoEncoded();
        }
    }
}
```

We don't really need to create our own delegates, we can just use this class.

## Extension methods

They allow us to add methods to an existing class without changing its source code or creating a new class that inherits from it.

Using the [summarize a post](#default-or-optional-arguments) example:

```cs
...
public static string Summarize(string text, int length = 20)
{
    string[] words = text.Split(' ');
    var summary = "";
    foreach (var word in words)
    {
        if (summary.Length >= length)
        {
            break;
        }
        summary += word + " ";
    }
    return summary.Trim() + "...";
}
...
```

We could add this method to the `String` class, but since `String` is [sealed](#sealed-classes-and-members), we cannot make any classes inherit from it.

The solution to this is to use **extension methods**. Let's add this summarize method to `String`.

First, we create a static class (it's a convention). Its name should be `String` plus `Extensions` (also a convention).

Secondly, we write the extension methods. They are always public static as well. The first argument of this method should **always** be `this <class-we-are-extending> <name>`, it's a convention.

```cs
using System;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Summarize(this String str, int length = 20)
        {
            string[] words = str.Split(' ');
            var summary = "";
            foreach (var word in words)
            {
                if (summary.Length >= length)
                {
                    break;
                }
                summary += word + " ";
            }
            return summary.Trim() + "...";
        }
    }
}
```

We didn't have to change anything in the source code of the `String` class.

Now, in `Main()`:

```cs
using System;

namespace ExtensionMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string post = "This is a supposed to be a very long blog post blah blah blah...";
            Console.WriteLine(post.Shorten(5)); // This prints "This is a supposed to be..."
        }
    }
}
```

Notice that `this String str` here represents `post`. That's why we can call `Shorten()` in `post`.

Another key thing is that **the extension class should always be on the same scope of the object calling its methods**. If we were to change the namespace `ExtensionMethods` one of the classes `Program` or `StringExtensions` to another name, the extension wouldn't work anymore, unless we import the namespace with `using`, which is not good practice.

Thus, it's common practice to define the extension class in the same namespace of the class that we're extending from. In this case, `String` is defined in `System`:

```cs
namespace System
{
    public static class StringExtensions
    {
        public static string Summarize(this String str, int length = 20)
        {
            string[] words = str.Split(' ');
            var summary = "";
            foreach (var word in words)
            {
                if (summary.Length >= length)
                {
                    break;
                }
                summary += word + " ";
            }
            return summary.Trim() + "...";
        }
    }
}
```

Often we'll be using extension methods, instead of creating them.

## LINQ

It stands for **Language Integrated Query**, and it gives us the ability to query objects natively.

We can query objects in memory, like collections (LINQ to objects), databases (LINQ to entities), XML (LINQ to XML), and AD<span>O</span>.NET Datasets (LINQ to datasets).

Example that gets books that are less than 10 dollars:

`Book.cs`:

```cs
namespace StudyingLinq
{
    public class Book
    {
        public string Title { get; set; }
        public float Price {get; set; }
    }
}
```

`BookRepository.cs`:

```cs
using System.Collections.Generic;

namespace StudyingLinq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "Book 1", Price = 5 },
                new Book() { Title = "Book 2", Price = 9.99f },
                new Book() { Title = "Book 3", Price = 12 },
                new Book() { Title = "Book 4", Price = 7 },
                new Book() { Title = "Book 5", Price = 9 }
            };
        }
    }
}
```

And `Program.cs`:

```cs
using System;
using System.Collections.Generic;

namespace StudyingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new BookRepository().GetBooks();
            var cheapBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 10)
                {
                    cheapBooks.Add(book);
                }
            }

            foreach (var cheapBook in cheapBooks)
            {
                Console.WriteLine($"{book.Title}: {book.Price}"); // Prints "Book 1, 2, 4, and 5".
            }
        }
    }
}
```

Using LINQ, we can shorten this to:

```cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudyingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new BookRepository().GetBooks();
            List<Book> cheapBooks = books.Where(b => b.Price < 10);
            foreach (var cheapBook in cheapBooks)
            {
                Console.WriteLine($"{book.Title}: {book.Price}"); // Prints "Book 1, 2, 4, and 5".
            }
        }
    }
}
```

The `Where()` method is defined inside `System.Linq`, and it's an [extension method](#extension-methods) for `System.Collections.Generic`. It accepts a predicate filter, that we define as a [lambda expression](#lambda-expressions), which returns a `Book`, and returns a `List<Book>`.

LINQ also has `OrderBy()` and `OrderByDescending()` methods, which orders the books by a specific attribute, like `b => b.Title`, or `b => b.Price`. It also has a `Select()` method, which is useful for projections, or transformations.

Since these LINQ methods return a `List<Book>`, we can chain them:

```cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudyingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new BookRepository().GetBooks();
            var cheapBooks = books.Where(b => b.Price < 10)
                                  .OrderByDescending(b => b.Title)
                                  .Select(b => b.Title);
            foreach (var cheapBook in cheapBooks)
            {
                Console.WriteLine(book); // Prints "Book 5, 4, 2, and 1".
            }
        }
    }
}
```

Notice that `Where()` and `OrderByDescending()` return a list of `<Book>`, but `Select()` returns a list of `b.Title`, which is a string. Thus, `cheapBooks` is an `IEnumerable<string>`.

There is a syntax used to write these methods, which is called **LINQ Query Operators**. The same methods wrote in this syntax:

```cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudyingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new BookRepository().GetBooks();
            var cheapBooks = from b in books
                             where b.Price < 10
                             orderby b.Title descending
                             select b.Title;

            foreach (var cheapBook in cheapBooks)
            {
                Console.WriteLine(book); // Prints "Book 5, 4, 2, and 1".
            }
        }
    }
}
```

These operators always start with `from` and always finish with `select`. If we wanted to return a list of `Book`s instead of strings, we could've just use `select b` instead.

Note that there are not keywords for every extension method from LINQ. Thus, if the operation is complex, the other syntax is preferred.

Some other extension methods that are very useful are:

- `Single(b => b.Title == "Book 4")`: Returns only one `Book` object that matches that title, as opposed to `Where()`. If it doesn't exist, throws an `InvalidOperationException` stating that the match was unsuccessful;
- `SingleOrDefault(b => b.Title == "Book 8")`: If there isn't a match, returns the data type's default value (in this case, null for strings);
- `First(b => b.Title == "Book 2")`: Returns the first occurrence of the match and throws an `InvalidOperationException` if the match isn't successful. This method can also be used without predicates to return the first item on the list;
- `FirstOrDefault(b => b.Title == "Book 2")`: Similar to `SingleOrDefault()`, but for `First()`;
- `Last(b => b.Title == "Book 5")` and `LastOrDefault(b => b.Title == "Book 2")`: Similar to `First()` and `FirstOrDefault()`;
- `Skip(int i)` and `Take(int j)`: Skips `i` objects on the list and returns a list with the remaining `j`. Used to do pagination;
- `Max(b => b.Price)`: Returns the price of book that has the maximum price (`12` in this example, for `Book 3`);
- `Min(b => b.Price)`: Returns the price the book that has the minimum price (`5` in this example, for `Book 1`);
- `Sum(b => b.Price)`: Returns the sum of the prices (in this case, `42.99`);
- `Average(b => b.Price)`: Returns the average of the prices (in this case, `8.598`).

## Nullable types

Value types cannot be null, but there are situations where we would like them to be null. For example, when a form for a database, not all of its fields necessarily have to be filled. An example would be when creating an account in a website, we really just need to input username, password, and an e-mail. Normally, it's not required to input birthday, first name, last name etc.

We have actually created a nullable class when studying [generics](#generics), but to create a nullable type, we can use `System.Nullable<T>`:

```cs
using System;

namespace StudyingNullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<DateTime> date = null; // DateTime is a struct, therefore a value type.
            Nullable<bool> date = null;
            Nullable<int> date = null;
        }
    }
}
```

There is a shorter version of nullifying a value type, which is by appending a question mark on it declaration:

```cs
using System;

namespace StudyingNullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null; // DateTime is a struct, therefore a value type.
            bool? date = null;
            int? date = null;
        }
    }
}
```

Nullable types have some useful properties and methods, like `GetValueOrDefault()`, `HasValue()`, and `Value()`:

```cs
using System;

namespace StudyingNullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            Console.WriteLine($"GetValueOrDefault(): {date.GetValueOrDefault()}"); // Prints "1/01/0001 12:00:00 AM", which is the default value of a DateTime.
            Console.WriteLine($"HasValue(): {date.HasValue()}"); // Prints "False", because "date" hasn't been initialized yet.
            Console.WriteLine($"Value(): {date.Value()}"); // Throws InvalidOperationException, stating that a nullable object must have a value, because "date" hasn't been initialized yet.
        }
    }
}
```

`GetValueOrDefault()` is the preferred way of getting a value, since it assigns it to the default and doesn't throw an exception.

Another thing to keep in mind is that we cannot assign a nullable type to a non-nullable one, even if the nullable type is initialized. To make it compile we can call the `GetValueOrDefault()` method:

```cs
using System;

namespace StudyingNullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = new DateTime(2014, 1, 1);
            // DateTime date2 = date; // This throws an error, because the compiler won't know what to do if "date" is null.
            DateTime date2 = date.GetValueOrDefault(); // Now if the type is null, it will be assigned to its default value and the compiler knows what to do.
        }
    }
}
```

Assigning a non-nullable type to a nullable type is possible, naturally.

When dealing with nullables, we can use the **Null Coalescing Operator**. For example:

```cs
using System;

namespace StudyingNullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            DateTime date2;

            if (date != null)
            {
                date2 = date.Value();
            }
            else
            {
                date2 = DateTime.Today();
            }
        }
    }
}
```

In this example, since `date` is null, `date2` will be converted to `DateTime.Today()`. We can rewrite this code using the Null Coalescing Operator like so:

```cs
using System;

namespace StudyingNullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            DateTime date2 = date.Value() ?? DateTime.Today(); // If "date" has a value, assigns "date2" to it. Otherwise, if "date" is null, assigns "date2" to "DateTime.Today()".
        }
    }
}
```

This is similar to the ternary operator: `DateTime date2 = (date != null) ? date.Value() : DateTime.Today();`.

## Dynamic

C# is a statically typed language, just like Java, whereas other languages, like Python and JavaScript, are dynamically typed.

The difference is that in statically typed languages, the resolution of types, members, properties, methods, and so on, is done at compile-time. So, if we try to access a method that's not defined in an object, for example, we immediately get a feedback when we compile the application, stating that that method isn't present in that object.

In dynamically typed languages, the resolution of types, members, properties, methods and, so on, is done at runtime. They are a little bit easier and faster to code with, but we have to run more unit tests to make sure that the application will run properly at runtime, since we don't need to compile them.

C# started as a statically typed language, but as of .NET 4, it's been added dynamic capabilities to the language.

For example, let's suppose we're developing Excel, and that it has a method called `Optimize()` that's only present at runtime. If we wrote the code lie so:

```cs
using System;

namespace StudyingDynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            object excelObject = "whatever";
            excelObject.Optimize(); // Won't compile.
        }
    }
}
```

This code wouldn't compile, because this method is not defined at compilation time. We can use the keyword `dynamic` instead:

```cs
using System;

namespace StudyingDynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic excelObject = "whatever";
            excelObject.Optimize(); // Now it compiles.
        }
    }
}
```

In .NET 4, we have **DLR**, which stand for **Dynamic Language Runtime**. It sits on top of CLR and this is what gives dynamic capabilities to C#.

Another example, which is what we do in Python:

```cs
using System;

namespace StudyingDynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic number = 11;
            number = "11";
        }
    }
}
```

Here, `number` is being dynamically converted into a `string`. If we inspect `number`, we can see the type changing in real time.

Since this:

```cs
using System;

namespace StudyingDynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic number = "11";
            number++;
        }
    }
}
```

Breaks the code, but we only see it at runtime, we have to make more unit tests to make sure that we're bug free.

Since the `var` keyword tells the compiler to decide the data type at compile-time, if we add two dynamic numbers, for example, into a third number variable declared with `var`, the compiler will assign `var` to `dynamic`.

## Exception handling

We use a `try` and `catch` block to handle exceptions. An exception is essentially a class.

Example:

```cs
using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number:");
            string num = Console.ReadLine();

            try
            {
                Convert.ToDouble(num);
            }
            catch (Exception e)
            {

                Console.WriteLine("An exception has occurred.");
                Console.WriteLine();
                Console.WriteLine($"Here it is: {e}");
                Console.WriteLine();
                Console.WriteLine("Terminating the program now.");
            }
        }
    }
}
```

Here, if we type a string that cannot be converted into a double, we get the following output:

```
Write a number:
sdf
An exception has occurred.

Here it is: System.FormatException: Input string was not in a correct format.
   at System.Number.ThrowOverflowOrFormatException(ParsingStatus status, TypeCode type)
   at System.Convert.ToDouble(String value)
   at ExceptionHandling.Program.Main(String[] args) in C:\Users\gibra\Desktop\Projetos\learning-game-dev\csharp\exercises\ExceptionHandling\Program.cs:line 14

Terminating the program now.
```

Note that the program exits without errors (`0`), because the exception has been handled.

The `System.Exception` class is the parent of all exceptions in C#, thus, `e` is a polymorphic variable, that suits all exceptions that may happen to our program. This base class has a property called `Message` which just displays the custom message that we gave it, without actually displaying the stack trace (which is also another property called `StackTrace`)

We can have multiple catch blocks to deal with different exceptions. In this block, the exceptions have to be handle from most specific to more generics. For example:

```cs
using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine(num / num2);
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("Cannot dive by 0.");
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("An arithmetic exception has occurred.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception has occurred.");
                Console.WriteLine(ex);
            }
        }
    }
}
```

If we input `2` and `0` we get:

```
2
0
Cannot dive by 0.
Attempted to divide by zero.
```

Now we didn't get the stack for `System.DivideByZeroException`.

As previously said, some processes in C# are not managed by the CLR, thus they don't have garbage collection. Examples are file handles, database connections, database collections etc. We need to manually clean these resources by implementing `IDisposable`. There, we have to implement a method called `Dispose()`, which:

>Defines a method to release allocated resources.

To call a `Dispose()` method from a class that uses manage resources, we can use the `finally` block, which gets executed no matter if `try` works or not:

```cs
using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            var streamReader = new StreamReader(@"C:\Users\gibra\Desktop\Projetos\learning-game-dev\csharp\exercises\ExceptionHandling\test.txt");

            try
            {
                streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception has occurred here:");
                Console.WriteLine(ex);
            }
            finally
            {
                streamReader.Dispose(); // If we don't manage this properly, the file will be opened on the disk, consuming RAM.
            }
        }
    }
}
```

A better way to write this code specifically is to use the `using ()` statement, as seen in the example in [interfaces](#interfaces), since `using ()` calls `Dispose()` from internally:

```cs
using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var streamReader = new StreamReader(@"C:\Users\gibra\Desktop\Projetos\learning-game-dev\csharp\exercises\ExceptionHandling\test.txt"))
                {
                    Console.WriteLine(streamReader.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception has occurred here:");
                Console.WriteLine(ex);
            }
        }
    }
}
```

As a guideline, we should always have a global exception handling block in our applications. In a console application, the entry point of the app is the `Main()` method, so, it should be there.

Moving on, to create a custom exception, we must inherit from `System.Exception`:

```cs
using System;

namespace ExceptionHandling
{
    public class CustomException : Exception
    {
        public CustomException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
```

An that's pretty much it. We can call this exception using the `throw` keyword somewhere in our code, passing a message to it, like we'd normally do. We can pass another exception as the second argument, to give the user more information of what's going on.

## Asynchronous programming

In the synchronous program execution model, a program is executed line by line, one at a time. When a function is called, program execution has to wait until the function returns.

In asynchronous programming, when a function is called, the program execution continues to the next line **without** waiting for the function to complete.

We normally provide a callback function to an asynchronous one, so that when the execution is complete, we invoke that function. The program runs more smoothly like that, improving responsiveness on our app.

Some examples are: WIndows Media Player, or our web browser. We can play a media, or access a site while resizing the window, move around etc. Without asynchronous, we would have to freeze the video in order to rise the window, for example.

We use asynchronous programming when we have a blocking operation, such as accessing the web, dealing with files and databases, dealing with images and so on.

How do we do that? Traditionally, we needed to use multi-threading or callback methods. With .NET 4.5 we can use the `async` and `await` keywords, which is called **task based asynchronous model**.

Let's exemplify this with a WPF application:

`MainWindow.xaml`:

```xml
<Window x:Class="AsyncWpf.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:AsyncWpf"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
        <Button Content="Button" HorizontalAlignment="Center" Margin="0,175,0,217" Width="236" Click="Button_Click_1"></Button>
    </Grid>
</Window>
```

`MainWindow.xaml.cs`:

```cs
using System.IO;
using System.Net;
using System.Windows;

namespace AsyncWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url); // Gets the HTML from the URL.
            using (var streamWriter = new StreamWriter(@"C:\Users\gibra\Desktop\Projetos\learning-game-dev\csharp\exercises\AsyncWpf\result.html"))
            {

                // Saves the HTML of the URL in "result.html":
                streamWriter.Write(html);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DownloadHtml("https://www.google.com/");
        }
    }
}
```

Here we have a simple Windows Presentation Foundation with a button that, when clicked, downloads the HTML for google.com.

It's quite hard to notice in this application, since it's very basic, but whenever we click the button, we can't actually resize the application window, or even move it, because it has to wait the download to be complete to actually to something. We can solve this issue by making this program asynchronous:

```cs
...
public async Task DownloadHtmlAsync(string url)
{
    var webClient = new WebClient();
    var html = await webClient.DownloadStringTaskAsync(url);
    using (var streamWriter = new StreamWriter(@"C:\Users\gibra\Desktop\Projetos\learning-game-dev\csharp\exercises\AsyncWpf\result.html"))
    {

        await streamWriter.WriteAsync(html);
    }
}
...
```

So, we created the asynchronous method using the `async` keyword. All asynchronous method should return `System.Threading.Tasks.Task`, which is a class that encapsulates the state of an asynchronous operation. There is the non-generic form, which is used to return void methods, and the generic version (`Task<T>`), which returns whatever type passed into it.

Since `DownloadHtml()` returns void, we use the non-generic class. By convention, the method name should be appended with `Async`, so, it became `DownloadHtmlAsync()`.

Since .NET 4.5, every blocking method has an asynchronous counterpart. For example, `WebClient.DownloadString()` has a `WebClient.DownloadStringTaskAsync()` method (`WebClient.DownloadStringAsync()` is deprecated). The same goes for `StreamWriter.Write()` with `StreamWriter.WriteAsync()`. That's why we converted these methods.

We, then, decorated them with the `await` keyword, which is used when we call an asynchronous method that returns a `Task` or `Task<T>`. This keyword tells the compiler that this operation is going to be costly, and may take some time to complete. In that case, instead of blocking the thread, the compiler immediately returns the control to the caller of the method `DownloadHtmlAsync()`, which is `Button_Click_1()`, so that it can continue executing other tasks, such as resizing the window, making the UI responsive again.

When the first method marked with `await` is completed, the runtime comes back to `DownloadHtmlAsync()` and executes the rest of the code.

Now, we can change `Button_Click_1()` to asynchronous as well and call `await DownloadHtmlAsync()`:

```cs
...
private void Button_Click_1(object sender, RoutedEventArgs e)
{
    await DownloadHtmlAsync("https://www.google.com/");
}
...
```

We made our app responsive.

We also use the asynchronous model in web apps, in ASP.NET Core MVC, for example, so that no blocking operations clog up our threads when we have multiple request connections.

Example of `Task<T>` returning a string:

```cs
...
public async Task<string> GetHtmlAsync(string url)
{
    var webClient = new WebClient();
    return await webClient.DownloadStringTaskAsync(url);
}
...
```

And `Button_Click_1()`:

```cs
private async void Button_Click_1(object sender, RoutedEventArgs e)
{
    string html = await GetHtmlAsync("https://www.google.com/");
    MessageBox.Show(html.Substring(0, 10));
}
```

Here `html` is of type `string`, not `Task<string>`, because of the `await` keyword, which tells the compiler that the `MessageBox.Show(html.Substring(0, 10));` cannot be executed until the operation is completed.

We can also do a work in between the calling of the asynchronous method and the awaiting of its return:

```cs
private async void Button_Click_1(object sender, RoutedEventArgs e)
{

    Task<string> getHtml = GetHtmlAsync("https://www.google.com/");
    MessageBox.Show("Doing something else.");

    string html = await getHtml;
    MessageBox.Show(html.Substring(0, 10));
}
```

Here `MessageBox.Show("Doing something else.");` will be executed before the awaiting of the asynchronous operation. We only use `await` when the rest of the method cannot be executed until the result is read.

## Unit testing

These are scripts that we write to automate tests within our script. It's a very important topic, specially for CI/CD.

When writing unit tests to a class, we need to isolate it, which means that we have to assume that every other class in the application is doing its job correctly.

That's where the name comes from: **we're testing a single unit of functionality, without dependencies**.

### Unit Test Project

We can create a simple unit test project under our solution by adding it. We'll be covering a basic `Unit Test Project`, but later on, we'll work with Visual Studio's `NUnit`.

Adding a unit test project to our solution gives us a default `UnitTest1.cs`:

```cs
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interfaces.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
```

The dependencies of the newly created project are:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net5.0</TargetFramework>

    <IsPackable>false</IsPackable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="16.7.1" />
    <PackageReference Include="MSTest.TestAdapter" Version="2.1.1" />
    <PackageReference Include="MSTest.TestFramework" Version="2.1.1" />
    <PackageReference Include="coverlet.collector" Version="1.3.0" />
  </ItemGroup>

</Project>
```

We'll write test cases for the following example:

`Order.cs`:

```cs
using System;

namespace Interfaces
{
    public class Order
    {
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }
        public Shipment Shipment { get; set; }
        public bool IsShipped
        {
            get { return Shipment != null; }
        }
    }
}
```

`OrderProcessor.cs`:

```cs
using System;

namespace Interfaces
{
    public class OrderProcessor
    {
        private readonly ShippingCalculator _shippingCalculator;
        public OrderProcessor()
        {
            _shippingCalculator = new ShippingCalculator();
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("This order is already processed.");
            }

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
```

`Shipment.cs`:

```cs
using System;

namespace Interfaces
{
    public class Shipment
    {
        public object Cost { get; set; }
        public DateTime ShippingDate { get; set; }
    }
}
```

`ShippingCalculator.cs`:

```cs
using System;

namespace Interfaces
{
    public class ShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }
            return 0;
        }
    }
}
```

And `Program.cs`:

```cs
using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor();
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }
}
```

In `OrderProcessor.cs`, we have tight-coupling between this class and `ShippingCalculator`, since it's being declared as a private field there. So, first, we need to loosen this coupling by creating an `IShippingCalculator` interface, which will be same as shown in the [interfaces](#interfaces) section:

```cs
namespace Interfaces
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
}
```

Altering `OrderProcessor.cs`:

```cs
using System;

namespace Interfaces
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator; // Now, there is no more reference to ShippingCalculator, only its interface.
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("This order is already processed.");
            }

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
```

And `Program.cs`:

```cs
using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }
}
```

As we can see, we're not initializing the field `_shippingCalculator` as an instance of `IShippingCalculator` anymore, thus, making `ShippingCalculator` and `OrderProcessor` loosely coupled. Only the `Main()` method knows of all the classes and their interfaces.

Now, we can write a test method to `OrderProcessor`. The first thing is to rename this file to `OrderProcessorTest.cs`. The second thing is to create a method for testing the `Process` method. This test method is named after the convention: `<MethodName>_<Condition>_<Expectation>()`.

Inside the method, we also have to create an object from `OrderProcessor` to test the `Process` method and, for that, we need to pass in a `IShippingMethod` object to its constructor. Thus, since we're assuming all classes are working perfectly fine, we'll create a `FakeShippingMethod` that implements `IShippingMethod` inside `OrderProcessorTest.cs`.

Since we don't have to actually use `FakeShippingMethod`, we can implement a very simple `CalculateSHipping` method, like returning a number.

Back to the test method, we now instantiate `OrderProcessor` with this newly created `FakeShippingMethod`. We also have to pass in an `Order` object to serve as a parameter to the tested method (`Process()`). We'll create one called `order`, with the property `Shipment` initialized to a new `Shipment` instance.

Now, we finally test for the `Process` method. Since `Shipment` was initialized, the `IsShipped` property from `order` will not return `null` and we'll actually get the `InvalidOperationException("This order is already processed.")` exception.

Since we're testing for this particular exception, we add the property `[ExpectedException(typeof(InvalidOperationException))]` to the `Process_OrderIsAlreadyShipped_ThrowsAnException()` method, so that it knows when to fail the test. This exception comes from `System`.

Putting everything together we get:

```cs
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interfaces.UnitTests
{
    [TestClass]
    public class OrderProcessorTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order() { Shipment = new Shipment() };
            orderProcessor.Process(order);

        }
    }
    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1f;
        }
    }
}
```

Note here that we had to add a reference to the original project. After adding this reference, the `<ProjectReference Include="..\Interfaces\Interfaces.csproj" />` is added to `Interfaces.UnitTest.csproj`:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net5.0</TargetFramework>

    <IsPackable>false</IsPackable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="16.7.1" />
    <PackageReference Include="MSTest.TestAdapter" Version="2.1.1" />
    <PackageReference Include="MSTest.TestFramework" Version="2.1.1" />
    <PackageReference Include="coverlet.collector" Version="1.3.0" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\Interfaces\Interfaces.csproj" />
  </ItemGroup>

</Project>
```

Running the test with `Ctrl + R + A`, we see that the test passed, because `order.IsShipping` is, indeed, throwing this exception, since `Shipment` was initialized.

If we initialize `Shipment` to null (or don't initialize it at all):

```cs
...
var order = new Order();
...
```

The test will fail, because no exception will be thrown.

Now, we'll create a second test case, for when the order isn't shipped yet (`Shipment` is empty or null) **and** that `Cost` will be equal to `1`, because, remember, we declared a `FakeShippingCalculator.CalculateShipping()` method that returns `1`, and finally, `ShippingDate` should be equal to today's date plus one day.

The test case method, now called `Process_OrderIsNotShipped_ShouldSetPropertyOfTheOrder()`, will utilize the `Assert` class to assert that `order.IsShipped` is indeed null, by using the `IsTrue()` method. We use the `AreEqual()` methods to assert that `Cost` and `ShippingDate` are the expected values:

```cs
...
[TestMethod]
public void Process_OrderIsNotShipped_ShouldSetPropertyOfTheOrder()
{
    var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
    var order = new Order();
    orderProcessor.Process(order);
    Assert.IsTrue(order.IsShipped);
    Assert.AreEqual(1f, order.Shipment.Cost);
    Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
}
...
```

Now, both tests should pass.
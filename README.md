# [GameDev.tv](https://www.gamedev.tv/)'s Complete C# Unity Game Developer 2D on Udemy

## A repository aimed to store the code and the notes generated from the lessons of [the course](https://www.udemy.com/course/unitycourse/).

## I will not make a detailed dive into Object Oriented Programming, because this has already been discussed in my [ learning Java repository](https://github.com/gagibran/udemy-java-the-complete-java-developer-course).

## Refer to that [README.md](https://github.com/gagibran/udemy-java-the-complete-java-developer-course/blob/dev/README.md) to know more about OOP.

## I will only list the main differences between C# and Java.

## Since Unity projects are too large to be stored in GitHub, I will only keep this README.md, the LICENSE, and .gitignore here.

## Table of Contents:
- [Hello, world](#hello,-world)
    - [Requirements for this course](#requirements-for-this-course)
    - [First C# program](#first-c-program)
    - [Start method](#start-method)
    - [Update method](#update-method)
- [Number wizard](#number-wizard)
    - [Debug.Log](#debug.log)
    - [Player input](#player-input)
    - [Unity namespace](#unity-namespace)
    - [Solution](#solution)
- [Text101](#text101)
    - [Game design](#game-design)
    - [The story](#the-story)
    - [Creating sprites in Unity](#creating-sprites-in-unity)
- [Differences between C# and Java](#differences-between-c-and-java)
    - [C# naming conventions](#c-naming-conventions)
    - [Namespaces](#namespaces)
    - [Data types](#data-types)
    - [Strings](#strings)
    - [Converting types](#converting-types)
    - [Structs](#structs)

## Hello, world

### Requirements for this course
1. Unity Hub;
2. A version of Unity. I'm using **Unity 2020.2.5f1 (64-bit)**;
3. Visual Studio. I'm using **Visual Stdio 2019**.

### First C# program

We can start by creating a new project in Unity Hub. When it's done creating, the folder structure will look like this for a project named **HelloWorld**:

![Unity Folder Structure](readme-images/unity-folder-structure.png)

Under the folder **HelloWorld**.

In unity, we can create a C# file by right clicking in the **Assets** area, select **Create**, and select **C# Script**:

![Create C# Script](readme-images/create-cs-file.png)

Right after clicking **Create**, we have to rename the file to something other than the default. In this case, **HelloWorld**:

![Hello World C#](readme-images/hello-world-cs.png)

We can choose to open it in Visual Studio by double clicking the file. The template C# script that's generated is:
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
```

We can add a print statement in order to make it print out **Hello, world.**:
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello, world");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
```

After that, we have to attach it into a **game object**.

We can see all game objects in the left side view of Unity, in the **Hierarchy** pane:

![Hierarchy Pane](readme-images/hierarchy-pane.png)

Right now, the only object present is the **Main Camera**.

To attach our script to the **Main Camera** object, we can simply drag and drop the **HelloWorld** file from the **Assets** into **Main Camera** on the left side pane.

If we click on the object, we should see the script added in the **Inspector** pane, on the right side, in the bottom:

![Script Added](readme-images/script-added.png)

We can also click the **Add Component** button to attach a script there.

Finally, to execute our script, we have to click the **play button** in the upper middle section of Unity:

![Play Button](readme-images/play-button.png)

The message will be displayed into the **console view**:

![Console View](readme-images/console-view.png)

To stop the current play session, we just have to click the **play button** again.

The console is an awesome tool for debugging.

### Start method

The start method is invoked when the game is initialized (when the play button is hit).

It's an initialization method. It only executes **once**.

But, we still have to declare **fields** to the class so that the [Update method](#update-method) can access them.

### Update method

This method is called **once per frame**.

So, for faster computers, this method will be called quicker.

## Number wizard

In this section, we'll create a console based C# game that guesses which number the user is thinking about.

### Debug.Log

This method of printing out is from the **UnityEngine** namespace.

It is more flexible and better than print. It will be later explained.

### Player input

We can read which key the player's pushed in a given situation.

The official documentation for Unity's API on that can be found [here](https://docs.unity3d.com/ScriptReference/Input.html).

To read an input, we need to use the **Input** class from the **UnityEngine** namespace.

Inside this class we have the overloaded method **GetKeyDown()** that takes an argument of type **KeyCode**.

This method reads which key an user pressed **down** in their keyboard.

Example to read the **up arrow**:
```
if (Input.GetKeyDown(KeyCode.UpArrow))
{
    Debug.Log("Up Arrow key was pressed.");
}
```

This has to go inside the [Update()](#update-method) method in the **NumberWizard** class, because this method constantly reads input from the user.

The message "Up Arrow key was pressed." will only be displayed **if we push the key after we click inside the Game tab**:

![Up Key Pushed](readme-images/up-key-pressed.png)

Here's a [list](https://docs.unity3d.com/ScriptReference/KeyCode.html) from the official documentation of all key codes that are available for reading.

**Note**: normally, we put the curly bracket starting a code block down bellow a statement in C#, like the example above.

### Unity namespace

We're using the **UnityEngine** namespace, that contains all classes, methods from the Unity framework.

A full documentation can be found [here](https://docs.unity3d.com/2020.2/Documentation/Manual/index.html).

### Solution

We create a project just like we did with the [hello, world](#hello,-world) challenge, create the C# file in **Assets**, and add the following code to it:
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Think of a number.");
        Debug.Log("The highest number is: " + max);
        Debug.Log("The lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Press the up arrow if it's higher.");
        Debug.Log("Press the down arrow if it's higher.");
        Debug.Log("Press enter if the number is correct.");
        max += 1; // Now that the max is 1001, we can press the up arrow until it hits 1000, if our number is 1000.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Your number is " + guess);
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is your number " + guess + "?");
    }
}
```

Trying to guess the number 643:

![Guessed Number](readme-images/guessed-number.png)

Something to note is that this game still has a major bug. When we hit up and down a certain amount of times, the minimum and maximum values will be equal, meaning that their mean will be equal themselves. In other words, when this condition is reached, we won't be able to update the value anymore and the **guess** variable will get stuck in a value.

## Text101

We'll be creating a text based game that the player chooses what will happen.

### Game design

It's important that the player have a feeling of discovery by choosing their own path through out the game.

The core mechanics of this game is that the player will be choosing their actions by selecting a text.

I'll try to make it a cyberpunk game, despite the theme being steampunk in the course.

It will be just a small project, just so that we get use to Unity's API and overall mechanics.

### The story

It will be just a small part of a story, so that we don't waste to much time on a demo game.

It will be about the CEO of a big cyber security company that runs the region of Denver in Colorado. 

His name is Cole Kravinski and he's been held captive for 4 months now in exchange for security data of the region. 

Knowing a little about neuromancy, Cole finds an opportunity to escape by accessing the matrix and finding out more about his kidnappers and his current location.

Wrapping up, we have:
1. **The player**: Cole, the CEO;
2. **The situation**: His kidnapping;
3. **The setting**: Denver, Colorado;
4. **The threat**: His death;
5. **The goal**: Escape alive.

### Creating sprites in Unity

According to the [documentation](https://docs.unity3d.com/Manual/Sprites.html), a sprite is a 2D graphic object obtained from a bitmap image.

To create a sprite in Unity, we just have to right click in the **Assets** area, select **Create**, just like we did to create the C# script, click **2D**, then **Sprites**, and finally, choose between **Square**, **Triangle**, **Diamond**, **Hexagon**, **Circle**, and **Polygon**:

![Create Sprits](readme-images/create-sprites.png)

Similarly to the adding a script into a game object, we can drag and drop a sprite into it. We can do it as many times as we want to ad multiple sprites into a game object.

In their **Inspector** pane, we can change their color, move them around the scene pane (can also be done by clicking and dragging), add scripts etc:

![Inspect](readme-images/inspector.png)

They will appear into our hierarchy tree.

In the top right, we have a bunch of tools to mess around with the sprite, like **Hand Tool**, **Move Tool**, **Scale Tool**, **Rotate Tool**, and **Editor Tool**:

![Tools](readme-images/tools.png)

Despite this being a 2D course, the game scene can be changed to 3D as well:

![Two D Toggle](readme-images/two-d-toggle.png)

Example of 2D:

![Added Sprites](readme-images/added-sprites.png)

**Challenge screenshot:**

![Challenge Screenshot](readme-images/challenge-screenshot.png)

## Differences between C# and Java

### C# naming conventions

Most of the naming is in PascalCase.

[Here](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines) is Microsoft's official naming convention for the C# language.

[Here](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions) is Microsoft's official coding convention.

[Here](https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md) is a repository from [Konstantin Taranov](https://github.com/ktaranov) that condenses all of the conventions.

### Namespaces

They are containers for related classes.

They are declared using PascalCase:
```
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
```
using System;
```

### Data types

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

### Strings

They're also mapped to a class in the `System` namespace, the `String` class.

They're immutable, meaning that they cannot be changed once declared.

We can iterate though a string by indexing it:
```
string name = "Gabriel";
Console.WriteLine(name[0]);
// name[1] = b; // This won't compile.
```
Which prints:
```
G
```

We can use string concatenation, but we can also use the static `Format()` method from the `String` class:
```
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

We can also join elements from an array or list using the `Join()` method, also in the `String` class:
```
int[] a = new int[3] { 1, 2, 3, 4 };
string s = string.Join(",", a);
Console.WriteLine(s);
```
Which prints `a`'s elements joined by a comma:
```
1,2,3,4
```

There's also a special type of string called **verbatim strings**, which are the pure strings, without the use of special or escape characters. For example: `string s = "\n";` jumps a line and in `string a = "variable\\holding\\a\\path";` we have to escape the backslash in order to use it.

We can simply append a `@` sign at the beginning of our string to use the escape character literally: `string s = @"\n";` equals `\n` literally. The path variable can now be declared as `string a = @"variable\holding\a\path";`. We can even type `Enter` to physically input a new line in the string, instead of using `\n`.

### Converting types

We have **implicit** and **explicit** conversions.

In implicit, it converts as long as there's not information loss, like `byte a = 3;` and `int b = a;`, or `float c = 4;` and `int d = c;`

But, we cannot convert `int a = 1;` to `byte b = c;`, because `int` occupies 4 bytes, whereas `byte`, occupies just one. Even though the number `1` fits into a `byte`, the compiler treats it as information loss and doesn't compile.

In these cases, we can use the **explicit** conversion type, or **casting**, which is just like Java: `int a = 1;` and `byte b = (byte) a;`.

To convert a `string` to an `int`, for example, we can use the methods from the `Convert` class from the `System` namespace:
```
using System;

string s = "1";
int i = Convert.ToInt32(s);
```
All primitive types have overloaded methods for conversion, that accept each primitive type as an argument.

We can also use the static `Parse` method from each primitive type struct:
```
string s = "1";
int i = int.Parse(s);
```

### Structs

It's a container in C# that's similar to a class.

They're not really used - we use classes 99% of the time.

They combine related fields and methods together.

There are a lot of tiny differences between classes and structs that's in the [official documentation](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct), but they're not very important to know.

What we should take from **structs**, is that we should use them when we want to create a small lightweight object. For example:
```
public struct RgbColor
{
    public int Red;
    public int Green;
    public int Blue;
}
```

It's more efficient to define it as a structure, when we need to create thousands of objects.
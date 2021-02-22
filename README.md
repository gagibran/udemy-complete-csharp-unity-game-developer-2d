# [GameDev.tv](https://www.gamedev.tv/)'s Complete C# Unity Game Developer 2D on Udemy

## A repository aimed to store the code and the notes generated from the lessons of [the course](https://www.udemy.com/course/unitycourse/).

## I will not make a detailed dive into Object Oriented Programming, because this has already been discussed in my [ learning Java repository](https://github.com/gagibran/udemy-java-the-complete-java-developer-course).

## Refer to that [README.md](https://github.com/gagibran/udemy-java-the-complete-java-developer-course/blob/dev/README.md) to know more about OOP.

## I will only list the main differences between C# and Java.

## Since Unity projects are too large to be stored in GitHub, I will only keep this README.md, the LICENSE, and .gitignore here.

## Table of Contents:
- [Hello, world](#hello,-world)
    - [Requirements for this course](#requirements-for-this-course)
    - [C# naming conventions](#c#-naming-conventions)
    - [First C# program](#first-c#-program)
    - [Start method](#start-method)
    - [Update method](#update-method)
- [Number wizard](#number-wizard)
    - [Debug.Log](#debug.log)
    - [Variable differences between Java and C#](#variable-differences-between-java-and-c#)
    - [Player input](#player-input)
    - [Namespaces](#namespaces)
    - [Solution](#solution)
- [Text101](#text101)


## Hello, world

### Requirements for this course
1. Unity Hub;
2. A version of Unity. I'm using **Unity 2020.2.5f1 (64-bit)**;
3. Visual Studio. I'm using **Visual Stdio 2019**.

### C# naming conventions

Most of the naming is in PascalCase.

[Here](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines) is Microsoft's official naming convention for the C# language.

[Here](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions) is Microsoft's official coding convention.

[Here](https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md) is a repository from [Konstantin Taranov](https://github.com/ktaranov) that condenses all of the conventions.

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

### Variable differences between Java and C#

To declare a boolean, we use the keyword **bool**.

A string in C# is a primitive type, not a custom class. Thus, we use the keyword **string** (lowercase).

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

### Namespaces

In C# we have an outer scope called **namespace**.

They're an extra container that encapsulate classes, like packages.

For example, we're using the **UnityEngine** namespace, that contains all classes, methods from the Unity framework.

We use the keyword **using** at the beginning of our code to import a particular namespace to our project.

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


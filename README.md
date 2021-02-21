# [GameDev.tv](https://www.gamedev.tv/)'s Complete C# Unity Game Developer 2D on Udemy

## A repository aimed to store the code and the notes generated from the lessons of [the course](https://www.udemy.com/course/unitycourse/).

## I will not make a detailed dive into Object Oriented Programming, because this has already been discussed in my [ learning Java repository](https://github.com/gagibran/udemy-java-the-complete-java-developer-course).

## Refer to that [README.md](https://github.com/gagibran/udemy-java-the-complete-java-developer-course/blob/dev/README.md) to know more about OOP.

## I will only list the main differences between C# and Java.

## Since Unity projects are too large to be stored in GitHub, I will only keep this README.md, the LICENSE, and .gitignore here.

## Table of Contents:
- [Hello, world](#hello,-world)
- [Number wizard](#number-wizard)

## Hello, world

**Requirements for this course**:
1. Unity Hub;
2. A version of Unity. I'm using **Unity 2020.2.5f1 (64-bit)**;
3. Visual Studio. I'm using **Visual Stdio 2019**.

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

## Number wizard


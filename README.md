# OOP3

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white) ![GitHub](https://img.shields.io/badge/github-%23121011.svg?style=for-the-badge&logo=github&logoColor=white) ![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white) ![Notepad++](https://img.shields.io/badge/Notepad++-90E59A.svg?style=for-the-badge&logo=notepad%2b%2b&logoColor=black)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)

Object-oriented programming (OOP) is a programming paradigm based on the concept of objects, which can contain data and code: data in the form of fields (often known as attributes or properties), and code in the form of procedures (often known as methods).

> C#, pronounced "C-sharp," is an object-oriented programming language from Microsoft that enables developers to build applications that run on the .NET platform. C# has its roots in the C family of programming languages and shares many of the same characteristics as those found in C and C++, as well as in Java and JavaScript.

## 4 OOP Principles

OOP allows objects to interact with each other using four basic principles:

- encapsulation,
- inheritance,
- polymorphism, and
- abstraction.

These four OOP principles enable objects to communicate and collaborate to create powerful applications.

## Popular learning resources on internet

![FreeCodeCamp](https://img.shields.io/badge/Freecodecamp-%23123.svg?&style=for-the-badge&logo=freecodecamp&logoColor=green) ![W3](https://img.shields.io/badge/W3Schools-04AA6D?style=for-the-badge&logo=W3Schools&logoColor=white)

- C# foundational course with Microsoft Learning on [freeCodeCamp](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/)
- Full C# video course for beginners on [freeCodeCamp](https://www.freecodecamp.org/news/c-sharp-tutorial-for-beginners/)
- New free online book for beginners on [freeCodeCamp](https://www.freecodecamp.org/news/learn-csharp-book/)
- C# tutorial on [W3 Schools](https://www.w3schools.com/cs/index.php)
- C# data types on [TutorialsTeacher](https://www.tutorialsteacher.com/csharp/csharp-data-types)

I can recommend resources on [freeCodeCamp](https://www.freecodecamp.org/news/about/) regarding any programming language!

## Further online resources regarding programming

![Stack Overflow](https://img.shields.io/badge/-Stackoverflow-FE7A16?style=for-the-badge&logo=stack-overflow&logoColor=white)
![Google](https://img.shields.io/badge/google-4285F4?style=for-the-badge&logo=google&logoColor=white)

- Forums on [StackOverflow](https://stackoverflow.com/questions)
- Google for "[Best programming forums](https://www.google.com/search?q=best+programming+forums)"

## Prompt I'm using on ChatGPT and MS Copilot to use them as a trainer (croatian!)

![ChatGPT](https://img.shields.io/badge/chatGPT-74aa9c?style=for-the-badge&logo=openai&logoColor=white)

Zamisli da si iskusni programer i učiš početnike programiranju u C#, izradi SQL baza podataka i korištenju Entitiy frameworka.  
Učim programiranje u C#. Pohađam tečaj objektno orijentiranog programiranja, gdje smo obradili cjelokupni standardni C# kurikulum.  
Kako bih vježbao izradu baza podataka u SQL i korištenje Entity frameworka, postavi mi jedan srednje kompliciran zadatak.  
Kao i uvijek nemoj odmah ispisivati rješenja, njih ćeš mi ponuditi na upit i to po principu korak po korak.  

Naprije ponovi instrukcije koje sam ti dao.  

> I stopped using Google Gemini, since I wasn't satisfied with his answers!

## Useful if you manually renamed folders containing projects in Visual Studio

When you manually rename folders containing projects in Visual Studio, the references in the solution file (.sln) do not get updated automatically, leading to errors. Here’s how you can fix it:

1. **Remove the missing projects**: In the Solution Explorer, right-click on each of the projects that cannot be found and select Remove.
2. **Add the renamed projects back to the solution**: Right-click on the solution and select Add -> Existing Project. Navigate to the new location of each project (the renamed folders), select the project file (.csproj, .vbproj, etc.), and click Open.
3. **Rebuild the solution**: Go to Build -> Rebuild Solution.

This should fix the error and allow the solution to recognize the projects in their new locations. Remember to update any project references if these projects are referred to by others in the same solution.

Cheers,

Tibor

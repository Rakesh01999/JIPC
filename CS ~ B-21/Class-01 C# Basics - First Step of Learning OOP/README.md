# 🚀 Run Your First C# Program in VS Code (Step-by-Step)

Welcome to your first step in learning C#! This guide will walk you through setting up your environment and running your very first console application using Visual Studio Code.

---

## 🛠️ 1. Setup Your Environment

Before you start coding, ensure you have the following tools installed:

### **A. Install .NET SDK**
*   Download and install the latest **.NET SDK** from the [official .NET website](https://dotnet.microsoft.com/download).
*   **Verify Installation:** Open your terminal and type:
    ```bash
    dotnet --version
    ```

### **B. Install VS Code**
*   Download and install [Visual Studio Code](https://code.visualstudio.com/).

### **C. Install C# Extensions**
*   Open VS Code, go to the **Extensions** view (`Ctrl+Shift+X`).
*   Search for and install:
    *   **C# Dev Kit** (by Microsoft)
    *   **C#** (by Microsoft)

---

## 📂 2. Create Your C# Project

### **Option A: Using the Terminal (Recommended)**
1.  Open the terminal in VS Code (`Ctrl + ` `).
2.  Create a new folder and project:
    ```bash
    dotnet new console -o FirstApp
    cd FirstApp
    code .
    ```

### **Option B: Using VS Code UI**
1.  Open VS Code.
2.  Press `Ctrl+Shift+P`, type `.NET: New Project`, and select it.
3.  Choose **Console App** from the list and follow the prompts.

---

## 🏃 3. Run Your Program

Once your project is open:
1.  Open the `Program.cs` file.
2.  In the terminal, type:
    ```bash
    dotnet run
    ```
3.  You should see the output: `Hello, World!`

---

## 🛠️ Common Issues (Quick Fix)

*   **`dotnet` not recognized:** Restart VS Code or your Terminal to refresh environment variables.
*   **Nothing runs:** Ensure you are **inside** the project folder (e.g., `cd FirstApp`) before running `dotnet run`.
*   **Debugging:** You can now debug just like in C++ by pressing `F5` or using the **Run and Debug** sidebar.

---

## 🔥 Mini Challenge (Do This Now)

Try writing this small program yourself inside `Program.cs`:

**Goal:** Input 2 numbers and print their sum.

```csharp
Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Sum = " + (a + b));
```

---

## 💡 Motivation
> **"Time is always running, then why are you sitting!"** 🏃‍♂️💨

*Let's keep coding!*

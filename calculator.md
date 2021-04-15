# object oriented programming

dotnet new console -o calculator

## Static Classes

Just like methods, classes can also be static. A static class can only contain static fields and static methods and cannot be instantiated. 

The main reason to create a static class is to serve as a toolbox of sorts. 

A static class may contain several useful methods that we want to call from many parts of our code without having to write them in multiple places. A simple example of a static class could be a calculator:

    int Sum = Calculator.Add(4, 6);

Notice that we call .Add() directly on the class name Calculator, rather than an instance of type Calculator. 

Non-static classes can contain static fields and methods, just remember that they will still be called from the class name, not class instances.

## Extension Methods

If you want to add functionality to a class, one way you can do this is to create a new class to inherit from it and add all needed code there. 

The problem ends up being that now your value type is of that new class and no longer the original one for any object you create. 

This can cause some problems so instead, you can make use of what are called extension methods to directly attach new methods to that class. 

Extension methods are wrapped in a new custom class with the static keyword. 

When the method you want is declared, you must include a variable for the class to which you want to add the extension in your parameters list preceded by the keyword this. 

The code below will make it more apparent how it's done.

From here an extension method is in place and the class will have access to that function when called as normal.

Note they do have to be in the same namespace, though not in necessarily in the same file!

## Extension Methods and Interfaces
You can apply an extension method directly to an interface as well! 

This allows you to add the extension method functionality to every class that implements the interface. 

Pretty cool right!?

## Delegates

Callback is a concept that exists in many other languages. 

The idea is that you can pass a function as a parameter to another function so that the passed function may be called within the one it was passed to. 

This allows for you to create some order by which the functions run as well as improve passing data between them. 

To create a callback in C# you must use a delegate, which is a variable reference to some type of function. 

Delegates can be defined like this:

```
public delegate void Del(string message);
public static void DelegateMethod(string message)
{
    Console.WriteLine(message);
}
// Instantiate the delegate to reference the DelegateMethod function
Del handler = DelegateMethod;
```

Now that you have set up a reference to a function as a delegate you can easily pass it to another function as a callback by making a parameter of the delegate type.

```
public void MethodWithCallback(int param1, int param2, Del callback)
{
    callback("The number is: " + (param1 + param2).ToString());
}
// Call this function by passing the params and actual delegate reference
MethodWithCallback(1, 2, handler);
```
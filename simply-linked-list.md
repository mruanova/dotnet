# object oriented programming

dotnet new console -o simply-linked-list

## Singly Linked Lists

Objectives:

Practice creating classes and objects

Learn and implement a singly linked list in C#.

In this assignment, you will create your own implementation of a singly linked list in C#.

To get you started, consider the following class definitions for SllNode and SinglyLinkedList.

### SllNode.cs
```
public class SllNode
{
    public int Value;
    public SllNode Next;
    public SllNode(int value) 
    {
    // your code here
    }
}
```
### SinglyLinkedList.cs
```
public class SinglyLinkedList
{
    public SllNode Head;
    public SinglyLinkedList() 
    {
        // your code here
    }
    // SLL methods go here. As a starter, we will show you how to add a node to the list.
    public void Add(int value) 
    {
        SllNode newNode = new SllNode(value);
        if(Head == null) 
        {
            Head = newNode;
        } 
        else
        {
            SllNode runner = Head;
            while(runner.Next != null) {
                runner = runner.Next;
            }
            runner.Next = newNode;
        }
    }    
}
```
### Tasks:
● Create a Node class as shown above.

● Fill in the constructor method that sets the Value to a given number and Next to null of your Node objects.

● Create a SinglyLinkedList class as shown above.

● Create a constructor method that sets the Head to null of your SinglyLinkedList objects

● Create a Remove() method that will remove a node from the end of your list

● Create PrintValues() method that will print all the values of each node in the list in order

### Optional Challenges:
● Implement a Find(int) method that will return the first node with the value in the parameter

● Implement a RemoveAt(int) method that will remove the node after n nodes, where n is the parameter.

For example, if n is 0, remove the first node. If n is 1, remove the second node (similar to arrays).

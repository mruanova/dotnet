# object oriented programming

dotnet new console -o doubly-linked-list

## Doubly Linked Lists

### Objectives:

Get familiar with the Doubly Linked List data structure

Compare and contrast to Singly Linked List

Build a few useful Doubly Linked List methods

There may have been times when working with the Singly Linked List where you really wish you could look back one node, in the same fashion as looking forward. 

### So make it happen!

Adding an additional pointer on your list node, one that will look backwards, is what defines a Doubly Linked List.

The only thing that distinguishes a Doubly Linked List from a Singly Linked one, is that nodes in a DLL have a pointer pointing backwards as well as forwards - often called Previous, or Prev.

The convienience of having a .Prev comes at the cost of managing twice as many pointers, so it may not always make sense to use a DLL over a SLL.

Managing pointers, though, will need to become second nature, and implementing DLL methods is a great way to get some practice.

Using the class definitions provided, or starting your own if you choose, build out a few methods on a DoublyLinkedList class, using a DLLNode (with a .Prev).

### DllNode.cs
```
public class DllNode
{
    public int Value;
    public DllNode Next;
    public DllNode Prev;
    public DllNode(int val) 
    {
    // your code here
    }
}
```
### DoublyLinkedList.cs
```
public class DoublyLinkedList
{
    public DllNode Head;
    // Place your methods here.
    
}
```
### Implement the following methods on your DoublyLinkedList class:

void Add(int value) Adds a new DllNode object, with the provided value, to the end of the list.

bool Remove(int value) Removes a DllNode object with the provided value, returns true if node is successfully removed.

void Reverse() Reverses order of nodes in list.

void Add(int value)

bool Remove(int value)

void Reverse()

# object oriented programming

dotnet new console -o trees

## Trees

https://en.wikipedia.org/wiki/Trie

### Objectives:

Get familiar with the Trees data structure

### Build a few methods for Trees

Many data structures we have seen so far use nodes and pointers as their building blocks (eg. linked lists and binary search trees). 

As we apply specific rules to how the nodes and pointers work, we end up with data structures that more effectively perform certain functionality (eg. binary search trees are great for maintaining and retrieving sorted data).

A trie (pronounced "try") is no different! 

They are a type of search tree, but unlike binary search trees, they are not restricted to only 2 pointers. Instead, a given node may have many pointers or no pointers at all. They are commonly known and used for their power to predict.

Think about how an auto-complete feature of a dictionary app works: as you type each letter, a list pops of of possible words matching your search so far. As you keep typing, the number of possible words decreases.

If we wanted to build such an app ourselves from scratch, how might we start saving all the dictionary’s words into a data structure? A list is one option, but as our dictionary grows, we’d end up with a node for every single word, and as our list grows, searching and adding will become increasingly time consuming.

But what if the time complexity of searching and adding could be reduced to simply the number of letters in the word? That's how tries work. Continuing with our dictionary app example, since there are 26 letters in the English alphabet, let's start with 26 nodes, each representing a different letter. Each of those nodes, in turn, will have pointers to letter nodes that represent the second letter of any words that begin with the first letter. Those nodes, then, would have pointers to letter nodes representing the third letter, and so on. Each node could have a simple property indicating whether it represented the end of a word. For example, let's say our dictionary has the words "see" and "seen."

Let's use a trie to save 3 words: code, dojo, cool. So that we have one uniform place to start, let’s set the value of the root node to be an empty string. Let's start by adding the word "code." Starting at the root, we'll look for a pointer to the first letter of the word, in this case 'c'. Since the root node has no pointers yet, let's add one. (Since we know we'll likely be adding multiple "next" pointers, perhaps some kind of collection will be useful here?) Then we'll traverse to that node and add a pointer to it to point to the letter 'o'. Then we'll move to that node and add a pointer to the letter 'd'. Let’s add a pointer to 'd' we reach the node representing the last letter, 'e'. We'll perform the same steps, but this time we'll update a property on the 'e' node to indicate that this node represents the end of a word (maybe a boolean property that by default is set to false).



Next, let's add the word 'cool.' Starting at the root, since the 'c' node exist, let’s navigate to it. The next letter, 'o', also already exists, so let's navigate to it. The next letter is 'o'. Since it is not yet connected to the current node, we'll add a pointer to it, and then navigate to that new 'o' node. Then we’ll add the ‘e’ pointer and the ‘e’ node, indicating that this final 'e' represents the end of a word.

When we try to add the word 'dojo', since we haven't added a word that starts with a 'd' yet, we’ll go through the same steps we went through when adding the first word.

Assignment: Build the following methods for your Tries class:

 void Add(string word)

 bool Contains(string word)

 string[] Autocomplete(string prefix)
 
que.1 What are the different types of loops in C#?
answer: loops are used to perform any repeatetive task.

# there are multiple types of loops

1. for Loop 
2. while loop
3. do-while loop
4. foreach loop


que 2. How does a while loop work?
answer: Executes a block of code as long as a condition is true.
while (condition)
{
    
}

que 3. What is the difference between a while loop and a do-while loop?
answer: the diffrence between while and do-loops is ,while loop Executes a block of code as long as a condition is true. and do while loop Similar to while, but executes at least once, even if the condition is false.


que 4. What happens if the loop condition in a while loop is initially false?
ans.  in this condition loop will terminate the excution 

que 5. How do you use a foreach loop in C#?
ans: Used to iterate over collections (arrays, lists, etc.). It does not use an index.

Syntax: int[] numbers = { 10, 20, 30 };
foreach (int num in numbers)
{
    Console.WriteLine(num);
}

que 6. Can we modify elements inside a foreach loop? Why or why not?
answ:  No, we cannot directly modify elements of a collection inside a foreach loop if the collection is an array or a list. This is because foreach works with an enumerator, which provides read-only access to the collection.

section 2 intermediate quwstions ?

1. What is an Infinite Loop?
ans: An infinite loop is a loop that runs indefinitely because its termination condition is never met.
A. using for loops for (;;)
{
    Console.WriteLine("This is an infinite loop.");
}

B. using while loops 
while (true)
{
    Console.WriteLine("This is an infinite loop.");
}
C. using do while loops 
do
{
    Console.WriteLine("This is an infinite loop.");
} while (true);



2. How Does the break Statement Work in Loops?
ans: The break statement immediately exits the loop when encountered, skipping any remaining iterations.

Example of break in a loop:
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        Console.WriteLine("Breaking the loop at i = 5");
        break;
    }
    Console.WriteLine(i);
}
output: 1 2 3 4 Breaking the loop at i = 5

3. What is the Role of the continue Statement in Loops?
ans: The continue statement skips the current iteration and proceeds to the next iteration.
Example of continue in a loop:
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        Console.WriteLine("Skipping iteration for i = 3");
        continue;
    }
    Console.WriteLine(i);
}
output : 1
2
Skipping iteration for i = 3
4
5

4. How to Exit Multiple Nested Loops at Once?
anser: You can exit multiple nested loops using labeled break or by using return inside a method.
Example using labeled break:
outerLoop:
for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine($"i = {i}, j = {j}");
        if (i == 2 && j == 2)
        {
            Console.WriteLine("Breaking out of both loops");
            break outerLoop;
        }
    }
}
Example using return inside a method:
void NestedLoop()
{
    for (int i = 1; i <= 3; i++)
    {
        for (int j = 1; j <= 3; j++)
        {
            Console.WriteLine($"i = {i}, j = {j}");
            if (i == 2 && j == 2)
            {
                Console.WriteLine("Exiting from method");
                return;
            }
        }
    }
}

5. Difference Between break and return Inside a Loop?
ans: Example of break:
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        break; // Exits the loop but continues execution after the loop
    }
    Console.WriteLine(i);
}
Console.WriteLine("Loop ended");
Example of return:
void ExampleMethod()
{
    for (int i = 1; i <= 5; i++)
    {
        if (i == 3)
        {
            return; // Exits the method completely
        }
        Console.WriteLine(i);
    }
    Console.WriteLine("This line will never execute if return is hit");
}

6.  Iterating Through an Array Using Loops
ans:Using for loop:

int[] numbers = { 10, 20, 30, 40, 50 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
Using foreach loop:
foreach (int num in numbers)
{
    Console.WriteLine(num);
}
Using while loop:
int index = 0;
while (index < numbers.Length)
{
    Console.WriteLine(numbers[index]);
    index++;
}

7. C# Program to Find the Largest and Smallest Number in an Array
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 25, 50, 10, 75, 5, 90 };
        
        int smallest = numbers[0];
        int largest = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < smallest)
            {
                smallest = numbers[i];
            }
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        
        Console.WriteLine($"Largest Number: {largest}");
    }
}


Section 3: Advanced Questions

15. Can a for loop run indefinitely? If yes, how?
ans: Yes, a for loop can run indefinitely if its termination condition is always true or omitted.
Example of an Infinite for Loop
for (;;)
{
    Console.WriteLine("This is an infinite loop.");
}
16. How Do You Implement a Loop Using Recursion Instead of Traditional Looping Constructs?
ans: Recursion is a technique where a function calls itself to perform repetitive tasks.

Example: Printing Numbers Using Recursion

using System;

class Program
{
    static void PrintNumbers(int n)
    {
        if (n == 0) // Base case
            return;

        Console.WriteLine(n);
        PrintNumbers(n - 1); // Recursive call
    }

    static void Main()
    {
        PrintNumbers(5);
    }
}
output: 
5
4
3
2
1

17.  What is the Impact of Using goto Inside Loops? Is It Recommended?

The goto statement transfers control to a labeled statement, which can make code hard to read and debug. It should be avoided in modern C# programming.

Example of goto in a Loop: 

using System;

class Program
{
    static void Main()
    {
        int i = 1;

    startLoop:
        if (i > 5) return;

        Console.WriteLine(i);
        i++;
        goto startLoop; // Jumping back to the label
    }
}
output: 
1
2
3
4
5

18. How Does a foreach Loop Work Internally in C#?
ans: A foreach loop works by using IEnumerator to iterate over collections.

Internal Working of foreach: 

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        using (var enumerator = numbers.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                int num = enumerator.Current;
                Console.WriteLine(num);
            }
        }
    }
}
. Works on any collection that implements IEnumerable<T>.

19. Can a foreach Loop Be Replaced with a for Loop? If Yes, In What Cases?
ans: Yes, a foreach loop can be replaced with a for loop when:
A. Index-based access is needed (like in arrays and lists).
B. You need modification (since foreach doesn’t allow modifying the collection directly).

int[] numbers = { 1, 2, 3, 4, 5 };

// Using foreach
foreach (int num in numbers)
{
    Console.WriteLine(num);
}

// Using for
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

20. How Do You Optimize Performance in Loops When Working with Large Datasets?
ans: Optimization Techniques:

   1. Use for instead of foreach for arrays (avoids iterator overhead).
   2. Minimize function calls inside the loop.
   3. Use Parallel.ForEach for multi-threading (if applicable).
   4.  Avoid modifying collections inside loops (causes performance issues).

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Span<int> spanNumbers = numbers;

        for (int i = 0; i < spanNumbers.Length; i++)
        {
            Console.WriteLine(spanNumbers[i]); // Faster access
        }
    }
}

21.  Best Practices for Writing Efficient Loops in C#
ans: 

1. Use for for arrays, foreach for collections.
2. Precompute loop conditions instead of recalculating in each iteration.
3. Avoid modifying collections while iterating (use ToList() if needed).
4. Use Break and Continue wisely to skip unnecessary iterations.
5. Consider Parallel.ForEach for heavy computation.

22. How Does Parallel.ForEach Differ from a Normal foreach Loop?
ans: 

   1. Parallel.ForEach executes iterations in parallel using multiple threads, improving performance for CPU-bound tasks.
   2. A normal foreach executes sequentially.


using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Parallel.ForEach(numbers, number =>
        {
            Console.WriteLine($"Processing {number} on thread {Task.CurrentId}");
        });
    }
}
Output : 
Processing 1 on thread 4
Processing 3 on thread 6
Processing 2 on thread 5
Processing 5 on thread 8
Processing 4 on thread 7


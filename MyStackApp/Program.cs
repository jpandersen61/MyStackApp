// See https://aka.ms/new-console-template for more information
using MyStackApp;

int stackSize = 5;
Console.WriteLine($"Testing with a stack with max size {stackSize}");
Console.WriteLine();
MyStack s = new MyStack(stackSize);
Console.WriteLine("Popping an empty stack -> MyStackIsEmptyException");
try
{
    s.Pop();
}
catch (MyStackIsEmptyException e)
{
    Console.WriteLine("Exception received: " + e.Message);
}

Console.WriteLine();
int testStackElement = 42;
Console.WriteLine($"Pushing stack element {testStackElement}");
s.Push(testStackElement);

Console.WriteLine("Popping stack element");
int poppedStackElement = s.Pop();
Console.WriteLine($"Popped stack element {poppedStackElement} - OK: {testStackElement==poppedStackElement}");

Console.WriteLine();
Console.WriteLine($"Filling up stack with {stackSize} elemnets");
for (int i = 0; i < stackSize; i++)
{
    s.Push(i);
}
Console.WriteLine($"Pushing stack element {testStackElement}");
Console.WriteLine("Pushing on a full stack -> MyStackIsFullException");
try
{
    s.Push(testStackElement);
}
catch (MyStackIsFullException e)
{
    Console.WriteLine("Exception received: " + e.Message);
}




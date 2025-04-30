public class Stack
{
    public Stack()
    {
        StackMenu();
    }
    private List<object> _stackObjects = new List<object>();
    public void StackMenu()
    {
        Console.WriteLine("Welcome to Ihsan Stack. What would you like to do now? Please note that the stack is automatically empty at the very start of this app. Press any key to continue");
        Console.ReadKey();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Click:\n1 to Push to stack\n2 to Pop from stack \n3 to Clear stack\n0 to end app");
            string option = Console.ReadLine()!;
            switch (option)
            {
                case "1":
                    Console.WriteLine("Enter value to push to stack");
                    object pushedObject = (object)Console.ReadLine()!;
                    Push(pushedObject);
                    Console.WriteLine($"{pushedObject} pushed successfully! Press any key to continue");
                    Console.ReadKey(); break;
                case "2":
                    Console.WriteLine(Pop());
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(); break;
                case "3":
                    Clear();
                    Console.WriteLine("Stack cleared successfully! Press any key to continue");
                    Console.ReadKey(); break;
                case "0": return;
                default: Console.WriteLine("Invalid option! Kindly retry.");
                    Console.ReadKey(); break;
            }
        }
    }
    public void Push(object obj)
    {
        if (obj is null)
        {
            throw new InvalidCastException("Sorry the stack does not accept null values for now, maybe some other time.");
        }
        _stackObjects.Add(obj);
    }
    public object Pop()
    {
        if (_stackObjects.Count == 1)
        {
            Console.Write("Popping last object in stack... ");
        }
        if (!_stackObjects.Any())
        {
            throw new InvalidOperationException("Sorry stack is empty for now. Push an object to fill it, then come back.");
        }
        object anObject = _stackObjects.Last();
        _stackObjects.Remove(_stackObjects.Last());
        return anObject;
    }
    public void Clear()
    {
        _stackObjects.Clear();
    }
}
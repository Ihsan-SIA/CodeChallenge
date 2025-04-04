public class Stack
{
    private List<object> _stackObjects = new List<object>();
    public void StackMenu()
    {

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
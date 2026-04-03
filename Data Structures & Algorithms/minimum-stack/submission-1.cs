public class MinStack
{
    private Stack<int> s1 = new Stack<int>();
    private Stack<int> s2 = new Stack<int>();
    
    public void Push(int val)
    {
        s1.Push(val);
        if (s2.Count == 0 || val <= s2.Peek())
            s2.Push(val);
    }

    public void Pop()
    {
        int removed = s1.Pop();
        if (removed == s2.Peek())
            s2.Pop();
    }

    public int Top()
    {
        return s1.Peek();
    }

    public int GetMin()
    {
        return s2.Peek();
    }
}
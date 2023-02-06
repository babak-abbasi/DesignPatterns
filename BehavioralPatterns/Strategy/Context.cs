namespace DesignPatterns.BehavioralPatterns;

public class Context<T>
{
    private ISort<T> _sort;
    public Context(ISort<T> sort)
    {
        _sort = sort;
    }

    public void SetSort(ISort<T> sort)
    {
        _sort = sort;
    }

    public T[] Sort(T[] array)
    {
        return _sort.Sort(array);
    }
}
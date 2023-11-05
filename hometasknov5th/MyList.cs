using System;

public class MyList<T>
{
    private T[] items;  
    private int count;  

    public int Capacity { get; private set; }  

    public int Count { get { return count; } }  

   
    public MyList()
    {
        Capacity = 4;
        items = new T[Capacity]; 
        count = 0;  
    }
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException(); 
            }
            return items[index];  
        }
        set
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();  
            }
            items[index] = value;  
        }
    }
    public void Add(T item)
    {
        if (count == Capacity)
        {
            Capacity *= 2;  
            Array.Resize(ref items, Capacity);  
        }
        items[count] = item;  
        count++;  
    }
    public void Clear()
    {
        count = 0;  
        Array.Clear(items, 0, Capacity);  
    }
    //public bool Exist(T item)
    //{
    //   
    //}
    //public bool Remove(T item)
    //{
      
    //}

    public void Reverse()
    {
        Array.Reverse(items, 0, count); 
    }
    public int IndexOf(T item)
    {
        return Array.IndexOf(items, item, 0, count);  
    }
    public int LastIndexOf(T item)
    {
        return Array.LastIndexOf(items, item, count - 1, count);  
    }
}

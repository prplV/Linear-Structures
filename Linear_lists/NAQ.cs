using System;

namespace Linear_lists
{
  public class NAQ<T>
  {
    private List<T> queue;
    public int Count { get; private set; }
    static public int N_op = 0;
    public NAQ()
    {
      queue = new List<T>(); //1
      N_op++;
    }
    public void ClearAll()
    {
      queue.Clear();
      Count = 0; //1
      N_op += 3;
    }
    public bool ContainsAtQueue(T key)
    {
      N_op += 2;
      foreach (T item in queue) //Count итераций - max
      {
        N_op += 6;
        if (key.Equals(item)) // 3
        {
          N_op += 4;
          return true; // 1
        }
      }
      N_op ++;
      return false; // 1
    }
    public void EnQueue(T item)
    {
      N_op += 4;
      queue.Add(item); // 3
      Count++; // 1
    }
    public T DeQueue()
    {
      T c = queue[0]; // 1
      queue.Remove(c); // 3
      Count--; // 1
      N_op += 6;
      return c; // 1
    }
    public void DeQueueAll()
    {
      int count = Count; // 1
      N_op += 3;
      for (int i = 0; i < count; i++) // Count итераций 
      {
        N_op += 5;
        Console.Write(DeQueue() + " "); // 3
      }
      N_op += 2;
      Console.WriteLine(); // 2
    }
    public T[] CopyToArray()
    {
      int count = Count; // 1
      T[] array = new T[count]; // 1
      N_op += 4;
      for (int i = 0; i < count; i++) // Count итераций 
      {
        N_op += 5;
        array[i] = queue[i]; // 3
      }
      N_op ++;
      return array; // 1
    }
    public void CopyFromArray(T[] array)
    {
      N_op += 4;
      for (int i = 0; i < array.Length; i++) // Count итераций
      {
        N_op += 7;
        queue[i] = array[i]; // 3
      }
      Count = array.Length; // 3
      N_op += 3;
    }
  }
}
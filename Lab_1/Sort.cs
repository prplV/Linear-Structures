using Linear_lists;
using System.Diagnostics;

namespace Lab_1
{
  class Sort
  {
    static public int N_q;
    static public Stopwatch timer = new Stopwatch();
    static public long freq = Stopwatch.Frequency;
    public static void Hoar(NAQ<int> nq)
    {
      timer.Start();
      int[] naq = nq.CopyToArray(); // 3
      Quicksort(naq, 0, naq.Length - 1); // 5

      nq.CopyFromArray(naq); // 4
      
      N_q = N_q + 11;
    }
    private static int Partition(int[] arr, int start, int end)
    {
      int key = start; // 1
      N_q++;
      N_q = N_q + 2;
      for (int i = start; i <= end; i++) // end - start + 1 итераций  
      {
        N_q += 2;
        if (arr[i] <= arr[end]) // 3
        {
          N_q += 11;
          int temp = arr[key]; // 2
          arr[key] = arr[i]; // 3
          arr[i] = temp; // 2
          key++; // 1
        }
      }
      N_q += 5;
      return key - 1; // 2
    }
    private static void Quicksort(int[] array, int start, int end)
    {
      N_q += 1;
      if (start >= end) // 2 в любом случае 
      {
        N_q += 2;
        return;
      }
      int pivot = Partition(array, start, end); // 6
      Quicksort(array, start, pivot-1); // 6
      Quicksort(array, pivot + 1, end); // 6
      N_q += 18;
      timer.Stop();
    }

  }
}

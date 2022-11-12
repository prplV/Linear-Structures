using Linear_lists;

namespace Lab_1
{
  class Program
  {
    static void Main()
    {
      Random random = new Random();

      NAQ<int> students = new NAQ<int>();
      int[] tests = new int[10] { 300, 600, 900, 1200, 1500, 1800, 2100, 2400, 2700, 3000 };

      for (int i = 0; i < tests.Length; i++)
      {
        for (int j = 0; j < tests[i]; j++)
        {
          students.EnQueue(random.Next(10));
        }
        Sort.Hoar(students);
        Console.WriteLine($"Опыт {i+1}:\n *** Кол-во отсортированных элементов - {tests[i]}\n *** Время сортировки - {(double)Sort.timer.ElapsedTicks/Sort.freq} cек\n *** Кол-во операций - {NAQ<int>.N_op + Sort.N_q}\n");
        students.ClearAll();
        Sort.N_q = 0;
        NAQ<int>.N_op = 0;
      }
    }
  }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Random rand = new Random();
        int result = 0;
        int[] array = new int[25];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(99999);
            Console.WriteLine(array[i]);
            result += array[i];
        }
        Console.WriteLine($"Результат суммы {result}");
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(99999);
            result = array[i] * array[i];
        }
        Console.WriteLine($"Результат умножения {result}");






        /* int summa = 0;
         for (int  i = 0; i < 25 ; i ++)
         { 
             summa = array[i] + summa;
         }
         Console.WriteLine($"Сумма равна {summa}");
         int mnoj = 0;
         for (int i = 0; i < 25; i++)
         {
             mnoj = array[i] * mnoj;
         }
         Console.WriteLine($"Умножение чисел равно {mnoj}");
        */
    }
}
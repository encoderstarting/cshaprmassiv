public class tasknumber3
{
    public static void Run()
    {
        Console.WriteLine("Введите сколько элементов должно быть в массиве: ");
        if (!int.TryParse(Console.ReadLine(), out int chouse))
        {
            Console.WriteLine("Введите значение!");
        }
        int[] myLine = new int[chouse];
        int sum = 0;
        for (int i = 0; i < myLine.Length; i++)
        {
            Console.WriteLine($"Введите элемент массива под индексом {i}:\t ");
            myLine[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Вывод суммы четных элементов массива: ");
        for (int i = 0; i < myLine.Length; i++)
        {
            if (myLine[i] % 2 == 0)
            {
                sum += myLine[i];

            }

        }
        Console.WriteLine(sum);
    }
}

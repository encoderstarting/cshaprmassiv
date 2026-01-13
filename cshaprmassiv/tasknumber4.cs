public class tasknumber4
{
    public static void Run()
    {

        Console.WriteLine("Введите сколько элементов должно быть в массиве: ");
        if (!int.TryParse(Console.ReadLine(), out int chouse))
        {
            Console.WriteLine("Введите значение!");
        }
        int[] myLine = new int[chouse];
        for (int i = 0; i < myLine.Length; i++)
        {
            Console.WriteLine($"Введите элемент массива под индексом {i}:\t ");
            myLine[i] = int.Parse(Console.ReadLine());
        }
        int min = myLine[0];
        Console.WriteLine("Вывод наименьшего числа в массиве: ");
        for (int i = 1; i < myLine.Length; i++)
        {

            if (min > myLine[i])
            {
                min = myLine[i];
            }

        }
        Console.WriteLine(min);
    }
}
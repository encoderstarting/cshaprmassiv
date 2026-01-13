public class tasknumber2
{
    public static void Run()
    {
        Console.WriteLine("Введите сколько элементов должно быть в массиве: ");
        if (!int.TryParse(Console.ReadLine(), out int chouse))
        {
            Console.WriteLine("Введите значение!");
        }
        int[] myArray = new int[chouse];
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine($"Введите элемент массива под индексом{i}: ");
            myArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Вывод массива в обратном порядке: ");
        for (int i = -1; i < myArray.Length; i--)
        {
            Console.WriteLine(myArray[i]);
        }








    }
}

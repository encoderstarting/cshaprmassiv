public class tasknumber2
{
    public static void Run()
    {
        Console.WriteLine("Введите сколько элементов должно быть в массиве: ");
        if (!int.TryParse(Console.ReadLine(), out int chouse))
        {
            Console.WriteLine("Введите значение!");
        }








    }
}

Console.WriteLine("Сколько хотите элементов в массиве? Введите ниже...");
if (!int.TryParse(Console.ReadLine(), out int value))
{
    Console.WriteLine("Введите значение!");
    return;
}

int[] myArray = new int[value];
for(int i = 0;i < myArray.Length; i++)
{
    Console.WriteLine($"Введите элемент массива под индексом {i}:\t ");
    myArray[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Вывод массива: ");
for(int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);

}

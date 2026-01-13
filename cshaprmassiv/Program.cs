while (true)
{
    Console.WriteLine("\nМеню: ");
    Console.WriteLine("1 - Вывести массив с клавиатуры самостоятельно");
    Console.WriteLine("2 - Вывести массив в обратном порядке");
    Console.WriteLine("3 - Вывести сумму четных элемнтов массива");
    Console.WriteLine("4  - Вывести наименьший элемент массива");
    Console.WriteLine("0 - выход");
    string choise = Console.ReadLine();
    switch (choise)
    {
        case "1":
            Console.WriteLine("Ввод масива...");
            tasknumber1.Run();
            break;
        case "2": Console.WriteLine("Вывод массива в обратном порядке..."); tasknumber2.Run(); break;
        case "3": Console.WriteLine("Вывод суммы четных элементов..."); tasknumber3.Run(); break;
        case "4": Console.WriteLine("Вывод наименьшего элемента массива...");tasknumber4.Run(); break;
        case "0": Console.WriteLine("Выход из меню"); break;
        default: Console.WriteLine("Такого варианта нет в меню!"); continue;
    }
 
}










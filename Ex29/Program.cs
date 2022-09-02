// Программа заполняет массив рандомными числами из вводимых пользователем числа элементов
// массива, минимального и максимального эементов массива"
Console.WriteLine("Введите количество элементов массива: ");
int q = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = new int[q];

if(min < max)
{
    int Method (int a)
    {
        return array[a];
    }
    
    Console.WriteLine("Ваш массив:");
    
    for (int i = 0; i < q; i++)
    {
        array[i] = new Random().Next(min, max+1);

        Console.WriteLine(" " + Method(i) + " ");
    }
}
else
{
    System.Console.WriteLine("Минимальный и максимальный элементы массива некорректны");
}


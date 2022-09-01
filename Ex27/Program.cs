// Напишите программу, которая принимает на вход целое число и выдает сумму цифр в числе
Console.WriteLine("Введите натуральное число, я посчитаю сумму цифр в числе");
Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int a = A;
int sum = 0;
while (Math.Abs(a) > 0)
{
    int number = a % 10;
    a = a / 10;
    sum = sum + number;
}
Console.WriteLine($"Сумма всех цифр в числе {A} равна {Math.Abs(sum)}");

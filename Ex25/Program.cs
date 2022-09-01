// Ввод чисел А и В, возведение А в натуральную степень В
Console.WriteLine("Введите числ А и В, я возведу число А в натуральную степень В");
Console.WriteLine("Введите число А: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число B: ");
double b = Convert.ToDouble(Console.ReadLine());
int natural_b = Convert.ToInt32(b);

double result = Math.Pow(a, Math.Abs(natural_b));

Console.WriteLine($"Число {a} в натуральной степени {b} равно {result}");

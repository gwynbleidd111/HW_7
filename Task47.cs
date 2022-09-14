//Задача 47________________________________________________________________

Console.Write("Введите количество строк: ");
bool isM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);

double[,] result = CreateRandomArray(m,n);
Print2DArray(result);

if (!isM || !isN){
    Console.WriteLine("Введите число.");
    return;
}
double[,] CreateRandomArray(int m, int n){
    double[,] a = new double[m, n];
    Random random = new Random();

    for (int i = 0; i < a.GetLength(0); i++){
        for (int j = 0; j < a.GetLength(1); j++){
            a[i, j] = random.Next(-9, 10) + random.NextDouble();
        }
    }
    return a;
}

void Print2DArray(double[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(a[i, j], 1)} ");
        }
        Console.WriteLine();
    }
}

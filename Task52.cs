//Задача 52________________________________________________________________

Console.Write("Введите количество строк: ");
bool isM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);

int[,] result = CreateRandomArray(m, n);
Console.WriteLine("");
Console.WriteLine("Массив:");
Print2DArray(result);
Console.WriteLine("");
Console.Write("Среднее арифметическое каждого столбца: ");
GetAverage(result);




int[,] CreateRandomArray(int m, int n){
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i,j] = random.Next(0,11);
        }
    }

    return array;
}

void Print2DArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void GetAverage(int[,] array){
    double line = Convert.ToDouble(m);
    double average = 0;
    for (int i = 0; i < array.GetLength(1); i++){
        int sum = 0;
        
        for (int j = 0; j < array.GetLength(0); j++){
            sum = sum + array[j,i];
        }
        double sum_double = Convert.ToDouble(sum);
        average = sum_double/line;
        Console.Write($"{Math.Round(average, 1)}; ");
    }
}

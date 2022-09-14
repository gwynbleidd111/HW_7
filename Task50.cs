//Задача 50________________________________________________________________

Console.Write("Введите количество строк: ");
bool isM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);
Console.Write("Введите искомое число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);

int[,] result = CreateRandomArray(m, n);
Print2DArray(result);
GetIndexes(result);


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

void GetIndexes(int[,] array){
    int line = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if(number == array[i,j]){
                line = i;
                column = j;
                Console.WriteLine($"Индексы числа {number} равны ({line},{column}).");
            }

        }
    }
    if(line == 0 && column == 0){
            Console.WriteLine("Такого числа нет.");
        }
    
}

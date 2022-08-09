void Zadacha1(){

   // Задайте массив заполненный случайными положительными трёхзначными числами. 
    // Напишите программу, которая покажет количество чётных чисел в массиве.

    Console.Write("Задайте длинну массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    FillArray(array, 100, 999);
    PrintArray(array);
    EvenNum(array);
}

void Zadacha2(){

    // Задайте одномерный массив, заполненный случайными числами. 
    // Найдите сумму элементов, стоящих на нечётных позициях.

    Console.Write("Задайте длинну массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    SumOddIndexNum(array);
}

void Zadacha3(){
    // Задайте массив вещественных чисел. 
    // Найдите разницу между максимальным и минимальным элементов массива.
    
    Console.Write("Задайте длинну массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[size];
    FillArrayDouble(array, -100, 100);
    PrintArrayDouble(array);
    DifMinMaxDouble(array);
}

void PrintArray(int[] array){
    int size = array.Length;

    for(int i = 0; i < size; i++){
        Console.Write(array[i] + ", ");
    }
    Console.Write("\b\b.");
    Console.WriteLine();
}

void FillArray(int[] array, int startNumber = 0, int finishNumber = 100){
    finishNumber++;
    int size = array.Length;
    Random random = new Random();

    for(int i = 0; i < size; i++){
        array[i] = random.Next(startNumber, finishNumber);
    }
}

void SortArray(int[] array){
    int size = array.Length;

    for(int i = 0; i < size; i++){
        int minPosition = i;

        for(int j = i; j < size; j++){
            if(array[j] < array[minPosition]){
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void EvenNum(int[] array){
    int size = array.Length;
    int result = 0;
    for(int i = 0; i < size; i++){
        if(array[i] % 2 == 0){
            result++;
        }
    }
    Console.Write("Кол-во чётных чисел: " + result);
}

void SumOddIndexNum(int[] array){
    int size = array.Length;
    int sum = 0;
    for(int i = 0; i < size; i += 2){
        sum += array[i];
    }
    Console.WriteLine("Сумма нечётнх эл-тов: " + sum);
}

void FillArrayDouble(double[] array, int startNum = 0, int finishNum = 100){
    int size = array.Length;
    Random random = new Random();

    for(int i = 0; i < size; i++){
        array[i] = Math.Round(random.Next(startNum, finishNum) + random.NextDouble(), 2);
    }
}

void PrintArrayDouble(double[] array){
    int size = array.Length;

    for(int i = 0; i < size; i++){
        Console.Write(array[i] + ", ");
    }
    Console.Write("\b\b.");
    Console.WriteLine();
}

void DifMinMaxDouble(double[] array){
    int size = array.Length;
    int maxPos = 0;
    int minPos = 0;

    for(int i = 0; i < size; i++){
        if(array[i] < array[minPos]){
            minPos = i;
        }
    }

    for(int i = 0; i < size; i++){
        if(array[i] > array[maxPos]){
            maxPos = i;
        }
    }

    double result = Math.Round(array[maxPos] - array[minPos], 2);
    Console.WriteLine("Разница: " + result);
}

// Zadacha1();
// Zadacha2();
Zadacha3();
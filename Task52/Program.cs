// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.WriteLine("Введите количество строк двумерного массива");
int rowCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columnCount = int.Parse(Console.ReadLine());

int [,] array = FillArray (rowCount, columnCount, 1, 10);
PrintArray(array);

CalculateAverageSum(array);

int [,] FillArray (int rows, int colunms, int min, int max){
    int [,] filledArray = new int[rows, colunms];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < colunms; j++){
            filledArray[i, j] = new Random().Next(min,max+1);
        }
    }
    return filledArray;
}

void PrintArray (int [,] inputArray){
    for(int i = 0; i < inputArray.GetLength(0); i++) {
        for(int j = 0; j < inputArray.GetLength(1); j++) {
        Console.Write(" " + inputArray[i, j]);
        }
Console.WriteLine();
    }
    
}

void CalculateAverageSum (int [,] inputArray){
     
    for(int j = 0; j < inputArray.GetLength(1); j++) {
        
        double Sum = 0;            
       
        for(int i = 0; i < inputArray.GetLength(0); i++) {
        
        Sum += inputArray[i, j];
    }  
    Console.WriteLine("Среднее арифметическое " + j + " столбца " + Sum/inputArray.GetLength(0));
        }
  
}
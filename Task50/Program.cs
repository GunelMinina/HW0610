// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк двумерного массива");
int rowCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columnCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите номер строки");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите номер столбца");
int y = int.Parse(Console.ReadLine());

int [,] array = FillArray (rowCount, columnCount, 1, 10);
PrintArray(array);

if(x > rowCount || y > columnCount){
    Console.WriteLine("такого элемента нет"); 
}
else {
    Console.WriteLine("Элемент " + array[x,y]);
}

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

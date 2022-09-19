            // 1 Задача. 
            // Задайте массив заполненный случайными положительными трёхзначными числами.
            // Напишите программу, которая покажет количество чётных чисел в массиве.





// int[] GeneratArray(int length){
//   var array = new int[length];
//     var random = new Random();

//     for (var i = 0; i < array.Length; i++){
//         array[i] = random.Next(100, 1000);
//     }
//     return array;
// }

// void PrintArray(int[] array){
// for ( var i = 0 ; i< array.Length; i++){
//     Console.WriteLine(array [i] + ", ");
// }
// Console.WriteLine();}

//  int SumPositiveNumbers(int[] array){
// var Count = 0;
//  for ( var i = 0 ; i< array.Length; i++){
//     if (array[i] % 2 == 0)
//    Count ++;
  
//  }

//     return Count;
// }

// var array = GeneratArray(4);
// PrintArray(array);

// var PositiveSum = SumPositiveNumbers(array);
// Console.WriteLine($" Чётных чичел - {PositiveSum}");



        // //   2 Задача
        //  Задайте одномерный массив, заполненный случайными числами.
        //   Найдите сумму элементов, стоящих на нечётных позициях.



// int[] GeneratArray(int length){
//   var array = new int[length];
//     var random = new Random();

//     for (var i = 0; i < array.Length; i++){
//         array[i] = random.Next(1, 10);
//     }
//     return array;
// }

// void PrintArray(int[] array){
// for ( var i = 0 ; i< array.Length - 1; i++){
//     Console.Write(array [i] + ", ");
// }
// Console.WriteLine(array[array.Length - 1]);}

//  int SumPositiveNumbers(int[] array){
// var sum = 0;
//  for ( var i = 0 ; i< array.Length; i+=2){
//    sum = sum + array [i];
//  }

//     return sum;
// }

// var array = GeneratArray(6);
// PrintArray(array);

// var PositiveSum = SumPositiveNumbers(array);
// Console.WriteLine($"Сумма  чиcел стоящих на нечётных позициях = {PositiveSum}");



                // 3 задача .
                // Задайте массив вещественных чисел. 
                // Найдите разницу между максимальным и минимальным элементов массива.


double[] GetArray(int length)
{
    double [] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine(array[array.Length-1] );
}

double NambMin(double[] array){
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min){
            min = array[i];
        }
    }
    return min;
}

double NambMax(double[] array){
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > max){
            max = array[i];
        }
        }
    return max;
}

double [] array = GetArray(6);
PrintArray(array);
double minPosition = NambMin(array);
double maxPosition = NambMax(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {maxPosition - minPosition}");
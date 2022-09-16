                // 1 Задача

// Console.Write("введите число : ");
// int i = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите степень : ");
// int n = Convert.ToInt32(Console.ReadLine());

//    System.Console.WriteLine(Math.Pow(i,n));



                //  2 Задача


// Console.Write("Введите число : ");
// int n = Convert.ToInt32(Console.ReadLine());

//   int Sum(int n){
    
//     int counter = Convert.ToString(n).Length;
//     int advance = 0;
//     int result = 0;

//     for (int i = 0; i < counter; i++){
//       advance = n - n % 10;
//       result = result + (n - advance);
//       n = n / 10;
//     }
//    return result;
//   }

// int sum = Sum(n);
// Console.WriteLine("Сумма цифр в числе: " + sum);


            // 3 Задача

int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}
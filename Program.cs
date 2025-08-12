//Task 1
// int n = Convert.ToInt32(Console.ReadLine());
// int even = 0;
// int odd = 0;
// int zeros = 0;
// int digits = 0;
// int min = 9;
// int max = 0;
// int sum = 0;
// if (n == 0)
// {
//     zeros = 1;
//     even = 1;
//     digits = 1;
//     min = 0;
//     max = 0;
// }
//
// while (n > 0)
// {
//     int digit = n % 10;
//
//     if (digit % 2 == 0) even++;
//     else odd++;
//
//    if (digit == 0) zeros++;
//
//    if (digit < min) min = digit;
//    if (digit > max) max = digit;
//
//    sum += digit;
//    digits++;
//
//     n /= 10;
// }
//
// Console.WriteLine("Even : " + even);
// Console.WriteLine("Odd : " + odd);
// Console.WriteLine("Zeros : " + zeros);
// Console.WriteLine("Digits : " + digits);
// Console.WriteLine("Min : " + min);
// Console.WriteLine("Max : " + max);
// Console.WriteLine(" Sum of Digits:" + sum);
 // Task2
//char CheckGrade(int n)
//{
//    if (n >= 90 && n <= 100)
//    {
//        return 'A';
//    }
//    else if (n >= 80 && n <= 89)
//    {
//        return 'B';
//    }
//    else if (n >= 70 && n <= 79)
//    {
//        return 'C';
//    }
//    else if (n >= 60 && n <= 69)
//    {
//        return 'D';
//    }
//    else
//    {
//        return 'F';
//    }
//}
//int n = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine(CheckGrade(n));



// Task3
// int[] arr = new int[6];
// int Negative = 0;
// int Positive = 0;
// int Zeros = 0;
// int Even = 0;
// int Odd = 0;
// int Max = -99999;
// int Min = 99999;
// int Sum = 0; 
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] < 0)
//     {
//         Negative++;
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] >= 0)
//     {
//         Positive++;
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] == 0)
//     {
//         Zeros++;
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] % 2 == 0 && arr[i] != 0)
//     {
//         Even++;
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] % 2 != 0)
//     {
//         Odd++;
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > Max)
//     {
//         Max = arr[i];
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] < Min)
//     {
//         Min = arr[i];
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     Sum += arr[i];
// }
// System.Console.WriteLine("Negative = " + Negative);
// System.Console.WriteLine("Positive = " + Positive);
// System.Console.WriteLine("Zeros = " + Zeros);
// System.Console.WriteLine("Even = " + Even);
// System.Console.WriteLine("Odd = " + Odd);
// System.Console.WriteLine("Max = " + Max);
// System.Console.WriteLine("Min = " + Min);
// System.Console.WriteLine("Sum = " + Sum);



// Task4
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (i % 2 == 0)
//     {
//     System.Console.Write(arr[i] + " ");
//    }
// }





// Task5
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// int count = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 1; i < n; i++)
// {
//     if (arr[i] > arr[i - 1])
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);




// Task6
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         if (i != j && arr[i] == arr[j])
//         {
//             Console.Write(arr[i] + " ");
//             break; 
//         }
//     }
// }
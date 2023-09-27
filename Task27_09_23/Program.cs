// Task 1

// int num;
// int remaind;
// Console.WriteLine("Eded daxil edin: ");
// num = Convert.ToInt32(Console.ReadLine());

// if (num == 2)
//     Console.Write("2-in quvvetidir");
// else
// {
//     while (num >= 2)
//     {
//         remaind = num % 2;
//         if (remaind != 0)
//             break;
//         num /= 2;
//     }
//     if (num == 2)
//         Console.WriteLine("2-in quvvetidir");
//     else
//         Console.WriteLine("2-in quvveti deyil");
// }


// Task 2

// Console.Write("Eded daxil edin: ");
// int n = int.Parse(Console.ReadLine());

//         if (n <= 0)
//         {
//             Console.WriteLine("Musbet eded daxil edin");
//             return;
//         }

//         int totalDigits = 0;

//         for (int i = 1; i <= n; i++)
//         {
//             int temp = i;

//             while (temp > 0)
//             {
//                 totalDigits++;
//                 temp /= 10;
//             }
//         }

//         Console.WriteLine($"1 ve {n} arasinda cemi {totalDigits} reqem var.");

// Task 3

// int n,i,sum;
// Console.Write("Eded daxil edin: ");
// n= Convert.ToInt32(Console.ReadLine());  
// sum = 0;
// Console.Write("Bolenleri: ");
// for (i=1;i<n;i++)
// {
//     if(n%i==0)
//     {
//          sum=sum+i;
//          Console.Write("{0}  ",i);
//     }
// }
// Console.Write("\nBolenlerin cemi: {0}",sum);
// if(sum==n)
//     Console.Write("\nMukemmel ededdir");
// else
//     Console.Write("\nMukemmel eded deyil");
//     Console.Write("\n");


// Task 4

// Console.Write("Eded daxil edin: ");
// int num10 = Convert.ToInt32(Console.ReadLine()); // 10-luq say sisteminde 
// int a = 0; // a - ikilik say sistemində ədədin əmələ gəldiyi % bölgüsündən sonra qalıq
// int i = 0;

// int[] b = new int[10]; // düzgün göstərilməsi üçün ikili nömrənin sonradan sonundan çap ediləcəyi massiv

// while (num10 >= 1)
// {
//     a = num10 % 2;
//     b[i] = a;
//     i++;

//     num10 = num10 / 2;

//     Console.Write(a);
// };

// Console.WriteLine();

// for (i = (b.Length - 1); i >= 0; i--)
// {
//     Console.Write(b[i]);
// }

// Task 5

// Console.Write("Musbet eded daxil edin: ");
// int number = int.Parse(Console.ReadLine());

// if (number <= 0)
// {
//    Console.WriteLine("Musbet eded qeyd edin");
//    return;
// }

// int largeDigit = int.MinValue;
// int smallDigit = int.MaxValue;

// while (number > 0)
// {
//    int digit = number % 10; 

//    if (digit > largeDigit)
//    {
//        largeDigit = digit;
//    }

//    if (digit < smallDigit)
//    {
//        smallDigit = digit;
//    }

//    number /= 10; 
// }

// int product = largeDigit * smallDigit;

// Console.WriteLine($"Boyuk reqem: {largeDigit}");
// Console.WriteLine($"Kichik reqem: {smallDigit}");
// Console.WriteLine($"Boyuk və Kichik reqemlerin hasili: {product}");

//Task 6

Console.Write("Setirlerin sayini daxil edin: ");
int numRows = int.Parse(Console.ReadLine());

if (numRows <= 0)
{
   Console.WriteLine("Musbet reqem yazin");
   return;
}

for (int i = 1; i <= numRows; i++)
{
   for (int j = 1; j <= i; j++)
   {
       Console.Write("*");
   }
   Console.WriteLine();
}
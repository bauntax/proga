// //lab 1 zavd 1 (var 20)
// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Collections.Specialized;
// using System.Runtime.CompilerServices;

// class Program{
//     static void Main(){

//   string filePath = "banana.txt";
//         List<char> charList = ReadFile(filePath);

//         (int golos, int prigolos) = Count2(charList);

//         Console.WriteLine($"кількість голосних: {golos}");
//         Console.WriteLine($"кількість приголосних: {prigolos}");
//     }

//     static List<char> ReadFile(string path)
//     {
//         List<char> words = new List<char>();
//         {
//             string content = File.ReadAllText(path);
//             foreach (char c in content)
//             {
//                 words.Add(c);
//             }
//         }
//         return words;
//     }

//     static (int golos, int prigolos) Count2(List<char> chars)
//     {
//         HashSet<char> golosSet = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'y', 
//                                                       'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я' };

//         int golos = 0, prigolos = 0;

//         foreach (char c in chars)
//         {
//             {
//                 if (golosSet.Contains(c))
//                     golos++;
//                 else
//                     prigolos++;
//             }
//         }
//         return (golos,prigolos);
//     }
// }


// завд 2
// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         List<Dictionary<string, string>> inputDicts = new List<Dictionary<string, string>>
//         {
//             new Dictionary<string, string> { { "V", "S001" } },
//             new Dictionary<string, string> { { "V", "S002" } },
//             new Dictionary<string, string> { { "VI", "S001" } },
//             new Dictionary<string, string> { { "VI", "S005" } },
//             new Dictionary<string, string> { { "VII", "S005" } },
//             new Dictionary<string, string> { { "V", "S009" } },
//             new Dictionary<string, string> { { "VIII", "S007" } }
//         };

//         HashSet<string> uniqueValues = new HashSet<string>();
//         foreach (var dict in inputDicts)
//         {
//             foreach (var pair in dict)
//             {
//                 uniqueValues.Add(pair.Value);
//             }
//         }
//         Console.WriteLine($"UniqueValues: {{ {string.Join(", ", uniqueValues)} }}");
//     }
// }


//завд 3

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введіть цифру D (0-9): ");
        int D = int.Parse(Console.ReadLine());

        Console.Write("Введіть послідовність чисел: ");
        int[] A = Console.ReadLine()
                         .Split(' ')       
                         .Select(int.Parse)   
                         .ToArray(); 

        int result = A.Where(x => x > 0 && x % 10 == D)  
                      .DefaultIfEmpty(0)                
                      .First();                     

     
        Console.WriteLine($"Рез: {result}");
    }
}





















// ЧМ

    // метод хорд

//         using System;
// using System.Text;

// namespace PraktChord
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.OutputEncoding = Encoding.UTF8;
//             double a, b;
//             double accur1 = Math.Pow(10, -4);
//             double accur2 = Math.Pow(10, -5);
//             double accur3 = Math.Pow(10, -6);

//             Console.Write("Введите a: ");
//             a = double.Parse(Console.ReadLine());
//             Console.Write("Введите b: ");
//             b = double.Parse(Console.ReadLine());

//             Console.WriteLine("Решение для f(x):");
//             MethodChord(a, b, accur1, 1);
//             MethodChord(a, b, accur2, 1);
//             MethodChord(a, b, accur3, 1);

//             Console.WriteLine("Решение для g(x):");
//             MethodChord(a, b, accur1, 2);
//             MethodChord(a, b, accur2, 2);
//             MethodChord(a, b, accur3, 2);

//             Console.ReadKey();
//         }

//         private static double FunctionF(double x)
//         {
//             return Math.Pow(x, 4) - 11 * Math.Pow(x, 2) + 24;
//         }

//         private static double FunctionG(double x)
//         {
//             return Math.Pow(x, 4) - 6 * Math.Pow(x, 2) + 9;
//         }

//         private static void MethodChord(double a, double b, double accur, int funcType)
//         {
//             double xPrev = b, xNext = a;
//             double fa, fb, fx;
//             int count = 0;

//             do
//             {
//                 if (funcType == 1)
//                 {
//                     fa = FunctionF(a);
//                     fb = FunctionF(b);
//                 }
//                 else
//                 {
//                     fa = FunctionG(a);
//                     fb = FunctionG(b);
//                 }

//                 xPrev = xNext;
//                 xNext = b - fb * ((b - a) / (fb - fa));

//                 fx = funcType == 1 ? FunctionF(xNext) : FunctionG(xNext);

//                 if (fa * fx < 0)
//                 {
//                     b = xNext;
//                     fb = fx;
//                 }
//                 else if (fx * fb < 0)
//                 {
//                     a = xNext;
//                     fa = fx;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Відрізок не має коренів");
//                     return;
//                 }
                
//                 count++;
//             } while (Math.Abs(xNext - xPrev) > accur);

//             Console.WriteLine($"x = {xNext}, f(x) = {fx}, точность = {accur}, итерации = {count}");
//         }
//     }
// }








// метод бісекції

// using System;
// using System.Text;

// namespace PraktBisect
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.OutputEncoding = Encoding.UTF8;
//             double a, b;
//             double accur1 = Math.Pow(10, -4);
//             double accur2 = Math.Pow(10, -5);
//             double accur3 = Math.Pow(10, -6);

//             Console.Write("Введите a: ");
//             a = double.Parse(Console.ReadLine());
//             Console.Write("Введите b: ");
//             b = double.Parse(Console.ReadLine());

//             Console.WriteLine("Решение для f(x):");
//             MethodBisect(a, b, accur1, 1);
//             MethodBisect(a, b, accur2, 1);
//             MethodBisect(a, b, accur3, 1);

//             Console.WriteLine("Решение для g(x):");
//             MethodBisect(a, b, accur1, 2);
//             MethodBisect(a, b, accur2, 2);
//             MethodBisect(a, b, accur3, 2);

//             Console.ReadKey();
//         }

//         private static double FunctionF(double x)
//         {
//             return Math.Pow(x, 4) - 11 * Math.Pow(x, 2) + 24;
//         }

//         private static double FunctionG(double x)
//         {
//             return Math.Pow(x, 4) - 6 * Math.Pow(x, 2) + 9;
//         }

//         private static void MethodBisect(double a, double b, double accur, int funcType)
//         {
//             double fa, fb, fm;
//             int count = 0;

//             do
//             {
//                 double m = (a + b) / 2;
                
//                 if (funcType == 1)
//                 {
//                     fa = FunctionF(a);
//                     fb = FunctionF(b);
//                     fm = FunctionF(m);
//                 }
//                 else
//                 {
//                     fa = FunctionG(a);
//                     fb = FunctionG(b);
//                     fm = FunctionG(m);
//                 }

//                 if (fa * fm < 0)
//                 {
//                     b = m;
//                     fb = fm;
//                 }
//                 else if (fm * fb < 0)
//                 {
//                     a = m;
//                     fa = fm;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Відрізок не має коренів");
//                     return;
//                 }
                
//                 count++;
//             } while (Math.Abs(b - a) > 2 * accur);

//             Console.WriteLine($"x = {(a + b) / 2}, f(x) = {FunctionF((a + b) / 2)}, точность = {accur}, итерации = {count}");
//         }
//     }
// }






// метод січних

// using System;
// using System.Text;

// namespace Prakt
// {
//     class Program
//     {
//         static void Main()
//         {
//             Console.OutputEncoding = Encoding.UTF8;

//             double xn1, xn2;
//             double accuracy1 = Math.Pow(10, -4);
//             double accuracy2 = Math.Pow(10, -5);
//             double accuracy3 = Math.Pow(10, -6);

//             Console.Write("Введіть a: ");
//             xn1 = double.Parse(Console.ReadLine());

//             Console.Write("Введіть b: ");
//             xn2 = double.Parse(Console.ReadLine());

//             Console.WriteLine("f(x):");
//             ChordMethod(xn1, xn2, accuracy1, 1);
//             ChordMethod(xn1, xn2, accuracy2, 1);
//             ChordMethod(xn1, xn2, accuracy3, 1);

//             Console.WriteLine("\ng(x):");
//             ChordMethod(xn1, xn2, accuracy1, 2);
//             ChordMethod(xn1, xn2, accuracy2, 2);
//             ChordMethod(xn1, xn2, accuracy3, 2);

//             Console.ReadKey();
//         }
//         private static double FunctionF(double x)
//         {
//             return Math.Pow(x, 4) - 11 * Math.Pow(x, 2) + 24;
//         }

//         private static double FunctionG(double x)
//         {
//             return Math.Pow(x, 4) - 6 * Math.Pow(x, 2) + 9;
//         }

//         private static void ChordMethod(double xn1, double xn2, double accuracy, int functionChoice)
//         {
//             double xn3;
//             double fxn1, fxn2;
//             int iterationCount = 0;

//             do
//             {
//                 fxn1 = (functionChoice == 1) ? FunctionF(xn1) : FunctionG(xn1);
//                 fxn2 = (functionChoice == 1) ? FunctionF(xn2) : FunctionG(xn2);

//                 xn3 = xn2 - (fxn2 / (fxn2 - fxn1)) * (xn2 - xn1);
//                 xn1 = xn2;
//                 xn2 = xn3;
//                 iterationCount++;
//             } while (Math.Abs(xn2 - xn1) > accuracy);

//             Console.WriteLine($"x = {xn3}, f(x) = {fxn2}, with accuracy = {accuracy}, iterations: {iterationCount}");
//         }
//     }
// }










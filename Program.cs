// //lab 1 zavd 1 (var 20)
using System;
using System.Collections.Generic;
using System.IO;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

class Program{
    static void Main(){

  string filePath = "banana.txt";
        List<char> charList = ReadFile(filePath);

        (int golos, int prigolos) = Count2(charList);

        Console.WriteLine($"кількість голосних: {golos}");
        Console.WriteLine($"кількість приголосних: {prigolos}");
    }

    static List<char> ReadFile(string path)
    {
        List<char> words = new List<char>();
        {
            string content = File.ReadAllText(path);
            foreach (char c in content)
            {
                words.Add(c);
            }
        }
        return words;
    }

    static (int golos, int prigolos) Count2(List<char> chars)
    {
        HashSet<char> golosSet = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'y', 
                                                      'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я' };

        int golos = 0, prigolos = 0;

        foreach (char c in chars)
        {
            {
                if (golosSet.Contains(c))
                    golos++;
                else
                    prigolos++;
            }
        }
        return (golos,prigolos);
    }
}


// завд 2
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Dictionary<string, string>> inputDicts = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string> { { "V", "S001" } },
            new Dictionary<string, string> { { "V", "S002" } },
            new Dictionary<string, string> { { "VI", "S001" } },
            new Dictionary<string, string> { { "VI", "S005" } },
            new Dictionary<string, string> { { "VII", "S005" } },
            new Dictionary<string, string> { { "V", "S009" } },
            new Dictionary<string, string> { { "VIII", "S007" } }
        };

        HashSet<string> uniqueValues = new HashSet<string>();
        foreach (var dict in inputDicts)
        {
            foreach (var pair in dict)
            {
                uniqueValues.Add(pair.Value);
            }
        }
        Console.WriteLine($"UniqueValues: {{ {string.Join(", ", uniqueValues)} }}");
    }
}


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


























                














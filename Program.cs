using System;
using System.Collections.Generic; 

namespace testcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dico = new Dictionary<string, string>() {
                {"A",".-"},
                {"B", "-..."},
                {"E", "."},
                {"H", "...."},
                {"I", ".."},
                {"J", ".---"},
                {"O", "---"},
                {"R", ".-."},
                {"S", "..."},
                {"T", "-"},
                {"U", "..-"},
                {"V", "...-"},
            };
            var message = ".−−− . // ...− −−− ..− ... // ... −−− ..− .... .- .. − . ";
            var separate = message.Split(" ");
            //var slash = new ArrayList();
            var parseMots = new List<string>();
            for (var i = 0; i < separate.Length; i++)
            {
                Console.WriteLine(separate[i]);
                if (dico.ContainsValue(separate[i])) 
                {
                    Console.WriteLine("ok");
                };
            }
            
            string res = string.Join("-",parseMots);
            Console.WriteLine(res);
        }
    }
}

using System;
using System.Linq;

namespace DesignPatterns
{
    class Pragram
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            foreach (var runnable in typeof(IPatternExample).Assembly.GetExportedTypes()
                .Where(t => t.IsClass && typeof(IPatternExample).IsAssignableFrom(t))
                .Select(t => Activator.CreateInstance(t) as IPatternExample)
                .OrderBy(e => e.Category)
                .ThenBy(e => e.Name)
                .ThenBy(e => e.ExampleType))
            {
                Console.WriteLine($"------------{runnable.Category} > {runnable.Name} > {runnable.ExampleType}----------");
                runnable.Main();
                Console.WriteLine();
            }
        }
    }
}

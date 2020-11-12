using System;
using System.Linq;

namespace DesignPatterns
{
    class Pragram
    {
        public static void Main()
        {
            foreach (var runnable in typeof(IMain).Assembly.GetExportedTypes()
                .Where(t => t.IsClass && typeof(IMain).IsAssignableFrom(t))
                .Select(t => Activator.CreateInstance(t) as IMain))
            {
                Console.WriteLine($">>-----------{runnable.GetType().FullName}------------");
                runnable.Main();
                Console.WriteLine();
            }
        }
    }
}

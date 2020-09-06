using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharpImpl
{
    internal class DebugHelper
    {
        public static Action<string> WriteLine = s => Debug.WriteLine(s);

        [Conditional("DEBUG")]
        public static void Print<T>(T[][] array)
        {
            WriteLine($"{nameof(array)},{array.GetType()},{array.Length}x{array[0].Length}");
            foreach (var row in array)
            {
                WriteLine(string.Join(" ", row));
            }
        }

        [Conditional("DEBUG")]
        public static void Print<T>(T[,] array)
        {
            WriteLine($"{nameof(array)},{array.GetType()},{array.GetLength(0)}x{array.GetLength(1)}");
            var sb = new StringBuilder();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sb.Append(array[i, j] + " ");
                }
                sb.AppendLine();
            }
            WriteLine(sb.ToString());
        }
    }
}

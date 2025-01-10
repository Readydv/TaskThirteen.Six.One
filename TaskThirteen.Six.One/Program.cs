using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace Thirteen.Six.One
{
    class Program
    {
        static void Main(string[] args) 
        {
            string[] words = File.ReadAllText("C:\\Users\\user\\Desktop\\input.txt").Split(new char[] { ' ', '\n', '\r' });

            // Измеряем время вставки в List<T>
            List<string> list = new List<string>();
            Stopwatch sw = new Stopwatch();

            sw.Start();

            foreach (var word in words)
            {
                list.Add(word);
            }
            sw.Stop();
            Console.WriteLine($"Время вставки в List<T>: {sw.ElapsedMilliseconds} мс");

            // Измеряем время вставки в LinkedList<T>
            LinkedList<string> linkedList = new LinkedList<string>();
            sw.Restart();
            foreach (var word in words )
            {
                linkedList.AddLast(word);
            }
            sw.Stop();
            Console.WriteLine($"Время вставки в LinkedList<T>: {sw.ElapsedMilliseconds} мс");
        }
    }
}
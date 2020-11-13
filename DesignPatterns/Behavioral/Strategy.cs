using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral
{
    /// <summary>
    /// Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
    /// https://www.dofactory.com/net/strategy-design-pattern
    /// </summary>
    public class Strategy
    {
        /// <summary>
        /// This structural code demonstrates the Strategy pattern which encapsulates functionality in the form of an object. This allows clients to dynamically change algorithmic strategies.
        /// </summary>
        public class Structural : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Strategy - 策略";

            public ExampleTypes ExampleType => ExampleTypes.Structural;

            public void Main()
            {
                Context context;

                // Three contexts following different strategies

                context = new Context(new ConcreteStrategyA());
                context.ContextInterface();

                context = new Context(new ConcreteStrategyB());
                context.ContextInterface();

                context = new Context(new ConcreteStrategyC());
                context.ContextInterface();
            }

            /// <summary>
            /// The 'Strategy' abstract class
            /// </summary>
            abstract class Strategy
            {
                public abstract void AlgorithmInterface();
            }

            /// <summary>
            /// A 'ConcreteStrategy' class
            /// </summary>
            class ConcreteStrategyA : Strategy
            {
                public override void AlgorithmInterface()
                {
                    Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
                }
            }

            /// <summary>
            /// A 'ConcreteStrategy' class
            /// </summary>
            class ConcreteStrategyB : Strategy
            {
                public override void AlgorithmInterface()
                {
                    Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
                }
            }

            /// <summary>
            /// A 'ConcreteStrategy' class
            /// </summary>
            class ConcreteStrategyC : Strategy
            {
                public override void AlgorithmInterface()
                {
                    Console.WriteLine("Called ConcreteStrategyC.AlgorithmInterface()");
                }
            }

            /// <summary>
            /// The 'Context' class
            /// </summary>
            class Context
            {
                private readonly Strategy _strategy;

                // Constructor
                public Context(Strategy strategy)
                {
                    this._strategy = strategy;
                }

                public void ContextInterface()
                {
                    _strategy.AlgorithmInterface();
                }
            }
        }

        /// <summary>
        /// This real-world code demonstrates the Strategy pattern which encapsulates sorting algorithms in the form of sorting objects. This allows clients to dynamically change sorting strategies including Quicksort, Shellsort, and Mergesort.
        /// </summary>
        public class RealWorld : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Strategy - 策略";

            public ExampleTypes ExampleType => ExampleTypes.RealWorld;

            public void Main()
            {
                SortedList studentRecords = new SortedList();

                studentRecords.Add("Samual");
                studentRecords.Add("Jimmy");
                studentRecords.Add("Sandra");
                studentRecords.Add("Vivek");
                studentRecords.Add("Anna");

                studentRecords.SetSortStrategy(new QuickSort());
                studentRecords.Sort();

                studentRecords.SetSortStrategy(new ShellSort());
                studentRecords.Sort();

                studentRecords.SetSortStrategy(new MergeSort());
                studentRecords.Sort();
            }

            /// <summary>
            /// The 'Strategy' abstract class
            /// </summary>
            abstract class SortStrategy
            {
                public abstract void Sort(List<string> list);
            }

            /// <summary>
            /// A 'ConcreteStrategy' class
            /// </summary>
            class QuickSort : SortStrategy
            {
                public override void Sort(List<string> list)
                {
                    list.Sort(); // Default is Quicksort
                    Console.WriteLine("QuickSorted list ");
                }
            }

            /// <summary>
            /// A 'ConcreteStrategy' class
            /// </summary>
            class ShellSort : SortStrategy
            {
                public override void Sort(List<string> list)
                {
                    //list.ShellSort(); not-implemented
                    Console.WriteLine("ShellSorted list ");
                }
            }

            /// <summary>
            /// A 'ConcreteStrategy' class
            /// </summary>
            class MergeSort : SortStrategy
            {
                public override void Sort(List<string> list)
                {
                    //list.MergeSort(); not-implemented
                    Console.WriteLine("MergeSorted list ");
                }
            }

            /// <summary>
            /// The 'Context' class
            /// </summary>
            class SortedList
            {
                private readonly List<string> _list = new List<string>();
                private SortStrategy _sortstrategy;

                public void SetSortStrategy(SortStrategy sortstrategy)
                {
                    this._sortstrategy = sortstrategy;
                }

                public void Add(string name)
                {
                    _list.Add(name);
                }

                public void Sort()
                {
                    _sortstrategy.Sort(_list);

                    // Iterate over list and display results
                    foreach (string name in _list)
                    {
                        Console.WriteLine(" " + name);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

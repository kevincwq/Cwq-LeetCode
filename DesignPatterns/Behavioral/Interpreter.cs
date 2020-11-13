using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral
{
    /// <summary>
    /// Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language.
    /// https://www.dofactory.com/net/interpreter-design-pattern
    /// </summary>
    public class Interpreter
    {
        /// <summary>
        /// This structural code demonstrates the Interpreter patterns, which using a defined grammer, provides the interpreter that processes parsed statements.
        /// </summary>
        public class Structural : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Interpreter - 解释器";

            public ExampleTypes ExampleType => ExampleTypes.Structural;

            public void Main()
            {
                Context context = new Context();

                // Usually a tree 

                List<AbstractExpression> list = new List<AbstractExpression>();

                // Populate 'abstract syntax tree'
                list.Add(new TerminalExpression());
                list.Add(new NonterminalExpression());
                list.Add(new TerminalExpression());
                list.Add(new TerminalExpression());

                // Interpret
                foreach (var exp in list)
                {
                    exp.Interpret(context);
                }
            }

            /// <summary>
            /// The 'Context' class
            /// </summary>
            class Context
            {
            }

            /// <summary>
            /// The 'AbstractExpression' abstract class
            /// </summary>
            abstract class AbstractExpression
            {
                public abstract void Interpret(Context context);
            }

            /// <summary>
            /// The 'TerminalExpression' class
            /// </summary>
            class TerminalExpression : AbstractExpression
            {
                public override void Interpret(Context context)
                {
                    Console.WriteLine("Called Terminal.Interpret()");
                }
            }

            /// <summary>
            /// The 'NonterminalExpression' class
            /// </summary>
            class NonterminalExpression : AbstractExpression
            {
                public override void Interpret(Context context)
                {
                    Console.WriteLine("Called Nonterminal.Interpret()");
                }
            }
        }

        /// <summary>
        /// This real-world code demonstrates the Interpreter pattern which is used to convert a Roman numeral to a decimal.
        /// </summary>
        public class RealWorld : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Interpreter - 解释器";

            public ExampleTypes ExampleType => ExampleTypes.RealWorld;

            public void Main()
            {
                string roman = "MCMXXVIII";
                Context context = new Context(roman);

                // Build the 'parse tree'
                List<Expression> tree = new List<Expression>();
                tree.Add(new ThousandExpression());
                tree.Add(new HundredExpression());
                tree.Add(new TenExpression());
                tree.Add(new OneExpression());

                // Interpret
                foreach (Expression exp in tree)
                {
                    exp.Interpret(context);
                }

                Console.WriteLine("{0} = {1}",
                  roman, context.Output);
            }

            /// <summary>
            /// The 'Context' class
            /// </summary>
            class Context
            {
                private int index = 0;

                // Constructor
                public Context(string input)
                {
                    this.Input = input;
                }

                // Gets or sets input
                public string Input { get; }

                // Gets or sets output
                public int Output { get; private set; }

                public bool Matches(string toMatch)
                {
                    for (int i = 0; i < toMatch.Length; i++)
                    {
                        if ((index + i) >= Input.Length || Input[index + i] != toMatch[i])
                            return false;
                    }
                    index += toMatch.Length;
                    return true;
                }

                public void AddToOutput(int increment)
                {
                    Output += increment;
                }

                public bool IsDone => index >= Input.Length;
            }

            /// <summary>
            /// The 'AbstractExpression' class
            /// </summary>
            abstract class Expression
            {
                public void Interpret(Context context)
                {
                    if (context.IsDone)
                        return;

                    if (context.Matches(Nine()))
                    {
                        context.AddToOutput(9 * Multiplier());
                    }
                    else if (context.Matches(Four()))
                    {
                        context.AddToOutput(4 * Multiplier());
                    }
                    else if (context.Matches(Five()))
                    {
                        context.AddToOutput(5 * Multiplier());
                    }

                    while (context.Matches(One()))
                    {
                        context.AddToOutput(1 * Multiplier());
                    }
                }

                public abstract string One();
                public abstract string Four();
                public abstract string Five();
                public abstract string Nine();
                public abstract int Multiplier();
            }

            /// <summary>
            /// A 'TerminalExpression' class
            /// <remarks>
            /// Thousand checks for the Roman Numeral M 
            /// </remarks>
            /// </summary>
            class ThousandExpression : Expression
            {
                public override string One() { return "M"; }
                public override string Four() { return " "; }
                public override string Five() { return " "; }
                public override string Nine() { return " "; }
                public override int Multiplier() { return 1000; }
            }

            /// <summary>
            /// A 'TerminalExpression' class
            /// <remarks>
            /// Hundred checks C, CD, D or CM
            /// </remarks>
            /// </summary>
            class HundredExpression : Expression
            {
                public override string One() { return "C"; }
                public override string Four() { return "CD"; }
                public override string Five() { return "D"; }
                public override string Nine() { return "CM"; }
                public override int Multiplier() { return 100; }
            }

            /// <summary>
            /// A 'TerminalExpression' class
            /// <remarks>
            /// Ten checks for X, XL, L and XC
            /// </remarks>
            /// </summary>
            class TenExpression : Expression
            {
                public override string One() { return "X"; }
                public override string Four() { return "XL"; }
                public override string Five() { return "L"; }
                public override string Nine() { return "XC"; }
                public override int Multiplier() { return 10; }
            }

            /// <summary>
            /// A 'TerminalExpression' class
            /// <remarks>
            /// One checks for I, II, III, IV, V, VI, VI, VII, VIII, IX
            /// </remarks>
            /// </summary>
            class OneExpression : Expression
            {
                public override string One() { return "I"; }
                public override string Four() { return "IV"; }
                public override string Five() { return "V"; }
                public override string Nine() { return "IX"; }
                public override int Multiplier() { return 1; }
            }
        }
    }
}

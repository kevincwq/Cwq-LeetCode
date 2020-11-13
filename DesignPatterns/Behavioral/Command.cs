﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral
{
    /// <summary>
    /// Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
    /// https://www.dofactory.com/net/command-design-pattern
    /// </summary>
    public class Command
    {
        public class Structural : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Command - 命令";

            public ExampleTypes ExampleType => ExampleTypes.Structural;

            public void Main()
            {
                // Create receiver, command, and invoker
                Receiver receiver = new Receiver();
                Command command = new ConcreteCommand(receiver);
                Invoker invoker = new Invoker();

                // Set and execute command
                invoker.SetCommand(command);
                invoker.ExecuteCommand();
            }

            /// <summary>
            /// The 'Command' abstract class
            /// </summary>
            abstract class Command
            {
                protected Receiver receiver;

                // Constructor
                public Command(Receiver receiver)
                {
                    this.receiver = receiver;
                }

                public abstract void Execute();
            }

            /// <summary>
            /// The 'ConcreteCommand' class
            /// </summary>
            class ConcreteCommand : Command
            {
                // Constructor
                public ConcreteCommand(Receiver receiver) :
                  base(receiver)
                {
                }

                public override void Execute()
                {
                    receiver.Action();
                }
            }

            /// <summary>
            /// The 'Receiver' class
            /// </summary>
            class Receiver
            {
                public void Action()
                {
                    Console.WriteLine("Called Receiver.Action()");
                }
            }

            /// <summary>
            /// The 'Invoker' class
            /// </summary>
            class Invoker
            {
                private Command _command;

                public void SetCommand(Command command)
                {
                    this._command = command;
                }

                public void ExecuteCommand()
                {
                    _command.Execute();
                }
            }
        }

        public class RealWorld : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Command - 命令";

            public ExampleTypes ExampleType => ExampleTypes.RealWorld;

            public void Main()
            {
                // Create user and let her compute
                User user = new User();

                // User presses calculator buttons
                user.Compute('+', 100);
                user.Compute('-', 50);
                user.Compute('*', 10);
                user.Compute('/', 2);

                // Undo 4 commands
                user.Undo(4);

                // Redo 3 commands
                user.Redo(3);

                // User presses calculator buttons
                user.Compute('/', 4);

                // Redo 1 commands
                user.Redo(1);

                // Undo 4 commands
                user.Undo(4);
            }

            /// <summary>
            /// The 'Command' abstract class
            /// </summary>
            abstract class Command
            {
                public abstract void Execute();
                public abstract void UnExecute();
            }

            /// <summary>
            /// The 'ConcreteCommand' class
            /// </summary>
            class CalculatorCommand : Command
            {
                private char _operator;
                private int _operand;
                private Calculator _calculator;

                public CalculatorCommand(Calculator calculator, char @operator, int operand)
                {
                    this._calculator = calculator;
                    this._operator = @operator;
                    this._operand = operand;
                }

                public char Operator
                {
                    set { _operator = value; }
                }

                public int Operand
                {
                    set
                    {
                        _operand = value;
                    }
                }

                public override void Execute()
                {
                    _calculator.Operation(_operator, _operand);
                }

                public override void UnExecute()
                {
                    _calculator.Operation(Undo(_operator), _operand);
                }

                private char Undo(char @operator)
                {
                    return @operator switch
                    {
                        '+' => '-',
                        '-' => '+',
                        '*' => '/',
                        '/' => '*',
                        _ => throw new ArgumentException("operator"),
                    };
                }
            }

            /// <summary>
            /// The 'Receiver' class
            /// </summary>
            class Calculator
            {
                private int _curr = 0;

                public void Operation(char @operator, int operand)
                {
                    switch (@operator)
                    {
                        case '+': _curr += operand; break;
                        case '-': _curr -= operand; break;
                        case '*': _curr *= operand; break;
                        case '/': _curr /= operand; break;
                    }
                    Console.WriteLine(
                      "Current value = {0,3} (following {1} {2})",
                      _curr, @operator, operand);
                }
            }

            /// <summary>
            /// The 'Invoker' class
            /// </summary>
            class User
            {
                // Initializers
                private Calculator _calculator = new Calculator();
                private List<Command> _commands = new List<Command>();
                private int _current = 0;

                public void Redo(int levels)
                {
                    Console.WriteLine("\n---- Redo {0} levels ", levels);
                    // Perform redo operations
                    for (int i = 0; i < levels; i++)
                    {
                        if (_current < _commands.Count - 1)
                        {
                            Command command = _commands[_current++];
                            command.Execute();
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                public void Undo(int levels)
                {
                    Console.WriteLine("\n---- Undo {0} levels ", levels);
                    // Perform undo operations
                    for (int i = 0; i < levels; i++)
                    {
                        if (_current > 0)
                        {
                            Command command = _commands[--_current] as Command;
                            command.UnExecute();
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                public void Compute(char @operator, int operand)
                {
                    // Create command operation and execute it
                    Command command = new CalculatorCommand(_calculator, @operator, operand);
                    command.Execute();

                    // Remove the Redo items
                    _commands.RemoveRange(_current, _commands.Count - _current);

                    // Add command to undo list
                    _commands.Add(command);
                    _current++;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral
{
    /// <summary>
    /// Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.
    /// https://www.dofactory.com/net/chain-of-responsibility-design-pattern
    /// </summary>
    public class ChainOfResponsibility
    {
        public class Structural : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Chain of Responsibility";

            public ExampleTypes ExampleType => ExampleTypes.Structural;

            public void Main()
            {
                // Setup Chain of Responsibility
                Handler h1 = new ConcreteHandler1();
                Handler h2 = new ConcreteHandler2();
                Handler h3 = new ConcreteHandler3();
                h1.SetSuccessor(h2);
                h2.SetSuccessor(h3);

                // Generate and process request
                int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };
                foreach (int request in requests)
                {
                    h1.HandleRequest(request);
                }
            }

            /// <summary>
            /// The 'Handler' abstract class
            /// </summary>
            abstract class Handler
            {
                protected Handler successor;

                public void SetSuccessor(Handler successor)
                {
                    this.successor = successor;
                }

                public abstract void HandleRequest(int request);
            }

            /// <summary>
            /// The 'ConcreteHandler1' class
            /// </summary>
            class ConcreteHandler1 : Handler
            {
                public override void HandleRequest(int request)
                {
                    if (request >= 0 && request < 10)
                    {
                        Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
                    }
                    else if (successor != null)
                    {
                        successor.HandleRequest(request);
                    }
                }
            }

            /// <summary>
            /// The 'ConcreteHandler2' class
            /// </summary>
            class ConcreteHandler2 : Handler
            {
                public override void HandleRequest(int request)
                {
                    if (request >= 10 && request < 20)
                    {
                        Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
                    }
                    else if (successor != null)
                    {
                        successor.HandleRequest(request);
                    }
                }
            }

            /// <summary>
            /// The 'ConcreteHandler3' class
            /// </summary>
            class ConcreteHandler3 : Handler
            {
                public override void HandleRequest(int request)
                {
                    if (request >= 20 && request < 30)
                    {
                        Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
                    }
                    else if (successor != null)
                    {
                        successor.HandleRequest(request);
                    }
                }
            }
        }

        public class RealWorld : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Chain of Responsibility";

            public ExampleTypes ExampleType => ExampleTypes.RealWorld;

            public void Main()
            {
                // Setup Chain of Responsibility
                Approver larry = new Director("Larry");
                Approver sam = new VicePresident("Sam");
                Approver tammy = new President("Tammy");

                larry.SetSuccessor(sam);
                sam.SetSuccessor(tammy);

                // Generate and process purchase requests
                Purchase p = new Purchase(2034, 350.00, "Assets");
                larry.ProcessRequest(p);

                p = new Purchase(2035, 32590.10, "Project X");
                larry.ProcessRequest(p);

                p = new Purchase(2036, 122100.00, "Project Y");
                larry.ProcessRequest(p);
            }

            /// <summary>
            /// The 'Handler' abstract class
            /// </summary>
            abstract class Approver
            {
                protected Approver successor;
                public string Name { get; }

                public Approver(string name)
                {
                    Name = name;
                }

                public void SetSuccessor(Approver successor)
                {
                    this.successor = successor;
                }

                public abstract void ProcessRequest(Purchase purchase);

                protected void PrintApprove(int number)
                {
                    Console.WriteLine("{0} {1} approved request# {2}", this.GetType().Name, Name, number);
                }
            }

            /// <summary>
            /// The 'ConcreteHandler' class
            /// </summary>
            class Director : Approver
            {
                public Director(string name) : base(name)
                {
                }

                public override void ProcessRequest(Purchase purchase)
                {
                    if (purchase.Amount < 10000.0)
                    {
                        PrintApprove(purchase.Number);
                    }
                    else if (successor != null)
                    {
                        successor.ProcessRequest(purchase);
                    }
                }
            }

            /// <summary>
            /// The 'ConcreteHandler' class
            /// </summary>
            class VicePresident : Approver
            {
                public VicePresident(string name) : base(name)
                {
                }

                public override void ProcessRequest(Purchase purchase)
                {
                    if (purchase.Amount < 25000.0)
                    {
                        PrintApprove(purchase.Number);
                    }
                    else if (successor != null)
                    {
                        successor.ProcessRequest(purchase);
                    }
                }
            }

            /// <summary>
            /// The 'ConcreteHandler' class
            /// </summary>
            class President : Approver
            {
                public President(string name) : base(name)
                {
                }

                public override void ProcessRequest(Purchase purchase)
                {
                    if (purchase.Amount < 100000.0)
                    {
                        PrintApprove(purchase.Number);
                    }
                    else
                    {
                        Console.WriteLine(
                          "Request# {0} requires an executive meeting!",
                          purchase.Number);
                    }
                }
            }

            /// <summary>
            /// Class holding request details
            /// </summary>
            class Purchase
            {
                // Constructor
                public Purchase(int number, double amount, string purpose)
                {
                    this.Number = number;
                    this.Amount = amount;
                    this.Purpose = purpose;
                }

                // Gets or sets purchase number
                public int Number { get; set; }

                // Gets or sets purchase amount
                public double Amount { get; set; }

                // Gets or sets purchase purpose
                public string Purpose { get; set; }
            }
        }
    }
}

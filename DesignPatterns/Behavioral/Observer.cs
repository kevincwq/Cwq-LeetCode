using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral
{
    /// <summary>
    /// Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
    /// https://www.dofactory.com/net/observer-design-pattern
    /// </summary>
    public class Observer
    {
        /// <summary>
        /// This structural code demonstrates the Observer pattern in which registered objects are notified of and updated with a state change.
        /// </summary>
        public class Structural : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Observer - 观察者";

            public ExampleTypes ExampleType => ExampleTypes.Structural;

            public void Main()
            {
                // Configure Observer pattern
                ConcreteSubject s = new ConcreteSubject();

                s.Attach(new ConcreteObserver(s, "X"));
                s.Attach(new ConcreteObserver(s, "Y"));
                s.Attach(new ConcreteObserver(s, "Z"));

                // Change subject and notify observers
                s.SubjectState = "ABC";
                s.Notify();
            }

            /// <summary>
            /// The 'Subject' abstract class
            /// </summary>
            abstract class Subject
            {
                private readonly List<Observer> _observers = new List<Observer>();

                public void Attach(Observer observer)
                {
                    _observers.Add(observer);
                }

                public void Detach(Observer observer)
                {
                    _observers.Remove(observer);
                }

                public void Notify()
                {
                    foreach (Observer o in _observers)
                    {
                        o.Update();
                    }
                }
            }

            /// <summary>
            /// The 'ConcreteSubject' class
            /// </summary>
            class ConcreteSubject : Subject
            {
                // Gets or sets subject state
                public string SubjectState { get; set; }
            }

            /// <summary>
            /// The 'Observer' abstract class
            /// </summary>
            abstract class Observer
            {
                public abstract void Update();
            }

            /// <summary>
            /// The 'ConcreteObserver' class
            /// </summary>
            class ConcreteObserver : Observer
            {
                private readonly string _name;
                private string _observerState;

                // Gets or sets subject
                public ConcreteSubject Subject { get; set; }

                // Constructor
                public ConcreteObserver(
                  ConcreteSubject subject, string name)
                {
                    this.Subject = subject;
                    this._name = name;
                }

                public override void Update()
                {
                    _observerState = Subject.SubjectState;
                    Console.WriteLine("Observer {0}'s new state is {1}", _name, _observerState);
                }
            }
        }

        /// <summary>
        /// This real-world code demonstrates the Observer pattern in which registered investors are notified every time a stock changes value.
        /// </summary>
        public class RealWorld : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Observer - 观察者";

            public ExampleTypes ExampleType => ExampleTypes.RealWorld;

            public void Main()
            {
                // Create IBM stock and attach investors
                IBM ibm = new IBM(120.00);
                ibm.Attach(new Investor("Sorros"));
                ibm.Attach(new Investor("Berkshire"));

                // Fluctuating prices will notify investors
                ibm.Price = 120.10;
                ibm.Price = 121.00;
                ibm.Price = 120.50;
                ibm.Price = 120.75;
            }

            /// <summary>
            /// The 'Subject' abstract class
            /// </summary>
            abstract class Stock
            {
                private double _price;
                private readonly List<IInvestor> _investors = new List<IInvestor>();

                // Gets the symbol
                public string Symbol { get; }

                // Constructor
                public Stock(string symbol, double price)
                {
                    this.Symbol = symbol;
                    this._price = price;
                }

                public void Attach(IInvestor investor)
                {
                    _investors.Add(investor);
                }

                public void Detach(IInvestor investor)
                {
                    _investors.Remove(investor);
                }

                public void Notify()
                {
                    foreach (IInvestor investor in _investors)
                    {
                        investor.Update(this);
                    }

                    Console.WriteLine("");
                }

                // Gets or sets the price
                public double Price
                {
                    get { return _price; }
                    set
                    {
                        if (_price != value)
                        {
                            _price = value;
                            Notify();
                        }
                    }
                }
            }

            /// <summary>
            /// The 'ConcreteSubject' class
            /// </summary>
            class IBM : Stock
            {
                // Constructor
                public IBM(double price)
                  : base("IBM", price)
                {
                }
            }

            /// <summary>
            /// The 'Observer' interface
            /// </summary>
            interface IInvestor
            {
                void Update(Stock stock);
            }

            /// <summary>
            /// The 'ConcreteObserver' class
            /// </summary>
            class Investor : IInvestor
            {
                private readonly string _name;

                // Gets or sets the stock
                public Stock Stock { get; set; }

                // Constructor
                public Investor(string name)
                {
                    this._name = name;
                }

                public void Update(Stock stock)
                {
                    Console.WriteLine("Notified {0} of {1}'s price change to {2:C}", _name, stock.Symbol, stock.Price);
                }
            }
        }
    }
}

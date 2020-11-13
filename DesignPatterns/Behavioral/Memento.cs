using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral
{
    /// <summary>
    /// Without violating encapsulation, capture and externalize an object's internal state so that the object can be restored to this state later.
    /// https://www.dofactory.com/net/memento-design-pattern
    /// </summary>
    public class Memento
    {
        /// <summary>
        /// This structural code demonstrates the Memento pattern which temporary saves and restores another object's internal state.
        /// </summary>
        public class Structural : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Memento - 备忘录";

            public ExampleTypes ExampleType => ExampleTypes.Structural;

            public void Main()
            {
                Originator o = new Originator
                {
                    State = "On"
                };

                // Store internal state
                Caretaker c = new Caretaker
                {
                    Memento = o.CreateMemento()
                };

                // Continue changing originator
                o.State = "Off";

                // Restore saved state
                o.SetMemento(c.Memento);
            }

            /// <summary>
            /// The 'Originator' class
            /// </summary>
            class Originator
            {
                private string _state;

                // Property
                public string State
                {
                    get { return _state; }
                    set
                    {
                        _state = value;
                        Console.WriteLine("State = " + _state);
                    }
                }

                // Creates memento
                public Memento CreateMemento()
                {
                    return (new Memento(_state));
                }

                // Restores original state
                public void SetMemento(Memento memento)
                {
                    Console.WriteLine("Restoring state...");
                    State = memento.State;
                }
            }

            /// <summary>
            /// The 'Memento' class
            /// </summary>
            class Memento
            {
                // Constructor
                public Memento(string state)
                {
                    this.State = state;
                }

                // Gets or sets state
                public string State { get; }
            }

            /// <summary>
            /// The 'Caretaker' class
            /// </summary>
            class Caretaker
            {
                // Gets or sets memento
                public Memento Memento { set; get; }
            }
        }

        /// <summary>
        /// This real-world code demonstrates the Memento pattern which temporarily saves and then restores the SalesProspect's internal state.
        /// </summary>
        public class RealWorld : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Memento - 备忘录";

            public ExampleTypes ExampleType => ExampleTypes.RealWorld;

            public void Main()
            {
                SalesProspect s = new SalesProspect();
                s.Name = "Noel van Halen";
                s.Phone = "(412) 256-0990";
                s.Budget = 25000.0;

                // Store internal state

                ProspectMemory m = new ProspectMemory();
                m.Memento = s.SaveMemento();

                // Continue changing originator

                s.Name = "Leo Welch";
                s.Phone = "(310) 209-7111";
                s.Budget = 1000000.0;

                // Restore saved state

                s.RestoreMemento(m.Memento);
            }

            /// <summary>
            /// The 'Originator' class
            /// </summary>
            class SalesProspect
            {
                private string _name;
                private string _phone;
                private double _budget;

                // Gets or sets name
                public string Name
                {
                    get { return _name; }
                    set
                    {
                        _name = value;
                        Console.WriteLine("Name:  " + _name);
                    }
                }

                // Gets or sets phone
                public string Phone
                {
                    get { return _phone; }
                    set
                    {
                        _phone = value;
                        Console.WriteLine("Phone: " + _phone);
                    }
                }

                // Gets or sets budget
                public double Budget
                {
                    get { return _budget; }
                    set
                    {
                        _budget = value;
                        Console.WriteLine("Budget: " + _budget);
                    }
                }

                // Stores memento
                public Memento SaveMemento()
                {
                    Console.WriteLine("\nSaving state --\n");
                    return new Memento(_name, _phone, _budget);
                }

                // Restores memento
                public void RestoreMemento(Memento memento)
                {
                    Console.WriteLine("\nRestoring state --\n");
                    this.Name = memento.Name;
                    this.Phone = memento.Phone;
                    this.Budget = memento.Budget;
                }
            }

            /// <summary>
            /// The 'Memento' class
            /// </summary>
            class Memento
            {
                // Constructor
                public Memento(string name, string phone, double budget)
                {
                    this.Name = name;
                    this.Phone = phone;
                    this.Budget = budget;
                }

                // Gets or sets name
                public string Name { get; set; }

                // Gets or set phone
                public string Phone { get; set; }

                // Gets or sets budget
                public double Budget { get; set; }
            }

            /// <summary>
            /// The 'Caretaker' class
            /// </summary>
            class ProspectMemory
            {
                // Property
                public Memento Memento { set; get; }
            }
        }
    }
}

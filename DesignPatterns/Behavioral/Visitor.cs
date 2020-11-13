﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral
{
    /// <summary>
    /// Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates.
    /// https://www.dofactory.com/net/visitor-design-pattern
    /// </summary>
    public class Visitor
    {
        /// <summary>
        /// This structural code demonstrates the Visitor pattern in which an object traverses an object structure and performs the same operation on each node in this structure. Different visitor objects define different operations.
        /// </summary>
        public class Structural : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Visitor - 访问者";

            public ExampleTypes ExampleType => ExampleTypes.Structural;

            public void Main()
            {
                // Setup structure
                ObjectStructure o = new ObjectStructure();
                o.Attach(new ConcreteElementA());
                o.Attach(new ConcreteElementB());

                // Create visitor objects
                ConcreteVisitor1 v1 = new ConcreteVisitor1();
                ConcreteVisitor2 v2 = new ConcreteVisitor2();

                // Structure accepting visitors
                o.Accept(v1);
                o.Accept(v2);
            }

            /// <summary>
            /// The 'Visitor' abstract class
            /// </summary>
            abstract class Visitor
            {
                public abstract void VisitConcreteElementA(
                  ConcreteElementA concreteElementA);
                public abstract void VisitConcreteElementB(
                  ConcreteElementB concreteElementB);
            }

            /// <summary>
            /// A 'ConcreteVisitor' class
            /// </summary>
            class ConcreteVisitor1 : Visitor
            {
                public override void VisitConcreteElementA(
                  ConcreteElementA concreteElementA)
                {
                    Console.WriteLine("{0} visited by {1}",
                      concreteElementA.GetType().Name, this.GetType().Name);
                }

                public override void VisitConcreteElementB(
                  ConcreteElementB concreteElementB)
                {
                    Console.WriteLine("{0} visited by {1}",
                      concreteElementB.GetType().Name, this.GetType().Name);
                }
            }

            /// <summary>
            /// A 'ConcreteVisitor' class
            /// </summary>
            class ConcreteVisitor2 : Visitor
            {
                public override void VisitConcreteElementA(
                  ConcreteElementA concreteElementA)
                {
                    Console.WriteLine("{0} visited by {1}",
                      concreteElementA.GetType().Name, this.GetType().Name);
                }

                public override void VisitConcreteElementB(
                  ConcreteElementB concreteElementB)
                {
                    Console.WriteLine("{0} visited by {1}",
                      concreteElementB.GetType().Name, this.GetType().Name);
                }
            }

            /// <summary>
            /// The 'Element' abstract class
            /// </summary>
            abstract class Element
            {
                public abstract void Accept(Visitor visitor);
            }

            /// <summary>
            /// A 'ConcreteElement' class
            /// </summary>
            class ConcreteElementA : Element
            {
                public override void Accept(Visitor visitor)
                {
                    visitor.VisitConcreteElementA(this);
                }

                public void OperationA()
                {

                }
            }

            /// <summary>
            /// A 'ConcreteElement' class
            /// </summary>
            class ConcreteElementB : Element
            {
                public override void Accept(Visitor visitor)
                {
                    visitor.VisitConcreteElementB(this);
                }

                public void OperationB()
                {

                }
            }

            /// <summary>
            /// The 'ObjectStructure' class
            /// </summary>
            class ObjectStructure
            {
                private readonly List<Element> _elements = new List<Element>();

                public void Attach(Element element)
                {
                    _elements.Add(element);
                }

                public void Detach(Element element)
                {
                    _elements.Remove(element);
                }

                public void Accept(Visitor visitor)
                {
                    foreach (Element element in _elements)
                    {
                        element.Accept(visitor);
                    }
                }
            }
        }

        /// <summary>
        /// This real-world code demonstrates the Visitor pattern in which two objects traverse a list of Employees and performs the same operation on each Employee. The two visitor objects define different operations -- one adjusts vacation days and the other income.
        /// </summary>
        public class RealWorld : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Visitor - 访问者";

            public ExampleTypes ExampleType => ExampleTypes.RealWorld;

            public void Main()
            {
                // Setup employee collection
                Employees e = new Employees();
                e.Attach(new Clerk());
                e.Attach(new Director());
                e.Attach(new President());

                // Employees are 'visited'
                e.Accept(new IncomeVisitor());
                e.Accept(new VacationVisitor());
            }


            /// <summary>
            /// The 'Visitor' interface
            /// </summary>
            interface IVisitor
            {
                void Visit(Element element);
            }

            /// <summary>
            /// A 'ConcreteVisitor' class
            /// </summary>
            class IncomeVisitor : IVisitor
            {
                public void Visit(Element element)
                {
                    Employee employee = element as Employee;

                    // Provide 10% pay raise
                    employee.Income *= 1.10;
                    Console.WriteLine("{0} {1}'s new income: {2:C}",
                      employee.GetType().Name, employee.Name,
                      employee.Income);
                }
            }

            /// <summary>
            /// A 'ConcreteVisitor' class
            /// </summary>
            class VacationVisitor : IVisitor
            {
                public void Visit(Element element)
                {
                    Employee employee = element as Employee;

                    // Provide 3 extra vacation days
                    employee.VacationDays += 3;
                    Console.WriteLine("{0} {1}'s new vacation days: {2}",
                      employee.GetType().Name, employee.Name,
                      employee.VacationDays);
                }
            }

            /// <summary>
            /// The 'Element' abstract class
            /// </summary>
            abstract class Element
            {
                public abstract void Accept(IVisitor visitor);
            }

            /// <summary>
            /// The 'ConcreteElement' class
            /// </summary>
            class Employee : Element
            {
                // Constructor
                public Employee(string name, double income,
                  int vacationDays)
                {
                    this.Name = name;
                    this.Income = income;
                    this.VacationDays = vacationDays;
                }

                // Gets or sets the name
                public string Name { get; set; }

                // Gets or sets income
                public double Income { get; set; }

                // Gets or sets number of vacation days
                public int VacationDays { get; set; }

                public override void Accept(IVisitor visitor)
                {
                    visitor.Visit(this);
                }
            }

            /// <summary>
            /// The 'ObjectStructure' class
            /// </summary>

            class Employees
            {
                private readonly List<Employee> _employees = new List<Employee>();

                public void Attach(Employee employee)
                {
                    _employees.Add(employee);
                }

                public void Detach(Employee employee)
                {
                    _employees.Remove(employee);
                }

                public void Accept(IVisitor visitor)
                {
                    foreach (Employee e in _employees)
                    {
                        e.Accept(visitor);
                    }
                    Console.WriteLine();
                }
            }

            // Three employee types
            class Clerk : Employee
            {
                // Constructor
                public Clerk()
                  : base("Hank", 25000.0, 14)
                {
                }
            }

            class Director : Employee
            {
                // Constructor
                public Director()
                  : base("Elly", 35000.0, 16)
                {
                }
            }

            class President : Employee
            {
                // Constructor
                public President()
                    : base("Dick", 45000.0, 21)
                {
                }
            }
        }
    }
}

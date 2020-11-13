using System;

namespace DesignPatterns.Behavioral
{
    /// <summary>
    /// Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
    /// https://www.dofactory.com/net/template-method-design-pattern
    /// </summary>
    public class TemplateMethod
    {
        /// <summary>
        /// This structural code demonstrates the Template method which provides a skeleton calling sequence of methods. One or more steps can be deferred to subclasses which implement these steps without changing the overall calling sequence.
        /// </summary>
        public class Structural : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Template Method - 模板方法";

            public ExampleTypes ExampleType => ExampleTypes.Structural;

            public void Main()
            {
                AbstractClass aA = new ConcreteClassA();
                aA.TemplateMethod();

                AbstractClass aB = new ConcreteClassB();
                aB.TemplateMethod();
            }

            // <summary>
            /// The 'AbstractClass' abstract class
            /// </summary>
            abstract class AbstractClass
            {
                public abstract void PrimitiveOperation1();
                public abstract void PrimitiveOperation2();

                // The "Template method"
                public void TemplateMethod()
                {
                    PrimitiveOperation1();
                    PrimitiveOperation2();
                    Console.WriteLine("");
                }
            }

            /// <summary>
            /// A 'ConcreteClass' class
            /// </summary>
            class ConcreteClassA : AbstractClass
            {
                public override void PrimitiveOperation1()
                {
                    Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
                }
                public override void PrimitiveOperation2()
                {
                    Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
                }
            }

            /// <summary>
            /// A 'ConcreteClass' class
            /// </summary>
            class ConcreteClassB : AbstractClass
            {
                public override void PrimitiveOperation1()
                {
                    Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
                }
                public override void PrimitiveOperation2()
                {
                    Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
                }
            }
        }

        /// <summary>
        /// This real-world code demonstrates a Template method named Run() which provides a skeleton calling sequence of methods. Implementation of these steps are deferred to the CustomerDataObject subclass which implements the Connect, Select, Process, and Disconnect methods.
        /// </summary>
        public class RealWorld : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Template Method - 模板方法";

            public ExampleTypes ExampleType => ExampleTypes.RealWorld;

            public void Main()
            {
                DataAccessObject daoCategories = new Categories();
                daoCategories.Run();

                DataAccessObject daoProducts = new Products();
                daoProducts.Run();
            }

            /// <summary>
            /// The 'AbstractClass' abstract class
            /// </summary>
            abstract class DataAccessObject
            {
                protected string connectionString;

                public virtual void Connect()
                {
                    // Make sure mdb is available to app
                    connectionString =
                      "provider=Microsoft.JET.OLEDB.4.0; " +
                      "data source=..\\..\\..\\db1.mdb";
                    Console.WriteLine("Connect");
                }

                public abstract void Select();
                public abstract void Process();

                public virtual void Disconnect()
                {
                    connectionString = "";
                    Console.WriteLine("Disconnect");
                    Console.WriteLine();
                }

                // The 'Template Method' 
                public void Run()
                {
                    Connect();
                    Select();
                    Process();
                    Disconnect();
                }
            }

            /// <summary>
            /// A 'ConcreteClass' class
            /// </summary>
            class Categories : DataAccessObject
            {
                public override void Select()
                {
                    Console.WriteLine("Select CategoryName from Categories");
                }

                public override void Process()
                {
                    Console.WriteLine("Process Categories");
                }
            }

            /// <summary>
            /// A 'ConcreteClass' class
            /// </summary>
            class Products : DataAccessObject

            {
                public override void Select()
                {
                    Console.WriteLine("Select ProductName from Products");
                }

                public override void Process()
                {
                    Console.WriteLine("Process Products");
                }
            }
        }
    }
}

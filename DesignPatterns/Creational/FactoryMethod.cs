using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    /// <summary>    /// Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
    /// https://www.dofactory.com/net/factory-method-design-pattern
    /// </summary>
    public class FactoryMethod
    {
        /// <summary>
        /// This structural code demonstrates the Factory method offering great flexibility in creating different objects. The Abstract class may provide a default object, but each subclass can instantiate an extended version of the object.
        /// </summary>
        public class Structural : IPatternExample
        {
            public string Name => "Factory Method - 工厂方法";

            public string Category => "Creational";

            public ExampleTypes ExampleType => ExampleTypes.Structural;

            public void Main()
            {
                // An array of creators

                Creator[] creators = new Creator[2];

                creators[0] = new ConcreteCreatorA();
                creators[1] = new ConcreteCreatorB();

                // Iterate over creators and create products

                foreach (Creator creator in creators)
                {
                    Product product = creator.FactoryMethod();
                    Console.WriteLine("Created {0}", product.GetType().Name);
                }
            }


            /// <summary>
            /// The 'Product' abstract class
            /// </summary>
            abstract class Product

            {
            }

            /// <summary>
            /// A 'ConcreteProduct' class
            /// </summary>
            class ConcreteProductA : Product

            {
            }

            /// <summary>
            /// A 'ConcreteProduct' class
            /// </summary>
            class ConcreteProductB : Product

            {
            }

            /// <summary>
            /// The 'Creator' abstract class
            /// </summary>

            abstract class Creator

            {
                public abstract Product FactoryMethod();
            }

            /// <summary>
            /// A 'ConcreteCreator' class
            /// </summary>
            class ConcreteCreatorA : Creator

            {
                public override Product FactoryMethod()
                {
                    return new ConcreteProductA();
                }
            }

            /// <summary>
            /// A 'ConcreteCreator' class
            /// </summary>
            class ConcreteCreatorB : Creator

            {
                public override Product FactoryMethod()
                {
                    return new ConcreteProductB();
                }
            }
        }

        /// <summary>
        /// This real-world code demonstrates the Factory method offering flexibility in creating different documents. The derived Document classes Report and Resume instantiate extended versions of the Document class. Here, the Factory Method is called in the constructor of the Document base class.
        /// </summary>
        public class RealWorld : IPatternExample
        {
            public string Name => "Factory Method - 工厂方法";

            public string Category => "Creational";

            public ExampleTypes ExampleType => ExampleTypes.RealWorld;

            public void Main()
            {
                // Note: constructors call Factory Method

                Document[] documents = new Document[2];

                documents[0] = new Resume();
                documents[1] = new Report();

                // Display document pages

                foreach (Document document in documents)
                {
                    Console.WriteLine("\n" + document.GetType().Name + "--");
                    foreach (Page page in document.Pages)
                    {
                        Console.WriteLine(" " + page.GetType().Name);
                    }
                }
            }

            /// <summary>
            /// The 'Product' abstract class
            /// </summary>
            abstract class Page
            {
            }

            /// <summary>
            /// A 'ConcreteProduct' class
            /// </summary>
            class SkillsPage : Page
            {
            }

            /// <summary>
            /// A 'ConcreteProduct' class
            /// </summary>
            class EducationPage : Page
            {
            }

            /// <summary>
            /// A 'ConcreteProduct' class
            /// </summary>
            class ExperiencePage : Page
            {
            }

            /// <summary>
            /// A 'ConcreteProduct' class
            /// </summary>
            class IntroductionPage : Page
            {
            }

            /// <summary>
            /// A 'ConcreteProduct' class
            /// </summary>
            class ResultsPage : Page
            {
            }

            /// <summary>
            /// A 'ConcreteProduct' class
            /// </summary>
            class ConclusionPage : Page
            {
            }

            /// <summary>
            /// A 'ConcreteProduct' class
            /// </summary>
            class SummaryPage : Page
            {
            }

            /// <summary>
            /// A 'ConcreteProduct' class
            /// </summary>
            class BibliographyPage : Page
            {
            }

            /// <summary>
            /// The 'Creator' abstract class
            /// </summary>
            abstract class Document
            {

                // Constructor calls abstract Factory method

                public Document()
                {
                    this.CreatePages();
                }

                public List<Page> Pages { get; } = new List<Page>();

                // Factory Method

                public abstract void CreatePages();
            }

            /// <summary>
            /// A 'ConcreteCreator' class
            /// </summary>
            class Resume : Document
            {
                // Factory Method implementation

                public override void CreatePages()
                {
                    Pages.Add(new SkillsPage());
                    Pages.Add(new EducationPage());
                    Pages.Add(new ExperiencePage());
                }
            }

            /// <summary>
            /// A 'ConcreteCreator' class
            /// </summary>
            class Report : Document
            {
                // Factory Method implementation

                public override void CreatePages()
                {
                    Pages.Add(new IntroductionPage());
                    Pages.Add(new ResultsPage());
                    Pages.Add(new ConclusionPage());
                    Pages.Add(new SummaryPage());
                    Pages.Add(new BibliographyPage());
                }
            }
        }

    }
}

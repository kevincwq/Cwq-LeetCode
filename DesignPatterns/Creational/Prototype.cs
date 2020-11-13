using System;
using System.Collections.Generic;

namespace DesignPatterns.Creational
{
    /// <summary>
    /// Specify the kind of objects to create using a prototypical instance, and create new objects by copying this prototype.
    /// https://www.dofactory.com/net/prototype-design-pattern
    /// </summary>
    public class Prototype
    {
        public class Structural : IPatternExample
        {
            public string Name => "Prototype - 原型";

            public string Category => "Creational";

            public ExampleTypes ExampleType => ExampleTypes.Structural;

            public void Main()
            {
                // Create two instances and clone eac

                ConcretePrototype1 p1 = new ConcretePrototype1("I");
                ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
                Console.WriteLine("Cloned: {0}", c1.Id);

                ConcretePrototype2 p2 = new ConcretePrototype2("II");
                ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
                Console.WriteLine("Cloned: {0}", c2.Id);
            }

            /// <summary>
            /// The 'Prototype' abstract class
            /// </summary>
            abstract class Prototype
            {
                // Constructor
                public Prototype(string id)
                {
                    this.Id = id;
                }

                // Gets id
                public string Id { get; }

                public abstract Prototype Clone();
            }

            /// <summary>
            /// A 'ConcretePrototype' class 
            /// </summary>

            class ConcretePrototype1 : Prototype
            {
                // Constructor
                public ConcretePrototype1(string id)
                  : base(id)
                {
                }

                // Returns a shallow copy
                public override Prototype Clone()
                {
                    return (Prototype)this.MemberwiseClone();
                }
            }

            /// <summary>
            /// A 'ConcretePrototype' class 
            /// </summary>
            class ConcretePrototype2 : Prototype
            {
                // Constructor
                public ConcretePrototype2(string id)
                  : base(id)
                {
                }

                // Returns a shallow copy
                public override Prototype Clone()
                {
                    return (Prototype)this.MemberwiseClone();
                }
            }
        }

        public class RealWorld : IPatternExample
        {
            public string Name => "Prototype - 原型";

            public string Category => "Creational";

            public ExampleTypes ExampleType => ExampleTypes.RealWorld;

            public void Main()
            {
                ColorManager colormanager = new ColorManager();

                // Initialize with standard colors
                colormanager["red"] = new Color(255, 0, 0);
                colormanager["green"] = new Color(0, 255, 0);
                colormanager["blue"] = new Color(0, 0, 255);

                // User adds personalized colors
                colormanager["angry"] = new Color(255, 54, 0);
                colormanager["peace"] = new Color(128, 211, 128);
                colormanager["flame"] = new Color(211, 34, 20);

                // User clones selected colors
                _ = colormanager["red"].Clone() as Color;
                _ = colormanager["peace"].Clone() as Color;
                _ = colormanager["flame"].Clone() as Color;
            }

            /// <summary>
            /// The 'Prototype' abstract class
            /// </summary>
            abstract class ColorPrototype
            {
                public abstract ColorPrototype Clone();
            }

            /// <summary>
            /// The 'ConcretePrototype' class
            /// </summary>
            class Color : ColorPrototype
            {
                private int _red;
                private int _green;
                private int _blue;

                // Constructor

                public Color(int red, int green, int blue)
                {
                    this._red = red;
                    this._green = green;
                    this._blue = blue;
                }

                // Create a shallow copy
                public override ColorPrototype Clone()
                {
                    Console.WriteLine(
                      "Cloning color RGB: {0,3},{1,3},{2,3}",
                      _red, _green, _blue);

                    return this.MemberwiseClone() as ColorPrototype;
                }
            }

            /// <summary>
            /// Prototype manager
            /// </summary>
            class ColorManager
            {
                private Dictionary<string, ColorPrototype> _colors =
                  new Dictionary<string, ColorPrototype>();

                // Indexer
                public ColorPrototype this[string key]
                {
                    get { return _colors[key]; }
                    set { _colors.Add(key, value); }
                }
            }
        }
    }
}

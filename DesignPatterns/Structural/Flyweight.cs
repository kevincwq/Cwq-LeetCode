using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    /// <summary>
    /// Use sharing to support large numbers of fine-grained objects efficiently.
    /// https://www.dofactory.com/net/flyweight-design-pattern
    /// </summary>
    public class Flyweight
    {
        public class Structural : IPatternExample
        {
            public string Category => "Structural";

            public string Name => "Flyweight";

            public ExampleTypes ExampleType => ExampleTypes.Structural;

            public void Main()
            {
                // Arbitrary extrinsic state

                int extrinsicstate = 22;

                FlyweightFactory factory = new FlyweightFactory();

                // Work with different flyweight instances

                Flyweight fx = factory.GetFlyweight("X");
                fx.Operation(--extrinsicstate);

                Flyweight fy = factory.GetFlyweight("Y");
                fy.Operation(--extrinsicstate);

                Flyweight fz = factory.GetFlyweight("Z");
                fz.Operation(--extrinsicstate);

                UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();

                fu.Operation(--extrinsicstate);
            }

            /// <summary>
            /// The 'FlyweightFactory' class
            /// </summary>
            class FlyweightFactory
            {
                private Hashtable flyweights = new Hashtable();

                // Constructor
                public FlyweightFactory()
                {
                    flyweights.Add("X", new ConcreteFlyweight());
                    flyweights.Add("Y", new ConcreteFlyweight());
                    flyweights.Add("Z", new ConcreteFlyweight());
                }

                public Flyweight GetFlyweight(string key)
                {
                    return ((Flyweight)flyweights[key]);
                }
            }

            /// <summary>
            /// The 'Flyweight' abstract class
            /// </summary>
            abstract class Flyweight
            {
                public abstract void Operation(int extrinsicstate);
            }

            /// <summary>
            /// The 'ConcreteFlyweight' class
            /// </summary>
            class ConcreteFlyweight : Flyweight
            {
                public override void Operation(int extrinsicstate)
                {
                    Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
                }
            }

            /// <summary>
            /// The 'UnsharedConcreteFlyweight' class
            /// </summary>
            class UnsharedConcreteFlyweight : Flyweight
            {
                public override void Operation(int extrinsicstate)
                {
                    Console.WriteLine("UnsharedConcreteFlyweight: " +
                      extrinsicstate);
                }
            }
        }

        public class RealWorld : IPatternExample
        {
            public string Category => "Structural";

            public string Name => "Flyweight";

            public ExampleTypes ExampleType => ExampleTypes.RealWorld;

            public void Main()
            {
                // Build a document with text
                string document = "AAZZBBZB";
                char[] chars = document.ToCharArray();

                CharacterFactory factory = new CharacterFactory();

                // extrinsic state
                int pointSize = 10;

                // For each character use a flyweight object
                foreach (char c in chars)
                {
                    pointSize++;
                    Character character = factory.GetCharacter(c);
                    character.Display(pointSize);
                }
            }

            /// <summary>
            /// The 'FlyweightFactory' class
            /// </summary>
            class CharacterFactory
            {
                private Dictionary<char, Character> _characters = new Dictionary<char, Character>();

                public Character GetCharacter(char key)
                {
                    // Uses "lazy initialization"

                    Character character = null;
                    if (_characters.ContainsKey(key))
                    {
                        character = _characters[key];
                    }
                    else

                    {
                        switch (key)
                        {
                            case 'A': character = new CharacterA(); break;
                            case 'B': character = new CharacterB(); break;
                            //...

                            case 'Z': character = new CharacterZ(); break;
                        }
                        _characters.Add(key, character);
                    }
                    return character;
                }
            }

            /// <summary>
            /// The 'Flyweight' abstract class
            /// </summary>
            abstract class Character
            {
                protected char symbol;
                protected int width;
                protected int height;
                protected int ascent;
                protected int descent;
                protected int pointSize;

                public abstract void Display(int pointSize);
            }

            /// <summary>
            /// A 'ConcreteFlyweight' class
            /// </summary>
            class CharacterA : Character
            {
                // Constructor
                public CharacterA()
                {
                    this.symbol = 'A';
                    this.height = 100;
                    this.width = 120;
                    this.ascent = 70;
                    this.descent = 0;
                }

                public override void Display(int pointSize)
                {
                    this.pointSize = pointSize;
                    Console.WriteLine(this.symbol +
                      " (pointsize " + this.pointSize + ")");
                }
            }

            /// <summary>
            /// A 'ConcreteFlyweight' class
            /// </summary>
            class CharacterB : Character
            {
                // Constructor
                public CharacterB()
                {
                    this.symbol = 'B';
                    this.height = 100;
                    this.width = 140;
                    this.ascent = 72;
                    this.descent = 0;
                }

                public override void Display(int pointSize)
                {
                    this.pointSize = pointSize;
                    Console.WriteLine(this.symbol +
                      " (pointsize " + this.pointSize + ")");
                }
            }

            // ... C, D, E, etc.


            /// <summary>
            /// A 'ConcreteFlyweight' class
            /// </summary>
            class CharacterZ : Character
            {
                // Constructor
                public CharacterZ()
                {
                    this.symbol = 'Z';
                    this.height = 100;
                    this.width = 100;
                    this.ascent = 68;
                    this.descent = 0;
                }

                public override void Display(int pointSize)
                {
                    this.pointSize = pointSize;
                    Console.WriteLine(this.symbol +
                      " (pointsize " + this.pointSize + ")");
                }
            }
        }
    }
}

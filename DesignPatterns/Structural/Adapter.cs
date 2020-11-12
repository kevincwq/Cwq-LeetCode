using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    /// <summary>
    /// Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
    /// https://www.dofactory.com/net/adapter-design-pattern
    /// </summary>
    public class Adapter
    {
        public class Structural : IMain
        {
            public void Main()
            {
                // Create adapter and place a request
                Target target = new Adapter();
                target.Request();
            }

            /// <summary>
            /// The 'Target' class
            /// </summary>
            class Target
            {
                public virtual void Request()
                {
                    Console.WriteLine("Called Target Request()");
                }
            }

            /// <summary>
            /// The 'Adapter' class
            /// </summary>
            class Adapter : Target
            {
                private Adaptee _adaptee = new Adaptee();

                public override void Request()
                {
                    // Possibly do some other work
                    //  and then call SpecificRequest
                    _adaptee.SpecificRequest();
                }
            }

            /// <summary>
            /// The 'Adaptee' class
            /// </summary>
            class Adaptee
            {
                public void SpecificRequest()
                {
                    Console.WriteLine("Called Adaptee SpecificRequest()");
                }
            }
        }

        public class RealWorld : IMain
        {
            public void Main()
            {
                // Non-adapted chemical compound
                Compound unknown = new Compound("Unknown");
                unknown.Display();

                // Adapted chemical compounds
                Compound water = new RichCompound("Water");
                water.Display();

                Compound benzene = new RichCompound("Benzene");
                benzene.Display();

                Compound ethanol = new RichCompound("Ethanol");
                ethanol.Display();
            }

            /// <summary>
            /// The 'Target' class
            /// </summary>
            class Compound
            {
                protected string _chemical;
                protected float _boilingPoint;
                protected float _meltingPoint;
                protected double _molecularWeight;
                protected string _molecularFormula;

                // Constructor
                public Compound(string chemical)
                {
                    this._chemical = chemical;
                }

                public virtual void Display()
                {
                    Console.WriteLine("\nCompound: {0} ------ ", _chemical);
                }
            }

            /// <summary>
            /// The 'Adapter' class
            /// </summary>
            class RichCompound : Compound
            {
                private ChemicalDatabank _bank;

                // Constructor

                public RichCompound(string name)
                  : base(name)
                {
                }

                public override void Display()
                {
                    // The Adaptee
                    _bank = new ChemicalDatabank();

                    _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
                    _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
                    _molecularWeight = _bank.GetMolecularWeight(_chemical);
                    _molecularFormula = _bank.GetMolecularStructure(_chemical);

                    base.Display();
                    Console.WriteLine(" Formula: {0}", _molecularFormula);
                    Console.WriteLine(" Weight : {0}", _molecularWeight);
                    Console.WriteLine(" Melting Pt: {0}", _meltingPoint);
                    Console.WriteLine(" Boiling Pt: {0}", _boilingPoint);
                }
            }

            /// <summary>
            /// The 'Adaptee' class
            /// </summary>
            class ChemicalDatabank
            {
                // The databank 'legacy API'
                public float GetCriticalPoint(string compound, string point)
                {
                    // Melting Point
                    if (point == "M")
                    {
                        return (compound.ToLower()) switch
                        {
                            "water" => 0.0f,
                            "benzene" => 5.5f,
                            "ethanol" => -114.1f,
                            _ => 0f,
                        };
                    }
                    // Boiling Point
                    else
                    {
                        return (compound.ToLower()) switch
                        {
                            "water" => 100.0f,
                            "benzene" => 80.1f,
                            "ethanol" => 78.3f,
                            _ => 0f,
                        };
                    }
                }

                public string GetMolecularStructure(string compound)
                {
                    return (compound.ToLower()) switch
                    {
                        "water" => "H20",
                        "benzene" => "C6H6",
                        "ethanol" => "C2H5OH",
                        _ => "",
                    };
                }

                public double GetMolecularWeight(string compound)
                {
                    return (compound.ToLower()) switch
                    {
                        "water" => 18.015,
                        "benzene" => 78.1134,
                        "ethanol" => 46.0688,
                        _ => 0d,
                    };
                }
            }
        }
    }
}

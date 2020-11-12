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
                throw new NotImplementedException();
            }
        }

        public class RealWorld : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Chain of Responsibility";

            public ExampleTypes ExampleType => ExampleTypes.RealWorld;

            public void Main()
            {
                throw new NotImplementedException();
            }
        }
    }
}

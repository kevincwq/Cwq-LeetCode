﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural
{
    /// <summary>
    /// Provide a surrogate or placeholder for another object to control access to it.
    /// https://www.dofactory.com/net/proxy-design-pattern
    /// </summary>
    public class Proxy
    {
        public class Structural : IPatternExample
        {
            public string Category => "Structural";

            public string Name => "Proxy - 代理";

            public ExampleTypes ExampleType => ExampleTypes.Structural;

            public void Main()
            {
                // Create proxy and request a service
                Subject proxy = new Proxy();
                proxy.Request();
            }

            /// <summary>
            /// The 'Subject' abstract class
            /// </summary>
            abstract class Subject
            {
                public abstract void Request();
            }

            /// <summary>
            /// The 'RealSubject' class
            /// </summary>
            class RealSubject : Subject
            {
                public override void Request()
                {
                    Console.WriteLine("Called RealSubject.Request()");
                }
            }

            /// <summary>
            /// The 'Proxy' class
            /// </summary>
            class Proxy : Subject
            {
                private RealSubject _realSubject;

                public override void Request()
                {
                    // Use 'lazy initialization'
                    if (_realSubject == null)
                    {
                        _realSubject = new RealSubject();
                    }

                    _realSubject.Request();
                }
            }
        }

        public class RealWorld : IPatternExample
        {
            public string Category => "Structural";

            public string Name => "Proxy - 代理";

            public ExampleTypes ExampleType => ExampleTypes.RealWorld;

            public void Main()
            {
                // Create math proxy
                IMath proxy = new MathProxy();

                // Do the math
                Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
                Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
                Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
                Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
            }

            /// <summary>
            /// The 'Subject interface
            /// </summary>
            public interface IMath
            {
                double Add(double x, double y);
                double Sub(double x, double y);
                double Mul(double x, double y);
                double Div(double x, double y);
            }

            /// <summary>
            /// The 'RealSubject' class
            /// </summary>
            class Math : IMath
            {
                public double Add(double x, double y) { return x + y; }
                public double Sub(double x, double y) { return x - y; }
                public double Mul(double x, double y) { return x * y; }
                public double Div(double x, double y) { return x / y; }
            }

            /// <summary>
            /// The 'Proxy Object' class
            /// </summary>
            class MathProxy : IMath
            {
                private Math _math = new Math();

                public double Add(double x, double y)
                {
                    return _math.Add(x, y);
                }
                public double Sub(double x, double y)
                {
                    return _math.Sub(x, y);
                }
                public double Mul(double x, double y)
                {
                    return _math.Mul(x, y);
                }
                public double Div(double x, double y)
                {
                    return _math.Div(x, y);
                }
            }
        }
    }
}

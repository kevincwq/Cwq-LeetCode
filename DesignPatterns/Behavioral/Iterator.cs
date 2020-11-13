using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral
{
    /// <summary>
    /// Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
    /// https://www.dofactory.com/net/iterator-design-pattern
    /// </summary>
    public class Iterator
    {
        /// <summary>
        /// This structural code demonstrates the Iterator pattern which provides for a way to traverse (iterate) over a collection of items without detailing the underlying structure of the collection.
        /// </summary>
        public class Structural : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Iterator - 迭代器";

            public ExampleTypes ExampleType => ExampleTypes.Structural;

            public void Main()
            {
                ConcreteAggregate a = new ConcreteAggregate();
                a[0] = "Item A";
                a[1] = "Item B";
                a[2] = "Item C";
                a[3] = "Item D";

                // Create Iterator and provide aggregate
                Iterator i = a.CreateIterator();

                Console.WriteLine("Iterating over collection:");

                object item = i.First();
                while (item != null)
                {
                    Console.WriteLine(item);
                    item = i.Next();
                }
            }

            /// <summary>
            /// The 'Aggregate' abstract class
            /// </summary>
            abstract class Aggregate
            {
                public abstract Iterator CreateIterator();
            }

            /// <summary>
            /// The 'ConcreteAggregate' class
            /// </summary>
            class ConcreteAggregate : Aggregate
            {
                private ArrayList _items = new ArrayList();

                public override Iterator CreateIterator()
                {
                    return new ConcreteIterator(this);
                }

                // Gets item count
                public int Count
                {
                    get { return _items.Count; }
                }

                // Indexer
                public object this[int index]
                {
                    get { return _items[index]; }
                    set { _items.Insert(index, value); }
                }
            }

            /// <summary>
            /// The 'Iterator' abstract class
            /// </summary>
            abstract class Iterator
            {
                public abstract object First();
                public abstract object Next();
                public abstract bool IsDone();
                public abstract object CurrentItem();
            }

            /// <summary>
            /// The 'ConcreteIterator' class
            /// </summary>
            class ConcreteIterator : Iterator
            {
                private ConcreteAggregate _aggregate;
                private int _current = 0;

                // Constructor
                public ConcreteIterator(ConcreteAggregate aggregate)
                {
                    this._aggregate = aggregate;
                }

                // Gets first iteration item
                public override object First()
                {
                    return _aggregate[0];
                }

                // Gets next iteration item
                public override object Next()
                {
                    object ret = null;
                    if (_current < _aggregate.Count - 1)
                    {
                        ret = _aggregate[++_current];
                    }
                    return ret;
                }

                // Gets current iteration item
                public override object CurrentItem()
                {
                    return _aggregate[_current];
                }

                // Gets whether iterations are complete
                public override bool IsDone()
                {
                    return _current >= _aggregate.Count;
                }
            }
        }

        /// <summary>
        /// This real-world code demonstrates the Iterator pattern which is used to iterate over a collection of items and skip a specific number of items each iteration.
        /// </summary>
        public class RealWorld : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "Iterator - 迭代器";

            public ExampleTypes ExampleType => ExampleTypes.RealWorld;

            public void Main()
            {
                // Build a collection
                Collection collection = new Collection();
                collection[0] = new Item("Item 0");
                collection[1] = new Item("Item 1");
                collection[2] = new Item("Item 2");
                collection[3] = new Item("Item 3");
                collection[4] = new Item("Item 4");
                collection[5] = new Item("Item 5");
                collection[6] = new Item("Item 6");
                collection[7] = new Item("Item 7");
                collection[8] = new Item("Item 8");

                // Create iterator
                Iterator iterator = collection.CreateIterator();

                // Skip every other item
                iterator.Step = 2;

                Console.WriteLine("Iterating over collection with Step 2:");

                for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
                {
                    Console.WriteLine(item.Name);
                }
            }

            /// <summary>
            /// A collection item
            /// </summary>
            class Item
            {
                // Constructor
                public Item(string name)
                {
                    this.Name = name;
                }

                // Gets name
                public string Name { get; }
            }

            /// <summary>
            /// The 'Aggregate' interface
            /// </summary>
            interface IAbstractCollection
            {
                Iterator CreateIterator();
            }

            /// <summary>
            /// The 'ConcreteAggregate' class
            /// </summary>

            class Collection : IAbstractCollection
            {
                private ArrayList _items = new ArrayList();

                public Iterator CreateIterator()
                {
                    return new Iterator(this);
                }

                // Gets item count

                public int Count
                {
                    get { return _items.Count; }
                }

                // Indexer
                public object this[int index]
                {
                    get { return _items[index]; }
                    set { _items.Add(value); }
                }
            }

            /// <summary>
            /// The 'Iterator' interface
            /// </summary>
            interface IAbstractIterator
            {
                Item First();
                Item Next();
                bool IsDone { get; }
                Item CurrentItem { get; }
            }

            /// <summary>
            /// The 'ConcreteIterator' class
            /// </summary>
            class Iterator : IAbstractIterator
            {
                private Collection _collection;
                private int _current = 0;
                private int _step = 1;

                // Constructor
                public Iterator(Collection collection)
                {
                    this._collection = collection;
                }

                // Gets first item
                public Item First()
                {
                    _current = 0;
                    return _collection[_current] as Item;
                }

                // Gets next item
                public Item Next()
                {
                    _current += _step;
                    if (!IsDone)
                        return _collection[_current] as Item;
                    else
                        return null;
                }

                // Gets or sets stepsize
                public int Step
                {
                    get { return _step; }
                    set { _step = value; }
                }

                // Gets current iterator item
                public Item CurrentItem
                {
                    get { return _collection[_current] as Item; }
                }

                // Gets whether iteration is complete
                public bool IsDone
                {
                    get { return _current >= _collection.Count; }
                }
            }
        }
    }
}

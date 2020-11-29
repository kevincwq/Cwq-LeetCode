﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral
{
    /// <summary>
    /// Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
    /// https://www.dofactory.com/net/state-design-pattern
    /// </summary>
    public class State
    {
        /// <summary>
        /// This structural code demonstrates the State pattern which allows an object to behave differently depending on its internal state. The difference in behavior is delegated to objects that represent this state.
        /// </summary>
        public class Structural : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "State - 状态";

            public ExampleTypes ExampleType => ExampleTypes.Structural;

            public void Main()
            {
                // Setup context in a state
                Context c = new Context(new ConcreteStateA());

                // Issue requests, which toggles state
                c.Request();
                c.Request();
                c.Request();
                c.Request();
            }

            /// <summary>
            /// The 'State' abstract class
            /// </summary>
            abstract class State
            {
                public abstract void Handle(Context context);
            }

            /// <summary>
            /// A 'ConcreteState' class
            /// </summary>
            class ConcreteStateA : State
            {
                public override void Handle(Context context)
                {
                    context.State = new ConcreteStateB();
                }
            }

            /// <summary>
            /// A 'ConcreteState' class
            /// </summary>
            class ConcreteStateB : State
            {
                public override void Handle(Context context)
                {
                    context.State = new ConcreteStateA();
                }
            }

            /// <summary>
            /// The 'Context' class
            /// </summary>
            class Context
            {
                private State _state;

                // Constructor
                public Context(State state)
                {
                    this.State = state;
                }

                // Gets or sets the state
                public State State
                {
                    get { return _state; }
                    set
                    {
                        _state = value;
                        Console.WriteLine("State: " + _state.GetType().Name);
                    }
                }

                public void Request()
                {
                    _state.Handle(this);
                }
            }
        }

        /// <summary>
        /// This real-world code demonstrates the State pattern which allows an Account to behave differently depending on its balance. The difference in behavior is delegated to State objects called RedState, SilverState and GoldState. These states represent overdrawn accounts, starter accounts, and accounts in good standing.
        /// </summary>
        public class RealWorld : IPatternExample
        {
            public string Category => "Behavioral";

            public string Name => "State - 状态";

            public ExampleTypes ExampleType => ExampleTypes.RealWorld;

            public void Main()
            {
                // Open a new account
                Account account = new Account("Jim Johnson");

                // Apply financial transactions
                account.Deposit(500.0);
                account.Deposit(300.0);
                account.Deposit(550.0);
                account.PayInterest();
                account.Withdraw(2000.00);
                account.Withdraw(1100.00);
            }

            /// <summary>
            /// The 'State' abstract class
            /// </summary>
            abstract class State
            {
                protected Account account;
                protected double balance;

                protected double interest;
                protected double lowerLimit;
                protected double upperLimit;

                // Properties
                public Account Account
                {
                    get { return account; }
                    set { account = value; }
                }

                public double Balance
                {
                    get { return balance; }
                    set { balance = value; }
                }

                public abstract void Deposit(double amount);
                public abstract void Withdraw(double amount);
                public abstract void PayInterest();
            }

            /// <summary>
            /// A 'ConcreteState' class
            /// <remarks>
            /// Red indicates that account is overdrawn 
            /// </remarks>
            /// </summary>
            class RedState : State
            {
                // Constructor
                public RedState(State state)
                {
                    this.balance = state.Balance;
                    this.account = state.Account;
                    Initialize();
                }

                private void Initialize()
                {
                    // Should come from a datasource
                    interest = 0.0;
                    lowerLimit = -100.0;
                    upperLimit = 0.0;
                }

                public override void Deposit(double amount)
                {
                    balance += amount;
                    StateChangeCheck();
                }

                public override void Withdraw(double amount)
                {
                    Console.WriteLine("No funds available for withdrawal!");
                }

                public override void PayInterest()
                {
                    // No interest is paid
                }

                private void StateChangeCheck()
                {
                    if (balance > upperLimit)
                    {
                        account.State = new SilverState(this);
                    }
                }
            }

            /// <summary>
            /// A 'ConcreteState' class
            /// <remarks>
            /// Silver indicates a non-interest bearing state
            /// </remarks>
            /// </summary>

            class SilverState : State
            {
                // Overloaded constructors
                public SilverState(State state) :
                  this(state.Balance, state.Account)
                {
                }

                public SilverState(double balance, Account account)
                {
                    this.balance = balance;
                    this.account = account;
                    Initialize();
                    StateChangeCheck();
                }

                private void Initialize()
                {
                    // Should come from a datasource
                    interest = 0.0;
                    lowerLimit = 0.0;
                    upperLimit = 1000.0;
                }

                public override void Deposit(double amount)
                {
                    balance += amount;
                    StateChangeCheck();
                }

                public override void Withdraw(double amount)
                {
                    balance -= amount;
                    StateChangeCheck();
                }

                public override void PayInterest()
                {
                    balance += interest * balance;
                    StateChangeCheck();
                }

                private void StateChangeCheck()
                {
                    if (balance < lowerLimit)
                    {
                        account.State = new RedState(this);
                    }
                    else if (balance > upperLimit)
                    {
                        account.State = new GoldState(this);
                    }
                }
            }

            /// <summary>
            /// A 'ConcreteState' class
            /// <remarks>
            /// Gold indicates an interest bearing state
            /// </remarks>
            /// </summary>
            class GoldState : State
            {
                // Overloaded constructors
                public GoldState(State state)
                  : this(state.Balance, state.Account)
                {
                }

                public GoldState(double balance, Account account)
                {
                    this.balance = balance;
                    this.account = account;
                    Initialize();
                    StateChangeCheck();
                }

                private void Initialize()
                {
                    // Should come from a database
                    interest = 0.05;
                    lowerLimit = 1000.0;
                    upperLimit = 10000000.0;
                }

                public override void Deposit(double amount)
                {
                    balance += amount;
                    StateChangeCheck();
                }

                public override void Withdraw(double amount)
                {
                    balance -= amount;
                    StateChangeCheck();
                }

                public override void PayInterest()
                {
                    balance += interest * balance;
                    StateChangeCheck();
                }

                private void StateChangeCheck()
                {
                    if (balance < 0.0)
                    {
                        account.State = new RedState(this);
                    }
                    else if (balance < lowerLimit)
                    {
                        account.State = new SilverState(this);
                    }
                }
            }

            /// <summary>
            /// The 'Context' class
            /// </summary>
            class Account
            {
                private readonly string _owner;

                // Constructor
                public Account(string owner)
                {
                    // New accounts are 'Silver' by default
                    this._owner = owner;
                    this.State = new SilverState(0.0, this);
                }

                // Properties
                public double Balance
                {
                    get { return State.Balance; }
                }

                public State State { get; set; }

                public void Deposit(double amount)
                {
                    State.Deposit(amount);
                    Console.WriteLine("Deposited {0:C} --- ", amount);
                    Console.WriteLine(" Balance = {0:C}", this.Balance);
                    Console.WriteLine(" Status = {0}\n", this.State.GetType().Name);
                }

                public void Withdraw(double amount)
                {
                    State.Withdraw(amount);
                    Console.WriteLine("Withdrew {0:C} --- ", amount);
                    Console.WriteLine(" Balance = {0:C}", this.Balance);
                    Console.WriteLine(" Status = {0}\n", this.State.GetType().Name);
                }

                public void PayInterest()
                {
                    State.PayInterest();
                    Console.WriteLine("Interest Paid --- ");
                    Console.WriteLine(" Balance = {0:C}", this.Balance);
                    Console.WriteLine(" Status = {0}\n", this.State.GetType().Name);
                }
            }
        }
    }
}

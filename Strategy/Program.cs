﻿
using Strategy;

var context = new Context();

Console.WriteLine("Client: Strategy is set to normal sorting.");
context.SetStrategy(new ConcreteStrategyA());
context.DoSomeBusinessLogic();

Console.WriteLine();

Console.WriteLine("Client: Strategy is set to reverse sorting.");
context.SetStrategy(new ConcreteStrategyB());
context.DoSomeBusinessLogic();
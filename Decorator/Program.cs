
using Decorator;

var simple = new ConcreteComponent();
Console.WriteLine("Client: I get a simple component:");
ClientCode(simple);
Console.WriteLine();

// ...as well as decorated ones.
//
// Note how decorators can wrap not only simple components but the
// other decorators as well.
ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
Console.WriteLine("Client: Now I've got a decorated component:");
ClientCode(decorator2);

void ClientCode(Component component)
{
    Console.WriteLine("RESULT: " + component.Operation());
}
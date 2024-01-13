
namespace Observer
{
    public class ConcreteObserver2 : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.WriteLine("ConcreteObserver2: Reacted to the event.");
            }
        }
    }
}

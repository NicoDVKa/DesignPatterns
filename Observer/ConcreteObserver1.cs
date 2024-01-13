

namespace Observer
{
    public class ConcreteObserver1 : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserver1: Reacted to the event.");
            }
        }
    }
}

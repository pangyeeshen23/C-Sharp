namespace Events
{
    public delegate void Notify(string message);

    public class EventPublisher
    {
        public event Notify OnNotify;
        public void RaiseEvent(string message)
        {
            OnNotify?.Invoke(message);
        }
    }

    public class EventSubscriber
    {
        public void OnEventRaised(string mesage)
        {
            Console.WriteLine("Event Received: " + mesage);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();
            publisher.OnNotify += subscriber.OnEventRaised;
            publisher.OnNotify += subscriber.OnEventRaised;
            publisher.RaiseEvent("test");
            Console.WriteLine("Hello, World!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP.Observer
{
    public static class  ObserverDemo{
        public static void Run()
        {
            Console.WriteLine("Hello, World!");

            var publisher = new Publisher("Message Hub");
            var subscriber1 = new Subscriber("First Subscriber");
            var subscriber2 = new Subscriber("Second Subscriber");
            var subscriber3 = new Subscriber("Third Subscriber");

            Console.WriteLine("Adding the first and the second subscribers to the publisher.");
            publisher.Subscribe(subscriber1);
            publisher.Subscribe(subscriber2);

            Console.WriteLine("Notifying subscribers.");
            publisher.Notify("Sequence initiated.");

            Console.WriteLine("Removing the first subscriber.");
            publisher.Unsubscribe(subscriber1);

            Console.WriteLine("Adding the third subscriber.");
            publisher.Subscribe(subscriber3);

            Console.WriteLine("Notifying subscribers.");
            publisher.Notify("Update received from the server.");

            Console.ReadKey();
        }
    }

    internal interface ISubject
    {
        string Name { get; }
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify(string message);

    }


    internal interface IObserver
    {
        void Update(ISubject subject, string message);
    }

    internal class Publisher : ISubject
    {
        private string name;
        private List<IObserver> observers;

        public Publisher(string name)
        {
            this.name = name;
            observers = new List<IObserver>();
        }

        public string Name => name;

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(this, message);
            }
        }
    }
    internal class Subscriber : IObserver
    {
        private string name;

        public Subscriber(string name)
        {
            this.name = name;
        }

        public void Update(ISubject subject, string message)
        {
            Console.WriteLine($"'{message}' message received  from {subject.Name} by {name}.");
        }
    }
}

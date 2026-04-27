using System;

namespace EXP03
{
    // 1. SRP – Single Responsibility Principle
    class User
    {
        public string Email { get; set; }
    }

    class EmailService
    {
        public void Send(string email)
        {
            Console.WriteLine("Email sent to : " + email);
        }
    }

    // 2. OCP – Open/Closed Principle
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }

    // 3. LSP – Liskov Substitution Principle
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // 4. ISP – Interface Segregation Principle
    interface IPrinter
    {
        void Print();
    }

    class CPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }
    }

    // 5. DIP – Dependency Inversion Principle
    interface IMessageService
    {
        void SendMessage(string msg);
    }

    class CSMSService : IMessageService
    {
        public void SendMessage(string msg)
        {
            Console.WriteLine("SMS : " + msg);
        }
    }

    class Notification
    {
        IMessageService service;

        public Notification(IMessageService service)
        {
            this.service = service;
        }

        public void Notify()
        {
            service.SendMessage("Hello SOLID");
        }
    }

    class Program
    {
        static void Main()
        {
            // SRP
            User user = new User { Email = "amit@gmail.com" };
            EmailService email = new EmailService();
            Console.WriteLine("SRP : Single Responsibility Principle");
            email.Send(user.Email);

            // OCP
            Shape shape1 = new Circle();
            Shape shape2 = new Rectangle();
            Console.WriteLine("\nOCP : Open/Closed Principle");
            shape1.Draw();
            shape2.Draw();

            // LSP
            Animal a = new Dog();
            Console.WriteLine("\nLSP : Liskov Substitution Principle");
            a.Sound();

            // ISP
            IPrinter prt = new CPrinter();
            Console.WriteLine("\nISP : Interface Segregation Principle");
            prt.Print();

            // DIP
            IMessageService sms = new CSMSService();
            Notification notify = new Notification(sms);
            Console.WriteLine("\nDIP : Dependency Inversion Principle");
            notify.Notify();

            Console.ReadLine();
        }
    }
}
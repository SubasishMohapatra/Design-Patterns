﻿using AbstractFactory;
using AbstractFactoryRevisited;
using Adapter;
using Builder;
using Chain_Of_Responsibility;
using Composite;
using Decorator;
using Facade;
using Observer;
using State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Please uncomment and comment out demos you want to see
            #region Adapter Demo
            //AdapterDemo();
            #endregion

            #region Observer Demo
            //ObserverDemo();
            #endregion

            #region AbstractFactory Demo

            //AbstractFactory();

            #endregion

            #region AbstractFactoryRevisited Demo

            //AbstractFactoryRevisited();

            #endregion

            #region Decorator Demo

            //Decorator();

            #endregion

            #region Visitor Demo

            //Visitor();

            #endregion

            #region Composite

            //Composite();

            #endregion

            #region Facade Demo

            //Facade();

            #endregion

            #region Chain of responsibility Demo

            //ChainOfResponsibility();

            #endregion

            #region Builder Demo

            //Builder();

            #endregion

            #region State Demo

            State();

            #endregion

            Console.ReadLine();
        }

        private static void State()
        {
            #region Uber example

            Uber uberApp = new Uber();
            uberApp.Book();
            uberApp.Book();
            uberApp.Book();
            uberApp.Book();

            uberApp.StartTrip(1);
            uberApp.StartTrip(2);
            uberApp.RideComplete(1);
            uberApp.RideComplete(2);
            uberApp.Cancelled(3);
            uberApp.Cancelled(4);

            uberApp.Cancelled(1);
            uberApp.StartTrip(1);

            uberApp.Book();
            uberApp.Book();
            uberApp.Book();
            uberApp.Book();
            uberApp.Book();
            uberApp.Book();
            uberApp.Book();
            uberApp.Book();
            uberApp.Book();
            uberApp.Book();

            uberApp.Book();//No cabs left

            #endregion

            #region Sample Object

            //SomeObject someObject = new SomeObject();
            //Console.WriteLine("Create new object");
            //someObject.Submit(); //New
            //Console.WriteLine("Edit changes");
            //someObject.Submit(); //Edit mode
            //Console.WriteLine("Try changing a readonly object");
            //someObject.ChangeState(new ReadOnlyState());
            //someObject.Submit(); //Read only mode

            #endregion
        }

        private static void Builder()
        {
            var computer = new Computer();
            computer.Build("Dell", "Lenovo", "HP", "Intel");
        }

        private static void ChainOfResponsibility()
        {
            var project = new Project();
            var pm = new ProjectManager();
            var pl = new ProjectLead();
            var developer = new Developer();
            var tester = new Tester();

            pm.Sucessor = pl;
            pl.Sucessor = developer;
            developer.Sucessor = tester;
            pm.DoJob(project);
        }

        private static void Facade()
        {
            var candidate = new Candidate();
            var interview = new Interview();
            interview.ScreenCandidate(candidate);

            Console.WriteLine("Candidate {0}", interview.IsCleared ? "cleared" : "could not clear");
        }

        private static void Composite()
        {
            var drive = new Drive("Drive");
            var a = new Directory("A");
            var b = new Directory("B");
            var c = new Directory("C");
            var d = new Directory("D");
            a.Add(new File("A1"));
            a.Add(new File("A2"));
            b.Add(new File("B1"));
            c.Add(b);
            d.Add(c);
            d.Add(a);
            drive.Add(d);
            drive.Display();
        }

        private static void Visitor()
        {
            var dotnetTrainer = new DotnetTrainer("Scott Hansellman");
            var javaTrainer = new JavaTrainer("Gosling");
            var john = new DotnetEmployee("John");
            var johny = new JavaEmployee("Johny");
            var jonathan = new DotnetEmployee("Jonathan");
            var rohan = new JavaEmployee("Rohan");
            var bhaskar = new DotnetEmployee("Bhaskar");
            var steve = new JavaEmployee("Steve");
            var harman = new DotnetEmployee("Harman");
            john.Accept(dotnetTrainer);
            johny.Accept(javaTrainer);
            jonathan.Accept(dotnetTrainer);
            rohan.Accept(javaTrainer);
            bhaskar.Accept(dotnetTrainer);
            steve.Accept(javaTrainer);
            harman.Accept(dotnetTrainer);
        }

        private static void Decorator()
        {
            var cheeseDecorator = new CheeseDecorator(null);
            var pizza = new PizzaDecorator(cheeseDecorator);
            Console.WriteLine(pizza.Display());
        }

        private static void AbstractFactoryRevisited()
        {
            Console.WriteLine(new DotnetSoftwareProfessionalFactory().GetDesktopProfessional().ToString());
            Console.WriteLine(new DotnetSoftwareProfessionalFactory().GetWebProfessional().ToString());
            Console.WriteLine(new JavaSoftwareProfessionalFactory().GetDesktopProfessional().ToString());
            Console.WriteLine(new JavaSoftwareProfessionalFactory().GetWebProfessional().ToString());
        }

        private static void AbstractFactory()
        {
            SoftwareProfessional resource = SoftwareProfessionaFactory.GetSoftwareProfessional("Dotnet");
            Console.WriteLine(resource.GetDesktopProfessional().ToString());
            Console.WriteLine(resource.GetWebProfessional());

            resource = SoftwareProfessionaFactory.GetSoftwareProfessional("Java");
            Console.WriteLine(resource.GetDesktopProfessional());
            Console.WriteLine(resource.GetWebProfessional());
        }

        private static void ObserverDemo()
        {
            var observer = new Observer.Observer();
            var p1 = new Publisher(observer) { ID = 1 };
            var p2 = new Publisher(observer) { ID = 2 };
            var p3 = new Publisher(observer) { ID = 3 };
            var p4 = new Publisher(observer) { ID = 4 };
            var p5 = new Publisher(observer) { ID = 5 };

            var s1 = new Subscriber("s1", observer);
            s1.Subscribe(p1.ID);
            s1.Subscribe(p2.ID);
            var s2 = new Subscriber("s2", observer);
            s2.Subscribe(p3.ID);
            s2.Subscribe(p4.ID);
            var s3 = new Subscriber("s3", observer);
            s3.Subscribe(p1.ID);
            s3.Subscribe(p2.ID);
            s3.Subscribe(p5.ID);

            p1.Update();
            p2.Update();
            p3.Update();
            p4.Update();
            p5.Update();

            Console.ReadLine();
        }

        private static void AdapterDemo()
        {
            QueueAdapter client = new QueueAdapter();
            client.Push("A");
            client.Push("B");
            client.Push("C");
            client.Push("D");
            client.Push("E");
            Console.WriteLine("FIFO output");
            Console.WriteLine("{0}", client.Pop());
            Console.WriteLine("{0}", client.Pop());
            Console.WriteLine("{0}", client.Pop());
            Console.WriteLine("{0}", client.Pop());
            Console.WriteLine("{0}", client.Pop());
            Console.ReadLine();
        }
    }
}

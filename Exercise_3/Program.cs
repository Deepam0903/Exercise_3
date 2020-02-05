using System;

namespace Exercise_3
{
    

        class Person
        {
            private string name; // field
            public string Name   // property
            {
                get { return name; }
                set { name = value; }
            }
        }

    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }

    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    abstract class Animal1
    {
        // Abstract method (does not have a body)
        public abstract void animalSound1();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    interface IAnimal
    {
        void animalSound2(); // interface method (does not have a body)
    }

    class Pig2 : IAnimal
    {
        public void animalSound2()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Pig1 : Animal1
    {
        public override void animalSound1()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    enum Level
    {
        Low,
        Medium,
        High
    }
    class Program
        {



            static void Main(string[] args)
            {
                Person myObj = new Person();
                myObj.Name = "Liam";
                Console.WriteLine(myObj.Name);

            Car myCar = new Car();

           
            myCar.honk();

           
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();


            Pig1 my_Pig = new Pig1(); // Create a Pig object
            my_Pig.animalSound1();  // Call the abstract method
            my_Pig.sleep();

            Pig2 my2Pig = new Pig2();  // Create a Pig object
            my2Pig.animalSound2();


            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
        }
        }
    }
   
 
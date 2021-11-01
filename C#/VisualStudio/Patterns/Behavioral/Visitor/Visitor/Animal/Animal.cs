using System;

namespace Visitor
{
    public interface IAnimal
    {
        void Accept(IVisitor visitor);
    }

    public class Cat : IAnimal
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Make(this);
        }
    }

    public class Dog : IAnimal
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Make(this);
        }
    }

    public interface IVisitor
    {
        void Make(Cat cat);

        void Make(Dog dog);
    }

    class Move : IVisitor
    {
        public void Make(Cat cat)
        {
            Console.WriteLine(this.GetType().Name);
        }

        public void Make(Dog dog)
        {
            Console.WriteLine(this.GetType().Name);
        }
    }

    class Speak : IVisitor
    {
        public void Make(Cat lightCargo)
        {
            Console.WriteLine(this.GetType().Name);
        }

        public void Make(Dog heavyCargo)
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
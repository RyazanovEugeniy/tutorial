using System;
using System.Collections.Generic;

namespace Composite
{
    abstract class Component
    {
        public Component() { }

        public abstract string GetInfo();

        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }

    class Leaf : Component
    {
        public override string GetInfo()
        {
            return "Leaf";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }

    class Branch : Component
    {
        protected List<Component> component = new List<Component>();

        public override void Add(Component component)
        {
            this.component.Add(component);
        }

        public override void Remove(Component component)
        {
            this.component.Remove(component);
        }

        public override string GetInfo()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Component component in this.component)
            {
                result += component.GetInfo();
                if (i != this.component.Count - 1)
                    result += "+";
                i++;
            }

            return result + ")";
        }
    }
}
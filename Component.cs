using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Composite
{
    public class Component : IEnumerable<Component>
    {
        public int ID { get; set; }

        private List<Component> children;

        public Component(int iD)
        {
            ID = iD;
            children = new List<Component>();
        }

        public string Concat()
        {
            string txt = GetName() + " ";
            foreach (Component child in children)
            {
                txt += child.Concat() + " ";
            }
            return txt;
        }

        private string GetName()
        {
            string txt;
            if (children.Count == 0) txt = "leaf";
            else txt = "composite";
            return txt + ID.ToString();
        }

        public void Add(Component child)
        {
            children.Add(child);
        }

        public IEnumerator<Component> GetEnumerator()
        {
            return ((IEnumerable<Component>)children).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Component>)children).GetEnumerator();
        }
    }
}

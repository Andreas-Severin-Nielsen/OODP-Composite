using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Composite
{
    public class Client
    {

        int id;

        public void DoTask()
        {
            id = 0;
            Component composite2 = new Component(GetNewId());
            composite2.Add(new Component(GetNewId()));
            composite2.Add(new Component(GetNewId()));
            composite2.Add(new Component(GetNewId()));
            Component composite1 = new Component(GetNewId());
            composite1.Add(new Component(GetNewId()));
            composite1.Add(composite2);
            composite1.Add(new Component(GetNewId()));

            Console.WriteLine("Composite 1: " + composite1.Concat());
            Console.WriteLine("Composite 2: " + composite2.Concat());
            Console.ReadKey();
        }

        private int GetNewId()
        {
            id++;
            return id;
        }
    }
}

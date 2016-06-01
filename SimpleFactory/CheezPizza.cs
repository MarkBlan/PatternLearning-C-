using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class CheezPizza : Pizza
    {
        public override void Bate()
        {
            Console.WriteLine("Cheez Pizza Is Bate.");
        }

        public override void Box()
        {
            Console.WriteLine("Cheez Pizza Is Box.");
        }

        public override void Cut()
        {
            Console.WriteLine("Cheez Pizza Is Cut.");
        }

        public override void Prepare()
        {
            Console.WriteLine("Cheez Is Prepared.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Polymorhism
{
    class Audi : Car
    {
        private string Brand = "Audi";

        public string Model { get; set; }

        public Audi(string model, int horsePower, string color) : base(horsePower, color)
        {
            this.Model = model;
        }
        
        public new void ShowDetails()
        {
        Console.WriteLine("Car Details this is an {0} {1} is has {2} horse power and is {3} in color"
                            ,"Audi", Model, HorsePower,Color);
        }

        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired", Model);
        }
            
    }
}

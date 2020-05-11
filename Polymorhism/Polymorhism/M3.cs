using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorhism
{
    class M3:BMW    

    {
        public M3(string model, int horsePower, string color) :base(model,horsePower, color)

        {
            this.Model = model;
        }

        ////This is sealed and doesn't allow inheritence
        //public override void Repair()
        //{
        //    base.Repair();
        //}

    }
}

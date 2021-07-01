using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.AbstractClasses
{
    class ConcreteGeek : GeeksForGeeks
    {
        public override object Clone()
        {
            throw new NotImplementedException();
        }

        public override void gfg()
        {
            throw new NotImplementedException();
        }

        public override string VirtualMethod()
        {
            return base.VirtualMethod();
        }
    }
}

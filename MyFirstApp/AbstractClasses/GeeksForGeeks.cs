using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.AbstractClasses
{
    public abstract class GeeksForGeeks : ICloneable
    {
        public abstract void gfg();

        public string Test()
        {
            return "We are testing!";
        }

        public abstract object Clone();
        //{
        //    throw new NotImplementedException();
        //}

        public virtual string VirtualMethod()
        {
            return "This is a Virtual method, you may override me!";
        }
    }
}

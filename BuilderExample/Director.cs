using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    internal class Director
    {
        PBuilder builder;
        public void construct (PBuilder builder)
        {
            this.builder = builder;
            builder.startingOperation();
            builder.buildBody();
            builder.addExtention();
            builder.endOperation();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    internal interface PBuilder
    {
        void startingOperation();
        void buildBody();
        void addExtention();
        void endOperation();
        Product getCar();
    }
}

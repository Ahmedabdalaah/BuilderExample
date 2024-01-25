using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
namespace BuilderExample
{
    internal class Product
    {
        private LinkedList<string> parts;
        public Product()
        {
            parts = new LinkedList<string>();
        }
        public void add(string part)
        {
            parts.AddLast(part);
        }
        public string show()
        {
            StringBuilder strb = new StringBuilder();
            strb.AppendLine(" product components are : ");
            foreach( string part in parts)
                strb.AppendLine(part);
                return strb.ToString();  
        }
    }
}

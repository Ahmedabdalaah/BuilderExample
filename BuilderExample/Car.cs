using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    internal class Car : PBuilder
    {
        private string modelName;
        private Product product;
        public Car(string model)
        {
            product = new Product( );
            this.modelName = model;
        }
        public void startingOperation()
        {
            product.add($" the car model name is :  {this.modelName}");
        }
        public void buildBody()
        {
            product.add("The body of the car is added ");
        }
        public void addExtention()
        {
            product.add("The extention of the car is added");
        }
        public void endOperation()
        {
            // end Operation
        }

        public Product getCar()
        {
            return product;
        }
    }
}

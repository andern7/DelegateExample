using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class MyDelegates
    {   //define delegate type
        public delegate void PerformAction(double firstNumber, double secondNumber);
        
        //delegate below, added 'event' keyword to make 'actions' indirectly accessible.
        
        public PerformAction actions;

       //Event handler
        public event EventHandler<EventArgs> ActionPerformed;
        
        //signature and return type match types in PerformAction delegate, calculates sum and displays.
        private void Add(double operand1, double operand2)
        {
            double total = operand1 + operand2;
            Console.WriteLine("Sum total is {0}", total);
            
        }

        private void Subtract(double operand1, double operand2)
        {
            //calculate difference
            double difference = operand1 - operand2;

            //print difference
            Console.WriteLine("Difference is {0}", difference);
        }

        private void Multiply(double operand1, double operand2)
        {
            //calculate product
            double product = operand1 * operand2;

            //print product
            Console.WriteLine("Product is {0}", product);
        }

        private void Divide(double operand1, double operand2)
        {
            //calculate quotient
            double quotient = operand1 / operand2;

            //print quotient
            Console.WriteLine("Quotient is {0}", quotient);
        }
        public MyDelegates()
        {
            //the short way
            this.actions = Add;
            //the long way
            this.actions += new PerformAction(Multiply);
            this.actions += Multiply;
            this.actions += Divide;
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegates example = new MyDelegates();
            example.actions(2.3, 4.5);
            Console.ReadKey(true);
        }
    }
}

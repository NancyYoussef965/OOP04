using System;

namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region P01 Q01
            //Calculator calc = new Calculator();

            //Console.WriteLine(calc.Add(2, 3));      
            //Console.WriteLine(calc.Add(1, 2, 3));      
            //Console.WriteLine(calc.Add(2.5, 3.7));

            #endregion


            #region P01 Q02

            //Rectangle r1 = new Rectangle();              
            //Rectangle r2 = new Rectangle(5, 10);      
            //Rectangle r3 = new Rectangle(7);          

            //Console.WriteLine($"r1: {r1.Width} x {r1.Height}");
            //Console.WriteLine($"r2: {r2.Width} x {r2.Height}");
            //Console.WriteLine($"r3: {r3.Width} x {r3.Height}");
            #endregion


            #region P01 Q03
            //ComplexNumber num1 = new ComplexNumber(3, 4);  
            //ComplexNumber num2 = new ComplexNumber(1, 2);  

            //ComplexNumber sum = num1 + num2;    
            //ComplexNumber diff = num1 - num2;  

            //Console.WriteLine("Sum: " + sum);      
            //Console.WriteLine("Difference: " + diff); 

            #endregion

            #region P01 Q04

            //Employee emp = new Employee();
            //emp.Work(); 

            //Manager mgr = new Manager();
            //mgr.Work();

            #endregion

            #region  P01 Q05
            //BaseClass b1 = new DerivedClass1();
            //b1.DisplayMessage(); 

            //BaseClass b2 = new DerivedClass2();
            //b2.DisplayMessage();  

            //DerivedClass2 d2 = new DerivedClass2();
            //d2.DisplayMessage();

            #endregion

            #region  P02 Q01
            //Duration d1 = new Duration();  
            //Duration d2 = new Duration(1, 30, 45); 

            //d1.Display();
            //d2.Display();
            #endregion

            #region  P02 Q02
            //Duration d1 = new Duration(1, 20, 30);
            //Duration d2 = new Duration(1, 20, 30);
            //Duration d3 = new Duration(0, 45, 10);

            //Console.WriteLine(d1.ToString());      
            //Console.WriteLine(d1.Equals(d2));        
            //Console.WriteLine(d1.Equals(d3));         
            //Console.WriteLine(d1.GetHashCode());     
            //Console.WriteLine(d2.GetHashCode());
            #endregion



            #region P02 Q03
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());
            #endregion

            #region P02 Q04

            #endregion


        }
    }
}
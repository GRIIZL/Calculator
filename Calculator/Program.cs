using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double rez;
            bool check=false;

            Console.WriteLine("Введите превое число");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double z = double.Parse(Console.ReadLine());

            while (check == false) 
            { 
             Console.WriteLine("Введите желаемую операцию : *, /, +, -");
             string oper = Console.ReadLine();
            
           
            if ("*" == oper)
            {
               rez = Ymnojenie(x, z);
                check = true;
                Console.WriteLine(rez);
            }
            if ("/" == oper)
            {
                rez = Delenie(x, z);
                check = true;
                Console.WriteLine(rez);
            }
            if ("+" == oper)
            {
                rez = slojenie(x, z);
                check = true;
                Console.WriteLine(rez);
            }
            if ("-" == oper)
            {
                rez = vichitanie(x, z);
                check = true;
                Console.WriteLine(rez);
            }
            
            else
                { Console.WriteLine("Повторите попытку"); }
            }



            static double slojenie(double x, double z)
            {
                return x + z;
            }
            static double vichitanie(double x, double z)
            {
                return x - z;
            }
            static double Delenie(double x, double z)
            {
                return x / z;
            }
            static double Ymnojenie(double x , double z)
            {
                return x * z;
            }

            
            
            
            
            
            
            
            
            
            
            
            
            
               
               
            

            
        }
    }
}

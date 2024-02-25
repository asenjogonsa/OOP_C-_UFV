/*
Pablo Asenjo
25/02/2024
               _ _       \ \
    .-"""""-. / \_> /\    |/
   /         \.'`  `',.--//
 -(           I      I  @@\
   \         /'.____.'\___|
    '-.....-' __/ | \   (`)
             /   /  /
                 \  \
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;

namespace code
{
    public class Calculator
    {
        private const int EXIT = 7;
        public Calculator()
        {

        }
        public int PrintOperation()
        {

            Console.WriteLine("--------------------------------------");
            Console.WriteLine(" 1. Add");
            Console.WriteLine(" 2. Subtract");
            Console.WriteLine(" 3. Multiply");
            Console.WriteLine(" 4. Divide");
            Console.WriteLine(" 5. Pow");
            Console.WriteLine(" 6. Modules");
            Console.WriteLine(" 7. Exit");
            Console.WriteLine("--------------------------------------");

            int option = int.Parse(Console.ReadLine());

            if (option < 1 || option > 7 && option == EXIT)
            {
                return EXIT;
            }

            return option;
        }
        public static int Add(int op1, int op2)
        {
            return op1 + op2;
        }
        public static int Subtract(int op1, int op2)
        {
            return op1 - op2;
        }
        public static int Multiply(int op1, int op2)
        {
            return op1 * op2;
        }
        public static int Divide(int op1, int op2)
        {
            if (op2 == 0)
                return Int32.MaxValue;
            else
                return op1 / op2;
        }
        public static int Pow(int op1, int op2)
        {
            int resultado = 1;
            if (op2 == 0)
            {
                return 1;
            }
            for (int i = 0; i < op2; i++)
            {
                resultado *= op1;
            }
            return resultado;
        }
        public static int Mod(int op1, int op2)
        {
            if (op2 == 0)
            {
                return 0;
            }
            return op1 % op2;
        }
        public void Perform_operation(int op1, int op2, int op)
        {
            double solucion = 0;
            string opt = "";
            if (op == 1)
            {
                opt = "+";
                solucion = Add(op1, op2);
            }
            else if (op == 2)
            {
                opt = "-";
                solucion = Subtract(op1, op2);
            }
            else if (op == 3)
            {
                opt = "*";
                solucion = Multiply(op1, op2);
            }
            else if (op == 4)
            {
                opt = "/";
                solucion = Divide(op1, op2);
            }
            else if (op == 5)
            {
                opt = "^";
                solucion = Pow(op1, op2);
            }
            else if (op == 6)
            {
                opt = "%";
                solucion = Mod(op1, op2);
            }
            Console.WriteLine($"{op1}{opt}{op2}={solucion}");
        }
    }
    public class Program
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();

            int option = calculator.PrintOperation();
            while (option >= 1 && option < 7)
            {

                Console.Clear();
                Console.Write("Insert the value of the first operator: ");
                int op1 = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.Write("Insert the value of the second operator: ");
                int op2 = int.Parse(Console.ReadLine());

                calculator.Perform_operation(op1, op2, option);

                option = calculator.PrintOperation();
            }
            Console.WriteLine("Exiting");

        }
    }
}
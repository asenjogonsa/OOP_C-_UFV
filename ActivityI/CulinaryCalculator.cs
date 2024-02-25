/*
Pablo Asenjo
18/02/2024
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

namespace oppguidedpw
{
    public class Program
    {

        //empezamos con las funciones
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
            return op1 / op2;
        }
        public static void Main()
        {
            int option = 1;      //sera usado para asignar la operacion a realizar
            int result = 0;      //se le asignara el valor final

            string tmp = "";
            string sign = "";    //para el simbolo "lit"

            while (option >= 1 && option <= 5)
            {
                Console.WriteLine("**************************");
                Console.WriteLine("*     1. Add             *");
                Console.WriteLine("*     2. Subtract        *");
                Console.WriteLine("*     3. Multiply        *");
                Console.WriteLine("*     4. Divide          *");
                Console.WriteLine("*     5. Exit            *");
                Console.WriteLine("**************************");
                
                tmp = Console.ReadLine();
                option = int.Parse(tmp);

               

                if (option >= 5) 
                {
                    break;
                }

                Console.WriteLine("Insert the value of the fist operator: ");
                int op1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Insert the value of the second operator: ");
                int op2 = int.Parse(Console.ReadLine());

                if (option == 1)         //sum
                {
                    result = Add(op1, op2);
                    sign = " + ";
                }
                else if (option == 2)    //resta
                {
                    result = Subtract(op1, op2);
                    sign = " - ";
                }
                else if (option == 3)    //mult
                {
                    result = Multiply(op1, op2);
                    sign = " * ";
                }
                else if (option == 4)    //divi
                {

                    if (op2 == 0) // por si
                    {
                            Console.WriteLine("It´s imposible to perform te opertation");
                    }
                    else 
                    {
                        result = Divide(op1, op2);
                        sign = " / ";
                    }
                }

                Console.WriteLine(op1 + sign + op2 + " = " + result);

            }
        }
    }
}


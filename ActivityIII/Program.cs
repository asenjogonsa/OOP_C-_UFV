/*
Pablo Asenjo
03/03/2024
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
        public static void Main()
        {
            Calculator calculator = new Calculator();
            int option = calculator.PrintOperations();
            while (option >= 1 && option < calculator.Exit())
            {
                Console.Clear();
                Console.Write("Insert the value of the first operand: ");
                int opl = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.Write("Insert the value of the second operand: ");
                int op2 = int.Parse(Console.ReadLine());
                calculator.PerformOperation(
                 option,
                 op1,
                 op2);
                option = calculator.PrintOperations();
            }
        }
    }
}


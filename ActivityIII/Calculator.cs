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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
#include 

namespace code
{
	public class Calculator
	{
		private Operation[] operations;

		public Calculator()
		{
			this.operations = new Operation[7];

			this.operations[1] = new Operation("Add", "+", 1);
			this.operations[2] = new Operation("Subtract", "-", 2);
			this.operations[3] = new Operation("Multiply", "*", 3);
			this.operations[4] = new Operation("Divide", "/", 4);
			this.operations[5] = new Operation("Pow", "^", 5);
			this.operations[6] = new Operation("Modules", "%", 6);
			
		}
		public int Exit()
		{
			return this.operations.Length;
		}
		public int PrintOperations()
		{
			Console.Clear();
			Console.WriteLine("---------------------------------");
			for (int i = 1; i < this.operations.Length; i++)
			{
				Console.WriteLine($"{i}. {this.operations[i].GetName()}");
			}
            Console.WriteLine($"{this.Exit()}. Exit");
            Console.WriteLine("---------------------------------");

			string tmp = Console.ReadLine();

			if (tmp == "")return this.Exit();

			int option = int.Parse(tmp);

			if(option < 1 || option > this.Exit()) return this.Exit();

			return option;

        }
		public void PerformOperations(int op, int op1, int op2)
		{
			int result = this.operations[op].Operate(op1, op2);
			Console.Clear();
			Console.WriteLine(${ op1} { this.operations[op].GetSymbol()} { op2} = {result});
			Console.ReadLine();
		}
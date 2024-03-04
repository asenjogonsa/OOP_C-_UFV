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

namespace code
{
    public class Operations()
    {
		private string symbol;
		private string name;
		private int operation;

		public Operations(string name, string symbol, int operationId)
		{
			this.name = name;
			this.symbol = symbol;
			this.operation = operationId;
		}

		private int Add(int op1, int op2)
		{
			opt = "+";
			return op1 + op2;	
		}
		private int Subtract(int op1, int op2)
		{
			opt = "-";
			return op1 - op2;
		}
		private int Multiply(int op1, int op2)
		{
			opt = "*";
			return op1 * op2;
		}
		private int Divide(int op1, int op2)
		{
			opt = "/";
			if (op2 == 0)
				return Int32.MaxValue;
			else
				return op1 / op2;
		}
		private int Pow(int op1, int op2)
		{
			opt = "^";
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
		private int Modulus(int op1, int op2)
		{
			opt = "%"
			if (op2 == 0)
			{
				return 0;
			}
			return op1 % op2;
		}

		public int Operate(int op1, int op2)
		{
			double result = 0;
			if (this.operation == 1)
			{
				opt = "+";
				result = this.Add(op1, op2);
			}
			else if (this.operation == 2)
			{
				opt = "-";
				result = this.Subtract(op1, op2);
			}
			else if (this.operation == 3)
			{
				opt = "*";
				result = this.Multiply(op1, op2);
			}
			else if (this.operation == 4)
			{
				opt = "/";
				result = this.Divide(op1, op2);
			}
			else if (this.operation == 5)
			{
				opt = "^";
				result = this.Pow(op1, op2);
			}
			else if (this.operation == 6)
			{
				opt = "%";
				result = this.Mod(op1, op2);
			}
		

		{
		public string GetSymbol()
		{
			return this.symbol;
		}
		public string GetName()
		{
			return this.name;
		}

}
}


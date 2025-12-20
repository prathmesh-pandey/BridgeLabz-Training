public class Operators{
	static void Main(){
		//Implementation of operators in java
		//1. Arithemetic Operators
		Console.WriteLine("Arithemetic Operators");
		//Addition(+) 
		int sum = 10+20;
		Console.WriteLine("Sum of 10 and 20 using + operator = "+sum);
		
		//Substraction(-)
		int sub = 25-5;
		Console.WriteLine("Differnce between 25 and 5 using - operator = "+sub);
		
		//Multiplication(*)
		int mul = 69*4;
		Console.WriteLine("Product of 69 and 4 using * operator = "+mul);
		
		//Division(/)
		double div = 19.0/56;
		Console.WriteLine("Quotient of 19 and 56 using / operator = "+div);
		
		//Modulus(%)
		double mod = 14%30;
		Console.WriteLine("Remainder of 14/30 using % operator = "+mod);
		Console.WriteLine();
		
		//2.Relational Operators
		Console.WriteLine("Relational Operators");
		
		//Equal to(==)
		Console.WriteLine("Checking if 2 == 3 using equal to operator, result is "+ (2==3));
		
		//Not Equal to(!=)
		Console.WriteLine("Checking if 2 == 3 using not equal to operator, result is "+ (2!=3));
		
		//Greater than(>)
		Console.WriteLine("Checking if 2 is greater than 3 using greater than operator, result is "+ (2>3));
		
		//Less than(<)
		Console.WriteLine("Checking if 2 is less than 3 using less than operator, result is "+ (2<3));
		
		//Greater than or equal to (>=)
		Console.WriteLine("Checking if 2 is greater than equal to 2 , result is "+ (2>=3));
		
		//Less than or equal to (<=)
		Console.WriteLine("Checking if 2 is less than equal to 3 , result is "+ (2<=3));
		Console.WriteLine();
		
		
		//3.Logical Operators
		
		Console.WriteLine("Define x = true and y = false");
		bool x= true;
		bool y = false;
		
		
		//Logical AND (&&)
		Console.WriteLine("Applying AND operator between x and y, result is "+ (x&&y));
		
		//Logical OR (||)
		Console.WriteLine("Applying OR operator between x and y, result is "+ (x||y));
		
		//Logical NOT(!)
		Console.WriteLine("Applying NOT operator on x, result is " + (!x));
		
		//4.Assignment Operators
		//Assignment(=)
		int num = 1;
		Console.WriteLine("value 1 is assigned to variable num, num = "+num);
		
		//Addition assignment (+=)
		num +=1;
		Console.WriteLine("value 1 is added to variable num, num = "+num);
		
		//Subtraction assignment (-=)
		num -= 1;
		Console.WriteLine("value 1 is subtracted from variable num, num = "+num);
		
		//Multiplication assignment (*=)
		num *= 2;
		Console.WriteLine("value 2 is multiplied to variable num, num = "+num);
		
		//Division assignment (/=)
		num /= 2;
		Console.WriteLine("value 2 is divivded from variable num, num = "+num);
		
		//Modulus assignment (%=)
		num%=2;
		Console.WriteLine("num after modulus assignment with 2 = " + num);
		
				//5.Unary Operators
		Console.WriteLine();
		Console.WriteLine("Unary Operators");
		
		int a = 10;
		Console.WriteLine("Initial value of a = " + a);
		
		//Unary plus (+)
		Console.WriteLine("Applying unary plus on a, result is " + (+a));
		
		//Unary minus (-)
		Console.WriteLine("Applying unary minus on a, result is " + (-a));
		
		//Increment (++)
		a++;
		Console.WriteLine("Applying increment operator on a, a = " + a);
		
		//Decrement (--)
		a--;
		Console.WriteLine("Applying decrement operator on a, a = " + a);
		
		//Logical complement (!)
		bool flag = true;
		Console.WriteLine("Initial value of flag = " + flag);
		Console.WriteLine("Applying logical complement on flag, result is " + (!flag));
		Console.WriteLine();
		
		
		//6.Ternary Operator
		Console.WriteLine("Ternary Operator");
		
		int p = 20;
		int q = 30;
		
		int max = (p > q) ? p : q;
		Console.WriteLine("Using ternary operator to find greater value between p and q, result is " + max);
		Console.WriteLine();
		
		
		//7.is Operator
		Console.WriteLine("is Operator");
		
		object obj = "Hello";
		Console.WriteLine("Checking if obj is of type string, result is " + (obj is string));
		
		
	}
}
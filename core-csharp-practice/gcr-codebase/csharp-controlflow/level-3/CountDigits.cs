using System;

class CountDigits{
    static void Main(){
		
		//Taking input from user for number

        Console.WriteLine("Enter a number: ");
        int num1 = int.Parse(Console.ReadLine());

        int count = 0;

        if (num1 == 0){
            count = 1;
        }
        else{
            while (num1 != 0){
                num1 = num1 / 10; 
                count++;
            }
        }

        Console.WriteLine("Number of digits: " + count);
    }
}

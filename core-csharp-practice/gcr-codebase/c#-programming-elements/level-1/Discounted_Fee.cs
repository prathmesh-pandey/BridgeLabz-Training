public class Discounted_Fee{
	public static void Main(String[] args){
		//defining fee and discount
		int Fee = 125000, DiscountPercent = 15;
		
		//calculating discounted amount
		double DiscountedAmount = (Fee*DiscountPercent)/100;
		double FeeToPay = Fee - DiscountedAmount;
		
		//Printing the result
		Console.WriteLine("The discount amount is "+DiscountedAmount+ " and final discounted fee is "+FeeToPay );
		
		
	}

}
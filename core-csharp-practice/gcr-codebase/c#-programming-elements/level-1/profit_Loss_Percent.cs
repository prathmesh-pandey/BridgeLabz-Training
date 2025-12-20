using System;

public class profitLossPercent{
	static void Main(){
		double cost_Price = 129;
		double selling_Price = 191;
		double profit = selling_Price - cost_Price;
		double profit_Percent = (profit/cost_Price) * 100;
		Console.WriteLine("The Cost Price of the prodcut is "+cost_Price + " and the Selling Price is "+selling_Price + " The net Profit is "+profit + " and The profit percent is "+profit_Percent);
	}
}
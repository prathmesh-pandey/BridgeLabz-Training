using System;

public class Hospital
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of patients:");
        int count = Convert.ToInt32(Console.ReadLine());

        Patient[] patients = new Patient[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter patient type (1-InPatient, 2-OutPatient):");
            int type = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter patient name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (type == 1)
            {
                Console.WriteLine("Enter number of days admitted:");
                int days = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter daily charge:");
                double charge = Convert.ToDouble(Console.ReadLine());

                patients[i] = new InPatient(name, age, days, charge);
            }
            else
            {
                Console.WriteLine("Enter consultation fee:");
                double fee = Convert.ToDouble(Console.ReadLine());

                patients[i] = new OutPatient(name, age, fee);
            }
        }

        Console.WriteLine();
        Console.WriteLine("=== Patient Details & Bills ===");

        for (int i = 0; i < patients.Length; i++)
        {
            patients[i].DisplayInfo();

            if (patients[i] is IPayable)
            {
                Console.WriteLine("Bill Amount: " +
                    ((IPayable)patients[i]).CalculateBill());
            }

            Console.WriteLine();
        }
    }
}

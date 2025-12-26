using System;

public class OTPGenerator
{
    static void Main()
    {
        // Array to store 10 OTPs
        int[] otps = new int[10];


        // Generating 10 OTP numbers
        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP();
            Console.WriteLine("OTP " + (i + 1) + ": " + otps[i]);
        }


        // Check if all OTPs are unique
        if (AreOTPsUnique(otps))
            Console.WriteLine("All OTPs are unique");
        else
            Console.WriteLine("Duplicate OTPs found");
    }


    // Method to generate a 6-digit OTP number
    static int GenerateOTP()
    {
        // Math.Random() generates value between 0.0 and 1.0
        // Multiplying by 900000 and adding 100000 gives us a 6-digit otp
        return (int)(Math.Random() * 900000) + 100000;
    }

    // Method to check if all OTPs are unique
    static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                    return false;
            }
        }
        return true;
    }
}

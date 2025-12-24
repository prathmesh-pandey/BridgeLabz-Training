using System;

class VotingEligibility{
    static void Main(){
		
        int[] ages = new int[10];
		
        // Taking input from user for age
        for (int i = 0; i < ages.Length; i++){
            Console.Write($"Enter age of student {i + 1}: ");
            ages[i] = int.Parse(Console.ReadLine());
        }
		

        // Checking voting eligibility and printing result
        
        for (int i = 0; i < ages.Length; i++){
            if (ages[i] < 0){
                Console.WriteLine("Invalid age");
            }
            else if (ages[i] >= 18){
                Console.WriteLine($"The student with the age {ages[i]} can vote.");
            }
            else{
                Console.WriteLine($"The student with the age {ages[i]} cannot vote.");
            }
        }
    }
}
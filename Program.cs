using System;

namespace AgeCalculator{
    class Program{
        static void Main(string[] args){
            int userAge = 0; //variable to store user input

            try{
                //get user input
                Console.Write("Enter your age: ");
                userAge = Convert.ToInt32(Console.ReadLine());
                

                //check if the user entered a positive number
                if(userAge <= 0){
                    throw new ArgumentOutOfRangeException("Enter a positive number.");
                }


                //calculate year of birth
                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - userAge;

                Console.WriteLine($"Your birth year is: {birthYear}");

            }
            //handle error for non-numeric inputs
            catch (FormatException){
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
            //handle error where user input is 0 or negative
            catch (ArgumentOutOfRangeException ex){
                Console.WriteLine($"{ex.Message}");
            }
            //handle error for unexpected exceptions
            catch (Exception ex){
                Console.WriteLine($"An unexpected error occured: {ex.Message}");
            }

        }
    }
}
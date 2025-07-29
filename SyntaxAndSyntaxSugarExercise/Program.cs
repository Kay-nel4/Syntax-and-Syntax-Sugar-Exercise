using System.ComponentModel.Design;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*var answer = 4;
            string response;

            if (answer < 9)
            {
                response = answer + "is less than 9";
            }
            else
            {
                response = answer + "is greater than 9";
            } */
            
            //if else statement
            //with inferred typing

            var answer = 4;
            

            if (answer < 9)
            {
                Console.WriteLine($"{answer} is less than 9");
            }
            else
            {
                Console.WriteLine($"{answer} is greater than 9");
            } 
            //ternary operator
            
            Console.WriteLine(answer < 9 ? "Your answer is less than 9" : answer > 15 ?"Your answer is greater than 15": "Your answer is between 9 and 15");
            
            //string interpolation
            Console.WriteLine(answer > 9 ? $"{answer} is greater than 9"  : $"{answer} is less than 9");
            
        }
        
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
    // Using all three constructors
        Fraction defaultFraction = new Fraction();      
        Fraction wholeNumberFraction = new Fraction(5); 
        Fraction customFraction = new Fraction(3, 4);    

        // Displaying fractions and decimal values
        Console.WriteLine(defaultFraction.GetFractionString());   
        Console.WriteLine(defaultFraction.GetDecimalValue());     

        Console.WriteLine(wholeNumberFraction.GetFractionString()); 
        Console.WriteLine(wholeNumberFraction.GetDecimalValue());   

        Console.WriteLine(customFraction.GetFractionString());   
        Console.WriteLine(customFraction.GetDecimalValue());     

        // Modifying values using setters
        customFraction.SetTop(1);
        customFraction.SetBottom(3);
        Console.WriteLine(customFraction.GetFractionString());   
        Console.WriteLine(customFraction.GetDecimalValue());     
    }
}
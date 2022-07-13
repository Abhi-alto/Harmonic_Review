using Harmonic;
Console.WriteLine("Welcome to the harmonic number problem");
Console.WriteLine("Enter a positive number you have to get harmonic value of");
int num=Convert.ToInt16(Console.ReadLine());
if(num <= 0)                    //for number less than or equal to zero
{
    Console.WriteLine("Wrong input given");
}
else                        //for numbers greater than zero
{
    Harmonic_number GET = new Harmonic_number(num);             //calling the class and giving the value through constructor
    Console.WriteLine("Harmonic value for the number " + num + " is " + (GET.getHarmonic()));           //printing and calling the Harmonic value function
}
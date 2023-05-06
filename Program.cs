/*
Lag en metode som tar inn to int verdier. 

Dersom en av de, eller summen til int verdiene blir 30,
skal metoden returnere true. Ellers returnerer metoden false
*/


namespace If_else_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv inn det første tallet: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv inn det andre tallet: ");
            int number2 = int.Parse(Console.ReadLine());

            bool result = ReturnTrueIfValueIs30(number1, number2);


            if (number1 == 30)
            {
                Console.WriteLine("Resultat: " + result + "." + " Det første tallet har verdien 30.");
            }
            else if (number2 == 30)
            {
                Console.WriteLine("Resultat: " + result + "." + " Det andre tallet har verdien 30.");
            }
            else if (number1 + number2 == 30)
            {
                Console.WriteLine("Resultat: " + result + "." + " Det første tallet og det andre tallet addert har verdien 30.");
            }
            else
            {
                Console.WriteLine("Resultat: " + result + "." + " Hverken det første, det andre eller det første og andre tallet addert har verdien 30.");
            }

        }

        static bool ReturnTrueIfValueIs30(int number1, int number2)
        {
            if(number1 ==  30)
            {
                return true;
            }
            else if(number2 == 30)
            {
                return true;
            }
            else if(number1 + number2 == 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
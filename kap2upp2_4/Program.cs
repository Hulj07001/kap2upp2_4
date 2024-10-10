using System;
namespace kap2upp2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hej du har tre antsällda.");
                Console.WriteLine("Skriv in lönen för anställd person 1: ");
                string person1 = Console.ReadLine();
                int intperson1 = int.Parse(person1);
                Console.WriteLine("Skriv in lönen för anställd person 2: ");
                string person2 = Console.ReadLine();
                int intperson2 = int.Parse(person2);
                Console.WriteLine("Skriv in lönen för anställd person 3: ");
                string person3 = Console.ReadLine();
                int intperson3 = int.Parse(person3);
                int medellön = (intperson1 + intperson2 + intperson3) / 3;
                Console.WriteLine("Medellönen för dessa tre är: " + medellön + "kr.");
            }
            catch
            {
                Console.WriteLine("Skriv endast in siffror tack.");
            }
        }
    }
}
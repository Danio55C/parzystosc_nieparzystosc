using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parzystosc_nieparzystosc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdza czy podana liczba jest parzysta ");



            for (int i = 0; i < 3; i++)
            {

                ParityCheck(Validation(i));
            }

            Console.ReadKey();
        }


        private static int Validation(int input) //nie wiem czy dałoby się zrobić bardziej unwersalną walidację w tym przypadku
        {
            Console.WriteLine("\nWitam proszę podaj liczbę: ");
            bool valid = false;
            do
            {
                valid = int.TryParse(Console.ReadLine(), out input);
                if (!valid)
                    Console.WriteLine("Podano niprawidłową wartość, ponownie podaj liczbę: ");
            } while (!valid);

            return input;
        }
               
        private static void ParityCheck(int numberToCheck)
        {
            if (numberToCheck % 2 == 0)
            {
                Console.WriteLine("liczba parzysta");
            }
            else
            {
                Console.WriteLine("liczba nieparzysta");
            }

        }


    }
}
                












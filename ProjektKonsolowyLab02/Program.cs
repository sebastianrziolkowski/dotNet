using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKonsolowyLab02
{
    class Program
    {

        static void Zad01()
        {
            bool repeat;
            do
            {
                repeat = false;
                try
                {
                    Console.WriteLine("Wizytowka");
                    Console.Write("Podaj imie i nazwisko:");
                    string imieNazwisko = Console.ReadLine();
                    string pom;
                    byte poziomHumoru;
                    Console.Write("Podaj poziom humoru:");
                    pom = Console.ReadLine();
                    if (!byte.TryParse(pom, out poziomHumoru))
                    {
                        throw new Exception("Niepoprawny poziom humoru!");
                    }
                    Console.Write("Podaj wzrost:");
                    pom = Console.ReadLine();
                    byte wzrost;

                    if (!byte.TryParse(pom,out wzrost) || wzrost < 73 || wzrost > 251)
                    {
                       throw new Exception("Niepoprawny wzrost!");
                   }
                    Console.WriteLine("Imie i Naziwsko: {0}", imieNazwisko);
                    Console.WriteLine("Poziom humoru: {0}", poziomHumoru);
                    Console.WriteLine("Wzrost: {0}", wzrost);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Blad wczytywania: {0}", e.Message);
                    repeat = true;
                } 
            } while (repeat);
        }

        static long Silnia(byte argument)
        {
            long result = 1;
            try
            {

                for (int i = argument; i > 1; i--)
                    result = checked(result * i);
            }
            catch (Exception e)
            {

                throw new Exception("Result out of range!");
            }

            return result;
        }

        static void Zad02()
        {
            try
            {
                Console.Write("Write number to factorial:");
                string silnia_ = Console.ReadLine();
                byte silniaByte;

                if (!byte.TryParse(silnia_, out silniaByte) || silniaByte < 0)
                {
                    throw new Exception("Parameter out of range!");
                }

                Console.WriteLine("Result: {0}", Silnia(silniaByte));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
        }

        static void Main(string[] args)
        {
            //Zad01();

            do
            {
                Zad02(); 
            } while (true);
            Console.ReadKey();
        }
    }
}

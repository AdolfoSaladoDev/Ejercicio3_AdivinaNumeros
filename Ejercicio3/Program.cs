using System;

namespace Ejercicio3
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            int attempts = 4;
            Random random = new Random();
            int randomNumber = random.Next(0, 101);
            bool isCorrect = false;

            Console.WriteLine("¡Bienvenid@ a ADIVINA EL NÚMERO!");
            Console.WriteLine("Tiene 4 intentos para acertar el número entre 0 y 100.");
            Console.WriteLine("Yo le indicaré si es mayor o menor.");
            Console.WriteLine("¿Está prepad@?");

            while (attempts > 0 && !isCorrect)
            {

                Console.WriteLine($"\nTiene {attempts} intentos.");

             
                bool isNumber = false;

                while (!isNumber)
                {

                    Console.Write("\nIntroduzca un número: ");
                    string numberUserString = Console.ReadLine();
                    int numberUser;

                    isNumber = int.TryParse(numberUserString, out numberUser);

                    if (isNumber)
                    {
                        if (numberUser >= 0 && numberUser <= 100)
                        {
                            if (numberUser == randomNumber)
                            {
                                isCorrect = true;
                            }
                            else
                            {
                                Console.WriteLine("No ha acertado.");

                                if (randomNumber > numberUser)
                                {
                                    Console.WriteLine($"El número es mayor que {numberUser}");
                                }
                                else if (randomNumber < numberUser)
                                {
                                    Console.WriteLine($"El número es menor que {numberUser}");
                                }

                                attempts--;
                            }

                            isNumber = true;
                        }
                        else
                        {
                            Console.WriteLine("No ha introducido un número entre 0 y 100. Vuelva a intentarlo");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No ha introducido un número. Vuelva a intentarlo.");
                    }
                }
            }

            if (attempts == 0)
            {
                Console.WriteLine("¡Lo sentimos, pero, no ha acertado el número!");
                Console.WriteLine($"La respuesta era {randomNumber}");
            } else if (isCorrect)
            {
                Console.WriteLine("¡Enhorabuena! Ha acertado el número.");
            }
        }
    }
}
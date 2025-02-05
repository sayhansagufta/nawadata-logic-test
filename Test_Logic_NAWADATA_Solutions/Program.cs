using System;

namespace Test_Logic_NAWADATA_Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "Y";

            while (answer.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    DisplayMenu();
                    int iTest = int.Parse(Console.ReadLine());

                    switch (iTest)
                    {
                        case 1:
                            SortCharacter.Run();
                            break;
                        case 2:
                            PSBB.Run();
                            break;
                        default:
                            Console.WriteLine("Test is not available. Please select a valid test number.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine("\nContinue? (y/n)");
                answer = Console.ReadLine();
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Please enter test number:");
            Console.WriteLine("1. Sorting Numbers");
            Console.WriteLine("2. PSBB (Pembatasan Sosial Berskala Besar)");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
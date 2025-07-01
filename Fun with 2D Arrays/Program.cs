using System;

namespace Simple_2D_Grid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with 2D Arrays!");

            Console.WriteLine("Choose an option:");
            Console.WriteLine("1 - Grid with border markings");
            Console.WriteLine("2 - Grid with random numbers (0–9)");
            Console.WriteLine("3 - Grid with '#' randomly or ' ' centrally filled");
            Console.WriteLine("4 - Grid with indices of rows & columns");

            string option = Console.ReadLine();

            // Ask user for number of rows (make out integer out of the text..)
            Console.Write("How many rows shall the grid have? ");
            string row = Console.ReadLine();           // Read input as text (e.g. "5")
            int rows = int.Parse(row);                 // Convert the text to a number

            // Ask user for number of columns
            Console.Write("How many columns shall the grid have? ");
            string column = Console.ReadLine();        // Read input as text (e.g. "8")
            int columns = int.Parse(column);           // Convert the text to a number

            char[,] grid = new char[rows, columns];
            Random rand = new Random();

            // Option 1 (border markings)
            if (option == "1")
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (i == 0 || i == rows - 1 || j == 0 || j == columns - 1)
                        {
                            grid[i, j] = '*';
                        }
                        else
                        {
                            grid[i, j] = '#';
                        }
                    }
                }
            }

            // Option 2 (random numbers)
            if (option == "2")
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        int num = rand.Next(0, 10);
                        grid[i, j] = (char)('0' + num);
                    }
                }
            }

            // Option 3 (Random: # or ' ')
            if (option == "3")
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        grid[i, j] = rand.Next(2) == 0 ? '#' : ' ';
                    }
                }
            }

            // Option 4 (indicating rows and coluns)
            if (option == "4")
            {                
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        grid[i, j] = ' ';
                    }
                }

                Console.WriteLine("\nGrid pattern with indices:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"[{i},{j}] ");
                    }
                    Console.WriteLine();
                }

                return; // end of program
            }

            // Eliminate wrong selection
            if (option != "1" && option != "2" && option != "3" && option != "4")
            {
                Console.WriteLine("Invalid option selected. Program will exit.");
                return;
            }

            // Output of the grid for options 1–3
            Console.WriteLine("\nGrid pattern:");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("|");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{grid[i, j]}|");
                }
                Console.WriteLine();
            }
        }
    }
}
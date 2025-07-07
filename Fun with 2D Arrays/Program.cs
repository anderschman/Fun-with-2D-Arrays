using System;

namespace Simple_2D_Grid
{
    internal class Program
    {
        // Nur diese Konstanten bleiben zur Vermeidung von Magic Strings
        const string OPTION_BOARDER = "1";
        const string OPTION_RANDOM_NUMBERS = "2";
        const string OPTION_RANDOM_FILL = "3";
        const string OPTION_INDICES = "4";

        static void Main(string[] args)
        {
            Console.WriteLine("Fun with 2D Arrays!");

            Console.WriteLine("Choose an option:");
            Console.WriteLine($"{OPTION_BOARDER} - Grid with border markings");
            Console.WriteLine($"{OPTION_RANDOM_NUMBERS} - Grid with random numbers (0–9)");
            Console.WriteLine($"{OPTION_RANDOM_FILL} - Grid with '#' randomly or ' ' centrally filled");
            Console.WriteLine($"{OPTION_INDICES} - Grid with indices of rows & columns");

            string option = Console.ReadLine();

            // Ask user for number of rows
            Console.Write("How many rows shall the grid have? ");
            string row = Console.ReadLine();
            int rows = int.Parse(row);

            // Ask user for number of columns
            Console.Write("How many columns shall the grid have? ");
            string column = Console.ReadLine();
            int columns = int.Parse(column);

            char[,] grid = new char[rows, columns];
            Random rand = new Random();

            // Option 1 (border markings)
            if (option == OPTION_BOARDER)
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
            else if (option == OPTION_RANDOM_NUMBERS)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        int num = rand.Next(0, 10); // 0–9
                        grid[i, j] = (char)('0' + num);
                    }
                }
            }
            // Option 3 (Random: # or ' ')
            else if (option == OPTION_RANDOM_FILL)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        grid[i, j] = rand.Next(2) == 0 ? '#' : ' ';
                    }
                }
            }
            // Option 4 (indicating rows and columns)
            else if (option == OPTION_INDICES)
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

                return;
            }
            else
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
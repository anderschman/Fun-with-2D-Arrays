namespace Fun_with_2D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fun with 2D Arrays
            Console.WriteLine("Fun with 2D Arrays");

            //User enters number of lines
            Console.WriteLine("How many rows shall the grid have?");
            int rows = int.Parse(Console.ReadLine());

            //User enters number of columns
            Console.WriteLine("How many columns shall the grid have?");
            int columns = int.Parse(Console.ReadLine());

            //Create 2D Array (with numbers)
            int[,] Array2D = new int[rows, columns];

            //Fill grid
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Array2D[i, j] = rand.Next(0, 100); // Fill with random numbers between 0 and 99
                    }
                    else
                    {
                        Array2D[i, j] = 0;
                    }
                }
            }
            // Edit grid
            Console.WriteLine("\nGrid pattern:");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("|");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(Array2D[i, j] + "|");
                }
                if (i < rows - 1)
                {
                    Console.WriteLine("\n" + new string('-', (columns * 2) + 5)); // Print separator line
                }
            }
        }
    }
}

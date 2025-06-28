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
            char[,] Array2D = new char[rows, columns];

            //Fill grid
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Array2D[i, j] = (i + j) % 4 == 0 ? '#' : ' '; // modulo-operator for occupancy number (even, odd, odd, odd)
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
                Console.WriteLine(); // Move to the next line after printing a row
            }
        }
    }
}

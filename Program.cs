using System;
class Program
{
    static void Main()
    {
        int rowNumber = ReadRowNumber();
        Console.WriteLine("Pascal's Triangle:");

        for (int i = 0; i <= rowNumber; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(CalculatePascalValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }
    static int ReadRowNumber()
    {
        Console.Write("Enter the Pascal's triangle row number: ");
        int rowNumber;

        while (!int.TryParse(Console.ReadLine(), out rowNumber) || rowNumber < 0)
        {
            Console.WriteLine("Invalid Pascal's triangle row number.");
            Console.Write("Enter the Pascal's triangle row number again: ");
        }

        return rowNumber;
    }
    static int CalculatePascalValue(int row, int column)
    {
        if (column == 0 || column == row)
        {
            return 1;
        }

        return CalculatePascalValue(row - 1, column - 1) + CalculatePascalValue(row - 1, column);
    }
}
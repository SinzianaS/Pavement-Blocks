using System;

namespace pavementBlocks
{

    class Program

    {
        static void Main(string[] args)

        {
            decimal marketSquareM = Convert.ToDecimal(Console.ReadLine());
            decimal marketSquareN = Convert.ToDecimal(Console.ReadLine());
            decimal marketBlocksA = Convert.ToDecimal(Console.ReadLine());
            decimal ariaDreptunghiului = Math.Ceiling(marketSquareM / marketBlocksA) * Math.Ceiling(marketSquareN / marketBlocksA);
            decimal v = Math.Ceiling(ariaDreptunghiului);
            Console.WriteLine(v);
            Console.Read();


        }

    }
}
    


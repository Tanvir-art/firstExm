using System;

namespace thirdProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            //Console.WriteLine("Enter the 2 dimensional array size:");
            int[,] arrayName= new int[4,4];
            for ( i = 0; i < 4; i++)
            {
                for ( j = 0; j < 4; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arrayName[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < 4; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 4; j++)
                    Console.Write(format: "{0}\t", arg0: arrayName[i, j]);
            }
            Console.Write("\n\n");
            //int sum1=arrayName[0,0]+arrayName[1,2]+
            Console.WriteLine(arrayName[0, 0] + arrayName[1, 1] + arrayName[2,2] + arrayName[3,3] );
            Console.WriteLine(arrayName[0,3] + arrayName[1, 2] + arrayName[2, 1] + arrayName[3, 0]);
        }
    }
}

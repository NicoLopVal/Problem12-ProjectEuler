using System;

namespace Problem12_ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            //          NOTE: THIS ONE TOOK A LOT OF TIME TO FIND THE ANSWER!
            double triangleNumber = 1;
            double counter = 2;
            double divisors = 0;

            while (true)
            {
                triangleNumber = triangleNumber + counter;

                if(triangleNumber > 11000000)
                {
                    for(int i = 1; i <= triangleNumber; i++)
                    {
                        if (triangleNumber % i == 0)
                            divisors++;
                    }
                }

                if (divisors >= 500)
                    break;

                counter++;
                divisors = 0;
            }

            Console.WriteLine("The first triangle number with over 500 divisors is: " + triangleNumber);


        }
    }
}

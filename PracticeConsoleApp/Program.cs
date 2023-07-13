using System;

namespace PracticeConsoleApp
{
    class Program
    {
       
            static public int Solution(string S)
            {
                int upCount = 0;
                int downCount = 0;
                int leftCount = 0;
                int rightCount = 0;

                foreach (char arrow in S)
                {
                    switch (arrow)
                    {
                        case '^':
                            upCount++;
                            break;
                        case 'v':
                            downCount++;
                            break;
                        case '<':
                            leftCount++;
                            break;
                        case '>':
                            rightCount++;
                            break;
                    }
                }

                int maxCount = Math.Max(Math.Max(upCount, downCount), Math.Max(leftCount, rightCount));
                int minRotations = S.Length - maxCount;

                return minRotations;
            }
        

        static void Main(string[] args)
        {
            Console.WriteLine( Solution("<<<<^^"));
           
        }
    }
}

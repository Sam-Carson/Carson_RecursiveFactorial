/*****************************************************
 *      Course: PROG 260
 *      
 *      Instructor: Dennis Minium
 *      
 *      Term: Fall 2020
 *      
 *      Programmer: Sam Carson
 *      
 *      Assignment: Recurrsion
 *      
 *      Descriptoin: 
 *      The program demonstrates the use of factorial recurrsion. 
 *      
 *      Revision    Date        Release Comment
 *      ---------------------------------------
 *      1.0         11-02-20    Final Submission
 *      
 *      
 *      Big O Notation: O(log n)
 *      
 */

using static System.Console;

namespace Carson_RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            long result;
            long count = 0;
            int j = 1;
            string userInput;

            do
            {
                result = Recursion(count);
                Write($"{count}! = {result:N0}.");
                Write($"\tTo continue with {j}! type anything but 'N'.");
                j++;
                count++;
                userInput = ReadLine().ToUpper();
            } while (userInput != "N");
        }



        public static long Recursion(long s)
        {
            if (s <= 1) return 1;
            else
            {
                return s * Recursion(s - 1);
            }
        }
    }
}

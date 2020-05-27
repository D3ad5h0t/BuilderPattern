using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JumpingNumber(98789876));
            Console.WriteLine(JumpingNumber(00000079));
        }
        
        public static string JumpingNumber(int number)
        {
            bool isJumpingNumber = true;
            int[] array = number.ToString().Select(num => Convert.ToInt32(num)).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (i + 1 < array.Length && (array[i] + 1 != array[i + 1] && array[i] - 1 != array[i + 1]))
                {
                    isJumpingNumber = false;
                }
            }

            return isJumpingNumber ? "Jumping!!" : "Not!!";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assigment1
{
    /// <summary>
    /// Class that keep track about info of a player such as gold or points.
    /// </summary>
    class Program
    {
        /// <summary>
        /// mehtod that read gold and score and printed to the user.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            int gold = 0;
            float time = 0;
            int minutePlayed = 0;
            const int HOUR_TO_MINUTE = 60;

            Console.WriteLine("Welcome, This is just testing");
            Console.WriteLine();
            
            Console.Write("Enter gold: ");
            gold = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Console.Write("Enter total hours played:");
            time = float.Parse(Console.ReadLine());
            int hourToMinute = (int)time;
            //calcule minutes from hours
            float temp = (time - hourToMinute) * 100;
            int minutes = (hourToMinute * HOUR_TO_MINUTE) + Convert.ToInt32(temp);
       
            Console.Write("\nTotal gold for minute: ");
            float goldForMinute = (float) gold/minutes;

            Console.WriteLine(goldForMinute);
        }
    }
}

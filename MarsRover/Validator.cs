using System;

namespace MarsRover
{
    public class Validator {
        public static bool ValidateLoactionLength(int length)
        {
            if(length != 3)
            {
                Console.WriteLine("Invalid Input");
                return true;
            }
            return false;
        }
    }
}

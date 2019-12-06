using System;
using static MarsRover.Rover;

namespace MarsRover
{
    public class Validator {
        
        public static bool ValidateLoactionLength(string[] location)
        {
            if(location.Length == 3 && Enum.IsDefined(typeof(Directions), location[2]))
            {
                return true;
            }
            return false;
        }
        public static bool ValidateMoves(string moves)
        {
            foreach(var move in moves)
            {
                switch(move)
                {
                    case 'M':
                    case 'L':
                    case 'R':
                        break;
                    default:
                        return false;
                }
            }
            return true;
        }
        public static void DisplayInvalidInputMessage()
        {
            Console.WriteLine("Inavlid Input");
            Console.ReadLine();
        }

    }
}

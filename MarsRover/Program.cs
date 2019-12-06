using System;
using static MarsRover.Rover;

namespace MarsRover
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var rover = new Rover();
            Console.WriteLine("Enter the initial position of the Rover in the form X ,Y ,D ");
            var initialLocation = Console.ReadLine().Trim().ToUpper();
            string[] location = initialLocation.Split(',');
            if (location.Length == 3)
            {
                rover.X = Int32.Parse(location[0]);
                rover.Y = Int32.Parse(location[1]);
                rover.direction = (Directions)Enum.Parse(typeof(Directions), location[2]);
            }
            Console.WriteLine("Enter the moves of the Rover");
            var moves = Console.ReadLine().Trim().ToUpper();
            rover.Move(moves);
            Console.ReadLine();
        }
    }
}

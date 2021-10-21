using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ibocan
{
    class Program
    {
        static Area getAreaFromInput(string str)
        {
            

            string[] split_input = str.Split(' ');

            Area a = new Area(Convert.ToInt32(split_input[0]), Convert.ToInt32(split_input[1]));

            return a;
        }


        static Rover getRoverFromInput(string str)
        {
            

            string[] split_input = str.Split(' ');

            Direction d = (Direction)Convert.ToChar(split_input[2]);
            Position pos = new Position(Convert.ToInt32(split_input[0]), Convert.ToInt32(split_input[1]), d);
            
            Rover rover = new Rover(pos);

            return rover;
        }
        static void Main(string[] args)
        {


            List<Rover> roverList = new List<Rover>();
            string input_area = Console.ReadLine();
            Area area = getAreaFromInput(input_area);
            Rover adding_rover;
            string commandList = "";
            

            string rover_string = "";
            do
            {
                rover_string=Console.ReadLine();
                 
                if(rover_string.Length == 0)
                {
                    break;
                }
                adding_rover = getRoverFromInput(rover_string);

                commandList = Console.ReadLine();
                
                adding_rover.setCommandList(commandList);
                roverList.Add(adding_rover);
               
            } while (true);

            

            foreach (var rover in roverList)
            {
                Console.WriteLine(rover.startCommand().ToString());
            }
            
            Console.ReadKey();
            
        }
    }
}

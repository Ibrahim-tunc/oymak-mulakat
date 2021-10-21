using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibocan
{
    class Rover
    {
        public Position position { get; set; }
        private Position finishPosition;

        public string Command { get; set; }

        private bool isCommandSet;
        public Rover(int x,int y, Direction direction)
        {
            position = new Position(x, y, direction);
            isCommandSet = false;
        }

        public Rover(Position position)
        {
            this.position = position;
            isCommandSet = false;
        }
        

        public void setCommandList(string command)
        {
            this.Command = command;
            isCommandSet = true;
        }

        public Position startCommand()
        {

            
            if (isCommandSet != true)
            {
                finishPosition = position;
            }
            else
            {
                for (int i = 0; i < Command.Length; i++)
                {
                    if (Command[i] == 'M')
                    {
                        changePos();
                    }
                    else if (Command[i] == 'L')
                    {
                        ChangeDir('L');
                    }
                    else if (Command[i] == 'R')
                    {
                        ChangeDir('R');
                    }
                    else
                    {

                    }

                }
                finishPosition = position;
            }
            

            return finishPosition;
        }


        private void ChangeDir(char dir)
        {
            if(dir == 'L')
            {
                switch (this.position.direction)
                {
                    case Direction.E:
                        position.direction = Direction.N;
                        break;
                    case Direction.W:
                        position.direction = Direction.S;
                        break;
                    case Direction.N:
                        position.direction = Direction.W;
                        break;
                    case Direction.S:
                        position.direction = Direction.E;
                        break;
                    default:
                        break;
                }
            }
            else // dir = 'R'
            {
                switch (position.direction)
                {   
                    case Direction.E:
                        position.direction = Direction.S;
                        break;
                    case Direction.W:
                        position.direction = Direction.N;
                        break;
                    case Direction.N:
                        position.direction = Direction.E;
                        break;
                    case Direction.S:
                        position.direction = Direction.W;
                        break;
                    default:
                        break;
                }
            }
        }

        private void changePos()
        {
            switch (position.direction)
            {
                case Direction.E:
                    position.x += 1; 
                    break;
                case Direction.W:
                    position.x -= 1;
                    break;
                case Direction.N:
                    position.y += 1;
                    break;
                case Direction.S:
                    position.y -= 1;
                    break;
                default:
                    break;
            }
        }


    }
}

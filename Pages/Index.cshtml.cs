using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MarsRover.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int id { get; set; }

        [BindProperty]
        public int X { get; set; }

        [BindProperty]
        public int Y { get; set; }

        [BindProperty]
        public char Direction { get; set; }

        [BindProperty]
        public string Movements { get; set; }

        [BindProperty]
        public static string Output1 { get; set; }

        [BindProperty]
        public static string Output2 { get; set; }

        //int X, int Y, char Direction, string Movements
        public void OnPost()
        {
            string strOutput = MoveRover(X, Y, Direction, Movements);

            string MoveRover(int xStart, int yStart, char dStart, string MoveMR)
            {
                char Direction = dStart;
                //C# should begin counting from 1, but I digress
                int[] XY = new int[2];
                XY[0] = xStart;
                XY[1] = yStart;
                int ActionCount = MoveMR.Length;

                //Perform movement actions with two helper functions
                for (var i = 0; i < ActionCount; i++)
                {
                    char Command = MoveMR[i];

                    if (Command == 'M')
                    {
                        XY = DoMovement(Direction, XY);
                    }
                    else
                    {
                        Direction = ChangeDirection(Direction, Command);
                    }
                }

                //Declare output string and return it to in-line C# using Razor;
                string strOutput = "X=" + XY[0].ToString() + " ,Y=" + XY[1].ToString() + ", D=" + Direction;
                return strOutput;
            }

            char ChangeDirection(char OldDirection, char LR)
            {
                char NewDirection = '\0';

                switch (OldDirection)
                {
                    case 'N':
                        if (LR == 'L')
                        {
                            NewDirection = 'W';
                        }
                        if (LR == 'R')
                        {
                            NewDirection = 'E';
                        }
                        break;
                    case 'E':
                        if (LR == 'L')
                        {
                            NewDirection = 'N';
                        }
                        if (LR == 'R')
                        {
                            NewDirection = 'S';
                        }
                        break;
                    case 'S':
                        if (LR == 'L')
                        {
                            NewDirection = 'E';
                        }
                        if (LR == 'R')
                        {
                            NewDirection = 'W';
                        }
                        break;
                    case 'W':
                        if (LR == 'L')
                        {
                            NewDirection = 'S';
                        }
                        if (LR == 'R')
                        {
                            NewDirection = 'N';
                        }
                        break;
                }

                return NewDirection;
            }

            int[] DoMovement(char Direction, int[] xy)
            {
                switch (Direction)
                {
                    case 'N':
                        xy[1] += 1;
                        break;
                    case 'E':
                        xy[0] += 1;
                        break;
                    case 'S':
                        xy[1] -= 1;
                        break;
                    case 'W':
                        xy[0] -= 1;
                        break;

                }
                return xy;
            }

            if (id==1)
            {
                Output1 = strOutput;
            } else
            {
                Output2 = strOutput;
            }
            
        }
    }
}
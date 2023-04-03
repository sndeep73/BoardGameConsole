using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Game
{
    public class Play_Board_Game
    {
        string[,] boardarr = new string[5, 5];
        
        int rownum = 0;
        int colnum = 0;
        char currdir = 'L';
        char direction = 'N';
        char changedirection;
        public string output;

        public string CreateBoard(string input)
        {
            //Create a board with X initially
            char[] inputchar = input.ToCharArray();
            //Loop 2 D array
            for (int i = boardarr.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < boardarr.GetLength(1); j++)
                {
                    boardarr[i, j] = " X ";

                }
            }
            UpdateBoard(boardarr, input);
            return output;
            
        }
        //Update board based on the input.
        public void UpdateBoard(string[,] Updarr, string ip)
        {
           //Loop each character of the input
            for(int x = 0; x <= ip.Length - 1; x++)
            {
                //if char is L
                if (ip[x] == 'L')
                {
                    //update array with X and directions of the board movement
                    Updarr[colnum, rownum] = " X ";
                    currdir = 'L';
                    direction = GetDirection(direction, 'L');

                }
                //if char is R update array with X and directions of the board movement
                else if (ip[x] == 'R')
                {
                    Updarr[colnum, rownum] = " X ";
                    currdir = 'R';
                    direction = GetDirection(direction, 'R');
                }
                //if char is M and previous movement is R
                else if (ip[x] == 'M' && currdir=='R')
                {
                    Updarr[colnum, rownum] = " - ";
                    if (x <= ip.Length) rownum++;
                }
                //if char is M and previous movement is L
                else if (ip[x] == 'M' && currdir == 'L')
                {
                    Updarr[colnum, rownum] = " | ";
                    if(x<=ip.Length)colnum++;
                }
            }
            //Display result in console
            for(int i = Updarr.GetLength(0) - 1; i >= 0; i--)
            {
                for(int j = 0; j < Updarr.GetLength(1); j++)
                {
                    Console.Write(Updarr[i, j]);
                }
                Console.WriteLine();
            }
            if (rownum > 5) rownum = 4;
            if (colnum >= 5) colnum = 4;
            //Set output
            output = rownum.ToString() + System.Convert.ToInt16(colnum) + direction;
            Console.WriteLine("Output" + rownum + System.Convert.ToInt16(colnum) + direction);
        }

        //Gets the direction of the board for output
        public char GetDirection(char direction, char Changingdir)
        {
            //based on movement you can set directions
            char resdirection = direction;
            if (direction == 'N' && Changingdir == 'R') resdirection = 'E';
            else if(direction == 'N' && Changingdir == 'L') resdirection = 'W';
            else if (direction == 'E' && Changingdir == 'L') resdirection = 'N';
            else if (direction == 'E' && Changingdir == 'R') resdirection = 'S';
            else if (direction == 'W' && Changingdir == 'L') resdirection = 'S';
            else if (direction == 'W' && Changingdir == 'R') resdirection = 'N';
            else if (direction == 'S' && Changingdir == 'L') resdirection = 'E';
            else if (direction == 'S' && Changingdir == 'R') resdirection = 'W';

            return resdirection;
        }
    }
}

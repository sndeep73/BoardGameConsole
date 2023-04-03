# BoardGameConsole

Its a console game below are the snippets and output results of Game and unit test.
![image](https://user-images.githubusercontent.com/35574314/229579546-308a2e63-e1a3-47f1-b5da-d92325ab5c97.png)

![image](https://user-images.githubusercontent.com/35574314/229578939-8ecdb3dd-417e-4c2c-a0dd-8819645eaca8.png)

![image](https://user-images.githubusercontent.com/35574314/229578711-a6a6cb63-e81a-465f-bc96-da653961898a.png)



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

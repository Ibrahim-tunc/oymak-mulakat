using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibocan
{
    class Area
    {
        public int rows { get; set; }
        public int cols { get; set; }

        public int[,] grid { get; set; }

        public Area(int rows,int cols)
        {
            this.rows = rows;
            this.cols = cols;

            grid = new int[rows, cols];

        }

        public void InverseTranspose()
        {

        }

        public void show()
        {
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

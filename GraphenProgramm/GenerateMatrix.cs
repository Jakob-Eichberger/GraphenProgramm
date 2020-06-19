using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafenProgramm
{
    class GenerateMatrix
    {
        int[,] matrix;
        public GenerateMatrix(int size, Boolean zusammenhaengend, Boolean artikualtion)
        {   
            matrix = new int[size, size];
            int result;
            Random r = new Random();
            for (int y = 0; y < size; y++)
            {
                for (int x = y; x < size; x++)
                {
                    if (x == y)
                    {
                        matrix[y, x] = 0;
                    }
                    else
                    {
                        result = r.Next(0, 2);
                        matrix[y, x] = result;
                        matrix[x, y] = result;
                    }

                }

            }

        }


    }
}

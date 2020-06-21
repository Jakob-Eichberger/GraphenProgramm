using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafenProgramm
{
    class GenerateMatrix
    {


        int[,] matrix;
        public GenerateMatrix()
        {


        }

        public int[,] generateMatrix(int size, Boolean zusammenhaengend, Boolean artikualtion, Boolean enable)
        {
            MatrixClass mtrx = new MatrixClass();

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

            if (enable)
            {
                mtrx.AmmountNode = size;
                mtrx.Matrix = matrix;
                ArrayList abc = mtrx.artikulationen(matrix);
                Boolean b = mtrx.zusammenhaengend;
                int matrixok = 0;
                if (artikualtion && abc.Count > 0)
                {
                    matrixok++;
                }
                if (!artikualtion && abc.Count == 0)
                {
                    matrixok++;
                }
                if (zusammenhaengend && b)
                {
                    matrixok++;
                }
                if (!zusammenhaengend && !b)
                {
                    matrixok++;
                }

                //MessageBox.Show($"matrixok value (should be2): {matrixok.ToString()}\nartikualtion:{artikualtion} __ {abc.Count}\n zusammen{zusammenhaengend} __ {b}");
                if (matrixok != 2)
                {
                    generateMatrix(size, zusammenhaengend, artikualtion, enable);
                }

            }

            return matrix;
        }



    }
}

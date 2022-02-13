/*
ToDo: 
check if Matrix is ok                           <- toDo
Matrix Multiplikation                           <-  implemented           QA ok
Bestimmung der Distanzen aller Knoten           2D <-  implemented    QA ok
Bestimmung der  Exzentrizitaet aller Knoten     2D<-  implemented (not yet displayed)    QA ok   info: Die Exzentrizitäten können aus den Zeilen der Matrix ermittelt werden
Radius,                                         2d<-  implemented     QA ok    
Durchmesser,                                    2d<-  implemented     QA ok    
Zentrum                                         <-  implemented       QA ok          
Artikulationen,                                 <-  implemented     QA ok 
Bruecken                                        <-  implemented     QA ok
Komponenten                                     <-  implemented     QA ok
WegMatrix                                       <-  implemented     QA ok
*/
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Windows.Forms.VisualStyles;

namespace GrafenProgramm
{
    public class Graph
    {
        public int[,] matrix;

        public bool readOk = false;

        public bool zusammenhaengend;

        int ammountNode = 0;

        public Graph()
        {
        }

        public int AmmountNode
        {
            get { return ammountNode; }
            set { ammountNode = value; }
        }

        /// <summary>
        /// used to get the full matrix;
        /// </summary>
        public int[,] Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        public bool ReadOk
        {
            get { return readOk; }
            set { readOk = value; }
        }

        public bool ZusammenHaengend
        {
            get { return zusammenhaengend; }
        }

        public static int[,] Generat(int size)
        {
            int[,] matrix = new int[size, size];
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
            return matrix;
        }
        /// <summary>
        /// bekommt AD übergeben
        /// </summary>
        /// <param name="art_matrix"></param>
        /// <returns></returns>
        public ArrayList Artikulationen(int[,] art_matrix)
        {
            ArrayList artiku = new ArrayList();
            int kompanz = Komponenten(WegMatrix(art_matrix)).Count;

            for (int x = 0; x < ammountNode; x++)
            {
                int[,] temporary = CopieMatrix(art_matrix);

                int temp = 0;
                for (int y = 0; y < ammountNode; y++)
                {
                    //zähle alle Kanten bro x
                    if (temporary[y, x] == 1 && y != x)
                    {
                        temp++;
                    }
                }
                //artikulations dont have the  value 0 or 1
                if (temp > 1)
                {
                    for (int n = 0; n < ammountNode; n++)
                    {
                        temporary[x, n] = 0;
                        temporary[n, x] = 0;
                    }
                    Boolean zus = Zusammenhaengend(temporary, x);
                    if (!zus)
                    {
                        ArrayList i = Komponenten(WegMatrix(temporary));
                        //i.Count-1 da wenn ich einen Knoten "lösche" er als eigene Kompoenten erkannt wirt
                        if ((i.Count - 1) > kompanz)
                        {
                            artiku.Add($"{x + 1}");
                        }
                    }
                }
            }
            return artiku;
        }

        /// <summary>
        /// bekommt normale matrix -> in matrix werden felder geändert -> dann wegmatrix -> dann komponente
        /// </summary>
        /// <param name="bru_matrix"></param>
        /// <returns></returns>
        public ArrayList Bruecken(int[,] bru_matrix)
        {
            ArrayList komp = Komponenten(WegMatrix(bru_matrix));
            ArrayList bruecken = new ArrayList();
            for (int x = 0; x < ammountNode - 1; x++)
            {
                for (int y = x + 1; y < ammountNode; y++)
                {
                    if (bru_matrix[y, x] == 1)
                    {
                        bru_matrix[y, x] = 0;
                        bru_matrix[x, y] = 0;
                        ArrayList komptemp = Komponenten(WegMatrix(bru_matrix));
                        if (komptemp.Count > komp.Count)
                        {
                            bruecken.Add($"[{x + 1},{y + 1}] ");
                        }
                        bru_matrix[y, x] = 1;
                        bru_matrix[x, y] = 1;
                    }
                }
            }
            return bruecken;
        }

        /// <summary>
        /// if value x is found true is returned - Function does not check diagonal lines for x 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="checkValue"></param>
        /// <param name="excludeXY"></param>
        /// <returns></returns>
        public Boolean CheckForValueNoneDiagonal(int[,] b, int checkValue, int excludeXY)
        {
            try
            {
                for (int x = 0; x < ammountNode; x++)
                {
                    for (int y = 0; y < ammountNode; y++)
                    {
                        if (x != excludeXY)
                        {
                            if (y != excludeXY)
                            {
                                if (x != y && b[y, x] == checkValue)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Array is not same as default");
            }
            return false;
        }

        /// <summary>
        /// function shows all distanzes from every vertex to every other vertex - returns int[,]
        /// </summary>
        /// <param name="givenmatrix"></param>
        /// <returns></returns>
        public int[,] Distanz(int[,] givenmatrix)
        {
            int[,] dMatrix = CopieMatrix(givenmatrix);
            int[,] multiMatrix = CopieMatrix(givenmatrix);
            dMatrix = ReplaceValueNoneDiagonal(dMatrix, 0, -1);
            for (int b = 2; b < dMatrix.Length; b++)
            {
                multiMatrix = Multiply(multiMatrix, givenmatrix);
                int y = 0;
                int x = 0;
                for (int i = 0; i < dMatrix.Length; i++, x++)
                {
                    if (x == ammountNode)
                    {
                        y++;
                        x = 0;
                    }
                    if (y == ammountNode)
                        i = dMatrix.Length;
                    if (dMatrix[y, x] == -1 && multiMatrix[y, x] != 0)
                    {
                        dMatrix[y, x] = b;
                    }
                }
            }
            return dMatrix;
        }

        /// <summary>
        /// returns int - durchmesser - -1 wird returned wenn der graphen nicht zsammenhängend ist.
        /// </summary>
        /// <returns></returns>
        public int Durchmesser()
        {
            try
            {
                if (!zusammenhaengend)
                {
                    return -1;
                }
                int[] exz = Exzentrizitaeten();
                int durchmesser = exz.Max();
                return durchmesser;
            }
            catch (InvalidOperationException)
            {
                return -1;
            }
        }

        /// <summary>
        /// liefert 1d array zurück in der länge von ammountNode ... und jeder Eintrag ist == zu jeder y Koordinate
        /// </summary>
        /// <returns></returns>
        public int[] Exzentrizitaeten()
        {
            int[] eMatrix = new int[ammountNode];
            if (!zusammenhaengend)
            {
                for (int i = 0; i < ammountNode; i++)
                {
                    eMatrix[i] = -1;
                }
                return eMatrix;
            }
            int[,] dMatrix = Distanz(matrix);
            int highestValue = 0;

            for (int y = 0; y < ammountNode; y++)
            {
                highestValue = 0;
                for (int x = 0; x < ammountNode; x++)
                {
                    if (dMatrix[y, x] >= highestValue)
                    {
                        highestValue = dMatrix[y, x];
                    }
                }
                eMatrix[y] = highestValue;
            }
            return eMatrix;
        }

        /// <summary>
        /// return AD + Exzentrizitäten als string
        /// </summary>
        /// <returns></returns>
        public string ExzentrizitaetenString()
        {
            int[,] tempaxa = CopieMatrix(matrix);
            int[] exz = Exzentrizitaeten();
            string temp = "";
            for (int y = 0; y < ammountNode; y++)
            {

                temp += "  ";
                for (int x = 0; x < ammountNode; x++)
                {
                    temp += $"{tempaxa[y, x]}    ";
                }
                temp += $"|  {exz[y]}\n";
            }
            return temp;
        }

        /// <summary>
        /// get file path
        /// </summary>
        /// <returns></returns>
        public string FileSelector()
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a csv file",
                Filter = "csv files (*.csv)|*.csv",
                Title = "Get csv file."
            };
            string inputFile = "";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = OpenFileDialog1.FileName;
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        inputFile = sr.ReadToEnd();
                    }
                    readOk = true;
                }
                catch (System.UnauthorizedAccessException)
                {
                    MessageBox.Show($"Acces to path '{OpenFileDialog1.FileName.ToString()}' was denied!");
                    readOk = false;
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show($"'The process cannot access the file '{OpenFileDialog1.FileName.ToString()}' because it is being used by another process.");
                    readOk = false;
                }
            }
            return inputFile;
        }

        /// <summary>
        /// bekomt wegmatrix übergeben
        /// </summary>
        /// <param name="wegmatrix"></param>
        /// <returns></returns>
        public ArrayList Komponenten(int[,] wegmatrix)
        {
            ArrayList komponents = new ArrayList();//pro eintrag eine komponente .. eintrag enthält index+1 als string
            ArrayList schongesucht = new ArrayList(); // füge int(index) als knoten hinzu wenn dieser bereits durchsucht wurde
            int y = 0;
            for (int x = 0; x < ammountNode; x++)
            {
                string kompo = "";
                if (!schongesucht.Contains(x))
                {
                    for (y = 0; y < ammountNode; y++)
                    {
                        if (wegmatrix[y, x] == 1)
                        {
                            kompo += $"{y + 1}, ";
                            schongesucht.Add(y);
                        }
                    }

                    komponents.Add(kompo.Remove(kompo.Length - 2, 2));
                }
            }
            return komponents;
        }

        /// <summary>
        /// multiplies on matrix with another
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] prod = new int[ammountNode, ammountNode];
            int x = 0;
            int y = 0;
            for (int i = 0; i < a.Length; i++, x++)
            {
                if (x == ammountNode)
                {
                    y++;
                    x = 0;
                }
                if (y == ammountNode)
                    i = a.Length;
                int[] arrayY = new int[ammountNode];
                int[] arrayX = new int[ammountNode];
                for (int ii = 0; ii < ammountNode; ii++)
                {
                    arrayY[ii] = a[ii, x];
                    arrayX[ii] = b[y, ii];
                }
                int value = 0;
                for (int ii = 0; ii < ammountNode; ii++)
                {
                    value += arrayY[ii] * arrayX[ii];
                }
                prod[y, x] = value;
            }
            return prod;
        }

        /// <summary>
        /// returns int - radius -  -1 wird returned wenn der graphen nicht zsammenhängend ist.
        /// </summary>
        /// <returns></returns>
        public int Radius()
        {
            try
            {
                if (!zusammenhaengend)
                {
                    return -1;
                }
                int[] exz = Exzentrizitaeten();
                int radius = exz.Min();
                return radius;
            }
            catch (InvalidOperationException)
            {
                return -1;
            }
        }

        /// <summary>
        /// reads csv file  checks content for ammount of nodes - puts content into a string - calls checkifCsvFileIsOk Function
        /// </summary>
        /// <returns></returns>
        public bool ReadCSV()
        {
            //reinitiates matrix and ammounNode with null/0 
            matrix = null;
            ammountNode = 0;
            String csvInput = FileSelector();
            CheckIfCsvFileIsOk(csvInput);
            if (readOk)
            {
                //Figure out how many nodes there are
                for (int i = 0; i < csvInput.IndexOf("\r\n"); i++)
                    ammountNode = csvInput[i].ToString() != "," ? ammountNode + 1 : ammountNode;
                //initialize Array
                matrix = new int[ammountNode, ammountNode];
                try
                {
                    //copy csv from csvInput into the matrix;
                    int y = 0;
                    int x = 0;
                    for (int i = 0; i < csvInput.Length; i++, x++)
                    {
                        if (x == ammountNode)
                        {
                            y++;
                            x = 0;
                        }
                        if (csvInput[i] == '0' || csvInput[i] == '1')
                        {
                            matrix[y, x] = Convert.ToInt32(csvInput[i]) - 48;
                        }
                        else
                        {
                            x--;
                        }
                    }
                    Zusammenhaengend(matrix, ammountNode + 1);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show($"Index out of Bound exception while trying to copie csvInput into Matrix! -> {DateTime.Now.ToString()} - This Application will now end");
                    Application.Exit();
                }
                try
                {
                    for (int y = 0; y < ammountNode && readOk; y++)
                    {
                        for (int x = y; x < ammountNode && readOk; x++)
                        {
                            if (matrix[y, x] != matrix[x, y])
                            {
                                readOk = false;
                                throw new Exception("Matrix not diagonal");
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    readOk = false;
                    MessageBox.Show(e.Message);
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// replace a Value that is not on the diagonal line
        /// </summary>
        /// <param name="cur"></param>
        /// <param name="isValue"></param>
        /// <param name="shouldValue"></param>
        /// <returns></returns>
        public int[,] ReplaceValueNoneDiagonal(int[,] cur, int isValue, int shouldValue)
        {
            int y = 0;
            int x = 0;
            for (int i = 0; i < cur.Length; i++, x++)
            {
                if (x == ammountNode)
                {
                    y++;
                    x = 0;
                }
                if (y == ammountNode)
                    i = cur.Length;
                if (x != y && cur[y, x] == isValue)
                {
                    cur[y, x] = shouldValue;
                }
            }
            return cur;
        }

        /// <summary>
        /// input is a matrix - output is a string
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public string Show(int[,] b)
        {
            try
            {
                if (b != null)
                {
                    String c = "";
                    int y = 0;
                    int x = 0;
                    for (int i = 0; i < b.Length; i++, x++)
                    {
                        if (x == ammountNode)
                        {
                            y++;
                            x = 0;
                            c += "\n";
                        }
                        if (y == ammountNode)
                            i = b.Length;
                        if (b[y, x] >= 0)
                        {
                            c += $"  {b[y, x]}  ";
                        }
                        else
                        {
                            c += $" {b[y, x]}  ";
                        }
                    }
                    return c;
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("index out of range");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("null pointer exception");
            }
            return null;
        }

        /// <summary>
        /// !Todo: matrix als argument für brücken
        /// </summary>
        /// <param name="inputmatrix"></param>
        /// <returns></returns>
        public int[,] WegMatrix(int[,] inputmatrix)
        {
            Boolean aendern = true;
            int[,] AD = CopieMatrix(inputmatrix);
            int[,] ADx = CopieMatrix(AD);
            for (int i = 0; i < ammountNode; i++)
            {
                AD[i, i] = 1;
            }
            while (aendern)
            {
                aendern = false;
                ADx = Multiply(inputmatrix, ADx);
                for (int x = 0; x < ammountNode; x++)
                {
                    for (int y = 0; y < ammountNode; y++)
                    {
                        if (AD[y, x] == 0 && ADx[y, x] != 0)
                        {
                            aendern = true;
                            AD[y, x] = 1;
                        }
                    }
                }
            }
            return AD;
        }

        /// <summary>
        /// returns arraylist - zählt 0 nicht mit :: Knoten "n-1" - null wird returned wenn der graphen nicht zsammenhängend ist.
        /// </summary>
        /// <returns></returns>
        public string Zentrum()
        {
            try
            {
                if (!zusammenhaengend)
                {
                    return null;
                }
                string str = "{";
                int zRadius = Radius();
                int[] exz = Exzentrizitaeten();

                for (int i = 0; i < exz.Length; i++)
                {
                    if (exz[i] == zRadius)
                        str += $"{i + 1}, ";
                }
                StringBuilder sb = new StringBuilder(str);
                sb[str.Length - 2] = '}';
                return sb.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }

        /// <summary>
        /// bekommt AD übergeben // exclude: x/y achsen die  bei der kontrolle ausgelassen werden sollen (wenn auslassen ausgelassen werden soll dann ammountNode+1)
        /// </summary>
        /// <param name="AD"></param>
        /// <param name="exclude"></param>
        /// <returns></returns>
        public bool Zusammenhaengend(int[,] AD, int exclude)
        {
            int[,] i = Distanz(AD);
            Boolean x = CheckForValueNoneDiagonal(i, -1, exclude);
            if (x)
            {
                zusammenhaengend = false;
                return false;
            }
            else
            {
                zusammenhaengend = true;
                return true;
            }
        }

        /// <summary>
        /// Checks if there are any unallowed characters in the inputfile
        /// </summary>
        /// <param name="input"></param>
        private void CheckIfCsvFileIsOk(string input)
        {
            try
            {
                for (int i = 0; i < input.Length && readOk; i++)
                {
                    if (input[i] == '0' || input[i] == '1' || input[i] == ',' || input[i] == '\r' || input[i] == '\n')
                    {
                        //current char is ok   
                        readOk = true;
                    }
                    else
                    {
                        //current char is not allowed -> exception is thrown
                        readOk = false;
                        throw new Exception($"Character '{input[i]}' at index {i} is not allowed. Please fix the csv file and try again!");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// it works -> dont touch it
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private int[,] CopieMatrix(int[,] a)
        {
            int[,] b = new int[ammountNode, ammountNode];
            int y = 0;
            int x = 0;
            for (int i = 0; i < a.Length; i++, x++)
            {
                if (x == ammountNode)
                {
                    y++;
                    x = 0;
                }
                if (y == ammountNode)
                    i = a.Length;
                b[y, x] = a[y, x];
            }
            return b;
        }
    }
}
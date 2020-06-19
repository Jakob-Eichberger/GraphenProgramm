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
    public class MatrixClass
    {
        public int[,] matrix;
        int ammountNode = 0;
        public Boolean zusammenhaengend;
        public Boolean readOk = false;

        public MatrixClass()
        {
        }
        //used to get the full matrix;
        public int[,] Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        public Boolean ReadOk
        {
            get { return readOk; }
            set { readOk = value; }
        }

        public int AmmountNode
        {
            get { return ammountNode; }
            set { ammountNode = value; }
        }

        public Boolean ZusammenHaengend
        {
            get { return zusammenhaengend; }
        }

        //get file path
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


        //reads csv file  checks content for ammount of nodes - puts content into a string - calls checkifCsvFileIsOk Function
        public bool ReadCSV()
        {


            //reinitiates matrix and ammounNode with null/0 
            matrix = null;
            ammountNode = 0;

            String csvInput = FileSelector();

            checkIfCsvFileIsOk(csvInput);

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
                return true;
            }
            return false;
        }

        //Checks if there are any unallowed characters in the inputfile
        private void checkIfCsvFileIsOk(string input)
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

        //it works -> dont touch it
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

        //multiplies on matrix with another
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

        //input is a matrix - output is a string
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
                else
                {

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
        //if value x is found true is returned - Function does not check diagonal lines for x 
        public Boolean checkForValueNoneDiagonal(int[,] b, int checkValue, int excludeXY)
        {
            Boolean valueFound = false;
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
                                    valueFound = true;
                            }
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Array is not same as default");
            }
            return valueFound;
        }

        //replace a Value that is not on the diagonal line
        public int[,] replaceValueNoneDiagonal(int[,] cur, int isValue, int shouldValue)
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

        //function shows all distanzes from every vertex to every other vertex - returns int[,]
        public int[,] Distanz(int[,] givenmatrix)
        {
            int[,] dMatrix = CopieMatrix(givenmatrix);
            int[,] multiMatrix = CopieMatrix(givenmatrix);
            dMatrix = replaceValueNoneDiagonal(dMatrix, 0, -1);
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

        //liefert 1d array zurück in der länge von ammountNode ... und jeder Eintrag ist == zu jeder y Koordinate
        public int[] exzentrizitaeten()
        {
            int[,] dMatrix = Distanz(matrix);
            int[] eMatrix = new int[ammountNode];
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

        //return AD + Exzentrizitäten als string
        public string exzentrizitaetenString()
        {
            int[,] tempaxa = CopieMatrix(matrix);
            int[] exz = exzentrizitaeten();
            
            string temp = "";
            for (int y = 0; y < ammountNode ; y++)
            {

                temp += "  ";
                for (int x = 0; x <ammountNode; x++)
                {
                    temp += $"{tempaxa[y,x]}    ";
                }
                temp += $"|  {exz[y]}\n";
            }
            return temp;
        }

        //returns int - radius -  -1 wird returned wenn der graphen nicht zsammenhängend ist.
        public int radius()
        {
            try
            {
                if (!zusammenhaengend)
                {
                    return -1;
                }
                int[] exz = exzentrizitaeten();
                int radius = exz.Min();
                return radius;
            }
            catch (InvalidOperationException)
            {
                return -1;
            }
        }

        //returns int - durchmesser - -1 wird returned wenn der graphen nicht zsammenhängend ist.
        public int durchmesser()
        {
            try
            {
                if (!zusammenhaengend)
                {
                    return -1;
                }
                int[] exz = exzentrizitaeten();
                int durchmesser = exz.Max();
                return durchmesser;
            }
            catch (InvalidOperationException)
            {
                return -1;
            }
        }

        // returns arraylist - zählt 0 nicht mit :: Knoten "n-1" - null wird returned wenn der graphen nicht zsammenhängend ist.
        public string zentrum()
        {
            try
            {
                if (!zusammenhaengend)
                {
                    return null;
                }
                string str = "{";
                int zRadius = radius();
                int[] exz = exzentrizitaeten();

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

        //bekommt AD übergeben // exclude: x/y achsen die  bei der kontrolle ausgelassen werden sollen (wenn ausgelassen dann ammountNode+1)
        public Boolean Zusammenhaengend(int[,] AD, int exclude)
        {
            int[,] i = Distanz(AD);
            if (checkForValueNoneDiagonal(i, -1, exclude))
            {
                zusammenhaengend = false;
                return true;
            }
            else
            {
                zusammenhaengend = true;
                return false;
            }
        }

        //!Todo: matrix als argument für brücken
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

        //bekomt wegmatrix übergeben
        public ArrayList komponenten(int[,] wegmatrix)
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
                    komponents.Add(kompo);
                }
            }
            return komponents;
        }

        //bekommt normale matrix -> in matrix werden felder geändert -> dann wegmatrix -> dann komponente
        public ArrayList brucken(int[,] bru_matrix)
        {
            ArrayList komp = komponenten(WegMatrix(bru_matrix));
            ArrayList bruecken = new ArrayList();
            for (int x = 0; x < ammountNode - 1; x++)
            {
                for (int y = x + 1; y < ammountNode; y++)
                {
                    if (bru_matrix[y, x] == 1)
                    {
                        bru_matrix[y, x] = 0;
                        bru_matrix[x, y] = 0;
                        ArrayList komptemp = komponenten(WegMatrix(bru_matrix));
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

        //bekommt AD übergeben
        public ArrayList artikulation(int[,] art_matrix)
        {

            ArrayList artiku = new ArrayList();
            ArrayList komp = komponenten(WegMatrix(art_matrix));
            int kompanz = komp.Count;


            for (int x = 0; x < ammountNode; x++)
            {
                int[,] temporary = CopieMatrix(art_matrix);

                int temp = 0;
                for (int y = x; y < ammountNode; y++)
                {
                    //zähle alle Kanten bro x
                    if (temporary[y, x] == 1 || y == x)
                    {
                        temp++;
                    }
                }
                //artikulations dont have the  value 0 or 1
                if (temp > 2)
                {
                    for (int n = 0; n < ammountNode; n++)
                    {
                        temporary[x, n] = 0;
                        temporary[n, x] = 0;
                    }
                    Boolean zus = Zusammenhaengend(temporary, x);
                    if (zus)
                    {
                        ArrayList i = komponenten(WegMatrix(temporary));
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
    }
}
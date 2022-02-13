using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using GrafenProgramm.Properties;
using System.Linq.Expressions;
using System.Threading;


/*
ToDo: 
Function that shows all the output in a grid     <- Not Done
*/

namespace GrafenProgramm
{
    public partial class MainWindow : Form

    {
        MatrixClass matrix = new MatrixClass();
        int[,] distanz;

        int radius;
        int durchmesser;
        string zentrum;
        string AD;
        string wegmatrix;

        public MainWindow()
        {
            InitializeComponent();

            if (Properties.Settings.Default["theme"].ToString() == 1.ToString())
            {
                DarkTheme();
            }
            else
            {
                BrightTheme();
            }
            label1.Text = "";
            labRadius.Text = "-";
            labZentrum.Text = "-";
            labDurchmesser.Text = "-";
            labZusammen.Text = "-";

            labKompo.Text = "-";
            labArtik.Text = "-";
            labBruck.Text = "-";


        }

        private Boolean BerechneGraphen(Boolean readfile, int[,] newmatrix, int size)
        {
            //either read from file or geneatte a new one;
            label1.Text = "";
            if (readfile)
            {
                label1.Text = "";
                matrix.ReadCSV();
            }
            else
            {
                matrix.Matrix = newmatrix;
                matrix.AmmountNode = size;
                matrix.ReadOk = true;
            }

            //figure out how big the matrix is and  ajust label1's font
            int fontsieze;


            if (matrix.AmmountNode < 10)
            {
                fontsieze = 18;
            }
            else
            {
                fontsieze = 200 / matrix.AmmountNode;
            }

            label1.Font = new Font("Microsoft Sans Serif", fontsieze);

            //do all the othe stuff
            if (matrix.readOk && matrix.Matrix != null)
            {
                distanz = matrix.Distanz(matrix.Matrix);
                radius = matrix.radius();
                durchmesser = matrix.durchmesser();
                zentrum = matrix.zentrum();
                AD = matrix.exzentrizitaetenString();
                wegmatrix = matrix.Show(matrix.WegMatrix(matrix.Matrix));


                if (!matrix.ZusammenHaengend)
                {
                    labRadius.Text = "-";
                    labZentrum.Text = "-";
                    labDurchmesser.Text = "-";
                    labZusammen.Text = "nein";
                }
                else
                {
                    labZusammen.Text = "ja";
                    labRadius.Text = radius.ToString();
                    labZentrum.Text = zentrum;


                    labDurchmesser.Text = durchmesser.ToString();
                }

                //Brücken am Label anzeigen
                ArrayList temp = matrix.brucken(matrix.Matrix);
                string n = "";
                if (temp.Count != 0)
                {
                    foreach (string i in temp)
                    {
                        n += i;
                    }
                }
                else
                {
                    n = "Keine Brücken vorhanden!";
                }
                labBruck.Text = n;

                //Komponenten am Label anzeigen
                ArrayList x = matrix.komponenten(matrix.WegMatrix(matrix.Matrix));

                string m = "";
                for (int i = 0; i < x.Count; i++)
                {
                    m += $"{{{x[i]}}} ";
                }
                labKompo.Text = m;

                //Artikulationen am Label anzeigen
                ArrayList art = matrix.artikulationen(matrix.Matrix);
                string oo = "";
                if (art.Count != 0)
                {
                    foreach (string ll in art)
                    {
                        oo += $" V{ll}";
                    }
                }
                else
                {
                    oo = "-";
                }
                labArtik.Text = oo;


            }
            else if (matrix.Matrix == null)
            {
                labRadius.Text = "-";
                labZentrum.Text = "-";
                labDurchmesser.Text = "-";
                labZusammen.Text = "-";
            }
            return true;
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {

            BerechneGraphen(true, null, 0);


        }

        private void DistanzenBtn_Click(object sender, EventArgs e)
        {
            label1.Text = matrix.Show(distanz);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Graphen_Click(object sender, EventArgs e)
        {
            label1.Text = AD;
        }

        private void WegBtn_Click(object sender, EventArgs e)
        {
            label1.Text = wegmatrix;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BrightTheme()
        {
            this.distanzenBtn.BackColor = System.Drawing.SystemColors.Control;
            this.distanzenBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.distanzenBtn.ForeColor = System.Drawing.SystemColors.ControlText;


            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;

            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;

            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;

            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;

            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;

            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;

            this.labZentrum.BackColor = System.Drawing.SystemColors.Control;
            this.labZentrum.ForeColor = System.Drawing.SystemColors.ControlText;

            this.labZusammen.BackColor = System.Drawing.SystemColors.Control;
            this.labZusammen.ForeColor = System.Drawing.SystemColors.ControlText;

            this.labRadius.BackColor = System.Drawing.SystemColors.Control;
            this.labRadius.ForeColor = System.Drawing.SystemColors.ControlText;

            this.labDurchmesser.BackColor = System.Drawing.SystemColors.Control;
            this.labDurchmesser.ForeColor = System.Drawing.SystemColors.ControlText;

            this.Graphen.BackColor = System.Drawing.SystemColors.Control;
            this.Graphen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Graphen.ForeColor = System.Drawing.SystemColors.ControlText;

            this.wegBtn.BackColor = System.Drawing.SystemColors.Control;
            this.wegBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.wegBtn.ForeColor = System.Drawing.SystemColors.ControlText;

            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.openFile.BackColor = System.Drawing.SystemColors.Control;
            this.openFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openFile.ForeColor = System.Drawing.SystemColors.ControlText;

            this.BackColor = System.Drawing.SystemColors.Control;

            this.openFile.BackColor = System.Drawing.SystemColors.Control;
            this.openFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openFile.ForeColor = System.Drawing.SystemColors.ControlText;

            this.labTheme.BackColor = System.Drawing.SystemColors.Control;
            this.labTheme.ForeColor = System.Drawing.SystemColors.ControlText;

            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;

            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;

            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;

            this.labKompo.BackColor = System.Drawing.SystemColors.Control;
            this.labKompo.ForeColor = System.Drawing.SystemColors.ControlText;

            this.labArtik.BackColor = System.Drawing.SystemColors.Control;
            this.labArtik.ForeColor = System.Drawing.SystemColors.ControlText;

            this.labBruck.BackColor = System.Drawing.SystemColors.Control;
            this.labBruck.ForeColor = System.Drawing.SystemColors.ControlText;

            this.panel3.BackColor = System.Drawing.SystemColors.Control;

            this.generateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.generateBtn.ForeColor = System.Drawing.SystemColors.ControlText;


        }

        private void DarkTheme()
        {
            this.distanzenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.distanzenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.distanzenBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));

            this.labZentrum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.labZentrum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.labZusammen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.labZusammen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.labRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.labRadius.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.labDurchmesser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.labDurchmesser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.Graphen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.Graphen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Graphen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.wegBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.wegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wegBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));

            this.openFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));

            this.openFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.labTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.labKompo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.labKompo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.labArtik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.labArtik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.labBruck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.labBruck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));

            this.generateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DarkTheme();
            Properties.Settings.Default["theme"] = 1.ToString();
            Properties.Settings.Default.Save();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BrightTheme();
            Properties.Settings.Default["theme"] = 0.ToString();
            Properties.Settings.Default.Save();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        //open interface for generate settings
        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            generateBtn.Text = "LOADING";

            FormSettings stn = new FormSettings();
            stn.ShowDialog();
            int size = stn.Size;
            Matrix temp = new Matrix();
            int[,] temp1 = temp.Generat(size);
            BerechneGraphen(false, temp1, size);
            Thread.Sleep(300);
            generateBtn.Text = "Generate";
        }
    }
}


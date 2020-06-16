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

/*
ToDo: 
Function that shows all the output in a grid     <- Not Done
*/

namespace GrafenProgramm
{
    public partial class Form1 : Form

    {
        MatrixClass matrix = new MatrixClass();
        int[,] distanz;
        int[] exzentrizitaeten;
        int radius;
        int durchmesser;
        string zentrum;
        //Artikulationen
        //Komponenten

        public Form1()
        {
            InitializeComponent();
            
            if (Convert.ToBoolean(Settings.Default["theme"]))
            {
                darkTheme();
            }
            else
            {
                brightTheme();
            }
            label1.Text = "";
            labRadius.Text = "-";
            labZentrum.Text = "-";
            labDurchmesser.Text = "-";
            labZusammen.Text = "-";
            labBruecken.Text = "-";



        }

        private void openFile_Click(object sender, EventArgs e)
        {

            label1.Text = "";
            matrix.ReadCSV();

            if (matrix.readOk && matrix.Matrix != null)
            {
                distanz = matrix.Distanz(matrix.Matrix);
                exzentrizitaeten = matrix.exzentrizitaeten();
                radius = matrix.radius();
                durchmesser = matrix.durchmesser();
                zentrum = matrix.zentrum();
                labBruecken.Text = matrix.brucken(matrix.Matrix).ToString();



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

            }
            else if (matrix.Matrix == null)
            {
                labRadius.Text = "-";
                labZentrum.Text = "-";
                labDurchmesser.Text = "-";
                labZusammen.Text = "-";
            }
        }


        private void komponentenBtn_Click(object sender, EventArgs e)
        {
            ArrayList x = matrix.Komponenten(matrix.WegMatrix(matrix.Matrix));

            string m = "";
            for (int i = 0; i < x.Count; i++)
            {
                m += $"{x[i]}\n";
            }
            label1.Text = m;
            // MessageBox.Show(x.Count.ToString());
        }



        private void brueckenBtn_Click(object sender, EventArgs e)
        {
            /* ArrayList x = matrix.brucken(matrix.Matrix);
             string temp="";
            foreach(string i in x)
             {
                 temp += i + "";
             }
             */

            int temp = matrix.brucken(matrix.Matrix);
            MessageBox.Show(temp.ToString());
        }

        private void artikulationenBtn_Click(object sender, EventArgs e)
        {

        }



        private void exzentrizitaetBtn_Click(object sender, EventArgs e)
        {

        }

        private void distanzenBtn_Click(object sender, EventArgs e)
        {
            label1.Text = matrix.Show(distanz);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Graphen_Click(object sender, EventArgs e)
        {
            label1.Text = matrix.Show(matrix.Matrix);
        }

        private void wegBtn_Click(object sender, EventArgs e)
        {
            label1.Text = matrix.Show(matrix.WegMatrix(matrix.Matrix)); ;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void brightTheme()
        {
            this.distanzenBtn.BackColor = System.Drawing.SystemColors.Control;
            this.distanzenBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.distanzenBtn.ForeColor = System.Drawing.SystemColors.ControlText;

            this.exzentrizitaetBtn.BackColor = System.Drawing.SystemColors.Control;
            this.exzentrizitaetBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exzentrizitaetBtn.ForeColor = System.Drawing.SystemColors.ControlText;

            this.komponentenBtn.BackColor = System.Drawing.SystemColors.Control;
            this.komponentenBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.komponentenBtn.ForeColor = System.Drawing.SystemColors.ControlText;

            this.artikulationenBtn.BackColor = System.Drawing.SystemColors.Control;
            this.artikulationenBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.artikulationenBtn.ForeColor = System.Drawing.SystemColors.ControlText;

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

            this.labBruecken.BackColor = System.Drawing.SystemColors.Control;
            this.labBruecken.ForeColor = System.Drawing.SystemColors.ControlText;

            this.Label6.BackColor = System.Drawing.SystemColors.Control;
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;

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


        }
        private void darkTheme()
        {
            this.distanzenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.distanzenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.distanzenBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.exzentrizitaetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.exzentrizitaetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exzentrizitaetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.komponentenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.komponentenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.komponentenBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.artikulationenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.artikulationenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artikulationenBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

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

            this.labBruecken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.labBruecken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

            this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            darkTheme();
            Settings.Default["theme"] = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            brightTheme();
            Settings.Default["theme"] = false;
        }
    }
}


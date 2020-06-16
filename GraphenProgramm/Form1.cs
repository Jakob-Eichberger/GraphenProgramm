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
            label1.Text = "";
            labRadius.Text = "-";
            labZentrum.Text = "-";
            labDurchmesser.Text = "-";
            labZusammen.Text = "-";
            labBruecken.Text = "-";
            darkTheme();
           

        }

        private void ReadCSV_Click(object sender, EventArgs e)
        {
            
            label1.Text = "";
            matrix.ReadCSV();

            if (matrix.readOk&&matrix.Matrix!=null) { 
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

            }else if (matrix.Matrix == null)
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
             for (int i =0; i<x.Count;i++)
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

        private void CSVPath_TextChanged(object sender, EventArgs e)
        {

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
            

        }
        private void darkTheme()
        {
            openFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 49, 48);

        }

    }
}


using GrafenProgramm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafenProgramm
{
    public partial class FormSettings : Form
    {
        int size = 0;
        Boolean zusammenhangen;
        Boolean artikulationen;

        public FormSettings()
        {
            InitializeComponent();


            checkBox3.Checked = Convert.ToBoolean(Properties.Settings.Default["enable"]);
            checkBox2.Checked = Convert.ToBoolean(Properties.Settings.Default["zusammenhangen"]);
            checkBox1.Checked = Convert.ToBoolean(Properties.Settings.Default["artikulationen"]);



            if (!checkBox3.Checked)
            {
                numericUpDown1.Value = Convert.ToDecimal(Properties.Settings.Default["size"]);
            }
            else
            {
                if (Convert.ToDecimal(Properties.Settings.Default["size"])>5)
                {
                    numericUpDown1.Value = 5;
                }
                else
                {
                    numericUpDown1.Value = Convert.ToDecimal(Properties.Settings.Default["size"]);
                }
                
            }
            checkifcheckbox3ischeckd();

        }

        public int Size
        {
            get { return size; }
        }
        public Boolean Zusammenhangen
        {
            get { return zusammenhangen; }

        }
        public Boolean Artikulationen
        {
            get { return artikulationen; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Boolean enabled
        {
            get { return checkBox3.Checked; }
        }
        private void checkifcheckbox3ischeckd()
        {
            if (checkBox3.Checked == true)
            {
                label2.Text = "Option  verursacht lange durchlaufzeit!";
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                numericUpDown1.Maximum = 5;
            }
            else
            {
                numericUpDown1.Maximum = 30;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                label2.Text = "";
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["enable"] = checkBox3.Checked;
            checkifcheckbox3ischeckd();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            size = Convert.ToInt32(numericUpDown1.Value);
            Properties.Settings.Default["size"] = Convert.ToInt32(numericUpDown1.Value);
            Properties.Settings.Default.Save();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["zusammenhangen"] = checkBox2.Checked;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["artikulationen"] = checkBox1.Checked;
        }
    }
}

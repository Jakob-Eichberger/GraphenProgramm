namespace GrafenProgramm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFile = new System.Windows.Forms.Button();
            this.distanzenBtn = new System.Windows.Forms.Button();
            this.exzentrizitaetBtn = new System.Windows.Forms.Button();
            this.komponentenBtn = new System.Windows.Forms.Button();
            this.artikulationenBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labBruecken = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.labZentrum = new System.Windows.Forms.Label();
            this.labZusammen = new System.Windows.Forms.Label();
            this.labRadius = new System.Windows.Forms.Label();
            this.labDurchmesser = new System.Windows.Forms.Label();
            this.Graphen = new System.Windows.Forms.Button();
            this.wegBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(12, 9);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(533, 23);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "OpenFile";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.ReadCSV_Click);
            // 
            // distanzenBtn
            // 
            this.distanzenBtn.Location = new System.Drawing.Point(346, 48);
            this.distanzenBtn.Name = "distanzenBtn";
            this.distanzenBtn.Size = new System.Drawing.Size(87, 23);
            this.distanzenBtn.TabIndex = 2;
            this.distanzenBtn.Text = "Distanzen";
            this.distanzenBtn.UseVisualStyleBackColor = true;
            this.distanzenBtn.Click += new System.EventHandler(this.distanzenBtn_Click);
            // 
            // exzentrizitaetBtn
            // 
            this.exzentrizitaetBtn.Location = new System.Drawing.Point(346, 87);
            this.exzentrizitaetBtn.Name = "exzentrizitaetBtn";
            this.exzentrizitaetBtn.Size = new System.Drawing.Size(87, 23);
            this.exzentrizitaetBtn.TabIndex = 3;
            this.exzentrizitaetBtn.Text = "Exzentrizitaet";
            this.exzentrizitaetBtn.UseVisualStyleBackColor = true;
            this.exzentrizitaetBtn.Click += new System.EventHandler(this.exzentrizitaetBtn_Click);
            // 
            // komponentenBtn
            // 
            this.komponentenBtn.Location = new System.Drawing.Point(458, 87);
            this.komponentenBtn.Name = "komponentenBtn";
            this.komponentenBtn.Size = new System.Drawing.Size(87, 23);
            this.komponentenBtn.TabIndex = 9;
            this.komponentenBtn.Text = "Komponenten";
            this.komponentenBtn.UseVisualStyleBackColor = true;
            this.komponentenBtn.Click += new System.EventHandler(this.komponentenBtn_Click);
            // 
            // artikulationenBtn
            // 
            this.artikulationenBtn.Location = new System.Drawing.Point(234, 87);
            this.artikulationenBtn.Name = "artikulationenBtn";
            this.artikulationenBtn.Size = new System.Drawing.Size(87, 23);
            this.artikulationenBtn.TabIndex = 7;
            this.artikulationenBtn.Text = "Artikulationen";
            this.artikulationenBtn.UseVisualStyleBackColor = true;
            this.artikulationenBtn.Click += new System.EventHandler(this.artikulationenBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "matrix";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Zusammenhängend:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Radius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Durchmesser";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Zentrum";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.labBruecken);
            this.panel1.Controls.Add(this.Label6);
            this.panel1.Controls.Add(this.labZentrum);
            this.panel1.Controls.Add(this.labZusammen);
            this.panel1.Controls.Add(this.labRadius);
            this.panel1.Controls.Add(this.labDurchmesser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(15, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 75);
            this.panel1.TabIndex = 15;
            // 
            // labBruecken
            // 
            this.labBruecken.AutoSize = true;
            this.labBruecken.Location = new System.Drawing.Point(117, 57);
            this.labBruecken.Name = "labBruecken";
            this.labBruecken.Size = new System.Drawing.Size(61, 13);
            this.labBruecken.TabIndex = 20;
            this.labBruecken.Text = "labBrucken";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(3, 57);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(68, 13);
            this.Label6.TabIndex = 19;
            this.Label6.Text = "AnzBrücken:";
            // 
            // labZentrum
            // 
            this.labZentrum.AutoSize = true;
            this.labZentrum.Location = new System.Drawing.Point(117, 44);
            this.labZentrum.Name = "labZentrum";
            this.labZentrum.Size = new System.Drawing.Size(43, 13);
            this.labZentrum.TabIndex = 18;
            this.labZentrum.Text = "labZent";
            // 
            // labZusammen
            // 
            this.labZusammen.AutoSize = true;
            this.labZusammen.Location = new System.Drawing.Point(117, 5);
            this.labZusammen.Name = "labZusammen";
            this.labZusammen.Size = new System.Drawing.Size(39, 13);
            this.labZusammen.TabIndex = 17;
            this.labZusammen.Text = "labZus";
            // 
            // labRadius
            // 
            this.labRadius.AutoSize = true;
            this.labRadius.Location = new System.Drawing.Point(117, 18);
            this.labRadius.Name = "labRadius";
            this.labRadius.Size = new System.Drawing.Size(41, 13);
            this.labRadius.TabIndex = 16;
            this.labRadius.Text = "labRad";
            // 
            // labDurchmesser
            // 
            this.labDurchmesser.AutoSize = true;
            this.labDurchmesser.Location = new System.Drawing.Point(117, 31);
            this.labDurchmesser.Name = "labDurchmesser";
            this.labDurchmesser.Size = new System.Drawing.Size(50, 13);
            this.labDurchmesser.TabIndex = 15;
            this.labDurchmesser.Text = "labDurch";
            // 
            // Graphen
            // 
            this.Graphen.Location = new System.Drawing.Point(234, 48);
            this.Graphen.Name = "Graphen";
            this.Graphen.Size = new System.Drawing.Size(87, 23);
            this.Graphen.TabIndex = 16;
            this.Graphen.Text = "Graphen";
            this.Graphen.UseVisualStyleBackColor = true;
            this.Graphen.Click += new System.EventHandler(this.Graphen_Click);
            // 
            // wegBtn
            // 
            this.wegBtn.Location = new System.Drawing.Point(458, 48);
            this.wegBtn.Name = "wegBtn";
            this.wegBtn.Size = new System.Drawing.Size(87, 23);
            this.wegBtn.TabIndex = 17;
            this.wegBtn.Text = "Weg";
            this.wegBtn.UseVisualStyleBackColor = true;
            this.wegBtn.Click += new System.EventHandler(this.wegBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(15, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 374);
            this.panel2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.wegBtn);
            this.Controls.Add(this.Graphen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.komponentenBtn);
            this.Controls.Add(this.artikulationenBtn);
            this.Controls.Add(this.exzentrizitaetBtn);
            this.Controls.Add(this.distanzenBtn);
            this.Controls.Add(this.openFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "               ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button distanzenBtn;
        private System.Windows.Forms.Button exzentrizitaetBtn;
        private System.Windows.Forms.Button komponentenBtn;
        private System.Windows.Forms.Button artikulationenBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labZentrum;
        private System.Windows.Forms.Label labZusammen;
        private System.Windows.Forms.Label labRadius;
        private System.Windows.Forms.Label labDurchmesser;
        private System.Windows.Forms.Button Graphen;
        private System.Windows.Forms.Button wegBtn;
        private System.Windows.Forms.Label labBruecken;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Panel panel2;
    }
}


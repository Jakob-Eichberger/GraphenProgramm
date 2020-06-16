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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.labTheme = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // distanzenBtn
            // 
            this.distanzenBtn.BackColor = System.Drawing.SystemColors.Control;
            this.distanzenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.distanzenBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.distanzenBtn.Location = new System.Drawing.Point(346, 48);
            this.distanzenBtn.Name = "distanzenBtn";
            this.distanzenBtn.Size = new System.Drawing.Size(87, 23);
            this.distanzenBtn.TabIndex = 3;
            this.distanzenBtn.TabStop = false;
            this.distanzenBtn.Text = "Distanzen";
            this.distanzenBtn.UseVisualStyleBackColor = false;
            this.distanzenBtn.Click += new System.EventHandler(this.distanzenBtn_Click);
            // 
            // exzentrizitaetBtn
            // 
            this.exzentrizitaetBtn.BackColor = System.Drawing.SystemColors.Control;
            this.exzentrizitaetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exzentrizitaetBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exzentrizitaetBtn.Location = new System.Drawing.Point(346, 87);
            this.exzentrizitaetBtn.Name = "exzentrizitaetBtn";
            this.exzentrizitaetBtn.Size = new System.Drawing.Size(87, 23);
            this.exzentrizitaetBtn.TabIndex = 3;
            this.exzentrizitaetBtn.TabStop = false;
            this.exzentrizitaetBtn.Text = "Exzentrizitaet";
            this.exzentrizitaetBtn.UseVisualStyleBackColor = false;
            this.exzentrizitaetBtn.Click += new System.EventHandler(this.exzentrizitaetBtn_Click);
            // 
            // komponentenBtn
            // 
            this.komponentenBtn.BackColor = System.Drawing.SystemColors.Control;
            this.komponentenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.komponentenBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.komponentenBtn.Location = new System.Drawing.Point(458, 87);
            this.komponentenBtn.Name = "komponentenBtn";
            this.komponentenBtn.Size = new System.Drawing.Size(87, 23);
            this.komponentenBtn.TabIndex = 9;
            this.komponentenBtn.TabStop = false;
            this.komponentenBtn.Text = "Komponenten";
            this.komponentenBtn.UseVisualStyleBackColor = false;
            this.komponentenBtn.Click += new System.EventHandler(this.komponentenBtn_Click);
            // 
            // artikulationenBtn
            // 
            this.artikulationenBtn.BackColor = System.Drawing.SystemColors.Control;
            this.artikulationenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artikulationenBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.artikulationenBtn.Location = new System.Drawing.Point(234, 87);
            this.artikulationenBtn.Name = "artikulationenBtn";
            this.artikulationenBtn.Size = new System.Drawing.Size(87, 23);
            this.artikulationenBtn.TabIndex = 7;
            this.artikulationenBtn.TabStop = false;
            this.artikulationenBtn.Text = "Artikulationen";
            this.artikulationenBtn.UseVisualStyleBackColor = false;
            this.artikulationenBtn.Click += new System.EventHandler(this.artikulationenBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Zusammenhängend:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Radius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Durchmesser";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(3, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Zentrum";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(15, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 75);
            this.panel1.TabIndex = 15;
            // 
            // labBruecken
            // 
            this.labBruecken.AutoSize = true;
            this.labBruecken.BackColor = System.Drawing.SystemColors.Control;
            this.labBruecken.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labBruecken.Location = new System.Drawing.Point(117, 57);
            this.labBruecken.Name = "labBruecken";
            this.labBruecken.Size = new System.Drawing.Size(61, 13);
            this.labBruecken.TabIndex = 20;
            this.labBruecken.Text = "labBrucken";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.SystemColors.Control;
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(3, 57);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(68, 13);
            this.Label6.TabIndex = 19;
            this.Label6.Text = "AnzBrücken:";
            // 
            // labZentrum
            // 
            this.labZentrum.AutoSize = true;
            this.labZentrum.BackColor = System.Drawing.SystemColors.Control;
            this.labZentrum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labZentrum.Location = new System.Drawing.Point(117, 44);
            this.labZentrum.Name = "labZentrum";
            this.labZentrum.Size = new System.Drawing.Size(43, 13);
            this.labZentrum.TabIndex = 18;
            this.labZentrum.Text = "labZent";
            // 
            // labZusammen
            // 
            this.labZusammen.AutoSize = true;
            this.labZusammen.BackColor = System.Drawing.SystemColors.Control;
            this.labZusammen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labZusammen.Location = new System.Drawing.Point(117, 5);
            this.labZusammen.Name = "labZusammen";
            this.labZusammen.Size = new System.Drawing.Size(39, 13);
            this.labZusammen.TabIndex = 17;
            this.labZusammen.Text = "labZus";
            // 
            // labRadius
            // 
            this.labRadius.AutoSize = true;
            this.labRadius.BackColor = System.Drawing.SystemColors.Control;
            this.labRadius.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labRadius.Location = new System.Drawing.Point(117, 18);
            this.labRadius.Name = "labRadius";
            this.labRadius.Size = new System.Drawing.Size(41, 13);
            this.labRadius.TabIndex = 16;
            this.labRadius.Text = "labRad";
            // 
            // labDurchmesser
            // 
            this.labDurchmesser.AutoSize = true;
            this.labDurchmesser.BackColor = System.Drawing.SystemColors.Control;
            this.labDurchmesser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labDurchmesser.Location = new System.Drawing.Point(117, 31);
            this.labDurchmesser.Name = "labDurchmesser";
            this.labDurchmesser.Size = new System.Drawing.Size(50, 13);
            this.labDurchmesser.TabIndex = 15;
            this.labDurchmesser.Text = "labDurch";
            // 
            // Graphen
            // 
            this.Graphen.BackColor = System.Drawing.SystemColors.Control;
            this.Graphen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Graphen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Graphen.Location = new System.Drawing.Point(234, 48);
            this.Graphen.Name = "Graphen";
            this.Graphen.Size = new System.Drawing.Size(87, 23);
            this.Graphen.TabIndex = 2;
            this.Graphen.TabStop = false;
            this.Graphen.Text = "Graphen";
            this.Graphen.UseVisualStyleBackColor = false;
            this.Graphen.Click += new System.EventHandler(this.Graphen_Click);
            // 
            // wegBtn
            // 
            this.wegBtn.BackColor = System.Drawing.SystemColors.Control;
            this.wegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wegBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.wegBtn.Location = new System.Drawing.Point(458, 48);
            this.wegBtn.Name = "wegBtn";
            this.wegBtn.Size = new System.Drawing.Size(87, 23);
            this.wegBtn.TabIndex = 4;
            this.wegBtn.TabStop = false;
            this.wegBtn.Text = "Weg";
            this.wegBtn.UseVisualStyleBackColor = false;
            this.wegBtn.Click += new System.EventHandler(this.wegBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(15, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 374);
            this.panel2.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 10);
            this.button1.TabIndex = 11;
            this.button1.TabStop = false;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(46, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 10);
            this.button2.TabIndex = 19;
            this.button2.TabStop = false;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFile
            // 
            this.openFile.BackColor = System.Drawing.SystemColors.Control;
            this.openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openFile.Location = new System.Drawing.Point(21, 9);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(412, 23);
            this.openFile.TabIndex = 1;
            this.openFile.TabStop = false;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = false;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // labTheme
            // 
            this.labTheme.AutoSize = true;
            this.labTheme.Location = new System.Drawing.Point(0, 0);
            this.labTheme.Name = "labTheme";
            this.labTheme.Size = new System.Drawing.Size(43, 13);
            this.labTheme.TabIndex = 20;
            this.labTheme.Text = "Theme:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labTheme);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(457, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(88, 33);
            this.panel3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(557, 534);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.wegBtn);
            this.Controls.Add(this.Graphen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.komponentenBtn);
            this.Controls.Add(this.artikulationenBtn);
            this.Controls.Add(this.exzentrizitaetBtn);
            this.Controls.Add(this.distanzenBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "               ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Label labTheme;
        private System.Windows.Forms.Panel panel3;
    }
}


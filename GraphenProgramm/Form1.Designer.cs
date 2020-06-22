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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labZusammen = new System.Windows.Forms.Label();
            this.labArtik = new System.Windows.Forms.Label();
            this.labRadius = new System.Windows.Forms.Label();
            this.labDurchmesser = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labZentrum = new System.Windows.Forms.Label();
            this.Graphen = new System.Windows.Forms.Button();
            this.wegBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labTheme = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labBruck = new System.Windows.Forms.Label();
            this.labKompo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
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
            this.distanzenBtn.Location = new System.Drawing.Point(456, 55);
            this.distanzenBtn.Name = "distanzenBtn";
            this.distanzenBtn.Size = new System.Drawing.Size(87, 27);
            this.distanzenBtn.TabIndex = 3;
            this.distanzenBtn.TabStop = false;
            this.distanzenBtn.Text = "Distanzen";
            this.distanzenBtn.UseVisualStyleBackColor = false;
            this.distanzenBtn.Click += new System.EventHandler(this.distanzenBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
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
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Radius:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Durchmesser:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Zentrum:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labZusammen);
            this.panel1.Controls.Add(this.labArtik);
            this.panel1.Controls.Add(this.labRadius);
            this.panel1.Controls.Add(this.labDurchmesser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(15, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 62);
            this.panel1.TabIndex = 15;
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
            // labArtik
            // 
            this.labArtik.AutoSize = true;
            this.labArtik.Location = new System.Drawing.Point(118, 44);
            this.labArtik.Name = "labArtik";
            this.labArtik.Size = new System.Drawing.Size(42, 13);
            this.labArtik.TabIndex = 4;
            this.labArtik.Text = "labArtik";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Artikulationen:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // labZentrum
            // 
            this.labZentrum.AutoSize = true;
            this.labZentrum.BackColor = System.Drawing.SystemColors.Control;
            this.labZentrum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labZentrum.Location = new System.Drawing.Point(88, 16);
            this.labZentrum.Name = "labZentrum";
            this.labZentrum.Size = new System.Drawing.Size(43, 13);
            this.labZentrum.TabIndex = 18;
            this.labZentrum.Text = "labZent";
            // 
            // Graphen
            // 
            this.Graphen.BackColor = System.Drawing.SystemColors.Control;
            this.Graphen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Graphen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Graphen.Location = new System.Drawing.Point(234, 55);
            this.Graphen.Name = "Graphen";
            this.Graphen.Size = new System.Drawing.Size(87, 27);
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
            this.wegBtn.Location = new System.Drawing.Point(346, 55);
            this.wegBtn.Name = "wegBtn";
            this.wegBtn.Size = new System.Drawing.Size(87, 27);
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
            this.panel2.Location = new System.Drawing.Point(15, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 351);
            this.panel2.TabIndex = 18;
            // 
            // openFile
            // 
            this.openFile.BackColor = System.Drawing.SystemColors.Control;
            this.openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openFile.Location = new System.Drawing.Point(15, 13);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(306, 27);
            this.openFile.TabIndex = 1;
            this.openFile.TabStop = false;
            this.openFile.Text = "Upload";
            this.openFile.UseVisualStyleBackColor = false;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(502, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 10);
            this.button2.TabIndex = 19;
            this.button2.TabStop = false;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(457, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 10);
            this.button1.TabIndex = 11;
            this.button1.TabStop = false;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labTheme
            // 
            this.labTheme.AutoSize = true;
            this.labTheme.Location = new System.Drawing.Point(453, 13);
            this.labTheme.Name = "labTheme";
            this.labTheme.Size = new System.Drawing.Size(43, 13);
            this.labTheme.TabIndex = 20;
            this.labTheme.Text = "Theme:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labZentrum);
            this.panel3.Controls.Add(this.labBruck);
            this.panel3.Controls.Add(this.labKompo);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(15, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 61);
            this.panel3.TabIndex = 22;
            // 
            // labBruck
            // 
            this.labBruck.AutoSize = true;
            this.labBruck.Location = new System.Drawing.Point(88, 29);
            this.labBruck.Name = "labBruck";
            this.labBruck.Size = new System.Drawing.Size(49, 13);
            this.labBruck.TabIndex = 5;
            this.labBruck.Text = "labBruck";
            // 
            // labKompo
            // 
            this.labKompo.AutoSize = true;
            this.labKompo.Location = new System.Drawing.Point(88, 3);
            this.labKompo.Name = "labKompo";
            this.labKompo.Size = new System.Drawing.Size(54, 13);
            this.labKompo.TabIndex = 3;
            this.labKompo.Text = "labKompo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Brücken:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Komponenten:";
            // 
            // generateBtn
            // 
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.Location = new System.Drawing.Point(346, 12);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(87, 28);
            this.generateBtn.TabIndex = 23;
            this.generateBtn.TabStop = false;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(615, 534);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labTheme);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.wegBtn);
            this.Controls.Add(this.Graphen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.distanzenBtn);
            this.Controls.Add(this.panel2);
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
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button distanzenBtn;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labTheme;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labBruck;
        private System.Windows.Forms.Label labArtik;
        private System.Windows.Forms.Label labKompo;
        private System.Windows.Forms.Button generateBtn;
    }
}


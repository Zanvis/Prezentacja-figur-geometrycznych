namespace Projekt2_Piwowarski62024
{
    partial class LaboratoriumNr2
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
            this.components = new System.ComponentModel.Container();
            this.txtNrFigury = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPoprzednia = new System.Windows.Forms.Button();
            this.btnNastepna = new System.Windows.Forms.Button();
            this.btnWylaczPokazFigur = new System.Windows.Forms.Button();
            this.gpbTrybPokazu = new System.Windows.Forms.GroupBox();
            this.rdbManualny = new System.Windows.Forms.RadioButton();
            this.rdbAutomatyczny = new System.Windows.Forms.RadioButton();
            this.btnWlaczPokazFigur = new System.Windows.Forms.Button();
            this.btnPrzesunDoNowegoXY = new System.Windows.Forms.Button();
            this.chlbFiguryGeometryczne = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbTrybPokazu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNrFigury
            // 
            this.txtNrFigury.Enabled = false;
            this.txtNrFigury.Location = new System.Drawing.Point(728, 487);
            this.txtNrFigury.Name = "txtNrFigury";
            this.txtNrFigury.Size = new System.Drawing.Size(68, 20);
            this.txtNrFigury.TabIndex = 33;
            this.txtNrFigury.TextChanged += new System.EventHandler(this.txtNrFigury_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(670, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Indeks (numer) figury geometrycznej";
            // 
            // btnPoprzednia
            // 
            this.btnPoprzednia.Enabled = false;
            this.btnPoprzednia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPoprzednia.Location = new System.Drawing.Point(764, 422);
            this.btnPoprzednia.Name = "btnPoprzednia";
            this.btnPoprzednia.Size = new System.Drawing.Size(117, 41);
            this.btnPoprzednia.TabIndex = 31;
            this.btnPoprzednia.Text = "Poprzednia";
            this.btnPoprzednia.UseVisualStyleBackColor = true;
            this.btnPoprzednia.Click += new System.EventHandler(this.btnPoprzednia_Click);
            // 
            // btnNastepna
            // 
            this.btnNastepna.Enabled = false;
            this.btnNastepna.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNastepna.Location = new System.Drawing.Point(635, 422);
            this.btnNastepna.Name = "btnNastepna";
            this.btnNastepna.Size = new System.Drawing.Size(117, 41);
            this.btnNastepna.TabIndex = 30;
            this.btnNastepna.Text = "Następna";
            this.btnNastepna.UseVisualStyleBackColor = true;
            this.btnNastepna.Click += new System.EventHandler(this.btnNastepna_Click);
            // 
            // btnWylaczPokazFigur
            // 
            this.btnWylaczPokazFigur.Enabled = false;
            this.btnWylaczPokazFigur.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWylaczPokazFigur.Location = new System.Drawing.Point(728, 320);
            this.btnWylaczPokazFigur.Name = "btnWylaczPokazFigur";
            this.btnWylaczPokazFigur.Size = new System.Drawing.Size(153, 78);
            this.btnWylaczPokazFigur.TabIndex = 28;
            this.btnWylaczPokazFigur.Text = "Wyłącz pokaz\r\nfigur geometrycznych";
            this.btnWylaczPokazFigur.UseVisualStyleBackColor = true;
            this.btnWylaczPokazFigur.Click += new System.EventHandler(this.btnWylaczPokazFigur_Click);
            // 
            // gpbTrybPokazu
            // 
            this.gpbTrybPokazu.Controls.Add(this.rdbManualny);
            this.gpbTrybPokazu.Controls.Add(this.rdbAutomatyczny);
            this.gpbTrybPokazu.Enabled = false;
            this.gpbTrybPokazu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpbTrybPokazu.Location = new System.Drawing.Point(199, 429);
            this.gpbTrybPokazu.Name = "gpbTrybPokazu";
            this.gpbTrybPokazu.Size = new System.Drawing.Size(430, 78);
            this.gpbTrybPokazu.TabIndex = 29;
            this.gpbTrybPokazu.TabStop = false;
            this.gpbTrybPokazu.Text = "Tryb pokazu figur geometrycznych";
            // 
            // rdbManualny
            // 
            this.rdbManualny.AutoSize = true;
            this.rdbManualny.Location = new System.Drawing.Point(214, 28);
            this.rdbManualny.Name = "rdbManualny";
            this.rdbManualny.Size = new System.Drawing.Size(176, 23);
            this.rdbManualny.TabIndex = 1;
            this.rdbManualny.Text = "Manualny (przyciskowy)";
            this.rdbManualny.UseVisualStyleBackColor = true;
            this.rdbManualny.CheckedChanged += new System.EventHandler(this.rdbManualny_CheckedChanged);
            // 
            // rdbAutomatyczny
            // 
            this.rdbAutomatyczny.AutoSize = true;
            this.rdbAutomatyczny.Checked = true;
            this.rdbAutomatyczny.Location = new System.Drawing.Point(6, 28);
            this.rdbAutomatyczny.Name = "rdbAutomatyczny";
            this.rdbAutomatyczny.Size = new System.Drawing.Size(185, 23);
            this.rdbAutomatyczny.TabIndex = 0;
            this.rdbAutomatyczny.TabStop = true;
            this.rdbAutomatyczny.Text = "Automatyczny (zegarowy)";
            this.rdbAutomatyczny.UseVisualStyleBackColor = true;
            // 
            // btnWlaczPokazFigur
            // 
            this.btnWlaczPokazFigur.Enabled = false;
            this.btnWlaczPokazFigur.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWlaczPokazFigur.Location = new System.Drawing.Point(28, 422);
            this.btnWlaczPokazFigur.Name = "btnWlaczPokazFigur";
            this.btnWlaczPokazFigur.Size = new System.Drawing.Size(153, 78);
            this.btnWlaczPokazFigur.TabIndex = 27;
            this.btnWlaczPokazFigur.Text = "Włącz pokaz\r\nfigur geometrycznych\r\n";
            this.btnWlaczPokazFigur.UseVisualStyleBackColor = true;
            this.btnWlaczPokazFigur.Click += new System.EventHandler(this.btnWlaczPokazFigur_Click);
            // 
            // btnPrzesunDoNowegoXY
            // 
            this.btnPrzesunDoNowegoXY.Enabled = false;
            this.btnPrzesunDoNowegoXY.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzesunDoNowegoXY.Location = new System.Drawing.Point(31, 205);
            this.btnPrzesunDoNowegoXY.Name = "btnPrzesunDoNowegoXY";
            this.btnPrzesunDoNowegoXY.Size = new System.Drawing.Size(151, 148);
            this.btnPrzesunDoNowegoXY.TabIndex = 26;
            this.btnPrzesunDoNowegoXY.Text = "Przesuń wszystkie figury do \r\nnowego wylosowanego położenia";
            this.btnPrzesunDoNowegoXY.UseVisualStyleBackColor = true;
            this.btnPrzesunDoNowegoXY.Click += new System.EventHandler(this.btnPrzesunDoNowegoXY_Click);
            // 
            // chlbFiguryGeometryczne
            // 
            this.chlbFiguryGeometryczne.FormattingEnabled = true;
            this.chlbFiguryGeometryczne.Items.AddRange(new object[] {
            "Punkt",
            "Linia",
            "Elipsa",
            "Prostokąt",
            "Okrąg",
            "Kwadrat",
            "itd."});
            this.chlbFiguryGeometryczne.Location = new System.Drawing.Point(728, 110);
            this.chlbFiguryGeometryczne.Name = "chlbFiguryGeometryczne";
            this.chlbFiguryGeometryczne.Size = new System.Drawing.Size(142, 124);
            this.chlbFiguryGeometryczne.TabIndex = 25;
            this.chlbFiguryGeometryczne.SelectedIndexChanged += new System.EventHandler(this.chlbFiguryGeometryczne_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(740, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 63);
            this.label2.TabIndex = 24;
            this.label2.Text = "Zaznacz figury\r\ngeometryczne\r\ndo prezentacji";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(68, 135);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 41);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(57, 98);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 22;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 63);
            this.label1.TabIndex = 21;
            this.label1.Text = "Podaj liczbę\r\nfigur geometrycznych\r\ndo prezentacji";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbRysownica
            // 
            this.pbRysownica.BackColor = System.Drawing.Color.LavenderBlush;
            this.pbRysownica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbRysownica.Location = new System.Drawing.Point(188, 87);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(523, 329);
            this.pbRysownica.TabIndex = 20;
            this.pbRysownica.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LaboratoriumNr2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 542);
            this.Controls.Add(this.txtNrFigury);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPoprzednia);
            this.Controls.Add(this.btnNastepna);
            this.Controls.Add(this.btnWylaczPokazFigur);
            this.Controls.Add(this.gpbTrybPokazu);
            this.Controls.Add(this.btnWlaczPokazFigur);
            this.Controls.Add(this.btnPrzesunDoNowegoXY);
            this.Controls.Add(this.chlbFiguryGeometryczne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRysownica);
            this.Name = "LaboratoriumNr2";
            this.Text = "LaboratoriumNr2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LaboratoriumNr2_FormClosing);
            this.Load += new System.EventHandler(this.LaboratoriumNr2_Load);
            this.gpbTrybPokazu.ResumeLayout(false);
            this.gpbTrybPokazu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNrFigury;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPoprzednia;
        private System.Windows.Forms.Button btnNastepna;
        private System.Windows.Forms.Button btnWylaczPokazFigur;
        private System.Windows.Forms.GroupBox gpbTrybPokazu;
        private System.Windows.Forms.RadioButton rdbManualny;
        private System.Windows.Forms.RadioButton rdbAutomatyczny;
        private System.Windows.Forms.Button btnWlaczPokazFigur;
        private System.Windows.Forms.Button btnPrzesunDoNowegoXY;
        private System.Windows.Forms.CheckedListBox chlbFiguryGeometryczne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
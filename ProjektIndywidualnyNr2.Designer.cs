namespace Projekt2_Piwowarski62024
{
    partial class ProjektIndywidualnyNr2
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
            this.btnWylaczPokaz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbAutomatyczny = new System.Windows.Forms.RadioButton();
            this.rdbManualny = new System.Windows.Forms.RadioButton();
            this.btnKolorLinii = new System.Windows.Forms.Button();
            this.btnPokazFigur = new System.Windows.Forms.Button();
            this.btnPrzesunDoNowegoXY = new System.Windows.Forms.Button();
            this.btnCofnijFG = new System.Windows.Forms.Button();
            this.btnPoprzednia = new System.Windows.Forms.Button();
            this.lblY = new System.Windows.Forms.Label();
            this.btnNastepna = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblWspolrzedne = new System.Windows.Forms.Label();
            this.gbWyborKrzywej = new System.Windows.Forms.GroupBox();
            this.lblKatNachylenia = new System.Windows.Forms.Label();
            this.rdbKrzywaKardynalna = new System.Windows.Forms.RadioButton();
            this.numUD_LiczbaStopni = new System.Windows.Forms.NumericUpDown();
            this.rdbKrzywaBeziera = new System.Windows.Forms.RadioButton();
            this.rdbWycinekElipsy = new System.Windows.Forms.RadioButton();
            this.rdbLukElipsy = new System.Windows.Forms.RadioButton();
            this.rdbElipsaWypelniona = new System.Windows.Forms.RadioButton();
            this.lblKatPoczatkowy = new System.Windows.Forms.Label();
            this.lblLiczbaPunktow = new System.Windows.Forms.Label();
            this.numUD_PoczatkowyKat = new System.Windows.Forms.NumericUpDown();
            this.rdbProstokatWypleniony = new System.Windows.Forms.RadioButton();
            this.rdbZamknietaKrzywaKardynalna = new System.Windows.Forms.RadioButton();
            this.rdbKwadrat = new System.Windows.Forms.RadioButton();
            this.rdbWypelnionyWyciekElipsy = new System.Windows.Forms.RadioButton();
            this.rdbProstokat = new System.Windows.Forms.RadioButton();
            this.rdbKolo = new System.Windows.Forms.RadioButton();
            this.rdbOkrag = new System.Windows.Forms.RadioButton();
            this.rdbELipsa = new System.Windows.Forms.RadioButton();
            this.numUD_LiczbaPunktow = new System.Windows.Forms.NumericUpDown();
            this.rdbLiniaProsta = new System.Windows.Forms.RadioButton();
            this.rdbPunkt = new System.Windows.Forms.RadioButton();
            this.rdbWielokatWypelniony = new System.Windows.Forms.RadioButton();
            this.rdbWielokat = new System.Windows.Forms.RadioButton();
            this.lblLiczbaKatow = new System.Windows.Forms.Label();
            this.numUD_LiczbaKatow = new System.Windows.Forms.NumericUpDown();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtNrFigury = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStylLinii = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKolorWypelnienia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWczytajBitMape = new System.Windows.Forms.Button();
            this.btnZapiszBitMape = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gbWyborKrzywej.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_LiczbaStopni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_PoczatkowyKat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_LiczbaPunktow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_LiczbaKatow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWylaczPokaz
            // 
            this.btnWylaczPokaz.Enabled = false;
            this.btnWylaczPokaz.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWylaczPokaz.Location = new System.Drawing.Point(578, 615);
            this.btnWylaczPokaz.Name = "btnWylaczPokaz";
            this.btnWylaczPokaz.Size = new System.Drawing.Size(188, 37);
            this.btnWylaczPokaz.TabIndex = 32;
            this.btnWylaczPokaz.Text = "Wyłącz pokaz";
            this.btnWylaczPokaz.UseVisualStyleBackColor = true;
            this.btnWylaczPokaz.Click += new System.EventHandler(this.btnWylaczPokaz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbAutomatyczny);
            this.groupBox1.Controls.Add(this.rdbManualny);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(184, 627);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 56);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pokaz figur";
            // 
            // rdbAutomatyczny
            // 
            this.rdbAutomatyczny.AutoSize = true;
            this.rdbAutomatyczny.Checked = true;
            this.rdbAutomatyczny.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbAutomatyczny.Location = new System.Drawing.Point(19, 19);
            this.rdbAutomatyczny.Name = "rdbAutomatyczny";
            this.rdbAutomatyczny.Size = new System.Drawing.Size(109, 23);
            this.rdbAutomatyczny.TabIndex = 10;
            this.rdbAutomatyczny.TabStop = true;
            this.rdbAutomatyczny.Text = "automatyczny";
            this.rdbAutomatyczny.UseVisualStyleBackColor = true;
            this.rdbAutomatyczny.CheckedChanged += new System.EventHandler(this.rdbAutomatyczny_CheckedChanged);
            // 
            // rdbManualny
            // 
            this.rdbManualny.AutoSize = true;
            this.rdbManualny.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbManualny.Location = new System.Drawing.Point(158, 19);
            this.rdbManualny.Name = "rdbManualny";
            this.rdbManualny.Size = new System.Drawing.Size(83, 23);
            this.rdbManualny.TabIndex = 11;
            this.rdbManualny.Text = "manualny";
            this.rdbManualny.UseVisualStyleBackColor = true;
            this.rdbManualny.CheckedChanged += new System.EventHandler(this.rdbManualny_CheckedChanged);
            // 
            // btnKolorLinii
            // 
            this.btnKolorLinii.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnKolorLinii.Location = new System.Drawing.Point(17, 51);
            this.btnKolorLinii.Name = "btnKolorLinii";
            this.btnKolorLinii.Size = new System.Drawing.Size(121, 27);
            this.btnKolorLinii.TabIndex = 20;
            this.btnKolorLinii.UseVisualStyleBackColor = false;
            this.btnKolorLinii.Click += new System.EventHandler(this.btnKolorLinii_Click);
            // 
            // btnPokazFigur
            // 
            this.btnPokazFigur.Enabled = false;
            this.btnPokazFigur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPokazFigur.Location = new System.Drawing.Point(12, 631);
            this.btnPokazFigur.Name = "btnPokazFigur";
            this.btnPokazFigur.Size = new System.Drawing.Size(152, 52);
            this.btnPokazFigur.TabIndex = 21;
            this.btnPokazFigur.Text = "Włącz pokaz figur";
            this.btnPokazFigur.UseVisualStyleBackColor = true;
            this.btnPokazFigur.Click += new System.EventHandler(this.btnPokazFigur_Click);
            // 
            // btnPrzesunDoNowegoXY
            // 
            this.btnPrzesunDoNowegoXY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzesunDoNowegoXY.Location = new System.Drawing.Point(844, 12);
            this.btnPrzesunDoNowegoXY.Name = "btnPrzesunDoNowegoXY";
            this.btnPrzesunDoNowegoXY.Size = new System.Drawing.Size(377, 37);
            this.btnPrzesunDoNowegoXY.TabIndex = 30;
            this.btnPrzesunDoNowegoXY.Text = "Przesuń figury geometryczne do nowej lokalizacji";
            this.btnPrzesunDoNowegoXY.UseVisualStyleBackColor = true;
            this.btnPrzesunDoNowegoXY.Click += new System.EventHandler(this.btnPrzesunDoNowegoXY_Click);
            // 
            // btnCofnijFG
            // 
            this.btnCofnijFG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCofnijFG.Location = new System.Drawing.Point(91, 349);
            this.btnCofnijFG.Name = "btnCofnijFG";
            this.btnCofnijFG.Size = new System.Drawing.Size(282, 40);
            this.btnCofnijFG.TabIndex = 29;
            this.btnCofnijFG.Text = "Cofnij (ostatnią figurę)";
            this.btnCofnijFG.UseVisualStyleBackColor = true;
            this.btnCofnijFG.Click += new System.EventHandler(this.btnCofnijFG_Click);
            // 
            // btnPoprzednia
            // 
            this.btnPoprzednia.Enabled = false;
            this.btnPoprzednia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPoprzednia.Location = new System.Drawing.Point(675, 654);
            this.btnPoprzednia.Name = "btnPoprzednia";
            this.btnPoprzednia.Size = new System.Drawing.Size(91, 36);
            this.btnPoprzednia.TabIndex = 23;
            this.btnPoprzednia.Text = "Poprzednia";
            this.btnPoprzednia.UseVisualStyleBackColor = true;
            this.btnPoprzednia.Click += new System.EventHandler(this.btnPoprzednia_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblY.Location = new System.Drawing.Point(455, 33);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(20, 19);
            this.lblY.TabIndex = 28;
            this.lblY.Text = "Y";
            // 
            // btnNastepna
            // 
            this.btnNastepna.Enabled = false;
            this.btnNastepna.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNastepna.Location = new System.Drawing.Point(578, 654);
            this.btnNastepna.Name = "btnNastepna";
            this.btnNastepna.Size = new System.Drawing.Size(91, 36);
            this.btnNastepna.TabIndex = 22;
            this.btnNastepna.Text = "Następna";
            this.btnNastepna.UseVisualStyleBackColor = true;
            this.btnNastepna.Click += new System.EventHandler(this.btnNastepna_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblX.Location = new System.Drawing.Point(412, 33);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 19);
            this.lblX.TabIndex = 27;
            this.lblX.Text = "X";
            // 
            // lblWspolrzedne
            // 
            this.lblWspolrzedne.AutoSize = true;
            this.lblWspolrzedne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWspolrzedne.Location = new System.Drawing.Point(86, 33);
            this.lblWspolrzedne.Name = "lblWspolrzedne";
            this.lblWspolrzedne.Size = new System.Drawing.Size(309, 19);
            this.lblWspolrzedne.TabIndex = 26;
            this.lblWspolrzedne.Text = "Współrzędne (X i Y) aktualnego położenia myszy:";
            // 
            // gbWyborKrzywej
            // 
            this.gbWyborKrzywej.Controls.Add(this.lblKatNachylenia);
            this.gbWyborKrzywej.Controls.Add(this.rdbKrzywaKardynalna);
            this.gbWyborKrzywej.Controls.Add(this.numUD_LiczbaStopni);
            this.gbWyborKrzywej.Controls.Add(this.rdbKrzywaBeziera);
            this.gbWyborKrzywej.Controls.Add(this.rdbWycinekElipsy);
            this.gbWyborKrzywej.Controls.Add(this.rdbLukElipsy);
            this.gbWyborKrzywej.Controls.Add(this.rdbElipsaWypelniona);
            this.gbWyborKrzywej.Controls.Add(this.lblKatPoczatkowy);
            this.gbWyborKrzywej.Controls.Add(this.lblLiczbaPunktow);
            this.gbWyborKrzywej.Controls.Add(this.btnCofnijFG);
            this.gbWyborKrzywej.Controls.Add(this.numUD_PoczatkowyKat);
            this.gbWyborKrzywej.Controls.Add(this.rdbProstokatWypleniony);
            this.gbWyborKrzywej.Controls.Add(this.rdbZamknietaKrzywaKardynalna);
            this.gbWyborKrzywej.Controls.Add(this.rdbKwadrat);
            this.gbWyborKrzywej.Controls.Add(this.rdbWypelnionyWyciekElipsy);
            this.gbWyborKrzywej.Controls.Add(this.rdbProstokat);
            this.gbWyborKrzywej.Controls.Add(this.rdbKolo);
            this.gbWyborKrzywej.Controls.Add(this.rdbOkrag);
            this.gbWyborKrzywej.Controls.Add(this.rdbELipsa);
            this.gbWyborKrzywej.Controls.Add(this.numUD_LiczbaPunktow);
            this.gbWyborKrzywej.Controls.Add(this.rdbLiniaProsta);
            this.gbWyborKrzywej.Controls.Add(this.rdbPunkt);
            this.gbWyborKrzywej.Controls.Add(this.rdbWielokatWypelniony);
            this.gbWyborKrzywej.Controls.Add(this.rdbWielokat);
            this.gbWyborKrzywej.Controls.Add(this.lblLiczbaKatow);
            this.gbWyborKrzywej.Controls.Add(this.numUD_LiczbaKatow);
            this.gbWyborKrzywej.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbWyborKrzywej.Location = new System.Drawing.Point(792, 55);
            this.gbWyborKrzywej.Name = "gbWyborKrzywej";
            this.gbWyborKrzywej.Size = new System.Drawing.Size(494, 389);
            this.gbWyborKrzywej.TabIndex = 25;
            this.gbWyborKrzywej.TabStop = false;
            this.gbWyborKrzywej.Text = "Wybierz figurę lub linię krzywą";
            // 
            // lblKatNachylenia
            // 
            this.lblKatNachylenia.AutoSize = true;
            this.lblKatNachylenia.Enabled = false;
            this.lblKatNachylenia.Location = new System.Drawing.Point(260, 293);
            this.lblKatNachylenia.Name = "lblKatNachylenia";
            this.lblKatNachylenia.Size = new System.Drawing.Size(98, 19);
            this.lblKatNachylenia.TabIndex = 55;
            this.lblKatNachylenia.Text = "Kąt nachylenia";
            // 
            // rdbKrzywaKardynalna
            // 
            this.rdbKrzywaKardynalna.AutoSize = true;
            this.rdbKrzywaKardynalna.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbKrzywaKardynalna.Location = new System.Drawing.Point(19, 200);
            this.rdbKrzywaKardynalna.Name = "rdbKrzywaKardynalna";
            this.rdbKrzywaKardynalna.Size = new System.Drawing.Size(149, 23);
            this.rdbKrzywaKardynalna.TabIndex = 59;
            this.rdbKrzywaKardynalna.Text = "Krzywa Kardynalna";
            this.rdbKrzywaKardynalna.UseVisualStyleBackColor = true;
            this.rdbKrzywaKardynalna.CheckedChanged += new System.EventHandler(this.rdbKrzywaKardynalna_CheckedChanged);
            // 
            // numUD_LiczbaStopni
            // 
            this.numUD_LiczbaStopni.Enabled = false;
            this.numUD_LiczbaStopni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUD_LiczbaStopni.Location = new System.Drawing.Point(282, 315);
            this.numUD_LiczbaStopni.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numUD_LiczbaStopni.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_LiczbaStopni.Name = "numUD_LiczbaStopni";
            this.numUD_LiczbaStopni.Size = new System.Drawing.Size(55, 26);
            this.numUD_LiczbaStopni.TabIndex = 53;
            this.numUD_LiczbaStopni.Value = new decimal(new int[] {
            270,
            0,
            0,
            0});
            // 
            // rdbKrzywaBeziera
            // 
            this.rdbKrzywaBeziera.AutoSize = true;
            this.rdbKrzywaBeziera.Location = new System.Drawing.Point(331, 112);
            this.rdbKrzywaBeziera.Name = "rdbKrzywaBeziera";
            this.rdbKrzywaBeziera.Size = new System.Drawing.Size(124, 23);
            this.rdbKrzywaBeziera.TabIndex = 58;
            this.rdbKrzywaBeziera.Text = "Krzywa Beziera";
            this.rdbKrzywaBeziera.UseVisualStyleBackColor = true;
            this.rdbKrzywaBeziera.CheckedChanged += new System.EventHandler(this.rdbKrzywaBeziera_CheckedChanged);
            // 
            // rdbWycinekElipsy
            // 
            this.rdbWycinekElipsy.AutoSize = true;
            this.rdbWycinekElipsy.Location = new System.Drawing.Point(20, 286);
            this.rdbWycinekElipsy.Name = "rdbWycinekElipsy";
            this.rdbWycinekElipsy.Size = new System.Drawing.Size(118, 23);
            this.rdbWycinekElipsy.TabIndex = 51;
            this.rdbWycinekElipsy.Text = "Wycinek elipsy";
            this.rdbWycinekElipsy.UseVisualStyleBackColor = true;
            this.rdbWycinekElipsy.CheckedChanged += new System.EventHandler(this.rdbWycinekElipsy_CheckedChanged);
            // 
            // rdbLukElipsy
            // 
            this.rdbLukElipsy.AutoSize = true;
            this.rdbLukElipsy.Location = new System.Drawing.Point(19, 315);
            this.rdbLukElipsy.Name = "rdbLukElipsy";
            this.rdbLukElipsy.Size = new System.Drawing.Size(89, 23);
            this.rdbLukElipsy.TabIndex = 57;
            this.rdbLukElipsy.Text = "Łuk elipsy";
            this.rdbLukElipsy.UseVisualStyleBackColor = true;
            this.rdbLukElipsy.CheckedChanged += new System.EventHandler(this.rdbLukElipsy_CheckedChanged);
            // 
            // rdbElipsaWypelniona
            // 
            this.rdbElipsaWypelniona.AutoSize = true;
            this.rdbElipsaWypelniona.Location = new System.Drawing.Point(331, 170);
            this.rdbElipsaWypelniona.Name = "rdbElipsaWypelniona";
            this.rdbElipsaWypelniona.Size = new System.Drawing.Size(135, 23);
            this.rdbElipsaWypelniona.TabIndex = 50;
            this.rdbElipsaWypelniona.Text = "Elipsa wypełniona";
            this.rdbElipsaWypelniona.UseVisualStyleBackColor = true;
            // 
            // lblKatPoczatkowy
            // 
            this.lblKatPoczatkowy.AutoSize = true;
            this.lblKatPoczatkowy.Enabled = false;
            this.lblKatPoczatkowy.Location = new System.Drawing.Point(144, 291);
            this.lblKatPoczatkowy.Name = "lblKatPoczatkowy";
            this.lblKatPoczatkowy.Size = new System.Drawing.Size(110, 19);
            this.lblKatPoczatkowy.TabIndex = 54;
            this.lblKatPoczatkowy.Text = "Kąt początkowy";
            // 
            // lblLiczbaPunktow
            // 
            this.lblLiczbaPunktow.AutoSize = true;
            this.lblLiczbaPunktow.Enabled = false;
            this.lblLiczbaPunktow.Location = new System.Drawing.Point(208, 202);
            this.lblLiczbaPunktow.Name = "lblLiczbaPunktow";
            this.lblLiczbaPunktow.Size = new System.Drawing.Size(106, 19);
            this.lblLiczbaPunktow.TabIndex = 61;
            this.lblLiczbaPunktow.Text = "Liczba punktów";
            // 
            // numUD_PoczatkowyKat
            // 
            this.numUD_PoczatkowyKat.Enabled = false;
            this.numUD_PoczatkowyKat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUD_PoczatkowyKat.Location = new System.Drawing.Point(171, 315);
            this.numUD_PoczatkowyKat.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numUD_PoczatkowyKat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_PoczatkowyKat.Name = "numUD_PoczatkowyKat";
            this.numUD_PoczatkowyKat.Size = new System.Drawing.Size(55, 26);
            this.numUD_PoczatkowyKat.TabIndex = 52;
            this.numUD_PoczatkowyKat.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // rdbProstokatWypleniony
            // 
            this.rdbProstokatWypleniony.AutoSize = true;
            this.rdbProstokatWypleniony.Location = new System.Drawing.Point(331, 83);
            this.rdbProstokatWypleniony.Name = "rdbProstokatWypleniony";
            this.rdbProstokatWypleniony.Size = new System.Drawing.Size(158, 23);
            this.rdbProstokatWypleniony.TabIndex = 48;
            this.rdbProstokatWypleniony.Text = "Prostokąt wypełniony";
            this.rdbProstokatWypleniony.UseVisualStyleBackColor = true;
            // 
            // rdbZamknietaKrzywaKardynalna
            // 
            this.rdbZamknietaKrzywaKardynalna.AutoSize = true;
            this.rdbZamknietaKrzywaKardynalna.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbZamknietaKrzywaKardynalna.Location = new System.Drawing.Point(19, 229);
            this.rdbZamknietaKrzywaKardynalna.Name = "rdbZamknietaKrzywaKardynalna";
            this.rdbZamknietaKrzywaKardynalna.Size = new System.Drawing.Size(208, 23);
            this.rdbZamknietaKrzywaKardynalna.TabIndex = 62;
            this.rdbZamknietaKrzywaKardynalna.Text = "Zamknięta krzywa kardynalna";
            this.rdbZamknietaKrzywaKardynalna.UseVisualStyleBackColor = true;
            this.rdbZamknietaKrzywaKardynalna.CheckedChanged += new System.EventHandler(this.rdbZamknietaKrzywaKardynalna_CheckedChanged);
            // 
            // rdbKwadrat
            // 
            this.rdbKwadrat.AutoSize = true;
            this.rdbKwadrat.Location = new System.Drawing.Point(19, 112);
            this.rdbKwadrat.Name = "rdbKwadrat";
            this.rdbKwadrat.Size = new System.Drawing.Size(81, 23);
            this.rdbKwadrat.TabIndex = 6;
            this.rdbKwadrat.Text = "Kwadrat";
            this.rdbKwadrat.UseVisualStyleBackColor = true;
            // 
            // rdbWypelnionyWyciekElipsy
            // 
            this.rdbWypelnionyWyciekElipsy.AutoSize = true;
            this.rdbWypelnionyWyciekElipsy.Location = new System.Drawing.Point(19, 258);
            this.rdbWypelnionyWyciekElipsy.Name = "rdbWypelnionyWyciekElipsy";
            this.rdbWypelnionyWyciekElipsy.Size = new System.Drawing.Size(190, 23);
            this.rdbWypelnionyWyciekElipsy.TabIndex = 56;
            this.rdbWypelnionyWyciekElipsy.Text = "Wypełniony wycinek elipsy";
            this.rdbWypelnionyWyciekElipsy.UseVisualStyleBackColor = true;
            this.rdbWypelnionyWyciekElipsy.CheckedChanged += new System.EventHandler(this.rdbWypelnionyWyciekElipsy_CheckedChanged);
            // 
            // rdbProstokat
            // 
            this.rdbProstokat.AutoSize = true;
            this.rdbProstokat.Location = new System.Drawing.Point(331, 54);
            this.rdbProstokat.Name = "rdbProstokat";
            this.rdbProstokat.Size = new System.Drawing.Size(86, 23);
            this.rdbProstokat.TabIndex = 5;
            this.rdbProstokat.Text = "Prostokąt";
            this.rdbProstokat.UseVisualStyleBackColor = true;
            // 
            // rdbKolo
            // 
            this.rdbKolo.AutoSize = true;
            this.rdbKolo.Location = new System.Drawing.Point(19, 83);
            this.rdbKolo.Name = "rdbKolo";
            this.rdbKolo.Size = new System.Drawing.Size(58, 23);
            this.rdbKolo.TabIndex = 4;
            this.rdbKolo.Text = "Koło";
            this.rdbKolo.UseVisualStyleBackColor = true;
            // 
            // rdbOkrag
            // 
            this.rdbOkrag.AutoSize = true;
            this.rdbOkrag.Location = new System.Drawing.Point(331, 25);
            this.rdbOkrag.Name = "rdbOkrag";
            this.rdbOkrag.Size = new System.Drawing.Size(66, 23);
            this.rdbOkrag.TabIndex = 3;
            this.rdbOkrag.Text = "Okrąg";
            this.rdbOkrag.UseVisualStyleBackColor = true;
            // 
            // rdbELipsa
            // 
            this.rdbELipsa.AutoSize = true;
            this.rdbELipsa.Location = new System.Drawing.Point(331, 141);
            this.rdbELipsa.Name = "rdbELipsa";
            this.rdbELipsa.Size = new System.Drawing.Size(63, 23);
            this.rdbELipsa.TabIndex = 2;
            this.rdbELipsa.Text = "Elipsa";
            this.rdbELipsa.UseVisualStyleBackColor = true;
            // 
            // numUD_LiczbaPunktow
            // 
            this.numUD_LiczbaPunktow.Enabled = false;
            this.numUD_LiczbaPunktow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUD_LiczbaPunktow.Location = new System.Drawing.Point(233, 226);
            this.numUD_LiczbaPunktow.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUD_LiczbaPunktow.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numUD_LiczbaPunktow.Name = "numUD_LiczbaPunktow";
            this.numUD_LiczbaPunktow.Size = new System.Drawing.Size(55, 26);
            this.numUD_LiczbaPunktow.TabIndex = 60;
            this.numUD_LiczbaPunktow.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // rdbLiniaProsta
            // 
            this.rdbLiniaProsta.AutoSize = true;
            this.rdbLiniaProsta.Location = new System.Drawing.Point(19, 54);
            this.rdbLiniaProsta.Name = "rdbLiniaProsta";
            this.rdbLiniaProsta.Size = new System.Drawing.Size(98, 23);
            this.rdbLiniaProsta.TabIndex = 1;
            this.rdbLiniaProsta.Text = "Linia prosta";
            this.rdbLiniaProsta.UseVisualStyleBackColor = true;
            // 
            // rdbPunkt
            // 
            this.rdbPunkt.AutoSize = true;
            this.rdbPunkt.Checked = true;
            this.rdbPunkt.Location = new System.Drawing.Point(19, 25);
            this.rdbPunkt.Name = "rdbPunkt";
            this.rdbPunkt.Size = new System.Drawing.Size(62, 23);
            this.rdbPunkt.TabIndex = 0;
            this.rdbPunkt.TabStop = true;
            this.rdbPunkt.Text = "Punkt";
            this.rdbPunkt.UseVisualStyleBackColor = true;
            // 
            // rdbWielokatWypelniony
            // 
            this.rdbWielokatWypelniony.AutoSize = true;
            this.rdbWielokatWypelniony.Location = new System.Drawing.Point(19, 141);
            this.rdbWielokatWypelniony.Name = "rdbWielokatWypelniony";
            this.rdbWielokatWypelniony.Size = new System.Drawing.Size(153, 23);
            this.rdbWielokatWypelniony.TabIndex = 49;
            this.rdbWielokatWypelniony.Text = "Wielokąt wypełniony";
            this.rdbWielokatWypelniony.UseVisualStyleBackColor = true;
            this.rdbWielokatWypelniony.CheckedChanged += new System.EventHandler(this.rdbWielokatWypelniony_CheckedChanged);
            // 
            // rdbWielokat
            // 
            this.rdbWielokat.AutoSize = true;
            this.rdbWielokat.Location = new System.Drawing.Point(19, 170);
            this.rdbWielokat.Name = "rdbWielokat";
            this.rdbWielokat.Size = new System.Drawing.Size(134, 23);
            this.rdbWielokat.TabIndex = 9;
            this.rdbWielokat.Text = "Wielokąt foremny";
            this.rdbWielokat.UseVisualStyleBackColor = true;
            this.rdbWielokat.CheckedChanged += new System.EventHandler(this.rdbWielokat_CheckedChanged);
            // 
            // lblLiczbaKatow
            // 
            this.lblLiczbaKatow.AutoSize = true;
            this.lblLiczbaKatow.Enabled = false;
            this.lblLiczbaKatow.Location = new System.Drawing.Point(178, 141);
            this.lblLiczbaKatow.Name = "lblLiczbaKatow";
            this.lblLiczbaKatow.Size = new System.Drawing.Size(91, 19);
            this.lblLiczbaKatow.TabIndex = 7;
            this.lblLiczbaKatow.Text = "Liczba kątów";
            // 
            // numUD_LiczbaKatow
            // 
            this.numUD_LiczbaKatow.Enabled = false;
            this.numUD_LiczbaKatow.Location = new System.Drawing.Point(199, 163);
            this.numUD_LiczbaKatow.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUD_LiczbaKatow.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numUD_LiczbaKatow.Name = "numUD_LiczbaKatow";
            this.numUD_LiczbaKatow.Size = new System.Drawing.Size(55, 26);
            this.numUD_LiczbaKatow.TabIndex = 8;
            this.numUD_LiczbaKatow.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // pbRysownica
            // 
            this.pbRysownica.BackColor = System.Drawing.Color.LavenderBlush;
            this.pbRysownica.Location = new System.Drawing.Point(12, 55);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(774, 550);
            this.pbRysownica.TabIndex = 24;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseDown);
            this.pbRysownica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseMove);
            this.pbRysownica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtNrFigury
            // 
            this.txtNrFigury.Enabled = false;
            this.txtNrFigury.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNrFigury.Location = new System.Drawing.Point(508, 654);
            this.txtNrFigury.Margin = new System.Windows.Forms.Padding(2);
            this.txtNrFigury.Multiline = true;
            this.txtNrFigury.Name = "txtNrFigury";
            this.txtNrFigury.Size = new System.Drawing.Size(31, 32);
            this.txtNrFigury.TabIndex = 33;
            this.txtNrFigury.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNrFigury.TextChanged += new System.EventHandler(this.txtNrFigury_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Kolor linii";
            // 
            // cmbStylLinii
            // 
            this.cmbStylLinii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbStylLinii.FormattingEnabled = true;
            this.cmbStylLinii.Items.AddRange(new object[] {
            "Kropkowa",
            "Kreskowa",
            "KreskowoKropkowa",
            "KreskowoKropkowaKropkowa",
            "Ciągła"});
            this.cmbStylLinii.Location = new System.Drawing.Point(180, 28);
            this.cmbStylLinii.Name = "cmbStylLinii";
            this.cmbStylLinii.Size = new System.Drawing.Size(211, 24);
            this.cmbStylLinii.TabIndex = 35;
            this.cmbStylLinii.Text = "Wybierz styl linii";
            this.cmbStylLinii.SelectedIndexChanged += new System.EventHandler(this.cmbStylLinii_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(180, 100);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(218, 45);
            this.trackBar1.TabIndex = 36;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(214, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ustaw grubość linii";
            // 
            // btnKolorWypelnienia
            // 
            this.btnKolorWypelnienia.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnKolorWypelnienia.Location = new System.Drawing.Point(17, 128);
            this.btnKolorWypelnienia.Name = "btnKolorWypelnienia";
            this.btnKolorWypelnienia.Size = new System.Drawing.Size(121, 27);
            this.btnKolorWypelnienia.TabIndex = 38;
            this.btnKolorWypelnienia.UseVisualStyleBackColor = false;
            this.btnKolorWypelnienia.Click += new System.EventHandler(this.btnKolorWypelnienia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(14, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Kolor wypełnienia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(478, 617);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 40;
            this.label4.Text = "Numer figury\r\n(indeks)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnWczytajBitMape
            // 
            this.btnWczytajBitMape.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWczytajBitMape.Location = new System.Drawing.Point(1028, 656);
            this.btnWczytajBitMape.Name = "btnWczytajBitMape";
            this.btnWczytajBitMape.Size = new System.Drawing.Size(192, 30);
            this.btnWczytajBitMape.TabIndex = 41;
            this.btnWczytajBitMape.Text = "Wczytaj bitmape z pliku";
            this.btnWczytajBitMape.UseVisualStyleBackColor = true;
            this.btnWczytajBitMape.Click += new System.EventHandler(this.btnWczytajBitMape_Click);
            // 
            // btnZapiszBitMape
            // 
            this.btnZapiszBitMape.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapiszBitMape.Location = new System.Drawing.Point(826, 657);
            this.btnZapiszBitMape.Name = "btnZapiszBitMape";
            this.btnZapiszBitMape.Size = new System.Drawing.Size(192, 30);
            this.btnZapiszBitMape.TabIndex = 42;
            this.btnZapiszBitMape.Text = "Zapisz bitmape w pliku";
            this.btnZapiszBitMape.UseVisualStyleBackColor = true;
            this.btnZapiszBitMape.Click += new System.EventHandler(this.btnZapiszBitMape_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnKolorLinii);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnKolorWypelnienia);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbStylLinii);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Location = new System.Drawing.Point(811, 450);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 186);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atrybuty graficzne";
            // 
            // ProjektIndywidualnyNr2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 706);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnZapiszBitMape);
            this.Controls.Add(this.btnWczytajBitMape);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNrFigury);
            this.Controls.Add(this.btnWylaczPokaz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPokazFigur);
            this.Controls.Add(this.btnPrzesunDoNowegoXY);
            this.Controls.Add(this.btnPoprzednia);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.btnNastepna);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblWspolrzedne);
            this.Controls.Add(this.gbWyborKrzywej);
            this.Controls.Add(this.pbRysownica);
            this.Name = "ProjektIndywidualnyNr2";
            this.Text = "ProjektIndywidualnyNr2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjektIndywidualnyNr2_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbWyborKrzywej.ResumeLayout(false);
            this.gbWyborKrzywej.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_LiczbaStopni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_PoczatkowyKat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_LiczbaPunktow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_LiczbaKatow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWylaczPokaz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbAutomatyczny;
        private System.Windows.Forms.RadioButton rdbManualny;
        private System.Windows.Forms.Button btnKolorLinii;
        private System.Windows.Forms.Button btnPokazFigur;
        private System.Windows.Forms.Button btnPrzesunDoNowegoXY;
        private System.Windows.Forms.Button btnCofnijFG;
        private System.Windows.Forms.Button btnPoprzednia;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button btnNastepna;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblWspolrzedne;
        private System.Windows.Forms.GroupBox gbWyborKrzywej;
        private System.Windows.Forms.RadioButton rdbWielokat;
        private System.Windows.Forms.NumericUpDown numUD_LiczbaKatow;
        private System.Windows.Forms.Label lblLiczbaKatow;
        private System.Windows.Forms.RadioButton rdbKwadrat;
        private System.Windows.Forms.RadioButton rdbProstokat;
        private System.Windows.Forms.RadioButton rdbKolo;
        private System.Windows.Forms.RadioButton rdbOkrag;
        private System.Windows.Forms.RadioButton rdbELipsa;
        private System.Windows.Forms.RadioButton rdbLiniaProsta;
        private System.Windows.Forms.RadioButton rdbPunkt;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rdbProstokatWypleniony;
        private System.Windows.Forms.RadioButton rdbWielokatWypelniony;
        private System.Windows.Forms.TextBox txtNrFigury;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton rdbElipsaWypelniona;
        private System.Windows.Forms.RadioButton rdbWycinekElipsy;
        private System.Windows.Forms.Label lblKatNachylenia;
        private System.Windows.Forms.Label lblKatPoczatkowy;
        private System.Windows.Forms.NumericUpDown numUD_LiczbaStopni;
        private System.Windows.Forms.RadioButton rdbWypelnionyWyciekElipsy;
        private System.Windows.Forms.RadioButton rdbLukElipsy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStylLinii;
        private System.Windows.Forms.NumericUpDown numUD_PoczatkowyKat;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKolorWypelnienia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnZapiszBitMape;
        private System.Windows.Forms.Button btnWczytajBitMape;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbKrzywaBeziera;
        private System.Windows.Forms.Label lblLiczbaPunktow;
        private System.Windows.Forms.NumericUpDown numUD_LiczbaPunktow;
        private System.Windows.Forms.RadioButton rdbKrzywaKardynalna;
        private System.Windows.Forms.RadioButton rdbZamknietaKrzywaKardynalna;
    }
}
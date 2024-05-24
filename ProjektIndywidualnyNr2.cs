using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projekt2_Piwowarski62024.FiguryGeometryczne2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projekt2_Piwowarski62024
{
    public partial class ProjektIndywidualnyNr2 : Form
    {
        Graphics apRysownica;
        Graphics apRysownicaTymczasowa;
        Pen apPioro;
        Pen apPioroTymczasowe;
        Point apPunkt = Point.Empty;
        List<Punkt> apLFG = new List<Punkt>();
        int apIndexLFG = 0;
        const int apMargines = 10;
        Color apKolor = Color.LightSkyBlue;
        Color apKolorWypelnienia = Color.LightSeaGreen;
        DashStyle apStylLinii;
        float apGruboscLinii = 0.8f;

        public ProjektIndywidualnyNr2()
        {
            InitializeComponent();
            // "podpięcie" BitMapy do kontrolki PictureBox
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            // utworzenie egzemplarza powierzchni graficznej
            apRysownica = Graphics.FromImage(pbRysownica.Image);
            // utworzenie egzemplarza tymczasowej powierzchni graficznej na przezroczystej powierzchni PictureBox
            apRysownicaTymczasowa = pbRysownica.CreateGraphics();
            // utworzenie egzemplarza Pióra tymczasowego
            apPioroTymczasowe = new Pen(Color.Black, 1.0f);
            // utworzenie egzemplarza Pióra i jego sformatowanie
            apPioro = new Pen(Color.Red, 1.7f);
            apPioro.DashStyle = DashStyle.Dash;
            apPioro.StartCap = LineCap.Round;
            apPioro.EndCap = LineCap.Round;
        }

        struct apOpisKrzywejBeziera
        {
            public Point apPunktP0;
            public Point apPunktP1;
            public Point apPunktP2;
            public Point apPunktP3;
            public ushort apNumerPunktuKontrolnego;
        }
        // deklaracja zmiennej dla KrzywejBeziera
        apOpisKrzywejBeziera apKrzywaBeziera;

        struct apOpisKrzywejKardynalnej
        {
            public ushort apLiczbaPunktow;
            public ushort apNumerPunktuKrzywej;
            public Point[] apPunktyKrzywej;
        }
        // deklaracja zmiennej dla KrzywejKardynalnej
        apOpisKrzywejKardynalnej apKrzywaKardynalna;

        private void ProjektIndywidualnyNr2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // utworzenie okna dialogowego dla potwierdzenia zamknięcia formularza indywidualnego
            DialogResult apOknoMessage = MessageBox.Show("Czy na pewno chcesz zamknąć ten formularz i przejść do formularza głównego?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            // rozpoznanie wybranej odpowiedzi Użytkownika programu
            if (apOknoMessage == DialogResult.Yes)
            {
                e.Cancel = false;
                // odszukanie egzemplarza formularza głównego w kolekcji OpenForms 
                foreach (Form apFormularz in Application.OpenForms)
                    // sprawdzamy, czy został znaleziony formularz główny
                    if (apFormularz.Name == "KokpitProjektuNr2Piwowarski")
                    {// ukrycie bieżącego formularza 
                        this.Hide();
                        // odsłonięcie znalezionego głównego formularza
                        apFormularz.Show();
                        // wyjście z metody obsługi zdarzenia FormClosing
                        return;
                    }
                // gdy będziemy tutaj, to będzie to oznaczało, że ktoś skasował formularz główny
                // utworzenie nowego egzemplarza formularza głównego KokpitProjektuNr2Piwowarski
                KokpitProjektuNr2Piwowarski apFormularzKokpitProjektuNr2Piwowarski = new KokpitProjektuNr2Piwowarski();
                // ukrycie bieżącego formularza 
                this.Hide();
                // odsłonięcie nowego formularza głównego
                this.Show();
            }
            else // anulujemy zmaknięcie formularza
                e.Cancel = true;
        }

        private void pbRysownica_MouseDown(object sender, MouseEventArgs e)
        {
            // wizualizacja współrzędnych aktualnego połóżenia myszy
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            // sprawdzenie czy zdarzenie MouseDown zostało spowodowane naciśnięciem lewego przycisku myszy
            if (e.Button == MouseButtons.Left)
            {
                // tak, to zapamiętamy aktualne połóżenie Myszy
                apPunkt = e.Location;
            }
        }

        private void pbRysownica_MouseMove(object sender, MouseEventArgs e)
        {
            //wizualizacja współrzędnych aktualnego połóżenia myszy
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();

            // ustalenie położenia i rozmiarów prostokąta, w którym będzie wkreślana figura
            int apLewyGornyNaroznikX = (apPunkt.X > e.Location.X) ? e.Location.X : apPunkt.X;
            int apLewyGornyNaroznikY = (apPunkt.Y > e.Location.Y) ? e.Location.Y : apPunkt.Y;
            int apSzerokosc = Math.Abs(apPunkt.X - e.Location.X);
            int apWysokosc = Math.Abs(apPunkt.Y - e.Location.Y);

            if (e.Button == MouseButtons.Left)
            {
                if (rdbLiniaProsta.Checked)
                {
                    apRysownicaTymczasowa.DrawLine(apPioroTymczasowe, apPunkt.X, apPunkt.Y, e.Location.X, e.Location.Y);
                }
                if (rdbProstokat.Checked)
                {
                    apRysownicaTymczasowa.DrawRectangle(apPioroTymczasowe, apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apWysokosc);
                }
                if (rdbKwadrat.Checked)
                {
                    apRysownicaTymczasowa.DrawRectangle(apPioroTymczasowe, apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apSzerokosc);
                }
                if (rdbELipsa.Checked)
                {
                    apRysownicaTymczasowa.DrawEllipse(apPioroTymczasowe, apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apWysokosc);
                }
                if (rdbOkrag.Checked)
                {
                    apRysownicaTymczasowa.DrawEllipse(apPioroTymczasowe, apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apSzerokosc);
                }
                if (rdbKolo.Checked)
                {
                    apRysownicaTymczasowa.DrawEllipse(apPioroTymczasowe, apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apSzerokosc);
                }
                if (rdbProstokatWypleniony.Checked)
                {
                    apRysownicaTymczasowa.DrawRectangle(apPioroTymczasowe, apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apWysokosc);
                }
                if (rdbWielokat.Checked)
                {
                    ushort apStopienWielokata = (ushort)numUD_LiczbaKatow.Value;
                    int R = apSzerokosc;
                    double apKatMiedzyWierzcholkami = 360.0 / apStopienWielokata;
                    double apKatPolozeniaPierwszegoWierzcholka = 0.0;
                    Point[] apWierzcholkiWielokata = new Point[apStopienWielokata];
                    // wyznaczenie współrzędnych wierzchołków wielokąta 
                    for (int i = 0; i < apStopienWielokata; i++)
                    {
                        apWierzcholkiWielokata[i].X = apLewyGornyNaroznikX + (int)(R * Math.Cos(Math.PI * (apKatPolozeniaPierwszegoWierzcholka + i * apKatMiedzyWierzcholkami) / 180.0));
                        apWierzcholkiWielokata[i].Y = apLewyGornyNaroznikY - (int)(R * Math.Sin(Math.PI * (apKatPolozeniaPierwszegoWierzcholka + i * apKatMiedzyWierzcholkami) / 180.0));
                    }
                    // wykreślenie wielokąta
                    apRysownicaTymczasowa.DrawPolygon(apPioroTymczasowe, apWierzcholkiWielokata);
                }
                if (rdbWielokatWypelniony.Checked)
                {
                    ushort apStopienWielokata = (ushort)numUD_LiczbaKatow.Value;
                    int R = apSzerokosc;
                    double apKatMiedzyWierzcholkami = 360.0 / apStopienWielokata;
                    double apKatPolozeniaPierwszegoWierzcholka = 0.0;
                    Point[] apWierzcholkiWielokata = new Point[apStopienWielokata];
                    // wyznaczenie współrzędnych wierzchołków wielokąta 
                    for (int i = 0; i < apStopienWielokata; i++)
                    {
                        apWierzcholkiWielokata[i].X = apLewyGornyNaroznikX + (int)(R * Math.Cos(Math.PI * (apKatPolozeniaPierwszegoWierzcholka + i * apKatMiedzyWierzcholkami) / 180.0));
                        apWierzcholkiWielokata[i].Y = apLewyGornyNaroznikY - (int)(R * Math.Sin(Math.PI * (apKatPolozeniaPierwszegoWierzcholka + i * apKatMiedzyWierzcholkami) / 180.0));
                    }
                    // wykreślenie wielokąta
                    apRysownicaTymczasowa.DrawPolygon(apPioroTymczasowe, apWierzcholkiWielokata);
                }
                if (rdbElipsaWypelniona.Checked)
                {
                    apRysownicaTymczasowa.DrawEllipse(apPioroTymczasowe, apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apWysokosc);
                }
                if (rdbWycinekElipsy.Checked)
                {
                    // zapisanie kątów podanych przez użytkownika
                    int apPoczatkowyKat = (int)numUD_PoczatkowyKat.Value;
                    int apLiczbaStopni = (int)numUD_LiczbaStopni.Value;
                    // zabezpieczenie przed błędem
                    try
                    {
                        // wykreślenie wycinka elipsy
                        apRysownicaTymczasowa.DrawPie(apPioroTymczasowe, apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apWysokosc, apPoczatkowyKat, apLiczbaStopni);

                    }
                    catch (ArgumentException) { }
                }
                if (rdbWypelnionyWyciekElipsy.Checked)
                {
                    // zapisanie kątów podanych przez użytkownika
                    int apPoczatkowyKat = (int)numUD_PoczatkowyKat.Value;
                    int apLiczbaStopni = (int)numUD_LiczbaStopni.Value;
                    // zabezpieczenie przed błędem
                    try
                    {
                        // wykreślenie wycinka elipsy
                        apRysownicaTymczasowa.DrawPie(apPioroTymczasowe, apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apWysokosc, apPoczatkowyKat, apLiczbaStopni);
                    }
                    catch (ArgumentException) { }
                }
                if (rdbLukElipsy.Checked)
                {
                    // zapisanie kątów podanych przez użytkownika
                    int apPoczatkowyKat = (int)numUD_PoczatkowyKat.Value;
                    int apLiczbaStopni = (int)numUD_LiczbaStopni.Value;
                    // zabezpieczenie przed błędem
                    try
                    {
                        // wykreślenie łuku elipsy
                        apRysownicaTymczasowa.DrawArc(apPioroTymczasowe, apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apWysokosc, apPoczatkowyKat, apLiczbaStopni);
                    }
                    catch (ArgumentException) { }
                }
            }
            pbRysownica.Refresh();
        }

        private void pbRysownica_MouseUp(object sender, MouseEventArgs e)
        {
            // wizualizacja współrzędnych aktualnego połóżenia myszy
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            // ustalenie położenia i rozmiarów prostokąta, w którym będzie wkreślana figura
            int apLewyGornyNaroznikX = (apPunkt.X > e.Location.X) ? e.Location.X : apPunkt.X;
            int apLewyGornyNaroznikY = (apPunkt.Y > e.Location.Y) ? e.Location.Y : apPunkt.Y;
            int apSzerokosc = Math.Abs(apPunkt.X - e.Location.X);
            int apWysokosc = Math.Abs(apPunkt.Y - e.Location.Y);

            // sprawdzenie czy zdarzenie MouseUp zostało spowodowane zwolnieniem lewego przycisku myszy 
            if (e.Button == MouseButtons.Left)
            {
                btnPokazFigur.Enabled = true;
                groupBox1.Enabled = true;
                // rysowanie wszystkich figur i linii krzywych
                if (rdbPunkt.Checked)
                {
                    apLFG.Add(new Punkt(apPunkt.X - 2, apPunkt.Y - 2, apKolor));
                    apLFG[apIndexLFG].Wykresl(apRysownica);
                    apIndexLFG++;
                }
                if (rdbLiniaProsta.Checked)
                {
                    apLFG.Add(new Linia(apPunkt.X, apPunkt.Y, e.Location.X, e.Location.Y, apKolor, apStylLinii, apGruboscLinii));
                    apLFG[apIndexLFG].Wykresl(apRysownica);
                    apIndexLFG++;
                }
                if (rdbProstokat.Checked)
                {
                    apLFG.Add(new Prostokat(apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apWysokosc, apKolor, apStylLinii, apGruboscLinii));
                    apLFG[apIndexLFG].Wykresl(apRysownica);
                    apIndexLFG++;
                }
                if (rdbKwadrat.Checked)
                {
                    apLFG.Add(new Kwadrat(apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apSzerokosc, apKolor, apStylLinii, apGruboscLinii));
                    apLFG[apIndexLFG].Wykresl(apRysownica);
                    apIndexLFG++;
                }
                if (rdbELipsa.Checked)
                {
                    apLFG.Add(new Elipsa(apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apWysokosc, apKolor, apStylLinii, apGruboscLinii));
                    apLFG[apIndexLFG].Wykresl(apRysownica);
                    apIndexLFG++;
                }
                if (rdbOkrag.Checked)
                {
                    apLFG.Add(new Okrag(apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apSzerokosc, apKolor, apStylLinii, apGruboscLinii));
                    apLFG[apIndexLFG].Wykresl(apRysownica);
                    apIndexLFG++;
                }
                if (rdbKolo.Checked)
                {
                    apLFG.Add(new Kolo(apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apSzerokosc, apKolorWypelnienia, apStylLinii, apGruboscLinii));
                    apLFG[apIndexLFG].Wykresl(apRysownica);
                    apIndexLFG++;
                }
                if (rdbProstokatWypleniony.Checked)
                {
                    apLFG.Add(new ProstokatWypelniony(apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apWysokosc, apKolorWypelnienia, apStylLinii, apGruboscLinii));
                    apLFG[apIndexLFG].Wykresl(apRysownica);
                    apIndexLFG++;
                }
                if (rdbWielokat.Checked)
                {
                    ushort apStopienWielokata = (ushort)numUD_LiczbaKatow.Value;
                    apLFG.Add(new Wielokat(apLewyGornyNaroznikX, apLewyGornyNaroznikY, apStopienWielokata, apSzerokosc, apKolor, apStylLinii, apGruboscLinii));
                    apLFG[apIndexLFG].Wykresl(apRysownica);
                    apIndexLFG++;
                }
                if (rdbWielokatWypelniony.Checked)
                {
                    ushort apStopienWielokata = (ushort)numUD_LiczbaKatow.Value;
                    apLFG.Add(new WielokatWypelniony(apLewyGornyNaroznikX, apLewyGornyNaroznikY, apStopienWielokata, apSzerokosc, apKolorWypelnienia, apStylLinii, apGruboscLinii));
                    apLFG[apIndexLFG].Wykresl(apRysownica);
                    apIndexLFG++;
                }
                if (rdbElipsaWypelniona.Checked)
                {
                    apLFG.Add(new ElipsaWypelniona(apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apWysokosc, apKolorWypelnienia, apStylLinii, apGruboscLinii));
                    apLFG[apIndexLFG].Wykresl(apRysownica);
                    apIndexLFG++;
                }
                if (rdbWycinekElipsy.Checked)
                {
                    // zapisanie kątów podanych przez użytkownika
                    int apPoczatkowyKat = (int)numUD_PoczatkowyKat.Value;
                    int apLiczbaStopni = (int)numUD_LiczbaStopni.Value;
                    // zabezpieczenie przed błędem
                    try
                    {
                        // wykreślenie wycinka elipsy
                        apLFG.Add(new WycinekELipsy(apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apWysokosc, apPoczatkowyKat, apLiczbaStopni, apKolor, apStylLinii, apGruboscLinii));
                        apLFG[apIndexLFG].Wykresl(apRysownica);
                        apIndexLFG++;

                    }
                    catch (ArgumentException) { }
                }
                if (rdbWypelnionyWyciekElipsy.Checked)
                {
                    // zapisanie kątów podanych przez użytkownika
                    int apPoczatkowyKat = (int)numUD_PoczatkowyKat.Value;
                    int apLiczbaStopni = (int)numUD_LiczbaStopni.Value;
                    // zabezpieczenie przed błędem
                    try
                    {
                        // wykreślenie wycinka elipsy
                        apLFG.Add(new WypelnionyWycinekElipsy(apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apWysokosc, apPoczatkowyKat, apLiczbaStopni, apKolorWypelnienia, apStylLinii, apGruboscLinii));
                        apLFG[apIndexLFG].Wykresl(apRysownica);
                        apIndexLFG++;

                    }
                    catch (ArgumentException) { }
                }
                if (rdbLukElipsy.Checked)
                {
                    // zapisanie kątów podanych przez użytkownika
                    int apPoczatkowyKat = (int)numUD_PoczatkowyKat.Value;
                    int apLiczbaStopni = (int)numUD_LiczbaStopni.Value;
                    // zabezpieczenie przed błędem
                    try
                    {
                        // wykreślenie łuku elipsy
                        apLFG.Add(new LukElipsy(apLewyGornyNaroznikX, apLewyGornyNaroznikY, apSzerokosc, apWysokosc, apPoczatkowyKat, apLiczbaStopni, apKolor, apStylLinii, apGruboscLinii));
                        apLFG[apIndexLFG].Wykresl(apRysownica);
                        apIndexLFG++;
                    }
                    catch (ArgumentException) { }
                }
                if (rdbKrzywaBeziera.Checked)
                {
                    if (gbWyborKrzywej.Enabled)
                    {
                        // ustawienie stanu braku aktywności dla kontenera: gbWyborKrzywej
                        gbWyborKrzywej.Enabled = false;
                        apKrzywaBeziera.apNumerPunktuKontrolnego = 0;
                        // przechowanie współrzędnych aktualnego położenia myszy
                        apKrzywaBeziera.apPunktP0 = e.Location;
                    }// od if (gbWyborKrzywej.Enabled)
                    else
                    {// przechowanie współrzędnych kolejnych punktów kontrolnych
                     // zwiększenie numeru (licznika) punktów kontrolnych
                        apKrzywaBeziera.apNumerPunktuKontrolnego++;
                        // przechowanie wartości współrzędnych punktu kontrolnego o numerze w KrzywaBeziera.NumerPunktuKontrolnego
                        switch (apKrzywaBeziera.apNumerPunktuKontrolnego)
                        {
                            case 1: apKrzywaBeziera.apPunktP1 = e.Location; break;
                            case 2: apKrzywaBeziera.apPunktP2 = e.Location; break;
                            case 3: apKrzywaBeziera.apPunktP3 = e.Location; break;
                        }
                        // wykreślenie krzywej Beziera
                        if (apKrzywaBeziera.apNumerPunktuKontrolnego >= 3)
                        {
                            apLFG.Add(new KrzywaBeziera(apKrzywaBeziera.apPunktP0, apKrzywaBeziera.apPunktP1, apKrzywaBeziera.apPunktP2, apKrzywaBeziera.apPunktP3, apKolor, apStylLinii, apGruboscLinii));
                            apLFG[apIndexLFG].Wykresl(apRysownica);
                            apIndexLFG++;
                            // ponowne uaktywnienie kontenera: gbWyborKrzywej
                            gbWyborKrzywej.Enabled = true;
                        }
                    }
                }
                if (rdbKrzywaKardynalna.Checked)
                {
                    if (gbWyborKrzywej.Enabled)
                    {
                        // ustawienie stanu braku aktywności dla kontenera: gbWyborKrzywej
                        gbWyborKrzywej.Enabled = false;
                        // zapisanie wartości liczby punktów podanej przez użytkownika
                        apKrzywaKardynalna.apLiczbaPunktow = (ushort)numUD_LiczbaPunktow.Value;
                        apKrzywaKardynalna.apNumerPunktuKrzywej = 0;
                        // stworzenie tablicy z tyloma wartościami, ile podał użytkownik
                        apKrzywaKardynalna.apPunktyKrzywej = new Point[apKrzywaKardynalna.apLiczbaPunktow];
                        // zapisanie lokalizacji pierwszego punktu
                        apKrzywaKardynalna.apPunktyKrzywej[0] = e.Location;
                        // narysowanie punktu
                    }
                    else
                    {
                        apKrzywaKardynalna.apNumerPunktuKrzywej++;
                        // zapisanie lokalizacji każdych z punktów
                        switch (apKrzywaKardynalna.apNumerPunktuKrzywej)
                        {
                            case 1: apKrzywaKardynalna.apPunktyKrzywej[1] = e.Location; break;
                            case 2: apKrzywaKardynalna.apPunktyKrzywej[2] = e.Location; break;
                            case 3: apKrzywaKardynalna.apPunktyKrzywej[3] = e.Location; break;
                            case 4: apKrzywaKardynalna.apPunktyKrzywej[4] = e.Location; break;
                            case 5: apKrzywaKardynalna.apPunktyKrzywej[5] = e.Location; break;
                            case 6: apKrzywaKardynalna.apPunktyKrzywej[6] = e.Location; break;
                            case 7: apKrzywaKardynalna.apPunktyKrzywej[7] = e.Location; break;
                            case 8: apKrzywaKardynalna.apPunktyKrzywej[8] = e.Location; break;
                            case 9: apKrzywaKardynalna.apPunktyKrzywej[9] = e.Location; break;
                            case 10: apKrzywaKardynalna.apPunktyKrzywej[10] = e.Location; break;
                            case 11: apKrzywaKardynalna.apPunktyKrzywej[11] = e.Location; break;
                            case 12: apKrzywaKardynalna.apPunktyKrzywej[12] = e.Location; break;
                            case 13: apKrzywaKardynalna.apPunktyKrzywej[13] = e.Location; break;
                            case 14: apKrzywaKardynalna.apPunktyKrzywej[14] = e.Location; break;
                            case 15: apKrzywaKardynalna.apPunktyKrzywej[15] = e.Location; break;
                            case 16: apKrzywaKardynalna.apPunktyKrzywej[16] = e.Location; break;
                            case 17: apKrzywaKardynalna.apPunktyKrzywej[17] = e.Location; break;
                            case 18: apKrzywaKardynalna.apPunktyKrzywej[18] = e.Location; break;
                            case 19: apKrzywaKardynalna.apPunktyKrzywej[19] = e.Location; break;
                        }
                        if (apKrzywaKardynalna.apNumerPunktuKrzywej >= apKrzywaKardynalna.apLiczbaPunktow - 1)
                        {
                            apLFG.Add(new KrzywaKardynalna(apKrzywaKardynalna.apPunktyKrzywej, apKolor, apStylLinii, apGruboscLinii));
                            apLFG[apIndexLFG].Wykresl(apRysownica);
                            apIndexLFG++;
                            // ponowne uaktywnienie kontenera: gbWyborKrzywej
                            gbWyborKrzywej.Enabled = true;
                        }
                    }
                }
                if (rdbZamknietaKrzywaKardynalna.Checked)
                {
                    if (gbWyborKrzywej.Enabled)
                    {
                        // ustawienie stanu braku aktywności dla kontenera: gbWyborKrzywej
                        gbWyborKrzywej.Enabled = false;
                        // zapisanie wartości liczby punktów podanej przez użytkownika
                        apKrzywaKardynalna.apLiczbaPunktow = (ushort)numUD_LiczbaPunktow.Value;
                        apKrzywaKardynalna.apNumerPunktuKrzywej = 0;
                        // stworzenie tablicy z tyloma wartościami, ile podał użytkownik
                        apKrzywaKardynalna.apPunktyKrzywej = new Point[apKrzywaKardynalna.apLiczbaPunktow];
                        // zapisanie lokalizacji pierwszego punktu
                        apKrzywaKardynalna.apPunktyKrzywej[0] = e.Location;
                        // narysowanie punktu
                    }
                    else
                    {
                        apKrzywaKardynalna.apNumerPunktuKrzywej++;
                        // zapisanie lokalizacji każdych z punktów
                        switch (apKrzywaKardynalna.apNumerPunktuKrzywej)
                        {
                            case 1: apKrzywaKardynalna.apPunktyKrzywej[1] = e.Location; break;
                            case 2: apKrzywaKardynalna.apPunktyKrzywej[2] = e.Location; break;
                            case 3: apKrzywaKardynalna.apPunktyKrzywej[3] = e.Location; break;
                            case 4: apKrzywaKardynalna.apPunktyKrzywej[4] = e.Location; break;
                            case 5: apKrzywaKardynalna.apPunktyKrzywej[5] = e.Location; break;
                            case 6: apKrzywaKardynalna.apPunktyKrzywej[6] = e.Location; break;
                            case 7: apKrzywaKardynalna.apPunktyKrzywej[7] = e.Location; break;
                            case 8: apKrzywaKardynalna.apPunktyKrzywej[8] = e.Location; break;
                            case 9: apKrzywaKardynalna.apPunktyKrzywej[9] = e.Location; break;
                            case 10: apKrzywaKardynalna.apPunktyKrzywej[10] = e.Location; break;
                            case 11: apKrzywaKardynalna.apPunktyKrzywej[11] = e.Location; break;
                            case 12: apKrzywaKardynalna.apPunktyKrzywej[12] = e.Location; break;
                            case 13: apKrzywaKardynalna.apPunktyKrzywej[13] = e.Location; break;
                            case 14: apKrzywaKardynalna.apPunktyKrzywej[14] = e.Location; break;
                            case 15: apKrzywaKardynalna.apPunktyKrzywej[15] = e.Location; break;
                            case 16: apKrzywaKardynalna.apPunktyKrzywej[16] = e.Location; break;
                            case 17: apKrzywaKardynalna.apPunktyKrzywej[17] = e.Location; break;
                            case 18: apKrzywaKardynalna.apPunktyKrzywej[18] = e.Location; break;
                            case 19: apKrzywaKardynalna.apPunktyKrzywej[19] = e.Location; break;
                        }
                        if (apKrzywaKardynalna.apNumerPunktuKrzywej >= apKrzywaKardynalna.apLiczbaPunktow - 1)
                        {
                            apLFG.Add(new ZamknietaKrzywaKardynalna(apKrzywaKardynalna.apPunktyKrzywej, apKolorWypelnienia, apStylLinii, apGruboscLinii));
                            apLFG[apIndexLFG].Wykresl(apRysownica);
                            apIndexLFG++;
                            // ponowne uaktywnienie kontenera: gbWyborKrzywej
                            gbWyborKrzywej.Enabled = true;
                        }
                    }
                }
            }
            pbRysownica.Refresh();
        }

        private void btnCofnijFG_Click(object sender, EventArgs e)
        {
            if (apLFG.Count > 0)
            {
                apLFG[apLFG.Count - 1].Wymaz(pbRysownica, apRysownica);
                apLFG.RemoveAt(apLFG.Count - 1);
                apIndexLFG--;
                if (apIndexLFG == 0)
                {
                    btnPokazFigur.Enabled = false;
                    btnCofnijFG.Enabled = true;
                    groupBox1.Enabled = false;
                }
            }
            pbRysownica.Refresh();
        }

        private void btnPrzesunDoNowegoXY_Click(object sender, EventArgs e)
        {
            // pomocnicze deklaracje
            Random aprnd = new Random();
            int apXn, apYn;
            int apXmax, apYmax; //rozmiar powierzchni
            // wyczyszczenie całej powierzchni graficznej
            apRysownica.Clear(pbRysownica.BackColor);
            // odczytanie rozmiaru powierzchni
            apXmax = pbRysownica.Width; apYmax = pbRysownica.Height;
            // przesuwanie z wykreśleniem wszystkich figur geometrycznych z LFG
            for (int api = 0; api < apLFG.Count; api++)
            {// wylosowanie nowych współrzędnych nowego położenia i-tej figury geometrycznej
                apXn = aprnd.Next(apMargines, apXmax - apMargines);
                apYn = aprnd.Next(apMargines, apYmax - apMargines);
                // przesunięcie z wykreśleniem i-tej figury geometrycznej
                apLFG[api].PrzesunDoNowegoXY(pbRysownica, apRysownica, apXn, apYn);
            }
            // odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // wymazanie figury aktualnie wykreślonej
            apLFG[(int)timer1.Tag].Wymaz(pbRysownica, apRysownica);
            // wyznaczenie rozmiaru powierzchni graficznej
            int apXmax = pbRysownica.Width;
            int apYmax = pbRysownica.Height;
            // wyznaczenie indeksu (numeru) figury do pokazu (wykreślenia)

            timer1.Tag = ((int)timer1.Tag + 1) % (apLFG.Count);
            
            // przesunięcie i wykreślenie figury geometrycznej o numerze timer1.Tag
            apLFG[(int)timer1.Tag].PrzesunDoNowegoXY(pbRysownica, apRysownica, apXmax / 2, apYmax / 2);
            // odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }
        private void txtNrFigury_TextChanged(object sender, EventArgs e)
        {
            ushort apN;
            // zgaszenie kontrolki errorProvider
            errorProvider1.Dispose();
            // sprawdzenie na poprawność zapisu
            while (!ushort.TryParse(txtNrFigury.Text, out apN))
            {// jest błąd
                errorProvider1.SetError(txtNrFigury, "ERROR: w podanym zapisie numeru (indeksu) figury geometrycznej wystąpił niedozwolony znak");
                return;
            }
            // sprawdzenie na wartość N
            if (apN > (apLFG.Count - 1))
            {// jest błąd
                errorProvider1.SetError(txtNrFigury, "ERROR: podany numer (indeks) figury geometrycznej wykracza poza zakres indeksu LFG");
                return;
            }
        }
        private void rdbManualny_CheckedChanged(object sender, EventArgs e)
        {
            // uaktywnienie kontroli txtNrFigury
            txtNrFigury.Enabled = true;
            label4.Enabled = true;
            // wpisanie domyślnego numeru (indeksu) figury w TFG
            txtNrFigury.Text = 0.ToString();
        }
        private void btnPokazFigur_Click(object sender, EventArgs e)
        {
            // wyczyszczenie powierzchni graficznej
            apRysownica.Clear(pbRysownica.BackColor);
            pbRysownica.Refresh();
            // ustawienie braku aktywności dla obsługiwanego przycisku
            btnPokazFigur.Enabled = false;
            btnCofnijFG.Enabled = false;
            // uaktywnienie przycisku zakonczenia pokazu figur geometrycznych
            btnWylaczPokaz.Enabled = true;
            groupBox1.Enabled = false;
            // rozpoznanie wybranego trybu pokazu
            if (rdbAutomatyczny.Checked)
            {
                txtNrFigury.Enabled = false;
                label4.Enabled = false;
                // ustawienie numeru (indeksu) figury w zegarze
                timer1.Tag = 0;
                // włączenie zegara
                timer1.Enabled = true;
                txtNrFigury.Text = 0.ToString();
                // uaktywnienie zegara
                timer1.Enabled = true;

                // uaktywnienie przycisku poleceń Wyłącz pokaz
                btnWylaczPokaz.Enabled = true;
                // i odwrotnie
                //btnWylaczPokaz.Enabled = false;
            }
            else
            {// uaktywnienie przycisków: Następny i Poprzedni
                btnNastepna.Enabled = true;
                btnPoprzednia.Enabled = true;
                txtNrFigury.Enabled = true;
                label4.Enabled = true;
                int apN;
                apN = int.Parse(txtNrFigury.Text);
                // wyznaczenie rozmiaru powierzchni graficznej
                int apXmax = pbRysownica.Width;
                int apYmax = pbRysownica.Height;
                // przesunięcie i wykreślenie figury o numerze (indeksie) N
                apLFG[apN].PrzesunDoNowegoXY(pbRysownica, apRysownica, apXmax / 2, apYmax / 2);
                pbRysownica.Refresh();
            }
        }
        private void btnWylaczPokaz_Click(object sender, EventArgs e)
        {
            // wyczyszczenie powierzchni graficznej
            apRysownica.Clear(pbRysownica.BackColor);
            groupBox1.Enabled = true;
            timer1.Enabled = false;
            // ustawienie braku aktywności dla obsługiwanego przycisku
            btnWylaczPokaz.Enabled = false;
            btnCofnijFG.Enabled = true;
            btnPokazFigur.Enabled = true;
            btnNastepna.Enabled = false;
            btnPoprzednia.Enabled = false;
            txtNrFigury.Enabled = false;
            label4.Enabled = false;
            int apXmax = pbRysownica.Width;
            int apYmax = pbRysownica.Height;
            int apXn, apYn;
            Random aprnd = new Random();
            // wykreślenie wszystkich figury geometrycznych z LFG
            for (int api = 0; api < apLFG.Count; api++)
            {
                // losowanie nowego położenia
                apXn = aprnd.Next(apMargines, apXmax - apMargines);
                apYn = aprnd.Next(apMargines, apYmax - apMargines);
                // przesunięcie z wykreśleniem i-tej figury geometrycznej
                apLFG[api].PrzesunDoNowegoXY(pbRysownica, apRysownica, apXn, apYn);
            }
            // odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }
        private void btnNastepna_Click(object sender, EventArgs e)
        {
            int apN = int.Parse(txtNrFigury.Text);
            // wymazanie powierzchni graficznej o numerze (indeksie) N
            apLFG[apN].Wymaz(pbRysownica, apRysownica);
            // wyznaczenie numeru następnej figury do wykreślenia 
            if (apN < (apLFG.Count - 1))
                apN++;
            else
                apN = 0;
            // wpisanie nowego numeru do kontrolki TextBox
            txtNrFigury.Text = apN.ToString();
            int apXmax = pbRysownica.Width;
            int apYmax = pbRysownica.Height;
            // wykreślenie nowej figury geometrycznej 
            apLFG[apN].PrzesunDoNowegoXY(pbRysownica, apRysownica, apXmax / 2, apYmax / 2);
            pbRysownica.Refresh();
        }

        private void btnPoprzednia_Click(object sender, EventArgs e)
        {
            int apN = int.Parse(txtNrFigury.Text);
            // wymazanie powierzchni graficznej o numerze (indeksie) N
            apLFG[apN].Wymaz(pbRysownica, apRysownica);
            // wyznaczenie numeru następnej figury do wykreślenia
            if (apN == 0)
                apN = apLFG.Count - 1;
            else
                apN--;
            // wpisanie nowego numeru do kontrolki TextBox
            txtNrFigury.Text = apN.ToString();
            int apXmax = pbRysownica.Width;
            int apYmax = pbRysownica.Height;
            // wykreślenie nowej figury geometrycznej 
            apLFG[apN].PrzesunDoNowegoXY(pbRysownica, apRysownica, apXmax / 2, apYmax / 2);
            pbRysownica.Refresh();
        }

        private void btnKolorLinii_Click(object sender, EventArgs e)
        {
            // otworzenie okna dialogowego z paletą kolorów
            ColorDialog apPaletaKolorow = new ColorDialog();
            // zaznaczenie w PalecieKolorow bieżącego koloru tła wykresu
            apPaletaKolorow.Color = gbWyborKrzywej.ForeColor;
            // wyświetlenie palety kolorów i "odczytanie" wybranego koloru przez Użytkownika
            if (apPaletaKolorow.ShowDialog() == DialogResult.OK)
            {
                // dokonujemy zmiany koloru linii
                btnKolorLinii.BackColor = apPaletaKolorow.Color;
                apKolor = apPaletaKolorow.Color;
            }

            // zwolnienie egzemplarza apPaletyKolorow
            apPaletaKolorow.Dispose();
        }

        private void cmbStylLinii_SelectedIndexChanged(object sender, EventArgs e)
        {
            // wybranie stylu linii
            if (cmbStylLinii.SelectedIndex == 0)
                apStylLinii = DashStyle.Dot;
            else if (cmbStylLinii.SelectedIndex == 1)
                apStylLinii = DashStyle.Dash;
            else if (cmbStylLinii.SelectedIndex == 2)
                apStylLinii = DashStyle.DashDot;
            else if (cmbStylLinii.SelectedIndex == 3)
                apStylLinii = DashStyle.DashDotDot;
            else
                apStylLinii = DashStyle.Solid;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // grubość linii
            int apNumerGrubosci = trackBar1.Value+1;
            apGruboscLinii = apNumerGrubosci * 0.8f;
        }

        private void btnKolorWypelnienia_Click(object sender, EventArgs e)
        {
            // otworzenie okna dialogowego z paletą kolorów
            ColorDialog apPaletaKolorow = new ColorDialog();
            // zaznaczenie w PalecieKolorow bieżącego koloru tła wykresu
            apPaletaKolorow.Color = gbWyborKrzywej.ForeColor;
            // wyświetlenie palety kolorów i "odczytanie" wybranego koloru przez Użytkownika
            if (apPaletaKolorow.ShowDialog() == DialogResult.OK)
            {
                // dokonujemy zmiany koloru wypełnienia
                btnKolorWypelnienia.BackColor = apPaletaKolorow.Color;
                apKolorWypelnienia = apPaletaKolorow.Color;
            }

            // zwolnienie egzemplarza apPaletyKolorow
            apPaletaKolorow.Dispose();
        }

        private void btnZapiszBitMape_Click(object sender, EventArgs e)
        {
            // zapisanie rysownicy w pliku
            using (SaveFileDialog apPlikDoZapisu = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (apPlikDoZapisu.ShowDialog() == DialogResult.OK)
                {
                    pbRysownica.Image.Save(apPlikDoZapisu.FileName);
                }
            }
        }

        private void btnWczytajBitMape_Click(object sender, EventArgs e)
        {
            // odczytanie rysownicy z pliku
            OpenFileDialog apPlikDoOdczytu = new OpenFileDialog();
            apPlikDoOdczytu.ShowDialog();
            string sciezka = apPlikDoOdczytu.FileName;
            try
            {
                pbRysownica.Image = Image.FromFile(sciezka);
            }
            catch (ArgumentException) { }

            apRysownica = Graphics.FromImage(pbRysownica.Image);
        }
        // ustawienie dostępności
        private void rdbAutomatyczny_CheckedChanged(object sender, EventArgs e)
        {
            txtNrFigury.Enabled = false;
            label4.Enabled = false;
        }

        private void rdbWielokat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWielokat.Checked)
            {
                // wyświetlenie okna dialogowego dla użytkownika programu
                MessageBox.Show("Wykreślenie wielokąta foremnego wymaga ustalenia (podania) liczby kątów (minimalna liczba kątów wielokąta, to 3!)",
                    "Kreślenie wielokąta foremnego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numUD_LiczbaKatow.Enabled = true;
                lblLiczbaKatow.Enabled = true;
            }
            else
            {
                numUD_LiczbaKatow.Enabled = false;
                lblLiczbaKatow.Enabled = false;
            }
        }

        private void rdbWielokatWypelniony_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWielokatWypelniony.Checked)
            {
                // wyświetlenie okna dialogowego dla użytkownika programu
                MessageBox.Show("Wykreślenie wielokąta wypełnionego wymaga ustalenia (podania) liczby kątów (minimalna liczba kątów wielokąta, to 3!)",
                    "Kreślenie wielokąta wypełnionego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numUD_LiczbaKatow.Enabled = true;
                lblLiczbaKatow.Enabled = true;
            }
            else
            {
                numUD_LiczbaKatow.Enabled = false;
                lblLiczbaKatow.Enabled = false;
            }
        }

        private void rdbWycinekElipsy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWycinekElipsy.Checked)
            {
                // wyświetlenie okna dialogowego dla użytkownika programu
                MessageBox.Show("Wykreślenie wycinka elipsy wymaga ustalenia (podania) kąta początkowego i kąta nachylenia (minimalnie 1 stopień, maksymalnie 360 stopni)",
                    "Kreślenie wycinka elispy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numUD_PoczatkowyKat.Enabled = true;
                numUD_LiczbaStopni.Enabled = true;
                lblKatPoczatkowy.Enabled = true;
                lblKatNachylenia.Enabled = true;
            }
            else
            {
                numUD_PoczatkowyKat.Enabled = false;
                numUD_LiczbaStopni.Enabled = false;
                lblKatPoczatkowy.Enabled = false;
                lblKatNachylenia.Enabled = false;
            }
        }

        private void rdbWypelnionyWyciekElipsy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWypelnionyWyciekElipsy.Checked)
            {
                // wyświetlenie okna dialogowego dla użytkownika programu
                MessageBox.Show("Wykreślenie wypełnionego wycinka elipsy wymaga ustalenia (podania) kąta początkowego i kąta nachylenia (minimalnie 1 stopień, maksymalnie 360 stopni)",
                    "Kreślenie wypełnionego wycinka elispy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numUD_PoczatkowyKat.Enabled = true;
                numUD_LiczbaStopni.Enabled = true;
                lblKatPoczatkowy.Enabled = true;
                lblKatNachylenia.Enabled = true;
            }
            else
            {
                numUD_PoczatkowyKat.Enabled = false;
                numUD_LiczbaStopni.Enabled = false;
                lblKatPoczatkowy.Enabled = false;
                lblKatNachylenia.Enabled = false;
            }
        }

        private void rdbLukElipsy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLukElipsy.Checked)
            {
                // wyświetlenie okna dialogowego dla użytkownika programu
                MessageBox.Show("Wykreślenie łuku elipsy wymaga ustalenia (podania) kąta początkowego i kąta nachylenia (minimalnie 1 stopień, maksymalnie 360 stopni)",
                    "Kreślenie łuku elispy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numUD_PoczatkowyKat.Enabled = true;
                numUD_LiczbaStopni.Enabled = true;
                lblKatPoczatkowy.Enabled = true;
                lblKatNachylenia.Enabled = true;
            }
            else
            {
                numUD_PoczatkowyKat.Enabled = false;
                numUD_LiczbaStopni.Enabled = false;
                lblKatPoczatkowy.Enabled = false;
                lblKatNachylenia.Enabled = false;
            }
        }

        private void rdbKrzywaKardynalna_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKrzywaKardynalna.Checked)
            {
                lblLiczbaPunktow.Enabled = true;
                numUD_LiczbaPunktow.Enabled = true;
                // wyświetlenie okna dialogowego dla użytkownika programu
                MessageBox.Show("Wykreślenie krzywej kardynalnej wymaga ustalenia (podania) liczby punktów (minimalna liczba punktów krzywej kardynalnej, to 3!)",
                    "Kreślenie krzywej kardynalnej", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblLiczbaPunktow.Enabled = false;
                numUD_LiczbaPunktow.Enabled = false;
            }
        }

        private void rdbZamknietaKrzywaKardynalna_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbZamknietaKrzywaKardynalna.Checked)
            {
                lblLiczbaPunktow.Enabled = true;
                numUD_LiczbaPunktow.Enabled = true;
                // wyświetlenie okna dialogowego dla użytkownika programu
                MessageBox.Show("Wykreślenie zamkniętej krzywej kardynalnej wymaga ustalenia (podania) liczby punktów (minimalna liczba punktów krzywej kardynalnej, to 3!)",
                    "Kreślenie zamkniętej krzywej kardynalnej", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblLiczbaPunktow.Enabled = false;
                numUD_LiczbaPunktow.Enabled = false;
            }
        }

        private void rdbKrzywaBeziera_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKrzywaBeziera.Checked)
                // wizualizacja okna dialogowego z informacją dla Użytkownika: co powinien zrobić?
                MessageBox.Show("Wykreślenie krzywej Beziera wymaga zaznaczenia (kliknięcia) 4 punktów na Rysownicy", "Kreślenie krzywej Beziera", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

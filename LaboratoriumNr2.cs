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
using static Projekt2_Piwowarski62024.FiguryGeometryczne;

namespace Projekt2_Piwowarski62024
{
    public partial class LaboratoriumNr2 : Form
    {
        // deklaracje pomocnicze
        const int Margines = 10;
        // deklaracja powierzchni graficznej
        Graphics Rysownica;
        // deklaracja tablicy TFG (Tablica Figur Geometrycznych)
        Punkt[] TFG;
        int IndexTFG;

        public LaboratoriumNr2()
        {
            InitializeComponent();

            // ustalenie rozmiarów formularza
            this.Location = new Point(Screen.PrimaryScreen.Bounds.X + Margines, Screen.PrimaryScreen.Bounds.Y + Margines);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.4f);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.6f);
            this.StartPosition = FormStartPosition.Manual;

            // ustalenie lokalizacji kontrolki PictureBox
            pbRysownica.Location = new Point(this.Left + 20 * Margines, this.Top + 5 * Margines);
            pbRysownica.Size = new Size((int)(this.Width * 0.6f), (int)(this.Height * 0.6f));
            // utworzenie BitMapy i jej podpięcie do kontrolki PictureBox
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            // utworzenie egzemplarza powierzchni graficznej
            Rysownica = Graphics.FromImage(pbRysownica.Image);
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            ushort N;
            // zgaszenie kontrolki errorProvider
            errorProvider1.Dispose();
            // sprawdzenie w kontrolce txtN jest wpisana poprawnie liczba figur
            if (!ushort.TryParse(txtN.Text, out N))
            {
                // zapalenie kontrolki errorProvider
                errorProvider1.SetError(txtN, "ERROR: w zapisie podanej liczby figur geometrycznych wystąpił niedozwolony znak");
                return;
            }
            // sprawdzenie, czy zostały wybrane figury geometryczne do prezentacji
            if (chlbFiguryGeometryczne.CheckedItems.Count > 0)
            {// ustawienie stanu braku aktywności dla kontrolki txtN
                //txtN.Enabled = false;
                // uaktywnienie przycisku poleceń START
                btnStart.Enabled = true;
            }
            else
                // sygnalizacja "braku danych wejściowych"
                errorProvider1.SetError(chlbFiguryGeometryczne, "UWAGA: musisz wybrać co najmniej jedną figurę w kontrolce CheckedList (ona jest tuż obok!)");
        }

        private void chlbFiguryGeometryczne_SelectedIndexChanged(object sender, EventArgs e)
        {
            // zgaszenie kontrolki errorProvider
            errorProvider1.Dispose();
            // sprawdzenie, czy została podana liczba figur do prezentacji
            if (!txtN.Enabled)
                // uaktywnienie przycisku poleceń START
                btnStart.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki errorProvider
            errorProvider1.Dispose();
            txtN.Enabled = false;
            ushort LiczbaWybranychFG;
            int Xmax, Ymax;
            int Xp, Yp;
            Color Kolor;
            DashStyle StylLinii;
            float GruboscLinii;
            Random rnd = new Random();
            // pobranie liczby figurz kontrolki txtN
            LiczbaWybranychFG = ushort.Parse(txtN.Text);
            // utworzenie egzemplarza tablicy TFG (Tablica Figur Geometrycznych)
            TFG = new Punkt[LiczbaWybranychFG];
            IndexTFG = 0;
            CheckedListBox.CheckedItemCollection WybraneFG = chlbFiguryGeometryczne.CheckedItems;
            // odczytanie rozmiarów powierzchni graficznej
            Xmax = pbRysownica.Width; Ymax = pbRysownica.Height;
            // tworzenie egzemplarzy figur geometrycznych i wpisanie ich referencji do TFG, a następnie ich wykreślenie
            for (ushort i = 0; i < LiczbaWybranychFG; i++)
            {
                // losowanie współrzędnych położenia figury geometrycznej
                Xp = rnd.Next(Margines, Xmax - Margines);
                Yp = rnd.Next(Margines, Ymax - Margines);
                Kolor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

                switch (rnd.Next(0, 5))
                {
                    case 0:
                        StylLinii = DashStyle.Solid;
                        break;
                    case 1:
                        StylLinii = DashStyle.Dash;
                        break;
                    case 2:
                        StylLinii = DashStyle.Dot;
                        break;
                    case 3:
                        StylLinii = DashStyle.DashDot;
                        break;
                    case 4:
                        StylLinii = DashStyle.DashDotDot;
                        break;
                    default:
                        {
                            StylLinii = DashStyle.Solid;
                            MessageBox.Show("Przepraszamy, ale takiego stylu linii jeszcze nie mamy");
                            break;
                        }
                }// od switcha
                // wylosowanie grubości linii 
                GruboscLinii = (float)(rnd.NextDouble() * ((double)Margines - 0.5) + 0.5);

                // losowanie figury: jednej z wybranych
                switch (WybraneFG[rnd.Next(WybraneFG.Count)].ToString())
                {
                    case "Punkt":
                        {
                            // utworzenie egzemplarza Punktu i wpisanie jego referencji do TFG
                            TFG[IndexTFG] = new Punkt(Xp, Yp, Kolor);
                            TFG[IndexTFG].Wykresl(Rysownica);
                            // "przejście" z IndexTFG do następnej wolnej pozycji w TFG
                            IndexTFG++;
                            break;
                        }
                    case "Linia":
                        {
                            // wylosowanie współrzędnych końca linii 
                            int Xk = rnd.Next(Margines, Xmax - Margines);
                            int Yk = rnd.Next(Margines, Ymax - Margines);
                            // utworzenie egzemplarza Linii i wpisanie jego referencji do TFG
                            TFG[IndexTFG] = new Linia(Xp, Yp, Xk, Yk, Kolor, StylLinii, GruboscLinii);
                            TFG[IndexTFG].Wykresl(Rysownica);
                            // "przejście" z IndexTFG do następnej wolnej pozycji w TFG
                            IndexTFG++;
                            break;
                        }
                    case "Elipsa":
                        {// deklaracje pomocnicze
                            int OsDuza, OsMala;
                            // wylosowanie Osi Duzej i Malej
                            OsDuza = rnd.Next(Margines, Xmax / 4);
                            OsMala = rnd.Next(Margines, Ymax / 6);
                            // utworzenie egzemplarza Elipsy i wpisanie jego referencji do TFG
                            TFG[IndexTFG] = new Elipsa(Xp, Yp, OsDuza, OsMala, Kolor, StylLinii, GruboscLinii);
                            // wykreślenie Elipsy
                            TFG[IndexTFG].Wykresl(Rysownica);
                            // "przeniesienie" IndexTFG do wolnej pozycji w TFG
                            IndexTFG++;
                            break;
                        }
                    case "Okrąg":
                        {
                            int Promien = rnd.Next(Margines, Xmax / 4);
                            TFG[IndexTFG] = new Okrag(Xp, Yp, Promien, Kolor, StylLinii, GruboscLinii);
                            // wykreślenie Okręgu
                            TFG[IndexTFG].Wykresl(Rysownica);
                            IndexTFG++;
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("UWAGA: tej figury jeszcze nie kreślimy! przepraszamy!!!");
                            break;
                        }
                }// koniec switcha
            }// od for
            // odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
            // ustawienie stanu braku aktywności dla przycisku poleceń Start
            btnStart.Enabled = false;
            // uaktywnienie kolejnych przycisków funkcjonalnych i kontrolek
            btnPrzesunDoNowegoXY.Enabled = true;
            btnWlaczPokazFigur.Enabled = true;
            gpbTrybPokazu.Enabled = true;
        }

        private void LaboratoriumNr2_Load(object sender, EventArgs e)
        {
            // lokalizacja kontrolki CheckedListBox
            chlbFiguryGeometryczne.Location = new Point(pbRysownica.Location.X + pbRysownica.Width + Margines, pbRysownica.Location.Y + Margines*2);
            label2.Location = new Point(pbRysownica.Location.X + pbRysownica.Width + Margines, Margines/2);
            btnWlaczPokazFigur.Location = new Point(Margines*3, pbRysownica.Height + Margines*8);
            gpbTrybPokazu.Location = new Point(pbRysownica.Width / 3, pbRysownica.Height + Margines * 8);
            btnNastepna.Location = new Point(pbRysownica.Width/2 + Margines*30, pbRysownica.Height + Margines * 8);
            btnPoprzednia.Location = new Point(pbRysownica.Width / 2 + Margines * 50, pbRysownica.Height + Margines * 8);
            label3.Location = new Point(pbRysownica.Width / 2 + Margines * 35, pbRysownica.Height + Margines * 15);
            txtNrFigury.Location = new Point(pbRysownica.Width / 2 + Margines * 42, pbRysownica.Height + Margines * 18);
            btnWylaczPokazFigur.Location = new Point(pbRysownica.Location.X + pbRysownica.Width + Margines, pbRysownica.Location.Y + pbRysownica.Height);
        }

        private void btnPrzesunDoNowegoXY_Click(object sender, EventArgs e)
        {
            // pomocnicze deklaracje
            Random rnd = new Random();
            int Xn, Yn;
            int Xmax, Ymax; //rozmiar powierzchni
            // wyczyszczenie całej powierzchni graficznej
            Rysownica.Clear(pbRysownica.BackColor);
            // odczytanie rozmiaru powierzchni
            Xmax = pbRysownica.Width; Ymax = pbRysownica.Height;
            // przesuwanie z wykreśleniem wszystkich figur geometrycznych z TFG
            for (int i = 0; i < TFG.Length; i++)
            {// wylosowanie nowych współrzędnych nowego położenia i-tej figury geometrycznej
                Xn = rnd.Next(Margines, Xmax - Margines);
                Yn = rnd.Next(Margines, Ymax - Margines);
                // przesunięcie z wykreśleniem i-tej figury geometrycznej
                TFG[i].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xn, Yn);
            }
            // odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // wymazanie figury aktualnie wykreślonej
            TFG[(int)timer1.Tag].Wymaz(pbRysownica, Rysownica);
            // wyznaczenie rozmiaru powierzchni graficznej
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            // wyznaczenie indeksu (numeru) figury do pokazu (wykreślenia)
            timer1.Tag = ((int)timer1.Tag + 1) % (TFG.Length);
            // przesunięcie i wykreślenie figury geometrycznej o numerze timer1.Tag
            TFG[(int)timer1.Tag].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            // odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void txtNrFigury_TextChanged(object sender, EventArgs e)
        {
            ushort N;
            // zgaszenie kontrolki errorProvider
            errorProvider1.Dispose();
            // sprawdzenie na poprawność zapisu
            while (!ushort.TryParse(txtNrFigury.Text, out N))
            {// jest błąd
                errorProvider1.SetError(txtNrFigury, "ERROR: w podanym zapisie numeru (indeksu) figury geometrycznej wystąpił niedozwolony znak");
                return;
            }
            // sprawdzenie na wartość N
            if (N > (TFG.Length - 1))
            {// jest błąd
                errorProvider1.SetError(txtNrFigury, "ERROR: podany numer (indeks) figury geometrycznej wykracza poza zakres indeksu TFG");
                return;
            }
        }

        private void rdbManualny_CheckedChanged(object sender, EventArgs e)
        {
            // uaktywnienie kontroli txtNrFigury
            txtNrFigury.Enabled = true;
            // wpisanie domyślnego numeru (indeksu) figury w TFG
            txtNrFigury.Text = 0.ToString();
        }

        private void btnWlaczPokazFigur_Click(object sender, EventArgs e)
        {
            // wyczyszczenie powierzchni graficznej
            Rysownica.Clear(pbRysownica.BackColor);
            pbRysownica.Refresh();
            // ustawienie braku aktywności dla obsługiwanego przycisku
            btnWlaczPokazFigur.Enabled = false;
            // uaktywnienie przycisku zakonczenia pokazu figur geometrycznych
            btnWylaczPokazFigur.Enabled = true;
            // rozpoznanie wybranego trybu pokazu
            if (rdbAutomatyczny.Checked)
            {
                // ustawienie numeru (indeksu) figury w zegarze
                timer1.Tag = 0;
                // włączenie zegara
                timer1.Enabled = true;
            }
            else
            {
                int N;
                N = int.Parse(txtNrFigury.Text);
                // wyznaczenie rozmiaru powierzchni graficznej
                int Xmax = pbRysownica.Width;
                int Ymax = pbRysownica.Height;
                // przesunięcie i wykreślenie figury o numerze (indeksie) N
                TFG[N].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
                pbRysownica.Refresh();
                // uaktywnienie przycisków: Następna i poprzednia
                btnNastepna.Enabled = true;
                btnPoprzednia.Enabled = true;
            }
        }

        private void btnWylaczPokazFigur_Click(object sender, EventArgs e)
        {
            // wyczyszczenie powierzchni graficznej
            Rysownica.Clear(pbRysownica.BackColor);

            timer1.Enabled = false;
            // ustawienie braku aktywności dla obsługiwanego przycisku
            btnWylaczPokazFigur.Enabled = false;
            btnWlaczPokazFigur.Enabled = true;
            btnNastepna.Enabled = false;
            btnPoprzednia.Enabled = false;
            txtNrFigury.Enabled = false;
            // wyznaczenie rozmiaru powierzchni graficznej
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            int Xn, Yn;
            Random rnd = new Random();
            // wykreślenie wszystkich figury geometrycznych z TFG
            for (int i = 0; i < TFG.Length; i++)
            {
                // losowanie nowego położenia
                Xn = rnd.Next(Margines, Xmax - Margines);
                Yn = rnd.Next(Margines, Ymax - Margines);
                // przesunięcie z wykreśleniem i-tej figury geometrycznej
                TFG[i].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xn, Yn);
            }
            // odświeżenie powierzchni graficznej
            pbRysownica.Refresh();
        }

        private void btnNastepna_Click(object sender, EventArgs e)
        {
            int N = int.Parse(txtNrFigury.Text);
            // wymazanie powierzchni graficznej o numerze (indeksie) N
            TFG[N].Wymaz(pbRysownica, Rysownica);
            // wyznaczenie numeru następnej figury do wykreślenia 
            if (N < (TFG.Length - 1))
                N++;
            else
                N = 0;
            // wpisanie nowego numeru do kontrolki TextBox
            txtNrFigury.Text = N.ToString();
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            // wykreślenie nowej figury geometrycznej 
            TFG[N].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            pbRysownica.Refresh();
        }

        private void btnPoprzednia_Click(object sender, EventArgs e)
        {
            int N = int.Parse(txtNrFigury.Text);
            // wymazanie powierzchni graficznej o numerze (indeksie) N
            TFG[N].Wymaz(pbRysownica, Rysownica);
            // wyznaczenie numeru następnej figury do wykreślenia
            if (N == 0)
                N = TFG.Length - 1;
            else
                N--;
            // wpisanie nowego numeru do kontrolki TextBox
            txtNrFigury.Text = N.ToString();
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            // wykreślenie nowej figury geometrycznej 
            TFG[N].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            pbRysownica.Refresh();
        }

        private void LaboratoriumNr2_FormClosing(object sender, FormClosingEventArgs e)
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
                KokpitProjektuNr2Piwowarski FormularzKokpitProjektuNr2Piwowarski = new KokpitProjektuNr2Piwowarski();
                // ukrycie bieżącego formularza 
                this.Hide();
                // odsłonięcie nowego formularza głównego
                this.Show();
            }
            else // anulujemy zmaknięcie formularza
                e.Cancel = true;
        }
    }
}

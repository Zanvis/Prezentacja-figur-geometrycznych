using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2_Piwowarski62024
{
    internal class FiguryGeometryczne
    {
        // deklaracja głównej klasy bazowej
        public class Punkt
        {// deklaracje pomocnicze
            const int PromienPunktu = 5;
            // deklaracja typu wyliczeniowego znaczników figur geometrycznych 
            public enum FiguryGeometryczne : byte { Punkt, Linia, Elipsa, Prostokat, Okrag, Kwadrat };
            // deklaracja aatrybutów klasy Punkt
            public FiguryGeometryczne Figura
            {
                get;
                protected set;
            }
            // aatrybut widoczności 
            public bool Widoczny
            {
                get;
                protected set;
            }
            public int SrednicaPunktu
            {
                get;
                protected set;
            }
            public int X
            {
                get;
                protected set;
            }
            public int Y
            {
                get;
                protected set;
            }
            public Color Kolor
            {
                get;
                protected set;
            }

            // deklaracja atrybutów "ważnych" dla klas potomnych
            public float GruboscLinii
            {
                get;
                protected set;
            }
            public DashStyle StylLinii
            {
                get;
                protected set;
            }
            public Color KolorWypelnienia
            {
                get;
                protected set;
            }

            // deklaracje konstruktorów
            public Punkt(int X, int Y)
            {// ustawienie znacznika figury
                Figura = FiguryGeometryczne.Punkt;
                Widoczny = false;
                SrednicaPunktu = 2 * PromienPunktu;
                this.X = X;
                this.Y = Y;
                // ustawienie wartości domyślnych dla pozostałych atrybutów klasy Punkt
                Kolor = Color.Black;
                GruboscLinii = 1.0f;
                StylLinii = DashStyle.Solid;
                KolorWypelnienia = Color.White;
            }
            public Punkt(int X, int Y, Color KolorPunktu) : this(X, Y)
            {
                Kolor = KolorPunktu;
            }
            public Punkt(int X, int Y, Color KolorPunktu, int SrednicaPunktu) : this(X, Y, KolorPunktu)
            {
                this.SrednicaPunktu = SrednicaPunktu;
            }

            // deklaracja metod
            // prywatne


            // publiczne


            // wirtualne
            public virtual void Wykresl(Graphics Rysownica)
            {// wersja 1
                SolidBrush Pedzel = new SolidBrush(Kolor);
                Rysownica.FillEllipse(Pedzel, X - SrednicaPunktu / 2, Y - SrednicaPunktu / 2, SrednicaPunktu, SrednicaPunktu);
                // ustawienie atrybutu Widoczności
                Widoczny = true;
                // zwolnienie Pędzla
                Pedzel.Dispose();
                // wersja 2
                using (SolidBrush Pedzel2 = new SolidBrush(Kolor))
                {
                    Rysownica.FillEllipse(Pedzel2, X - SrednicaPunktu / 2, Y - SrednicaPunktu / 2, SrednicaPunktu, SrednicaPunktu);
                    // ustawienie atrybutu Widoczności
                    Widoczny = true;
                }
            }
            public virtual void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                // sprawdzenie atrybutu Widoczności
                if (Widoczny)
                    using (SolidBrush Pedzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        Rysownica.FillEllipse(Pedzel, X - SrednicaPunktu / 2, Y - SrednicaPunktu / 2, SrednicaPunktu, SrednicaPunktu);
                        // "zgaszenie" atrybutu Widoczności
                        Widoczny = false;
                    }
            }
            public virtual void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int Xn, int Yn)
            {
                // wpisanie do atrybutów X i Y wartości współrzędnych nowego położenia Punktu
                X = Xn; Y = Yn;
                Wykresl(Rysownica);
            }
        } // koniec klasy Punkt
        // deklaracja klasy Linia
        public class Linia : Punkt
        {// dodanie deklaracji niezbędnych dla wykreślenia linii
            int Xk, Yk;
            // deklaracja konstruktorów
            public Linia(int Xp, int Yp, int Xk, int Yk) : base(Xp, Yp)
            {
                // ustawienie znacznika figury geometrycznej: Linia
                Figura = FiguryGeometryczne.Linia;
                this.Xk = Xk;
                this.Yk = Yk;
            }
            public Linia(int Xp, int Yp, int Xk, int Yk, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(Xp, Yp, KolorLinii)
            {
                // ustawienie znacznika figury geometrycznej: Linia
                Figura = FiguryGeometryczne.Linia;
                this.Xk = Xk;
                this.Yk = Yk;
                this.StylLinii = StylLinii;
                this.GruboscLinii = GruboscLinii;
            }
            // nadpisanie metod wirtualnych
            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor, GruboscLinii))
                {
                    // ustawienie stylu linii 
                    Pioro.DashStyle = StylLinii;
                    // wykreślenie linii
                    Rysownica.DrawLine(Pioro, X, Y, Xk, Yk);
                    // ustawienie atrybutu Widoczności
                    Widoczny = true;
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii))
                    {
                        Pioro.DashStyle = StylLinii;
                        // wymazanie linii
                        Rysownica.DrawLine(Pioro, X, Y, Xk, Yk);
                        // "zgaszenie" atrybutu Widoczności
                        Widoczny = false;
                    }
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int Xn, int Yn)
            {
                // deklaracje pomocnicze: Dx - przyrost zmiany współrzędnej X, Dy - przyrost zmiany współrzędnej Y
                int Dx, Dy;
                // wyznaczenie przyrostu zmiany współrzędnej X
                if (Xn > X)
                    Dx = Xn - X;
                else
                    Dx = X - Xn;
                // wyznaczenie przyrostu zmiany współrzędnej Y
                if (Yn > Y)
                    Dy = Yn - Y;
                else
                    Dy = Y - Yn;
                // przechowanie nowych wartości współrzędnych początku i końca linii
                X = Xn; Y = Yn;
                Xk = (Xk + Dx) % Kontrolka.Width;
                Yk = (Yk + Dy) % Kontrolka.Height;
                // wykreślenie linii w nowym położeniu
                Wykresl(Rysownica);
            }
        } // koniec Linii
        public class Elipsa : Punkt
        {// deklaracja atrybutów niezbędnych do wykreślenia Elipsy
            protected int OsDuza, OsMala;
            // deklaracja konstruktora (lub kontruktorów)
            public Elipsa(int x, int y, int OsDuza, int OsMala, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(x, y, KolorLinii)
            {
                // ustawienie znacznika figury: Elipsa
                Figura = FiguryGeometryczne.Elipsa;
                // ustawienie atrybutu widocznośći
                Widoczny = false;
                this.OsDuza = OsDuza;
                this.OsMala = OsMala;
                this.StylLinii = StylLinii;
                this.GruboscLinii = GruboscLinii;
            }
            // nadpisanie metod wirtualnych zadeklarowanych w klasie Punkt
            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor, GruboscLinii))
                {// ustalenie stylu linii
                    Pioro.DashStyle = StylLinii;
                    // wykreślenie Elipsy
                    Rysownica.DrawEllipse(Pioro, X - OsDuza / 2, Y - OsMala / 2, OsDuza, OsMala);
                    // zmiana atrybutu widoczności
                    Widoczny = true;
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {// sprawdzenie, czy Elipsa jest wykreślona
                if (Widoczny)
                {
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii))
                    {// ustawienie stylu linii
                        Pioro.DashStyle = StylLinii;
                        // wymazanie linii
                        Rysownica.DrawEllipse(Pioro, X - OsDuza / 2, Y - OsMala / 2, OsDuza, OsMala);
                        // aktualizacja atrybutu widoczności
                        Widoczny = false;
                    }
                }
            }
        }
        // deklaracja klasy Okrąg
        public class Okrag : Elipsa
        {
            protected int Promien
            {
                get
                {
                    return OsDuza;
                }
                set
                {
                    OsDuza = value;
                    OsMala = value;
                }
            }
            // deklaracja konstruktora:
            public Okrag(int x, int y, int Promien, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(x, y, 2 * Promien, 2 * Promien, KolorLinii, StylLinii, GruboscLinii)
            {
                Figura = FiguryGeometryczne.Okrag;
                Widoczny = false;
                this.Promien = Promien;
            }
        }
    }
}

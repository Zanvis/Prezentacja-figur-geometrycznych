using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Projekt2_Piwowarski62024
{
    internal class FiguryGeometryczne2
    {
        // deklaracja głównej klasy bazowej
        public class Punkt
        {// deklaracje pomocnicze
            const int PromienPunktu = 5;
            // deklaracja typu wyliczeniowego znaczników figur geometrycznych 
            public enum FiguryGeometryczne : byte { Punkt, Linia, Elipsa, Prostokat, Okrag, Kolo, Kwadrat, ProstokatWypelniony, Wielokat, WielokatWypelniony, ElipsaWypelniona, WycinekELipsy, WypelnionyWycinekElipsy, LukElipsy, KrzywaBeziera, KrzywaKardynalna, ZamknietaKrzywaKardynalna };
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
            protected int Szerokosc, Wysokosc;

            public Elipsa(int Xp, int Yp, int Szerokosc, int Wysokosc, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(Xp, Yp, KolorLinii)
            {
                Figura = FiguryGeometryczne.Elipsa;
                this.Szerokosc = Szerokosc;
                this.Wysokosc = Wysokosc;
                this.StylLinii = StylLinii;
                this.GruboscLinii = GruboscLinii;
            }

            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor, GruboscLinii))
                {
                    Pioro.DashStyle = StylLinii;
                    Rysownica.DrawEllipse(Pioro, X, Y, Szerokosc, Wysokosc);
                    Widoczny = true;
                }
            }

            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii))
                    {
                        Pioro.DashStyle = StylLinii;
                        Rysownica.DrawEllipse(Pioro, X, Y, Szerokosc, Wysokosc);
                        Widoczny = false;
                    }
            }
        }
        public class ElipsaWypelniona : Elipsa
        {
            public ElipsaWypelniona(int Xp, int Yp, int Szerokosc, int Wysokosc, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(Xp, Yp, Szerokosc, Wysokosc, KolorLinii, StylLinii, GruboscLinii)
            {
                Figura = FiguryGeometryczne.ElipsaWypelniona;
                this.Szerokosc = Szerokosc;
                this.Wysokosc = Wysokosc;
            }

            public override void Wykresl(Graphics Rysownica)
            {
                using (SolidBrush Pedzel = new SolidBrush(Kolor))
                {
                    Rysownica.FillEllipse(Pedzel, X, Y, Szerokosc, Wysokosc);
                    Widoczny = true;
                }
            }

            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (SolidBrush Pedzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        Rysownica.FillEllipse(Pedzel, X, Y, Szerokosc, Wysokosc);
                        Widoczny = false;
                    }
            }
        }
        // deklaracja klasy Okrąg
        public class Okrag : Elipsa
        {
            // deklaracja konstruktora:
            public Okrag(int x, int y, int Szerokosc, int Wysokosc, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(x, y, Szerokosc, Szerokosc, KolorLinii, StylLinii, GruboscLinii)
            {
                Figura = FiguryGeometryczne.Okrag;
                Widoczny = false;
                this.Szerokosc = Szerokosc;
                this.Wysokosc = Wysokosc;
            }
        }

        public class Prostokat : Punkt
        {
            protected int Szerokosc, Wysokosc;

            public Prostokat(int Xp, int Yp, int Szerokosc, int Wysokosc, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(Xp, Yp, KolorLinii)
            {
                Figura = FiguryGeometryczne.Prostokat;
                this.Szerokosc = Szerokosc;
                this.Wysokosc = Wysokosc;
                this.StylLinii = StylLinii;
                this.GruboscLinii = GruboscLinii;
            }

            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor, GruboscLinii))
                {
                    Pioro.DashStyle = StylLinii;
                    Rysownica.DrawRectangle(Pioro, X, Y, Szerokosc, Wysokosc);
                    Widoczny = true;
                }
            }

            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii))
                    {
                        Pioro.DashStyle = StylLinii;
                        Rysownica.DrawRectangle(Pioro, X, Y, Szerokosc, Wysokosc);
                        Widoczny = false;
                    }
            }
        }
        public class Kwadrat : Prostokat
        {
            // deklaracja konstruktora:
            public Kwadrat(int x, int y, int Szerokosc, int Wysokosc, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(x, y, Szerokosc, Szerokosc, KolorLinii, StylLinii, GruboscLinii)
            {
                Figura = FiguryGeometryczne.Kwadrat;
                Widoczny = false;
                this.Szerokosc = Szerokosc;
                this.Wysokosc = Wysokosc;
            }
        }
        public class Kolo : Okrag
        {// deklaracja atrybutów niezbędnych do wykreślenia Elipsy
            //protected int Szerokosc, Wysokosc;

            public Kolo(int Xp, int Yp, int Szerokosc, int Wysokosc, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(Xp, Yp, Szerokosc, Szerokosc, KolorLinii, StylLinii, GruboscLinii)
            {
                Figura = FiguryGeometryczne.Kolo;
                this.Szerokosc = Szerokosc;
                this.Wysokosc = Wysokosc;
            }

            public override void Wykresl(Graphics Rysownica)
            {
                using (SolidBrush Pedzel = new SolidBrush(Kolor))
                {
                    Rysownica.FillEllipse(Pedzel, X, Y, Szerokosc, Wysokosc);
                    Widoczny = true;
                }
            }

            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (SolidBrush Pedzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        Rysownica.FillEllipse(Pedzel, X, Y, Szerokosc, Wysokosc);
                        Widoczny = true;
                    }
            }
        }
        public class ProstokatWypelniony : Prostokat
        {// deklaracja atrybutów niezbędnych do wykreślenia Elipsy

            public ProstokatWypelniony(int Xp, int Yp, int Szerokosc, int Wysokosc, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(Xp, Yp, Szerokosc, Wysokosc, KolorLinii, StylLinii, GruboscLinii)
            {
                Figura = FiguryGeometryczne.ProstokatWypelniony;
                this.Szerokosc = Szerokosc;
                this.Wysokosc = Wysokosc;
            }

            public override void Wykresl(Graphics Rysownica)
            {
                using (SolidBrush Pedzel = new SolidBrush(Kolor))
                {
                    Rysownica.FillRectangle(Pedzel, X, Y, Szerokosc, Wysokosc);
                    Widoczny = true;
                }
            }

            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (SolidBrush Pedzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        Rysownica.FillRectangle(Pedzel, X, Y, Szerokosc, Wysokosc);
                        Widoczny = true;
                    }
            }
        }
        public class Wielokat : Punkt
        {
            protected ushort StopienWielokata;
            protected int R;
            protected double KatMiedzyWierzcholkami;
            protected double KatPolozeniaPierwszegoWierzcholka;

            public Wielokat(int Xp, int Yp, ushort StopienWielokata, int R, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(Xp, Yp, KolorLinii)
            {
                Figura = FiguryGeometryczne.Wielokat;
                this.StopienWielokata = StopienWielokata;
                this.R = R;
                KatMiedzyWierzcholkami = 360.0 / StopienWielokata;
                KatPolozeniaPierwszegoWierzcholka = 0.0;
                this.StylLinii = StylLinii;
                this.GruboscLinii = GruboscLinii;
            }
            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor, GruboscLinii))
                {
                    Point[] WierzcholkiWielokata = new Point[StopienWielokata];
                    for (int i = 0; i < StopienWielokata; i++)
                    {
                        WierzcholkiWielokata[i].X = X + (int)(R * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0));
                        WierzcholkiWielokata[i].Y = Y - (int)(R * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0));
                    }

                    Rysownica.DrawPolygon(Pioro, WierzcholkiWielokata);
                    Widoczny = true;
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii))
                    {
                        Point[] WierzcholkiWielokata = new Point[StopienWielokata];
                        for (int i = 0; i < StopienWielokata; i++)
                        {
                            WierzcholkiWielokata[i].X = X + (int)(R * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0));
                            WierzcholkiWielokata[i].Y = Y - (int)(R * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0));
                        }

                        Rysownica.DrawPolygon(Pioro, WierzcholkiWielokata);
                        Widoczny = false;
                    }
            }
        }
        public class WielokatWypelniony : Wielokat
        {
            public WielokatWypelniony(int Xp, int Yp, ushort StopienWielokata, int R, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(Xp, Yp, StopienWielokata, R, KolorLinii, StylLinii, GruboscLinii)
            {
                Figura = FiguryGeometryczne.WielokatWypelniony;
                this.StopienWielokata = StopienWielokata;
                this.R = R;
                KatMiedzyWierzcholkami = 360.0 / StopienWielokata;
                KatPolozeniaPierwszegoWierzcholka = 0.0;
            }
            public override void Wykresl(Graphics Rysownica)
            {
                using (SolidBrush Pedzel = new SolidBrush(Kolor))
                {
                    Point[] WierzcholkiWielokata = new Point[StopienWielokata];
                    for (int i = 0; i < StopienWielokata; i++)
                    {
                        WierzcholkiWielokata[i].X = X + (int)(R * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0));
                        WierzcholkiWielokata[i].Y = Y - (int)(R * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0));
                    }

                    Rysownica.FillPolygon(Pedzel, WierzcholkiWielokata);
                    Widoczny = true;
                }
            }
            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (SolidBrush Pedzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        Point[] WierzcholkiWielokata = new Point[StopienWielokata];
                        for (int i = 0; i < StopienWielokata; i++)
                        {
                            WierzcholkiWielokata[i].X = X + (int)(R * Math.Cos(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0));
                            WierzcholkiWielokata[i].Y = Y - (int)(R * Math.Sin(Math.PI * (KatPolozeniaPierwszegoWierzcholka + i * KatMiedzyWierzcholkami) / 180.0));
                        }

                        Rysownica.FillPolygon(Pedzel, WierzcholkiWielokata);
                        Widoczny = false;
                    }
            }
        }
        public class WycinekELipsy : Punkt
        {// deklaracja atrybutów niezbędnych do wykreślenia Elipsy
            protected int Szerokosc, Wysokosc, PoczatkowyKat, LiczbaStopni;

            public WycinekELipsy(int Xp, int Yp, int Szerokosc, int Wysokosc, int PoczatkowyKat, int LiczbaStopni, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(Xp, Yp, KolorLinii)
            {
                Figura = FiguryGeometryczne.WycinekELipsy;
                this.Szerokosc = Szerokosc;
                this.Wysokosc = Wysokosc;
                this.PoczatkowyKat = PoczatkowyKat;
                this.LiczbaStopni = LiczbaStopni;
                this.StylLinii = StylLinii;
                this.GruboscLinii = GruboscLinii;
            }

            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor, GruboscLinii))
                {
                    Pioro.DashStyle = StylLinii;
                    Rysownica.DrawPie(Pioro, X, Y, Szerokosc, Wysokosc, PoczatkowyKat, LiczbaStopni);
                    Widoczny = true;
                }
            }

            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii))
                    {
                        Pioro.DashStyle = StylLinii;
                        Rysownica.DrawPie(Pioro, X, Y, Szerokosc, Wysokosc, PoczatkowyKat, LiczbaStopni);
                        Widoczny = false;
                    }
            }
        }
        public class WypelnionyWycinekElipsy : WycinekELipsy
        {// deklaracja atrybutów niezbędnych do wykreślenia Elipsy
            public WypelnionyWycinekElipsy(int Xp, int Yp, int Szerokosc, int Wysokosc, int PoczatkowyKat, int LiczbaStopni, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(Xp, Yp, Szerokosc, Wysokosc, PoczatkowyKat, LiczbaStopni, KolorLinii, StylLinii, GruboscLinii)
            {
                Figura = FiguryGeometryczne.WypelnionyWycinekElipsy;
                this.Szerokosc = Szerokosc;
                this.Wysokosc = Wysokosc;
                this.PoczatkowyKat = PoczatkowyKat;
                this.LiczbaStopni = LiczbaStopni;
            }

            public override void Wykresl(Graphics Rysownica)
            {
                using (SolidBrush Pedzel = new SolidBrush(Kolor))
                {
                    Rysownica.FillPie(Pedzel, X, Y, Szerokosc, Wysokosc, PoczatkowyKat, LiczbaStopni);
                    Widoczny = true;
                }
            }

            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (SolidBrush Pedzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        Rysownica.FillPie(Pedzel, X, Y, Szerokosc, Wysokosc, PoczatkowyKat, LiczbaStopni);
                        Widoczny = false;
                    }
            }
        }
        public class LukElipsy : Punkt
        {// deklaracja atrybutów niezbędnych do wykreślenia Elipsy
            protected int Szerokosc, Wysokosc, PoczatkowyKat, LiczbaStopni;

            public LukElipsy(int Xp, int Yp, int Szerokosc, int Wysokosc, int PoczatkowyKat, int LiczbaStopni, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(Xp, Yp, KolorLinii)
            {
                Figura = FiguryGeometryczne.LukElipsy;
                this.Szerokosc = Szerokosc;
                this.Wysokosc = Wysokosc;
                this.PoczatkowyKat = PoczatkowyKat;
                this.LiczbaStopni = LiczbaStopni;
                this.StylLinii = StylLinii;
                this.GruboscLinii = GruboscLinii;
            }

            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor, GruboscLinii))
                {
                    Pioro.DashStyle = StylLinii;
                    Rysownica.DrawArc(Pioro, X, Y, Szerokosc, Wysokosc, PoczatkowyKat, LiczbaStopni);
                    Widoczny = true;
                }
            }

            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii))
                    {
                        Pioro.DashStyle = StylLinii;
                        Rysownica.DrawArc(Pioro, X, Y, Szerokosc, Wysokosc, PoczatkowyKat, LiczbaStopni);
                        Widoczny = false;
                    }
            }
        }
        public class KrzywaBeziera : Punkt
        {// deklaracja atrybutów niezbędnych do wykreślenia Elipsy
            Point Punkt0, Punkt1, Punkt2, Punkt3;

            public KrzywaBeziera(Point Punkt0, Point Punkt1, Point Punkt2, Point Punkt3, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(Punkt0.X, Punkt0.Y, KolorLinii)
            {
                Figura = FiguryGeometryczne.KrzywaBeziera;
                this.Punkt0 = Punkt0;
                this.Punkt1 = Punkt1;
                this.Punkt2 = Punkt2;
                this.Punkt3 = Punkt3;
                this.StylLinii = StylLinii;
                this.GruboscLinii = GruboscLinii;
            }

            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor, GruboscLinii))
                {
                    Pioro.DashStyle = StylLinii;
                    Rysownica.DrawBezier(Pioro, Punkt0, Punkt1, Punkt2, Punkt3);
                    Widoczny = true;
                }
            }

            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii))
                    {
                        Pioro.DashStyle = StylLinii;
                        Rysownica.DrawBezier(Pioro, Punkt0, Punkt1, Punkt2, Punkt3);
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

                Punkt0.X = (Punkt0.X + Dx) % Kontrolka.Width; Punkt0.Y = (Punkt0.Y + Dy) % Kontrolka.Height;
                Punkt1.X = (Punkt1.X + Dx) % Kontrolka.Width; Punkt1.Y = (Punkt1.Y + Dy) % Kontrolka.Height;
                Punkt2.X = (Punkt2.X + Dx) % Kontrolka.Width; Punkt2.Y = (Punkt2.Y + Dy) % Kontrolka.Height;
                Punkt3.X = (Punkt3.X + Dx) % Kontrolka.Width; Punkt3.Y = (Punkt3.Y + Dy) % Kontrolka.Height;

                Wykresl(Rysownica);
            }
        }
        public class KrzywaKardynalna : Punkt
        {// deklaracja atrybutów niezbędnych do wykreślenia Elipsy
            protected Point[] PunktyKrzywej;

            public KrzywaKardynalna(Point[] PunktyKrzywej, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(PunktyKrzywej[0].X, PunktyKrzywej[0].Y, KolorLinii)
            {
                Figura = FiguryGeometryczne.KrzywaKardynalna;
                this.PunktyKrzywej = PunktyKrzywej;
                this.StylLinii = StylLinii;
                this.GruboscLinii = GruboscLinii;
            }

            public override void Wykresl(Graphics Rysownica)
            {
                using (Pen Pioro = new Pen(Kolor, GruboscLinii))
                {
                    Pioro.DashStyle = StylLinii;
                    Rysownica.DrawCurve(Pioro, PunktyKrzywej);
                    Widoczny = true;
                }
            }

            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, GruboscLinii))
                    {
                        Pioro.DashStyle = StylLinii;
                        Rysownica.DrawCurve(Pioro, PunktyKrzywej);
                        Widoczny = false;
                    }
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int Xn, int Yn)
            {
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

                for (int i = 0; i < PunktyKrzywej.Length; i++)
                {
                    PunktyKrzywej[i].X = (PunktyKrzywej[i].X + Dx) % Kontrolka.Width;
                    PunktyKrzywej[i].Y = (PunktyKrzywej[i].Y + Dy) % Kontrolka.Height;
                }

                Wykresl(Rysownica);
            }
        }
        public class ZamknietaKrzywaKardynalna : KrzywaKardynalna
        {// deklaracja atrybutów niezbędnych do wykreślenia Elipsy
            public ZamknietaKrzywaKardynalna(Point[] PunktyKrzywej, Color KolorLinii, DashStyle StylLinii, float GruboscLinii) : base(PunktyKrzywej, KolorLinii, StylLinii, GruboscLinii)
            {
                Figura = FiguryGeometryczne.ZamknietaKrzywaKardynalna;
                this.PunktyKrzywej = PunktyKrzywej;
            }

            public override void Wykresl(Graphics Rysownica)
            {
                using (SolidBrush Pedzel = new SolidBrush(Kolor))
                {
                    Rysownica.FillClosedCurve(Pedzel, PunktyKrzywej);
                    Widoczny = true;
                }
            }

            public override void Wymaz(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                    using (SolidBrush Pedzel = new SolidBrush(Kontrolka.BackColor))
                    {
                        Rysownica.FillClosedCurve(Pedzel, PunktyKrzywej);
                        Widoczny = false;
                    }
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int Xn, int Yn)
            {
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

                for (int i = 0; i < PunktyKrzywej.Length; i++)
                {
                    PunktyKrzywej[i].X = (PunktyKrzywej[i].X + Dx) % Kontrolka.Width;
                    PunktyKrzywej[i].Y = (PunktyKrzywej[i].Y + Dy) % Kontrolka.Height;
                }

                Wykresl(Rysownica);
            }
        }
    }
}

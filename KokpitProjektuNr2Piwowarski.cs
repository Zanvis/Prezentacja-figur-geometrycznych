using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2_Piwowarski62024
{
    public partial class KokpitProjektuNr2Piwowarski : Form
    {
        public KokpitProjektuNr2Piwowarski()
        {
            InitializeComponent();
        }

        private void btnLaboratoriumNr2_Click(object sender, EventArgs e)
        {// sprawdzenie czy już był utworzony egzemplarz formularza LaboratoriumNr2
            foreach (Form Formularz in Application.OpenForms)
                // sprawdzenie, czy został znaleziony formularz LaboratoriumNr2
                if (Formularz.Name == "LaboratoriumNr2")
                {
                    // ukrycie bieżącego formularza
                    this.Hide();
                    // odsłonięcie formularza znalezionego
                    Formularz.Show();
                    // bezwarunkowe zakończenie obsługi zdarzenia Click
                    return;
                }
            /* gdy będziemy tutaj, to poszukiwany fomrularz LaboratoriumNr2 nie został znaleziony,
             a to oznacza, że należy utworzyć egzemplarz tego formularza i go odsłonić */
            LaboratoriumNr2 FormLaboratoriumNr2 = new LaboratoriumNr2();
            // ukrycie bieżącego formularza
            this.Hide();
            // odsłonięcie formularza FormLaboratoriumNr2
            FormLaboratoriumNr2.Show();

        }

        private void btnProjektIndywidualnyNr2_Click(object sender, EventArgs e)
        {
            // sprawdzenie czy już był utworzony egzemplarz formularza LaboratoriumNr2
            foreach (Form Formularz in Application.OpenForms)
                // sprawdzenie, czy został znaleziony formularz LaboratoriumNr2
                if (Formularz.Name == "ProjektIndywidualnyNr2")
                {
                    // ukrycie bieżącego formularza
                    this.Hide();
                    // odsłonięcie formularza znalezionego
                    Formularz.Show();
                    // bezwarunkowe zakończenie obsługi zdarzenia Click
                    return;
                }
            /* gdy będziemy tutaj, to poszukiwany fomrularz LaboratoriumNr2 nie został znaleziony,
             a to oznacza, że należy utworzyć egzemplarz tego formularza i go odsłonić */
            ProjektIndywidualnyNr2 FormProjektIndywidualnyNr2 = new ProjektIndywidualnyNr2();
            // ukrycie bieżącego formularza
            this.Hide();
            // odsłonięcie formularza FormLaboratoriumNr2
            FormProjektIndywidualnyNr2.Show();
        }
    }
}

using Combate.Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combate.Front
{
    public partial class frmInfo : Form
    {

        ListaArmas Lista_Armas = new ListaArmas();
        public frmInfo()
        {
            InitializeComponent();
            DGVListado.DataSource = Lista_Armas.Lista;

            if(Lista_Armas.Selec(1)==null)
            {
                Arma Espada = new Arma(1, "Espada", 3, "Un arma muy afilada");
                Lista_Armas.Insert(Espada);
                Arma Hacha = new Arma(2, "Hacha", 4, "2x1 en filo y contundencia");
                Lista_Armas.Insert(Hacha);
                Arma Pistola = new Arma(3, "Pistola", 7, "Está muy rota,nerféenla");
                Lista_Armas.Insert(Pistola);
            }
        }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

       


    }
}

using Combate.Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combate.Front
{
    public partial class frmMenu : Form
    {
        //hola//

        frmInfo Info = new frmInfo();

        frmJugar Jugar = new frmJugar();

        ListaArmas Lista_Armas = new ListaArmas();

        public frmMenu()
        {
            InitializeComponent();
            

        }
        
        private void btnJugar_Click(object sender, EventArgs e)
        {
            Jugar.Visible = true;

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            
            Info.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

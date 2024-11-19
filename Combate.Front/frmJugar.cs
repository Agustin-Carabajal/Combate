using System;
using Combate.Back;
using Combate.Front;
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
    public partial class frmJugar : Form
    {
        Jugador Jugador1 = new Jugador("Jugador N° 1", 15);

        Jugador Enemigo = new Jugador("Enemigo", 15);

        ListaArmas Lista_Armas = new ListaArmas();

        private Timer timer;


        public frmJugar()
        {
            InitializeComponent();
            LabelsCarga();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            imgBang.Visible = false;
        }

        private void CerrarJ(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        public void LabelsCarga()
        {
            lblEnem.Text = Enemigo.NombreJug;
            lblEnemVida.Text = $"Vida: {Enemigo.Vida.ToString()}"; 
            lblJugNom.Text = Jugador1.NombreJug;
            lblJugVida.Text = $"Vida: {Jugador1.Vida.ToString()}";
        }

        private void btnEspada_Click(object sender, EventArgs e)
        {
            Arma atak = Lista_Armas.Selec(1);

            Enemigo.Vida = Enemigo.Vida - atak.Atk;

            MostrarBang();

            lblEnemVida.Text = $"Vida: {Enemigo.Vida.ToString()}";

            EnemAtac();

            Fin();

        }

        private void btnHacha_Click(object sender, EventArgs e)
        {
            Arma atak = Lista_Armas.Selec(2);

            Enemigo.Vida = Enemigo.Vida - atak.Atk;

            MostrarBang();

            lblEnemVida.Text = $"Vida: {Enemigo.Vida.ToString()}";

            EnemAtac();

            Fin();
        }


        private void btnPistola_Click(object sender, EventArgs e)
        {
            Arma atak = Lista_Armas.Selec(3);

            Enemigo.Vida = Enemigo.Vida - atak.Atk;

            MostrarBang();

            lblEnemVida.Text = $"Vida: {Enemigo.Vida.ToString()}";

            EnemAtac();

            Fin();
        }

        public void Fin()
        {
            if (Enemigo.Vida <= 0)
            {
                DialogResult result = MessageBox.Show("¡GANASTE! ¿Quieres continuar jugando?", "Fin del Juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Jugador1.Vida = 15;
                    lblJugVida.Text = $"Vida: {Jugador1.Vida.ToString()}";
                    Enemigo.Vida = 15;
                    lblEnemVida.Text = $"Vida: {Enemigo.Vida.ToString()}";
                } 
                if (result == DialogResult.No)
                {
                    this.Close();
                    Jugador1.Vida = 15;
                    lblJugVida.Text = $"Vida: {Jugador1.Vida.ToString()}";
                    Enemigo.Vida = 15;
                    lblEnemVida.Text = $"Vida: {Enemigo.Vida.ToString()}";
                }
                    
            }

            if (Jugador1.Vida <= 0)
            {
                DialogResult result = MessageBox.Show("¡PERDISTE! ¿Quieres continuar jugando?", "Fin del Juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    Jugador1.Vida = 15;
                    lblJugVida.Text = $"Vida: {Jugador1.Vida.ToString()}";
                    Enemigo.Vida = 15;
                    lblEnemVida.Text = $"Vida: {Enemigo.Vida.ToString()}";
                }
                if (result == DialogResult.No)
                {
                    this.Close();
                    Jugador1.Vida = 15;
                    lblJugVida.Text = $"Vida: {Jugador1.Vida.ToString()}";
                    Enemigo.Vida = 15;
                    lblEnemVida.Text = $"Vida: {Enemigo.Vida.ToString()}";
                }

            }
        }

        public void EnemAtac()
        {
            Jugador1.Vida = Jugador1.Vida - Azar();
            lblJugVida.Text = $"Vida: {Jugador1.Vida.ToString()}";
        }

        public int Azar()
        {
            Random aleatorio = new Random();
            int numeroAleatorio = aleatorio.Next(1, 7);

            return numeroAleatorio;
        }

        private void MostrarBang()
        {
   
            imgBang.Visible = true;

    
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
 
            timer.Stop();

            imgBang.Visible = false;
        }



        /* public int Puntaje()
         {
             Puntos punto = new Puntos(0);
             punto.GuardarPuntaje(punto);

         }*/
    }
}

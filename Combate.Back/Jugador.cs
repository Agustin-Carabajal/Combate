using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combate.Back
{
    public class Jugador
    {
        public string NombreJug { get; set; }
        public int Vida { get; set; }


        public Jugador(string nomj, int hp)
        {
            NombreJug = nomj;
            Vida = hp;
        }


    }
}

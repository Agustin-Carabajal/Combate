using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combate.Back
{
    public class Arma
    {
        public int ID         { get; set; }
        public string Nombre      { get; set; }
        public int Atk            { get; set; }
        public string Descripcion { get; set; }

      public Arma(int id, string nombre, int atk, string descripcion)
      {
          ID = id;
          Nombre = nombre;
          Atk = atk;
          Descripcion = descripcion;
      }

        public override string ToString()
        {
            return $"Nombre: {Nombre} Ataque: {Atk.ToString()} Descripción: {Descripcion}";
        }


    }  

}

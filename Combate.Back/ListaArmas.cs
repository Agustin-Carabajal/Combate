using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combate.Back
{
    public class ListaArmas
    {
        public DataTable Lista { get; set; } = new DataTable();

        
        public ListaArmas()
        {
            Lista.TableName = "Lista_Armas";
            Lista.Columns.Add("ID", typeof(int));
            Lista.Columns.Add("Nombre");
            Lista.Columns.Add("Atk", typeof(int));
            Lista.Columns.Add("Descripcion");
            
            LeerArchivo();
        }

        private void LeerArchivo()
        {
            if (System.IO.File.Exists("Armas.xml"))
            {
                Lista.ReadXml("Armas.xml");
            }
        }

        public void Insert(Arma arma)
        {
            Lista.Rows.Add();
            int NuevoRenglon = Lista.Rows.Count - 1;
            Lista.Rows[NuevoRenglon]["ID"] = arma.ID;
            Lista.Rows[NuevoRenglon]["Nombre"] = arma.Nombre;
            Lista.Rows[NuevoRenglon]["Atk"] = arma.Atk;
            Lista.Rows[NuevoRenglon]["Descripcion"] = arma.Descripcion;

            Lista.WriteXml("Armas.xml");
        }
        public Arma Selec(int id)
        {
            



            foreach (DataRow row in Lista.Rows)
            {
                if (Convert.ToInt32(row["ID"]) ==id)
                {
                    Arma arma = new Arma(Convert.ToInt32(row["ID"]),
                                         Convert.ToString(row["Nombre"]),
                                         Convert.ToInt32(row["Atk"]),
                                         Convert.ToString(row["Descripcion"])
                    );

                    return arma;
                }
                
            }
            return null;
        }
        
    }
}

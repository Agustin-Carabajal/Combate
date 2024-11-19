using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Combate.Back
{
    public class Puntos
    {
        public int Puntaje { get; set; }

        Puntos(int punto)
        {
            Puntaje = punto;
        }


        private Puntos LeerPuntaje()
        {
            if (System.IO.File.Exists("Puntaje.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Puntos));
                using (StreamReader reader = new StreamReader("Puntaje.xml"))
                {
                    return (Puntos)serializer.Deserialize(reader);
                }
            }
            else
            {
                return null;
            }
        }

        public void GuardarPuntaje(Puntos puntaje)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Puntos));
            using (StreamWriter writer = new StreamWriter("Puntaje.xml"))
            {
                serializer.Serialize(writer, puntaje);
            }
        }




    }
}

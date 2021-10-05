using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Cosmeticos
{

   public  class BrochasBL
    {
        public BindingList<Brochas> ListaBrochas { get; set; }

        public BrochasBL()
        {
            ListaBrochas = new BindingList<Brochas>();

            var Brochas1 = new Brochas();
            Brochas1.Id = 1;
            Brochas1.Descripcion = "BE BELLA Set De Brochas 24 Pcs Take Me To Malibu  ";
            Brochas1.Precio = 790;
            Brochas1.Existencia = 10;
            Brochas1.Activo = true;

            ListaBrochas.Add(Brochas1);

            var Brochas2 = new Brochas();
            Brochas2.Id = 2;
            Brochas2.Descripcion = "SUGAR KISS Set De Brochas 10 Piezas ";
            Brochas2.Precio = 297;
            Brochas2.Existencia = 15;
            Brochas2.Activo = true;

            ListaBrochas.Add(Brochas2);

            var Brochas3 = new Brochas();
            Brochas3.Id = 3;
            Brochas3.Descripcion = "CANDICE Set De Brochas 24 Piezas - Candice ";
            Brochas3.Precio = 395;
            Brochas3.Existencia = 15;
            Brochas3.Activo = true;

            ListaBrochas.Add(Brochas3);

        }
        public BindingList<Brochas> ObtenerBrochas()
        {
            return ListaBrochas;
        }
    }
       public class Brochas


    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }
}


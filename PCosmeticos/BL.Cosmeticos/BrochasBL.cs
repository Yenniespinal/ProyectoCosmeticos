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
      public  BindingList<Brocha> ListaBrochas { get; set; }

        public BrochasBL()
        {
            ListaBrochas = new BindingList<Brocha>();

            var Brocha1 = new Brocha();
            Brocha1.Id = 1;
            Brocha1.Descripcion = "BE BELLA Set De Brochas 24 Pcs Take Me To Malibu  ";
            Brocha1.Precio = 790;
            Brocha1.Existencia = 10;
            Brocha1.Activo = true;

            ListaBrochas.Add(Brocha1);

            var Brocha2 = new Brocha();
            Brocha2.Id = 1;
            Brocha2.Descripcion = "SUGAR KISS Set De Brochas 10 Piezas  ";
            Brocha2.Precio = 297;
            Brocha2.Existencia = 15;
            Brocha2.Activo = true;

            ListaBrochas.Add(Brocha2);

            var Brocha3 = new Brocha();
            Brocha3.Id = 1;
            Brocha3.Descripcion = "CANDICE Set De Brochas 24 Piezas - Candice ";
            Brocha3.Precio = 296;
            Brocha3.Existencia = 15;
            Brocha3.Activo = true;

            ListaBrochas.Add(Brocha3);
        }
        public BindingList<Brocha> ObtenerBrochas()

        {
            return ListaBrochas;
        }

    } 

    public class Brocha
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }
}

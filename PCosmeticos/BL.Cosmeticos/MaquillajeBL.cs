using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Cosmeticos
{
    public class MaquillajeBL
    {
        
 
        public BindingList<Maquillaje > ListaMaquillaje { get; set; }

        public MaquillajeBL()
        {
            ListaMaquillaje = new BindingList<Maquillaje>();

            var Maquillaje1 = new Maquillaje();
            Maquillaje1.Id = 1;
            Maquillaje1.Descripcion = "BEAUTE CREATIONS Paleta Tease Me";
            Maquillaje1.Precio = 250;
            Maquillaje1.Existencia = 15;
            Maquillaje1.Activo = true;

            ListaMaquillaje.Add(Maquillaje1);

            var Maquillaje2 = new Maquillaje();
            Maquillaje2.Id = 2;
            Maquillaje2.Descripcion = "AMORUS Paleta Nude Fantasía";
            Maquillaje2.Precio = 440;
            Maquillaje2.Existencia = 15;
            Maquillaje2.Activo = true;

            ListaMaquillaje.Add(Maquillaje2);

            var Maquillaje3 = new Maquillaje();
            Maquillaje3.Id = 3;
            Maquillaje3.Descripcion = " KTB Bases Stay All Day";
            Maquillaje3.Precio = 395;
            Maquillaje3.Existencia = 20;
            Maquillaje3.Activo = true;

            ListaMaquillaje.Add(Maquillaje3);

            var Maquillaje4 = new Maquillaje();
            Maquillaje4.Id = 4;
            Maquillaje4.Descripcion = " L.A COLOR Base Truly Matte";
            Maquillaje4.Precio = 225;
            Maquillaje4.Existencia = 20;
            Maquillaje4.Activo = true;

            ListaMaquillaje.Add(Maquillaje4);

            var Maquillaje5 = new Maquillaje();
            Maquillaje5.Id = 5;
            Maquillaje5.Descripcion = " BEAUTY CREATION Poreless Primer";
            Maquillaje5.Precio = 250;
            Maquillaje5.Existencia = 20;
            Maquillaje5.Activo = true;

            ListaMaquillaje.Add(Maquillaje5);


            var Maquillaje6 = new Maquillaje();
            Maquillaje6.Id = 6;
            Maquillaje6.Descripcion = "TOO FACED Deliniador Better tha sex";
            Maquillaje6.Precio = 1147;
            Maquillaje6.Existencia = 10;
            Maquillaje6.Activo = true;

            ListaMaquillaje.Add(Maquillaje6);

            var Maquillaje7 = new Maquillaje();
            Maquillaje7.Id = 7;
            Maquillaje7.Descripcion = "WET N WILD Deliniador Liquido Mega Liner ";
            Maquillaje7.Precio = 196;
            Maquillaje7.Existencia = 10;
            Maquillaje7.Activo = true;

            ListaMaquillaje.Add(Maquillaje7);

            var Maquillaje8 = new Maquillaje();
            Maquillaje8.Id = 8;
            Maquillaje8.Descripcion = "MAC COSMETICS Labiales Mac Travel Exclusive ";
            Maquillaje8.Precio = 990;
            Maquillaje8.Existencia = 5;
            Maquillaje8.Activo = true;

            ListaMaquillaje.Add(Maquillaje8);

            var Maquillaje9 = new Maquillaje();
            Maquillaje9.Id = 9;
            Maquillaje9.Descripcion = "BEAUTY CREATIONS Lispstick barra Matte";
            Maquillaje9.Precio = 120;
            Maquillaje9.Existencia = 20;
            Maquillaje9.Activo = true;

            ListaMaquillaje.Add(Maquillaje9);

            var Maquillaje10 = new Maquillaje();
            Maquillaje10.Id = 10;
            Maquillaje10.Descripcion = "BEAUTY CREATIONS Mascara Thickening ";
            Maquillaje10.Precio = 290;
            Maquillaje10.Existencia = 15;
            Maquillaje10.Activo = true;

            ListaMaquillaje.Add(Maquillaje10);

        }
        public BindingList<Maquillaje> ObtenerMaquillaje()
        {
            return ListaMaquillaje;
        }
        public class Maquillaje
        {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }


   }
}
}

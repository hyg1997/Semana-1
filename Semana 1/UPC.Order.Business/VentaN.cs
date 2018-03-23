using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.Order.Entities;

namespace UPC.Order.Business
{
    public class VentaN : IVenta
    {
        public double AsignaPrecio(Orden o)
        {
            switch (o.producto.descripcion)
            {
                case "Mouse": return 20;
                case "Teclado": return 35;
                case "Impresora": return 350;
                case "Monitor": return 550;
                case "Parlantes": return 50;
            }
            return 0;
        }

        public double CalcularSubtotal(Orden o)
        {
            return o.producto.precio;
        }

        public double CalcularDescu(Orden o)
        {
            if (o.subtotal <= 30) return o.subtotal * 0.05;
            else if (o.subtotal > 300 & o.subtotal < 500) return o.subtotal * 0.10;
            else return o.subtotal * 0.125;
        }

        public double CalcularNeto(Orden o)
        {
            return o.subtotal - o.descuento;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.Order.Entities;

namespace UPC.Order.Business
{
    public interface IVenta
    {
        double AsignaPrecio(Orden o);
        double CalcularSubtotal(Orden o);
        double CalcularDescu(Orden o);
        double CalcularNeto(Orden o);
    }
}

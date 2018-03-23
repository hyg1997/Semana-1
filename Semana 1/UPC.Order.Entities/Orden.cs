using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.Order.Entities
{
    public class Orden
    {
        public Cliente cliente { get; set; }
        public Producto producto { get; set; }
        public Int32 cantidad { get; set; }
        public Double subtotal { get; set; }
        public Double descuento { get; set; }
        public Double neto { get; set; }
    }
}

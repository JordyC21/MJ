using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foxstore.Models
{
    public class Carrito
    {
        public int IdCarrito { get; set; }
        public Producto oProducto { get; set; }
        public Usuario oUsuario { get; set; }
    }
}
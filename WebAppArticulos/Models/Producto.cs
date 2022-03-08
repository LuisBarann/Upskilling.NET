﻿using System;

namespace WebAppArticulos.Models
{
    public class Producto
    {
        public long ProductoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Codigo { get; set; }
        public int PrecioUnitario { get; set; }
        public int Stock { get; set; }
        public long CategoriaId { get; set; }
        public int Eliminado { get; set; }

        public Categoria Categoria { get; set; }

    }
}

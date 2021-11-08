using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmeticos.Shared.Data.Entidades
{
    [Index(nameof(Id), Name = "UQ_Orden_Id", IsUnique = true)]
    public class Orden
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar un producto.")]
        public string Producto { get; set; }

        [Required(ErrorMessage = "Debe ingresar una cantidad.")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "Debe ingresar un telefono.")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "Debe ingresar su domicilio.")]
        public string Domicilio { get; set; }
    
    }
}

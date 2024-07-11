using Restaurant.Common.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Cliente.Domain.Entities
{
    [Table("Empleado", Schema = "dbo")]
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string? Nombre { get; set; }
        public string? Cargo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Common.Data.Base
{
    public abstract class AuditEntity : BaseEntity
    {
       public String? Nombre { get; set; }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using Restaurant.Cliente.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Cliente.Persistance.Context
{

    public class RestaurantContext : DbContext
    {
        #region"Constructor"
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {
        }
        #region"Db Sets"
        public DbSet<Domain.Entities.Empleado> Empleados { get; set; }
        public DbSet<Domain.Entities.Cliente> Clientes { get; set; }

     
        #endregion
        #endregion
    }
}
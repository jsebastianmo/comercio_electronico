﻿using CarroCompras.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CarroCompras.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Usuario>  Usuarios { get; set; }
    }
}

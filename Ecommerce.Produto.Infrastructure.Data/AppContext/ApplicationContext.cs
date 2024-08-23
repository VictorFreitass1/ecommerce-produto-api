﻿using Ecommerce.Produto.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Produto.Infrastructure.Data.AppContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<ProdutoEntity> Produto { get; set; }
        public DbSet<CategoriaEntity> Categoria { get; set; }
    }
}

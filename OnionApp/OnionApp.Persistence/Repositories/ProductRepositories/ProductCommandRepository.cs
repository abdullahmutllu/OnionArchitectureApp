using Microsoft.EntityFrameworkCore;
using OnionApp.Domain.Entities;
using OnionApp.Domain.Repositories.ProductRepositories;
using OnionApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Persistence.Repositories.ProductRepositories
{
    public class ProductCommandRepository :  CommandRepository<Product>, IProductCommandRepository 
    {
        public ProductCommandRepository(AppDbContext context) : base(context)
        {

        }
    }
}

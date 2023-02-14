using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionApp.Domain.Entities;
using OnionApp.Persistence.Constans;

namespace OnionApp.Persistence.Configuration
{
    public sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(TableNames.Products);
            builder.HasKey(p => p.Id);
            builder.HasOne(x=>x.Company).WithMany(x=>x.Products).HasForeignKey(x=>x.CompanyId);
            builder.Property(x=>x.Price).HasColumnType("money");
            builder.Property(x => x.Stock).HasColumnType("decimal(18,2)");
        }
    }
}

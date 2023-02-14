using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionApp.Domain.Entities;
using OnionApp.Persistence.Constans;

namespace OnionApp.Persistence.Configuration
{
    public sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(TableNames.Orders);
            builder.HasKey(X=>X.Id);
            builder.HasOne(x=>x.Product).WithMany(x => x.Orders).HasForeignKey(x=>x.ProductId);
          
        }
    }
}

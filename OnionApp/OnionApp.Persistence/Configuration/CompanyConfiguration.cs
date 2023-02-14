using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionApp.Domain.Entities;
using OnionApp.Persistence.Constans;

namespace OnionApp.Persistence.Configuration
{
    public sealed class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable(TableNames.Compaines);
            builder.HasKey(x=>x.Id);
         
        }
    }
}
    
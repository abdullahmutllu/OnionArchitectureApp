using OnionApp.Domain.Base;

namespace OnionApp.Domain.Entities
{
    public sealed class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public decimal Stock { get; set; }
        public decimal Price { get; set; }

        public string CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}

using OnionApp.Domain.Base;

namespace OnionApp.Domain.Entities
{
    public sealed class Order : BaseEntity
    {
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public string FirmaId { get; set; }
        //public string CompanyId { get; set; }
        //public Company Company { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}

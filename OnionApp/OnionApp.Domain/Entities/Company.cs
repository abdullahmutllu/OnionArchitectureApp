using OnionApp.Domain.Base;

namespace OnionApp.Domain.Entities
{
    public sealed class Company : BaseEntity
    {
        public string CompanyName { get; set; }
        public bool ApprovalStatus { get; set; } // onay durumu 
        public int OrderStartTimeHour { get; set; }
        public int OrderStartTimeMinute { get; set; }
        public int OrderFinishTimeHour { get; set; }
        public int OrderFinishTimeMinute { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}

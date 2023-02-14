using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Base
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }
        public DateTime CreeatedDate { get; set; }
        public DateTime UptatedDate { get; set; }
    }
}

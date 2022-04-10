using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        //Bir Orderın birden fazla Product u olduğunu ifade ediyor.
        public ICollection<Product> Products { get; set; }

        //Bir Orderin sadece bir tane Customerı vardır.

        public Customer Customer { get; set; }  

    }
}

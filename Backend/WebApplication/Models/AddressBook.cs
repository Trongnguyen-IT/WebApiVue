using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace T.Domain
{
    public class AddressBook: BaseEntity
    {
        public string Address { get; set; }
        public int? LocationId { get; set; }

        #region Reference
        [ForeignKey(nameof(LocationId))]
        public virtual Location Location { get; set; }
        //=> toggle on will cause slow Order getAll query
        //public virtual ICollection<Order> SupplierOrders { get; set; }
        //public virtual ICollection<Order> CustomerOrders { get; set; }
        #endregion
    }
}

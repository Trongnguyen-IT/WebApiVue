using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace T.Domain
{
    public class History : BaseEntity
    {
        public int RuleId { get; set; }
        public string RuleName { get; set; }
        public int? SupplierId { get; set; }
        public int? ProductId { get; set; }
        [ForeignKey(nameof(SupplierId))]
        public AddressBook Supplier { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        [ForeignKey(nameof(RuleId))]
        public DynamicRule DynamicRule { get; set; }

    }
}

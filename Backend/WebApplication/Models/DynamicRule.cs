using System.ComponentModel.DataAnnotations.Schema;

namespace T.Domain
{
    public class DynamicRule : BaseEntity
    {
        public string RuleName { get; set; }

        #region reference

        public int SupplierId { get; set; }
        [ForeignKey(nameof(SupplierId))]
        public virtual AddressBook Supplier { get; set; }

        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }

        #endregion
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class ShopBridgeBaseModel
    {
        public bool IsActive { get; set; }

        [ForeignKey("CreatedBy")]
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        [ForeignKey("UpdatedBy")]
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class ShopBridgeBaseModel
    {
        public ShopBridgeBaseModel() {
            IsDeleted = false;
            IsActive = true;
        }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey("CreatedBy")]
        public int CreatedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; }

        [ForeignKey("UpdatedBy")]
        public int? UpdatedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? UpdatedOn { get; set; }
    }
}

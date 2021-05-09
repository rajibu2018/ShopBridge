using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModel
{
    [Table("tblShopBridgeItems")]
    public class ShopBridgeItemModel : ShopBridgeBaseModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        [ForeignKey("CreatedBy")]
        public ShopBridgeUserModel CreatedByUser { get; set; }

        [ForeignKey("UpdatedBy")]
        public ShopBridgeUserModel UpdatedByUser { get; set; }

    }
}

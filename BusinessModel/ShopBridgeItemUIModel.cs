using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel
{
    public class ShopBridgeItemUIModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public int CreatedByUserId { get; set; }
        public int CreatedByUserName { get; set; }
        public int CreatedOn { get; set; }
        public int UpdatedByUserId { get; set; }
        public int UpdatedByUserName { get; set; }
        public int UpdatedOn { get; set; }

    }
}

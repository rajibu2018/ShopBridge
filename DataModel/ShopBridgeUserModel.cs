using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataModel
{
   public class ShopBridgeUserModel:ShopBridgeBaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Designation { get; set; }
    }
}

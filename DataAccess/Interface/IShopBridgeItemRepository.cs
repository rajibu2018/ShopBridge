using DataModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface IShopBridgeItemRepository
    {
        Task<ShopBridgeItemModel> Create(ShopBridgeItemModel model);
    }
}

using DataAccess.Interface;
using DataModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Impl
{
    class ShopBridgeItemRepository : IShopBridgeItemRepository
    {
        public Task<ShopBridgeItemModel> Create(ShopBridgeItemModel model) {
            throw new NotImplementedException();
        }
    }
}

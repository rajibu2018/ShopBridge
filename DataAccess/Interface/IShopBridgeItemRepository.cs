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
        Task<ShopBridgeItemModel> Read(int key);
        Task<bool> Update(ShopBridgeItemModel model, int key);
        Task<bool> Delete(int key);
        Task<List<ShopBridgeItemModel>> GetItems();
    }
}

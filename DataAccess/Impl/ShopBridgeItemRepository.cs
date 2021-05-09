using DataAccess.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Impl
{
    class ShopBridgeItemRepository : IShopBridgeItemRepository
    {
        protected readonly MyDBContext DBContext;
        public ShopBridgeItemRepository(MyDBContext myDBContext) {
            DBContext = myDBContext;
        }
        public async Task<ShopBridgeItemModel> Create(ShopBridgeItemModel model) {
            DBContext.Set<ShopBridgeItemModel>().Add(model);
            await DBContext.SaveChangesAsync();
            return model;
        }

        public async Task<bool> Delete(int key) {
            var exist = await DBContext.Set<ShopBridgeItemModel>().FindAsync(key);
            if (exist != null) {
                exist.IsDeleted = true;
                DBContext.Entry(exist).CurrentValues.SetValues(exist);
                await DBContext.SaveChangesAsync();
            }
            return true;
        }

        public  Task<List<ShopBridgeItemModel>> GetItems() {
            throw new NotImplementedException();
        }

        public async Task<ShopBridgeItemModel> Read(int key) {
          return  await DBContext.Set<ShopBridgeItemModel>().FindAsync(key);
        }

        public async Task<bool> Update(ShopBridgeItemModel model, int key) {
            
            var exist = await DBContext.Set<ShopBridgeItemModel>().FindAsync(key);
            if (exist != null) {
                DBContext.Entry(exist).CurrentValues.SetValues(model);
                await DBContext.SaveChangesAsync();
            }
            return true;
        }
    }
}

using BusinessModel;
using DataAccess.Interface;
using DataModel;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Impl
{
   public class ShopBridgeItemService : IShopBridgeItemService
    {
        public IShopBridgeItemRepository ShopBridgeItemRepository { get; set; }
        public ShopBridgeItemService(IShopBridgeItemRepository shopBridgeItemRepository) {
            ShopBridgeItemRepository = shopBridgeItemRepository;
        }
        public async Task <ShopBridgeItemUIModel> Create(ShopBridgeItemUIModel uiModel) {
            if (string.IsNullOrEmpty(uiModel.Name)) {
                throw new ApplicationException("Name is required");
            }
            
            try {               
                var dataModel = new ShopBridgeItemModel {
                    Name = uiModel.Name,
                    Description = uiModel.Description,
                    Price = uiModel.Price,
                    ImagePath = uiModel.ImagePath,
                    CreatedBy = uiModel.CreatedByUserId,
                    CreatedOn = DateTime.Now
                };
                dataModel =await ShopBridgeItemRepository.Create(dataModel);
                uiModel.Id = dataModel.Id;
            } catch (Exception ex) {

                throw ex;
            }
            return uiModel;
        }       
    }
}

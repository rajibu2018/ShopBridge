using BusinessModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IShopBridgeItemService
    {
        Task<ShopBridgeItemUIModel> Create(ShopBridgeItemUIModel uiModel);
    }
}

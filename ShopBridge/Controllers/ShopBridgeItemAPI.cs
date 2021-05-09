using BusinessModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Interface;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopBridge.Controllers
{
    [Route("api/ShopBridgeItem")]
    [ApiController]
    public class ShopBridgeItemAPI : ControllerBase
    {
        public ILogger<ShopBridgeItemAPI> Logger { get; set; }
        public IShopBridgeItemService ShopBridgeItemService { get; set; }


        public ShopBridgeItemAPI(ILogger<ShopBridgeItemAPI> logger, IShopBridgeItemService shopBridgeItemService) {
            Logger = logger;
            ShopBridgeItemService = shopBridgeItemService;
        }
        public async Task<ShopBridgeItemUIModel> CreateItem(ShopBridgeItemUIModel shopbridgeItemUIModel) {
            try {
                return await ShopBridgeItemService.Create(shopbridgeItemUIModel);
            } catch (ApplicationException ax) {
                Logger.LogWarning(ax.Message);
                throw ax;
            } catch (Exception ex) {
                Logger.LogError(ex.Message);
                throw ex;
            }            
        }

    }
}

using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccesLayer.Concrete;

namespace SignalRApi.Hubs
{
    public class SignalRHub:Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;

        public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderService orderService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
        }

        public async Task SendStatistic()
        {
            var value = _categoryService.TCategoryCount();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);

            var value2 = _productService.TProductCount();
            await Clients.All.SendAsync("ReceiveProductCount", value2);

            var value3 = _categoryService.TActiveCategoryCount();
            await Clients.All.SendAsync("ReceiveActiveCategoryCount", value3);

            var value4 = _categoryService.TPassiveCategoryCount();
            await Clients.All.SendAsync("ReceivePassiveCategoryCount", value4);
            
            var value5 = _productService.TProductCountCategoryNameHamburger();
            await Clients.All.SendAsync("ReceiveProductCountCategoryNameHamburger", value5);

            var value6 = _productService.TProductCountCategoryNameDrink();
            await Clients.All.SendAsync("ReceiveProductCountCategoryNameDrink", value6);
            
            var value7 = _productService.TProductPriceAvg();
            await Clients.All.SendAsync("ReceiveProductPriceAvg", value7.ToString("0.00") + "₺");

            var value8 = _productService.TProductNameByMaxPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMaxPrice", value8);

            var value9 = _productService.TProductNameByMinPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMinPrice", value9);

            var value10 = _productService.TProductAvgPriceByHamburger();
            await Clients.All.SendAsync("ReceiveProductAvgPriceByHamburger", value10.ToString("0.00") + "₺");

            var value11 = _orderService.TTotalOrderCount();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", value11); 
            
            var value12 = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value12);
        }
    }
}

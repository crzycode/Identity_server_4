using Identity_server_4.Model;

namespace Identity_server_4.Services
{
    public interface ICoffeeShopService
    {
        Task<List<CoffeeShop>> List();
    }
}

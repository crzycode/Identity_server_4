using DataAccess.Data;
using Identity_server_4.Model;
using Microsoft.EntityFrameworkCore;

namespace Identity_server_4.Services
{
    public class CoffeeShopService:ICoffeeShopService
    {
        private readonly AppDbContext dbContext;
        public CoffeeShopService(AppDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }
       public async Task<List<CoffeeShop>> List()
        {
            var coffeeshop = await (from shop in dbContext.coffeeShops
                                    select new CoffeeShop()
                                    {
                                        Id = shop.Id,
                                        Name = shop.Name,
                                        OpeningHours = shop.OpeningHours,
                                        Address = shop.Address
                                    }).ToListAsync();

            return coffeeshop;
        }
    }
}

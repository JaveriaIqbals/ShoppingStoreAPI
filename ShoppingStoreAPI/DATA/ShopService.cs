using Microsoft.EntityFrameworkCore;

namespace ShoppingStoreAPI.DATA
{
    public class ShopService : IShopService
    {
        private ShoppingStoreDbContext _db;

        public ShopService(ShoppingStoreDbContext db)
        {
            _db = db;
        }
        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _db.customers.ToListAsync();
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            // Find the Customer with given Id
            var cust = await _db.customers.FindAsync(id);
            return cust;
        }
        public async Task<Customer> AddCustomer(Customer cust)
        {
            _db.customers.Add(cust);
            await _db.SaveChangesAsync();
            return cust;
        }

        public async Task UpdateCustomer(Customer cust)
        {
            _db.Entry(cust).State = EntityState.Modified;
            await _db.SaveChangesAsync();

        }

        public async Task DeleteCustomer(int id)
        {
            var cust = _db.customers.Find(id);
            if(cust != null)
            {
                _db.customers.Remove(cust);
                await _db.SaveChangesAsync();
            }
        }

    }
}

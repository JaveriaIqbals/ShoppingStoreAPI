namespace ShoppingStoreAPI.DATA
{
    // Async and Await methods: Asynchronous Communication
    public interface IShopService
    {
        public Task<List<Customer>> GetAllCustomers();
        public Task<Customer> GetCustomerById(int id);
        public Task<Customer> AddCustomer(Customer cust);
        public Task UpdateCustomer(Customer cust);
        public Task DeleteCustomer(int id);
    }
}

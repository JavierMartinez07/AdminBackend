using AdminBackend.Models;

namespace AdminBackend.Repositories
{
    public class CustomerRepository : BaseRepository
    {
        public static List<Customer> Get()
        {
            string query = "Select * from Customer";
            return Query<Customer>(query);
        }

        public static List<Customer> Get(int Id)
        {
            string query = "Select * from Customer Where Id = @Id";
            return Query<Customer>(query, new { Id });
        }

        public static List<Customer> GetByCompanyId(int Id)
        {
            string query = @"
            Select ct.* from Customer ct join Company cp
            on ct.CompanyId = cp.Id
            Where cp.Id = @Id
            ";
            return Query<Customer>(query, new { Id });
        }

        public static void Delete(int Id)
        {
            string query = "Delete from Customer Where Id = @Id";
            Query<Customer>(query, new { Id });
        }

        public static int Insert(Customer model)
        {
            string query = @"
            Insert Into Customer(Name, LastName, CompanyId) 
            Values (@Name, @LastName, @CompanyId)
            Select @@IDENTITY ";
            return Query<int>(query, model).FirstOrDefault();
        }

        public static void Update(Customer model)
        {
            string query = @"
            Update Customer set 
            Name = Name, 
            LastName = @LastName, 
            CompanyId = @CompanyId
            Where Id = @Id ";
            Query<int>(query, model);
        }
    }
}

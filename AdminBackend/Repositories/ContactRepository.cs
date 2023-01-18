using AdminBackend.Models;

namespace AdminBackend.Repositories
{
    public class ContactRepository : BaseRepository
    {
        public static List<Contact> Get()
        {
            string query = "Select * from Contact";
            return Query<Contact>(query);
        }

        public static List<Contact> Get(int Id)
        {
            string query = "Select * from Contact Where Id = @Id";
            return Query<Contact>(query, new { Id });
        }

        public static List<Contact> GetByCustomerId(int Id)
        {
            string query = @"
            Select ct.* from Contact ct join Customer cm
            on ct.CustomerId = cm.Id
            Where cm.Id = @Id
            ";
            return Query<Contact>(query, new { Id });
        }

        public static void Delete(int Id)
        {
            string query = "Delete from Contact Where Id = @Id";
            Query<Contact>(query, new { Id });
        }

        public static int Insert(Contact model)
        {
            string query = @"
            Insert Into Contact(Address, PhoneNumber, Email, CustomerId) 
            Values (@Address, @PhoneNumber, @Email, @CustomerId)
            Select @@IDENTITY ";
            return Query<int>(query, model).FirstOrDefault();
        }

        public static void Update(Contact model)
        {
            string query = @"
            Update Contact set 
            Address = @Address, 
            PhoneNumber = @PhoneNumber, 
            Email = @Email, 
            CustomerId = @CustomerId
            Where Id = @Id ";
            Query<int>(query, model);
        }
    }
}

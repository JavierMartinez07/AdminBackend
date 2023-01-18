
using AdminBackend.Models;

namespace AdminBackend.Repositories
{
    public class CompanyRepository : BaseRepository
    {

        public static List<Company> Get()
        {
            string query = "Select * from Company";
            return Query<Company>(query);
        }

        public static List<Company> Get(int Id)
        {
            string query = "Select * from Company Where Id = @Id";
            return Query<Company>(query, new { Id });
        }
        public static void Delete(int Id)
        {
            string query = "Delete from Company Where Id = @Id";
            Query<Company>(query, new { Id });
        }


        public static int Insert(Company model)
        {
            string query = @"
            Insert Into Company(Name, Description) Values (@Name, @Description)
            Select @@IDENTITY ";
            return Query<int>(query, model).FirstOrDefault();
        }

        public static void Update(Company model)
        {
            string query = @"
            Update Company set Name = @Name, Description = @Description
            Where Id = @Id ";
            Query<int>(query, model);
        }


    }
}



namespace CRUD_OPERATIONS.Service
{
    public class UserDAL
    {
        string ConnectionString = string.Empty;
        private readonly IConfiguration configuration;

        public UserDAL(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DBConnection");
        }

        //CRUD OPERATIONS


    }
} 

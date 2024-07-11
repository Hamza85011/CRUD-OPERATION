using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace CRUD_OPERATIONS.Models
{
    public class Employee
    { 
        public int Id { get; set; }
     
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
        
        public int Age { get; set; }
      
        public string Gender { get; set; }
    }
}

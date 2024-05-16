using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracking.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }
        public override string getInfo()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class PersonModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        /*
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName} {Birthday} {Address}";
            }
        }
        */
    }
}

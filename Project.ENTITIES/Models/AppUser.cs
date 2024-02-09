using Project.ENTITIES.Abstract;
using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public  class AppUser:BaseEntity
    {
        public string UserName { get; set; }
        public string Passaword { get; set; }
        public AppUserRole Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        //Relational Properties
        public virtual List<Order> Orders { get; set; }
    }
}

using Project.ENTITIES.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ProductDetail:BaseEntity
    {
        public string ImageFile { get; set; }
        public string Comment { get; set; }
        //Relational Properties
        public virtual Product Product { get; set; }
    }
}

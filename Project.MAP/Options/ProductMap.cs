using Project.ENTITIES.Models;
using Project.MAP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ProductMap:BaseMap<Product>
    {
        public ProductMap()
        {
            HasOptional(x => x.ProductDetail).WithRequired(x => x.Product);
        }
    }
}

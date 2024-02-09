using Project.ENTITIES.Models;
using Project.MAP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class OrderDetailMap:BaseMap<OrderDetail>
    {
        public OrderDetailMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.ProductID,
                x.OrderID
            });
        }
        /*
         n-n ilişkilerde ilişki  n-1 1-n şeklinde ilişkiye sahip ekstra bir tablo ile verilir ve bu tabloda PK olmaması gerekir !!! FK'lar ProductID ve OrderID'dir 
         */
    }
}

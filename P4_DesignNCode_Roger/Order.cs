using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_DesignNCode_Roger
{
    public abstract class Order
    {
        public int id;
        public int user_id;
        public DateTime date;
        public List<String> products;
        public int quantity;
        public int final_price;
    }
}

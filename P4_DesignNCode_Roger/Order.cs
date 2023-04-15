using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_DesignNCode_Roger
{
    public abstract class Order
    {
        private int id;
        private int user_id;
        public string user_name;
        public DateTime date;
        private List<String> products;
        private int quantity;
        private int final_price;
    }
}

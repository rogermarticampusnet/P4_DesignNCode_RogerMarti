using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_DesignNCode_Roger
{
    public class Wishlist
    {
        private int id;
        private int user_id;
        public string user_name;
        public List<String> products;

        public float NumberOfProducts()
        {
            return products.Count;
        }
    }   
}

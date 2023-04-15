using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_DesignNCode_Roger
{
    public abstract class Review
    {
        public int id;
        public int user_id;
        public int product_id;
        public int rating;
        public string comment;
    }
}

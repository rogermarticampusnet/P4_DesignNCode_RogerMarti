using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_DesignNCode_Roger
{
    public class Product
    {
        public int id;
        private bool visible;
        public string name;
        public string brand;
        public List<String> images; // Lista de las URLs de las imágenes
        public string description;
        public Category category;
    }
    public class Category
    {
        protected int id;
        public string name;
    }
    public class Subcategory : Category
    {
        public string subcategory_name;
    }
    public class SubSub : Subcategory
    {
        public string subsub_name;
    }
}

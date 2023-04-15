using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_DesignNCode_Roger
{
    public abstract class Product
    {
        public int id;
        public bool visible;
        public string name;
        public string brand;
        public List<String> images; // Lista de las URLs de las imágenes
        public string description;
    }
    public class Category
    {
        public int id;
        public string name;
    }
    public class Subcategory
    {
        public int id;
        public int parent_id; // ID de la categoría
        public string name;
    }
    public class SubSub
    {
        public int id;
        public int parent_id; // ID de la subcategoría
        public string name;
    }
}

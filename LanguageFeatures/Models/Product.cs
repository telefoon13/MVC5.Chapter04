using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public class Product
    {
        private String name;
        private int productID;
        private String description;
        private decimal price;
        private String category;

        public String Category
        {
            get { return category; }
            set { category = value; }
        }


        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }


        public String Description
        {
            get { return description; }
            set { description = value; }
        }


        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }


        public String Name
        {
            get { return productID + name; }
            set { name = value; }
        }

    }
}
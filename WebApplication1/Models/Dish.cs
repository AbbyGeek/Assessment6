using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Dish
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string DishName { get; set; }
        public string Desc { get; set; }
        public string Options { get; set; }

        public Dish() { }

        public Dish(string name, string number, string dishName, string desc, string options)
        {
            Name = name;
            Number = number;
            DishName = dishName;
            Desc = desc;
            Options = options;
        }
    }
}
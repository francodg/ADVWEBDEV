using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryListManager.Models
{
    public class Item
    {

        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public bool purchased { get; set; }
    }
}

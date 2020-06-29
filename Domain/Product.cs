using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public  class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Prize { get; set; }
        public int Stock { get; set; }
    }
}

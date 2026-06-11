using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Webshop.Model
{
    class Order
    {
        public Order()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        
    }
}

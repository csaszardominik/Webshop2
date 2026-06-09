using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Webshop.Model
{
    class SmartDevice
    {
        public SmartDevice()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}

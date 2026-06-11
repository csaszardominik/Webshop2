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

        public SmartDevice(string deviceName, int price, int releaseDate, string description)
        {
            DeviceName = deviceName;
            Price = price;
            ReleaseDate = releaseDate;
            Description = description;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public int Price { get; set; }
        public int ReleaseDate { get; set; }
        public string Description { get; set; }


    }
}

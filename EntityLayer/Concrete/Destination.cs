using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        public int DestinationID { get; set; }

        public string City { get; set; }

        // Kalınan Gece
        public string DayNight { get; set; }

        // Ücret
        public double Price { get; set; }

        // Container İçerisindeki Resim
        public string Image { get; set; }

        // Açıklama
        public string Description { get; set; }

        // Kapasite
        public int Capacity { get; set; }

        // Aktif mi Pasif mi
        public bool Status { get; set; }
    }
}
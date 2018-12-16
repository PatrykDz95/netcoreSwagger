using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netCore.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Brand { get; set; }
        public string ChangeDate { get; set; }
        public string Deeplink { get; set; }
        public string Description { get; set; }

        public ICollection<Feature> Features { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace netCore.Models
{
    public class Product
    {
       [System.ComponentModel.DataAnnotations.Key]
        public int Pk_Product_Id { get; set; }
        public string Brand { get; set; }
        public string ChangeDate { get; set; }
        public string Deeplink { get; set; }
        public string Description { get; set; }

        public virtual Feature Features { get; set; }
    }

}

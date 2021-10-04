using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        [Key]

        public int ProductID { get; set; }

        [ForeignKey("associatedCategory")]
        public int CategoryID { get; set; }

        public string Description { get; set; }

        public float UnitPrice { get; set; }

        public DateTime dateFirstIssued { get; set; }
        public int QuantityInStock { get; set; }

        public virtual Category associatedCategory { get; set; }
    }
}

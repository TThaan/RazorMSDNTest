using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorMSDNTest.Data
{
    public class RazorMSDNTestArt
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        [DataType(DataType.Date)]
        public DateTime ProductionDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime ZGPublishDate { get; set; }

        //public ZGUser Owner { get; set; }
        public decimal Price { get; set; }
        public bool ForSale { get; set; }
    }
}

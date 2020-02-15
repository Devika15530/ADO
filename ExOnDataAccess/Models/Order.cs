using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExOnDataAccess.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? OrderDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? DeliveryDate { get; set; }

        public int ItemId { get; set; }
        //navigation property
        [ForeignKey("ItemId")]
        public Item  items { get; set; }

    }
}

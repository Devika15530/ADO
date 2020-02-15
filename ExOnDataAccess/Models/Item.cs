using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExOnDataAccess.Models
{
    [Table("Item")]
  public  class Item
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        public string Itemname { get; set; }

        public int ItemPrice { get; set; }




    }
}

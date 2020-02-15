using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccesslayer.Models
{
    [Table(" Employee")]
  public   class Employee
    {
        [Key]//set primary key
        [StringLength(5)]
        public string EId { get; set; }
        [Required]
        public string Ename { get; set; }

        [Column(TypeName ="Date")]
        public DateTime? joinDate { get; set; }
        [StringLength(20)]
        public string Designation { get; set; }
        public decimal? salary { get; set; }

        public int ProjectId { get; set; }
        //navigation property
        [ForeignKey("ProjectId")]
        public Project Project { get; set; } 
    }
}

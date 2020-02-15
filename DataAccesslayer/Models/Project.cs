using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccesslayer.Models
{
    [Table("Project")]

   public  class Project
    {
        [Key]//set primary key
        public int ProjectId { get; set; }
        [Required]//set not null
        [StringLength(30)]
        public string ProjectName { get; set; }

        //set one  to many relation with employee

        [Column(TypeName = "Date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName="Date")]
        public DateTime? EndDate { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}





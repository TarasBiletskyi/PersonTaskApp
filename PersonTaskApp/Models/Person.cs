using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonTaskApp.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name  { get; set; }
        public string Surename { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }

        public string Task{ get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projet_Jdr.Models
{
    public class Token
    {
        [Key]
        public string Name { get; set; }
        public bool Status { get; set; }
        public int Value { get; set; }
    }
}
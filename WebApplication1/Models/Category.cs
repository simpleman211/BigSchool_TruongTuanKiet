using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
    
namespace WebApplication1.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Microsoft.Build.Framework.Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}